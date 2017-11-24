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
    /// AccountMinimumPasswordLength
    /// </summary>
    [DataContract]
    public partial class AccountMinimumPasswordLength :  IEquatable<AccountMinimumPasswordLength>, IValidatableObject
    {
        public AccountMinimumPasswordLength()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountMinimumPasswordLength" /> class.
        /// </summary>
        /// <param name="MaximumLength">.</param>
        /// <param name="MinimumLength">.</param>
        public AccountMinimumPasswordLength(string MaximumLength = default(string), string MinimumLength = default(string))
        {
            this.MaximumLength = MaximumLength;
            this.MinimumLength = MinimumLength;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="maximumLength", EmitDefaultValue=false)]
        public string MaximumLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="minimumLength", EmitDefaultValue=false)]
        public string MinimumLength { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountMinimumPasswordLength {\n");
            sb.Append("  MaximumLength: ").Append(MaximumLength).Append("\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
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
            return this.Equals(obj as AccountMinimumPasswordLength);
        }

        /// <summary>
        /// Returns true if AccountMinimumPasswordLength instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountMinimumPasswordLength to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountMinimumPasswordLength other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaximumLength == other.MaximumLength ||
                    this.MaximumLength != null &&
                    this.MaximumLength.Equals(other.MaximumLength)
                ) && 
                (
                    this.MinimumLength == other.MinimumLength ||
                    this.MinimumLength != null &&
                    this.MinimumLength.Equals(other.MinimumLength)
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
                if (this.MaximumLength != null)
                    hash = hash * 59 + this.MaximumLength.GetHashCode();
                if (this.MinimumLength != null)
                    hash = hash * 59 + this.MinimumLength.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
