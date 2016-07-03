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
using System;
namespace com.pb.locationintelligence.segmentation.model
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.segmentation.model.Variable" />
    public class RangeVariable : Variable
{

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public IList<Field> field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public class Field {
         
            /// <summary>
            /// Gets or sets the value.
            /// </summary>
            /// <value>
            /// The value.
            /// </value>
            public String value { get; set; }


          

            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            /// <value>
            /// The description.
            /// </value>
            public String description { get; set;}

       
        
    }

}
}