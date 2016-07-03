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
    /// Represents SDK Internal Errors
    /// </summary>
    public class SdkInternalError
    {
        /// <summary>
        /// Gets or sets the error description.
        /// </summary>
        /// <value>
        /// The error description.
        /// </value>
        public String ErrorDescription { set; get; }
        /// <summary>
        /// Gets or sets the nested exception.
        /// </summary>
        /// <value>
        /// The nested exception.
        /// </value>
        private Exception NestedException { set; get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SdkInternalError"/> class.
        /// </summary>
        public SdkInternalError()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SdkInternalError"/> class.
        /// </summary>
        /// <param name="errorDescription">The error description.</param>
        public SdkInternalError(String errorDescription)
        {
            this.ErrorDescription = errorDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SdkInternalError"/> class.
        /// </summary>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="nestedException">The nested exception.</param>
        public SdkInternalError(String errorDescription, Exception nestedException)
        {
            this.ErrorDescription = errorDescription;
            this.NestedException = nestedException;
        }

        
       


    }
}