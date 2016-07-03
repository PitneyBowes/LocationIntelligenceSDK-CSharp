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

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    public class GeocodeCapabilitiesResponse
    {

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>
        /// The name of the service.
        /// </value>
        public String ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the service description.
        /// </summary>
        /// <value>
        /// The service description.
        /// </value>
        public String ServiceDescription { get; set; }

        /// <summary>
        /// Gets or sets the core version.
        /// </summary>
        /// <value>
        /// The core version.
        /// </value>
        public String CoreVersion { get; set;}

        /// <summary>
        /// Gets or sets the supported countries.
        /// </summary>
        /// <value>
        /// The supported countries.
        /// </value>
        public List<String> SupportedCountries {
            get; set;
        }

        /// <summary>
        /// Gets or sets the supported operations.
        /// </summary>
        /// <value>
        /// The supported operations.
        /// </value>
        public List<Operation> SupportedOperations {
            get; set;
        }


        /// <summary>
        /// Gets or sets the custom objects.
        /// </summary>
        /// <value>
        /// The custom objects.
        /// </value>
        public List<CustomObject> CustomObjects {
            get; set;
        }

       

    }
}
