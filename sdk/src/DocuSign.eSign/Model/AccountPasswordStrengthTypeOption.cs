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
    /// AccountPasswordStrengthTypeOption
    /// </summary>
    [DataContract]
    public partial class AccountPasswordStrengthTypeOption :  IEquatable<AccountPasswordStrengthTypeOption>, IValidatableObject
    {
        public AccountPasswordStrengthTypeOption()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPasswordStrengthTypeOption" /> class.
        /// </summary>
        /// <param name="MinimumLength">.</param>
        /// <param name="Name">.</param>
        /// <param name="PasswordIncludeDigit">.</param>
        /// <param name="PasswordIncludeDigitOrSpecialCharacter">.</param>
        /// <param name="PasswordIncludeLowerCase">.</param>
        /// <param name="PasswordIncludeSpecialCharacter">.</param>
        /// <param name="PasswordIncludeUpperCase">.</param>
        public AccountPasswordStrengthTypeOption(string MinimumLength = default(string), string Name = default(string), string PasswordIncludeDigit = default(string), string PasswordIncludeDigitOrSpecialCharacter = default(string), string PasswordIncludeLowerCase = default(string), string PasswordIncludeSpecialCharacter = default(string), string PasswordIncludeUpperCase = default(string))
        {
            this.MinimumLength = MinimumLength;
            this.Name = Name;
            this.PasswordIncludeDigit = PasswordIncludeDigit;
            this.PasswordIncludeDigitOrSpecialCharacter = PasswordIncludeDigitOrSpecialCharacter;
            this.PasswordIncludeLowerCase = PasswordIncludeLowerCase;
            this.PasswordIncludeSpecialCharacter = PasswordIncludeSpecialCharacter;
            this.PasswordIncludeUpperCase = PasswordIncludeUpperCase;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="minimumLength", EmitDefaultValue=false)]
        public string MinimumLength { get; set; }
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
        [DataMember(Name="passwordIncludeDigit", EmitDefaultValue=false)]
        public string PasswordIncludeDigit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="passwordIncludeDigitOrSpecialCharacter", EmitDefaultValue=false)]
        public string PasswordIncludeDigitOrSpecialCharacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="passwordIncludeLowerCase", EmitDefaultValue=false)]
        public string PasswordIncludeLowerCase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="passwordIncludeSpecialCharacter", EmitDefaultValue=false)]
        public string PasswordIncludeSpecialCharacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="passwordIncludeUpperCase", EmitDefaultValue=false)]
        public string PasswordIncludeUpperCase { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPasswordStrengthTypeOption {\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PasswordIncludeDigit: ").Append(PasswordIncludeDigit).Append("\n");
            sb.Append("  PasswordIncludeDigitOrSpecialCharacter: ").Append(PasswordIncludeDigitOrSpecialCharacter).Append("\n");
            sb.Append("  PasswordIncludeLowerCase: ").Append(PasswordIncludeLowerCase).Append("\n");
            sb.Append("  PasswordIncludeSpecialCharacter: ").Append(PasswordIncludeSpecialCharacter).Append("\n");
            sb.Append("  PasswordIncludeUpperCase: ").Append(PasswordIncludeUpperCase).Append("\n");
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
            return this.Equals(obj as AccountPasswordStrengthTypeOption);
        }

        /// <summary>
        /// Returns true if AccountPasswordStrengthTypeOption instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPasswordStrengthTypeOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPasswordStrengthTypeOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinimumLength == other.MinimumLength ||
                    this.MinimumLength != null &&
                    this.MinimumLength.Equals(other.MinimumLength)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PasswordIncludeDigit == other.PasswordIncludeDigit ||
                    this.PasswordIncludeDigit != null &&
                    this.PasswordIncludeDigit.Equals(other.PasswordIncludeDigit)
                ) && 
                (
                    this.PasswordIncludeDigitOrSpecialCharacter == other.PasswordIncludeDigitOrSpecialCharacter ||
                    this.PasswordIncludeDigitOrSpecialCharacter != null &&
                    this.PasswordIncludeDigitOrSpecialCharacter.Equals(other.PasswordIncludeDigitOrSpecialCharacter)
                ) && 
                (
                    this.PasswordIncludeLowerCase == other.PasswordIncludeLowerCase ||
                    this.PasswordIncludeLowerCase != null &&
                    this.PasswordIncludeLowerCase.Equals(other.PasswordIncludeLowerCase)
                ) && 
                (
                    this.PasswordIncludeSpecialCharacter == other.PasswordIncludeSpecialCharacter ||
                    this.PasswordIncludeSpecialCharacter != null &&
                    this.PasswordIncludeSpecialCharacter.Equals(other.PasswordIncludeSpecialCharacter)
                ) && 
                (
                    this.PasswordIncludeUpperCase == other.PasswordIncludeUpperCase ||
                    this.PasswordIncludeUpperCase != null &&
                    this.PasswordIncludeUpperCase.Equals(other.PasswordIncludeUpperCase)
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
                if (this.MinimumLength != null)
                    hash = hash * 59 + this.MinimumLength.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PasswordIncludeDigit != null)
                    hash = hash * 59 + this.PasswordIncludeDigit.GetHashCode();
                if (this.PasswordIncludeDigitOrSpecialCharacter != null)
                    hash = hash * 59 + this.PasswordIncludeDigitOrSpecialCharacter.GetHashCode();
                if (this.PasswordIncludeLowerCase != null)
                    hash = hash * 59 + this.PasswordIncludeLowerCase.GetHashCode();
                if (this.PasswordIncludeSpecialCharacter != null)
                    hash = hash * 59 + this.PasswordIncludeSpecialCharacter.GetHashCode();
                if (this.PasswordIncludeUpperCase != null)
                    hash = hash * 59 + this.PasswordIncludeUpperCase.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
