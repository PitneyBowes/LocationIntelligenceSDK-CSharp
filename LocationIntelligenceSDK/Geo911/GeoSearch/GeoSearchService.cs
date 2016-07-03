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

using System;

namespace com.pb.locationintelligence.geosearch
{
    /// <summary>
    /// This service provides local search capabilities into your apps and services.
    ///It provides both independent and neutral local search information based on
    ///the input of search text and location coordinate w.r.t requested Address or
    ///Latitude-Longitude
    /// </summary>
public interface GeoSearchService {



    /// <summary>
    ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
    ///  which has information regarding the response object and exception occurred
    ///
    /// </summary>
    event EventHandler<WebResponseEventArgs<Locations>> LiAPIRequestFinishedEvent;


    /// <summary>
    /// Accepts searchText , latitude and longitude information and gets the Locations information.
    /// </summary>
    /// <param name="searchText">Mandatory - The input to be searched.</param>
    /// <param name="latitude">Mandatory - The latitude of the location.</param>
    /// <param name="longitude">Mandatory - The longitude of the location.</param>
    /// <returns>Locations</returns>
     Locations geoSearch(String searchText,
                          Double latitude, Double longitude);

     /// <summary>
     /// Accepts searchText , latitude ,longitude,searchRadius,searchRadiusUnit and maxCandidates information and 
     /// gets the Locations information .
     /// </summary>
     /// <param name="searchText">Mandatory - The input to be searched.</param>
     /// <param name="latitude">Mandatory - The latitude of the location.</param>
     /// <param name="longitude">Mandatory - The longitude of the location.</param>
     /// <param name="searchRadius">Optional - The radius from the given co-ordinates in which to
     /// search for results.</param>
     /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius.The acceptable unit
     ///            values are: Feet, Kilometers, Miles and Meters. The
     ///            searchRadiusUnit is optional, if not provided; the Feet
     ///            value is taken by default. The specified values are
     ///            case-insensitive.</param>
     /// <param name="maxCandidates">Optional - Maximum number of results to return.</param>
     /// <returns>Locations</returns>
     Locations geoSearch(String searchText,
                          Double latitude, Double longitude,
                          float? searchRadius, String searchRadiusUnit,
                          int? maxCandidates);


     
     /// <summary>
     /// Accepts searchText , latitude and longitude information and gets the Locations information in Asynchronous mode.
     /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
     /// </summary>
     /// <param name="searchText">Mandatory - The input to be searched.</param>
     /// <param name="latitude">Mandatory - The latitude of the location.</param>
     /// <param name="longitude">Mandatory - The longitude of the location.</param>
     /// <returns>void</returns>
     void geoSearchAsync(String searchText,
                          Double latitude, Double longitude);




     /// <summary>
     /// Accepts searchText , latitude ,longitude,searchRadius,searchRadiusUnit and maxCandidates information and gets the Locations information in Asynchronous mode.
     /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
     /// </summary>
     /// <param name="searchText">Mandatory - The input to be searched.</param>
     /// <param name="latitude">Mandatory - The latitude of the location.</param>
     /// <param name="longitude">Mandatory - The longitude of the location.</param>
     /// <param name="searchRadius">Optional - The radius from the given co-ordinates in which to
     /// search for results.</param>
     /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius.The acceptable unit
     ///            values are: Feet, Kilometers, Miles and Meters. The
     ///            searchRadiusUnit is optional, if not provided; the Feet
     ///            value is taken by default. The specified values are
     ///            case-insensitive.</param>
     /// <param name="maxCandidates">Optional - Maximum number of results to return.</param>
     /// <returns>void</returns>
     void geoSearchAsync(String searchText,
                          Double latitude, Double longitude,
                          float? searchRadius, String searchRadiusUnit,
                          int? maxCandidates);

}

}