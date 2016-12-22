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
using com.pb.locationintelligence.geocode.model;
using com.pb.locationintelligence.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Reflection;

namespace com.pb.locationintelligence.geocode
{
    class GeocodeServiceImpl : GeocodeService
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<WebResponseEventArgs<GeocodeResponse>> LiAPIRequestFinishedEvent;
        public event EventHandler<WebResponseEventArgs<ConfiguredDictionaryResponse>> LiConfiguredDictionaryFinishedEvent;
        public event EventHandler<WebResponseEventArgs<GeocodeCapabilitiesResponse>> LiGeocodeCapabilitiesFinishedEvent;

        #region Capabilities
        public GeocodeCapabilitiesResponse getCapabilities(Country? country=null, OperationType? operationType=null, BundleType bundleType=BundleType.basic)
        {
            return Utility.processAPIRequest<GeocodeCapabilitiesResponse>(getUrlForConfiguration(country, operationType, bundleType), Utility.HttpVerb.Get, String.Empty);
        }

        public void getCapabilitiesAsync(Country? country=null, OperationType? operationType=null,  BundleType bundleType = BundleType.basic)
        {
            processAPIRequestDelegate<GeocodeCapabilitiesResponse> delegateApiRequs = new processAPIRequestDelegate<GeocodeCapabilitiesResponse>(Utility.processAPIRequest<GeocodeCapabilitiesResponse>);
            delegateApiRequs.BeginInvoke(getUrlForConfiguration(country, operationType , bundleType), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallbackConfiguration), null);
        }
        private string getUrlForConfiguration(Country? country, OperationType? operationType,  BundleType bundeleType )
        {
            UrlMaker urlMaker = UrlMaker.getInstance();

            String FormatterCongfigurationUrl = String.Format(Constants.geoCodeConfigurationsUrl,bundeleType);

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(FormatterCongfigurationUrl));

            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            if (country != null)
            {
                keyValueMap.Add("country", Utility.getCountryCode(country));
            }
            if (operationType != null)
            {
                keyValueMap.Add("operation", operationType.ToString());
            }

            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            return urlBuilder.ToString();
        }

        void WorkflowCompletedCallbackConfiguration(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<GeocodeCapabilitiesResponse> del = (processAPIRequestDelegate<GeocodeCapabilitiesResponse>)result.AsyncDelegate;
            WebResponseEventArgs<GeocodeCapabilitiesResponse> webResponseEventArgs;

            try
            {
                Debug.WriteLine("Geocode Capabilites SDK Asynchronous function called ");
                GeocodeCapabilitiesResponse geoLifeResponse = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<GeocodeCapabilitiesResponse>(geoLifeResponse, null);
                LiGeocodeCapabilitiesFinishedEvent.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<GeocodeCapabilitiesResponse>(null, sdkException);
                LiGeocodeCapabilitiesFinishedEvent.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }


        #endregion

        #region Dictionary 
        public ConfiguredDictionaryResponse getDictionary(Country? country = null,  BundleType bundleType = BundleType.basic)
        {
            return Utility.processAPIRequest<ConfiguredDictionaryResponse>(getUrlForDictionary(country, bundleType), Utility.HttpVerb.Get, String.Empty);
        }

        public void getDictionaryAsync(Country? country = null,   BundleType bundleType = BundleType.basic)
        {
            processAPIRequestDelegate<ConfiguredDictionaryResponse> delegateApiRequs = new processAPIRequestDelegate<ConfiguredDictionaryResponse>(Utility.processAPIRequest<ConfiguredDictionaryResponse>);
            delegateApiRequs.BeginInvoke(getUrlForDictionary(country, bundleType), Utility.HttpVerb.Get, String.Empty, new AsyncCallback(WorkflowCompletedCallbackDictionary), null);
        }
        private string getUrlForDictionary(Country? country,  BundleType bundleType)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            String formattedDictionaryUrl = String.Format(Constants.geoCodeDictionariesUrl,  bundleType);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(formattedDictionaryUrl));
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            if (country != null)
            {
                keyValueMap.Add("country", Utility.getCountryCode(country));
            }
            Utility.appendIfNotNull(urlBuilder, keyValueMap);
            return urlBuilder.ToString();
        }


        void WorkflowCompletedCallbackDictionary(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<ConfiguredDictionaryResponse> del = (processAPIRequestDelegate<ConfiguredDictionaryResponse>)result.AsyncDelegate;
            WebResponseEventArgs<ConfiguredDictionaryResponse> webResponseEventArgs;

            try
            {
                Debug.WriteLine("Geocode Capabilites SDK Asynchronous function called ");
                ConfiguredDictionaryResponse geoLifeResponse = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<ConfiguredDictionaryResponse>(geoLifeResponse, null);
                LiConfiguredDictionaryFinishedEvent.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<ConfiguredDictionaryResponse>(null, sdkException);
                LiConfiguredDictionaryFinishedEvent.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }
        #endregion

        #region Geocode
        public GeocodeResponse getGeocode(Address address, GeocodeType geocodeType, BundleType bundleType)
        {
            return getGeocodeBatch(new List<Address> {address},geocodeType,bundleType);
        }

        public GeocodeResponse getGeocodeBatch(IList<Address> address,  GeocodeType geocodeType, BundleType bundleType)
        {
            GeocodeRequest geocodeRequest = new GeocodeRequest();
            geocodeRequest.Type = geocodeType.ToString();
            String requestPayload = String.Empty;

            
            geocodeRequest.Addresses = address as List<Address>;

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GeocodeRequest));
            serializer.WriteObject(stream1, geocodeRequest);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoCodeService = String.Format(Constants.fwrdGeoCodeService , bundleType);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoCodeService));

            return Utility.processAPIRequest<GeocodeResponse>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        public GeocodeResponse getGeocodeAdvanceBatch(IList<Address> address,  GeocodeType geocodeType,  BundleType bundleType, GeocodePreferenceBuilder preferenceBuilder)
        {
            String requestPayload = getPayloadAdvanceBatch(address, geocodeType, bundleType, preferenceBuilder);
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoCodeService = String.Format(Constants.fwrdGeoCodeService, bundleType);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoCodeService));

            return Utility.processAPIRequest<GeocodeResponse>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }


        private string getPayloadAdvanceBatch(IList<Address> address, GeocodeType geocodeType, BundleType bundleType, GeocodePreferenceBuilder preferenceBuilder)
        {
            GeocodeRequest geocodeRequest = new GeocodeRequest();
            geocodeRequest.Type = geocodeType.ToString();
            String requestPayload = String.Empty;

            //Setting Address
            geocodeRequest.Addresses = address as List<Address>;



            geocodeRequest.Preferences = getPreference(preferenceBuilder);
            geocodeRequest.Preferences.customPreferences = getCustomPreference(preferenceBuilder.CustomPreference);


            MemoryStream streamJason = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GeocodeRequest), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });

            serializer.WriteObject(streamJason, geocodeRequest);
            streamJason.Position = 0;
            StreamReader sr = new StreamReader(streamJason);
            requestPayload = sr.ReadToEnd();
            return requestPayload;
        }

        Preferences getPreference(GeocodePreferenceBuilder preferenceBuilder)
        {
            //Setting Preference

            Preferences preference = new Preferences();

            //Geocode Preference
            preference.returnAllCandidateInfo = preferenceBuilder.GeocodePreference.returnAllCandidateInfo;
            preference.fallbackToGeographic = preferenceBuilder.GeocodePreference.fallbackToGeographic;
            preference.fallbackToPostal = preferenceBuilder.GeocodePreference.fallbackToPostal;
            preference.maxReturnedCandidates = preferenceBuilder.GeocodePreference.maxReturnedCandidates;
            preference.distance = preferenceBuilder.GeocodePreference.distance;
            preference.streetOffset = preferenceBuilder.GeocodePreference.streetOffset;
            preference.cornerOffset = preferenceBuilder.GeocodePreference.cornerOffset;
            preference.matchMode = String.IsNullOrEmpty(preferenceBuilder.GeocodePreference.matchMode.ToString()) ? null : preferenceBuilder.GeocodePreference.matchMode.ToString();
            preference.clientLocale = preferenceBuilder.GeocodePreference.clientLocale;
            preference.clientCoordSysName = preferenceBuilder.GeocodePreference.clientCoordSysName;
            preference.distanceUnits = String.IsNullOrEmpty(preferenceBuilder.GeocodePreference.distanceUnits.ToString()) ? null : preferenceBuilder.GeocodePreference.distanceUnits.ToString();
            preference.streetOffsetUnits = String.IsNullOrEmpty(preferenceBuilder.GeocodePreference.streetOffsetUnits.ToString()) ? null : preferenceBuilder.GeocodePreference.distanceUnits.ToString();
            preference.cornerOffsetUnits = String.IsNullOrEmpty(preferenceBuilder.GeocodePreference.cornerOffsetUnits.ToString()) ? null : preferenceBuilder.GeocodePreference.distanceUnits.ToString();



            //FieldsMatching
            preference.mustMatchFields = preferenceBuilder.GeocodePreference.mustMatchFields;


            //preferred Dictionary Order
            if (preferenceBuilder.GeocodePreference.preferredDictionaryOrders != null)
            {

                preference.preferredDictionaryOrders = Utility.getPreferredDictionaryOrderList(preferenceBuilder.GeocodePreference.preferredDictionaryOrders);
            }
            //ReturnFieldsDescriptor
            if (preferenceBuilder.ReturnFieldsDescriptorPreferences != null)
            {
                preference.returnFieldsDescriptor = new ReturnFieldsDescriptor();

                preference.returnFieldsDescriptor.returnAllCustomFields = preferenceBuilder.ReturnFieldsDescriptorPreferences.ReturnAllCustomFields;

                preference.returnFieldsDescriptor.returnMatchDescriptor = preferenceBuilder.ReturnFieldsDescriptorPreferences.ReturnMatchDescriptor;
                preference.returnFieldsDescriptor.returnStreetAddressFields = preferenceBuilder.ReturnFieldsDescriptorPreferences.ReturnStreetAddressFields;
                preference.returnFieldsDescriptor.returnUnitInformation = preferenceBuilder.ReturnFieldsDescriptorPreferences.ReturnUnitInformation;

                //ReturnedCustomFieldKeys


                List<string> List = new List<string>();
                foreach (ReturnedCustomFieldsKeys keys in preferenceBuilder.ReturnFieldsDescriptorPreferences.ReturnedCustomFieldKeys)
                {
                    List.Add(Utility.GetReturnedCustomFieldsKeys(keys));

                }

                preference.returnFieldsDescriptor.returnedCustomFieldKeys = List;

            }



           


            return preference;
        }
        Dictionary<string, string> getCustomPreference(IList<ICustomPreference> CustomPreferenceList)
        {
            //Custom Preferences
            Dictionary<string, string> customPreferenceList = new Dictionary<string, string>();

            foreach (ICustomPreference customPreference in CustomPreferenceList)
            {
                if (customPreference is ICustomPreferenceUSA)
                {
                    ICustomPreferenceUSA customPreferenceUSA = (ICustomPreferenceUSA)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("USA." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }

                }
                else if (customPreference is ICustomPreferenceAUS)
                {
                    ICustomPreferenceAUS customPreferenceUSA = (ICustomPreferenceAUS)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("AUS." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceCAN)
                {
                    ICustomPreferenceCAN customPreferenceUSA = (ICustomPreferenceCAN)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("CAN." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceDUE)
                {
                    ICustomPreferenceDUE customPreferenceUSA = (ICustomPreferenceDUE)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("DUE." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceFRA)
                {
                    ICustomPreferenceFRA customPreferenceUSA = (ICustomPreferenceFRA)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("FRA." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceGBR)
                {
                    ICustomPreferenceGBR customPreferenceUSA = (ICustomPreferenceGBR)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("GBR." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceNZL)
                {

                    ICustomPreferenceNZL customPreferenceUSA = (ICustomPreferenceNZL)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("NZL." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferencePRT)
                {
                    ICustomPreferencePRT customPreferenceUSA = (ICustomPreferencePRT)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("PRT." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceSGP)
                {
                    ICustomPreferenceSGP customPreferenceUSA = (ICustomPreferenceSGP)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("SGP." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else if (customPreference is ICustomPreferenceSWE)
                {
                    ICustomPreferenceSWE customPreferenceUSA = (ICustomPreferenceSWE)customPreference;

                    foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                    {

                        customPreferenceList.Add("SWE." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                    }
                }
                else
                {
                    ICustomPreference customPreferenceUSA = (ICustomPreference)customPreference;

                    if (customPreferenceUSA.Country == null)
                    {
                        foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                        {

                            customPreferenceList.Add(item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                        }
                    }
                    else
                    {
                        foreach (PropertyInfo item in customPreferenceUSA.GetType().GetProperties())
                        {

                            customPreferenceList.Add(Utility.getCountryCode(customPreferenceUSA.Country) + "." + item.Name, item.GetValue(customPreferenceUSA, null) == null ? null : item.GetValue(customPreferenceUSA, null).ToString());
                        }
                    }



                }
            }

            return customPreferenceList;
        }

        public void getGeocodeAsync(Address address, GeocodeType geocodeType,BundleType bundleType)
        {
            GeocodeRequest geocodeRequest = new GeocodeRequest();
            geocodeRequest.Type = geocodeType.ToString();
            String requestPayload = String.Empty;


            geocodeRequest.Addresses = new List<Address> { address };

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GeocodeRequest));
            serializer.WriteObject(stream1, geocodeRequest);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();

            UrlMaker urlMaker = UrlMaker.getInstance();
            String url = String.Format(Constants.fwrdGeoCodeService, bundleType);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(url));
            processAPIRequestDelegate<GeocodeResponse> delegateApiRequs = new processAPIRequestDelegate<GeocodeResponse>(Utility.processAPIRequest<GeocodeResponse>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackGeocode), null);

        }
        
        public void getGeocodeBatchAsync(IList<Address> address, GeocodeType geocodeType,    BundleType bundleType)
        {
            GeocodeRequest geocodeRequest = new GeocodeRequest();
            geocodeRequest.Type = geocodeType.ToString();
            String requestPayload = String.Empty;


            geocodeRequest.Addresses = address as List<Address>;

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GeocodeRequest));
            serializer.WriteObject(stream1, geocodeRequest);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();

            UrlMaker urlMaker = UrlMaker.getInstance();
            String url = String.Format(Constants.fwrdGeoCodeService, bundleType);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(url));
            processAPIRequestDelegate<GeocodeResponse> delegateApiRequs = new processAPIRequestDelegate<GeocodeResponse>(Utility.processAPIRequest<GeocodeResponse>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackGeocode), null);
        }

        public void getGeocodeAdvanceBatchAsync(IList<Address> address, GeocodeType geocodeType,   BundleType bundleType, GeocodePreferenceBuilder preferenceBuilder)
        {
            String requestPayload = getPayloadAdvanceBatch(address, geocodeType, bundleType, preferenceBuilder);
            UrlMaker urlMaker = UrlMaker.getInstance();
            String GeoCodeService = String.Format(Constants.fwrdGeoCodeService, bundleType);
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(GeoCodeService));

            processAPIRequestDelegate<GeocodeResponse> delegateApiRequs = new processAPIRequestDelegate<GeocodeResponse>(Utility.processAPIRequest<GeocodeResponse>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackGeocode), null);
        }

        void WorkflowCompletedCallbackGeocode(IAsyncResult results)
        {

            AsyncResult result = (AsyncResult)results;

            processAPIRequestDelegate<GeocodeResponse> del = (processAPIRequestDelegate<GeocodeResponse>)result.AsyncDelegate;
            WebResponseEventArgs<GeocodeResponse> webResponseEventArgs;

            try
            {
                
                GeocodeResponse geocodeResponse = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<GeocodeResponse>(geocodeResponse, null);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);

            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<GeocodeResponse>(null, sdkException);
                LiAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }




        #endregion

        #region ReverseGeocode

        public GeocodeResponse getReverseGeocode(BundleType bundleType, Points points)
        {
            IList<Points> pointList = new List<Points>();
            pointList.Add(points);

            return getReverseGeocodeBatch(bundleType,pointList);
        }


        public GeocodeResponse getReverseGeocodeBatch(BundleType bundleType, IList<Points> points)
        {

            String requestPayload = String.Empty;

            ReverseGeocodeRequest reverseGeocodeRequest = new ReverseGeocodeRequest();

            reverseGeocodeRequest.Points = points as List<Points>;
            

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReverseGeocodeRequest));
            serializer.WriteObject(stream1, reverseGeocodeRequest);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            string url = Constants.reverseGeocodegeoCode;

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(String.Format(url, bundleType.ToString())));

            return Utility.processAPIRequest<GeocodeResponse>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        

        public void getReverseGeocodeAsync(BundleType bundleType, Points points)
        {
            getReverseGeocodeBatchAsync(bundleType,new List <Points>{points});
        }

        public void getReverseGeocodeBatchAsync(BundleType bundleType,IList<Points> points)
        {
            String requestPayload = String.Empty;

            ReverseGeocodeRequest reverseGeocodeRequest = new ReverseGeocodeRequest();

            
            reverseGeocodeRequest.Points = points as List<Points>;

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReverseGeocodeRequest));
            serializer.WriteObject(stream1, reverseGeocodeRequest);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            string url = Constants.reverseGeocodegeoCode;
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(String.Format(url, bundleType.ToString())));


            processAPIRequestDelegate<GeocodeResponse> delegateApiRequs = new processAPIRequestDelegate<GeocodeResponse>(Utility.processAPIRequest<GeocodeResponse>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackGeocode), null);
        }

        public void getReverseGeocodeAdvanceBatchAsync(BundleType bundleType, IList<Points> points,   GeocodePreferenceBuilder geocodePreferenceBuilder)
        {
            String requestPayload = String.Empty;

            ReverseGeocodeRequest reverseGeocodeRequest = new ReverseGeocodeRequest();


            reverseGeocodeRequest.Points = points as List<Points>;

            reverseGeocodeRequest.Preferences = getPreference(geocodePreferenceBuilder);
            reverseGeocodeRequest.Preferences.customPreferences = getCustomPreference(geocodePreferenceBuilder.CustomPreference);

            MemoryStream streamJason = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReverseGeocodeRequest), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });
           
            serializer.WriteObject(streamJason, reverseGeocodeRequest);
            streamJason.Position = 0;
            StreamReader sr = new StreamReader(streamJason);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            string url =Constants.reverseGeocodegeoCode;
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(String.Format(url, bundleType.ToString())));


            processAPIRequestDelegate<GeocodeResponse> delegateApiRequs = new processAPIRequestDelegate<GeocodeResponse>(Utility.processAPIRequest<GeocodeResponse>);
            delegateApiRequs.BeginInvoke(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload, new AsyncCallback(WorkflowCompletedCallbackGeocode), null);
        }

      

        public GeocodeResponse getReverseGeocodeAdvanceBatch(BundleType bundleType, IList<Points> points,  GeocodePreferenceBuilder preferenceBuilder)
        {
            String requestPayload = String.Empty;

            ReverseGeocodeRequest reverseGeocodeRequest = new ReverseGeocodeRequest();

            reverseGeocodeRequest.Points = points as List<Points>;

            reverseGeocodeRequest.Preferences = getPreference(preferenceBuilder);
            reverseGeocodeRequest.Preferences.customPreferences = getCustomPreference(preferenceBuilder.CustomPreference);


            MemoryStream streamJason = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReverseGeocodeRequest), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });
            serializer.WriteObject(streamJason, reverseGeocodeRequest);
            streamJason.Position = 0;
            StreamReader sr = new StreamReader(streamJason);
            requestPayload = sr.ReadToEnd();
            UrlMaker urlMaker = UrlMaker.getInstance();
            string url = Constants.reverseGeocodegeoCode;

            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(String.Format(url, bundleType.ToString())));

            return Utility.processAPIRequest<GeocodeResponse>(urlBuilder.ToString(), Utility.HttpVerb.Post, requestPayload);
        }

        

        #endregion


    }
}
