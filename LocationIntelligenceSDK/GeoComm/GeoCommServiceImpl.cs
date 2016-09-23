#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.geocomm.model;
using com.pb.locationintelligence.utils;
using com.pb.locationintelligence.exception;

namespace com.pb.locationintelligence.geocomm
{

    public class GeoCommServiceImpl : GeoCommService
    {

        /// <summary>
        /// The geoComm URL
        /// </summary>
        private static readonly String geoCommURL = "/geocomm/v1/";

        private const String RATE_CENTER_DEFAULT_COUNTRY = "USA";

        private const String RATE_CENTER_DEFAULT_LEVEL = "basic";


        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;

        /// <summary>
        /// This event is Raised Asynchronously when web response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<WebResponseEventArgs<RateCenterResponse>> LiAPIRequestFinishedEvent;


        /// <summary>
        /// Gets the geocomm ratecenter response.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="country">country.</param>
        /// <param name="requestAreaCodeInfo">requestAreaCodeInfo</param>
        /// <param name="level">level</param>
        /// <returns>RateCenterResponse</returns>
        public RateCenterResponse getRateCenterByAddress(String address, String country = RATE_CENTER_DEFAULT_COUNTRY, Boolean requestAreaCodeInfo = false, String level = RATE_CENTER_DEFAULT_LEVEL)
        {
            return Utility.processAPIRequest<RateCenterResponse>(getURLForRateCenterByAddress(address,country,requestAreaCodeInfo,level), Utility.HttpVerb.Get, String.Empty);
        }

        /// <summary>
        /// Gets the geocomm ratecenter response.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="country">country.</param>
        /// <param name="requestAreaCodeInfo">requestAreaCodeInfo</param>
        /// <param name="level">level</param>
        /// <returns>RateCenterResponse</returns>
        public void getRateCenterByAddressAsync(String address, String country = RATE_CENTER_DEFAULT_COUNTRY, Boolean requestAreaCodeInfo = false, String level = RATE_CENTER_DEFAULT_LEVEL)
        {
            processAPIRequestDelegate<RateCenterResponse> delegateApiRequs = new processAPIRequestDelegate<RateCenterResponse>(Utility.processAPIRequest<RateCenterResponse>);
            delegateApiRequs.BeginInvoke(getURLForRateCenterByAddress(address, country, requestAreaCodeInfo, level), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
        }

        /// <summary>
        /// Gets the geocomm ratecenter response.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="requestAreaCodeInfo">requestAreaCodeInfo</param>
        /// <param name="level">level</param>
        /// <returns>RateCenterResponse</returns>
        public RateCenterResponse getRateCenterByLocation(Double latitude, Double longitude, Boolean requestAreaCodeInfo = false, String level = RATE_CENTER_DEFAULT_LEVEL) {
            return Utility.processAPIRequest<RateCenterResponse>(getURLForRateCenterByLocation(latitude, longitude, requestAreaCodeInfo, level), Utility.HttpVerb.Get, String.Empty);
        }

        /// <summary>
        /// Gets the geocomm ratecenter response.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="requestAreaCodeInfo">requestAreaCodeInfo</param>
        /// <param name="level">level</param>
        /// <returns></returns>
        public void getRateCenterByLocationAsync(Double latitude, Double longitude, Boolean requestAreaCodeInfo = false, String level = RATE_CENTER_DEFAULT_LEVEL)
        {
            processAPIRequestDelegate<RateCenterResponse> delegateApiRequs = new processAPIRequestDelegate<RateCenterResponse>(Utility.processAPIRequest<RateCenterResponse>);
            delegateApiRequs.BeginInvoke(getURLForRateCenterByLocation(latitude, longitude, requestAreaCodeInfo, level), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
        }


        /// <summary>
        /// Gets the urlfor geocomm ratecenter by address.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="country">country.</param>
        /// <param name="requestAreaCodeInfo">requestAreaCodeInfo</param>
        /// <param name="level">level</param>
        /// <returns></returns>
        private string getURLForRateCenterByAddress(String address, String country, Boolean areaCodeInfo, String level)
        {
            urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoCommURL));
            urlBuilder.Append("ratecenter/").Append("byaddress");

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("address", address);
            keyValueMap.Add("country", country);
            keyValueMap.Add("areaCodeInfo", areaCodeInfo);
            keyValueMap.Add("level", level);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

            return urlBuilder.ToString();
        }

        /// <summary>
        /// Gets the urlfor geocomm ratecenter by location.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="requestAreaCodeInfo">requestAreaCodeInfo</param>
        /// <param name="level">level</param>
        /// <returns></returns>
        private string getURLForRateCenterByLocation(Double latitude, Double longitude, Boolean areaCodeInfo, String level)
        {

            urlMaker = UrlMaker.getInstance();

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geoCommURL));
            urlBuilder.Append("ratecenter/").Append("bylocation");

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            keyValueMap.Add("areaCodeInfo", areaCodeInfo);
            keyValueMap.Add("level", level);

            Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

            return urlBuilder.ToString();
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallback(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<RateCenterResponse> del = (processAPIRequestDelegate<RateCenterResponse>)result.AsyncDelegate;
            WebResponseEventArgs<RateCenterResponse> webResponseEventArgs;

            try
            {
                Debug.WriteLine("GeoComm SDK Asynchronous function called ");
                RateCenterResponse rateCenterResponse = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<RateCenterResponse>(rateCenterResponse, null);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<RateCenterResponse>(null, sdkException);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }

        }
    }
}