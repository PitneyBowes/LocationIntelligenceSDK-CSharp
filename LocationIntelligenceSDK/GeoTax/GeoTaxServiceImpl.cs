#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.exception;
using com.pb.locationintelligence.geotax.model;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Json;
using System.Text;

namespace com.pb.locationintelligence.geotax
{




    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geotax.GeoTaxService" />
    public class GeoTaxServiceImpl : GeoTaxService {



        /// <summary>
        /// The geotax URL
        /// </summary>
        private static readonly String geotaxUrl = "/geotax/v1/";
       

        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<WebResponseEventArgs<TaxRateResponse>> LiAPIRequestFinishedEvent;

        public event EventHandler<WebResponseEventArgs<TaxResponseList>> LiAPIGEoTaxBatchRequestFinishedEvent;


        #region HTTP GET

        #region GeoTaxRateByAddress


        /// <summary>
        /// Accepts taxRateTypeId  and address information and gets the GeoTax Rate information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        public TaxRateResponse getGeoTaxRateByAddress(String taxType, String address)  {

			return Utility.processAPIRequest<TaxRateResponse>(getUrlforGeoTaxRateByAddress(taxType, address), Utility.HttpVerb.Get, String.Empty);
		
		 }


        /// <summary>
        /// Accepts taxRateTypeId  and address information and gets the GeoTax Rate information in Asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        public void getGeoTaxRateByAddressAsync(string taxType, string address)
		{
			processAPIRequestDelegate<TaxRateResponse> delegateApiRequs = new processAPIRequestDelegate<TaxRateResponse>(Utility.processAPIRequest<TaxRateResponse>);
            delegateApiRequs.BeginInvoke(getUrlforGeoTaxRateByAddress(taxType, address), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
		}


        /// <summary>
        /// Gets the urlfor geo tax rate by address.
        /// </summary>
        /// <param name="taxType">Type of the tax.</param>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        string getUrlforGeoTaxRateByAddress(String taxType, String address)
		{
			urlMaker = UrlMaker.getInstance();

			StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geotaxUrl));
			urlBuilder.Append("taxrate/").Append(taxType).Append("/byaddress");

			Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
			keyValueMap.Add("address", address);

			Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

			return urlBuilder.ToString();
		}


        #endregion


        #region GeoTaxRateByLocation
        /// <summary>
        /// Accepts taxRateTypeId , latitude and longitude information and gets the GeoTax Rate information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        public TaxRateResponse getGeoTaxRateByLocation(String taxType,
				Double latitude, Double longitude)  {

					return Utility.processAPIRequest<TaxRateResponse>(getUrlforGeoTaxRateByLocation( taxType,latitude,  longitude), Utility.HttpVerb.Get, String.Empty);
		}

        /// <summary>
        /// Accepts taxRateTypeId , latitude and longitude information and gets the GeoTax Rate information in asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        public void getGeoTaxRateByLocationAsync(string taxType, double latitude, double longitude)
		{
			processAPIRequestDelegate<TaxRateResponse> delegateApiRequs = new processAPIRequestDelegate<TaxRateResponse>(Utility.processAPIRequest<TaxRateResponse>);
			delegateApiRequs.BeginInvoke(getUrlforGeoTaxRateByLocation(taxType, latitude, longitude), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
		}

        /// <summary>
        /// Gets the urlfor geo tax rate by location.
        /// </summary>
        /// <param name="taxType">Type of the tax.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns></returns>
        private string getUrlforGeoTaxRateByLocation(string taxType, double latitude, double longitude)
		{

			urlMaker = UrlMaker.getInstance();

			StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geotaxUrl));
			urlBuilder.Append("taxrate/").Append(taxType).Append("/bylocation");

			Dictionary<String,Object> keyValueMap = new Dictionary<String, Object>();
			keyValueMap.Add("latitude",latitude);
			keyValueMap.Add("longitude",longitude);

			Utility.appendIfNotNull(urlBuilder,keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

			return urlBuilder.ToString();
		}

        #endregion


        #region GeoTaxByLocation
        /// <summary>
        /// Accepts taxRateTypeId , latitude , longitude and purchaseAmount information and gets the GeoTax  information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        public TaxRateResponse getGeoTaxByLocation(String taxType,
				Double latitude, Double longitude, Double purchaseAmount)
				 {
			
			return Utility.processAPIRequest<TaxRateResponse>(getUrlforGeoTaxByLocation( taxType,
				 latitude,  longitude,  purchaseAmount), Utility.HttpVerb.Get, String.Empty);
		}


        /// <summary>
        /// Accepts taxRateTypeId , latitude , longitude and purchaseAmount information and gets the GeoTax  information in Asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        public void getGeoTaxByLocationAsync(string taxType, double latitude, double longitude, double purchaseAmount)
		{
			processAPIRequestDelegate<TaxRateResponse> delegateApiRequs = new processAPIRequestDelegate<TaxRateResponse>(Utility.processAPIRequest<TaxRateResponse>);
            delegateApiRequs.BeginInvoke(getUrlforGeoTaxByLocation(taxType, latitude, longitude, purchaseAmount), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
		}

        /// <summary>
        /// Gets the urlfor geo tax by location.
        /// </summary>
        /// <param name="taxType">Type of the tax.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="purchaseAmount">The purchase amount.</param>
        /// <returns></returns>
        private string getUrlforGeoTaxByLocation(String taxType,
				Double latitude, Double longitude, Double purchaseAmount)
		{
			urlMaker = UrlMaker.getInstance();

			StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geotaxUrl));
			urlBuilder.Append("tax/").Append(taxType).Append("/bylocation");

			Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
			keyValueMap.Add("latitude", latitude);
			keyValueMap.Add("longitude", longitude);
			keyValueMap.Add("purchaseAmount", purchaseAmount);

			Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);

			return urlBuilder.ToString();

		}



        #endregion


        #region GeoTaxByAddress

        /// <summary>
        /// Accepts taxRateTypeId , address  and purchaseAmount information and gets the GeoTax  information.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        /// <returns>
        /// TaxRateResponse
        /// </returns>
        public TaxRateResponse getGeoTaxByAddress(String taxType,
				String address, Double purchaseAmount)  {
			
			return Utility.processAPIRequest<TaxRateResponse>(getUrlforGeoTaxByAddress( taxType,
				 address,  purchaseAmount), Utility.HttpVerb.Get, String.Empty);
		}

        /// <summary>
        /// Gets the urlfor geo tax by address.
        /// </summary>
        /// <param name="taxType">Type of the tax.</param>
        /// <param name="address">The address.</param>
        /// <param name="purchaseAmount">The purchase amount.</param>
        /// <returns></returns>
        private string getUrlforGeoTaxByAddress(String taxType,
				String address, Double purchaseAmount)
		{
			urlMaker = UrlMaker.getInstance();

			StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(geotaxUrl));
			urlBuilder.Append("tax/").Append(taxType).Append("/byaddress");

			Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
			keyValueMap.Add("address", address);
			keyValueMap.Add("purchaseAmount", purchaseAmount);

			Utility.appendIfNotNull(urlBuilder, keyValueMap);

            Debug.WriteLine("API URL : " + urlBuilder);
		   

			return urlBuilder.ToString();

		}


        /// <summary>
        /// Accepts taxRateTypeId , address  and purchaseAmount information and gets the GeoTax  information in Asynchronous mode.
        /// We need to subscribe to event
        /// LiAPIRequestFinishedEvent to get the response.
        /// </summary>
        /// <param name="taxType">Required - Tax Rate Types.</param>
        /// <param name="address">Required - Free-form address text.</param>
        /// <param name="purchaseAmount">Required - purchase amount.</param>
        public void getGeoTaxByAddressAsync(string taxType, string address, double purchaseAmount)
		{
			processAPIRequestDelegate<TaxRateResponse> delegateApiRequs = new processAPIRequestDelegate<TaxRateResponse>(Utility.processAPIRequest<TaxRateResponse>);
			delegateApiRequs.BeginInvoke(getUrlforGeoTaxByAddress(taxType,
				 address, purchaseAmount), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallback), null);
		}

        #endregion

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallback(IAsyncResult results)
		{

			AsyncResult result = (AsyncResult)results;

			processAPIRequestDelegate<TaxRateResponse> del = (processAPIRequestDelegate<TaxRateResponse>)result.AsyncDelegate;
			WebResponseEventArgs<TaxRateResponse> webResponseEventArgs;

			try
			{
                Debug.WriteLine("GeoLife SDK Asynchronous function called ");
				TaxRateResponse taxRateResponse = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<TaxRateResponse>(taxRateResponse, null);
				LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

			}
			catch (SdkException sdkException)
			{
				webResponseEventArgs = new WebResponseEventArgs<TaxRateResponse>(null, sdkException);
				LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
				
			}

		}
        #endregion

        #region  HTTP POST

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackBatchGeoTax(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<TaxResponseList> del = (processAPIRequestDelegate<TaxResponseList>)result.AsyncDelegate;
            WebResponseEventArgs<TaxResponseList> webResponseEventArgs;

            try
            {
                Debug.WriteLine("GeoLife SDK Asynchronous function called ");
                TaxResponseList taxRateResponse = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<TaxResponseList>(taxRateResponse, null);
                LiAPIGEoTaxBatchRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<TaxResponseList>(null, sdkException);
                LiAPIGEoTaxBatchRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }

        }
        public TaxResponseList getGeoTaxRateBatchByLocation(string taxRateTypeId, TaxRateLocationRequest request)
        {
            String requestPayload = String.Empty;
            
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxRateLocationRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxRatelocationService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));

            return Utility.processAPIRequest<TaxResponseList>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        public TaxResponseList getGeoTaxRateByBatchAddress(string taxRateTypeId, TaxRateAddressRequest request)
        {
            String requestPayload = String.Empty;
            
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxRateAddressRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxRateAddressService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));

            return Utility.processAPIRequest<TaxResponseList>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        public TaxResponseList getGeoTaxByBatchLocation(string taxRateTypeId, TaxLocationRequest request)
        {
            String requestPayload = String.Empty;
            

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxLocationRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxlocationService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));

            return Utility.processAPIRequest<TaxResponseList>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        public TaxResponseList getGeoTaxByBatchAddress(string taxRateTypeId, TaxAddressRequest request)
        {
            String requestPayload = String.Empty;
           

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxAddressRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxAddressService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));

            return Utility.processAPIRequest<TaxResponseList>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        void GeoTaxService.getGeoTaxRateBatchByLocationAsync(string taxRateTypeId, TaxRateLocationRequest request)
        {
            String requestPayload = String.Empty;


            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxRateLocationRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();

            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxRatelocationService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));


            processAPIRequestDelegate<TaxResponseList> delegateApiRequs = new processAPIRequestDelegate<TaxResponseList>(Utility.processAPIRequest<TaxResponseList>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackBatchGeoTax), null);
        }

        void GeoTaxService.getGeoTaxRateByBatchAddressAsync(string taxRateTypeId, TaxRateAddressRequest request)
        {
            String requestPayload = String.Empty;


            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxRateAddressRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();

            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxRateAddressService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));


            processAPIRequestDelegate<TaxResponseList> delegateApiRequs = new processAPIRequestDelegate<TaxResponseList>(Utility.processAPIRequest<TaxResponseList>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackBatchGeoTax), null);
        }

        void GeoTaxService.getGeoTaxByBatchLocationAsync(string taxRateTypeId, TaxLocationRequest request)
        {
            String requestPayload = String.Empty;


            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxLocationRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();

            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxlocationService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));


            processAPIRequestDelegate<TaxResponseList> delegateApiRequs = new processAPIRequestDelegate<TaxResponseList>(Utility.processAPIRequest<TaxResponseList>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackBatchGeoTax), null);
        }

        void GeoTaxService.getGeoTaxByBatchAddressAsync(string taxRateTypeId, TaxAddressRequest request)
        {
            String requestPayload = String.Empty;


            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TaxAddressRequest));
            serializer.WriteObject(stream1, request);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();

            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoTaxBatch = String.Format(Constants.geoTaxbatchTaxAddressService, taxRateTypeId);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoTaxBatch));


            processAPIRequestDelegate<TaxResponseList> delegateApiRequs = new processAPIRequestDelegate<TaxResponseList>(Utility.processAPIRequest<TaxResponseList>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackBatchGeoTax), null);
        }


        #endregion
    }
}