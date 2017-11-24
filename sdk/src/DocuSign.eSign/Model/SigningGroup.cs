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
    /// SigningGroup
    /// </summary>
    [DataContract]
    public partial class SigningGroup :  IEquatable<SigningGroup>, IValidatableObject
    {
        public SigningGroup()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigningGroup" /> class.
        /// </summary>
        /// <param name="Created">.</param>
        /// <param name="CreatedBy">.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="GroupEmail">.</param>
        /// <param name="GroupName">The name of the group..</param>
        /// <param name="GroupType">.</param>
        /// <param name="Modified">.</param>
        /// <param name="ModifiedBy">.</param>
        /// <param name="SigningGroupId">When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once)..</param>
        /// <param name="Users">.</param>
        public SigningGroup(string Created = default(string), string CreatedBy = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string GroupEmail = default(string), string GroupName = default(string), string GroupType = default(string), string Modified = default(string), string ModifiedBy = default(string), string SigningGroupId = default(string), List<SigningGroupUser> Users = default(List<SigningGroupUser>))
        {
            this.Created = Created;
            this.CreatedBy = CreatedBy;
            this.ErrorDetails = ErrorDetails;
            this.GroupEmail = GroupEmail;
            this.GroupName = GroupName;
            this.GroupType = GroupType;
            this.Modified = Modified;
            this.ModifiedBy = ModifiedBy;
            this.SigningGroupId = SigningGroupId;
            this.Users = Users;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="groupEmail", EmitDefaultValue=false)]
        public string GroupEmail { get; set; }
        /// <summary>
        /// The name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public string GroupType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public string Modified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).
        /// </summary>
        /// <value>When set to **true** and the feature is enabled in the sender&#39;s account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).</value>
        [DataMember(Name="signingGroupId", EmitDefaultValue=false)]
        public string SigningGroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<SigningGroupUser> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningGroup {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  GroupEmail: ").Append(GroupEmail).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  SigningGroupId: ").Append(SigningGroupId).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as SigningGroup);
        }

        /// <summary>
        /// Returns true if SigningGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of SigningGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.GroupEmail == other.GroupEmail ||
                    this.GroupEmail != null &&
                    this.GroupEmail.Equals(other.GroupEmail)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
                ) && 
                (
                    this.GroupType == other.GroupType ||
                    this.GroupType != null &&
                    this.GroupType.Equals(other.GroupType)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) && 
                (
                    this.SigningGroupId == other.SigningGroupId ||
                    this.SigningGroupId != null &&
                    this.SigningGroupId.Equals(other.SigningGroupId)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.GroupEmail != null)
                    hash = hash * 59 + this.GroupEmail.GetHashCode();
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
                if (this.GroupType != null)
                    hash = hash * 59 + this.GroupType.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.SigningGroupId != null)
                    hash = hash * 59 + this.SigningGroupId.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
