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
    public class CandidateRange {


        /// <summary>
        /// Gets or sets the name of the place.
        /// </summary>
        /// <value>
        /// The name of the place.
        /// </value>
        public String PlaceName {
            get; set;
        }


        /// <summary>
        /// Gets and Sets the value of the lowHouse property.
        /// </summary>
        public String LowHouse {
            get; set;
        }



        /// <summary>
        ///  Gets and Sets the value of the highHouse property.
        /// </summary>
        public String HighHouse {
            get; set;
        }



        /// <summary>
        ///  Gets and Sets the value of the side property.
        /// </summary>
        public StreetSideIndicator Side {
            get; set;
        }



        /// <summary>
        /// Gets and Sets the value of the oddEvenIndicator property.
        /// </summary>
        public OddEvenIndicator OddEvenIndicator {
            get; set;
        }



        /// <summary>
        /// Gets the value of the units property.
        /// </summary>
        public List<CandidateRangeUnit> Units{
            get; set;
        }

        /// <summary>
        /// Gets the value of the customValues property.
        /// </summary>
        public Dictionary<String,String>  CustomValues{
            get; set;
        }

       

    }
}
