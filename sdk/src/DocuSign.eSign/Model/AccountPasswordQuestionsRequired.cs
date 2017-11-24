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
    /// AccountPasswordQuestionsRequired
    /// </summary>
    [DataContract]
    public partial class AccountPasswordQuestionsRequired :  IEquatable<AccountPasswordQuestionsRequired>, IValidatableObject
    {
        public AccountPasswordQuestionsRequired()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPasswordQuestionsRequired" /> class.
        /// </summary>
        /// <param name="MaximumQuestions">.</param>
        /// <param name="MinimumQuestions">.</param>
        public AccountPasswordQuestionsRequired(string MaximumQuestions = default(string), string MinimumQuestions = default(string))
        {
            this.MaximumQuestions = MaximumQuestions;
            this.MinimumQuestions = MinimumQuestions;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="maximumQuestions", EmitDefaultValue=false)]
        public string MaximumQuestions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="minimumQuestions", EmitDefaultValue=false)]
        public string MinimumQuestions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPasswordQuestionsRequired {\n");
            sb.Append("  MaximumQuestions: ").Append(MaximumQuestions).Append("\n");
            sb.Append("  MinimumQuestions: ").Append(MinimumQuestions).Append("\n");
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
            return this.Equals(obj as AccountPasswordQuestionsRequired);
        }

        /// <summary>
        /// Returns true if AccountPasswordQuestionsRequired instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPasswordQuestionsRequired to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPasswordQuestionsRequired other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaximumQuestions == other.MaximumQuestions ||
                    this.MaximumQuestions != null &&
                    this.MaximumQuestions.Equals(other.MaximumQuestions)
                ) && 
                (
                    this.MinimumQuestions == other.MinimumQuestions ||
                    this.MinimumQuestions != null &&
                    this.MinimumQuestions.Equals(other.MinimumQuestions)
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
                if (this.MaximumQuestions != null)
                    hash = hash * 59 + this.MaximumQuestions.GetHashCode();
                if (this.MinimumQuestions != null)
                    hash = hash * 59 + this.MinimumQuestions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
