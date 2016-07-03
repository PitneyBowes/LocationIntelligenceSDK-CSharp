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
namespace com.pb.locationintelligence.segmentation.model
{


    /// <summary>
    /// 
    /// </summary>
    public class Boundary
    {
        /**
        * Gets/Sets the value of the geometry property.
        * 
        * @return
        *     possible object is
        *     {@link Geometry }
        *     
        */

        /// <summary>
        /// Gets or sets the geometry.
        /// </summary>
        /// <value>
        /// The geometry.
        /// </value>
        public Geometry geometry{set;get;}


        /**
         * Gets the value of the boundaryId property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */

        /// <summary>
        /// Gets or sets the boundary identifier.
        /// </summary>
        /// <value>
        /// The boundary identifier.
        /// </value>
        public String boundaryId{set; get;}

        /**
        * Gets the value of the boundaryType property.
        * 
        * @return
        *     possible object is
        *     {@link String }
        *     
        */

        /// <summary>
        /// Gets or sets the type of the boundary.
        /// </summary>
        /// <value>
        /// The type of the boundary.
        /// </value>
        public String boundaryType { set; get; }

        /**
         * Gets the value of the url property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public String url{set;get;}

        
       

    }
}