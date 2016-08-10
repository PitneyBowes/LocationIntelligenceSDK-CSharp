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
 

namespace com.pb.locationintelligence.geolifeDemographics.model
{

    /// <summary>
    /// 
    /// </summary>
    public class Boundary
    {

        /// <summary>
        /// Identifier for a specific area boundary within which the boundary results will be retrieved.
        /// </summary>
        /// <value>
        /// The boundary identifier.
        /// </value>
        public String boundaryId { set; get; }

        /// <summary>
        /// boundaryType is exposed as an enumeration for different countries..
        /// </summary>
        /// <value>
        /// The type of the boundary.
        /// </value>
        public String boundaryType { set; get; }

        /// <summary>
        /// boundaryRef defined in boundaryId and used in the theme to refer to the respective boundary.
        /// </summary>
        /// <value>
        /// The xmlid.
        /// </value>
        public String boundaryRef { set; get; }

        
    }
}