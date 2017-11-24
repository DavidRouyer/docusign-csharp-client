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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// PropertyMetadata
    /// </summary>
    [DataContract]
    public partial class PropertyMetadata :  IEquatable<PropertyMetadata>, IValidatableObject
    {
        public PropertyMetadata()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyMetadata" /> class.
        /// </summary>
        /// <param name="Options">.</param>
        /// <param name="Rights">.</param>
        public PropertyMetadata(List<string> Options = default(List<string>), string Rights = default(string))
        {
            this.Options = Options;
            this.Rights = Rights;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="rights", EmitDefaultValue=false)]
        public string Rights { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyMetadata {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Rights: ").Append(Rights).Append("\n");
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
            return this.Equals(obj as PropertyMetadata);
        }

        /// <summary>
        /// Returns true if PropertyMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                ) && 
                (
                    this.Rights == other.Rights ||
                    this.Rights != null &&
                    this.Rights.Equals(other.Rights)
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
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.Rights != null)
                    hash = hash * 59 + this.Rights.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
