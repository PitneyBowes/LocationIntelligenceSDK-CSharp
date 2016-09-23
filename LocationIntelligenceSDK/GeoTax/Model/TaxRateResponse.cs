#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.common.model;

namespace com.pb.locationintelligence.geotax.model
{

    /// <summary>
    /// Represents Tax Rate Response of GeoTax API.
    /// </summary>
    public class TaxRateResponse
    {

        /// <summary>
        /// Provides the percentage overlap of the geocode to the Place polygon layer. 
        /// The returned percentage value describes the probability that the point falls in the specified Place..
        /// </summary>
        /// <value>
        /// The confidence.
        /// </value>
        public double confidence{get;set;}
        /// <summary>
        /// Gets or sets the jurisdiction.
        /// </summary>
        /// <value>
        /// The jurisdiction.
        /// </value>
        public TaxJurisdiction jurisdiction{get;set;}
        /// <summary>
        /// Gets or sets the matched address.
        /// </summary>
        /// <value>
        /// The matched address.
        /// </value>
        public Address matchedAddress{get;set;}
        /// <summary>
        /// Gets or sets the sales tax.
        /// </summary>
        /// <value>
        /// The sales tax.
        /// </value>
        public SalesTax salesTax{get;set;}
        /// <summary>
        /// Gets or sets the use tax.
        /// </summary>
        /// <value>
        /// The use tax.
        /// </value>
        public UseTax useTax{get;set;}

       

    }
}