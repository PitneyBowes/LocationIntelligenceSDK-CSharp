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
using System.Runtime.Serialization;
using com.pb.locationintelligence.common.model;


namespace com.pb.locationintelligence.geo911.model
{
    /// <summary>
    /// This class represents the Authority Having Jurisdiction (AHJ) properties.
    /// </summary>
    [DataContract(Name = "ahj")]
    public class AHJ
    {


        /// <summary>
        /// Gets or sets the type of the ahj.
        /// </summary>
        /// <value>
        /// The type of the ahj.
        /// </value>
        public string ahjType { get; set; }
        /// <summary>
        /// Gets or sets the ahj identifier.
        /// </summary>
        /// <value>
        /// The ahj identifier.
        /// </value>
        public string ahjId { get; set; }
        /// <summary>
        /// Gets or sets the agency.
        /// </summary>
        /// <value>
        /// The agency.
        /// </value>
        public string agency { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string phone { get; set; }
        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public string comments { get; set; }
        /// <summary>
        /// Gets or sets the coverage.
        /// </summary>
        /// <value>
        /// The coverage.
        /// </value>
        public Coverage coverage { get; set; }
        /// <summary>
        /// Gets or sets the contact person.
        /// </summary>
        /// <value>
        /// The contact person.
        /// </value>
        public ContactPerson contactPerson { get; set; }
        /// <summary>
        /// Gets or sets the mailing address.
        /// </summary>
        /// <value>
        /// The mailing address.
        /// </value>
        public Address mailingAddress { get; set; }
    }

    }
