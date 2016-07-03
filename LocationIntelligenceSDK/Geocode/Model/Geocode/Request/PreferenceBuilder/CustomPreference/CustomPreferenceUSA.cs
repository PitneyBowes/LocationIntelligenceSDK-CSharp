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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geocode.model.ICustomPreferenceUSA" />
    public class CustomPreferenceUSA : ICustomPreferenceUSA
    {
        /// <summary>
        /// Gets or sets the fin d_ addrcode.
        /// </summary>
        /// <value>
        /// The fin d_ addrcode.
        /// </value>
        public Boolean? FIND_ADDRCODE { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ addres s_ range].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ addres s_ range]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_ADDRESS_RANGE { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ buildin g_ search].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ buildin g_ search]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_BUILDING_SEARCH { get; set; }

        /// <summary>
        /// Gets or sets the fin d_ centerlin e_ offset.
        /// </summary>
        /// <value>
        /// The fin d_ centerlin e_ offset.
        /// </value>
        public int FIND_CENTERLINE_OFFSET { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ centerl n_ pro j_ o f_ point].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ centerl n_ pro j_ o f_ point]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_CENTERLN_PROJ_OF_POINT { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ correc t_ lastline].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ correc t_ lastline]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_CORRECT_LASTLINE { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ d b_ order].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ d b_ order]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_DB_ORDER { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ DPV].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ DPV]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_DPV { get; set; }

        /// <summary>
        /// Gets or sets the fin d_ expande d_ searc h_ radius.
        /// </summary>
        /// <value>
        /// The fin d_ expande d_ searc h_ radius.
        /// </value>
        public int FIND_EXPANDED_SEARCH_RADIUS { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ expn d_ source h_ li m_ t o_ state].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ expn d_ source h_ li m_ t o_ state]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_EXPND_SRCH_LIM_TO_STATE { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ firs t_ lette r_ expanded].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ firs t_ lette r_ expanded]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_FIRST_LETTER_EXPANDED { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ lacslink].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ lacslink]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_LACSLINK { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ mixe d_ case].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ mixe d_ case]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_MIXED_CASE { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ prefe r_ pobox].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ prefe r_ pobox]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_PREFER_POBOX { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ prefe r_ street].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ prefe r_ street]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_PREFER_STREET { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ prefe r_ zi p_ ove r_ city].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ prefe r_ zi p_ ove r_ city]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_PREFER_ZIP_OVER_CITY { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ searc h_ area].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ searc h_ area]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_SEARCH_AREA { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ stree t_ centroid].
        /// </summary>
        /// <value>
        /// <c>true</c> if [fin d_ stree t_ centroid]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_STREET_CENTROID { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ suitelink].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ suitelink]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_SUITELINK { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ z_ code].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ z_ code]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_Z_CODE { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ Z5_ code].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ Z5_ code]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_Z5_CODE { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ Z7_ code].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ Z7_ code]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_Z7_CODE { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [fin d_ Z9_ code].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [fin d_ Z9_ code]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? FIND_Z9_CODE { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [retur n_ la t_ lo n_ a s_ intege r_ value].
        /// </summary>
        /// <value>
        /// <c>true</c> if [retur n_ la t_ lo n_ a s_ intege r_ value]; otherwise, <c>false</c>.
        /// </value>
        public Boolean? RETURN_LAT_LON_AS_INTEGER_VALUE { get; set; }

        /// <summary>
        /// Gets or sets the name of the client coord system.
        /// </summary>
        /// <value>
        /// The name of the client coord system.
        /// </value>
        public string clientCoordSysName
        { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public Country? Country
        { get; set; }

        /// <summary>
        /// Gets or sets the client locale.
        /// </summary>
        /// <value>
        /// The client locale.
        /// </value>
        public string clientLocale
        { get; set; }

        /// <summary>
        /// Gets or sets the corner offset.
        /// </summary>
        /// <value>
        /// The corner offset.
        /// </value>
        public string cornerOffset
        { get; set; }

        /// <summary>
        /// Gets or sets the corner offset units.
        /// </summary>
        /// <value>
        /// The corner offset units.
        /// </value>
        public string cornerOffsetUnits
        { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public double? distance
        { get; set; }

        /// <summary>
        /// Gets or sets the distance units.
        /// </summary>
        /// <value>
        /// The distance units.
        /// </value>
        public DistanceUnits? distanceUnits
        { get; set; }

        /// <summary>
        /// Gets or sets the fallback to geographic.
        /// </summary>
        /// <value>
        /// The fallback to geographic.
        /// </value>
        public bool? fallbackToGeographic
        { get; set; }

        /// <summary>
        /// Gets or sets the fallback to postal.
        /// </summary>
        /// <value>
        /// The fallback to postal.
        /// </value>
        public bool? fallbackToPostal
        { get; set; }

        /// <summary>
        /// Gets or sets the fallbac k_ t o_ world.
        /// </summary>
        /// <value>
        /// The fallbac k_ t o_ world.
        /// </value>
        public bool? FALLBACK_TO_WORLD
        { get; set; }

        /// <summary>
        /// Gets or sets the match mode.
        /// </summary>
        /// <value>
        /// The match mode.
        /// </value>
        public string matchMode
        { get; set; }

        /// <summary>
        /// Gets or sets the match on address number.
        /// </summary>
        /// <value>
        /// The match on address number.
        /// </value>
        public bool? MatchOnAddressNumber
        { get; set; }

        /// <summary>
        /// Gets or sets the match on all street fields.
        /// </summary>
        /// <value>
        /// The match on all street fields.
        /// </value>
        public bool? MatchOnAllStreetFields
        { get; set; }

        /// <summary>
        /// Gets or sets the match on area name1.
        /// </summary>
        /// <value>
        /// The match on area name1.
        /// </value>
        public bool? MatchOnAreaName1
        { get; set; }

        /// <summary>
        /// Gets or sets the match on area name2.
        /// </summary>
        /// <value>
        /// The match on area name2.
        /// </value>
        public bool? MatchOnAreaName2
        { get; set; }

        /// <summary>
        /// Gets or sets the match on area name3.
        /// </summary>
        /// <value>
        /// The match on area name3.
        /// </value>
        public bool? MatchOnAreaName3
        { get; set; }

        /// <summary>
        /// Gets or sets the match on area name4.
        /// </summary>
        /// <value>
        /// The match on area name4.
        /// </value>
        public bool? MatchOnAreaName4
        { get; set; }

        /// <summary>
        /// Gets or sets the match on input fields.
        /// </summary>
        /// <value>
        /// The match on input fields.
        /// </value>
        public bool? MatchOnInputFields
        { get; set; }

        /// <summary>
        /// Gets or sets the name of the match on place.
        /// </summary>
        /// <value>
        /// The name of the match on place.
        /// </value>
        public bool? MatchOnPlaceName
        { get; set; }

        /// <summary>
        /// Gets or sets the match on post code1.
        /// </summary>
        /// <value>
        /// The match on post code1.
        /// </value>
        public bool? MatchOnPostCode1
        { get; set; }

        /// <summary>
        /// Gets or sets the match on post code2.
        /// </summary>
        /// <value>
        /// The match on post code2.
        /// </value>
        public bool? MatchOnPostCode2
        { get; set; }

        /// <summary>
        /// Gets or sets the match on street directional.
        /// </summary>
        /// <value>
        /// The match on street directional.
        /// </value>
        public bool? MatchOnStreetDirectional
        { get; set; }

        /// <summary>
        /// Gets or sets the name of the match on street.
        /// </summary>
        /// <value>
        /// The name of the match on street.
        /// </value>
        public bool? MatchOnStreetName
        { get; set; }

        /// <summary>
        /// Gets or sets the type of the match on street.
        /// </summary>
        /// <value>
        /// The type of the match on street.
        /// </value>
        public bool? MatchOnStreetType
        { get; set; }

        /// <summary>
        /// Gets or sets the maximum returned candidates.
        /// </summary>
        /// <value>
        /// The maximum returned candidates.
        /// </value>
        public string maxReturnedCandidates
        { get; set; }

        /// <summary>
        /// Gets or sets the return all candidate information.
        /// </summary>
        /// <value>
        /// The return all candidate information.
        /// </value>
        public bool? returnAllCandidateInfo
        { get; set; }

        /// <summary>
        /// Gets or sets the return all custom fields.
        /// </summary>
        /// <value>
        /// The return all custom fields.
        /// </value>
        public bool? ReturnAllCustomFields
        { get; set; }

        /// <summary>
        /// Gets or sets the return match descriptor.
        /// </summary>
        /// <value>
        /// The return match descriptor.
        /// </value>
        public bool? ReturnMatchDescriptor
        { get; set; }

        /// <summary>
        /// Gets or sets the return street address fields.
        /// </summary>
        /// <value>
        /// The return street address fields.
        /// </value>
        public bool? ReturnStreetAddressFields
        { get; set; }

        /// <summary>
        /// Gets or sets the return unit information.
        /// </summary>
        /// <value>
        /// The return unit information.
        /// </value>
        public bool? ReturnUnitInformation


        { get; set; }


        /// <summary>
        /// Gets or sets the street offset.
        /// </summary>
        /// <value>
        /// The street offset.
        /// </value>
        public string streetOffset


        { get; set; }


        /// <summary>
        /// Gets or sets the street offset units.
        /// </summary>
        /// <value>
        /// The street offset units.
        /// </value>
        public string streetOffsetUnits


        { get; set; }

    }
}
