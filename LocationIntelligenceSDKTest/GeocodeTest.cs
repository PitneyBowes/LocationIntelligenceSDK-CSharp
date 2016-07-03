#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.geocode;
using com.pb.locationintelligence.manager;
using com.pb.locationintelligence.oauth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using com.pb.locationintelligence.geocode.model;
using com.pb.locationintelligence.common;
using System.Collections.Generic;

namespace LocationIntelligenceSDKTest
{
    [TestClass]
    public class GeocodeTest
    {
        private static GeocodeService geocodeService;
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
            geocodeService = liServiceManager.getGeocodeService();

        }



        #region Capabilities
        [TestMethod]
        public void getGeocodeCapabilitiesTest()
        {
            try
            {

                GeocodeCapabilitiesResponse response = geocodeService.getCapabilities();
                Assert.IsInstanceOfType(response, typeof(GeocodeCapabilitiesResponse));
               

            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getGeocodeCapabilitiesWithCountryTest()
        {
            try
            {

                GeocodeCapabilitiesResponse response = geocodeService.getCapabilities(Country.AMERICAN_SAMOA);
                Assert.IsInstanceOfType(response, typeof(GeocodeCapabilitiesResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getCapabilitiesTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geocodeService.LiGeocodeCapabilitiesFinishedEvent += (object sender, WebResponseEventArgs<GeocodeCapabilitiesResponse> eventArgs) =>
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
                geocodeService.getCapabilities(Country.AMERICAN_SAMOA, OperationType.Geocode);
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

        #endregion

        #region Dictionaries 
        [TestMethod]
        public void getDictionaryTest()
        {
            try
            {

                ConfiguredDictionaryResponse response = geocodeService.getDictionary();
                Assert.IsInstanceOfType(response, typeof(ConfiguredDictionaryResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }




        [TestMethod]
        public void getDictionaryTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geocodeService.LiConfiguredDictionaryFinishedEvent += (object sender, WebResponseEventArgs<ConfiguredDictionaryResponse> eventArgs) =>
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
                geocodeService.getDictionary();
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

        #endregion

        #region Geocode

        [TestMethod]
        public void getGeocodeTest()
        {
            try
            {
                Address add = new Address();
                add.MainAddressLine = "4750 Walnut St., Boulder CO, 80301";
                add.Country = "USA";

                GeocodeResponse response = geocodeService.getGeocode(add,GeocodeType.ADDRESS, BundleType.Premium);
                Assert.IsInstanceOfType(response, typeof(GeocodeResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void getGeocodeTestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                geocodeService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<GeocodeResponse> eventArgs) =>
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
                Address add = new Address();
                add.MainAddressLine = "4750 Walnut St., Boulder CO, 80301";
                add.Country = "USA";

               geocodeService.getGeocodeAsync(add, GeocodeType.ADDRESS, BundleType.Premium);

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
        public void getGeocodePreferenceTest()
        {
            try
            {
                Address add = new Address();
                add.MainAddressLine = "4750 Walnut St., Boulder CO, 80301";
                add.Country = "USA";

                GeocodePreferenceBuilder geocodePreferenceBuilder = new GeocodePreferenceBuilder();

                #region Preference
                GeocodePreference geocodePreference = new GeocodePreference();

                        //Must match fields
                        FieldsMatching mustMatchField = new FieldsMatching();
                        mustMatchField.matchOnAddressNumber = true;
                        geocodePreference.mustMatchFields = mustMatchField;


                        //Preferred Dictionary Order
                        geocodePreference.preferredDictionaryOrders = new Dictionary<Country, int[]> { { Country.AMERICAN_SAMOA, new int[] {0,1}}};

                #endregion

                #region ReturnFieldsDescriptorPreferences
                
                GeocodeReturnFieldsDescriptor geocodeReturnFieldsDescriptor = new GeocodeReturnFieldsDescriptor();
                geocodeReturnFieldsDescriptor.ReturnedCustomFieldKeys = new List<ReturnedCustomFieldsKeys> { ReturnedCustomFieldsKeys.NZL_ORIGINAL_LONGITUDE };
                geocodePreferenceBuilder.ReturnFieldsDescriptorPreferences = geocodeReturnFieldsDescriptor;

                #endregion

                #region CustomPreference

                List<ICustomPreference> customList = new List<ICustomPreference>();


                ICustomPreference customPrefernce = CustomPreferenceFactory.GetCustomPreference();

                customPrefernce.FALLBACK_TO_WORLD = true;
                customPrefernce.distanceUnits = DistanceUnits.FEET;
                customList.Add(customPrefernce);


                ICustomPreferenceUSA customPrefernceUSA = CustomPreferenceFactory.GetCustomPreferenceUSA();

                customPrefernce.FALLBACK_TO_WORLD = true;
               customPrefernce.distanceUnits = DistanceUnits.FEET;
                customList.Add(customPrefernceUSA);




                ICustomPreference customPrefernceArgentena = CustomPreferenceFactory.GetCustomPreference(Country.ARGENTINA);

                customPrefernce.FALLBACK_TO_WORLD = true;
                customPrefernce.distanceUnits = DistanceUnits.FEET;
                customList.Add(customPrefernceArgentena);


                geocodePreferenceBuilder.CustomPreference = customList;

                #endregion

                //CustomPreference
                geocodePreferenceBuilder.GeocodePreference = geocodePreference;
                GeocodeResponse response = geocodeService.getGeocodeAdvanceBatch(new List<Address> { add }, GeocodeType.ADDRESS, BundleType.Basic, geocodePreferenceBuilder);
                Assert.IsInstanceOfType(response, typeof(GeocodeResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        #endregion

        #region Reverse Geocode
        [TestMethod]
        public void getReverseGeocodeTest()
        {
            try
            {
                Points points = new Points();
                points.Country = "USA";

                GeoPos geoposition = new GeoPos();

                List <double> lst = new List<double>();
                lst.Add(12.025594);
                lst.Add(57.712891);
                geoposition.Coordinates = lst;
                geoposition.Type = "point";

                

                Crs crs = new Crs();
                crs.Type="name";
                Properties properties = new Properties();
                properties.Name = "EPSG:4326";
                crs.Properties = properties;


                geoposition.Crs = crs;

                points.Geometry = geoposition;

                GeocodeResponse response = geocodeService.getReverseGeocode(points);
                Assert.IsInstanceOfType(response, typeof(GeocodeResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }


        [TestMethod]
        public void getReverseGeocodeTestAsync()
        {
           
               
                

                try
                {
                    Boolean failFlag = false;
                    this.TriggerTest = new AutoResetEvent(false);
                    geocodeService.LiAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<GeocodeResponse> eventArgs) =>
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
                    Points points = new Points();
                    points.Country = "USA";

                    GeoPos geoposition = new GeoPos();

                    List<double> list = new List<double>();
                    list.Add(-78.009);
                    list.Add(39.52);
                    geoposition.Coordinates = list;
                    geoposition.Type = "point";



                    Crs crs = new Crs();
                    crs.Type = "name";
                    Properties properties = new Properties();
                    properties.Name = "EPSG:4326";
                    crs.Properties = properties;


                    geoposition.Crs = crs;

                    points.Geometry = geoposition;

                    geocodeService.getReverseGeocodeAsync(points);

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
        public void getReverseGeocodePreferenceTest()
        {
            try
            {
                Points points = new Points();
                points.Country = "USA";

                GeoPos geoposition = new GeoPos();

                List<double> lst = new List<double>();
                lst.Add(-78.009);
                lst.Add(39.52);
                geoposition.Coordinates = lst;
                geoposition.Type = "point";



                Crs crs = new Crs();
                crs.Type = "name";
                Properties properties = new Properties();
                properties.Name = "EPSG:4326";
                crs.Properties = properties;


                geoposition.Crs = crs;

                points.Geometry = geoposition;

                GeocodePreferenceBuilder geocodePreferenceBuilder = new GeocodePreferenceBuilder();

                #region Preference
                GeocodePreference geocodePreference = new GeocodePreference();

                //Must match fields
                FieldsMatching mustMatchField = new FieldsMatching();
                mustMatchField.matchOnAddressNumber = true;
                geocodePreference.mustMatchFields = mustMatchField;


                //Preferred Dictionary Order
                geocodePreference.preferredDictionaryOrders = new Dictionary<Country, int[]> { { Country.AMERICAN_SAMOA, new int[] { 0, 1 } } };

                #endregion

                #region ReturnFieldsDescriptorPreferences

                GeocodeReturnFieldsDescriptor geocodeReturnFieldsDescriptor = new GeocodeReturnFieldsDescriptor();
                geocodeReturnFieldsDescriptor.ReturnedCustomFieldKeys = new List<ReturnedCustomFieldsKeys> { ReturnedCustomFieldsKeys.NZL_ORIGINAL_LONGITUDE };
                geocodePreferenceBuilder.ReturnFieldsDescriptorPreferences = geocodeReturnFieldsDescriptor;

                #endregion

                #region CustomPreference

                List<ICustomPreference> customList = new List<ICustomPreference>();


                ICustomPreference customPrefernce = CustomPreferenceFactory.GetCustomPreference();

                customPrefernce.FALLBACK_TO_WORLD = true;
                customPrefernce.distanceUnits = DistanceUnits.FEET;
                customList.Add(customPrefernce);


                ICustomPreferenceUSA customPrefernceUSA = CustomPreferenceFactory.GetCustomPreferenceUSA();

                customPrefernce.FALLBACK_TO_WORLD = true;
                customPrefernce.distanceUnits = DistanceUnits.FEET;
                customList.Add(customPrefernceUSA);




                ICustomPreference customPrefernceArgentena = CustomPreferenceFactory.GetCustomPreference(Country.ARGENTINA);

                customPrefernce.FALLBACK_TO_WORLD = true;
                customPrefernce.distanceUnits = DistanceUnits.FEET;
                customList.Add(customPrefernceArgentena);


                geocodePreferenceBuilder.CustomPreference = customList;
                #endregion

                //CustomPreference
                geocodePreferenceBuilder.GeocodePreference = geocodePreference;
                GeocodeResponse response = geocodeService.getReverseGeocodeAdvanceBatch(new List<Points> { points }, geocodePreferenceBuilder);
                Assert.IsInstanceOfType(response, typeof(GeocodeResponse));


            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }
        #endregion

    }
}
