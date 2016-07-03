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
using com.pb.locationintelligence.geoenhance;
using com.pb.locationintelligence.manager;
using com.pb.locationintelligence.oauth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Web.Script.Serialization;


namespace LocationIntelligenceSDKTest
{
    [TestClass]
    public class GeoEnhanceTest
    {
        
        private static GeoEnhanceService mGeoEnhanceService;
        private static String TEST_URL = String.Empty;
        private static String TEST_TOKEN = String.Empty;
        AutoResetEvent TriggerTest;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the 
        ///current test run.
        ///</summary>
        public TestContext TestContextinstnace { get; set; }


        [TestInitialize()]
        public void Initialize()
        {
            TEST_URL = ConfigurationManager.AppSettings["TEST_URL"];
            TEST_TOKEN = ConfigurationManager.AppSettings["TEST_TOKEN"];
            Assert.IsFalse(String.IsNullOrEmpty(TEST_URL), "No App.Config found.");
            LIServiceManager liServiceManager;
            BasicAuthServiceImpl basicAuthServiceImpl = new BasicAuthServiceImpl(TEST_TOKEN, TEST_URL);
            liServiceManager = LIServiceManager.getInstance(basicAuthServiceImpl);
            mGeoEnhanceService = liServiceManager.getGeoEnhanceService();

        }

        [TestMethod]
        public void testGetAddress()
        {
            try
            {
                Locations response = mGeoEnhanceService.getAddress(34.59667, -86.96556, 5280f, "FEET");
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void testGetAddressAsync()
        {


            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    Assert.IsTrue(eventArgs.ResponseObject!= null);
                    this.TriggerTest.Set();
                };
                mGeoEnhanceService.getAddressAsync(34.59667, -86.96556, 5280f, "FEET");
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
            
            
        }




        [TestMethod]
        public void testGetAddressWithInvalidParams()
        {
            try
            {
                mGeoEnhanceService.getAddress(334.59667, -886.96556, 5280f, "FEET_ABC");
            }
            catch (SdkException e)
            {
                verifyException(e);
            }
        }


        [TestMethod]
        public void testGetAddressWithInvalidParamsAsync()
        {
            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    verifyException(eventArgs.SDKException);
                    this.TriggerTest.Set();
                };
                mGeoEnhanceService.getAddressAsync(334.59667, -886.96556, 5280f, "FEET_ABC");
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
            
        }



        [TestMethod]
        public void testGetPlaceByLocation()
        {
            try
            {
                Locations response = mGeoEnhanceService.getPlace(34.59667, -86.96556, 1);
                Assert.IsTrue(response.location != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void testGetPlaceByLocationAsync()
        {

            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    Assert.IsTrue(eventArgs.ResponseObject.location != null);
                };
                mGeoEnhanceService.getPlaceAsync(34.59667, -86.96556, 1);
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }

        }



        public void testGetPlaceByLocationWithInvalidParams()
        {
            try
            {
                mGeoEnhanceService.getPlace(234.59667, -886.96556, null);
            }
            catch (SdkException e)
            {
                verifyException(e);
            }
        }

        public void testGetPlaceByLocationWithInvalidParamsAsync()
        {

            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    verifyException(eventArgs.SDKException);
                };
                mGeoEnhanceService.getPlaceAsync(234.59667, -886.96556, null);
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
            
            
           
        }


        [TestMethod]
        public void testGetPlaceByLocationWithNoLevelHint()
        {
            try
            {
                Locations response = mGeoEnhanceService.getPlace(34.59667, -86.96556, null);
                Assert.IsTrue(response.location != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void testGetPlaceByLocationWithNoLevelHintAsync()
        {
           
            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    Assert.IsTrue(eventArgs.ResponseObject.location != null);
                };
                mGeoEnhanceService.getPlaceAsync(34.59667, -86.96556, null);
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
           
        }

        #region POI
        [TestMethod]
        public void testGetPOI()
        {
            try
            {
                Locations response = mGeoEnhanceService.getPOI(42.5309, -73.6572, "1023", 10, 10560f, "FEET", "PBData", "N");
                Assert.IsTrue(response.location != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void testGetPOIAsync()
        {
            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    Assert.IsTrue(eventArgs.ResponseObject.location != null);
                };
                mGeoEnhanceService.getPOIAsync(42.5309, -73.6572, "1023", 10, 10560f, "FEET", "PBData", "N");
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void testGetPOIWithInvalidParams()
        {
            try
            {
                mGeoEnhanceService.getPOI(442.5309, -793.6572, null, null, null, "FEET_ABC", null, "Z");
            }
            catch (SdkException e)
            {
                verifyException(e);
            }
        }
        [TestMethod]
        public void testGetPOIWithInvalidParamsAsync()
        {

            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    verifyException(eventArgs.SDKException);
                };
                mGeoEnhanceService.getPOIAsync(442.5309, -793.6572, null, null, null, "FEET_ABC", null, "Z");
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
            
            
        }

         [TestMethod]
        public void testGetPOIWithOnlyLocation()
        {
            try
            {
                Locations response = mGeoEnhanceService.getPOI(42.5309, -73.6572, null, null, null, null, null, null);
                Assert.IsTrue(response.location != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

         [TestMethod]
         public void testGetPOIWithOnlyLocationAsync()
         {

             try
             {

                 this.TriggerTest = new AutoResetEvent(false);
                 mGeoEnhanceService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                 {
                     Assert.IsTrue(eventArgs.ResponseObject.location != null);
                 };
                 mGeoEnhanceService.getPOIAsync(42.5309, -73.6572, null, null, null, null, null, null);
                 this.TriggerTest.WaitOne(10000);


             }
             catch (Exception e)
             {
                 Assert.Fail("Unexpected Exception");
             }
             
             
             
         }
        #endregion
        
        [TestMethod]
         public void testGetTimezoneByLocation()
         {
             try
             {
                 TimezoneResponse    response = mGeoEnhanceService.getTimezone(1118169000000,40, -73);
                 Assert.IsNotNull(response.timezoneName);
             }
             catch (Exception e)
             {
                 Assert.Fail("Unexpected Exception");
             }
         }

        [TestMethod]
        public void testGetTimezoneByLocationAsync()
        {

            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiTimeZoneAPIRequestFinishedEvent+= (object sender, WebResponseEventArgs<TimezoneResponse> eventArgs) =>
                {
                    Assert.IsTrue(eventArgs.ResponseObject.timezoneName != null);
                };
                mGeoEnhanceService.getTimezoneAsync(40, -73, 1118169000000);
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }

        }
        
        [TestMethod]
        public void testGetTimezoneByLocationWithInvalidParams()
        {
            try
            {
                mGeoEnhanceService.getTimezone(1118169000000,234.59667, -886.96556);
            }
            catch (SdkException e)
            {
                verifyException(e);
            }
        }


        [TestMethod]
        public void testGetTimezoneByLocationWithInvalidParamsAsync()
        {

            try
            {

                this.TriggerTest = new AutoResetEvent(false);
                mGeoEnhanceService.LiTimeZoneAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<TimezoneResponse> eventArgs) =>
                {
                    verifyException(eventArgs.SDKException);
                };
                mGeoEnhanceService.getTimezoneAsync(1118169000000,234.59667, -886.96556);
                this.TriggerTest.WaitOne(10000);


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }



        }

        private void verifyException(SdkException e)
        {
            Assert.IsTrue(SdkException.ErrorResponseType.LI.Equals(e.ErrorResponseTypes));
            Assert.IsTrue(e.LiApiErrors != null);
            Assert.IsTrue(e.LiApiErrors.Errors.Count > 0);
            Assert.IsTrue(e.LiApiErrors.Reason.Length > 0);
            Assert.IsTrue(e.LiApiErrors.JsonResponse.Length > 0);
        }
        
        [TestMethod]
        public void testGetAddressAndCompareSDKResponseTest()
        {
            try
            {
               Locations responseSDK = mGeoEnhanceService.getAddress(34.59667, -86.96556, 5280f, "FEET");
               String serviceEndPoint = "/geoenhance/v1/address/bylocation";
               Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
               keyValueMap.Add("latitude", 34.59667);
               keyValueMap.Add("longitude", -86.96556);
               keyValueMap.Add("searchRadius", 5280);
               keyValueMap.Add("searchRadiusUnit", "FEET");
               String responseJSON = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);
               JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
               Locations locationsFromAPI = jsonSerializer.Deserialize<Locations>(responseJSON);
               Assert.AreEqual(responseSDK.location[0].address.formattedAddress, locationsFromAPI.location[0].address.formattedAddress);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


       [TestMethod]
	   	public void testGetPlaceCompareSDKAndAPIResponseOfGeoEnhanceByLocation() {
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", 34.59667);
            keyValueMap.Add("longitude", -86.96556);
            keyValueMap.Add("levelHint", 1);
            String jsonResponseFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, "/geoenhance/v1/place/bylocation", keyValueMap);
	        Locations responseSDK = mGeoEnhanceService.getPlace(34.59667, -86.96556, 1);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            Locations locationsFromAPI = jsonSerializer.Deserialize<Locations>(jsonResponseFromAPI);
            Assert.AreEqual(responseSDK.location[0].place.name[0].value, locationsFromAPI.location[0].place.name[0].value);
            Assert.AreEqual(responseSDK.location[0].place.level, locationsFromAPI.location[0].place.level);
            Assert.AreEqual(responseSDK.location[0].place.levelName, locationsFromAPI.location[0].place.levelName);
	   	}

        [TestMethod]
	   	public void testToCompareSDKAndAPIResponseOfGeoEnhancePOI()   {
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", 42.5309);
            keyValueMap.Add("longitude", -73.6572);
            keyValueMap.Add("category", "1023");
            keyValueMap.Add("maxCandidates", 10);
            keyValueMap.Add("searchRadius", 10560f);
            keyValueMap.Add("searchRadiusUnit", "FEET");
            keyValueMap.Add("searchDataset", "PBData");
            keyValueMap.Add("searchPriority", "N");
            String jsonResponseFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, "/geoenhance/v1/poi/bylocation", keyValueMap);
            Locations responseSDK = mGeoEnhanceService.getPOI(42.5309, -73.6572, "1023", 10, 10560f, "FEET", "PBData", "N");
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            Locations locationsFromAPI = jsonSerializer.Deserialize<Locations>(jsonResponseFromAPI);
            Assert.AreEqual(responseSDK.location[0].poi.alias, locationsFromAPI.location[0].poi.alias);
            Assert.AreEqual(responseSDK.location[0].poi.contactDetails.address.formattedAddress, locationsFromAPI.location[0].poi.contactDetails.address.formattedAddress);
	   	}


        [TestMethod]
	   	public void testToCompareSDKAndAPIResponseOfGeoEnhanceTimezone()   {
            Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
            keyValueMap.Add("latitude", 42.5309D);
            keyValueMap.Add("longitude", -73.6572D);
            keyValueMap.Add("timestamp", 1434526026157L);
            String jsonResponseFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, "/geoenhance/v1/timezone/bylocation", keyValueMap);
            TimezoneResponse responseSDK = mGeoEnhanceService.getTimezone(1434526026157L, 42.5309D, -73.6572D);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            TimezoneResponse timeZoneFromAPI = jsonSerializer.Deserialize<TimezoneResponse>(jsonResponseFromAPI);
            Assert.AreEqual(responseSDK.timezoneName, timeZoneFromAPI.timezoneName);
            Assert.AreEqual(responseSDK.dstOffset, timeZoneFromAPI.dstOffset);
            Assert.AreEqual(responseSDK.utcOffset, timeZoneFromAPI.utcOffset);
	   	}
	

        [TestCleanup]  
        public void tearDown()
        {
        mGeoEnhanceService = null;
        }
    }

   
     

}
