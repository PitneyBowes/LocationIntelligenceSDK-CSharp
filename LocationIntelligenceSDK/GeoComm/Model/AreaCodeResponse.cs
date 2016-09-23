#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
namespace com.pb.locationintelligence.geocomm.model
{
    /// <summary>
    /// Represents AreaCode Response of GeoComm API.
    /// </summary>
    public class AreaCodeResponse
    {
        /// <summary>
        /// Gets or sets the companyName.
        /// </summary>
        /// <value>
        /// companyName.
        /// </value> 
        public string companyName { get; set; }

        /// <summary>
        /// Gets or sets the ocn.
        /// </summary>
        /// <value>
        /// ocn.
        /// </value>
        public string ocn { get; set; }

        /// <summary>
        /// Gets or sets the ocnCategory.
        /// </summary>
        /// <value>
        /// ocnCategory.
        /// </value>
        public string ocnCategory { get; set; }

        /// <summary>
        /// Gets or sets the npa.
        /// </summary>
        /// <value>
        /// npa.
        /// </value>
        public string npa { get; set; }

        /// <summary>
        /// Gets or sets the nxx.
        /// </summary>
        /// <value>
        /// nxx.
        /// </value>
        public string nxx { get; set; }

        /// <summary>
        /// Gets or sets the startRange.
        /// </summary>
        /// <value>
        /// startRange.
        /// </value>
        public string startRange { get; set; }

        /// <summary>
        /// Gets or sets the endRange.
        /// </summary>
        /// <value>
        /// endRange.
        /// </value>
        public string endRange { get; set; }

        /// <summary>
        /// Gets or sets the lata.
        /// </summary>
        /// <value>
        /// lata.
        /// </value>
        public string lata { get; set; }

        /// <summary>
        /// Gets or sets the areaName4.
        /// </summary>
        /// <value>
        /// areaName4.
        /// </value>
        public string areaName4 { get; set; }
    }
}