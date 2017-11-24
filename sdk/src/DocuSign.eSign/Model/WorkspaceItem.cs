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
    /// A workspaceItem (file type only) representing the file. This property is only returned in response to file specific GET call.
    /// </summary>
    [DataContract]
    public partial class WorkspaceItem :  IEquatable<WorkspaceItem>, IValidatableObject
    {
        public WorkspaceItem()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceItem" /> class.
        /// </summary>
        /// <param name="CallerAuthorization">CallerAuthorization.</param>
        /// <param name="ContentType">.</param>
        /// <param name="Created">The UTC DateTime when the workspace item was created..</param>
        /// <param name="CreatedById">.</param>
        /// <param name="CreatedByInformation">CreatedByInformation.</param>
        /// <param name="Extension">.</param>
        /// <param name="FileSize">.</param>
        /// <param name="FileUri">.</param>
        /// <param name="Id">.</param>
        /// <param name="IsPublic"> If true, this supersedes need for bit mask permission with workspaceUserAuthorization.</param>
        /// <param name="LastModified">.</param>
        /// <param name="LastModifiedById">Utc date and time the comment was last updated (can only be done by creator).</param>
        /// <param name="LastModifiedByInformation">LastModifiedByInformation.</param>
        /// <param name="Name">A simple string description of the item, such as a file name or a folder name..</param>
        /// <param name="PageCount">.</param>
        /// <param name="ParentFolderId">The ID of the parent folder. This is the GUID of the parent folder, or the special value &#39;root&#39; for the root folder..</param>
        /// <param name="ParentFolderUri">.</param>
        /// <param name="Type">The type of the workspace item. Valid values are file, folder..</param>
        /// <param name="Uri">.</param>
        public WorkspaceItem(WorkspaceUserAuthorization CallerAuthorization = default(WorkspaceUserAuthorization), string ContentType = default(string), string Created = default(string), string CreatedById = default(string), WorkspaceUser CreatedByInformation = default(WorkspaceUser), string Extension = default(string), string FileSize = default(string), string FileUri = default(string), string Id = default(string), string IsPublic = default(string), string LastModified = default(string), string LastModifiedById = default(string), WorkspaceUser LastModifiedByInformation = default(WorkspaceUser), string Name = default(string), string PageCount = default(string), string ParentFolderId = default(string), string ParentFolderUri = default(string), string Type = default(string), string Uri = default(string))
        {
            this.CallerAuthorization = CallerAuthorization;
            this.ContentType = ContentType;
            this.Created = Created;
            this.CreatedById = CreatedById;
            this.CreatedByInformation = CreatedByInformation;
            this.Extension = Extension;
            this.FileSize = FileSize;
            this.FileUri = FileUri;
            this.Id = Id;
            this.IsPublic = IsPublic;
            this.LastModified = LastModified;
            this.LastModifiedById = LastModifiedById;
            this.LastModifiedByInformation = LastModifiedByInformation;
            this.Name = Name;
            this.PageCount = PageCount;
            this.ParentFolderId = ParentFolderId;
            this.ParentFolderUri = ParentFolderUri;
            this.Type = Type;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// Gets or Sets CallerAuthorization
        /// </summary>
        [DataMember(Name="callerAuthorization", EmitDefaultValue=false)]
        public WorkspaceUserAuthorization CallerAuthorization { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
        /// <summary>
        /// The UTC DateTime when the workspace item was created.
        /// </summary>
        /// <value>The UTC DateTime when the workspace item was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="createdById", EmitDefaultValue=false)]
        public string CreatedById { get; set; }
        /// <summary>
        /// Gets or Sets CreatedByInformation
        /// </summary>
        [DataMember(Name="createdByInformation", EmitDefaultValue=false)]
        public WorkspaceUser CreatedByInformation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fileSize", EmitDefaultValue=false)]
        public string FileSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fileUri", EmitDefaultValue=false)]
        public string FileUri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        ///  If true, this supersedes need for bit mask permission with workspaceUserAuthorization
        /// </summary>
        /// <value> If true, this supersedes need for bit mask permission with workspaceUserAuthorization</value>
        [DataMember(Name="isPublic", EmitDefaultValue=false)]
        public string IsPublic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
        /// <summary>
        /// Utc date and time the comment was last updated (can only be done by creator)
        /// </summary>
        /// <value>Utc date and time the comment was last updated (can only be done by creator)</value>
        [DataMember(Name="lastModifiedById", EmitDefaultValue=false)]
        public string LastModifiedById { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedByInformation
        /// </summary>
        [DataMember(Name="lastModifiedByInformation", EmitDefaultValue=false)]
        public WorkspaceUser LastModifiedByInformation { get; set; }
        /// <summary>
        /// A simple string description of the item, such as a file name or a folder name.
        /// </summary>
        /// <value>A simple string description of the item, such as a file name or a folder name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public string PageCount { get; set; }
        /// <summary>
        /// The ID of the parent folder. This is the GUID of the parent folder, or the special value &#39;root&#39; for the root folder.
        /// </summary>
        /// <value>The ID of the parent folder. This is the GUID of the parent folder, or the special value &#39;root&#39; for the root folder.</value>
        [DataMember(Name="parentFolderId", EmitDefaultValue=false)]
        public string ParentFolderId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="parentFolderUri", EmitDefaultValue=false)]
        public string ParentFolderUri { get; set; }
        /// <summary>
        /// The type of the workspace item. Valid values are file, folder.
        /// </summary>
        /// <value>The type of the workspace item. Valid values are file, folder.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceItem {\n");
            sb.Append("  CallerAuthorization: ").Append(CallerAuthorization).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedByInformation: ").Append(CreatedByInformation).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileUri: ").Append(FileUri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedById: ").Append(LastModifiedById).Append("\n");
            sb.Append("  LastModifiedByInformation: ").Append(LastModifiedByInformation).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  ParentFolderUri: ").Append(ParentFolderUri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as WorkspaceItem);
        }

        /// <summary>
        /// Returns true if WorkspaceItem instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkspaceItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallerAuthorization == other.CallerAuthorization ||
                    this.CallerAuthorization != null &&
                    this.CallerAuthorization.Equals(other.CallerAuthorization)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CreatedById == other.CreatedById ||
                    this.CreatedById != null &&
                    this.CreatedById.Equals(other.CreatedById)
                ) && 
                (
                    this.CreatedByInformation == other.CreatedByInformation ||
                    this.CreatedByInformation != null &&
                    this.CreatedByInformation.Equals(other.CreatedByInformation)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.FileSize == other.FileSize ||
                    this.FileSize != null &&
                    this.FileSize.Equals(other.FileSize)
                ) && 
                (
                    this.FileUri == other.FileUri ||
                    this.FileUri != null &&
                    this.FileUri.Equals(other.FileUri)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsPublic == other.IsPublic ||
                    this.IsPublic != null &&
                    this.IsPublic.Equals(other.IsPublic)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.LastModifiedById == other.LastModifiedById ||
                    this.LastModifiedById != null &&
                    this.LastModifiedById.Equals(other.LastModifiedById)
                ) && 
                (
                    this.LastModifiedByInformation == other.LastModifiedByInformation ||
                    this.LastModifiedByInformation != null &&
                    this.LastModifiedByInformation.Equals(other.LastModifiedByInformation)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.ParentFolderId == other.ParentFolderId ||
                    this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(other.ParentFolderId)
                ) && 
                (
                    this.ParentFolderUri == other.ParentFolderUri ||
                    this.ParentFolderUri != null &&
                    this.ParentFolderUri.Equals(other.ParentFolderUri)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.CallerAuthorization != null)
                    hash = hash * 59 + this.CallerAuthorization.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CreatedById != null)
                    hash = hash * 59 + this.CreatedById.GetHashCode();
                if (this.CreatedByInformation != null)
                    hash = hash * 59 + this.CreatedByInformation.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.FileSize != null)
                    hash = hash * 59 + this.FileSize.GetHashCode();
                if (this.FileUri != null)
                    hash = hash * 59 + this.FileUri.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsPublic != null)
                    hash = hash * 59 + this.IsPublic.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedById != null)
                    hash = hash * 59 + this.LastModifiedById.GetHashCode();
                if (this.LastModifiedByInformation != null)
                    hash = hash * 59 + this.LastModifiedByInformation.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.ParentFolderId != null)
                    hash = hash * 59 + this.ParentFolderId.GetHashCode();
                if (this.ParentFolderUri != null)
                    hash = hash * 59 + this.ParentFolderUri.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
