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
    public interface ICustomPreference
    {





        #region Preferences

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        Country? Country { get; set; }


       
        /// <summary>
        /// Gets or sets the return all candidate information.
        /// </summary>
        /// <value>
        /// The return all candidate information.
        /// </value>
        Boolean? returnAllCandidateInfo
        {
            set; get;
        }



        
        /// <summary>
        /// Gets or sets the fallback to geographic.
        /// </summary>
        /// <value>
        /// The fallback to geographic.
        /// </value>
        Boolean? fallbackToGeographic
        {
            set; get;
        }


       
        /// <summary>
        /// Gets or sets the fallback to postal.
        /// </summary>
        /// <value>
        /// The fallback to postal.
        /// </value>
        Boolean? fallbackToPostal
        {
            set; get;
        }

        /// <summary>
        /// Gets or sets the fallbac k_ t o_ world.
        /// </summary>
        /// <value>
        /// The fallbac k_ t o_ world.
        /// </value>
        Boolean? FALLBACK_TO_WORLD
        {
            get;
            set;
        }

        
        /// <summary>
        /// Gets or sets the maximum returned candidates.
        /// </summary>
        /// <value>
        /// The maximum returned candidates.
        /// </value>
        String maxReturnedCandidates
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        Double? distance
        {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the street offset.
        /// </summary>
        /// <value>
        /// The street offset.
        /// </value>
        String streetOffset
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the corner offset.
        /// </summary>
        /// <value>
        /// The corner offset.
        /// </value>
        String cornerOffset
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the match mode.
        /// </summary>
        /// <value>
        /// The match mode.
        /// </value>
        String matchMode
        {
            get; set;
        }


        
        /// <summary>
        /// Gets or sets the client locale.
        /// </summary>
        /// <value>
        /// The client locale.
        /// </value>
        String clientLocale
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the name of the client coord system.
        /// </summary>
        /// <value>
        /// The name of the client coord system.
        /// </value>
        String clientCoordSysName
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the distance units.
        /// </summary>
        /// <value>
        /// The distance units.
        /// </value>
        DistanceUnits? distanceUnits
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the street offset units.
        /// </summary>
        /// <value>
        /// The street offset units.
        /// </value>
        String streetOffsetUnits
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the corner offset units.
        /// </summary>
        /// <value>
        /// The corner offset units.
        /// </value>
        String cornerOffsetUnits
        {
            get; set;
        }
        #endregion


        #region MatchMode

       
        /// <summary>
        /// Gets or sets the match on address number.
        /// </summary>
        /// <value>
        /// The match on address number.
        /// </value>
        Boolean? MatchOnAddressNumber
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the match on post code1.
        /// </summary>
        /// <value>
        /// The match on post code1.
        /// </value>
        Boolean? MatchOnPostCode1
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the match on post code2.
        /// </summary>
        /// <value>
        /// The match on post code2.
        /// </value>
        Boolean? MatchOnPostCode2
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the match on area name1.
        /// </summary>
        /// <value>
        /// The match on area name1.
        /// </value>
        Boolean? MatchOnAreaName1
        {
            get; set;
        }



        /// <summary>
        /// Gets or sets the match on area name2.
        /// </summary>
        /// <value>
        /// The match on area name2.
        /// </value>
        Boolean? MatchOnAreaName2
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the match on area name3.
        /// </summary>
        /// <value>
        /// The match on area name3.
        /// </value>
        Boolean? MatchOnAreaName3
        {
            get; set;
        }



        /// <summary>
        /// Gets or sets the match on area name4.
        /// </summary>
        /// <value>
        /// The match on area name4.
        /// </value>
        Boolean? MatchOnAreaName4
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the match on all street fields.
        /// </summary>
        /// <value>
        /// The match on all street fields.
        /// </value>
        Boolean? MatchOnAllStreetFields
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the name of the match on street.
        /// </summary>
        /// <value>
        /// The name of the match on street.
        /// </value>
        Boolean? MatchOnStreetName
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the type of the match on street.
        /// </summary>
        /// <value>
        /// The type of the match on street.
        /// </value>
        Boolean? MatchOnStreetType
        {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the match on street directional.
        /// </summary>
        /// <value>
        /// The match on street directional.
        /// </value>
        Boolean? MatchOnStreetDirectional
        {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the name of the match on place.
        /// </summary>
        /// <value>
        /// The name of the match on place.
        /// </value>
        Boolean? MatchOnPlaceName
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the match on input fields.
        /// </summary>
        /// <value>
        /// The match on input fields.
        /// </value>
        Boolean? MatchOnInputFields
        {
            get; set;
        }

        #endregion


        #region ReturnFieldsDescriptor 

       
        /// <summary>
        /// Gets or sets the return all custom fields.
        /// </summary>
        /// <value>
        /// The return all custom fields.
        /// </value>
        Boolean? ReturnAllCustomFields
        {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the return match descriptor.
        /// </summary>
        /// <value>
        /// The return match descriptor.
        /// </value>
        Boolean? ReturnMatchDescriptor
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the return street address fields.
        /// </summary>
        /// <value>
        /// The return street address fields.
        /// </value>
        Boolean? ReturnStreetAddressFields
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the return unit information.
        /// </summary>
        /// <value>
        /// The return unit information.
        /// </value>
        Boolean? ReturnUnitInformation
        {
            get; set;
        }



        #endregion


    }
}
