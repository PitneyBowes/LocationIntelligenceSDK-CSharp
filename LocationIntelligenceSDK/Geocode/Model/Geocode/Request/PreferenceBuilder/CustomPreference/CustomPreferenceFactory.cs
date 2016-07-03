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
    public static class CustomPreferenceFactory
    {

        /// <summary>
        /// Gets the custom preference.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        public static ICustomPreference GetCustomPreference(Country country)
        {
            return new CustomPreference(country);
        }


        /// <summary>
        /// Gets the custom preference.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreference GetCustomPreference()
        {
            return new CustomPreference();
        }

        /// <summary>
        /// Gets the custom preference usa.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceUSA GetCustomPreferenceUSA()
        {
            return new CustomPreferenceUSA();
        }
        /// <summary>
        /// Gets the custom preference canada.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceCAN GetCustomPreferenceCanada()
        {
            return new CustomPreferenceCAN();
        }
        /// <summary>
        /// Gets the custom preference germany.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceDUE GetCustomPreferenceGermany()
        {
            return new CustomPreferenceDUE();
        }
        /// <summary>
        /// Gets the custom preference australia.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceAUS GetCustomPreferenceAustralia()
        {

            return new CustomPreferenceAUS();
        }

        /// <summary>
        /// Gets the custom preference france.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceFRA GetCustomPreferenceFrance()
        {
            return new CustomPreferenceFRA();
        }
        /// <summary>
        /// Gets the custom preference great britain.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceGBR GetCustomPreferenceGreatBritain()
        {
            return new CustomPreferenceGBR();
        }
        /// <summary>
        /// Gets the custom preference new zerland.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreferenceNZL GetCustomPreferenceNewZerland()
        {
            return new CustomPreferenceNZL();
        }
        /// <summary>
        /// Gets the custom preference protugol.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreference GetCustomPreferenceProtugol()
        {
            return new CustomPreferencePRT();
        }
        /// <summary>
        /// Gets the custom preference singapore.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreference GetCustomPreferenceSingapore()
        {
            return new CustomPreferenceSGP();
        }
        /// <summary>
        /// Gets the custom preference sweden.
        /// </summary>
        /// <returns></returns>
        public static ICustomPreference GetCustomPreferenceSweden()
        {
            return new CustomPreferenceSWE();
        }

       
    }
}
