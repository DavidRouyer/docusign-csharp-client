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
    /// DocumentTemplate
    /// </summary>
    [DataContract]
    public partial class DocumentTemplate :  IEquatable<DocumentTemplate>, IValidatableObject
    {
        public DocumentTemplate()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTemplate" /> class.
        /// </summary>
        /// <param name="DocumentEndPage">.</param>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="DocumentStartPage">.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="TemplateId">The unique identifier of the template. If this is not provided, DocuSign will generate a value. .</param>
        public DocumentTemplate(string DocumentEndPage = default(string), string DocumentId = default(string), string DocumentStartPage = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string TemplateId = default(string))
        {
            this.DocumentEndPage = DocumentEndPage;
            this.DocumentId = DocumentId;
            this.DocumentStartPage = DocumentStartPage;
            this.ErrorDetails = ErrorDetails;
            this.TemplateId = TemplateId;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentEndPage", EmitDefaultValue=false)]
        public string DocumentEndPage { get; set; }
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentStartPage", EmitDefaultValue=false)]
        public string DocumentStartPage { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value. 
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value. </value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTemplate {\n");
            sb.Append("  DocumentEndPage: ").Append(DocumentEndPage).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentStartPage: ").Append(DocumentStartPage).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(obj as DocumentTemplate);
        }

        /// <summary>
        /// Returns true if DocumentTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentEndPage == other.DocumentEndPage ||
                    this.DocumentEndPage != null &&
                    this.DocumentEndPage.Equals(other.DocumentEndPage)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.DocumentStartPage == other.DocumentStartPage ||
                    this.DocumentStartPage != null &&
                    this.DocumentStartPage.Equals(other.DocumentStartPage)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
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
                if (this.DocumentEndPage != null)
                    hash = hash * 59 + this.DocumentEndPage.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.DocumentStartPage != null)
                    hash = hash * 59 + this.DocumentStartPage.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
