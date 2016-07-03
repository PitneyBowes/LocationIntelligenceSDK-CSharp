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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.pb.locationintelligence.utils;

namespace com.pb.locationintelligence.geocode.model
{

    /// <summary>
    /// 
    /// </summary>
    public class Preferences {


       
        /// <summary>
        /// Gets or sets the return all candidate information.
        /// </summary>
        /// <value>
        /// The return all candidate information.
        /// </value>
        public Boolean? returnAllCandidateInfo {
            set; get;
        }



        /// <summary>
        /// Gets or sets the fallback to geographic.
        /// </summary>
        /// <value>
        /// The fallback to geographic.
        /// </value>
        public Boolean? fallbackToGeographic {
            set; get;
        }


        /// <summary>
        /// Gets or sets the fallback to postal.
        /// </summary>
        /// <value>
        /// The fallback to postal.
        /// </value>
        public Boolean? fallbackToPostal
        {
            set; get;
        }


       
        /// <summary>
        /// Gets or sets the maximum returned candidates.
        /// </summary>
        /// <value>
        /// The maximum returned candidates.
        /// </value>
        public String maxReturnedCandidates {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public Double? distance {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the street offset.
        /// </summary>
        /// <value>
        /// The street offset.
        /// </value>
        public String streetOffset {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the corner offset.
        /// </summary>
        /// <value>
        /// The corner offset.
        /// </value>
        public String cornerOffset {
            get; set;
        }



        /// <summary>
        /// Gets or sets the match mode.
        /// </summary>
        /// <value>
        /// The match mode.
        /// </value>
        public String matchMode{
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the client locale.
        /// </summary>
        /// <value>
        /// The client locale.
        /// </value>
        public String clientLocale{
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the name of the client coord system.
        /// </summary>
        /// <value>
        /// The name of the client coord system.
        /// </value>
        public String clientCoordSysName {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the distance units.
        /// </summary>
        /// <value>
        /// The distance units.
        /// </value>
        public String distanceUnits {
            get;set;
        }



       
        /// <summary>
        /// Gets or sets the street offset units.
        /// </summary>
        /// <value>
        /// The street offset units.
        /// </value>
        public String streetOffsetUnits {
             get; set;
        }



       
        /// <summary>
        /// Gets or sets the corner offset units.
        /// </summary>
        /// <value>
        /// The corner offset units.
        /// </value>
        public String cornerOffsetUnits {
            get; set;
        }


       
        /// <summary>
        /// Gets or sets the must match fields.
        /// </summary>
        /// <value>
        /// The must match fields.
        /// </value>
        public FieldsMatching mustMatchFields {
            get; set;
        }



       
        /// <summary>
        /// Gets or sets the return fields descriptor.
        /// </summary>
        /// <value>
        /// The return fields descriptor.
        /// </value>
        public ReturnFieldsDescriptor returnFieldsDescriptor {
            get; set;
        }




        /// <summary>
        /// Gets or sets the custom preferences.
        /// </summary>
        /// <value>
        /// The custom preferences.
        /// </value>
        public Dictionary<String,String> customPreferences {
            get; set;
        }



        /// <summary>
        /// Gets or sets the preferred dictionary orders.
        /// </summary>
        /// <value>
        /// The preferred dictionary orders.
        /// </value>
        public List<String> preferredDictionaryOrders{
            get; set;
        }

       
    }
}
