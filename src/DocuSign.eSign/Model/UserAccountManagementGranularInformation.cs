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
    /// UserAccountManagementGranularInformation
    /// </summary>
    [DataContract]
    public partial class UserAccountManagementGranularInformation :  IEquatable<UserAccountManagementGranularInformation>, IValidatableObject
    {
        public UserAccountManagementGranularInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountManagementGranularInformation" /> class.
        /// </summary>
        /// <param name="CanManageAdmins">.</param>
        /// <param name="CanManageAdminsMetadata">CanManageAdminsMetadata.</param>
        /// <param name="CanManageGroups">.</param>
        /// <param name="CanManageGroupsMetadata">CanManageGroupsMetadata.</param>
        /// <param name="CanManageSharing">.</param>
        /// <param name="CanManageSharingMetadata">CanManageSharingMetadata.</param>
        /// <param name="CanManageUsers">.</param>
        /// <param name="CanManageUsersMetadata">CanManageUsersMetadata.</param>
        public UserAccountManagementGranularInformation(string CanManageAdmins = default(string), SettingsMetadata CanManageAdminsMetadata = default(SettingsMetadata), string CanManageGroups = default(string), SettingsMetadata CanManageGroupsMetadata = default(SettingsMetadata), string CanManageSharing = default(string), SettingsMetadata CanManageSharingMetadata = default(SettingsMetadata), string CanManageUsers = default(string), SettingsMetadata CanManageUsersMetadata = default(SettingsMetadata))
        {
            this.CanManageAdmins = CanManageAdmins;
            this.CanManageAdminsMetadata = CanManageAdminsMetadata;
            this.CanManageGroups = CanManageGroups;
            this.CanManageGroupsMetadata = CanManageGroupsMetadata;
            this.CanManageSharing = CanManageSharing;
            this.CanManageSharingMetadata = CanManageSharingMetadata;
            this.CanManageUsers = CanManageUsers;
            this.CanManageUsersMetadata = CanManageUsersMetadata;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageAdmins", EmitDefaultValue=false)]
        public string CanManageAdmins { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAdminsMetadata
        /// </summary>
        [DataMember(Name="canManageAdminsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAdminsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageGroups", EmitDefaultValue=false)]
        public string CanManageGroups { get; set; }
        /// <summary>
        /// Gets or Sets CanManageGroupsMetadata
        /// </summary>
        [DataMember(Name="canManageGroupsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageGroupsMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageSharing", EmitDefaultValue=false)]
        public string CanManageSharing { get; set; }
        /// <summary>
        /// Gets or Sets CanManageSharingMetadata
        /// </summary>
        [DataMember(Name="canManageSharingMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageSharingMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canManageUsers", EmitDefaultValue=false)]
        public string CanManageUsers { get; set; }
        /// <summary>
        /// Gets or Sets CanManageUsersMetadata
        /// </summary>
        [DataMember(Name="canManageUsersMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageUsersMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountManagementGranularInformation {\n");
            sb.Append("  CanManageAdmins: ").Append(CanManageAdmins).Append("\n");
            sb.Append("  CanManageAdminsMetadata: ").Append(CanManageAdminsMetadata).Append("\n");
            sb.Append("  CanManageGroups: ").Append(CanManageGroups).Append("\n");
            sb.Append("  CanManageGroupsMetadata: ").Append(CanManageGroupsMetadata).Append("\n");
            sb.Append("  CanManageSharing: ").Append(CanManageSharing).Append("\n");
            sb.Append("  CanManageSharingMetadata: ").Append(CanManageSharingMetadata).Append("\n");
            sb.Append("  CanManageUsers: ").Append(CanManageUsers).Append("\n");
            sb.Append("  CanManageUsersMetadata: ").Append(CanManageUsersMetadata).Append("\n");
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
            return this.Equals(obj as UserAccountManagementGranularInformation);
        }

        /// <summary>
        /// Returns true if UserAccountManagementGranularInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountManagementGranularInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountManagementGranularInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CanManageAdmins == other.CanManageAdmins ||
                    this.CanManageAdmins != null &&
                    this.CanManageAdmins.Equals(other.CanManageAdmins)
                ) && 
                (
                    this.CanManageAdminsMetadata == other.CanManageAdminsMetadata ||
                    this.CanManageAdminsMetadata != null &&
                    this.CanManageAdminsMetadata.Equals(other.CanManageAdminsMetadata)
                ) && 
                (
                    this.CanManageGroups == other.CanManageGroups ||
                    this.CanManageGroups != null &&
                    this.CanManageGroups.Equals(other.CanManageGroups)
                ) && 
                (
                    this.CanManageGroupsMetadata == other.CanManageGroupsMetadata ||
                    this.CanManageGroupsMetadata != null &&
                    this.CanManageGroupsMetadata.Equals(other.CanManageGroupsMetadata)
                ) && 
                (
                    this.CanManageSharing == other.CanManageSharing ||
                    this.CanManageSharing != null &&
                    this.CanManageSharing.Equals(other.CanManageSharing)
                ) && 
                (
                    this.CanManageSharingMetadata == other.CanManageSharingMetadata ||
                    this.CanManageSharingMetadata != null &&
                    this.CanManageSharingMetadata.Equals(other.CanManageSharingMetadata)
                ) && 
                (
                    this.CanManageUsers == other.CanManageUsers ||
                    this.CanManageUsers != null &&
                    this.CanManageUsers.Equals(other.CanManageUsers)
                ) && 
                (
                    this.CanManageUsersMetadata == other.CanManageUsersMetadata ||
                    this.CanManageUsersMetadata != null &&
                    this.CanManageUsersMetadata.Equals(other.CanManageUsersMetadata)
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
                if (this.CanManageAdmins != null)
                    hash = hash * 59 + this.CanManageAdmins.GetHashCode();
                if (this.CanManageAdminsMetadata != null)
                    hash = hash * 59 + this.CanManageAdminsMetadata.GetHashCode();
                if (this.CanManageGroups != null)
                    hash = hash * 59 + this.CanManageGroups.GetHashCode();
                if (this.CanManageGroupsMetadata != null)
                    hash = hash * 59 + this.CanManageGroupsMetadata.GetHashCode();
                if (this.CanManageSharing != null)
                    hash = hash * 59 + this.CanManageSharing.GetHashCode();
                if (this.CanManageSharingMetadata != null)
                    hash = hash * 59 + this.CanManageSharingMetadata.GetHashCode();
                if (this.CanManageUsers != null)
                    hash = hash * 59 + this.CanManageUsers.GetHashCode();
                if (this.CanManageUsersMetadata != null)
                    hash = hash * 59 + this.CanManageUsersMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
