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

using com.pb.locationintelligence.geocomm.model;
using com.pb.locationintelligence.common;
namespace com.pb.locationintelligence.geocomm

{
    /// <summary>
    /// This service provides rate center details w.r.t requested Address or Latitude-Longitude.
    /// </summary>
   public  interface GeoCommService
    {

        event EventHandler<WebResponseEventArgs<RateCenterResponse>> LiAPIRequestFinishedEvent;

        #region Http GetMethod Calls

        /// <summary>
        /// Accepts address, country, areaCodeInfo and level information and gets the GeoComm Rate information.
        /// </summary>
        /// <param name="address">Required - Address.</param>
        /// <param name="country">optional - default is "USA".</param>
        /// <param name="areaCodeInfo">optional - flag to get AreaCodeInfo in response.</param>
        /// <param name="level">optional - default is "basic".</param>
        /// <returns>
        /// RateCenterResponse
        /// </returns>
        RateCenterResponse getRateCenterByAddress(String address, String country, Boolean areaCodeInfo, String level);

        /// <summary>
        /// Accepts address, country, areaCodeInfo and level information and gets the GeoComm Rate information.
        /// </summary>
        /// <param name="address">Required - Address.</param>
        /// <param name="country">optional - default is "USA".</param>
        /// <param name="areaCodeInfo">optional - flag to get AreaCodeInfo in response.</param>
        /// <param name="level">optional - default is "basic".</param>
        /// <returns>
        /// </returns>
        void getRateCenterByAddressAsync(String address, String country, Boolean areaCodeInfo, String level);

        /// <summary>
        /// Accepts latitude, longitude, areaCodeInfo and level information and gets the GeoComm Rate information.
        /// </summary>
        /// <param name="latitude">Required - latitude.</param>
        /// <param name="longitude">Required - longitude is "USA".</param>
        /// <param name="areaCodeInfo">optional - flag to get AreaCodeInfo in response.</param>
        /// <param name="level">optional - default is "basic".</param>
        /// <returns>
        /// </returns>
        RateCenterResponse getRateCenterByLocation(Double latitude, Double longitude, Boolean areaCodeInfo, String level);

        /// <summary>
        /// Accepts latitude, longitude, areaCodeInfo and level information and gets the GeoComm Rate information.
        /// </summary>
        /// <param name="latitude">Required - latitude.</param>
        /// <param name="longitude">Required - longitude is "USA".</param>
        /// <param name="areaCodeInfo">optional - flag to get AreaCodeInfo in response.</param>
        /// <param name="level">optional - default is "basic".</param>
        /// <returns>
        /// </returns>
        void getRateCenterByLocationAsync(Double latitude, Double longitude, Boolean areaCodeInfo, String level);
    }
}
#endregion