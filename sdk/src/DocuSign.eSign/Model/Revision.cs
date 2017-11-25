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
    /// Revision
    /// </summary>
    [DataContract]
    public partial class Revision :  IEquatable<Revision>, IValidatableObject
    {
        public Revision()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Revision" /> class.
        /// </summary>
        /// <param name="EndData">.</param>
        /// <param name="FieldName">.</param>
        /// <param name="MaxSignatureLength">.</param>
        /// <param name="SignatureType">.</param>
        /// <param name="StartData">.</param>
        public Revision(string EndData = default(string), string FieldName = default(string), string MaxSignatureLength = default(string), string SignatureType = default(string), string StartData = default(string))
        {
            this.EndData = EndData;
            this.FieldName = FieldName;
            this.MaxSignatureLength = MaxSignatureLength;
            this.SignatureType = SignatureType;
            this.StartData = StartData;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="endData", EmitDefaultValue=false)]
        public string EndData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="maxSignatureLength", EmitDefaultValue=false)]
        public string MaxSignatureLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="startData", EmitDefaultValue=false)]
        public string StartData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Revision {\n");
            sb.Append("  EndData: ").Append(EndData).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  MaxSignatureLength: ").Append(MaxSignatureLength).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  StartData: ").Append(StartData).Append("\n");
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
            return this.Equals(obj as Revision);
        }

        /// <summary>
        /// Returns true if Revision instances are equal
        /// </summary>
        /// <param name="other">Instance of Revision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Revision other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndData == other.EndData ||
                    this.EndData != null &&
                    this.EndData.Equals(other.EndData)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.MaxSignatureLength == other.MaxSignatureLength ||
                    this.MaxSignatureLength != null &&
                    this.MaxSignatureLength.Equals(other.MaxSignatureLength)
                ) && 
                (
                    this.SignatureType == other.SignatureType ||
                    this.SignatureType != null &&
                    this.SignatureType.Equals(other.SignatureType)
                ) && 
                (
                    this.StartData == other.StartData ||
                    this.StartData != null &&
                    this.StartData.Equals(other.StartData)
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
                if (this.EndData != null)
                    hash = hash * 59 + this.EndData.GetHashCode();
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.MaxSignatureLength != null)
                    hash = hash * 59 + this.MaxSignatureLength.GetHashCode();
                if (this.SignatureType != null)
                    hash = hash * 59 + this.SignatureType.GetHashCode();
                if (this.StartData != null)
                    hash = hash * 59 + this.StartData.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}