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
    class CustomPreferenceNZL : ICustomPreferenceNZL
    {
        //Boolean ReturnOriginalCoordinates { set; get; }
        public string clientCoordSysName
        {
            get; set;
        }
        public Country? Country { set; get; }
        public string clientLocale
        {
            get; set;
        }

        public string cornerOffset
        {
            get; set;
        }

        public string cornerOffsetUnits
        {
            get; set;
        }

        public double? distance
        {
            get; set;
        }

        public DistanceUnits? distanceUnits
        {
            get; set;
        }

        public Boolean? fallbackToGeographic
        {
            get; set;
        }

        public Boolean? fallbackToPostal
        {
            get; set;
        }
        public Boolean? FALLBACK_TO_WORLD
        {
            get; set;
        }
        public string matchMode
        {
            get; set;
        }

        public Boolean? MatchOnAddressNumber
        {
            get; set;
        }

        public Boolean? MatchOnAllStreetFields
        {
            get; set;
        }

        public Boolean? MatchOnAreaName1
        {
            get; set;
        }

        public Boolean? MatchOnAreaName2
        {
            get; set;
        }

        public Boolean? MatchOnAreaName3
        {
            get; set;
        }

        public Boolean? MatchOnAreaName4
        {
            get; set;
        }

        public Boolean? MatchOnInputFields
        {
            get; set;
        }

        public Boolean? MatchOnPlaceName
        {
            get; set;
        }

        public Boolean? MatchOnPostCode1
        {
            get; set;
        }

        public Boolean? MatchOnPostCode2
        {
            get; set;
        }

        public Boolean? MatchOnStreetDirectional
        {
            get; set;
        }

        public Boolean? MatchOnStreetName
        {
            get; set;
        }

        public Boolean? MatchOnStreetType
        {
            get; set;
        }

        public string maxReturnedCandidates
        {
            get; set;
        }

        public Boolean? returnAllCandidateInfo
        {
            get; set;
        }

        public Boolean? ReturnAllCustomFields
        {
            get; set;
        }

        public Boolean? ReturnMatchDescriptor
        {
            get; set;
        }

        public Boolean? ReturnOriginalCoordinates
        {
            get; set;
        }

        public Boolean? ReturnStreetAddressFields
        {
            get; set;
        }

        public Boolean? ReturnUnitInformation
        {
            get; set;
        }

        public string streetOffset
        {
            get; set;
        }

        public string streetOffsetUnits
        {
            get; set;
        }
    }
}
