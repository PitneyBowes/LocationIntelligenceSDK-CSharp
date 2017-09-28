/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 3.7.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace pb.locationIntelligence.Model
{
    /// <summary>
    /// GeocodeCapabilitiesResponse
    /// </summary>
    [DataContract]
    public partial class GeocodeCapabilitiesResponse :  IEquatable<GeocodeCapabilitiesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeCapabilitiesResponse" /> class.
        /// </summary>
        /// <param name="ServiceName">ServiceName.</param>
        /// <param name="ServiceDescription">ServiceDescription.</param>
        /// <param name="CoreVersion">CoreVersion.</param>
        /// <param name="SupportedCountries">SupportedCountries.</param>
        /// <param name="SupportedOperations">SupportedOperations.</param>
        /// <param name="CustomObjects">CustomObjects.</param>
        public GeocodeCapabilitiesResponse(string ServiceName = null, string ServiceDescription = null, string CoreVersion = null, List<string> SupportedCountries = null, List<Operation> SupportedOperations = null, List<CustomObject> CustomObjects = null)
        {
            this.ServiceName = ServiceName;
            this.ServiceDescription = ServiceDescription;
            this.CoreVersion = CoreVersion;
            this.SupportedCountries = SupportedCountries;
            this.SupportedOperations = SupportedOperations;
            this.CustomObjects = CustomObjects;
        }
        
        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }
        /// <summary>
        /// Gets or Sets ServiceDescription
        /// </summary>
        [DataMember(Name="serviceDescription", EmitDefaultValue=false)]
        public string ServiceDescription { get; set; }
        /// <summary>
        /// Gets or Sets CoreVersion
        /// </summary>
        [DataMember(Name="coreVersion", EmitDefaultValue=false)]
        public string CoreVersion { get; set; }
        /// <summary>
        /// Gets or Sets SupportedCountries
        /// </summary>
        [DataMember(Name="supportedCountries", EmitDefaultValue=false)]
        public List<string> SupportedCountries { get; set; }
        /// <summary>
        /// Gets or Sets SupportedOperations
        /// </summary>
        [DataMember(Name="supportedOperations", EmitDefaultValue=false)]
        public List<Operation> SupportedOperations { get; set; }
        /// <summary>
        /// Gets or Sets CustomObjects
        /// </summary>
        [DataMember(Name="customObjects", EmitDefaultValue=false)]
        public List<CustomObject> CustomObjects { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeCapabilitiesResponse {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceDescription: ").Append(ServiceDescription).Append("\n");
            sb.Append("  CoreVersion: ").Append(CoreVersion).Append("\n");
            sb.Append("  SupportedCountries: ").Append(SupportedCountries).Append("\n");
            sb.Append("  SupportedOperations: ").Append(SupportedOperations).Append("\n");
            sb.Append("  CustomObjects: ").Append(CustomObjects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GeocodeCapabilitiesResponse);
        }

        /// <summary>
        /// Returns true if GeocodeCapabilitiesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GeocodeCapabilitiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeCapabilitiesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) && 
                (
                    this.ServiceDescription == other.ServiceDescription ||
                    this.ServiceDescription != null &&
                    this.ServiceDescription.Equals(other.ServiceDescription)
                ) && 
                (
                    this.CoreVersion == other.CoreVersion ||
                    this.CoreVersion != null &&
                    this.CoreVersion.Equals(other.CoreVersion)
                ) && 
                (
                    this.SupportedCountries == other.SupportedCountries ||
                    this.SupportedCountries != null &&
                    this.SupportedCountries.SequenceEqual(other.SupportedCountries)
                ) && 
                (
                    this.SupportedOperations == other.SupportedOperations ||
                    this.SupportedOperations != null &&
                    this.SupportedOperations.SequenceEqual(other.SupportedOperations)
                ) && 
                (
                    this.CustomObjects == other.CustomObjects ||
                    this.CustomObjects != null &&
                    this.CustomObjects.SequenceEqual(other.CustomObjects)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                if (this.ServiceDescription != null)
                    hash = hash * 59 + this.ServiceDescription.GetHashCode();
                if (this.CoreVersion != null)
                    hash = hash * 59 + this.CoreVersion.GetHashCode();
                if (this.SupportedCountries != null)
                    hash = hash * 59 + this.SupportedCountries.GetHashCode();
                if (this.SupportedOperations != null)
                    hash = hash * 59 + this.SupportedOperations.GetHashCode();
                if (this.CustomObjects != null)
                    hash = hash * 59 + this.CustomObjects.GetHashCode();
                return hash;
            }
        }
    }

}
