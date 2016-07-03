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


namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.geocode.model.ICustomPreference" />
    public interface ICustomPreferenceAUS:ICustomPreference
    {

        /// <summary>
        /// Gets or sets the ke y_ stree t_ frontage.
        /// </summary>
        /// <value>
        /// The ke y_ stree t_ frontage.
        /// </value>
        Boolean? KEY_STREET_FRONTAGE{get; set;}

        /// <summary>
        /// Gets or sets the ke y_ gna f_ original.
        /// </summary>
        /// <value>
        /// The ke y_ gna f_ original.
        /// </value>
        Boolean? KEY_GNAF_ORIGINAL { get; set; }

        /// <summary>
        /// Gets or sets the ke y_ posta l_ cod e_ override.
        /// </summary>
        /// <value>
        /// The ke y_ posta l_ cod e_ override.
        /// </value>
        Boolean? KEY_POSTAL_CODE_OVERRIDE { get; set; }
        /// <summary>
        /// Gets or sets the ke y_ retur n_ stree t_ typ e_ abbrevs.
        /// </summary>
        /// <value>
        /// The ke y_ retur n_ stree t_ typ e_ abbrevs.
        /// </value>
        Boolean? KEY_RETURN_STREET_TYPE_ABBREVS { get; set; }
        /// <summary>
        /// Gets or sets the us e_ addres s_ poin t_ interpolation.
        /// </summary>
        /// <value>
        /// The us e_ addres s_ poin t_ interpolation.
        /// </value>
        Boolean? USE_ADDRESS_POINT_INTERPOLATION { get; set; }
        /// <summary>
        /// Gets or sets the us e_ centerlin e_ offset.
        /// </summary>
        /// <value>
        /// The us e_ centerlin e_ offset.
        /// </value>
        Boolean? USE_CENTERLINE_OFFSET { get; set; }
        /// <summary>
        /// Gets or sets the centerlin e_ offset.
        /// </summary>
        /// <value>
        /// The centerlin e_ offset.
        /// </value>
        int? CENTERLINE_OFFSET { get; set; }

        /// <summary>
        /// Gets or sets the centerlin e_ offse t_ unit.
        /// </summary>
        /// <value>
        /// The centerlin e_ offse t_ unit.
        /// </value>
        DistanceUnits? CENTERLINE_OFFSET_UNIT { get; set; }
}
}
