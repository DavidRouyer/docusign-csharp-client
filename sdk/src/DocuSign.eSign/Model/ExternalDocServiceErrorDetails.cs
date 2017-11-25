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
    /// ExternalDocServiceErrorDetails
    /// </summary>
    [DataContract]
    public partial class ExternalDocServiceErrorDetails :  IEquatable<ExternalDocServiceErrorDetails>, IValidatableObject
    {
        public ExternalDocServiceErrorDetails()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDocServiceErrorDetails" /> class.
        /// </summary>
        /// <param name="AuthenticationUrl">Reserved: TBD.</param>
        /// <param name="ErrorCode">.</param>
        /// <param name="Message">.</param>
        public ExternalDocServiceErrorDetails(string AuthenticationUrl = default(string), string ErrorCode = default(string), string Message = default(string))
        {
            this.AuthenticationUrl = AuthenticationUrl;
            this.ErrorCode = ErrorCode;
            this.Message = Message;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="authenticationUrl", EmitDefaultValue=false)]
        public string AuthenticationUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalDocServiceErrorDetails {\n");
            sb.Append("  AuthenticationUrl: ").Append(AuthenticationUrl).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as ExternalDocServiceErrorDetails);
        }

        /// <summary>
        /// Returns true if ExternalDocServiceErrorDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalDocServiceErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalDocServiceErrorDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationUrl == other.AuthenticationUrl ||
                    this.AuthenticationUrl != null &&
                    this.AuthenticationUrl.Equals(other.AuthenticationUrl)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.AuthenticationUrl != null)
                    hash = hash * 59 + this.AuthenticationUrl.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}