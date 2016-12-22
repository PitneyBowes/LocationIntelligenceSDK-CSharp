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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.pb.locationintelligence.geocode.model;

namespace com.pb.locationintelligence.geocode
{
    /// <summary>
    /// 
    /// </summary>
    public interface GeocodeService
    {
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred. This event provies Geocode Response
        /// </summary>
        event EventHandler<WebResponseEventArgs<GeocodeResponse>> LiAPIRequestFinishedEvent;
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred. This event provides Capabilities Response
        /// </summary>
        event EventHandler<WebResponseEventArgs<GeocodeCapabilitiesResponse>> LiGeocodeCapabilitiesFinishedEvent;
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred. This event provides Dictionaries Response
        /// </summary>
        event EventHandler<WebResponseEventArgs<ConfiguredDictionaryResponse>> LiConfiguredDictionaryFinishedEvent;

        #region Capabilities

        /// <summary>
        /// This method provides Geocode Capabilities of Geocode API
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="operationType">Type of the operation.</param>
        /// <param name="bundleType">Type of the bundle.</param>
        /// <returns>
        /// GeocodeCapabilitiesResponse
        /// </returns>
        GeocodeCapabilitiesResponse getCapabilities(Country? country = null,OperationType? operationType=null,BundleType bundleType=BundleType.basic);

        /// <summary>
        /// This method provides Geocode Capabilities of Geocode API asynchronously
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="operationType">Type of the operation.</param>
        /// <param name="bundleType">Type of the bundle.</param>
        void getCapabilitiesAsync(Country? country=null, OperationType? operationType=null,  BundleType bundleType = BundleType.basic);

        #endregion

        #region Dictionary 
        /// <summary>
        /// This method provides information about dictionaires which are configured for Geocode API
        /// </summary>
        /// <param name="country">Optional</param>
        /// <param name="bundleType">Optional</param>
        /// <returns>
        /// ConfiguredDictionaryResponse
        /// </returns>
        ConfiguredDictionaryResponse getDictionary(Country? country=null,  BundleType bundleType = BundleType.basic);




        /// <summary>
        /// This method provides information about dictionaires which are configured for Geocode API asynchronously
        /// </summary>
        /// <param name="country">Optional</param>
        /// <param name="bundleType">Optional</param>
        void getDictionaryAsync(Country? country=null,  BundleType bundleType = BundleType.basic);
        #endregion

        #region Geocode

        /// <summary>
        /// This method geocodes Address
        /// </summary>
        /// <param name="address">required</param>
        /// <param name="geocodeType">required</param>
        /// <param name="bundleType">required</param>
        /// <returns>
        /// GeocodeResponse
        /// </returns>
        GeocodeResponse getGeocode(Address address,GeocodeType geocodeType, BundleType bundleType);

        /// <summary>
        /// This method geocodes Address asynchronously
        /// </summary>
        /// <param name="address">required</param>
        /// <param name="geocodeType">required</param>
        /// <param name="bundleType">required</param>
        void getGeocodeAsync(Address address, GeocodeType geocodeType, BundleType bundleType);

        /// <summary>
        /// This method geocodes multiple  Addresses
        /// </summary>
        /// <param name="address">required</param>
        /// <param name="geocodeType">required</param>
        /// <param name="bundleType">required</param>
        /// <returns></returns>
        GeocodeResponse getGeocodeBatch(IList<Address> address, GeocodeType geocodeType,BundleType bundleType);

        /// <summary>
        /// This method geocodes multiple  Addresses asynchronously
        /// </summary>
        /// <param name="address">required</param>
        /// <param name="geocodeType">required</param>
        /// <param name="bundleType">required</param>
        void getGeocodeBatchAsync(IList<Address> address, GeocodeType geocodeType, BundleType bundleType);

        /// <summary>
        /// This method geocodes multiple  Addresses and Preferences can  also be passed to change default behaviour of Geocoder
        /// </summary>
        /// <param name="address">required</param>
        /// <param name="geocodeType">required</param>
        /// <param name="bundleType">required</param>
        /// <param name="preferenceBuilder">required</param>
        /// <returns></returns>
        GeocodeResponse getGeocodeAdvanceBatch(IList<Address> address, GeocodeType geocodeType,  BundleType bundleType, GeocodePreferenceBuilder preferenceBuilder);

        /// <summary>
        /// This method geocodes multiple  Addresses and Preferences can  also be passed to change default behaviour of Geocoder asynchronously
        /// </summary>
        /// <param name="address">required</param>
        /// <param name="geocodeType">required</param>
        /// <param name="bundleType">required</param>
        /// <param name="preferenceBuilder">required</param>
        void getGeocodeAdvanceBatchAsync(IList<Address> address, GeocodeType geocodeType, BundleType bundleType, GeocodePreferenceBuilder preferenceBuilder);

        #endregion

        #region ReverseGeocode

        /// <summary>
        /// This method reverse geocode a given point
        /// </summary>
        /// <param name="points">required</param>
        /// <returns>
        /// GeocodeResponse
        /// </returns>
        GeocodeResponse getReverseGeocode(BundleType bundleType, Points points);
        /// <summary>
        /// This method reverse Geocodes a list of point
        /// </summary>
        /// <param name="points">required</param>
        /// <returns>
        /// GeocodeResponse
        /// </returns>
        GeocodeResponse getReverseGeocodeBatch(BundleType bundleType, IList<Points> points);

        /// <summary>
        /// This method reverse Geocodes a list of point and Preferences can  also be passed to change default behaviour of Geocoder
        /// </summary>
        /// <param name="points">required</param>
        /// <param name="preferenceBuilder">required</param>
        /// <returns></returns>
        GeocodeResponse getReverseGeocodeAdvanceBatch(BundleType bundleType, IList<Points> points, GeocodePreferenceBuilder preferenceBuilder);

        /// <summary>
        /// This method reverse geocode a given point asynchronously
        /// </summary>
        /// <param name="points">required</param>

        void getReverseGeocodeAsync(BundleType bundleType, Points points);

        /// <summary>
        /// This method reverse Geocodes a list of point asynchronously
        /// </summary>
        /// <param name="points">required</param>
        void getReverseGeocodeBatchAsync(BundleType bundleType, IList<Points> points);

        /// <summary>
        /// This method reverse Geocodes a list of point and Preferences can  also be passed to change default behaviour of Geocoder asynchronously
        /// </summary>
        /// <param name="points">required</param>
        /// <param name="preferenceBuilder">required</param>
        void getReverseGeocodeAdvanceBatchAsync(BundleType bundleType, IList<Points> points,  GeocodePreferenceBuilder preferenceBuilder);

        #endregion
    }
}
