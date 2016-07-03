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
using System.Runtime.Serialization;

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geocode.model.Address" />
    [DataContract(Name = "address")]
    public class AddressResp:Address
    {

        /// <summary>
        ///  Gets the value of the customFields property.
        /// </summary>
        [DataMember(Name = "customFields")]
        public Dictionary<String, String> CustomFields
        {
            get; set;
        }



    }
}
