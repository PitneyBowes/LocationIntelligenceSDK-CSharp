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
    public class Operation {


        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String Name {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the required inputs.
        /// </summary>
        /// <value>
        /// The required inputs.
        /// </value>
        public List<InputParameter> RequiredInputs {
            get;set;
        }

       
        /// <summary>
        /// Gets or sets the optional inputs.
        /// </summary>
        /// <value>
        /// The optional inputs.
        /// </value>
        public List<InputParameter> OptionalInputs{
            get; set;
        }

     
        /// <summary>
        /// Gets or sets the outputs.
        /// </summary>
        /// <value>
        /// The outputs.
        /// </value>
        public List<OutputParameter> Outputs{
            get; set;
        }

        
        /// <summary>
        /// Gets or sets the support levels.
        /// </summary>
        /// <value>
        /// The support levels.
        /// </value>
        public List<SupportLevel> SupportLevels {
            get; set;
        }

    }
}
