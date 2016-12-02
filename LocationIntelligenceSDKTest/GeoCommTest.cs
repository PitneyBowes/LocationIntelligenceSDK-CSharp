using System;
using System.Configuration;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.pb.locationintelligence.geocomm;
using com.pb.locationintelligence.manager;
using com.pb.locationintelligence.oauth;
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.geocomm.model;

namespace LocationIntelligenceSDKTest
{
    [TestClass]
    public class GeoCommTest
    {

        private static GeoCommService mGeoCommService;
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
            mGeoCommService = liServiceManager.getGeoCommService();

        }

        [TestMethod]
        public void getRateCenterByAddressTest()
        {
            try
            {
                RateCenterResponse response = mGeoCommService.getRateCenterByAddress("107 S Indiana Ave Bloomington", "USA", true, "detail");                
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getRateCenterByAddressTestAsync()
        {

            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoCommService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<RateCenterResponse> eventArgs) =>
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
                mGeoCommService.getRateCenterByAddressAsync("107 S Indiana Ave Bloomington", "USA", true, "detail");
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
        public void getRateCenterByLocationTest()
        {
            try
            {
                RateCenterResponse response = mGeoCommService.getRateCenterByLocation(35.081018559404, -87.441472686269, true, "detail");
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getRateCenterByLocationTestAsync()
        {

            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoCommService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<RateCenterResponse> eventArgs) =>
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
                mGeoCommService.getRateCenterByLocationAsync(35.081018559404, -87.441472686269, true, "detail");
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

    }
}