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
using System.Runtime.Serialization;

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract(Name = "geometry")]
    public class GeoPos {


        /// <summary>
        /// Gets and Sets the value of the type property.
        /// </summary>
        [DataMember(Name = "type")]
        public String Type {
            get; set;
        }



        /// <summary>
        ///  Gets the value of the coordinates property.
        /// </summary>
        [DataMember(Name = "coordinates")]
        public List<Double> Coordinates {
            get; set;
        }

        /// <summary>
        /// Gets and Sets  the value of the crs property.
        /// </summary>
        [DataMember(Name = "crs")]
        public Crs Crs {
            get; set;
        }

       
    }
}