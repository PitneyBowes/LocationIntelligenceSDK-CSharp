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
    /// Details of Country 
    /// </summary>
    public class County
    {
        /// <summary>
        /// Name of county where the PSAP is located.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }
        /// <summary>
        /// FIPS of county where the PSAP is located.
        /// </summary>
        /// <value>
        /// The fips.
        /// </value>
        public string fips { get; set; }
    }
}
