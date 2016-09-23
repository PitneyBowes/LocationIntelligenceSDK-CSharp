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
    /// Represents Sales Tax Information. 
    /// </summary>
    public class SalesTax {
        /// <summary>
        /// The sum of the individual Municipal, County, State and SPD sales tax rates..
        /// </summary>
        /// <value>
        /// The total tax rate.
        /// </value>
        public Double totalTaxRate{get;set;}
        /// <summary>
        /// The sum of the individual Municipal, County, State and SPD sales tax amounts.
        /// </summary>
        /// <value>
        /// The total tax amount.
        /// </value>
        public Double totalTaxAmount{get;set;}
        /// <summary>
        /// State sales tax rate for the selected tax rate type.
        /// </summary>
        /// <value>
        /// The state tax rate.
        /// </value>
        public Double stateTaxRate{get;set;}
        /// <summary>
        /// State sales tax amount for the selected tax rate type.
        /// </summary>
        /// <value>
        /// The state tax amount.
        /// </value>
        public Double stateTaxAmount{get;set;}
        /// <summary>
        /// County sales tax rate for the selected tax rate type.
        /// </summary>
        /// <value>
        /// The county tax rate.
        /// </value>
        public Double countyTaxRate{get;set;}
        /// <summary>
        /// County sales tax amount for the selected tax rate type.
        /// </summary>
        /// <value>
        /// The county tax amount.
        /// </value>
        public Double countyTaxAmount{get;set;}
        /// <summary>
        /// Municipality sales tax rate for the selected tax rate type.
        /// </summary>
        /// <value>
        /// The municipal tax rate.
        /// </value>
        public Double municipalTaxRate{get;set;}
        /// <summary>
        /// Municipality sales tax amount for the selected tax rate type.
        /// </summary>
        /// <value>
        /// The municipal tax amount.
        /// </value>
        public Double municipalTaxAmount{get;set;}
        /// <summary>
        /// Gets or sets the special purpose districts tax.
        /// </summary>
        /// <value>
        /// The special purpose districts tax.
        /// </value>
        public List<SpecialPurposeDistrictTax> specialPurposeDistrictsTax{get;set;}

	
}
}