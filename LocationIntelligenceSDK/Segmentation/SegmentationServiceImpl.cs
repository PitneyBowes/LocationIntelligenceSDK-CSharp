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
using com.pb.locationintelligence.segmentation.model;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Text;
namespace com.pb.locationintelligence.segmentation
{


    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.segmentation.SegmentationService" />
    public class SegmentationServiceImpl :SegmentationService 
{



        /// <summary>
        /// The segmentation URL
        /// </summary>
        private String segmentationURL = "/geolife/v1/segmentation/";

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<Segmentation>> LiAPIRequestFinishedEvent;


        /// <summary>
        /// Gets the segmentation by address.
        /// </summary>
        /// <param name="address">Required - address text.</param>
        /// <param name="country">Optional - Country Code
        /// Acceptable list of country codes: USA,CAN,AUS,SWE,JPN,GBR.</param>
        /// <returns></returns>
        public Segmentation getSegmentationByAddress(String address, String country)
    {

        String url = getUrl(address, country);

        Debug.WriteLine("API URL : " + url);
        return Utility.processAPIRequest<Segmentation>(url, Utility.HttpVerb.Get, String.Empty);
    }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        private string getUrl(string address, string country)
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
        private string getUrlforLocation(Double longitude, Double latitude)
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
        public Segmentation getSegmentationByLocation(double longitude, double latitude)
    {

        return Utility.processAPIRequest<Segmentation>(getUrlforLocation(longitude, latitude), Utility.HttpVerb.Get, String.Empty);
    }




        /// <summary>
        /// Gets the segmentation by address asynchronous.
        /// </summary>
        /// <param name="address">Required - The address.</param>
        /// <param name="country">Optional -  The country.</param>
        void SegmentationService.getSegmentationByAddressAsync(string address, string country)
    {
        processAPIRequestDelegate<Segmentation> delegateApiRequest = new processAPIRequestDelegate<Segmentation>(Utility.processAPIRequest<Segmentation>);
        delegateApiRequest.BeginInvoke(getUrl(address, country), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

    }


        /// <summary>
        /// Gets the segmentation by location asynchronous.
        /// </summary>
        /// <param name="longitude">Required - The longitude.</param>
        /// <param name="latitude">Required - The latitude.</param>
        void SegmentationService.getSegmentationByLocationAsync(double longitude, double latitude)
    {

        processAPIRequestDelegate<Segmentation> delegateApiRequest = new processAPIRequestDelegate<Segmentation>(Utility.processAPIRequest<Segmentation>);
        delegateApiRequest.BeginInvoke(getUrlforLocation(longitude, latitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

    }


        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallback(IAsyncResult results)
    {

        AsyncResult result = (AsyncResult)results;

        processAPIRequestDelegate<Segmentation> del = (processAPIRequestDelegate<Segmentation>)result.AsyncDelegate;
        WebResponseEventArgs<Segmentation> webResponseEventArgs;

        try
        {
            Debug.WriteLine("Locations SDK Asynchronous function called ");
            Segmentation segmentation = del.EndInvoke(results);
            webResponseEventArgs = new WebResponseEventArgs<Segmentation>(segmentation, null);
            LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

        }
        catch (SdkException sdkException)
        {
            webResponseEventArgs = new WebResponseEventArgs<Segmentation>(null, sdkException);
            LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
            Trace.WriteLine(sdkException.Message);
        }

    }





    
}
}