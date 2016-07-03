#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.exception;
using System;

namespace com.pb.locationintelligence.common
{
    /// <summary>
    /// This Generic event which is Raised Asynchronously after the completion of WebRequest
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WebResponseEventArgs<T>:EventArgs
    {

        /// <summary>
        /// Gets or sets the response object.
        /// </summary>
        /// <value>
        /// The response object.
        /// </value>
        public T ResponseObject { get; set; }
        /// <summary>
        /// Gets or sets the SDK exception.
        /// </summary>
        /// <value>
        /// The SDK exception.
        /// </value>
        public SdkException SDKException { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebResponseEventArgs{T}"/> class.
        /// </summary>
        /// <param name="EventData">The event data.</param>
        /// <param name="sdkException">The SDK exception.</param>
        public WebResponseEventArgs(T EventData, SdkException sdkException)
        {
            this.ResponseObject = EventData;
            this.SDKException = sdkException;
        }
    
    }
}
