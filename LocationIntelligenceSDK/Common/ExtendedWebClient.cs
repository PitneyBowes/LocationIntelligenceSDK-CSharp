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
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace com.pb.locationintelligence.common
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Net.WebClient" />
    public class ExtendedWebClient : WebClient
    {


        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        /// <value>
        /// The timeout.
        /// </value>
        public int Timeout { set; get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedWebClient"/> class.
        /// </summary>
        /// <param name="address">The address.</param>
        public ExtendedWebClient(Uri address)
        {
            this.Timeout = 30000;
            var objWebClient = GetWebRequest(address);
        }
        /// <summary>
        /// Gets the web request.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest = base.GetWebRequest(address);
            objWebRequest.Timeout = this.Timeout;
            return objWebRequest;
        }
    }
}
