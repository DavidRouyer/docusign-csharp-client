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
    /// DateStampProperties
    /// </summary>
    [DataContract]
    public partial class DateStampProperties :  IEquatable<DateStampProperties>, IValidatableObject
    {
        public DateStampProperties()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateStampProperties" /> class.
        /// </summary>
        /// <param name="DateAreaHeight">.</param>
        /// <param name="DateAreaWidth">.</param>
        /// <param name="DateAreaX">.</param>
        /// <param name="DateAreaY">.</param>
        public DateStampProperties(string DateAreaHeight = default(string), string DateAreaWidth = default(string), string DateAreaX = default(string), string DateAreaY = default(string))
        {
            this.DateAreaHeight = DateAreaHeight;
            this.DateAreaWidth = DateAreaWidth;
            this.DateAreaX = DateAreaX;
            this.DateAreaY = DateAreaY;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dateAreaHeight", EmitDefaultValue=false)]
        public string DateAreaHeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dateAreaWidth", EmitDefaultValue=false)]
        public string DateAreaWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dateAreaX", EmitDefaultValue=false)]
        public string DateAreaX { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dateAreaY", EmitDefaultValue=false)]
        public string DateAreaY { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateStampProperties {\n");
            sb.Append("  DateAreaHeight: ").Append(DateAreaHeight).Append("\n");
            sb.Append("  DateAreaWidth: ").Append(DateAreaWidth).Append("\n");
            sb.Append("  DateAreaX: ").Append(DateAreaX).Append("\n");
            sb.Append("  DateAreaY: ").Append(DateAreaY).Append("\n");
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
            return this.Equals(obj as DateStampProperties);
        }

        /// <summary>
        /// Returns true if DateStampProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DateStampProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateStampProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateAreaHeight == other.DateAreaHeight ||
                    this.DateAreaHeight != null &&
                    this.DateAreaHeight.Equals(other.DateAreaHeight)
                ) && 
                (
                    this.DateAreaWidth == other.DateAreaWidth ||
                    this.DateAreaWidth != null &&
                    this.DateAreaWidth.Equals(other.DateAreaWidth)
                ) && 
                (
                    this.DateAreaX == other.DateAreaX ||
                    this.DateAreaX != null &&
                    this.DateAreaX.Equals(other.DateAreaX)
                ) && 
                (
                    this.DateAreaY == other.DateAreaY ||
                    this.DateAreaY != null &&
                    this.DateAreaY.Equals(other.DateAreaY)
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
                if (this.DateAreaHeight != null)
                    hash = hash * 59 + this.DateAreaHeight.GetHashCode();
                if (this.DateAreaWidth != null)
                    hash = hash * 59 + this.DateAreaWidth.GetHashCode();
                if (this.DateAreaX != null)
                    hash = hash * 59 + this.DateAreaX.GetHashCode();
                if (this.DateAreaY != null)
                    hash = hash * 59 + this.DateAreaY.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
