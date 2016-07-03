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
    public class CustomObjectMember
    {


        /// <summary>
        /// Gets the value of the name property.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String Name { get; set; }

        /// <summary>
        /// Gets the value of the input property.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        public InputParameter input { get; set; }

        /// <summary>
        /// Gets the value of the output property.
        /// </summary>
        /// <value>
        /// The output.
        /// </value>
        public OutputParameter output { get; set; }

        
       

        

    }
}
