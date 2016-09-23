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

namespace com.pb.locationintelligence.geotax.model
{

    /// <summary>
    /// Represents Place Information 
    /// </summary>
    public class Place
    {
        /// <summary>
        /// The name of the "place" where the address is located. 
        /// A "place" is a geographic area defined on the basis of population criteria that vary by state. 
        /// Or, an area recognized as significant because it is located in an incorporated municipality..
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String name{get;set;}
        /// <summary>
        /// An identifier for a specific place. A "place" is a geographic area defined on the basis of population criteria that vary by state. 
        /// Or, an area recognized as significant because it is located in an incorporated municipality.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public String code{get;set;}
        /// <summary>
        /// Place class code. Place class codes are used to determine the proper taxing jurisdictions.
        ///Note: This field is always included in the output regardless of whether or not you choose to include tax jurisdiction data in the output..
        /// </summary>
        /// <value>
        /// The class code.
        /// </value>
        public String classCode{get;set;}
        /// <summary>
        /// Indicates whether the address is located in an incorporated or unincorporated place. 
        /// A "place" is a geographic area defined on the basis of population criteria that vary by state. 
        /// Or, an area recognized as significant because it is located in an incorporated municipality.
        /// </summary>
        /// <value>
        /// The incorporated flag.
        /// </value>
        public String incorporatedFlag{get;set;}
        /// <summary>
        /// Last annexed date, in the format MM/YYYY, representing the month and year of the most recent boundary 
        /// change or the most recent available boundary information.
        /// </summary>
        /// <value>
        /// The last annexed date.
        /// </value>
        public String lastAnnexedDate{get;set;}
        /// <summary>
        ///	Last updated date, in the format MM/YYYY, reflecting the month and year..
        /// </summary>
        /// <value>
        /// The last updated date.
        /// </value>
        public String lastUpdatedDate{get;set;}
        /// <summary>
        /// 	Last verified date, in the format MM/YYYY, representing the month and year.
        /// </summary>
        /// <value>
        /// The last verified date.
        /// </value>
        public String lastVerifiedDate{get;set;}

   
    }
}