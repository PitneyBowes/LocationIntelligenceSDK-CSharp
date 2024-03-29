/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 8.5.0
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
    /// SupportLevel
    /// </summary>
    [DataContract]
    public partial class SupportLevel :  IEquatable<SupportLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportLevel" /> class.
        /// </summary>
        /// <param name="SupportedDataLevel">SupportedDataLevel.</param>
        /// <param name="Countries">Countries.</param>
        /// <param name="UpdatedRequiredInputs">UpdatedRequiredInputs.</param>
        /// <param name="UpdatedOptionalInputs">UpdatedOptionalInputs.</param>
        /// <param name="UpdatedOptionalOutputs">UpdatedOptionalOutputs.</param>
        public SupportLevel(int? SupportedDataLevel = null, List<string> Countries = null, List<InputParameter> UpdatedRequiredInputs = null, List<InputParameter> UpdatedOptionalInputs = null, List<OutputParameter> UpdatedOptionalOutputs = null)
        {
            this.SupportedDataLevel = SupportedDataLevel;
            this.Countries = Countries;
            this.UpdatedRequiredInputs = UpdatedRequiredInputs;
            this.UpdatedOptionalInputs = UpdatedOptionalInputs;
            this.UpdatedOptionalOutputs = UpdatedOptionalOutputs;
        }
        
        /// <summary>
        /// Gets or Sets SupportedDataLevel
        /// </summary>
        [DataMember(Name="supportedDataLevel", EmitDefaultValue=false)]
        public int? SupportedDataLevel { get; set; }
        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedRequiredInputs
        /// </summary>
        [DataMember(Name="updatedRequiredInputs", EmitDefaultValue=false)]
        public List<InputParameter> UpdatedRequiredInputs { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedOptionalInputs
        /// </summary>
        [DataMember(Name="updatedOptionalInputs", EmitDefaultValue=false)]
        public List<InputParameter> UpdatedOptionalInputs { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedOptionalOutputs
        /// </summary>
        [DataMember(Name="updatedOptionalOutputs", EmitDefaultValue=false)]
        public List<OutputParameter> UpdatedOptionalOutputs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportLevel {\n");
            sb.Append("  SupportedDataLevel: ").Append(SupportedDataLevel).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  UpdatedRequiredInputs: ").Append(UpdatedRequiredInputs).Append("\n");
            sb.Append("  UpdatedOptionalInputs: ").Append(UpdatedOptionalInputs).Append("\n");
            sb.Append("  UpdatedOptionalOutputs: ").Append(UpdatedOptionalOutputs).Append("\n");
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
            return this.Equals(obj as SupportLevel);
        }

        /// <summary>
        /// Returns true if SupportLevel instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportLevel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SupportedDataLevel == other.SupportedDataLevel ||
                    this.SupportedDataLevel != null &&
                    this.SupportedDataLevel.Equals(other.SupportedDataLevel)
                ) && 
                (
                    this.Countries == other.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(other.Countries)
                ) && 
                (
                    this.UpdatedRequiredInputs == other.UpdatedRequiredInputs ||
                    this.UpdatedRequiredInputs != null &&
                    this.UpdatedRequiredInputs.SequenceEqual(other.UpdatedRequiredInputs)
                ) && 
                (
                    this.UpdatedOptionalInputs == other.UpdatedOptionalInputs ||
                    this.UpdatedOptionalInputs != null &&
                    this.UpdatedOptionalInputs.SequenceEqual(other.UpdatedOptionalInputs)
                ) && 
                (
                    this.UpdatedOptionalOutputs == other.UpdatedOptionalOutputs ||
                    this.UpdatedOptionalOutputs != null &&
                    this.UpdatedOptionalOutputs.SequenceEqual(other.UpdatedOptionalOutputs)
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
                if (this.SupportedDataLevel != null)
                    hash = hash * 59 + this.SupportedDataLevel.GetHashCode();
                if (this.Countries != null)
                    hash = hash * 59 + this.Countries.GetHashCode();
                if (this.UpdatedRequiredInputs != null)
                    hash = hash * 59 + this.UpdatedRequiredInputs.GetHashCode();
                if (this.UpdatedOptionalInputs != null)
                    hash = hash * 59 + this.UpdatedOptionalInputs.GetHashCode();
                if (this.UpdatedOptionalOutputs != null)
                    hash = hash * 59 + this.UpdatedOptionalOutputs.GetHashCode();
                return hash;
            }
        }
    }

}
