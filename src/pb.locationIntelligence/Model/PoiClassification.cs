/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 7.0.0
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
    /// PoiClassification
    /// </summary>
    [DataContract]
    public partial class PoiClassification :  IEquatable<PoiClassification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoiClassification" /> class.
        /// </summary>
        /// <param name="Sic">Sic.</param>
        /// <param name="Category">Category.</param>
        /// <param name="AlternateIndustryCode">AlternateIndustryCode.</param>
        public PoiClassification(Sic Sic = null, Category Category = null, string AlternateIndustryCode = null)
        {
            this.Sic = Sic;
            this.Category = Category;
            this.AlternateIndustryCode = AlternateIndustryCode;
        }
        
        /// <summary>
        /// Gets or Sets Sic
        /// </summary>
        [DataMember(Name="sic", EmitDefaultValue=false)]
        public Sic Sic { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public Category Category { get; set; }
        /// <summary>
        /// Gets or Sets AlternateIndustryCode
        /// </summary>
        [DataMember(Name="alternateIndustryCode", EmitDefaultValue=false)]
        public string AlternateIndustryCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoiClassification {\n");
            sb.Append("  Sic: ").Append(Sic).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  AlternateIndustryCode: ").Append(AlternateIndustryCode).Append("\n");
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
            return this.Equals(obj as PoiClassification);
        }

        /// <summary>
        /// Returns true if PoiClassification instances are equal
        /// </summary>
        /// <param name="other">Instance of PoiClassification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoiClassification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sic == other.Sic ||
                    this.Sic != null &&
                    this.Sic.Equals(other.Sic)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.AlternateIndustryCode == other.AlternateIndustryCode ||
                    this.AlternateIndustryCode != null &&
                    this.AlternateIndustryCode.Equals(other.AlternateIndustryCode)
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
                if (this.Sic != null)
                    hash = hash * 59 + this.Sic.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.AlternateIndustryCode != null)
                    hash = hash * 59 + this.AlternateIndustryCode.GetHashCode();
                return hash;
            }
        }
    }

}
