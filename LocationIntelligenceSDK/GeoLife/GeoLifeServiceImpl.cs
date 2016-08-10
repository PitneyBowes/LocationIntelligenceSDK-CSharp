#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.geolifeDemographics.model;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using com.pb.locationintelligence.common;
using System.Diagnostics;
using com.pb.locationintelligence.exception;
using com.pb.locationintelligence.geoLifeSegmentation.model;

namespace com.pb.locationintelligence.geolifeDemographics
{




    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geolifeDemographics.GeoLifeService" />
    public class GeoLifeServiceImpl : GeoLifeService
	{



        /// <summary>
        /// The geo lilfe URL
        /// </summary>
        private const string geoLilfeUrl = "/geolife/v1/demographics/";


        /// <summary>
        /// The segmentation URL
        /// </summary>
        private String segmentationURL = "/geolife/v1/segmentation/";

        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<WebResponseEventArgs<GeoLifeResponseDemographics>> LiAPIEventGeoLifeDemographics;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<WebResponseEventArgs<GeoLifeResponseSegmentation >> LiAPIEventGeoLifeSegmentation;



        #region V2 Demographics by Address


        /// <summary>
        /// Returns the geodemographic variables - age, gender, marital status, ethnicity, and household income
        /// based on an address provided
        /// </summary>
        /// <param name="address">Required - address text</param>
        /// <param name="country">The country.</param>
        /// <param name="profile">Optional - Pre-defined profiles sets. Below are the values:
        /// 'Top5Ascending': Retrieves the top 5 results in ascending order.
        /// 'Top5Descending': Retrieves the top 5 results in descending order.
        /// 'Top3Ascending': Retrieves the top 3 results in ascending order.
        /// 'Top3Descending': Retrieves the top 3 results in descending order</param>
        /// <param name="filter">Optional - Represents demographic themes to narrow down search results
        /// for example; AgeTheme, IncomeTheme, EthnicityTheme.
        /// Maximum number of themes that can be provided as a filter are 10.</param>
        /// <returns>
        /// GeoLifeResponse
        /// </returns>
        public GeoLifeResponseDemographics getDemographicsByAddress(String address, String country, String profile, String filter)
		{
            return Utility.processAPIRequest<GeoLifeResponseDemographics>(getDemographicsUrlforAddress(address, country, profile, filter), Utility.HttpVerb.Get, String.Empty);
		}

        /// <summary>
        /// Returns the geodemographic variables - age, gender, marital status, ethnicity, and household income
        /// based on an address provided Asynchronously . Event LiAPIRequestFinishedEvent gets raised when request finishes which
        /// contains response object.
        /// </summary>
        /// <param name="address">Required - address text</param>
        /// <param name="country">The country.</param>
        /// <param name="profile">Optional - Pre-defined profiles sets. Below are the values:
        /// 'Top5Ascending': Retrieves the top 5 results in ascending order.
        /// 'Top5Descending': Retrieves the top 5 results in descending order.
        /// 'Top3Ascending': Retrieves the top 3 results in ascending order.
        /// 'Top3Descending': Retrieves the top 3 results in descending order</param>
        /// <param name="filter">Optional - Represents demographic themes to narrow down search results
        /// for example; AgeTheme, IncomeTheme, EthnicityTheme.
        /// Maximum number of themes that can be provided as a filter are 10.</param>
        public void getDemographicsByAddressAsync( String address,  String country,  String  profile,  String filter) {
			processAPIRequestDelegate<GeoLifeResponseDemographics> delegateApiRequs = new processAPIRequestDelegate<GeoLifeResponseDemographics>(Utility.processAPIRequest<GeoLifeResponseDemographics>);
			delegateApiRequs.BeginInvoke(getDemographicsUrlforAddress(address, country, profile, filter), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallbackDemographics), null);

		}


        /// <summary>
        /// Gets the urlfor address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="country">The country.</param>
        /// <param name="profile">The profile.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        private string getDemographicsUrlforAddress(String address, String country, String profile, String filter)
        {
            urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoLilfeUrl));
            urlBuilder.Append("byaddress");
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("address", address);
            keyValueMap.Add("country", country);
            keyValueMap.Add("profile", profile);
            keyValueMap.Add("filter", filter);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

            return urlBuilder.ToString();
        }

        #endregion


        #region V2 Demographics by Location


        /// <summary>
        /// Returns the geodemographic variables - age, gender, marital status, ethnicity, and household income based on the location provided.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="profile">Optional - Pre-defined profiles sets. Below are the values:
        /// 'Top5Ascending': Retrieves the top 5 results in ascending order.
        /// 'Top5Descending': Retrieves the top 5 results in descending order.
        /// 'Top3Ascending': Retrieves the top 3 results in ascending order.
        /// 'Top3Descending': Retrieves the top 3 results in descending order</param>
        /// <param name="filter">Optional - Represents demographic themes to narrow down search results
        /// for example; AgeTheme, IncomeTheme, EthnicityTheme.
        /// Maximum number of themes that can be provided as a filter are 10.</param>
        /// <returns>
        /// GeoLifeResponse
        /// </returns>
        public GeoLifeResponseDemographics getDemographicsByLocation(Double latitude,Double longitude, String profile, String filter)
		{
			urlMaker = UrlMaker.getInstance();

			StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoLilfeUrl));
			urlBuilder.Append("bylocation");
			Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
			keyValueMap.Add("latitude", latitude);
			keyValueMap.Add("longitude", longitude);
			keyValueMap.Add("profile", profile);

			Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
			return Utility.processAPIRequest<GeoLifeResponseDemographics>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
		}



        /// <summary>
        /// Returns the geodemographic variables - age, gender, marital status, ethnicity,
        /// and household income based on the location provided  Asynchronously .Event LiAPIRequestFinishedEvent gets raised when request finishes which
        /// contains response object.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="profile">Optional - Pre-defined profiles sets. Below are the values:
        /// 'Top5Ascending': Retrieves the top 5 results in ascending order.
        /// 'Top5Descending': Retrieves the top 5 results in descending order.
        /// 'Top3Ascending': Retrieves the top 3 results in ascending order.
        /// 'Top3Descending': Retrieves the top 3 results in descending order</param>
        /// <param name="filter">Optional - Represents demographic themes to narrow down search results
        /// for example; AgeTheme, IncomeTheme, EthnicityTheme.
        /// Maximum number of themes that can be provided as a filter are 10.</param>
        public void getDemographicsByLocationAsync( Double latitude,  Double longitude,  String profile,  String filter) {
		   processAPIRequestDelegate<GeoLifeResponseDemographics> delegateApiRequs = new processAPIRequestDelegate<GeoLifeResponseDemographics>(Utility.processAPIRequest<GeoLifeResponseDemographics>);
		   delegateApiRequs.BeginInvoke(getDemographicsUrlforLocation(latitude,  longitude,  profile,  filter), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallbackDemographics), null);

		}


        /// <summary>
        /// Gets the urlfor location.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="profile">The profile.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        private string getDemographicsUrlforLocation(Double latitude, Double longitude, String profile, String filter)
        {
            urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoLilfeUrl));
            urlBuilder.Append("bylocation");
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("profile", profile);
            keyValueMap.Add("filter", filter);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

            return urlBuilder.ToString();
        }
        #endregion



        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackDemographics(IAsyncResult results)
		{

			AsyncResult result = (AsyncResult)results;

			processAPIRequestDelegate<GeoLifeResponseDemographics> del = (processAPIRequestDelegate<GeoLifeResponseDemographics>)result.AsyncDelegate;
			WebResponseEventArgs<GeoLifeResponseDemographics> webResponseEventArgs;

			try
			{
                Debug.WriteLine("GeoLife SDK Asynchronous function called ");
				GeoLifeResponseDemographics geoLifeResponse = del.EndInvoke(results);
				webResponseEventArgs = new WebResponseEventArgs<GeoLifeResponseDemographics>(geoLifeResponse, null);
                LiAPIEventGeoLifeDemographics.Invoke(this, webResponseEventArgs);

			}
			catch (SdkException sdkException)
			{
				webResponseEventArgs = new WebResponseEventArgs<GeoLifeResponseDemographics>(null, sdkException);
                LiAPIEventGeoLifeDemographics.Invoke(this, webResponseEventArgs);
				Trace.WriteLine(sdkException.Message);
			}

		}

        /// <summary>
        /// Gets the segmentation by address.
        /// </summary>
        /// <param name="address">Required - address text.</param>
        /// <param name="country">Optional - Country Code
        /// Acceptable list of country codes: USA,CAN,AUS,SWE,JPN,GBR.</param>
        /// <returns></returns>
        public GeoLifeResponseSegmentation getSegmentationByAddress(String address, String country)
        {

            String url = getSegmentationUrlforAddress(address, country);

            Debug.WriteLine("API URL : " + url);
            return Utility.processAPIRequest<GeoLifeResponseSegmentation>(url, Utility.HttpVerb.Get, String.Empty);
        }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        private string getSegmentationUrlforAddress(string address, string country)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(segmentationURL));
            urlBuilder.Append("byaddress");
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("address", address);
            keyValueMap.Add("country", country);


            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            return urlBuilder.ToString();
        }

        /// <summary>
        /// Gets the urlfor location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        /// <returns></returns>
        private string getSegmentationUrlforLocation(Double longitude, Double latitude)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(segmentationURL));
            urlBuilder.Append("bylocation");
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("latitude", latitude);


            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

            return urlBuilder.ToString();
        }



        /// <summary>
        /// Gets the segmentation by location.
        /// </summary>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <returns></returns>
        public GeoLifeResponseSegmentation getSegmentationByLocation(double longitude, double latitude)
        {

            return Utility.processAPIRequest<GeoLifeResponseSegmentation>(getSegmentationUrlforLocation(longitude, latitude), Utility.HttpVerb.Get, String.Empty);
        }




        /// <summary>
        /// Gets the segmentation by address asynchronous.
        /// </summary>
        /// <param name="address">Required - The address.</param>
        /// <param name="country">Optional -  The country.</param>
        public void getSegmentationByAddressAsync(string address, string country)
        {
            processAPIRequestDelegate<GeoLifeResponseSegmentation> delegateApiRequest = new processAPIRequestDelegate<GeoLifeResponseSegmentation>(Utility.processAPIRequest<GeoLifeResponseSegmentation>);
            delegateApiRequest.BeginInvoke(getSegmentationUrlforAddress(address, country), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallbackSegmentaton), null);

        }


        /// <summary>
        /// Gets the segmentation by location asynchronous.
        /// </summary>
        /// <param name="longitude">Required - The longitude.</param>
        /// <param name="latitude">Required - The latitude.</param>
        public void getSegmentationByLocationAsync(double longitude, double latitude)
        {

            processAPIRequestDelegate<GeoLifeResponseSegmentation> delegateApiRequest = new processAPIRequestDelegate<GeoLifeResponseSegmentation>(Utility.processAPIRequest<GeoLifeResponseSegmentation>);
            delegateApiRequest.BeginInvoke(getSegmentationUrlforLocation(longitude, latitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallbackSegmentaton), null);

        }


        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackSegmentaton(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<GeoLifeResponseSegmentation> del = (processAPIRequestDelegate<GeoLifeResponseSegmentation>)result.AsyncDelegate;
            WebResponseEventArgs<GeoLifeResponseSegmentation> webResponseEventArgs;

            try
            {
                Debug.WriteLine("Locations SDK Asynchronous function called ");
                GeoLifeResponseSegmentation segmentation = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<GeoLifeResponseSegmentation>(segmentation, null);
                LiAPIEventGeoLifeSegmentation.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<GeoLifeResponseSegmentation>(null, sdkException);
                LiAPIEventGeoLifeSegmentation.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }
      
    }
}

