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
    /// 
    /// </summary>
    public class TimezoneResponse
    {

        /// <summary>
        /// Gets or sets the name of the timezone.
        /// </summary>
        /// <value>
        /// The name of the timezone.
        /// </value>
        public string timezoneName { set; get; }

        /// <summary>
        /// Gets or sets the UTC offset.
        /// </summary>
        /// <value>
        /// The UTC offset.
        /// </value>
        public long utcOffset { set; get; }

        /// <summary>
        /// Gets or sets the DST offset.
        /// </summary>
        /// <value>
        /// The DST offset.
        /// </value>
        public long dstOffset { set; get; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>
        /// The timestamp.
        /// </value>
        public long timestamp { set; get; }

        

    }
}
