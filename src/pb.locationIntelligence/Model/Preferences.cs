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
    /// Preferences
    /// </summary>
    [DataContract]
    public partial class Preferences :  IEquatable<Preferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Preferences" /> class.
        /// </summary>
        /// <param name="ReturnAllCandidateInfo">ReturnAllCandidateInfo (default to &quot;false&quot;).</param>
        /// <param name="FallbackToGeographic">FallbackToGeographic.</param>
        /// <param name="FallbackToPostal">FallbackToPostal.</param>
        /// <param name="MaxReturnedCandidates">MaxReturnedCandidates.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="StreetOffset">StreetOffset.</param>
        /// <param name="CornerOffset">CornerOffset.</param>
        /// <param name="MatchMode">MatchMode.</param>
        /// <param name="ClientLocale">ClientLocale.</param>
        /// <param name="ClientCoordSysName">ClientCoordSysName.</param>
        /// <param name="DistanceUnits">DistanceUnits.</param>
        /// <param name="StreetOffsetUnits">StreetOffsetUnits.</param>
        /// <param name="CornerOffsetUnits">CornerOffsetUnits.</param>
        /// <param name="MustMatchFields">MustMatchFields.</param>
        /// <param name="ReturnFieldsDescriptor">ReturnFieldsDescriptor.</param>
        /// <param name="OutputRecordType">OutputRecordType.</param>
        /// <param name="CustomPreferences">CustomPreferences.</param>
        /// <param name="PreferredDictionaryOrders">PreferredDictionaryOrders.</param>
        /// <param name="OutputCasing">OutputCasing.</param>
        /// <param name="LatLongOffset">LatLongOffset.</param>
        /// <param name="Squeeze">Squeeze.</param>
        /// <param name="ReturnLatLongFields">ReturnLatLongFields.</param>
        /// <param name="UseGeoTaxAuxiliaryFile">UseGeoTaxAuxiliaryFile.</param>
        /// <param name="LatLongFormat">LatLongFormat.</param>
        /// <param name="DefaultBufferWidth">DefaultBufferWidth.</param>
        /// <param name="ReturnCensusFields">ReturnCensusFields.</param>
        /// <param name="TaxRatetypeID">TaxRatetypeID.</param>
        public Preferences(string ReturnAllCandidateInfo = null, string FallbackToGeographic = null, string FallbackToPostal = null, string MaxReturnedCandidates = null, double? Distance = null, string StreetOffset = null, string CornerOffset = null, string MatchMode = null, string ClientLocale = null, string ClientCoordSysName = null, string DistanceUnits = null, string StreetOffsetUnits = null, string CornerOffsetUnits = null, FieldsMatching MustMatchFields = null, ReturnFieldsDescriptor ReturnFieldsDescriptor = null, string OutputRecordType = null, Dictionary<string, Object> CustomPreferences = null, List<string> PreferredDictionaryOrders = null, string OutputCasing = null, string LatLongOffset = null, string Squeeze = null, string ReturnLatLongFields = null, string UseGeoTaxAuxiliaryFile = null, string LatLongFormat = null, string DefaultBufferWidth = null, string ReturnCensusFields = null, string TaxRatetypeID = null)
        {
            // use default value if no "ReturnAllCandidateInfo" provided
            if (ReturnAllCandidateInfo == null)
            {
                this.ReturnAllCandidateInfo = "false";
            }
            else
            {
                this.ReturnAllCandidateInfo = ReturnAllCandidateInfo;
            }
            this.FallbackToGeographic = FallbackToGeographic;
            this.FallbackToPostal = FallbackToPostal;
            this.MaxReturnedCandidates = MaxReturnedCandidates;
            this.Distance = Distance;
            this.StreetOffset = StreetOffset;
            this.CornerOffset = CornerOffset;
            this.MatchMode = MatchMode;
            this.ClientLocale = ClientLocale;
            this.ClientCoordSysName = ClientCoordSysName;
            this.DistanceUnits = DistanceUnits;
            this.StreetOffsetUnits = StreetOffsetUnits;
            this.CornerOffsetUnits = CornerOffsetUnits;
            this.MustMatchFields = MustMatchFields;
            this.ReturnFieldsDescriptor = ReturnFieldsDescriptor;
            this.OutputRecordType = OutputRecordType;
            this.CustomPreferences = CustomPreferences;
            this.PreferredDictionaryOrders = PreferredDictionaryOrders;
            this.OutputCasing = OutputCasing;
            this.LatLongOffset = LatLongOffset;
            this.Squeeze = Squeeze;
            this.ReturnLatLongFields = ReturnLatLongFields;
            this.UseGeoTaxAuxiliaryFile = UseGeoTaxAuxiliaryFile;
            this.LatLongFormat = LatLongFormat;
            this.DefaultBufferWidth = DefaultBufferWidth;
            this.ReturnCensusFields = ReturnCensusFields;
            this.TaxRatetypeID = TaxRatetypeID;
        }
        
        /// <summary>
        /// Gets or Sets ReturnAllCandidateInfo
        /// </summary>
        [DataMember(Name="returnAllCandidateInfo", EmitDefaultValue=false)]
        public string ReturnAllCandidateInfo { get; set; }
        /// <summary>
        /// Gets or Sets FallbackToGeographic
        /// </summary>
        [DataMember(Name="fallbackToGeographic", EmitDefaultValue=false)]
        public string FallbackToGeographic { get; set; }
        /// <summary>
        /// Gets or Sets FallbackToPostal
        /// </summary>
        [DataMember(Name="fallbackToPostal", EmitDefaultValue=false)]
        public string FallbackToPostal { get; set; }
        /// <summary>
        /// Gets or Sets MaxReturnedCandidates
        /// </summary>
        [DataMember(Name="maxReturnedCandidates", EmitDefaultValue=false)]
        public string MaxReturnedCandidates { get; set; }
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public double? Distance { get; set; }
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
        /// Gets or Sets DistanceUnits
        /// </summary>
        [DataMember(Name="distanceUnits", EmitDefaultValue=false)]
        public string DistanceUnits { get; set; }
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
        public Dictionary<string, Object> CustomPreferences { get; set; }
        /// <summary>
        /// Gets or Sets PreferredDictionaryOrders
        /// </summary>
        [DataMember(Name="preferredDictionaryOrders", EmitDefaultValue=false)]
        public List<string> PreferredDictionaryOrders { get; set; }
        /// <summary>
        /// Gets or Sets OutputCasing
        /// </summary>
        [DataMember(Name="outputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }
        /// <summary>
        /// Gets or Sets LatLongOffset
        /// </summary>
        [DataMember(Name="latLongOffset", EmitDefaultValue=false)]
        public string LatLongOffset { get; set; }
        /// <summary>
        /// Gets or Sets Squeeze
        /// </summary>
        [DataMember(Name="squeeze", EmitDefaultValue=false)]
        public string Squeeze { get; set; }
        /// <summary>
        /// Gets or Sets ReturnLatLongFields
        /// </summary>
        [DataMember(Name="returnLatLongFields", EmitDefaultValue=false)]
        public string ReturnLatLongFields { get; set; }
        /// <summary>
        /// Gets or Sets UseGeoTaxAuxiliaryFile
        /// </summary>
        [DataMember(Name="useGeoTaxAuxiliaryFile", EmitDefaultValue=false)]
        public string UseGeoTaxAuxiliaryFile { get; set; }
        /// <summary>
        /// Gets or Sets LatLongFormat
        /// </summary>
        [DataMember(Name="latLongFormat", EmitDefaultValue=false)]
        public string LatLongFormat { get; set; }
        /// <summary>
        /// Gets or Sets DefaultBufferWidth
        /// </summary>
        [DataMember(Name="defaultBufferWidth", EmitDefaultValue=false)]
        public string DefaultBufferWidth { get; set; }
        /// <summary>
        /// Gets or Sets ReturnCensusFields
        /// </summary>
        [DataMember(Name="returnCensusFields", EmitDefaultValue=false)]
        public string ReturnCensusFields { get; set; }
        /// <summary>
        /// Gets or Sets TaxRatetypeID
        /// </summary>
        [DataMember(Name="taxRatetypeID", EmitDefaultValue=false)]
        public string TaxRatetypeID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Preferences {\n");
            sb.Append("  ReturnAllCandidateInfo: ").Append(ReturnAllCandidateInfo).Append("\n");
            sb.Append("  FallbackToGeographic: ").Append(FallbackToGeographic).Append("\n");
            sb.Append("  FallbackToPostal: ").Append(FallbackToPostal).Append("\n");
            sb.Append("  MaxReturnedCandidates: ").Append(MaxReturnedCandidates).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  StreetOffset: ").Append(StreetOffset).Append("\n");
            sb.Append("  CornerOffset: ").Append(CornerOffset).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
            sb.Append("  ClientCoordSysName: ").Append(ClientCoordSysName).Append("\n");
            sb.Append("  DistanceUnits: ").Append(DistanceUnits).Append("\n");
            sb.Append("  StreetOffsetUnits: ").Append(StreetOffsetUnits).Append("\n");
            sb.Append("  CornerOffsetUnits: ").Append(CornerOffsetUnits).Append("\n");
            sb.Append("  MustMatchFields: ").Append(MustMatchFields).Append("\n");
            sb.Append("  ReturnFieldsDescriptor: ").Append(ReturnFieldsDescriptor).Append("\n");
            sb.Append("  OutputRecordType: ").Append(OutputRecordType).Append("\n");
            sb.Append("  CustomPreferences: ").Append(CustomPreferences).Append("\n");
            sb.Append("  PreferredDictionaryOrders: ").Append(PreferredDictionaryOrders).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  LatLongOffset: ").Append(LatLongOffset).Append("\n");
            sb.Append("  Squeeze: ").Append(Squeeze).Append("\n");
            sb.Append("  ReturnLatLongFields: ").Append(ReturnLatLongFields).Append("\n");
            sb.Append("  UseGeoTaxAuxiliaryFile: ").Append(UseGeoTaxAuxiliaryFile).Append("\n");
            sb.Append("  LatLongFormat: ").Append(LatLongFormat).Append("\n");
            sb.Append("  DefaultBufferWidth: ").Append(DefaultBufferWidth).Append("\n");
            sb.Append("  ReturnCensusFields: ").Append(ReturnCensusFields).Append("\n");
            sb.Append("  TaxRatetypeID: ").Append(TaxRatetypeID).Append("\n");
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
            return this.Equals(obj as Preferences);
        }

        /// <summary>
        /// Returns true if Preferences instances are equal
        /// </summary>
        /// <param name="other">Instance of Preferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Preferences other)
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
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
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
                    this.DistanceUnits == other.DistanceUnits ||
                    this.DistanceUnits != null &&
                    this.DistanceUnits.Equals(other.DistanceUnits)
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
                    this.CustomPreferences.SequenceEqual(other.CustomPreferences)
                ) && 
                (
                    this.PreferredDictionaryOrders == other.PreferredDictionaryOrders ||
                    this.PreferredDictionaryOrders != null &&
                    this.PreferredDictionaryOrders.SequenceEqual(other.PreferredDictionaryOrders)
                ) && 
                (
                    this.OutputCasing == other.OutputCasing ||
                    this.OutputCasing != null &&
                    this.OutputCasing.Equals(other.OutputCasing)
                ) && 
                (
                    this.LatLongOffset == other.LatLongOffset ||
                    this.LatLongOffset != null &&
                    this.LatLongOffset.Equals(other.LatLongOffset)
                ) && 
                (
                    this.Squeeze == other.Squeeze ||
                    this.Squeeze != null &&
                    this.Squeeze.Equals(other.Squeeze)
                ) && 
                (
                    this.ReturnLatLongFields == other.ReturnLatLongFields ||
                    this.ReturnLatLongFields != null &&
                    this.ReturnLatLongFields.Equals(other.ReturnLatLongFields)
                ) && 
                (
                    this.UseGeoTaxAuxiliaryFile == other.UseGeoTaxAuxiliaryFile ||
                    this.UseGeoTaxAuxiliaryFile != null &&
                    this.UseGeoTaxAuxiliaryFile.Equals(other.UseGeoTaxAuxiliaryFile)
                ) && 
                (
                    this.LatLongFormat == other.LatLongFormat ||
                    this.LatLongFormat != null &&
                    this.LatLongFormat.Equals(other.LatLongFormat)
                ) && 
                (
                    this.DefaultBufferWidth == other.DefaultBufferWidth ||
                    this.DefaultBufferWidth != null &&
                    this.DefaultBufferWidth.Equals(other.DefaultBufferWidth)
                ) && 
                (
                    this.ReturnCensusFields == other.ReturnCensusFields ||
                    this.ReturnCensusFields != null &&
                    this.ReturnCensusFields.Equals(other.ReturnCensusFields)
                ) && 
                (
                    this.TaxRatetypeID == other.TaxRatetypeID ||
                    this.TaxRatetypeID != null &&
                    this.TaxRatetypeID.Equals(other.TaxRatetypeID)
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
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
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
                if (this.DistanceUnits != null)
                    hash = hash * 59 + this.DistanceUnits.GetHashCode();
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
                if (this.OutputCasing != null)
                    hash = hash * 59 + this.OutputCasing.GetHashCode();
                if (this.LatLongOffset != null)
                    hash = hash * 59 + this.LatLongOffset.GetHashCode();
                if (this.Squeeze != null)
                    hash = hash * 59 + this.Squeeze.GetHashCode();
                if (this.ReturnLatLongFields != null)
                    hash = hash * 59 + this.ReturnLatLongFields.GetHashCode();
                if (this.UseGeoTaxAuxiliaryFile != null)
                    hash = hash * 59 + this.UseGeoTaxAuxiliaryFile.GetHashCode();
                if (this.LatLongFormat != null)
                    hash = hash * 59 + this.LatLongFormat.GetHashCode();
                if (this.DefaultBufferWidth != null)
                    hash = hash * 59 + this.DefaultBufferWidth.GetHashCode();
                if (this.ReturnCensusFields != null)
                    hash = hash * 59 + this.ReturnCensusFields.GetHashCode();
                if (this.TaxRatetypeID != null)
                    hash = hash * 59 + this.TaxRatetypeID.GetHashCode();
                return hash;
            }
        }
    }

}
