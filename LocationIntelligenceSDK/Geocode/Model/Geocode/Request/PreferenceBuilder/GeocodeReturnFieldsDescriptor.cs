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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.pb.locationintelligence.utils;

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    public class GeocodeReturnFieldsDescriptor
    {
        
        /// <summary>
        /// Gets or sets the return all custom fields.
        /// </summary>
        /// <value>
        /// The return all custom fields.
        /// </value>
        public Boolean? ReturnAllCustomFields
        {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the return match descriptor.
        /// </summary>
        /// <value>
        /// The return match descriptor.
        /// </value>
        public Boolean? ReturnMatchDescriptor
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the return street address fields.
        /// </summary>
        /// <value>
        /// The return street address fields.
        /// </value>
        public Boolean? ReturnStreetAddressFields
        {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the return unit information.
        /// </summary>
        /// <value>
        /// The return unit information.
        /// </value>
        public Boolean? ReturnUnitInformation
        {
            get; set;
        }



        
        /// <summary>
        /// Gets or sets the returned custom field keys.
        /// </summary>
        /// <value>
        /// The returned custom field keys.
        /// </value>
        public List<ReturnedCustomFieldsKeys> ReturnedCustomFieldKeys
        {
            get; set;
        }

    }
}
