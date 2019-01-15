/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.0.0
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
    /// EarthquakeRiskLocationResponse
    /// </summary>
    [DataContract]
    public partial class EarthquakeRiskLocationResponse :  IEquatable<EarthquakeRiskLocationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeRiskLocationResponse" /> class.
        /// </summary>
        /// <param name="RiskLevel">RiskLevel.</param>
        /// <param name="EventsCount">EventsCount.</param>
        /// <param name="Grid">Grid.</param>
        public EarthquakeRiskLocationResponse(string RiskLevel = null, EventsCount EventsCount = null, Grid Grid = null)
        {
            this.RiskLevel = RiskLevel;
            this.EventsCount = EventsCount;
            this.Grid = Grid;
        }
        
        /// <summary>
        /// Gets or Sets RiskLevel
        /// </summary>
        [DataMember(Name="riskLevel", EmitDefaultValue=false)]
        public string RiskLevel { get; set; }
        /// <summary>
        /// Gets or Sets EventsCount
        /// </summary>
        [DataMember(Name="eventsCount", EmitDefaultValue=false)]
        public EventsCount EventsCount { get; set; }
        /// <summary>
        /// Gets or Sets Grid
        /// </summary>
        [DataMember(Name="grid", EmitDefaultValue=false)]
        public Grid Grid { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarthquakeRiskLocationResponse {\n");
            sb.Append("  RiskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  EventsCount: ").Append(EventsCount).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
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
            return this.Equals(obj as EarthquakeRiskLocationResponse);
        }

        /// <summary>
        /// Returns true if EarthquakeRiskLocationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EarthquakeRiskLocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeRiskLocationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RiskLevel == other.RiskLevel ||
                    this.RiskLevel != null &&
                    this.RiskLevel.Equals(other.RiskLevel)
                ) && 
                (
                    this.EventsCount == other.EventsCount ||
                    this.EventsCount != null &&
                    this.EventsCount.Equals(other.EventsCount)
                ) && 
                (
                    this.Grid == other.Grid ||
                    this.Grid != null &&
                    this.Grid.Equals(other.Grid)
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
                if (this.RiskLevel != null)
                    hash = hash * 59 + this.RiskLevel.GetHashCode();
                if (this.EventsCount != null)
                    hash = hash * 59 + this.EventsCount.GetHashCode();
                if (this.Grid != null)
                    hash = hash * 59 + this.Grid.GetHashCode();
                return hash;
            }
        }
    }

}