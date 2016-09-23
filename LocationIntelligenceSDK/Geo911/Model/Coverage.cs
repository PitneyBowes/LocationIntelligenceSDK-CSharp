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
    /// PSAP coverage area details
    /// </summary>
    public class Coverage
    {
        /// <summary>
        /// Coverage area of the PSAP.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public String area { get; set; }
        /// <summary>
        /// Additional comments about the PSAP's coverage.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public String comments { get; set; }
        /// <summary>
        /// Areas excluded from the coverageArea.
        /// </summary>
        /// <value>
        /// The exceptions.
        /// </value>
        public String exceptions { get; set; }

    }
}
