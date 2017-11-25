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
    /// Seal
    /// </summary>
    [DataContract]
    public partial class Seal :  IEquatable<Seal>, IValidatableObject
    {
        public Seal()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seal" /> class.
        /// </summary>
        /// <param name="Configuration">.</param>
        /// <param name="SealIdentifier">.</param>
        public Seal(Dictionary<string, string> Configuration = default(Dictionary<string, string>), string SealIdentifier = default(string))
        {
            this.Configuration = Configuration;
            this.SealIdentifier = SealIdentifier;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Dictionary<string, string> Configuration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sealIdentifier", EmitDefaultValue=false)]
        public string SealIdentifier { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Seal {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  SealIdentifier: ").Append(SealIdentifier).Append("\n");
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
            return this.Equals(obj as Seal);
        }

        /// <summary>
        /// Returns true if Seal instances are equal
        /// </summary>
        /// <param name="other">Instance of Seal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Seal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.SequenceEqual(other.Configuration)
                ) && 
                (
                    this.SealIdentifier == other.SealIdentifier ||
                    this.SealIdentifier != null &&
                    this.SealIdentifier.Equals(other.SealIdentifier)
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
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
                if (this.SealIdentifier != null)
                    hash = hash * 59 + this.SealIdentifier.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}