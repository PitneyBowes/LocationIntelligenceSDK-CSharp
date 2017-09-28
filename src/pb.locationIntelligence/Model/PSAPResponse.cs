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
    /// PSAPResponse
    /// </summary>
    [DataContract]
    public partial class PSAPResponse :  IEquatable<PSAPResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PSAPResponse" /> class.
        /// </summary>
        /// <param name="FccId">FccId.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Count">Count.</param>
        /// <param name="Agency">Agency.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="County">County.</param>
        /// <param name="Coverage">Coverage.</param>
        /// <param name="ContactPerson">ContactPerson.</param>
        /// <param name="SiteDetails">SiteDetails.</param>
        /// <param name="MailingAddress">MailingAddress.</param>
        public PSAPResponse(string FccId = null, string Type = null, int? Count = null, string Agency = null, string Phone = null, County County = null, Coverage Coverage = null, ContactPerson ContactPerson = null, SiteDetails SiteDetails = null, Address MailingAddress = null)
        {
            this.FccId = FccId;
            this.Type = Type;
            this.Count = Count;
            this.Agency = Agency;
            this.Phone = Phone;
            this.County = County;
            this.Coverage = Coverage;
            this.ContactPerson = ContactPerson;
            this.SiteDetails = SiteDetails;
            this.MailingAddress = MailingAddress;
        }
        
        /// <summary>
        /// Gets or Sets FccId
        /// </summary>
        [DataMember(Name="fccId", EmitDefaultValue=false)]
        public string FccId { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Gets or Sets Agency
        /// </summary>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public string Agency { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public County County { get; set; }
        /// <summary>
        /// Gets or Sets Coverage
        /// </summary>
        [DataMember(Name="coverage", EmitDefaultValue=false)]
        public Coverage Coverage { get; set; }
        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name="contactPerson", EmitDefaultValue=false)]
        public ContactPerson ContactPerson { get; set; }
        /// <summary>
        /// Gets or Sets SiteDetails
        /// </summary>
        [DataMember(Name="siteDetails", EmitDefaultValue=false)]
        public SiteDetails SiteDetails { get; set; }
        /// <summary>
        /// Gets or Sets MailingAddress
        /// </summary>
        [DataMember(Name="mailingAddress", EmitDefaultValue=false)]
        public Address MailingAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PSAPResponse {\n");
            sb.Append("  FccId: ").Append(FccId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  SiteDetails: ").Append(SiteDetails).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
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
            return this.Equals(obj as PSAPResponse);
        }

        /// <summary>
        /// Returns true if PSAPResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PSAPResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PSAPResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FccId == other.FccId ||
                    this.FccId != null &&
                    this.FccId.Equals(other.FccId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Agency == other.Agency ||
                    this.Agency != null &&
                    this.Agency.Equals(other.Agency)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.Coverage == other.Coverage ||
                    this.Coverage != null &&
                    this.Coverage.Equals(other.Coverage)
                ) && 
                (
                    this.ContactPerson == other.ContactPerson ||
                    this.ContactPerson != null &&
                    this.ContactPerson.Equals(other.ContactPerson)
                ) && 
                (
                    this.SiteDetails == other.SiteDetails ||
                    this.SiteDetails != null &&
                    this.SiteDetails.Equals(other.SiteDetails)
                ) && 
                (
                    this.MailingAddress == other.MailingAddress ||
                    this.MailingAddress != null &&
                    this.MailingAddress.Equals(other.MailingAddress)
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
                if (this.FccId != null)
                    hash = hash * 59 + this.FccId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Agency != null)
                    hash = hash * 59 + this.Agency.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.Coverage != null)
                    hash = hash * 59 + this.Coverage.GetHashCode();
                if (this.ContactPerson != null)
                    hash = hash * 59 + this.ContactPerson.GetHashCode();
                if (this.SiteDetails != null)
                    hash = hash * 59 + this.SiteDetails.GetHashCode();
                if (this.MailingAddress != null)
                    hash = hash * 59 + this.MailingAddress.GetHashCode();
                return hash;
            }
        }
    }

}
