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

namespace com.pb.locationintelligence.common.model
{
    /// <summary>
    /// 
    /// </summary>
    class OAuthServiceResponse
    {


        /// <summary>
        /// Gets or sets the access_token.
        /// </summary>
        /// <value>
        /// The access_token.
        /// </value>
        public String  access_token {get; set;}
        /// <summary>
        /// Gets or sets the type of the token.
        /// </summary>
        /// <value>
        /// The type of the token.
        /// </value>
        public String  tokenType {get; set;}
        /// <summary>
        /// Gets or sets the issued at.
        /// </summary>
        /// <value>
        /// The issued at.
        /// </value>
        public String  issuedAt {get; set;}
        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        /// <value>
        /// The expires in.
        /// </value>
        public String  expiresIn {get; set;}

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public String  clientID {get; set;}

        /// <summary>
        /// Gets or sets the org.
        /// </summary>
        /// <value>
        /// The org.
        /// </value>
        public String  org {get; set;}
    
       
    
    }
}
