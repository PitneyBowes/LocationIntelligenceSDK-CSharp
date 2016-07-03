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
    public class InputParameter
    {

        /// <summary>
        /// Gets and Sets the value of the name property.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String Name
        {
            get; set;
        }



        /// <summary>
        /// Gets a nd Sets the value of the description property.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public String Description
        {
            get; set;
        }



        /// <summary>
        /// Gets and Sets the value of the type property.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public String Type
        {
            get; set;
        }




        /// <summary>
        /// Gets and Sets the value of the defaultValue property.
        /// </summary>
        /// <value>
        /// The default value.
        /// </value>
        public String DefaultValue
        {
            get; set;
        }


        /// <summary>
        /// Gets the value of the lowBoundary property.
        /// </summary>
        /// <value>
        /// The low boundary.
        /// </value>
        public String LowBoundary
        {
            get; set;
        }



        /// <summary>
        /// Gets and Set the value of the highBoundary property.
        /// </summary>
        /// <value>
        /// The high boundary.
        /// </value>
        public String HighBoundary
        {
            get; set;
        }


        /// <summary>
        /// Gets the value of the allowedValuesWithDescriptions property.
        /// </summary>
        /// <value>
        /// The allowed values with descriptions.
        /// </value>
        public Dictionary<String, String> AllowedValuesWithDescriptions
        {
            get; set;
        }

       

    }
}
