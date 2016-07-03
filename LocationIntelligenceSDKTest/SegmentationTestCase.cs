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
using System.Configuration;
using com.pb.locationintelligence.exception;
using com.pb.locationintelligence.segmentation;
using com.pb.locationintelligence.segmentation.model;
using com.pb.locationintelligence.manager;
using com.pb.locationintelligence.oauth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using com.pb.locationintelligence.common;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace LocationIntelligenceSDKTest
{
    [TestClass]
    public class SegmentationTest
    {
        
        private static SegmentationService segmentationService;
        private static String TEST_URL = String.Empty;
        private static String TEST_TOKEN = String.Empty;
        private AutoResetEvent TriggerTest;

        [TestInitialize()]
        public void Initialize()
        {
            TEST_URL = ConfigurationManager.AppSettings["TEST_URL"];
            TEST_TOKEN = ConfigurationManager.AppSettings["TEST_TOKEN"];
            Assert.IsFalse(String.IsNullOrEmpty(TEST_URL), "No App.Config found.");
            LIServiceManager liServiceManager;


            BasicAuthServiceImpl basicAuthServiceImpl = new BasicAuthServiceImpl(TEST_TOKEN, TEST_URL);
            liServiceManager = LIServiceManager.getInstance(basicAuthServiceImpl);
            segmentationService = liServiceManager.getSegmentationService();

        }


        [TestMethod]
        public void segmentationByLocationTest()
        {
            try
            {
                Segmentation segmentation = segmentationService.getSegmentationByLocation(-81.9571, 35.0118);
                Assert.IsTrue(segmentation != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void segmentationByLocationTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                segmentationService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Segmentation> eventArgs) =>
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
                segmentationService.getSegmentationByLocationAsync(-81.9571, 35.0118);
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
        public void segmentationByAddressTest()
        {
            try
            {
                Segmentation segmentation = segmentationService.getSegmentationByAddress("1 Global View, Troy, NY");
                Assert.IsTrue(segmentation != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

          [TestMethod]
        public void segmentationByAddressTestAsync()
        {

            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                segmentationService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<Segmentation> eventArgs) =>
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
                Segmentation segmentation = segmentationService.getSegmentationByAddress("1 Global View, Troy, NY", "USA");
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



        [TestCleanup]
        public void tearDown()
        {
            segmentationService = null;
        }


    }
}
