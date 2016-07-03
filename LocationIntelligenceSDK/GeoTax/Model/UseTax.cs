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

namespace com.pb.locationintelligence.geotax.model
{

    /// <summary>
    /// 
    /// </summary>
    public class UseTax
    {
        /// <summary>
        /// Gets or sets the total tax rate.
        /// </summary>
        /// <value>
        /// The total tax rate.
        /// </value>
        public Double totalTaxRate{get;set;}
        /// <summary>
        /// Gets or sets the total tax amount.
        /// </summary>
        /// <value>
        /// The total tax amount.
        /// </value>
        public Double totalTaxAmount{get;set;}
        /// <summary>
        /// Gets or sets the state tax rate.
        /// </summary>
        /// <value>
        /// The state tax rate.
        /// </value>
        public Double stateTaxRate{get;set;}
        /// <summary>
        /// Gets or sets the state tax amount.
        /// </summary>
        /// <value>
        /// The state tax amount.
        /// </value>
        public Double stateTaxAmount{get;set;}
        /// <summary>
        /// Gets or sets the county tax rate.
        /// </summary>
        /// <value>
        /// The county tax rate.
        /// </value>
        public Double countyTaxRate{get;set;}
        /// <summary>
        /// Gets or sets the county tax amount.
        /// </summary>
        /// <value>
        /// The county tax amount.
        /// </value>
        public Double countyTaxAmount{get;set;}
        /// <summary>
        /// Gets or sets the municipal tax rate.
        /// </summary>
        /// <value>
        /// The municipal tax rate.
        /// </value>
        public Double municipalTaxRate{get;set;}
        /// <summary>
        /// Gets or sets the municipal tax amount.
        /// </summary>
        /// <value>
        /// The municipal tax amount.
        /// </value>
        public Double municipalTaxAmount{get;set;}
        /// <summary>
        /// Gets or sets the SPDS tax.
        /// </summary>
        /// <value>
        /// The SPDS tax.
        /// </value>
        public List<SpecialPurposeDistrictTax> spdsTax{get;set;}

       
    }
}