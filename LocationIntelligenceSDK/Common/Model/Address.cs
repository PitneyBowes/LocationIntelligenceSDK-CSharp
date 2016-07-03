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
    public class Address {
        /// <summary>
        /// Gets or sets the formatted address.
        /// </summary>
        /// <value>
        /// The formatted address.
        /// </value>
        public String formattedAddress { get; set; }
        /// <summary>
        /// Gets or sets the main address line.
        /// </summary>
        /// <value>
        /// The main address line.
        /// </value>
        public String mainAddressLine { get; set; }
        /// <summary>
        /// Gets or sets the address last line.
        /// </summary>
        /// <value>
        /// The address last line.
        /// </value>
        public String addressLastLine { get; set; }
        /// <summary>
        /// Gets or sets the name of the place.
        /// </summary>
        /// <value>
        /// The name of the place.
        /// </value>
        public String placeName { get; set; }
        /// <summary>
        /// Gets or sets the area name1.
        /// </summary>
        /// <value>
        /// The area name1.
        /// </value>
        public String areaName1 { get; set; }
        /// <summary>
        /// Gets or sets the area name2.
        /// </summary>
        /// <value>
        /// The area name2.
        /// </value>
        public String areaName2 { get; set; }
        /// <summary>
        /// Gets or sets the area name3.
        /// </summary>
        /// <value>
        /// The area name3.
        /// </value>
        public String areaName3 { get; set; }
        /// <summary>
        /// Gets or sets the area name4.
        /// </summary>
        /// <value>
        /// The area name4.
        /// </value>
        public String areaName4 { get; set; }
        /// <summary>
        /// Gets or sets the post code.
        /// </summary>
        /// <value>
        /// The post code.
        /// </value>
        public String postCode { get; set; }
        /// <summary>
        /// Gets or sets the post code ext.
        /// </summary>
        /// <value>
        /// The post code ext.
        /// </value>
        public String postCodeExt { get; set; }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public String country { get; set; }
        /// <summary>
        /// Gets or sets the address number.
        /// </summary>
        /// <value>
        /// The address number.
        /// </value>
        public String addressNumber { get; set; }
        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>
        /// The name of the street.
        /// </value>
        public String streetName { get; set; }
        /// <summary>
        /// Gets or sets the type of the unit.
        /// </summary>
        /// <value>
        /// The type of the unit.
        /// </value>
        public String unitType { get; set; }
        /// <summary>
        /// Gets or sets the unit value.
        /// </summary>
        /// <value>
        /// The unit value.
        /// </value>
        public String unitValue { get; set; }
        
	}
}
