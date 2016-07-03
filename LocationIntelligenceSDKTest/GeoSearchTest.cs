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
using com.pb.locationintelligence.geosearch;
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
    public class GeoSearchTest
    {
        
        private static GeoSearchService mGeoSearchService;
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
            mGeoSearchService = liServiceManager.getGeoSearchService();

        }

        [TestMethod]
        public void testGeoSearch()
        {
            try
            {
                Locations response = mGeoSearchService.geoSearch("times sq", 40.761819, -73.997533);
                Assert.IsNotNull(response);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void testGeoSearchAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoSearchService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    try
                    {
                        Assert.IsTrue(eventArgs.ResponseObject != null);
                        this.TriggerTest.Set();
                    }
                    catch (Exception)
                    {
                        failFlag = true;
                        this.TriggerTest.Set();

                    }
                };
                mGeoSearchService.geoSearchAsync("times sq", 40.761819, -73.997533);
                this.TriggerTest.WaitOne(10000);
                if (failFlag)
                {
                    Assert.Fail("Test Case Failed");
                }


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }


        }

        [TestMethod]
        public void testGeoSearchWithInvalidParams()
        {
            try
            {
                mGeoSearchService.geoSearch("times sq", 240.761819, -73.997533);
            }
            catch (SdkException e)
            {
                verifyException(e);
            }
        }


        [TestMethod]
        public void testGeoSearchWithAllParams()
        {
            try
            {
                Locations response = mGeoSearchService.geoSearch("times sq", 40.761819, -73.997533, 1.00f, "MILES", 5);
                Assert.IsNotNull(response);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void testGeoSearchWithAllParamsAsync()
        {


            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoSearchService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Locations> eventArgs) =>
                {
                    try
                    {
                        Assert.IsTrue(eventArgs.ResponseObject != null);
                        this.TriggerTest.Set();
                    }
                    catch (Exception)
                    {
                        failFlag = true;
                        this.TriggerTest.Set();

                    }
                };
                mGeoSearchService.geoSearchAsync("times sq", 40.761819, -73.997533, 1.00f, "MILES", 5);
                this.TriggerTest.WaitOne(10000);
                if (failFlag)
                {
                    Assert.Fail("Test Case Failed");
                }

            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }


        }

        [TestMethod]        
        public void testGeoSearchWithInvalidRequest() {
            try {
                mGeoSearchService.geoSearch("times sq", 440.761819, -743.997533, 1.00f, "MILES_AA", 59);
            } catch (SdkException e) {
                verifyException(e);
            }
        }


       [TestMethod]
       private void verifyException(SdkException e) {

        Assert.IsTrue(SdkException.ErrorResponseType.LI.Equals(e.ErrorResponseTypes));
        Assert.IsNotNull(e.LiApiErrors);
        Assert.IsTrue(e.LiApiErrors.Errors.Count > 0);
        Assert.IsTrue(e.LiApiErrors.Reason.Length > 0);
        Assert.IsTrue(e.LiApiErrors.JsonResponse.Length > 0);
    }


       [TestMethod]
       public void testGetGeolifeByAddressAndCompareSDKResponseTest()
       {
           try
           {
               Locations response = mGeoSearchService.geoSearch("times sq", 40.761819, -73.997533);
               String serviceEndPoint = "/geosearch/v1/locations";
               Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
               keyValueMap.Add("searchText", "times sq");
               keyValueMap.Add("latitude", 40.761819);
               keyValueMap.Add("longitude", -73.997533);
               String responseJSON = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);
               JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
               String sdkResponseString = jsonSerializer.Serialize(response);
               Locations apiResponse = jsonSerializer.Deserialize<Locations>(responseJSON);
               Assert.AreEqual(response.location[0].address.addressNumber, apiResponse.location[0].address.addressNumber);
               Assert.AreEqual(response.location[0].address.areaName1, apiResponse.location[0].address.areaName1);
               Assert.AreEqual(response.location[0].address.areaName2, apiResponse.location[0].address.areaName2);
               Assert.AreEqual(response.location[0].address.areaName3, apiResponse.location[0].address.areaName3);

              
           }
           catch (Exception e)
           {
               Assert.Fail("Unexpected Exception");
           }
       } 



    [TestCleanup]
    public void tearDown(){
        mGeoSearchService = null;
    }
    
    }

}
