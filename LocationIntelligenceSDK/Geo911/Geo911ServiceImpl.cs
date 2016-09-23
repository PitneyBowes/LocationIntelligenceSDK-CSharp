#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.geo911.model;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.exception;
using System.Diagnostics;
namespace com.pb.locationintelligence.geo911
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geo911.Geo911Service" />
    public class Geo911ServiceImpl : Geo911Service  {


        /// <summary>
        /// The geo911 URL
        /// </summary>
        private String geo911Url = "/geo911/v1/psap/";

        /// <summary>
        /// The geo911 ahj URL
        /// </summary>
        private String geo911AHJUrl = "/geo911/v1/ahj-psap/";

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<PsapResponse>> LiAPIRequestFinishedEvent;
        /// <summary>
        /// Occurs when [li apiahj plus psas request finished event].
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<AHJPlusPSAPResponse>> LiAPIAHJPlusPSASRequestFinishedEvent;

        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details.
        /// Accepts the address as input and returns PSAP locations' details
        /// including agency name, phone number, county name, coverage, contact person's
        /// details, site details and mailing address
        /// </summary>
        /// <param name="address">Required - Free-form address text.</param>
        /// <returns>
        /// PsapResponse
        /// </returns>
        public PsapResponse getPSAPByAddress(String address)  {
        return Utility.processAPIRequest<PsapResponse>(getUrlForAddress(address),Utility.HttpVerb.Get,String.Empty);
    }


        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// Accepts the address as input and returns PSAP locations' details
        /// including agency name, phone number, county name, coverage, contact person's
        /// details, site details and mailing address
        /// </summary>
        /// <param name="address">Required - Free-form address text.</param>
        public void getPSAPByAddressAsync(String address)
    {
        processAPIRequestDelegate<PsapResponse> delegateApiRequest = new processAPIRequestDelegate<PsapResponse>(Utility.processAPIRequest<PsapResponse>);
        delegateApiRequest.BeginInvoke(getUrlForAddress(address), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
    }

        /// <summary>
        /// Gets the URL for address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        private String getUrlForAddress(String address)
    {
        UrlMaker urlMaker = UrlMaker.getInstance();
        StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geo911Url));
        urlBuilder.Append("byaddress");
        Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
        keyValueMap.Add("address", address);
        Utility.appendIfNotNull(urlBuilder, keyValueMap);
        return urlBuilder.ToString();
    }

        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// Accepts latitude and longitude co-ordinates as input and returns PSAP locations' details in Async Mode
        /// including agency name, including agency name, phone number, county name, coverage,
        /// contact person's details, site details and mailing address.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        public void getPSAPByLocationAsync(Double latitude, Double longitude)  {
        processAPIRequestDelegate<PsapResponse> delegateApiRequest = new processAPIRequestDelegate<PsapResponse>(Utility.processAPIRequest<PsapResponse>);
        delegateApiRequest.BeginInvoke(getUrlForLocation(latitude, longitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
 
    }


        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details.
        /// Accepts latitude and longitude co-ordinates as input and returns PSAP locations' details
        /// including agency name, including agency name, phone number, county name, coverage,
        /// contact person's details, site details and mailing address.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>
        /// PsapResponse
        /// </returns>
        public PsapResponse getPSAPByLocation(Double latitude, Double longitude)
    {
        return Utility.processAPIRequest<PsapResponse>(getUrlForLocation(latitude, longitude), Utility.HttpVerb.Get, String.Empty);
    }

        /// <summary>
        /// Gets the URL for location.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns></returns>
        private String getUrlForLocation(Double latitude, Double longitude)
    {
        UrlMaker urlMaker = UrlMaker.getInstance();
        StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geo911AHJUrl));
        urlBuilder.Append("bylocation");
        Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
        keyValueMap.Add("latitude", latitude);
        keyValueMap.Add("longitude", longitude);
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
        processAPIRequestDelegate<PsapResponse> del = (processAPIRequestDelegate<PsapResponse>)result.AsyncDelegate;
        WebResponseEventArgs<PsapResponse> webResponceEventArgs;
        try
        {
            Debug.WriteLine("Geo911 SDK Asynchronous function called ");
            PsapResponse psapResponse = del.EndInvoke(results);
            webResponceEventArgs = new WebResponseEventArgs<PsapResponse>(psapResponse, null);
            LiAPIRequestFinishedEvent.Invoke(this, webResponceEventArgs);
        }
        catch (SdkException sdkException)
        {
            webResponceEventArgs = new WebResponseEventArgs<PsapResponse>(null, sdkException);
            LiAPIRequestFinishedEvent.Invoke(this, webResponceEventArgs);
            Trace.WriteLine(sdkException.Message);
        }

    }


        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedAHJCallback(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<AHJPlusPSAPResponse> del = (processAPIRequestDelegate<AHJPlusPSAPResponse>)result.AsyncDelegate;
            WebResponseEventArgs<AHJPlusPSAPResponse> webResponceEventArgs;
            try
            {
                Debug.WriteLine("Geo911 SDK Asynchronous function called ");
                AHJPlusPSAPResponse aHJPlusPSAPResponse = del.EndInvoke(results);
                webResponceEventArgs = new WebResponseEventArgs<AHJPlusPSAPResponse>(aHJPlusPSAPResponse, null);
                LiAPIAHJPlusPSASRequestFinishedEvent.Invoke(this, webResponceEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponceEventArgs = new WebResponseEventArgs<AHJPlusPSAPResponse>(null, sdkException);
                LiAPIAHJPlusPSASRequestFinishedEvent.Invoke(this, webResponceEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }


        /// <summary>
        /// Gets the URL for ahj address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        public string getUrlForAHJAddress(string address)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geo911AHJUrl));
            urlBuilder.Append("byaddress");
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("address", address);
            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            Debug.WriteLine("API URL : " + urlBuilder);
            return urlBuilder.ToString();
        }

        /// <summary>
        /// Gets the URL for ahj location.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns></returns>
        public string getUrlForAHJLocation(Double latitude, Double longitude)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geo911AHJUrl));
            urlBuilder.Append("bylocation");
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", latitude);
            keyValueMap.Add("longitude", longitude);
            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            Debug.WriteLine("API URL : " + urlBuilder);
            return urlBuilder.ToString();
        }


        /// <summary>
        /// Gets the ahj plus psap by address asynchronous.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void getAHJPlusPSAPByAddressAsync(string address)
        {
            processAPIRequestDelegate<AHJPlusPSAPResponse> delegateApiRequest = new processAPIRequestDelegate<AHJPlusPSAPResponse>(Utility.processAPIRequest<AHJPlusPSAPResponse>);
            delegateApiRequest.BeginInvoke(getUrlForAHJAddress(address), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedAHJCallback), null);
        }

        /// <summary>
        /// Gets the ahj plus psap by location.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns></returns>
        public AHJPlusPSAPResponse getAHJPlusPSAPByLocation(double latitude, double longitude)
        {
            return Utility.processAPIRequest<AHJPlusPSAPResponse>(getUrlForLocation(latitude, longitude), Utility.HttpVerb.Get, String.Empty);
        }

        /// <summary>
        /// Gets the ahj plus psap by location asynchronous.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void getAHJPlusPSAPByLocationAsync(double latitude, double longitude)
        {
            processAPIRequestDelegate<AHJPlusPSAPResponse> delegateApiRequest = new processAPIRequestDelegate<AHJPlusPSAPResponse>(Utility.processAPIRequest<AHJPlusPSAPResponse>);
            delegateApiRequest.BeginInvoke(getUrlForAHJLocation(latitude, longitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedAHJCallback), null);

        }

        /// <summary>
        /// Gets the ahj plus psap by address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        public AHJPlusPSAPResponse getAHJPlusPSAPByAddress(string address)
        {
            return Utility.processAPIRequest<AHJPlusPSAPResponse>(getUrlForAHJAddress(address), Utility.HttpVerb.Get, String.Empty);
        }
    }
}
