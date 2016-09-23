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

namespace com.pb.locationintelligence.geo911.model
{
    /// <summary>
    /// Person Information.
    /// </summary>
    public class ContactPerson
    {
        /// <summary>
        /// Title of contact person.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public String title { get; set; }
        /// <summary>
        /// Prefix (Mr, Mrs, etc.) for the contact person.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public String prefix { get; set; }
        /// <summary>
        /// First name of contact person.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public String firstName { get; set; }
        /// <summary>
        /// Last name of contact person.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public String lastName { get; set; }
        /// <summary>
        /// Phone number of contact person.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public String phone { get; set; }
        /// <summary>
        /// Fax number of contact person.
        /// </summary>
        /// <value>
        /// The fax.
        /// </value>
        public String fax { get; set; }
        /// <summary>
        /// Email address of contact person.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public String email { get; set; }
        /// <summary>
        /// Comments regarding contact person.
        /// </summary>
        /// <value>
        /// The additional details.
        /// </value>
        public String additionalDetails { get; set; }
    }
}
