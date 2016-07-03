#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.geolife.model;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using com.pb.locationintelligence.common;
using System.Diagnostics;
using com.pb.locationintelligence.exception;

namespace com.pb.locationintelligence.geolife
{



   
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geolife.GeoLifeService" />
    public class GeoLifeServiceImpl : GeoLifeService
	{



        /// <summary>
        /// The geo lilfe URL
        /// </summary>
        private const string geoLilfeUrl = "/geolife/v1/demographics/";
        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<WebResponseEventArgs<GeoLifeResponse>> LiAPIRequestFinishedEvent;

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
        public GeoLifeResponse getDemographicsByAddress(String address, String country, String profile, String filter)
		{
            return Utility.processAPIRequest<GeoLifeResponse>(getUrlforAddress(address, country, profile, filter), Utility.HttpVerb.Get, String.Empty);
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
			processAPIRequestDelegate<GeoLifeResponse> delegateApiRequs = new processAPIRequestDelegate<GeoLifeResponse>(Utility.processAPIRequest<GeoLifeResponse>);
			delegateApiRequs.BeginInvoke(getUrlforAddress(address, country, profile, filter), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

		}


        /// <summary>
        /// Gets the urlfor address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="country">The country.</param>
        /// <param name="profile">The profile.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        private string getUrlforAddress(String address, String country, String profile, String filter)
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
        public GeoLifeResponse getDemographicsByLocation(Double latitude,Double longitude, String profile, String filter)
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
			return Utility.processAPIRequest<GeoLifeResponse>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
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
		   processAPIRequestDelegate<GeoLifeResponse> delegateApiRequs = new processAPIRequestDelegate<GeoLifeResponse>(Utility.processAPIRequest<GeoLifeResponse>);
		   delegateApiRequs.BeginInvoke(getUrlforLocation(latitude,  longitude,  profile,  filter), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

		}


        /// <summary>
        /// Gets the urlfor location.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="profile">The profile.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        private string getUrlforLocation(Double latitude, Double longitude, String profile, String filter)
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
        void WorkflowCompletedCallback(IAsyncResult results)
		{

			AsyncResult result = (AsyncResult)results;

			processAPIRequestDelegate<GeoLifeResponse> del = (processAPIRequestDelegate<GeoLifeResponse>)result.AsyncDelegate;
			WebResponseEventArgs<GeoLifeResponse> webResponseEventArgs;

			try
			{
                Debug.WriteLine("GeoLife SDK Asynchronous function called ");
				GeoLifeResponse geoLifeResponse = del.EndInvoke(results);
				webResponseEventArgs = new WebResponseEventArgs<GeoLifeResponse>(geoLifeResponse, null);
				LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

			}
			catch (SdkException sdkException)
			{
				webResponseEventArgs = new WebResponseEventArgs<GeoLifeResponse>(null, sdkException);
				LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
				Trace.WriteLine(sdkException.Message);
			}

		}
		

	   

	}
}

