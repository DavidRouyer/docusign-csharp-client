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
    /// Ssn9InformationInput
    /// </summary>
    [DataContract]
    public partial class Ssn9InformationInput :  IEquatable<Ssn9InformationInput>, IValidatableObject
    {
        public Ssn9InformationInput()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ssn9InformationInput" /> class.
        /// </summary>
        /// <param name="DisplayLevelCode">Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay.</param>
        /// <param name="Ssn9"> The recipient&#39;s Social Security Number(SSN)..</param>
        public Ssn9InformationInput(string DisplayLevelCode = default(string), string Ssn9 = default(string))
        {
            this.DisplayLevelCode = DisplayLevelCode;
            this.Ssn9 = Ssn9;
        }
        
        /// <summary>
        /// Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay
        /// </summary>
        /// <value>Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay</value>
        [DataMember(Name="displayLevelCode", EmitDefaultValue=false)]
        public string DisplayLevelCode { get; set; }
        /// <summary>
        ///  The recipient&#39;s Social Security Number(SSN).
        /// </summary>
        /// <value> The recipient&#39;s Social Security Number(SSN).</value>
        [DataMember(Name="ssn9", EmitDefaultValue=false)]
        public string Ssn9 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ssn9InformationInput {\n");
            sb.Append("  DisplayLevelCode: ").Append(DisplayLevelCode).Append("\n");
            sb.Append("  Ssn9: ").Append(Ssn9).Append("\n");
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
            return this.Equals(obj as Ssn9InformationInput);
        }

        /// <summary>
        /// Returns true if Ssn9InformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of Ssn9InformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ssn9InformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayLevelCode == other.DisplayLevelCode ||
                    this.DisplayLevelCode != null &&
                    this.DisplayLevelCode.Equals(other.DisplayLevelCode)
                ) && 
                (
                    this.Ssn9 == other.Ssn9 ||
                    this.Ssn9 != null &&
                    this.Ssn9.Equals(other.Ssn9)
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
                if (this.DisplayLevelCode != null)
                    hash = hash * 59 + this.DisplayLevelCode.GetHashCode();
                if (this.Ssn9 != null)
                    hash = hash * 59 + this.Ssn9.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
