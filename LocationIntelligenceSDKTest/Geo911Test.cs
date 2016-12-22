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
using com.pb.locationintelligence.geo911;
using com.pb.locationintelligence.geo911.model;
using com.pb.locationintelligence.manager;
using com.pb.locationintelligence.oauth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace LocationIntelligenceSDKTest
{
    [TestClass]
    public class Geo911Test
    {
       
        private static Geo911Service geo911Service;
        private static String TEST_URL = String.Empty;
        private static String TEST_TOKEN = String.Empty;
        AutoResetEvent TriggerTest;

        [TestInitialize()]
        public void Initialize()
        {
            TEST_URL = ConfigurationManager.AppSettings["TEST_URL"];
            TEST_TOKEN = ConfigurationManager.AppSettings["TEST_TOKEN"];
            Assert.IsFalse(String.IsNullOrEmpty(TEST_URL), "No App.Config found.");
            LIServiceManager liServiceManager;
            BasicAuthServiceImpl basicAuthServiceImpl = new BasicAuthServiceImpl(TEST_TOKEN, TEST_URL);
            liServiceManager = LIServiceManager.getInstance(basicAuthServiceImpl);
            geo911Service = liServiceManager.getGeo911Service();

        }

        [TestMethod]
        public void getPSAPByAddressTest()
        {
            try
            {

                PsapResponse response = geo911Service.getPSAPByAddress("1 Global View, Troy, NY");
                Assert.IsInstanceOfType(response, typeof(PsapResponse));
               

            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getAHJPlusPSAPByAddressTest()
        {
            try
            {

                AHJPlusPSAPResponse response = geo911Service.getAHJPlusPSAPByAddress("4750 Walnut St, Boulder, CO");
                Assert.IsInstanceOfType(response, typeof(AHJPlusPSAPResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void getAHJPlusPSAPByLocationTest()
        {
            try
            {

                AHJPlusPSAPResponse response = geo911Service.getAHJPlusPSAPByLocation(32.032, -93.703); 
                Assert.IsInstanceOfType(response, typeof(AHJPlusPSAPResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void getAHJPlusPSAPByAddressTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geo911Service.LiAPIAHJPlusPSASRequestFinishedEvent += (object sender, WebResponseEventArgs<AHJPlusPSAPResponse> eventArgs) =>
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
                geo911Service.getAHJPlusPSAPByAddressAsync("4750 Walnut St, Boulder, CO");
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
        public void getAHJPlusPSAPByLocationTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geo911Service.LiAPIAHJPlusPSASRequestFinishedEvent += (object sender, WebResponseEventArgs<AHJPlusPSAPResponse> eventArgs) =>
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
                geo911Service.getAHJPlusPSAPByLocationAsync(32.032, -93.703); 
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
        public void getPSAPByAddressTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geo911Service.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<PsapResponse> eventArgs) =>
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
                geo911Service.getPSAPByAddressAsync("1 Global View, Troy, NY");
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
        public void getPSAPByLocationTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geo911Service.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<PsapResponse> eventArgs) =>
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
                geo911Service.getPSAPByLocationAsync(42.6823227, -73.7042231);
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
        public void getPSAPByLocationTest()
        {
            try
            {
                PsapResponse response = geo911Service.getPSAPByLocation(42.6823227, -73.7042231);
                Assert.IsInstanceOfType(response, typeof(PsapResponse));
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }



        [TestMethod]
        public void getPSAPByAddressAndCompareSDKResponseTest()
        {
            try
            {
                PsapResponse sdkResponse = geo911Service.getPSAPByAddress("1 Global View, Troy, NY");
                String serviceEndPoint="/geo911/v1/psap/byaddress";
                Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
                keyValueMap.Add("address", "1 Global View, Troy, NY");
                String responseJSON=TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                String sdkResponseString=jsonSerializer.Serialize(sdkResponse);
                Assert.AreEqual(sdkResponseString, responseJSON);
               
                }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


       [TestMethod]
        public void getPSAPByLocationAndCompareSDKResponseTest()
        {
            try
            {
                PsapResponse sdkResponse = geo911Service.getPSAPByLocation(42.6823227, -73.7042231);
                String serviceEndPoint = "/geo911/v1/psap/bylocation";
                Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
                keyValueMap.Add("latitude", 42.6823227);
                keyValueMap.Add("longitude", -73.7042231);
                String responseJSON = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                PsapResponse DirectResponse = jsonSerializer.Deserialize<PsapResponse>(responseJSON);
                Assert.AreEqual(sdkResponse.mailingAddress, DirectResponse.mailingAddress);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

    }
}
