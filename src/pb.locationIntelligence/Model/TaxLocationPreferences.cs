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
    /// TaxLocationPreferences
    /// </summary>
    [DataContract]
    public partial class TaxLocationPreferences :  IEquatable<TaxLocationPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxLocationPreferences" /> class.
        /// </summary>
        /// <param name="DefaultBufferWidth">DefaultBufferWidth (default to &quot;0&quot;).</param>
        /// <param name="DistanceUnits">DistanceUnits (default to &quot;Feet&quot;).</param>
        /// <param name="OutputCasing">OutputCasing (default to &quot;M&quot;).</param>
        /// <param name="ReturnCensusFields">ReturnCensusFields.</param>
        /// <param name="ReturnLatLongFields">ReturnLatLongFields.</param>
        public TaxLocationPreferences(string DefaultBufferWidth = null, string DistanceUnits = null, string OutputCasing = null, string ReturnCensusFields = null, string ReturnLatLongFields = null)
        {
            // use default value if no "DefaultBufferWidth" provided
            if (DefaultBufferWidth == null)
            {
                this.DefaultBufferWidth = "0";
            }
            else
            {
                this.DefaultBufferWidth = DefaultBufferWidth;
            }
            // use default value if no "DistanceUnits" provided
            if (DistanceUnits == null)
            {
                this.DistanceUnits = "Feet";
            }
            else
            {
                this.DistanceUnits = DistanceUnits;
            }
            // use default value if no "OutputCasing" provided
            if (OutputCasing == null)
            {
                this.OutputCasing = "M";
            }
            else
            {
                this.OutputCasing = OutputCasing;
            }
            this.ReturnCensusFields = ReturnCensusFields;
            this.ReturnLatLongFields = ReturnLatLongFields;
        }
        
        /// <summary>
        /// Gets or Sets DefaultBufferWidth
        /// </summary>
        [DataMember(Name="defaultBufferWidth", EmitDefaultValue=false)]
        public string DefaultBufferWidth { get; set; }
        /// <summary>
        /// Gets or Sets DistanceUnits
        /// </summary>
        [DataMember(Name="distanceUnits", EmitDefaultValue=false)]
        public string DistanceUnits { get; set; }
        /// <summary>
        /// Gets or Sets OutputCasing
        /// </summary>
        [DataMember(Name="outputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }
        /// <summary>
        /// Gets or Sets ReturnCensusFields
        /// </summary>
        [DataMember(Name="returnCensusFields", EmitDefaultValue=false)]
        public string ReturnCensusFields { get; set; }
        /// <summary>
        /// Gets or Sets ReturnLatLongFields
        /// </summary>
        [DataMember(Name="returnLatLongFields", EmitDefaultValue=false)]
        public string ReturnLatLongFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxLocationPreferences {\n");
            sb.Append("  DefaultBufferWidth: ").Append(DefaultBufferWidth).Append("\n");
            sb.Append("  DistanceUnits: ").Append(DistanceUnits).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  ReturnCensusFields: ").Append(ReturnCensusFields).Append("\n");
            sb.Append("  ReturnLatLongFields: ").Append(ReturnLatLongFields).Append("\n");
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
            return this.Equals(obj as TaxLocationPreferences);
        }

        /// <summary>
        /// Returns true if TaxLocationPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxLocationPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxLocationPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DefaultBufferWidth == other.DefaultBufferWidth ||
                    this.DefaultBufferWidth != null &&
                    this.DefaultBufferWidth.Equals(other.DefaultBufferWidth)
                ) && 
                (
                    this.DistanceUnits == other.DistanceUnits ||
                    this.DistanceUnits != null &&
                    this.DistanceUnits.Equals(other.DistanceUnits)
                ) && 
                (
                    this.OutputCasing == other.OutputCasing ||
                    this.OutputCasing != null &&
                    this.OutputCasing.Equals(other.OutputCasing)
                ) && 
                (
                    this.ReturnCensusFields == other.ReturnCensusFields ||
                    this.ReturnCensusFields != null &&
                    this.ReturnCensusFields.Equals(other.ReturnCensusFields)
                ) && 
                (
                    this.ReturnLatLongFields == other.ReturnLatLongFields ||
                    this.ReturnLatLongFields != null &&
                    this.ReturnLatLongFields.Equals(other.ReturnLatLongFields)
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
                if (this.DefaultBufferWidth != null)
                    hash = hash * 59 + this.DefaultBufferWidth.GetHashCode();
                if (this.DistanceUnits != null)
                    hash = hash * 59 + this.DistanceUnits.GetHashCode();
                if (this.OutputCasing != null)
                    hash = hash * 59 + this.OutputCasing.GetHashCode();
                if (this.ReturnCensusFields != null)
                    hash = hash * 59 + this.ReturnCensusFields.GetHashCode();
                if (this.ReturnLatLongFields != null)
                    hash = hash * 59 + this.ReturnLatLongFields.GetHashCode();
                return hash;
            }
        }
    }

}
