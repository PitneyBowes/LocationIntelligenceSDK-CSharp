#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
namespace com.pb.locationintelligence.common.model
{

    /// <summary>
    /// 
    /// </summary>
    public class Location
    {


        /// <summary>
        /// Gets or sets the dataset.
        /// </summary>
        /// <value>
        /// The dataset.
        /// </value>
        public string dataset { get; set; }

        /// <summary>
        /// Gets or sets the match.
        /// </summary>
        /// <value>
        /// The match.
        /// </value>
        public Match match { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public Address address { get; set; }

        /// <summary>
        /// Gets or sets the poi.
        /// </summary>
        /// <value>
        /// The poi.
        /// </value>
        public Poi poi { get; set; }
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public Distance distance { get; set; }

        /// <summary>
        /// Gets or sets the geometry.
        /// </summary>
        /// <value>
        /// The geometry.
        /// </value>
        public Geometry geometry { get; set; }

        /// <summary>
        /// Gets or sets the place.
        /// </summary>
        /// <value>
        /// The place.
        /// </value>
        public PlaceByLocationResponse place { get; set; }
      
    }
}
