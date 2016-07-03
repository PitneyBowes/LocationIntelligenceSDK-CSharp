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
using com.pb.locationintelligence.geo911.model;
using System;

namespace com.pb.locationintelligence.geo911
{
    /// <summary>
    ///  This service provides Life-saving emergency call-routing information (PSAP details) w.r.t requested Address or Latitude-Longitude.
    /// </summary>
    public interface Geo911Service
    {

        /// <summary>
        ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        ///  which has information regarding the response object and exception occurred
        ///
        /// </summary>
        event EventHandler<WebResponseEventArgs<PsapResponse>> LiAPIRequestFinishedEvent;
        
        
        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details.
        /// Accepts the address as input and returns PSAP locations' details
        /// including agency name, phone number, county name, coverage, contact person's
        /// details, site details and mailing address
        /// </summary>
        /// <param name="address">Required - Free-form address text.</param>
        /// <returns>PsapResponse</returns>
        PsapResponse getPSAPByAddress(String address);

        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details.
        ///Accepts latitude and longitude co-ordinates as input and returns PSAP locations' details
        ///including agency name, including agency name, phone number, county name, coverage,
        ///contact person's details, site details and mailing address.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>PsapResponse</returns>
        PsapResponse getPSAPByLocation(Double latitude, Double longitude);

       

        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// Accepts the address as input and returns PSAP locations' details
        /// including agency name, phone number, county name, coverage, contact person's
        /// details, site details and mailing address
        /// </summary>
        /// <param name="address">Required - Free-form address text.</param>
        /// <returns>void</returns>
        void getPSAPByAddressAsync(String address);

        /// <summary>
        /// Retrieves Public Safety Answering Points (PSAP) details.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        ///Accepts latitude and longitude co-ordinates as input and returns PSAP locations' details in Async Mode
        ///including agency name, including agency name, phone number, county name, coverage,
        ///contact person's details, site details and mailing address.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>void</returns>
        void getPSAPByLocationAsync(Double latitude, Double longitude);



    }
}