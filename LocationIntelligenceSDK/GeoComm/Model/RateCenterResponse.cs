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
using System.Collections.Generic;

namespace com.pb.locationintelligence.geocomm.model
{
    /// <summary>
    /// Represents RateCenter Response of GeoComm API.
    /// </summary>
    public class RateCenterResponse
    {
        /// <summary>
        /// Gets or sets the rate center id.
        /// </summary>
        /// <value>
        /// Rate center id.
        /// </value> 
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the rate center name.
        /// </summary>
        /// <value>
        /// Name.
        /// </value> 
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the alternate name.
        /// </summary>
        /// <value>
        /// The alternate name.
        /// </value> 
        public string alternateName { get; set; }

        /// <summary>
        /// Gets or sets the areaName1.
        /// </summary>
        /// <value>
        /// areaName1.
        /// </value> 
        public string areaName1 { get; set; }

        /// <summary>
        /// Gets or sets the Geometry.
        /// </summary>
        /// <value>
        /// Geometry.
        /// </value> 
        public Geometry geometry { get; set; }

        /// <summary>
        /// Gets or sets the areaCodeInfoList.
        /// </summary>
        /// <value>
        /// areaCodeInfoList.
        /// </value> 
        public List<AreaCodeResponse> areaCodeInfoList { get; set; }

        /// <summary>
        /// Gets or sets the matched address.
        /// </summary>
        /// <value>
        /// The matched address.
        /// </value>
        public Address matchedAddress { get; set; }

        /// <summary>
        /// Gets or sets the match.
        /// </summary>
        /// <value>
        /// Match.
        /// </value>
        public Match match { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// County.
        /// </value>
        public County county { get; set; }

    }
}

