#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using System.Collections.Generic;

namespace com.pb.locationintelligence.geoLifeSegmentation.model
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class Theme
    {

        /// <summary>
        /// Gets or sets the boundary reference.
        /// </summary>
        /// <value>
        /// The boundary reference.
        /// </value>
        public string boundaryRef { get; set; }
        /// <summary>
        /// Gets or sets the individual value variable.
        /// </summary>
        /// <value>
        /// The individual value variable.
        /// </value>
        public List<IndividualValueVariable> individualValueVariable { set; get; }
        /// <summary>
        /// Gets or sets the range variable.
        /// </summary>
        /// <value>
        /// The range variable.
        /// </value>
        public List<RangeVariable> rangeVariable { set; get; }

    }
}