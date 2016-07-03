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
    public interface ICustomPreferenceUSA : ICustomPreference
    {

        
        /// <summary>
        /// Gets or sets the fin d_ addrcode.
        /// </summary>
        /// <value>
        /// The fin d_ addrcode.
        /// </value>
        Boolean? FIND_ADDRCODE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ addres s_ range.
        /// </summary>
        /// <value>
        /// The fin d_ addres s_ range.
        /// </value>
        Boolean? FIND_ADDRESS_RANGE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ buildin g_ search.
        /// </summary>
        /// <value>
        /// The fin d_ buildin g_ search.
        /// </value>
        Boolean? FIND_BUILDING_SEARCH
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ centerlin e_ offset.
        /// </summary>
        /// <value>
        /// The fin d_ centerlin e_ offset.
        /// </value>
        int FIND_CENTERLINE_OFFSET
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ centerl n_ pro j_ o f_ point.
        /// </summary>
        /// <value>
        /// The fin d_ centerl n_ pro j_ o f_ point.
        /// </value>
        Boolean? FIND_CENTERLN_PROJ_OF_POINT
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ correc t_ lastline.
        /// </summary>
        /// <value>
        /// The fin d_ correc t_ lastline.
        /// </value>
        Boolean? FIND_CORRECT_LASTLINE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ d b_ order.
        /// </summary>
        /// <value>
        /// The fin d_ d b_ order.
        /// </value>
        Boolean? FIND_DB_ORDER
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ DPV.
        /// </summary>
        /// <value>
        /// The fin d_ DPV.
        /// </value>
        Boolean? FIND_DPV
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ expande d_ searc h_ radius.
        /// </summary>
        /// <value>
        /// The fin d_ expande d_ searc h_ radius.
        /// </value>
        int FIND_EXPANDED_SEARCH_RADIUS
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the state of the fin d_ expn d_ source h_ li m_ t o_.
        /// </summary>
        /// <value>
        /// The state of the fin d_ expn d_ source h_ li m_ t o_.
        /// </value>
        Boolean? FIND_EXPND_SRCH_LIM_TO_STATE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ firs t_ lette r_ expanded.
        /// </summary>
        /// <value>
        /// The fin d_ firs t_ lette r_ expanded.
        /// </value>
        Boolean? FIND_FIRST_LETTER_EXPANDED
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ lacslink.
        /// </summary>
        /// <value>
        /// The fin d_ lacslink.
        /// </value>
        Boolean? FIND_LACSLINK
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ mixe d_ case.
        /// </summary>
        /// <value>
        /// The fin d_ mixe d_ case.
        /// </value>
        Boolean? FIND_MIXED_CASE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ prefe r_ pobox.
        /// </summary>
        /// <value>
        /// The fin d_ prefe r_ pobox.
        /// </value>
        Boolean? FIND_PREFER_POBOX
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ prefe r_ street.
        /// </summary>
        /// <value>
        /// The fin d_ prefe r_ street.
        /// </value>
        Boolean? FIND_PREFER_STREET
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ prefe r_ zi p_ ove r_ city.
        /// </summary>
        /// <value>
        /// The fin d_ prefe r_ zi p_ ove r_ city.
        /// </value>
        Boolean? FIND_PREFER_ZIP_OVER_CITY
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ searc h_ area.
        /// </summary>
        /// <value>
        /// The fin d_ searc h_ area.
        /// </value>
        Boolean? FIND_SEARCH_AREA
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ stree t_ centroid.
        /// </summary>
        /// <value>
        /// The fin d_ stree t_ centroid.
        /// </value>
        Boolean? FIND_STREET_CENTROID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ suitelink.
        /// </summary>
        /// <value>
        /// The fin d_ suitelink.
        /// </value>
        Boolean? FIND_SUITELINK
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ Z5_ code.
        /// </summary>
        /// <value>
        /// The fin d_ Z5_ code.
        /// </value>
        Boolean? FIND_Z5_CODE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ Z7_ code.
        /// </summary>
        /// <value>
        /// The fin d_ Z7_ code.
        /// </value>
        Boolean? FIND_Z7_CODE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ Z9_ code.
        /// </summary>
        /// <value>
        /// The fin d_ Z9_ code.
        /// </value>
        Boolean? FIND_Z9_CODE
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the fin d_ z_ code.
        /// </summary>
        /// <value>
        /// The fin d_ z_ code.
        /// </value>
        Boolean? FIND_Z_CODE
        {
            get; set;
        }

        
        /// <summary>
        /// Gets or sets the retur n_ la t_ lo n_ a s_ intege r_ value.
        /// </summary>
        /// <value>
        /// The retur n_ la t_ lo n_ a s_ intege r_ value.
        /// </value>
        Boolean? RETURN_LAT_LON_AS_INTEGER_VALUE
        {
            get; set;
        }

        
    }
   

}
