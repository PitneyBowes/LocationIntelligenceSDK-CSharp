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
using com.pb.locationintelligence.geotax;
using com.pb.locationintelligence.geotax.model;
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
	public class GeoTaxTest
	{
		
		private static GeoTaxService mGeoTaxService;
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
			mGeoTaxService = liServiceManager.getGeoTaxService();

		}

        #region GeoTax

        [TestMethod]
	public void getGeoTaxRateByLocationTest() {
		try{
			TaxRateResponse response = mGeoTaxService.getGeoTaxRateByLocation("General", 40.018912D, -105.239771D);
			Assert.IsTrue(response != null);
		}catch(Exception e){
			Assert.Fail("Unexpected Exception");
		}
	}

		[TestMethod]
		public void getGeoTaxRateByLocationTestAsync()
		{
			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoTaxService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxRateResponse> eventArgs) =>
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
				mGeoTaxService.getGeoTaxRateByLocationAsync("General", 40.018912D, -105.239771D);
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
	public void getGeoTaxRateByAddressTest() {
		try{
			TaxRateResponse response = mGeoTaxService.getGeoTaxRateByAddress("Auto", "4750 Walnut st, Boulder, CO");
			Assert.IsTrue(response != null);
		}catch(Exception e){
			Assert.Fail("Unexpected Exception");
		}
	}


	public void getGeoTaxRateByAddressTestAsync()
	{

		try
		{
			Boolean failFlag = false;
			this.TriggerTest = new AutoResetEvent(false);
			mGeoTaxService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxRateResponse> eventArgs) =>
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
			mGeoTaxService.getGeoTaxRateByAddressAsync("Auto", "4750 Walnut st, Boulder, CO");
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
	public void getGeoTaxByLocationTest() {
		try{
			TaxRateResponse response = mGeoTaxService.getGeoTaxByLocation("General", 40.018912D, -105.239771D, 100D);
			Assert.IsTrue(response != null);
		}catch(Exception e){
			Assert.Fail("Unexpected Exception");
		}
	}

	[TestMethod]
	public void getGeoTaxByLocationTestAsync()
	{
		try
		{
			this.TriggerTest = new AutoResetEvent(false);
			Boolean failFlag=false;
			mGeoTaxService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxRateResponse> eventArgs) =>
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
			mGeoTaxService.getGeoTaxByLocationAsync("General", 40.018912D, -105.239771D, 100D);
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
	public void getGeoTaxByAddressTest() {
		try{
			TaxRateResponse response = mGeoTaxService.getGeoTaxByAddress("Auto", "4750 Walnut st, Boulder, CO", 100D);
			Assert.IsTrue(response != null);
		}catch(Exception e){
			Assert.Fail("Unexpected Exception");
		}
	}

	[TestMethod]
	public void getGeoTaxByAddressTestAsync()
	{

		try
		{
			this.TriggerTest = new AutoResetEvent(false);
			Boolean failFlag = false;
			mGeoTaxService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxRateResponse> eventArgs) =>
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
			mGeoTaxService.getGeoTaxByAddressAsync("Auto", "4750 Walnut st, Boulder, CO", 100D);
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
	public void testToCompareSDKAndAPIResponseOfGeoTaxRateByAddress()   {
		 Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
		 keyValueMap.Add("address", "4750 Walnut st, Boulder, CO");
         String serviceEndPoint = "/geotax/v1/taxrate/Auto/byaddress";
		 String responseJSONFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);     
         TaxRateResponse responseFromSDK = mGeoTaxService.getGeoTaxRateByAddress("Auto", "4750 Walnut st, Boulder, CO");
         JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
         TaxRateResponse responseFromAPI=jsonSerializer.Deserialize<TaxRateResponse>(responseJSONFromAPI);
         Assert.AreEqual(responseFromSDK.confidence, responseFromAPI.confidence);
         Assert.AreEqual(responseFromSDK.salesTax.countyTaxRate, responseFromAPI.salesTax.countyTaxRate);
         Assert.AreEqual(responseFromSDK.useTax.countyTaxRate, responseFromAPI.useTax.countyTaxRate);
	}


[TestMethod]
	public void testToCompareSDKAndAPIResponseOfGeoTaxRateByLocation()   {
        Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
		keyValueMap.Add("latitude", 40.018912);
		keyValueMap.Add("longitude", -105.239771D);
        String serviceEndPoint = "/geotax/v1/taxrate/General/bylocation";
		String responseJSONFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);     
        TaxRateResponse responseFromSDK = mGeoTaxService.getGeoTaxRateByLocation("General", 40.018912D, -105.239771D);
        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        TaxRateResponse responseFromAPI = jsonSerializer.Deserialize<TaxRateResponse>(responseJSONFromAPI);
        Assert.AreEqual(responseFromSDK.salesTax.countyTaxRate, responseFromAPI.salesTax.countyTaxRate);
        Assert.AreEqual(responseFromSDK.useTax.countyTaxRate, responseFromAPI.useTax.countyTaxRate);
	}
	
	
[TestMethod]
	public void testToCompareSDKAndAPIResponseOfGeoTaxByAddress()   {
        Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
		 keyValueMap.Add("address", "4750 Walnut st, Boulder, CO");
		 keyValueMap.Add("purchaseAmount", 100D);
        String serviceEndPoint = "/geotax/v1/tax/Auto/byaddress";
		String responseJSONFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);     
        TaxRateResponse responseFromSDK = mGeoTaxService.getGeoTaxByAddress("Auto", "4750 Walnut st, Boulder, CO", 100D);
        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        TaxRateResponse responseFromAPI=jsonSerializer.Deserialize<TaxRateResponse>(responseJSONFromAPI);
        Assert.AreEqual(responseFromSDK.salesTax.countyTaxAmount, responseFromAPI.salesTax.countyTaxAmount);
	}

[TestMethod]
public void testToCompareSDKAndAPIResponseOfGeoTaxByLocation()
{
        Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
		keyValueMap.Add("latitude", 40.018912);
		keyValueMap.Add("longitude", -105.239771D);
		keyValueMap.Add("purchaseAmount", 100D);
        String serviceEndPoint = "/geotax/v1/tax/General/bylocation";
		String responseJSONFromAPI = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);     
        TaxRateResponse responseFromSDK = mGeoTaxService.getGeoTaxByLocation("General", 40.018912D, -105.239771D, 100D);
        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        TaxRateResponse responseFromAPI = jsonSerializer.Deserialize<TaxRateResponse>(responseJSONFromAPI);
        Assert.AreEqual(responseFromSDK.salesTax.countyTaxAmount, responseFromAPI.salesTax.countyTaxAmount);
	}

#endregion

        #region GoaTax Batch

        [TestMethod]
        public void testGeoTaxbatchRateAddress()
        {
            try
            {
                TaxRateAddressRequest taxRateAddressRequest = new TaxRateAddressRequest();

                List<TaxRateAddress> taxAddressList = new List<TaxRateAddress>();

                TaxRateAddress taxRateAddress = new TaxRateAddress();
                taxRateAddress.MainAddressLine = "39 Sycamore Rd,Stafford 08050, USA";
                taxAddressList.Add(taxRateAddress);
                taxRateAddressRequest.taxRateAddresses = taxAddressList;

                TaxResponseList response = mGeoTaxService.getGeoTaxRateByBatchAddress("General", taxRateAddressRequest);
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }



        [TestMethod]
        public void testGeoTaxbatchAddress()
        {
            try
            {
                TaxAddressRequest taxAddressRequest = new TaxAddressRequest();

                List<TaxAddress> taxAddressList = new List<TaxAddress>();

                TaxAddress taxAddress = new TaxAddress();
                taxAddress.MainAddressLine = "39 Sycamore Rd,Stafford 08050, USA";
                taxAddressList.Add(taxAddress);
                taxAddressRequest.taxAddresses = taxAddressList;
                taxAddress.purchaseAmount = "100";

                TaxResponseList response = mGeoTaxService.getGeoTaxByBatchAddress("General", taxAddressRequest);
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void testGeoTaxbatchRateLocation()
        {
            try
            {
                TaxRateLocationRequest taxRateLocatoinRequest = new TaxRateLocationRequest();

                List<Locations> taxLocationList = new List<Locations>();

                Locations location = new Locations();

                 Geometry geometry= new Geometry();
                geometry.type = "point";
                geometry.coordinates =new List<Double>(){ -105.239771, 40.018912 };

                location.geometry = geometry;
                taxLocationList.Add(location);

                taxRateLocatoinRequest.locations = taxLocationList;

                TaxResponseList response = mGeoTaxService.getGeoTaxRateBatchByLocation("General", taxRateLocatoinRequest);
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void testGeoTaxbatchLocation()
        {

            try
            {
                TaxLocationRequest taxLocatoinRequest = new TaxLocationRequest();

                List<Locations> taxLocationList = new List<Locations>();

                Locations location = new Locations();

                Geometry geometry = new Geometry();
                geometry.type = "point";
                geometry.coordinates = new List<Double>() { -105.239771, 40.018912 };

                location.geometry = geometry;
                location.purchaseAmount = "100";
                taxLocationList.Add(location);

                taxLocatoinRequest.locations = taxLocationList;

                TaxResponseList response = mGeoTaxService.getGeoTaxByBatchLocation("General", taxLocatoinRequest);
                Assert.IsTrue(response != null);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void TestgetGeoTaxbatchRateAddressAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoTaxService.LiAPIGEoTaxBatchRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxResponseList> eventArgs) =>
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
                TaxRateAddressRequest taxRateAddressRequest = new TaxRateAddressRequest();

                List<TaxRateAddress> taxAddressList = new List<TaxRateAddress>();

                TaxRateAddress taxRateAddress = new TaxRateAddress();
                taxRateAddress.MainAddressLine = "39 Sycamore Rd,Stafford 08050, USA";
                taxAddressList.Add(taxRateAddress);
                taxRateAddressRequest.taxRateAddresses = taxAddressList;

                mGeoTaxService.getGeoTaxRateByBatchAddressAsync("General", taxRateAddressRequest);

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
        public void TestgetGeoTaxbatchAddressAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoTaxService.LiAPIGEoTaxBatchRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxResponseList> eventArgs) =>
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
                TaxAddressRequest taxeAddressRequest = new TaxAddressRequest();

                List<TaxAddress> taxAddressList = new List<TaxAddress>();

                TaxAddress taxAddress = new TaxAddress();
                taxAddress.MainAddressLine = "39 Sycamore Rd,Stafford 08050, USA";
                taxAddress.purchaseAmount = "200";

                taxAddressList.Add(taxAddress);
                taxeAddressRequest.taxAddresses = taxAddressList;
                

                mGeoTaxService.getGeoTaxByBatchAddressAsync("General", taxeAddressRequest);

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
        public void TestgetGeoTaxbatchRateLocationAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoTaxService.LiAPIGEoTaxBatchRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxResponseList> eventArgs) =>
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
                TaxRateLocationRequest taxRateLocatoinRequest = new TaxRateLocationRequest();

                List<Locations> taxLocationList = new List<Locations>();

                Locations location = new Locations();

                Geometry geometry = new Geometry();
                geometry.type = "point";
                geometry.coordinates = new List<Double>() { -105.239771, 40.018912 };

                location.geometry = geometry;
                taxLocationList.Add(location);

                taxRateLocatoinRequest.locations = taxLocationList;

                mGeoTaxService.getGeoTaxRateBatchByLocationAsync("General", taxRateLocatoinRequest);

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
        public void TestgetGeoTaxbatchLocationAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                mGeoTaxService.LiAPIGEoTaxBatchRequestFinishedEvent += (object sender, WebResponseEventArgs<TaxResponseList> eventArgs) =>
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
                TaxLocationRequest taxLocatoinRequest = new TaxLocationRequest();

                List<Locations> taxLocationList = new List<Locations>();

                Locations location = new Locations();

                Geometry geometry = new Geometry();
                geometry.type = "point";
                geometry.coordinates = new List<Double>() { -105.239771, 40.018912 };

                location.geometry = geometry;
                location.purchaseAmount = "100";
                taxLocationList.Add(location);

                taxLocatoinRequest.locations = taxLocationList;

                mGeoTaxService.getGeoTaxByBatchLocationAsync("General", taxLocatoinRequest);

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
        mGeoTaxService = null;
    }

        #endregion
    }
}
