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

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    public class CandidateRangeUnit
    {



        /// <summary>
        /// Gets abd Sets the value of the placeName property.
        /// </summary>
        /// <value>
        /// The name of the place.
        /// </value>
        public String PlaceName
        {
            get; set;
        }



        /// <summary>
        /// Gets and Sets the value of the unitType property.
        /// </summary>
        /// <value>
        /// The type of the unit.
        /// </value>
        public String UnitType
        {
            get; set;
        }



        /// <summary>
        /// Gets ans Sets the value of the highUnitValue property.
        /// </summary>
        /// <value>
        /// The high unit value.
        /// </value>
        public String HighUnitValue
        {
            get; set;
        }



        /// <summary>
        /// Gets and Sets the value of the lowUnitValue property.
        /// </summary>
        /// <value>
        /// The low unit value.
        /// </value>
        public String LowUnitValue
        {
            get; set;
        }


        /// <summary>
        /// Gets and Sets the value of the customValues property.
        /// </summary>
        /// <value>
        /// The custom values.
        /// </value>
        public Dictionary<String,String> CustomValues
        {
            get; set;
        }

       

    }
}
