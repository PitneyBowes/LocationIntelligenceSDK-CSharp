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

namespace com.pb.locationintelligence.geoenhance
{
    /// <summary>
    /// This Interface provides implementation for accessing Location Intelligence GeoEnhanceAPI.
    /// </summary>
    public interface GeoEnhanceService
    {
        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        event EventHandler<WebResponseEventArgs<Locations>> LiAPIRequestFinishedEvent;
        /// <summary>
        /// Occurs when [li time zone API request finished event].
        /// </summary>
        event EventHandler<WebResponseEventArgs<TimezoneResponse>> LiTimeZoneAPIRequestFinishedEvent;

        /// <summary>
        /// Accepts longitude and latitude and returns an Address for that location.
        /// </summary>
        /// <param name="latitude">Required - Latitude of the location.</param>
        /// <param name="longitude">Required - Longitude of the location.</param>
        /// <param name="searchRadius">Optional - Search Radius, in feet. Default Value is 150 feet,
        /// Allowed range is 0- 5280 feet.</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        /// <returns>
        /// Locations
        /// </returns>
        Locations getAddress(Double latitude, Double longitude,
                              float? searchRadius, String searchRadiusUnit);

        /// <summary>
        /// Accepts longitude and latitude and returns an Address for that location in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="latitude">Required - Latitude of the location.</param>
        /// <param name="longitude">Required - Longitude of the location.</param>
        /// <param name="searchRadius">Optional - Search Radius, in feet. Default Value is 150 feet,
        /// Allowed range is 0- 5280 feet.</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        void getAddressAsync(Double latitude, Double longitude,
                              float? searchRadius, String searchRadiusUnit);

        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets the place information.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="levelHint">Optional - Level of Information. Below are the numeric codes
        /// for geographic hierarchy level: LEVEL 1 = Country LEVEL 2 =
        /// State or equivalent LEVEL 3 = District or equivalent LEVEL 4
        /// =City or Town LEVEL 5 = Locality LEVEL 6 = Neighbourhood If
        /// not provided, returns the lowest geographic hierarchy level
        /// information available
        /// .</param>
        /// <returns>
        /// Locations
        /// </returns>
        Locations getPlace(Double latitude, Double longitude, int? levelHint);

        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets the place information in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="levelHint">Optional - Level of Information. Below are the numeric codes
        /// for geographic hierarchy level: LEVEL 1 = Country LEVEL 2 =
        /// State or equivalent LEVEL 3 = District or equivalent LEVEL 4
        /// =City or Town LEVEL 5 = Locality LEVEL 6 = Neighbourhood If
        /// not provided, returns the lowest geographic hierarchy level
        /// information available
        /// .</param>
        void getPlaceAsync(Double latitude, Double longitude, int? levelHint);

        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets Point of Interests (POI) information.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="category">Optional - Category or Sub-Category to refine the POI search
        /// results.</param>
        /// <param name="maxCandidates">Optional - Maximum number of POIs that will be returned
        /// Default is 10</param>
        /// <param name="searchRadius">Optional - Search Radius, in miles. Default Value is 2 miles,
        /// Allowed range is 0-50 miles</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        /// <param name="searchDataset">Optional - Comma-separated input of dataSet names ('PBData'
        /// for searching in PB Data)..</param>
        /// <param name="searchPriority">Optional - Define priority while searching on DataSets.
        /// Allowed values are Y/N..</param>
        /// <returns>
        /// Locations
        /// </returns>
        Locations getPOI(Double latitude, Double longitude,
                          String category, int? maxCandidates, float? searchRadius,
                          String searchRadiusUnit, String searchDataset,
                          String searchPriority);

        /// <summary>
        /// Accepts latitude , longitude and levelHint information and gets Point of Interests (POI) information in asynchronous mode.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <param name="category">Optional - Category or Sub-Category to refine the POI search
        /// results.</param>
        /// <param name="maxCandidates">Optional - Maximum number of POIs that will be returned
        /// Default is 10</param>
        /// <param name="searchRadius">Optional - Search Radius, in miles. Default Value is 2 miles,
        /// Allowed range is 0-50 miles</param>
        /// <param name="searchRadiusUnit">Optional - Unit used for searchRadius. Allowed values are
        /// FEET,METERS,MILES,KILOMETERS (Case insensitive).</param>
        /// <param name="searchDataset">Optional - Comma-separated input of dataSet names ('PBData'
        /// for searching in PB Data)..</param>
        /// <param name="searchPriority">Optional - Define priority while searching on DataSets.
        /// Allowed values are Y/N..</param>
        void getPOIAsync(Double latitude, Double longitude,
                           String category, int? maxCandidates, float? searchRadius,
                           String searchRadiusUnit, String searchDataset,
                           String searchPriority);

        /// <summary>
        /// Accepts latitude , longitude and timestamp and returns the timezone information applicable including
        /// utcoffset and dstoffset.
        /// </summary>
        /// <param name="timestamp">Required - timestamp in UTC milliseconds
        /// returns the TimezoneResponse information applicable at the given timestamp at the specific location
        /// .</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        /// <returns>
        /// TimezoneResponse
        /// </returns>
        TimezoneResponse getTimezone(long timestamp,Double latitude, Double longitude);

        /// <summary>
        /// Accepts latitude , longitude and timestamp information and gets the applicable timezone information
        /// including utcoffset and dstoffset.
        /// Response can be retrieved by subscribing to event LiAPIRequestFinishedEvent.
        /// </summary>
        /// <param name="timestamp">Required - timestamp in UTC milliseconds
        /// returns the TimezoneResponse information applicable at the given timestamp at the specific timestamp
        /// .</param>
        /// <param name="latitude">Required - latitude of the location.</param>
        /// <param name="longitude">Required - longitude of the location.</param>
        void getTimezoneAsync(long timestamp,Double latitude, Double longitude);

    }
}