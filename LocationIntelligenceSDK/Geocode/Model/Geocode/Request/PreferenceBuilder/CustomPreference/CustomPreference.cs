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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geocode.model.ICustomPreference" />
    public class CustomPreference : ICustomPreference
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [IgnoreDataMember]
        public Country? Country { set; get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPreference"/> class.
        /// </summary>
        /// <param name="Country">The country.</param>
        public CustomPreference(Country Country)
        {
            this.Country = Country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPreference"/> class.
        /// </summary>
        public CustomPreference()
        {
          
        }

        #region Preferences


        /// <summary>
        /// </summary>
        /// * Gets the value of the returnAllCandidateInfo property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Boolean }
        /// *
        /// */
        public Boolean? returnAllCandidateInfo { get; set; }

        /// <summary>
        /// </summary>
        /// * Gets the value of the clientCoordSysName property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link String }
        /// *
        /// */
        public string clientCoordSysName{ get; set;}
        /// <summary>
        /// </summary>
        /// * Gets the value of the clientLocale property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link String }
        /// *
        /// */
        public string clientLocale { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the cornerOffset property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Double }
        /// *
        /// */
        public string cornerOffset{ get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the cornerOffsetUnits property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link DistanceUnit }
        /// *
        /// */
        public string cornerOffsetUnits{ get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the distance property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Double }
        /// *
        /// */
        public double? distance { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the distanceUnits property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link DistanceUnit }
        /// *
        /// */
        public DistanceUnits? distanceUnits { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the fallbackToGeographic property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Boolean }
        /// *
        /// */
        public Boolean? fallbackToGeographic{ get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the fallbackToPostal property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Boolean }
        /// *
        /// */
        public Boolean? fallbackToPostal{ get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchMode property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link String }
        /// *
        /// */
        public string matchMode{ get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the streetOffset property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Double }
        /// *
        /// */
        public string streetOffset { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the streetOffsetUnits property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link DistanceUnit }
        /// *
        /// */
        public string streetOffsetUnits { get; set; }

        /// <summary>
        /// </summary>
        /// * Gets the value of the maxReturnedCandidates property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link Integer }
        /// *
        /// */
        public String maxReturnedCandidates { get; set; }
        #endregion

        #region MatchMode
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnAddressNumber property.
        /// *
        /// */
        public Boolean? MatchOnAddressNumber{ get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnAllStreetFields property.
        /// *
        /// */
        public Boolean? MatchOnAllStreetFields { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnAreaName1 property.
        /// *
        /// */
        public Boolean? MatchOnAreaName1        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnAreaName2 property.
        /// *
        /// */
        public Boolean? MatchOnAreaName2        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnAreaName3 property.
        /// *
        /// */
        public Boolean? MatchOnAreaName3        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnAreaName4 property.
        /// *
        /// */
        public Boolean? MatchOnAreaName4        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnInputFields property.
        /// *
        /// */
        public Boolean? MatchOnInputFields        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnPlaceName property.
        /// *
        /// */
        public Boolean? MatchOnPlaceName        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnPostCode1 property.
        /// *
        /// */
        public Boolean? MatchOnPostCode1        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnPostCode2 property.
        /// *
        /// */
        public Boolean? MatchOnPostCode2        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnStreetDirectional property.
        /// *
        /// */
        public Boolean? MatchOnStreetDirectional        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnStreetName property.
        /// *
        /// */
        public Boolean? MatchOnStreetName        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the matchOnStreetType property.
        /// *
        /// */
        public Boolean? MatchOnStreetType        { get; set; }
        #endregion

        #region ReturnFieldsDescriptor

        /// <summary>
        /// </summary>
        /// * Gets the value of the returnFieldsDescriptor property.
        /// *
        /// * @return
        /// *     possible object is
        /// *     {@link ReturnFieldsDescriptor }
        /// *
        /// */
        public Boolean? ReturnAllCustomFields        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the returnMatchDescriptor property.
        /// *
        /// */
        public Boolean? ReturnMatchDescriptor        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the returnStreetAddressFields property.
        /// *
        /// */
        public Boolean? ReturnStreetAddressFields        { get; set; }
        /// <summary>
        /// </summary>
        /// * Gets the value of the returnUnitInformation property.
        /// *
        /// */
        public Boolean? ReturnUnitInformation        { get; set; }

        /// <summary>
        /// Gets or sets the returned custom field keys.
        /// </summary>
        /// <value>
        /// The returned custom field keys.
        /// </value>
        public IList<String> returnedCustomFieldKeys { get;set;}

        /// <summary>
        /// Gets or sets the fallbac k_ t o_ world.
        /// </summary>
        /// <value>
        /// The fallbac k_ t o_ world.
        /// </value>
        public Boolean? FALLBACK_TO_WORLD
        {
            get; set;
        }

        





        #endregion

    }
}
