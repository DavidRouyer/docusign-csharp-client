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
    /// PaymentDetails
    /// </summary>
    [DataContract]
    public partial class PaymentDetails :  IEquatable<PaymentDetails>, IValidatableObject
    {
        public PaymentDetails()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetails" /> class.
        /// </summary>
        /// <param name="AllowedPaymentMethods">.</param>
        /// <param name="ChargeId">.</param>
        /// <param name="CurrencyCode">.</param>
        /// <param name="GatewayAccountId">.</param>
        /// <param name="GatewayDisplayName">.</param>
        /// <param name="GatewayName">.</param>
        /// <param name="LineItems">.</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        /// <param name="Total">Total.</param>
        public PaymentDetails(List<string> AllowedPaymentMethods = default(List<string>), string ChargeId = default(string), string CurrencyCode = default(string), string GatewayAccountId = default(string), string GatewayDisplayName = default(string), string GatewayName = default(string), List<PaymentLineItem> LineItems = default(List<PaymentLineItem>), string Status = default(string), Money Total = default(Money))
        {
            this.AllowedPaymentMethods = AllowedPaymentMethods;
            this.ChargeId = ChargeId;
            this.CurrencyCode = CurrencyCode;
            this.GatewayAccountId = GatewayAccountId;
            this.GatewayDisplayName = GatewayDisplayName;
            this.GatewayName = GatewayName;
            this.LineItems = LineItems;
            this.Status = Status;
            this.Total = Total;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="allowedPaymentMethods", EmitDefaultValue=false)]
        public List<string> AllowedPaymentMethods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="chargeId", EmitDefaultValue=false)]
        public string ChargeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="gatewayAccountId", EmitDefaultValue=false)]
        public string GatewayAccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="gatewayDisplayName", EmitDefaultValue=false)]
        public string GatewayDisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="gatewayName", EmitDefaultValue=false)]
        public string GatewayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<PaymentLineItem> LineItems { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public Money Total { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDetails {\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  GatewayAccountId: ").Append(GatewayAccountId).Append("\n");
            sb.Append("  GatewayDisplayName: ").Append(GatewayDisplayName).Append("\n");
            sb.Append("  GatewayName: ").Append(GatewayName).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as PaymentDetails);
        }

        /// <summary>
        /// Returns true if PaymentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowedPaymentMethods == other.AllowedPaymentMethods ||
                    this.AllowedPaymentMethods != null &&
                    this.AllowedPaymentMethods.SequenceEqual(other.AllowedPaymentMethods)
                ) && 
                (
                    this.ChargeId == other.ChargeId ||
                    this.ChargeId != null &&
                    this.ChargeId.Equals(other.ChargeId)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.GatewayAccountId == other.GatewayAccountId ||
                    this.GatewayAccountId != null &&
                    this.GatewayAccountId.Equals(other.GatewayAccountId)
                ) && 
                (
                    this.GatewayDisplayName == other.GatewayDisplayName ||
                    this.GatewayDisplayName != null &&
                    this.GatewayDisplayName.Equals(other.GatewayDisplayName)
                ) && 
                (
                    this.GatewayName == other.GatewayName ||
                    this.GatewayName != null &&
                    this.GatewayName.Equals(other.GatewayName)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.AllowedPaymentMethods != null)
                    hash = hash * 59 + this.AllowedPaymentMethods.GetHashCode();
                if (this.ChargeId != null)
                    hash = hash * 59 + this.ChargeId.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.GatewayAccountId != null)
                    hash = hash * 59 + this.GatewayAccountId.GetHashCode();
                if (this.GatewayDisplayName != null)
                    hash = hash * 59 + this.GatewayDisplayName.GetHashCode();
                if (this.GatewayName != null)
                    hash = hash * 59 + this.GatewayName.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
