﻿#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.common.model;
using com.pb.locationintelligence.exception;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Text;
namespace com.pb.locationintelligence.geoenhance
{

    /**
     * GeoEnhanceService Implementation Class
     *
     */

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geoenhance.GeoEnhanceService" />
    public class GeoEnhanceServiceImpl : GeoEnhanceService
    {
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<Locations>> LiAPIRequestFinishedEvent;
        /// <summary>
        /// Occurs when [li time zone API request finished event].
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<TimezoneResponse>> LiTimeZoneAPIRequestFinishedEvent;


        /// <summary>
        /// The geo enahnceh URL
        /// </summary>
        private String geoEnahncehURL = "/geoenhance/v1/";

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoEnhanceServiceImpl"/> class.
        /// </summary>
        public GeoEnhanceServiceImpl()
        {

           
            
        }

        #region Address
        /// <summary>
        /// Accepts longitude and latitude and returns an Address for that location.
        /// </summary>
        /// <param name="latitude">Required - Latitude of the location.</param>
        /// <param name="longitude">Required - Longitude of the location.</param>
        /// <param name="searchRadius">Optional - Search Radius, in feet. Default Value is 150 feet,
        /// Allowed range is 0- 5280 feet.</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        /// <returns>
        /// Locations
        /// </returns>
        public Locations getAddress(Double latitude, Double longitude, float? searchRadius, String searchRadiusUnit)
        {
            return Utility.processAPIRequest<Locations>(getUrlforAddress(latitude, longitude, searchRadius, searchRadiusUnit),Utility.HttpVerb.Get,String.Empty);
        }

        /// <summary>
        /// Accepts longitude and latitude and returns an Address for that location in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="latitude">Required - Latitude of the location.</param>
        /// <param name="longitude">Required - Longitude of the location.</param>
        /// <param name="searchRadius">Optional - Search Radius, in feet. Default Value is 150 feet,
        /// Allowed range is 0- 5280 feet.</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        public void getAddressAsync(double latitude, double longitude, float? searchRadius, string searchRadiusUnit)
        {
            processAPIRequestDelegate<Locations> delegateApiRequs = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequs.BeginInvoke(getUrlforAddress(latitude, longitude, searchRadius, searchRadiusUnit), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

        }

        /// <summary>
        /// Gets the urlfor address.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="searchRadius">The search radius.</param>
        /// <param name="searchRadiusUnit">The search radius unit.</param>
        /// <returns></returns>
        private string getUrlforAddress(double latitude, double longitude, float? searchRadius, string searchRadiusUnit)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoEnahncehURL));
            urlBuilder.Append("address/bylocation");

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return urlBuilder.ToString();
        }

        #endregion


        #region Place
        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets the place information.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="levelHint">Optional - Level of Information. Below are the numeric codes
        /// for geographic hierarchy level: LEVEL 1 = Country LEVEL 2 =
        /// State or equivalent LEVEL 3 = District or equivalent LEVEL 4
        /// =City or Town LEVEL 5 = Locality LEVEL 6 = Neighbourhood If
        /// not provided, returns the lowest geographic hierarchy level
        /// information available
        /// .</param>
        /// <returns>
        /// Locations
        /// </returns>
        public Locations getPlace(Double latitude, Double longitude, int? levelHint)
        {
           
            return Utility.processAPIRequest<Locations>(getUrlforPlace( latitude,  longitude,  levelHint), Utility.HttpVerb.Get, String.Empty);
        }

        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets the place information in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="levelHint">Optional - Level of Information. Below are the numeric codes
        /// for geographic hierarchy level: LEVEL 1 = Country LEVEL 2 =
        /// State or equivalent LEVEL 3 = District or equivalent LEVEL 4
        /// =City or Town LEVEL 5 = Locality LEVEL 6 = Neighbourhood If
        /// not provided, returns the lowest geographic hierarchy level
        /// information available
        /// .</param>
        public void getPlaceAsync(Double latitude, Double longitude, int? levelHint)
        {

            processAPIRequestDelegate<Locations> delegateApiRequs = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequs.BeginInvoke(getUrlforPlace(latitude, longitude, levelHint), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

        }

        /// <summary>
        /// Gets the urlfor place.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="levelHint">The level hint.</param>
        /// <returns></returns>
        private string getUrlforPlace(Double latitude, Double longitude, int? levelHint)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoEnahncehURL));
            urlBuilder.Append("place/bylocation");

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("levelHint", levelHint);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return urlBuilder.ToString();
        }


        #endregion


        #region POI
        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets Point of Interests (POI) information.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="category">Optional - Category or Sub-Category to refine the POI search
        /// results.</param>
        /// <param name="maxCandidates">Optional - Maximum number of POIs that will be returned
        /// Default is 10</param>
        /// <param name="searchRadius">Optional - Search Radius, in miles. Default Value is 2 miles,
        /// Allowed range is 0-50 miles</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        /// <param name="searchDataset">Optional - Comma-separated input of dataSet names ('PBData'
        /// for searching in PB Data)..</param>
        /// <param name="searchPriority">Optional - Define priority while searching on DataSets.
        /// Allowed values are Y/N..</param>
        /// <returns>
        /// Locations
        /// </returns>
        public Locations getPOI(Double latitude, Double longitude, String category, int? maxCandidates, float? searchRadius, String searchRadiusUnit, String searchDataset, String searchPriority)
        {
            
            return Utility.processAPIRequest<Locations>(getUrlforPOI(latitude,longitude, category, maxCandidates, searchRadius, searchRadiusUnit, searchDataset, searchPriority), Utility.HttpVerb.Get, String.Empty);
        }

        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets Point of Interests (POI) information in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="category">Optional - Category or Sub-Category to refine the POI search
        /// results.</param>
        /// <param name="maxCandidates">Optional - Maximum number of POIs that will be returned
        /// Default is 10</param>
        /// <param name="searchRadius">Optional - Search Radius, in miles. Default Value is 2 miles,
        /// Allowed range is 0-50 miles</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        /// <param name="searchDataset">Optional - Comma-separated input of dataSet names ('PBData'
        /// for searching in PB Data)..</param>
        /// <param name="searchPriority">Optional - Define priority while searching on DataSets.
        /// Allowed values are Y/N..</param>
        public void getPOIAsync(Double latitude, Double longitude, String category, int? maxCandidates, float? searchRadius, String searchRadiusUnit, String searchDataset, String searchPriority)
        {

            processAPIRequestDelegate<Locations> delegateApiRequs = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequs.BeginInvoke(getUrlforPOI(latitude, longitude, category, maxCandidates, searchRadius, searchRadiusUnit, searchDataset, searchPriority), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

        }

        /// <summary>
        /// Gets the urlfor poi.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="category">The category.</param>
        /// <param name="maxCandidates">The maximum candidates.</param>
        /// <param name="searchRadius">The search radius.</param>
        /// <param name="searchRadiusUnit">The search radius unit.</param>
        /// <param name="searchDataset">The search dataset.</param>
        /// <param name="searchPriority">The search priority.</param>
        /// <returns></returns>
        private string getUrlforPOI(Double latitude, Double longitude, String category, int? maxCandidates, float? searchRadius, String searchRadiusUnit, String searchDataset, String searchPriority)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoEnahncehURL));
            urlBuilder.Append("poi/bylocation");

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("category", category);
            keyValueMap.Add("maxCandidates", maxCandidates);
            keyValueMap.Add("searchRadius", searchRadius);
            keyValueMap.Add("searchRadiusUnit", searchRadiusUnit);
            keyValueMap.Add("searchDataset", searchDataset);
            keyValueMap.Add("searchPriority", searchPriority);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return urlBuilder.ToString();
        }
        #endregion

        #region TimezoneResponse
        /// <summary>
        /// Accepts latitude , longitude and timestamp and returns the timezone information applicable including
        /// utcoffset and dstoffset.
        /// </summary>
        /// <param name="timestamp">Required - timestamp in UTC milliseconds
        /// returns the TimezoneResponse information applicable at the given timestamp at the specific location
        /// .</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>
        /// TimezoneResponse
        /// </returns>
        public TimezoneResponse getTimezone(long timestamp,Double latitude, Double longitude)
        {

            TimezoneResponse timezone = Utility.processAPIRequest<TimezoneResponse>(getUrlforTimezone(timestamp,latitude, longitude), Utility.HttpVerb.Get, String.Empty);
            return timezone;
        }

        /// <summary>
        /// Accepts latitude , longitude and timestamp information and gets the applicable timezone information
        /// including utcoffset and dstoffset.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="timestamp">Required - timestamp in UTC milliseconds
        /// returns the TimezoneResponse information applicable at the given timestamp at the specific timestamp
        /// .</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        public void getTimezoneAsync(long timestamp,Double latitude, Double longitude)
        {

            processAPIRequestDelegate<TimezoneResponse> delegateApiRequs = new processAPIRequestDelegate<TimezoneResponse>(Utility.processAPIRequest<TimezoneResponse>);
            delegateApiRequs.BeginInvoke(getUrlforTimezone(timestamp,latitude, longitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowTimezoneCompletedCallback), null);

        }

        /// <summary>
        /// Gets the urlfor timezone.
        /// </summary>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns></returns>
        private string getUrlforTimezone(long timestamp,Double latitude, Double longitude)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoEnahncehURL));
            urlBuilder.Append("timezone/bylocation");

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("timestamp", timestamp);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
            return urlBuilder.ToString();
        }

        /// <summary>
        /// Workflows the timezone completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowTimezoneCompletedCallback(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<TimezoneResponse> del = (processAPIRequestDelegate<TimezoneResponse>)result.AsyncDelegate;
            WebResponseEventArgs<TimezoneResponse> webResponseEventArgs;

            try
            {
                TimezoneResponse timeZoneResponse = new TimezoneResponse();
                TimezoneResponse timezone = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<TimezoneResponse>(timeZoneResponse, null);
                LiTimeZoneAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                Debug.WriteLine("GeoEnhace Asynchronous function called  ");
            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<TimezoneResponse>(null, sdkException);
                LiTimeZoneAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }

        }

        #endregion

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
                Locations locations = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<Locations>(locations, null);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                Debug.WriteLine("GeoEnhace Asynchronous function called  ");
            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<Locations>(null, sdkException);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                
            }

        }
    }
}
