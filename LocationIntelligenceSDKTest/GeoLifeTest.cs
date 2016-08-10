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
using com.pb.locationintelligence.geolifeDemographics;
using com.pb.locationintelligence.geolifeDemographics.model;
using com.pb.locationintelligence.manager;
using com.pb.locationintelligence.oauth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Web.Script.Serialization;
using com.pb.locationintelligence.geoLifeSegmentation.model;

namespace LocationIntelligenceSDKTest
{
	[TestClass]
	public class GeoLifeTest
	{
		
		private  static GeoLifeService mGeoLifeService;
		private  static String TEST_URL = String.Empty;
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
			mGeoLifeService = liServiceManager.getGeoLifeService();
			
		}
		
		[TestMethod]
		public  void getDemographicsByAddressTest()
		{
				try{

					GeoLifeResponseDemographics response = mGeoLifeService.getDemographicsByAddress("1 Global View, Troy, NY", "USA", "top3Ascending", "agetheme");
					Assert.IsInstanceOfType(response, typeof(GeoLifeResponseDemographics));
				}catch(Exception e){
					Assert.Fail("Unexpected Exception");
				}
		}
		[TestMethod]
		public void getDemographicsByAddressAsyncTest()
		{
			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) => 
				{

					try
					{
						Assert.IsNotNull(eventArgs.ResponseObject);
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				   
					
				};
				mGeoLifeService.getDemographicsByAddressAsync("1 Global View, Troy, NY", "USA", "top3Ascending", "agetheme");
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
		public void getDemographicsByAddressNegativeTest() {
			try{
				mGeoLifeService.getDemographicsByAddress(null, "USA", "top3Ascending", "agetheme");
			}catch(SdkException exp){
				Assert.IsTrue(exp.getHttpStatusCode()== 400);
			}catch(Exception e){
				Assert.Fail("Unexpected Exception");
			}
		}

		[TestMethod]
		public void getDemographicsByAddressNegativeTestAsync()
		{

			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) =>
				{
					
					
					try
					{
						Assert.IsTrue(eventArgs.SDKException.getHttpStatusCode() == 400);
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				};
				mGeoLifeService.getDemographicsByAddressAsync(null, "USA", "top3Ascending", "agetheme");
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
			public void getDemographicsByAddressBadRequestTest() {
					try{
						mGeoLifeService.getDemographicsByAddress("1 Global View, Troy, NY", "1234", "top3Ascending", "agetheme");
					}
					catch (SdkException exp)
					{
						Assert.IsTrue((SdkException.ErrorResponseType)exp.ErrorResponseTypes == SdkException.ErrorResponseType.LI);
						Assert.IsTrue(exp.getHttpStatusCode() == 400);
					}catch(Exception e){
						Assert.Fail("Unexpected Exception");
					}
			}

		[TestMethod]
		public void getDemographicsByAddressBadRequestTestAsync()
		{

			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) =>
				{
					
					

					try
					{
						Assert.IsTrue((SdkException.ErrorResponseType)eventArgs.SDKException.ErrorResponseTypes == SdkException.ErrorResponseType.LI);
						Assert.IsTrue(eventArgs.SDKException.getHttpStatusCode() == 400);
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				};
				mGeoLifeService.getDemographicsByAddressAsync("1 Global View, Troy, NY", "1234", "top3Ascending", "agetheme");
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
		public void getDemographicsByAddressNoFilterTest() {
			try{
				GeoLifeResponseDemographics response = mGeoLifeService.getDemographicsByAddress("1 Global View, Troy, NY","USA","top3Ascending", null);
				//assertTrue(response instanceof GeoLifeResponse);
				Assert.IsInstanceOfType(response, typeof(GeoLifeResponseDemographics));

			}catch(Exception e){
				Assert.Fail("Unexpected Exception");
			}
		}

		[TestMethod]
		public void getDemographicsByAddressNoFilterTestAsync()
		{

			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) =>
				{
					
					
					try
					{
						Assert.IsInstanceOfType(eventArgs.ResponseObject, typeof(GeoLifeResponseDemographics)); 
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				};
				mGeoLifeService.getDemographicsByAddressAsync("1 Global View, Troy, NY", "USA", "top3Ascending", null);
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
		public void getDemographicsByLocationTest() {
			try{
				GeoLifeResponseDemographics response = mGeoLifeService.getDemographicsByLocation(35.0118D, -81.9571D, "top3Ascending", "agetheme");
				Assert.IsInstanceOfType(response, typeof(GeoLifeResponseDemographics));
			}catch(Exception e){
				Assert.Fail("Unexpected Exception");
			}
		}

		[TestMethod]
		public void getDemographicsByLocationTestAsync()
		{

			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) =>
				{
					
					
					try
					{
						Assert.IsInstanceOfType(eventArgs.ResponseObject, typeof(GeoLifeResponseDemographics));
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				};
				mGeoLifeService.getDemographicsByLocationAsync(35.0118D, -81.9571D, "top3Ascending", "agetheme");
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
		public void getDemographicsByLocationBadRequestTest() {
			try{
				mGeoLifeService.getDemographicsByLocation(35.0118D, -81.9571D, "Invalid Values", "agetheme");
			}
			catch (SdkException exception)
			{
				Assert.IsTrue((SdkException.ErrorResponseType)exception.ErrorResponseTypes == SdkException.ErrorResponseType.LI);
				Assert.IsTrue(exception.getHttpStatusCode() == 400);
			}catch(Exception e){
				Assert.Fail("Unexpected Exception");
			}
		}

		[TestMethod]
		public void getDemographicsByLocationBadRequestTestAsync()
		{

			try
			{
				Boolean failFlag = false;
				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) =>
				{
					
					
					try
					{
						Assert.IsTrue((SdkException.ErrorResponseType)eventArgs.SDKException.ErrorResponseTypes == SdkException.ErrorResponseType.LI);
						Assert.IsTrue(eventArgs.SDKException.getHttpStatusCode() == 400);
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				};
				mGeoLifeService.getDemographicsByLocationAsync(35.0118D, -81.9571D, "Invalid Values", "agetheme");
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
		public void getDemographicsByLocationNoFilterTest() {
			try{
				GeoLifeResponseDemographics response = mGeoLifeService.getDemographicsByLocation(35.0118D,-81.9571D,null, null);
				Assert.IsInstanceOfType(response, typeof(GeoLifeResponseDemographics));
			}catch(Exception e){
				Assert.Fail("Unexpected Exception");
			}
		}

		[TestMethod]
		public void getDemographicsByLocationNoFilterTestAsync()
		{

			try
			{
				Boolean failFlag = false;

				this.TriggerTest = new AutoResetEvent(false);
				mGeoLifeService.LiAPIEventGeoLifeDemographics += (object sender, WebResponseEventArgs<GeoLifeResponseDemographics> eventArgs) =>
				{
					
					
					try
					{
						Assert.IsInstanceOfType(eventArgs.ResponseObject, typeof(GeoLifeResponseDemographics));
						this.TriggerTest.Set();
					}
					catch (Exception)
					{
						failFlag = true;
						this.TriggerTest.Set();

					}
				};
				mGeoLifeService.getDemographicsByLocationAsync(35.0118D, -81.9571D, null, null);
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
		public void testGetGeolifeByLocationAndCompareSDKResponseTest()
		{
			try
			{
				GeoLifeResponseDemographics response = mGeoLifeService.getDemographicsByLocation(35.0118D, -81.9571D, "top3Ascending", "agetheme");
				String serviceEndPoint = "/geolife/v1/demographics/bylocation";
				Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
				keyValueMap.Add("latitude", 35.0118);
				keyValueMap.Add("longitude", -81.9571);
				keyValueMap.Add("profile", "top3Ascending");
				keyValueMap.Add("filter", "agetheme");
			   
				String responseJSON = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);
				JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
				String sdkResponseString = jsonSerializer.Serialize(response);
		 //     Assert.AreEqual(sdkResponseString, responseJSON);
				GeoLifeResponseDemographics apiResponse= jsonSerializer.Deserialize<GeoLifeResponseDemographics>(responseJSON);
			   // Assert.AreEqual(response.boundaries.boundary[0].boundaryid,apiResponse.themes.age.boundaryid);


				Assert.AreEqual(response.themes.ageTheme.boundaryRef, apiResponse.themes.ageTheme.boundaryRef);
			}
			catch (Exception e)
			{
				Assert.Fail("Unexpected Exception");
			}
		}

		[TestMethod]
		public void testGetGeolifeByAddressAndCompareSDKResponseTest()
		{
			try
			{
				GeoLifeResponseDemographics response = mGeoLifeService.getDemographicsByAddress("1 Global View, Troy, NY", "USA", "top3Ascending", "agetheme");
				String serviceEndPoint = "/geolife/v1/demographics/byaddress";
				Dictionary<String, Object> keyValueMap = new Dictionary<String, Object>();
				keyValueMap.Add("address", "1 Global View, Troy, NY");
				keyValueMap.Add("country", "USA");
				keyValueMap.Add("profile", "top3Ascending");
				keyValueMap.Add("filter", "agetheme");
				String responseJSON = TestUtility.getJSONResponseFromAPI(TEST_URL, serviceEndPoint, keyValueMap);
				JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
				String sdkResponseString = jsonSerializer.Serialize(response);
				//       Assert.AreEqual(sdkResponseString, responseJSON);
				GeoLifeResponseDemographics apiResponse = jsonSerializer.Deserialize<GeoLifeResponseDemographics>(responseJSON);
				//Assert.AreEqual(response.themes.age.boundaryid, apiResponse.themes.age.boundaryid);
				Assert.AreEqual(response.themes.ageTheme.boundaryRef, apiResponse.themes.ageTheme.boundaryRef);
			}
			catch (Exception e)
			{
				Assert.Fail("Unexpected Exception");
			}
		}



		[TestMethod]
		public void segmentationByLocationTest()
		{
			try
			{
				GeoLifeResponseSegmentation segmentation = mGeoLifeService.getSegmentationByLocation(-81.9571, 35.0118);
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
				mGeoLifeService.LiAPIEventGeoLifeSegmentation += (object sender, WebResponseEventArgs<GeoLifeResponseSegmentation> eventArgs) =>
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
				mGeoLifeService.getSegmentationByLocationAsync(-81.9571, 35.0118);
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
				GeoLifeResponseSegmentation segmentation = mGeoLifeService.getSegmentationByAddress("1 Global View, Troy, NY");
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
				mGeoLifeService.LiAPIEventGeoLifeSegmentation += (object sender, WebResponseEventArgs<GeoLifeResponseSegmentation> eventArgs) =>
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
				GeoLifeResponseSegmentation segmentation = mGeoLifeService.getSegmentationByAddress("1 Global View, Troy, NY", "USA");
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
			mGeoLifeService = null;
		}

	}
	
}
