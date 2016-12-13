#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.common.model;
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.exception;

using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace com.pb.locationintelligence.geosearch
{
    /**
     * GeoSearchService Implementation Class
     *
     */
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geosearch.GeoSearchService" />
    public class GeoSearchServiceImpl : GeoSearchService
    {



        /// <summary>
        /// The geo search URL
        /// </summary>
        private String geoSearchURL = "/geosearch/v1/locations";

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<Locations>> LiAPIRequestFinishedEvent;

        /// <summary>
        /// Geoes the search.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <param name="latitude">The origin latitude.</param>
        /// <param name="longitude">The origin longitude.</param>
        /// <returns></returns>
        public Locations geoSearch(String searchText, Double latitude, Double longitude)
        {

            String url = getUrl(searchText, latitude, longitude);

            Debug.WriteLine("API URL : " + url);
            return Utility.processAPIRequest<Locations>(url, Utility.HttpVerb.Get, String.Empty);
        }

		
		 public Locations geoSearch(String searchText,String country,
                               Double latitude, Double longitude)
							   {
								   
								   UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return Utility.processAPIRequest<Locations>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
								   
								   
							   }
							   
							   
							   
							   
		public Locations geoSearch(String searchText,String country)
		{
			 UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            
            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return Utility.processAPIRequest<Locations>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
			
		}
        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns></returns>
        private String getUrl(String searchText, Double latitude, Double longitude)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            return urlBuilder.ToString();
        }


        /// <summary>
        /// Accepts searchText , latitude ,longitude,searchRadius,searchRadiusUnit and maxCandidates information and
        /// gets the Locations information .
        /// </summary>
        /// <param name="searchText">Mandatory - The input to be searched.</param>
        /// <param name="latitude">Mandatory - The latitude of the location.</param>
        /// <param name="longitude">Mandatory - The longitude of the location.</param>
        /// <param name="searchRadius">Optional - The radius from the given co-ordinates in which to
        /// search for results.</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius.The acceptable unit
        /// values are: Feet, Kilometers, Miles and Meters. The
        /// searchRadiusUnit is optional, if not provided; the Feet
        /// value is taken by default. The specified values are
        /// case-insensitive.</param>
        /// <param name="maxCandidates">Optional - Maximum number of results to return.</param>
        /// <returns>
        /// Locations
        /// </returns>
        public Locations geoSearch(String searchText, Double latitude, Double longitude, float? searchRadius, String searchRadiusUnit, int? maxCandidates)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("maxCandidates", maxCandidates);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return Utility.processAPIRequest<Locations>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
        }
		
		
		
		public Locations geoSearch(String searchText,String country,
                               Double latitude, Double longitude,
                               float? searchRadius, String searchRadiusUnit,
                               int?  maxCandidates)
							   {
								   
								    UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("maxCandidates", maxCandidates);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return Utility.processAPIRequest<Locations>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
								   
								   
								   
							   }

        public Locations geoSearch(String searchText,String country,
            float? searchRadius, String searchRadiusUnit,
            int?  maxCandidates)
			{
				
				 UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("maxCandidates", maxCandidates);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return Utility.processAPIRequest<Locations>(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty);
				
				
				
			}



        /**
     * Retrieves Geo Search results
     * 
     * @param searchText
     *            Mandatory - The input to be searched
     * @param originoriginLatitude
     *            Mandatory - The latitude of the location
     * @param originoriginLongitude
     *            Mandatory - The longitude of the location
     * @return {@link Locations}
     */
        /// <summary>
        /// Accepts searchText , latitude and longitude information and gets the Locations information in Asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="searchText">Mandatory - The input to be searched.</param>
        /// <param name="latitude">Mandatory - The latitude of the location.</param>
        /// <param name="longitude">Mandatory - The longitude of the location.</param>
        public void geoSearchAsync(String searchText,
                             Double latitude, Double longitude)
        {
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(getUrl(searchText, latitude, longitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

        }

		 public void geoSearchAsync(String searchText,String country,
                               Double latitude, Double longitude)
							   {
								   UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            
           

            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
							   }

        public  void geoSearchAsync(String searchText,String country)
		 {

            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            
            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
		 }
        /// <summary>
        /// Accepts searchText , latitude ,longitude,searchRadius,searchRadiusUnit and maxCandidates information and gets the Locations information in Asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="searchText">Mandatory - The input to be searched.</param>
        /// <param name="latitude">Mandatory - The latitude of the location.</param>
        /// <param name="longitude">Mandatory - The longitude of the location.</param>
        /// <param name="searchRadius">Optional - The radius from the given co-ordinates in which to
        /// search for results.</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius.The acceptable unit
        /// values are: Feet, Kilometers, Miles and Meters. The
        /// searchRadiusUnit is optional, if not provided; the Feet
        /// value is taken by default. The specified values are
        /// case-insensitive.</param>
        /// <param name="maxCandidates">Optional - Maximum number of results to return.</param>
        public void geoSearchAsync(String searchText,
                         Double latitude, Double longitude,
                         float? searchRadius, String searchRadiusUnit,
                         int? maxCandidates)
        {

            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("maxCandidates", maxCandidates);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

        }



        public void geoSearchAsync(String searchText,String country,
                               Double latitude, Double longitude,
                               float? searchRadius, String searchRadiusUnit,
                               int?  maxCandidates)
							   {
	  UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
			keyValueMap.Add("country", country);
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("maxCandidates", maxCandidates);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);							   
							   
							   
							   
							   
							   }




        public void geoSearchAsync(String searchText,String country,
            float? searchRadius, String searchRadiusUnit,
            int?  maxCandidates)
			{
				
	  UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoSearchURL));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("searchText", searchText);
            keyValueMap.Add("country", country);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("maxCandidates", maxCandidates);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);		
			
			
			}
			
        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallback(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<Locations> del = (processAPIRequestDelegate<Locations>)result.AsyncDelegate;
            WebResponseEventArgs<Locations> webResponseEventArgs;

            try
            {
                Debug.WriteLine("Locations SDK Asynchronous function called ");
                Locations geoSearch = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<Locations>(geoSearch, null);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<Locations>(null, sdkException);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }
    }
}