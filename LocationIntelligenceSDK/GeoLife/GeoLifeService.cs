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
using com.pb.locationintelligence;
using com.pb.locationintelligence.geolife.model;
using com.pb.locationintelligence.common;

namespace com.pb.locationintelligence.geolife
{

    /// <summary>
    /// This Service provides demographic data and lifestyle characteristics for a specific area.
    /// </summary>
public interface GeoLifeService {


    /// <summary>
    ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
    ///  which has information regarding the response object and exception occurred
    ///
    /// </summary>
    event EventHandler<WebResponseEventArgs<GeoLifeResponse>> LiAPIRequestFinishedEvent;
	
	/// <summary>
    /// Returns the geodemographic variables - age, gender, marital status, ethnicity, and household income
	/// based on an address provided
    /// </summary>
    /// <param name="address">Required - address text</param>
    /// <param name="country">The country.</param>
    /// <param name="profile">
    /// Optional - Pre-defined profiles sets. Below are the values:
	///'Top5Ascending': Retrieves the top 5 results in ascending order.
	///'Top5Descending': Retrieves the top 5 results in descending order.
	///'Top3Ascending': Retrieves the top 3 results in ascending order.
    ///'Top3Descending': Retrieves the top 3 results in descending order
    ///</param>
    /// <param name="filter">
    /// Optional - Represents demographic themes to narrow down search results
	///for example; AgeTheme, IncomeTheme, EthnicityTheme.
    ///Maximum number of themes that can be provided as a filter are 10.
    /// </param>
    /// <returns>GeoLifeResponse</returns>
     GeoLifeResponse getDemographicsByAddress(String address,String country, String profile, String filter);
    
     /// <summary>
     /// Returns the geodemographic variables - age, gender, marital status, ethnicity, and household income based on the location provided.
     /// </summary>
     /// <param name="latitude">Required - latitude of the location.</param>
     /// <param name="longitude">Required - longitude of the location.</param>
     /// <param name="profile">
     /// Optional - Pre-defined profiles sets. Below are the values:
     ///'Top5Ascending': Retrieves the top 5 results in ascending order.
     ///'Top5Descending': Retrieves the top 5 results in descending order.
     ///'Top3Ascending': Retrieves the top 3 results in ascending order.
     ///'Top3Descending': Retrieves the top 3 results in descending order
     ///</param>
     /// <param name="filter">
     /// Optional - Represents demographic themes to narrow down search results
     ///for example; AgeTheme, IncomeTheme, EthnicityTheme.
     ///Maximum number of themes that can be provided as a filter are 10.
     /// </param>
     /// <returns>GeoLifeResponse</returns>
     GeoLifeResponse getDemographicsByLocation(Double latitude, Double longitude, String profile, String filter);

     /// <summary>
     /// Returns the geodemographic variables - age, gender, marital status, ethnicity, and household income
     /// based on an address provided Asynchronously . Event LiAPIRequestFinishedEvent gets raised when request finishes which 
     /// contains response object.
     /// </summary>
     /// <param name="address">Required - address text</param>
     /// <param name="country">The country.</param>
     /// <param name="profile">
     /// Optional - Pre-defined profiles sets. Below are the values:
     ///'Top5Ascending': Retrieves the top 5 results in ascending order.
     ///'Top5Descending': Retrieves the top 5 results in descending order.
     ///'Top3Ascending': Retrieves the top 3 results in ascending order.
     ///'Top3Descending': Retrieves the top 3 results in descending order
     ///</param>
     /// <param name="filter">
     /// Optional - Represents demographic themes to narrow down search results
     ///for example; AgeTheme, IncomeTheme, EthnicityTheme.
     ///Maximum number of themes that can be provided as a filter are 10.
     /// </param>
     /// <returns>Void</returns>
     void getDemographicsByAddressAsync(String address,String country, String profile, String filter);


     /// <summary>
     /// Returns the geodemographic variables - age, gender, marital status, ethnicity, 
     /// and household income based on the location provided  Asynchronously .Event LiAPIRequestFinishedEvent gets raised when request finishes which 
     /// contains response object.
     /// </summary>
     /// <param name="latitude">Required - latitude of the location.</param>
     /// <param name="longitude">Required - longitude of the location.</param>
     /// <param name="profile">
     /// Optional - Pre-defined profiles sets. Below are the values:
     ///'Top5Ascending': Retrieves the top 5 results in ascending order.
     ///'Top5Descending': Retrieves the top 5 results in descending order.
     ///'Top3Ascending': Retrieves the top 3 results in ascending order.
     ///'Top3Descending': Retrieves the top 3 results in descending order
     ///</param>
     /// <param name="filter">
     /// Optional - Represents demographic themes to narrow down search results
     ///for example; AgeTheme, IncomeTheme, EthnicityTheme.
     ///Maximum number of themes that can be provided as a filter are 10.
     /// </param>
     /// <returns>void</returns>
     void getDemographicsByLocationAsync(Double latitude, Double longitude, String profile, String filter);

}
}