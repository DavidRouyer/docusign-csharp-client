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
    /// Contains account settings information.
    /// </summary>
    [DataContract]
    public partial class AccountSettingsInformation :  IEquatable<AccountSettingsInformation>, IValidatableObject
    {
        public AccountSettingsInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSettingsInformation" /> class.
        /// </summary>
        /// <param name="AccountSettings">The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden..</param>
        public AccountSettingsInformation(List<NameValue> AccountSettings = default(List<NameValue>))
        {
            this.AccountSettings = AccountSettings;
        }
        
        /// <summary>
        /// The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.
        /// </summary>
        /// <value>The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.</value>
        [DataMember(Name="accountSettings", EmitDefaultValue=false)]
        public List<NameValue> AccountSettings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSettingsInformation {\n");
            sb.Append("  AccountSettings: ").Append(AccountSettings).Append("\n");
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
            return this.Equals(obj as AccountSettingsInformation);
        }

        /// <summary>
        /// Returns true if AccountSettingsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSettingsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSettingsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountSettings == other.AccountSettings ||
                    this.AccountSettings != null &&
                    this.AccountSettings.SequenceEqual(other.AccountSettings)
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
                if (this.AccountSettings != null)
                    hash = hash * 59 + this.AccountSettings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
