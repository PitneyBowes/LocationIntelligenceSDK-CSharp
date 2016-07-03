/*****************************************************************************
 *       Copyright   ©  2014, Pitney Bowes Software Inc.
 *       All  rights reserved.
 *       Confidential Property of Pitney Bowes Software Inc.
 */

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
    public class GeoSearchServiceImpl : GeoSearchService
    {

        

        private String geoSearchURL = "/geosearch/v1/locations";

        public event EventHandler<common.WebResponseEventArgs<Locations>> LiAPIRequestFinishedEvent;

        public Locations geoSearch(String searchText, Double originLatitude, Double originLongitude)
        {

            String url = getUrl(searchText, originLatitude, originLongitude);

            Debug.WriteLine("API URL : " + url);
            return Utility.processAPIRequest<Locations>(url, Utility.HttpVerb.Get, String.Empty);
        }

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



        /**
     * Retrieves Geo Search results
     * 
     * @param searchText
     *            Mandatory - The input to be searched
     * @param originLatitude
     *            Mandatory - The latitude of the location
     * @param originLongitude
     *            Mandatory - The longitude of the location
     * @return {@link Locations}
     */
        public void geoSearchAsync(String searchText,
                             Double latitude, Double longitude)
        {
            processAPIRequestDelegate<Locations> delegateApiRequest = new processAPIRequestDelegate<Locations>(Utility.processAPIRequest<Locations>);
            delegateApiRequest.BeginInvoke(getUrl(searchText, latitude, longitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);

        }


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