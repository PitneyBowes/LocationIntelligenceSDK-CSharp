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

namespace com.pb.locationintelligence.common.model
{
    /// <summary>
    /// Represents Error received from Location Intelligence API call.
    /// </summary>
    public class ErrorInfo
    {
        /// <summary>
        /// This is the error information from the Location Intelligence APIs. This gets populated when a bad request is fired such as a request with invalid latitude..
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>

        public List<ErrorCodes> Errors { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code.
        /// </summary>
        /// <value>
        /// The HTTP status code.
        /// </value>
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// This represents the verbal description for the status code.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>

        public String Reason { get; set; }

        /// <summary>
        /// This represents the raw json response from the server.
        /// </summary>
        /// <value>
        /// The json response.
        /// </value>

        public String JsonResponse { get; set; }
    }
}