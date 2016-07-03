#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.segmentation.model;
using System;
using com.pb.locationintelligence.common.model;
using com.pb.locationintelligence.common;

namespace com.pb.locationintelligence.segmentation
{
/**
 * This Service provides lifestyle segmentation data for a specific area.
 *
 */
public interface SegmentationService {

    /// <summary>
    ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
    ///  which has information regarding the response object and exception occurred
    ///
    /// </summary>
    event EventHandler<WebResponseEventArgs<Segmentation>> LiAPIRequestFinishedEvent;

    /// <summary>
    /// Gets the segmentation by address.
    /// </summary>
    /// <param name="address">Required - address text.</param>
    /// <param name="country">Optional - Country Code
    ///        Acceptable list of country codes: USA,CAN,AUS,SWE,JPN,GBR.</param>
    /// <returns></returns>
    Segmentation getSegmentationByAddress(String address, String country="USA");

    
    
    /// <summary>
    /// Gets the segmentation by location.
    /// </summary>
    /// <param name="longitude">Required - longitude of the location.</param>
    /// <param name="latitude">Required - latitude of the location.</param>
    /// <returns></returns>
    Segmentation getSegmentationByLocation(Double longitude, Double latitude);

    
    /// <summary>
    /// Gets the segmentation by address asynchronous.
    /// </summary>
    /// <param name="address">Required - The address.</param>
    /// <param name="country">Optional -  The country.</param>
    void getSegmentationByAddressAsync(String address, String country="USA");
    
    
    /// <summary>
    /// Gets the segmentation by location asynchronous.
    /// </summary>
    /// <param name="longitude">Required - The longitude.</param>
    /// <param name="latitude">Required - The latitude.</param>
    void getSegmentationByLocationAsync(Double longitude, Double latitude);


    }
}