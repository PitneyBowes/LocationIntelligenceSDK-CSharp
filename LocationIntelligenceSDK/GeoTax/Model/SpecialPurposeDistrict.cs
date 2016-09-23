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

namespace com.pb.locationintelligence.geotax.model
{


    /// <summary>
    /// Represents SPDs
    /// </summary>
    public class SpecialPurposeDistrict
    {

        /// <summary>
        /// SPD Name
        /// </summary>
        public String districtName;
        /// <summary>
        /// 3-digit district type code.
        /// </summary>
        public String districtCode;
        /// <summary>
        /// The district number
        /// </summary>
        public String districtNumber;
        /// <summary>
        /// SPD version date
        /// </summary>
        public String versionDate;
        /// <summary>
        /// SPD effective date.
        /// </summary>
        public String effectiveDate;
        /// <summary>
        /// SPD compiled date.
        /// </summary>
        public String compiledDate;
        /// <summary>
        /// SPD update date.
        /// </summary>
        public String updateDate;

        

    }
}