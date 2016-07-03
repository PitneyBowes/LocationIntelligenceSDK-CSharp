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
    public class OutputParameter
    {

        /// <summary>
        /// The name
        /// </summary>
        protected String name;
        /// <summary>
        /// The description
        /// </summary>
        protected String description;
        /// <summary>
        /// The type
        /// </summary>
        protected String type;

       
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public String getName()
        {
            return name;
        }

       
        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="value">The value.</param>
        public void setName(String value)
        {
            this.name = value;
        }

       
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <returns></returns>
        public String getDescription()
        {
            return description;
        }

        /// <summary>
        /// Sets the description.
        /// </summary>
        /// <param name="value">The value.</param>
        public void setDescription(String value)
        {
            this.description = value;
        }

        
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <returns></returns>
        public String getType()
        {
            return type;
        }

       
        /// <summary>
        /// Sets the type.
        /// </summary>
        /// <param name="value">The value.</param>
        public void setType(String value)
        {
            this.type = value;
        }

    }
}
