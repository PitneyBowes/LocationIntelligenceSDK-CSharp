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
    [DataContract]
    [KnownType(typeof(Type))]
    [KnownType(typeof(Preferences))]
    [KnownType(typeof(Address))]
    public class GeocodeRequest {

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember(Name ="type")]
        public String Type {
            get; set;
        }
        /// <summary>
        /// Gets or sets the preferences.
        /// </summary>
        /// <value>
        /// The preferences.
        /// </value>
        [DataMember(Name = "preferences")]
        public Preferences Preferences
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>
        /// The addresses.
        /// </value>
        [DataMember(Name = "addresses")]
        public List<Address> Addresses
        {
            get; set;
        }

    }
}
