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
    /// A complex type that Contains the elements:  * recipMayProvideNumber - Boolean. When set to **true**, the recipient can use whatever phone number they choose. * senderProvidedNumbers - ArrayOfString.  A list of phone numbers the recipient can use. * recordVoicePrint - Reserved. * validateRecipProvidedNumber - Reserved.
    /// </summary>
    [DataContract]
    public partial class RecipientPhoneAuthentication :  IEquatable<RecipientPhoneAuthentication>, IValidatableObject
    {
        public RecipientPhoneAuthentication()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientPhoneAuthentication" /> class.
        /// </summary>
        /// <param name="RecipMayProvideNumber">Boolean. When set to **true**, the recipient can supply a phone number their choice..</param>
        /// <param name="RecordVoicePrint">Reserved..</param>
        /// <param name="SenderProvidedNumbers">An Array containing a list of phone numbers the recipient may use for SMS text authentication. .</param>
        /// <param name="ValidateRecipProvidedNumber"> Reserved..</param>
        public RecipientPhoneAuthentication(string RecipMayProvideNumber = default(string), string RecordVoicePrint = default(string), List<string> SenderProvidedNumbers = default(List<string>), string ValidateRecipProvidedNumber = default(string))
        {
            this.RecipMayProvideNumber = RecipMayProvideNumber;
            this.RecordVoicePrint = RecordVoicePrint;
            this.SenderProvidedNumbers = SenderProvidedNumbers;
            this.ValidateRecipProvidedNumber = ValidateRecipProvidedNumber;
        }
        
        /// <summary>
        /// Boolean. When set to **true**, the recipient can supply a phone number their choice.
        /// </summary>
        /// <value>Boolean. When set to **true**, the recipient can supply a phone number their choice.</value>
        [DataMember(Name="recipMayProvideNumber", EmitDefaultValue=false)]
        public string RecipMayProvideNumber { get; set; }
        /// <summary>
        /// Reserved.
        /// </summary>
        /// <value>Reserved.</value>
        [DataMember(Name="recordVoicePrint", EmitDefaultValue=false)]
        public string RecordVoicePrint { get; set; }
        /// <summary>
        /// An Array containing a list of phone numbers the recipient may use for SMS text authentication. 
        /// </summary>
        /// <value>An Array containing a list of phone numbers the recipient may use for SMS text authentication. </value>
        [DataMember(Name="senderProvidedNumbers", EmitDefaultValue=false)]
        public List<string> SenderProvidedNumbers { get; set; }
        /// <summary>
        ///  Reserved.
        /// </summary>
        /// <value> Reserved.</value>
        [DataMember(Name="validateRecipProvidedNumber", EmitDefaultValue=false)]
        public string ValidateRecipProvidedNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientPhoneAuthentication {\n");
            sb.Append("  RecipMayProvideNumber: ").Append(RecipMayProvideNumber).Append("\n");
            sb.Append("  RecordVoicePrint: ").Append(RecordVoicePrint).Append("\n");
            sb.Append("  SenderProvidedNumbers: ").Append(SenderProvidedNumbers).Append("\n");
            sb.Append("  ValidateRecipProvidedNumber: ").Append(ValidateRecipProvidedNumber).Append("\n");
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
            return this.Equals(obj as RecipientPhoneAuthentication);
        }

        /// <summary>
        /// Returns true if RecipientPhoneAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientPhoneAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientPhoneAuthentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RecipMayProvideNumber == other.RecipMayProvideNumber ||
                    this.RecipMayProvideNumber != null &&
                    this.RecipMayProvideNumber.Equals(other.RecipMayProvideNumber)
                ) && 
                (
                    this.RecordVoicePrint == other.RecordVoicePrint ||
                    this.RecordVoicePrint != null &&
                    this.RecordVoicePrint.Equals(other.RecordVoicePrint)
                ) && 
                (
                    this.SenderProvidedNumbers == other.SenderProvidedNumbers ||
                    this.SenderProvidedNumbers != null &&
                    this.SenderProvidedNumbers.SequenceEqual(other.SenderProvidedNumbers)
                ) && 
                (
                    this.ValidateRecipProvidedNumber == other.ValidateRecipProvidedNumber ||
                    this.ValidateRecipProvidedNumber != null &&
                    this.ValidateRecipProvidedNumber.Equals(other.ValidateRecipProvidedNumber)
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
                if (this.RecipMayProvideNumber != null)
                    hash = hash * 59 + this.RecipMayProvideNumber.GetHashCode();
                if (this.RecordVoicePrint != null)
                    hash = hash * 59 + this.RecordVoicePrint.GetHashCode();
                if (this.SenderProvidedNumbers != null)
                    hash = hash * 59 + this.SenderProvidedNumbers.GetHashCode();
                if (this.ValidateRecipProvidedNumber != null)
                    hash = hash * 59 + this.ValidateRecipProvidedNumber.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
