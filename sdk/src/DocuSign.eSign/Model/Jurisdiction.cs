/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Jurisdiction
    /// </summary>
    [DataContract]
    public partial class Jurisdiction :  IEquatable<Jurisdiction>, IValidatableObject
    {
        public Jurisdiction()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Jurisdiction" /> class.
        /// </summary>
        /// <param name="CommissionIdInSeal">.</param>
        /// <param name="County">.</param>
        /// <param name="CountyInSeal">.</param>
        /// <param name="Enabled">.</param>
        /// <param name="JurisdictionId">.</param>
        /// <param name="Name">.</param>
        /// <param name="NotaryPublicInSeal">.</param>
        /// <param name="StateNameInSeal">.</param>
        public Jurisdiction(string CommissionIdInSeal = default(string), string County = default(string), string CountyInSeal = default(string), string Enabled = default(string), string JurisdictionId = default(string), string Name = default(string), string NotaryPublicInSeal = default(string), string StateNameInSeal = default(string))
        {
            this.CommissionIdInSeal = CommissionIdInSeal;
            this.County = County;
            this.CountyInSeal = CountyInSeal;
            this.Enabled = Enabled;
            this.JurisdictionId = JurisdictionId;
            this.Name = Name;
            this.NotaryPublicInSeal = NotaryPublicInSeal;
            this.StateNameInSeal = StateNameInSeal;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commissionIdInSeal", EmitDefaultValue=false)]
        public string CommissionIdInSeal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="countyInSeal", EmitDefaultValue=false)]
        public string CountyInSeal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public string Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="jurisdictionId", EmitDefaultValue=false)]
        public string JurisdictionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="notaryPublicInSeal", EmitDefaultValue=false)]
        public string NotaryPublicInSeal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="stateNameInSeal", EmitDefaultValue=false)]
        public string StateNameInSeal { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Jurisdiction {\n");
            sb.Append("  CommissionIdInSeal: ").Append(CommissionIdInSeal).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  CountyInSeal: ").Append(CountyInSeal).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  JurisdictionId: ").Append(JurisdictionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NotaryPublicInSeal: ").Append(NotaryPublicInSeal).Append("\n");
            sb.Append("  StateNameInSeal: ").Append(StateNameInSeal).Append("\n");
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
            return this.Equals(obj as Jurisdiction);
        }

        /// <summary>
        /// Returns true if Jurisdiction instances are equal
        /// </summary>
        /// <param name="other">Instance of Jurisdiction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Jurisdiction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommissionIdInSeal == other.CommissionIdInSeal ||
                    this.CommissionIdInSeal != null &&
                    this.CommissionIdInSeal.Equals(other.CommissionIdInSeal)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.CountyInSeal == other.CountyInSeal ||
                    this.CountyInSeal != null &&
                    this.CountyInSeal.Equals(other.CountyInSeal)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.JurisdictionId == other.JurisdictionId ||
                    this.JurisdictionId != null &&
                    this.JurisdictionId.Equals(other.JurisdictionId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NotaryPublicInSeal == other.NotaryPublicInSeal ||
                    this.NotaryPublicInSeal != null &&
                    this.NotaryPublicInSeal.Equals(other.NotaryPublicInSeal)
                ) && 
                (
                    this.StateNameInSeal == other.StateNameInSeal ||
                    this.StateNameInSeal != null &&
                    this.StateNameInSeal.Equals(other.StateNameInSeal)
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
                if (this.CommissionIdInSeal != null)
                    hash = hash * 59 + this.CommissionIdInSeal.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.CountyInSeal != null)
                    hash = hash * 59 + this.CountyInSeal.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.JurisdictionId != null)
                    hash = hash * 59 + this.JurisdictionId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NotaryPublicInSeal != null)
                    hash = hash * 59 + this.NotaryPublicInSeal.GetHashCode();
                if (this.StateNameInSeal != null)
                    hash = hash * 59 + this.StateNameInSeal.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
