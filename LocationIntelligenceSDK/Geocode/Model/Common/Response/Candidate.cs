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
    public class Candidate {


        /// <summary>
        /// Gets or sets the precision level.
        /// </summary>
        /// <value>
        /// The precision level.
        /// </value>
        public int PrecisionLevel{ get; set;}


        /// <summary>
        /// Gets or sets the formatted street address.
        /// </summary>
        /// <value>
        /// The formatted street address.
        /// </value>
        public String FormattedStreetAddress{
            get; set;
        }

        /// <summary>
        /// Gets or sets the formatted location address.
        /// </summary>
        /// <value>
        /// The formatted location address.
        /// </value>
        public String FormattedLocationAddress {
            get; set;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public String Identifier{
            get; set;
        }



        /// <summary>
        /// Gets or sets the precision code.
        /// </summary>
        /// <value>
        /// The precision code.
        /// </value>
        public String PrecisionCode{
            get; set;
        }



        /// <summary>
        /// Gets or sets the source dictionary.
        /// </summary>
        /// <value>
        /// The source dictionary.
        /// </value>
        public String SourceDictionary{
            get; set;
        }




        /// <summary>
        /// Gets or sets the matching.
        /// </summary>
        /// <value>
        /// The matching.
        /// </value>
        public FieldsMatching Matching {
            set; get;
        }




        /// <summary>
        /// Gets or sets the geometry.
        /// </summary>
        /// <value>
        /// The geometry.
        /// </value>
        public GeoPos Geometry {
            set; get;
        }



        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public AddressResp Address {
            set; get;
        }


        /// <summary>
        /// Gets or sets the ranges.
        /// </summary>
        /// <value>
        /// The ranges.
        /// </value>
        public List<CandidateRange> Ranges {
            get; set;
        }
        /// <summary>
        /// The vendor codes
        /// </summary>
        public List<String> vendorCodes;
    }
}
