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
    /// RecipientSignatureProviderOptions
    /// </summary>
    [DataContract]
    public partial class RecipientSignatureProviderOptions :  IEquatable<RecipientSignatureProviderOptions>, IValidatableObject
    {
        public RecipientSignatureProviderOptions()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientSignatureProviderOptions" /> class.
        /// </summary>
        /// <param name="CpfNumber">.</param>
        /// <param name="OneTimePassword">.</param>
        /// <param name="SignerRole">.</param>
        /// <param name="Sms">.</param>
        public RecipientSignatureProviderOptions(string CpfNumber = default(string), string OneTimePassword = default(string), string SignerRole = default(string), string Sms = default(string))
        {
            this.CpfNumber = CpfNumber;
            this.OneTimePassword = OneTimePassword;
            this.SignerRole = SignerRole;
            this.Sms = Sms;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="cpfNumber", EmitDefaultValue=false)]
        public string CpfNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="oneTimePassword", EmitDefaultValue=false)]
        public string OneTimePassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signerRole", EmitDefaultValue=false)]
        public string SignerRole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public string Sms { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSignatureProviderOptions {\n");
            sb.Append("  CpfNumber: ").Append(CpfNumber).Append("\n");
            sb.Append("  OneTimePassword: ").Append(OneTimePassword).Append("\n");
            sb.Append("  SignerRole: ").Append(SignerRole).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
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
            return this.Equals(obj as RecipientSignatureProviderOptions);
        }

        /// <summary>
        /// Returns true if RecipientSignatureProviderOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSignatureProviderOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSignatureProviderOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CpfNumber == other.CpfNumber ||
                    this.CpfNumber != null &&
                    this.CpfNumber.Equals(other.CpfNumber)
                ) && 
                (
                    this.OneTimePassword == other.OneTimePassword ||
                    this.OneTimePassword != null &&
                    this.OneTimePassword.Equals(other.OneTimePassword)
                ) && 
                (
                    this.SignerRole == other.SignerRole ||
                    this.SignerRole != null &&
                    this.SignerRole.Equals(other.SignerRole)
                ) && 
                (
                    this.Sms == other.Sms ||
                    this.Sms != null &&
                    this.Sms.Equals(other.Sms)
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
                if (this.CpfNumber != null)
                    hash = hash * 59 + this.CpfNumber.GetHashCode();
                if (this.OneTimePassword != null)
                    hash = hash * 59 + this.OneTimePassword.GetHashCode();
                if (this.SignerRole != null)
                    hash = hash * 59 + this.SignerRole.GetHashCode();
                if (this.Sms != null)
                    hash = hash * 59 + this.Sms.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}