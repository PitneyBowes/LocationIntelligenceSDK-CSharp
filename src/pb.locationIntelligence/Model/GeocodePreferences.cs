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
    /// GeocodePreferences
    /// </summary>
    [DataContract]
    public partial class GeocodePreferences :  IEquatable<GeocodePreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodePreferences" /> class.
        /// </summary>
        /// <param name="ReturnAllCandidateInfo">ReturnAllCandidateInfo (default to false).</param>
        /// <param name="FallbackToGeographic">FallbackToGeographic (default to true).</param>
        /// <param name="FallbackToPostal">FallbackToPostal (default to true).</param>
        /// <param name="MaxReturnedCandidates">MaxReturnedCandidates.</param>
        /// <param name="StreetOffset">StreetOffset.</param>
        /// <param name="CornerOffset">CornerOffset.</param>
        /// <param name="MatchMode">MatchMode.</param>
        /// <param name="ClientLocale">ClientLocale.</param>
        /// <param name="ClientCoordSysName">ClientCoordSysName.</param>
        /// <param name="StreetOffsetUnits">StreetOffsetUnits.</param>
        /// <param name="CornerOffsetUnits">CornerOffsetUnits.</param>
        /// <param name="MustMatchFields">MustMatchFields.</param>
        /// <param name="ReturnFieldsDescriptor">ReturnFieldsDescriptor.</param>
        /// <param name="OutputRecordType">OutputRecordType.</param>
        /// <param name="CustomPreferences">CustomPreferences.</param>
        /// <param name="PreferredDictionaryOrders">PreferredDictionaryOrders.</param>
        public GeocodePreferences(bool? ReturnAllCandidateInfo = null, bool? FallbackToGeographic = null, bool? FallbackToPostal = null, string MaxReturnedCandidates = null, string StreetOffset = null, string CornerOffset = null, string MatchMode = null, string ClientLocale = null, string ClientCoordSysName = null, string StreetOffsetUnits = null, string CornerOffsetUnits = null, FieldsMatching MustMatchFields = null, ReturnFieldsDescriptor ReturnFieldsDescriptor = null, string OutputRecordType = null, GeocodeCustomPreferences CustomPreferences = null, List<string> PreferredDictionaryOrders = null)
        {
            // use default value if no "ReturnAllCandidateInfo" provided
            if (ReturnAllCandidateInfo == null)
            {
                this.ReturnAllCandidateInfo = false;
            }
            else
            {
                this.ReturnAllCandidateInfo = ReturnAllCandidateInfo;
            }
            // use default value if no "FallbackToGeographic" provided
            if (FallbackToGeographic == null)
            {
                this.FallbackToGeographic = true;
            }
            else
            {
                this.FallbackToGeographic = FallbackToGeographic;
            }
            // use default value if no "FallbackToPostal" provided
            if (FallbackToPostal == null)
            {
                this.FallbackToPostal = true;
            }
            else
            {
                this.FallbackToPostal = FallbackToPostal;
            }
            this.MaxReturnedCandidates = MaxReturnedCandidates;
            this.StreetOffset = StreetOffset;
            this.CornerOffset = CornerOffset;
            this.MatchMode = MatchMode;
            this.ClientLocale = ClientLocale;
            this.ClientCoordSysName = ClientCoordSysName;
            this.StreetOffsetUnits = StreetOffsetUnits;
            this.CornerOffsetUnits = CornerOffsetUnits;
            this.MustMatchFields = MustMatchFields;
            this.ReturnFieldsDescriptor = ReturnFieldsDescriptor;
            this.OutputRecordType = OutputRecordType;
            this.CustomPreferences = CustomPreferences;
            this.PreferredDictionaryOrders = PreferredDictionaryOrders;
        }
        
        /// <summary>
        /// Gets or Sets ReturnAllCandidateInfo
        /// </summary>
        [DataMember(Name="returnAllCandidateInfo", EmitDefaultValue=false)]
        public bool? ReturnAllCandidateInfo { get; set; }
        /// <summary>
        /// Gets or Sets FallbackToGeographic
        /// </summary>
        [DataMember(Name="fallbackToGeographic", EmitDefaultValue=false)]
        public bool? FallbackToGeographic { get; set; }
        /// <summary>
        /// Gets or Sets FallbackToPostal
        /// </summary>
        [DataMember(Name="fallbackToPostal", EmitDefaultValue=false)]
        public bool? FallbackToPostal { get; set; }
        /// <summary>
        /// Gets or Sets MaxReturnedCandidates
        /// </summary>
        [DataMember(Name="maxReturnedCandidates", EmitDefaultValue=false)]
        public string MaxReturnedCandidates { get; set; }
        /// <summary>
        /// Gets or Sets StreetOffset
        /// </summary>
        [DataMember(Name="streetOffset", EmitDefaultValue=false)]
        public string StreetOffset { get; set; }
        /// <summary>
        /// Gets or Sets CornerOffset
        /// </summary>
        [DataMember(Name="cornerOffset", EmitDefaultValue=false)]
        public string CornerOffset { get; set; }
        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=false)]
        public string MatchMode { get; set; }
        /// <summary>
        /// Gets or Sets ClientLocale
        /// </summary>
        [DataMember(Name="clientLocale", EmitDefaultValue=false)]
        public string ClientLocale { get; set; }
        /// <summary>
        /// Gets or Sets ClientCoordSysName
        /// </summary>
        [DataMember(Name="clientCoordSysName", EmitDefaultValue=false)]
        public string ClientCoordSysName { get; set; }
        /// <summary>
        /// Gets or Sets StreetOffsetUnits
        /// </summary>
        [DataMember(Name="streetOffsetUnits", EmitDefaultValue=false)]
        public string StreetOffsetUnits { get; set; }
        /// <summary>
        /// Gets or Sets CornerOffsetUnits
        /// </summary>
        [DataMember(Name="cornerOffsetUnits", EmitDefaultValue=false)]
        public string CornerOffsetUnits { get; set; }
        /// <summary>
        /// Gets or Sets MustMatchFields
        /// </summary>
        [DataMember(Name="mustMatchFields", EmitDefaultValue=false)]
        public FieldsMatching MustMatchFields { get; set; }
        /// <summary>
        /// Gets or Sets ReturnFieldsDescriptor
        /// </summary>
        [DataMember(Name="returnFieldsDescriptor", EmitDefaultValue=false)]
        public ReturnFieldsDescriptor ReturnFieldsDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets OutputRecordType
        /// </summary>
        [DataMember(Name="outputRecordType", EmitDefaultValue=false)]
        public string OutputRecordType { get; set; }
        /// <summary>
        /// Gets or Sets CustomPreferences
        /// </summary>
        [DataMember(Name="customPreferences", EmitDefaultValue=false)]
        public GeocodeCustomPreferences CustomPreferences { get; set; }
        /// <summary>
        /// Gets or Sets PreferredDictionaryOrders
        /// </summary>
        [DataMember(Name="preferredDictionaryOrders", EmitDefaultValue=false)]
        public List<string> PreferredDictionaryOrders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodePreferences {\n");
            sb.Append("  ReturnAllCandidateInfo: ").Append(ReturnAllCandidateInfo).Append("\n");
            sb.Append("  FallbackToGeographic: ").Append(FallbackToGeographic).Append("\n");
            sb.Append("  FallbackToPostal: ").Append(FallbackToPostal).Append("\n");
            sb.Append("  MaxReturnedCandidates: ").Append(MaxReturnedCandidates).Append("\n");
            sb.Append("  StreetOffset: ").Append(StreetOffset).Append("\n");
            sb.Append("  CornerOffset: ").Append(CornerOffset).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
            sb.Append("  ClientCoordSysName: ").Append(ClientCoordSysName).Append("\n");
            sb.Append("  StreetOffsetUnits: ").Append(StreetOffsetUnits).Append("\n");
            sb.Append("  CornerOffsetUnits: ").Append(CornerOffsetUnits).Append("\n");
            sb.Append("  MustMatchFields: ").Append(MustMatchFields).Append("\n");
            sb.Append("  ReturnFieldsDescriptor: ").Append(ReturnFieldsDescriptor).Append("\n");
            sb.Append("  OutputRecordType: ").Append(OutputRecordType).Append("\n");
            sb.Append("  CustomPreferences: ").Append(CustomPreferences).Append("\n");
            sb.Append("  PreferredDictionaryOrders: ").Append(PreferredDictionaryOrders).Append("\n");
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
            return this.Equals(obj as GeocodePreferences);
        }

        /// <summary>
        /// Returns true if GeocodePreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of GeocodePreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodePreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReturnAllCandidateInfo == other.ReturnAllCandidateInfo ||
                    this.ReturnAllCandidateInfo != null &&
                    this.ReturnAllCandidateInfo.Equals(other.ReturnAllCandidateInfo)
                ) && 
                (
                    this.FallbackToGeographic == other.FallbackToGeographic ||
                    this.FallbackToGeographic != null &&
                    this.FallbackToGeographic.Equals(other.FallbackToGeographic)
                ) && 
                (
                    this.FallbackToPostal == other.FallbackToPostal ||
                    this.FallbackToPostal != null &&
                    this.FallbackToPostal.Equals(other.FallbackToPostal)
                ) && 
                (
                    this.MaxReturnedCandidates == other.MaxReturnedCandidates ||
                    this.MaxReturnedCandidates != null &&
                    this.MaxReturnedCandidates.Equals(other.MaxReturnedCandidates)
                ) && 
                (
                    this.StreetOffset == other.StreetOffset ||
                    this.StreetOffset != null &&
                    this.StreetOffset.Equals(other.StreetOffset)
                ) && 
                (
                    this.CornerOffset == other.CornerOffset ||
                    this.CornerOffset != null &&
                    this.CornerOffset.Equals(other.CornerOffset)
                ) && 
                (
                    this.MatchMode == other.MatchMode ||
                    this.MatchMode != null &&
                    this.MatchMode.Equals(other.MatchMode)
                ) && 
                (
                    this.ClientLocale == other.ClientLocale ||
                    this.ClientLocale != null &&
                    this.ClientLocale.Equals(other.ClientLocale)
                ) && 
                (
                    this.ClientCoordSysName == other.ClientCoordSysName ||
                    this.ClientCoordSysName != null &&
                    this.ClientCoordSysName.Equals(other.ClientCoordSysName)
                ) && 
                (
                    this.StreetOffsetUnits == other.StreetOffsetUnits ||
                    this.StreetOffsetUnits != null &&
                    this.StreetOffsetUnits.Equals(other.StreetOffsetUnits)
                ) && 
                (
                    this.CornerOffsetUnits == other.CornerOffsetUnits ||
                    this.CornerOffsetUnits != null &&
                    this.CornerOffsetUnits.Equals(other.CornerOffsetUnits)
                ) && 
                (
                    this.MustMatchFields == other.MustMatchFields ||
                    this.MustMatchFields != null &&
                    this.MustMatchFields.Equals(other.MustMatchFields)
                ) && 
                (
                    this.ReturnFieldsDescriptor == other.ReturnFieldsDescriptor ||
                    this.ReturnFieldsDescriptor != null &&
                    this.ReturnFieldsDescriptor.Equals(other.ReturnFieldsDescriptor)
                ) && 
                (
                    this.OutputRecordType == other.OutputRecordType ||
                    this.OutputRecordType != null &&
                    this.OutputRecordType.Equals(other.OutputRecordType)
                ) && 
                (
                    this.CustomPreferences == other.CustomPreferences ||
                    this.CustomPreferences != null &&
                    this.CustomPreferences.Equals(other.CustomPreferences)
                ) && 
                (
                    this.PreferredDictionaryOrders == other.PreferredDictionaryOrders ||
                    this.PreferredDictionaryOrders != null &&
                    this.PreferredDictionaryOrders.SequenceEqual(other.PreferredDictionaryOrders)
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
                if (this.ReturnAllCandidateInfo != null)
                    hash = hash * 59 + this.ReturnAllCandidateInfo.GetHashCode();
                if (this.FallbackToGeographic != null)
                    hash = hash * 59 + this.FallbackToGeographic.GetHashCode();
                if (this.FallbackToPostal != null)
                    hash = hash * 59 + this.FallbackToPostal.GetHashCode();
                if (this.MaxReturnedCandidates != null)
                    hash = hash * 59 + this.MaxReturnedCandidates.GetHashCode();
                if (this.StreetOffset != null)
                    hash = hash * 59 + this.StreetOffset.GetHashCode();
                if (this.CornerOffset != null)
                    hash = hash * 59 + this.CornerOffset.GetHashCode();
                if (this.MatchMode != null)
                    hash = hash * 59 + this.MatchMode.GetHashCode();
                if (this.ClientLocale != null)
                    hash = hash * 59 + this.ClientLocale.GetHashCode();
                if (this.ClientCoordSysName != null)
                    hash = hash * 59 + this.ClientCoordSysName.GetHashCode();
                if (this.StreetOffsetUnits != null)
                    hash = hash * 59 + this.StreetOffsetUnits.GetHashCode();
                if (this.CornerOffsetUnits != null)
                    hash = hash * 59 + this.CornerOffsetUnits.GetHashCode();
                if (this.MustMatchFields != null)
                    hash = hash * 59 + this.MustMatchFields.GetHashCode();
                if (this.ReturnFieldsDescriptor != null)
                    hash = hash * 59 + this.ReturnFieldsDescriptor.GetHashCode();
                if (this.OutputRecordType != null)
                    hash = hash * 59 + this.OutputRecordType.GetHashCode();
                if (this.CustomPreferences != null)
                    hash = hash * 59 + this.CustomPreferences.GetHashCode();
                if (this.PreferredDictionaryOrders != null)
                    hash = hash * 59 + this.PreferredDictionaryOrders.GetHashCode();
                return hash;
            }
        }
    }

}