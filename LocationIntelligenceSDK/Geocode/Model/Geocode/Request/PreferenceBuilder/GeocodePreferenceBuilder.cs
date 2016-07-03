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
    public class GeocodePreferenceBuilder
    {
        /// <summary>
        /// The geocode preference
        /// </summary>
        private GeocodePreference geocodePreference=null;
        /// <summary>
        /// Gets or sets the custom preference.
        /// </summary>
        /// <value>
        /// The custom preference.
        /// </value>
        public List<ICustomPreference> CustomPreference { get; set; }

        /// <summary>
        /// Gets or sets the geocode preference.
        /// </summary>
        /// <value>
        /// The geocode preference.
        /// </value>
        public GeocodePreference GeocodePreference  {
            get
            {
                if(geocodePreference==null)
                {
                    geocodePreference = new GeocodePreference();
                    
                }
                return geocodePreference;
            }

            set
            {
                geocodePreference = value;
            }
                }

        /// <summary>
        /// Gets or sets the return fields descriptor preferences.
        /// </summary>
        /// <value>
        /// The return fields descriptor preferences.
        /// </value>
        public GeocodeReturnFieldsDescriptor ReturnFieldsDescriptorPreferences { get; set; }

    }
}
