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
    /// NewUsersDefinition
    /// </summary>
    [DataContract]
    public partial class NewUsersDefinition :  IEquatable<NewUsersDefinition>, IValidatableObject
    {
        public NewUsersDefinition()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUsersDefinition" /> class.
        /// </summary>
        /// <param name="NewUsers">.</param>
        public NewUsersDefinition(List<UserInformation> NewUsers = default(List<UserInformation>))
        {
            this.NewUsers = NewUsers;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="newUsers", EmitDefaultValue=false)]
        public List<UserInformation> NewUsers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUsersDefinition {\n");
            sb.Append("  NewUsers: ").Append(NewUsers).Append("\n");
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
            return this.Equals(obj as NewUsersDefinition);
        }

        /// <summary>
        /// Returns true if NewUsersDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of NewUsersDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUsersDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NewUsers == other.NewUsers ||
                    this.NewUsers != null &&
                    this.NewUsers.SequenceEqual(other.NewUsers)
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
                if (this.NewUsers != null)
                    hash = hash * 59 + this.NewUsers.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
