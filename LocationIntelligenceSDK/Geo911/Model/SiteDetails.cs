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
using com.pb.locationintelligence.common.model;

namespace com.pb.locationintelligence.geo911.model
{
    /// <summary>
    /// Site details.
    /// </summary>
    public class SiteDetails
    {
        /// <summary>
        /// Phone number of the PSAP site.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public String phone { get; set; }
        /// <summary>
        /// Fax number of the PSAP site.
        /// </summary>
        /// <value>
        /// The fax.
        /// </value>
        public String fax { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public Address address { get; set; }
    }
}
