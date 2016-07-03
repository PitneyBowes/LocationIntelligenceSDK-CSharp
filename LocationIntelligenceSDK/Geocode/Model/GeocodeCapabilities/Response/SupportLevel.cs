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
    public class SupportLevel {



        /// <summary>
        /// Gets or sets the supported data level.
        /// </summary>
        /// <value>
        /// The supported data level.
        /// </value>
        public int SupportedDataLevel { get; set;}


       
        /// <summary>
        /// Gets or sets the countries.
        /// </summary>
        /// <value>
        /// The countries.
        /// </value>
        public List<String> Countries{
            get;set;
        }

       
        /// <summary>
        /// Gets or sets the updated required inputs.
        /// </summary>
        /// <value>
        /// The updated required inputs.
        /// </value>
        public List<InputParameter> UpdatedRequiredInputs{
            get; set;
        }

       
        /// <summary>
        /// Gets or sets the updated optional inputs.
        /// </summary>
        /// <value>
        /// The updated optional inputs.
        /// </value>
        public List<InputParameter> UpdatedOptionalInputs {
            get; set;
        }

       
        /// <summary>
        /// Gets or sets the updated optional outputs.
        /// </summary>
        /// <value>
        /// The updated optional outputs.
        /// </value>
        public List<OutputParameter> UpdatedOptionalOutputs{
            get; set;
        }

    }
}
