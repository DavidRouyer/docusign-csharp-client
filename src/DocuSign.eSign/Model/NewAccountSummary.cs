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
    /// NewAccountSummary
    /// </summary>
    [DataContract]
    public partial class NewAccountSummary :  IEquatable<NewAccountSummary>, IValidatableObject
    {
        public NewAccountSummary()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccountSummary" /> class.
        /// </summary>
        /// <param name="AccountId">The account ID associated with the envelope..</param>
        /// <param name="AccountIdGuid">The GUID associated with the account ID..</param>
        /// <param name="AccountName">The account name for the new account..</param>
        /// <param name="ApiPassword">Contains a token that can be used for authentication in API calls instead of using the user name and password..</param>
        /// <param name="BaseUrl">The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri&#39;s that are relative to this baseUrl..</param>
        /// <param name="BillingPlanPreview">BillingPlanPreview.</param>
        /// <param name="UserId">Specifies the user ID of the new user..</param>
        public NewAccountSummary(string AccountId = default(string), string AccountIdGuid = default(string), string AccountName = default(string), string ApiPassword = default(string), string BaseUrl = default(string), BillingPlanPreview BillingPlanPreview = default(BillingPlanPreview), string UserId = default(string))
        {
            this.AccountId = AccountId;
            this.AccountIdGuid = AccountIdGuid;
            this.AccountName = AccountName;
            this.ApiPassword = ApiPassword;
            this.BaseUrl = BaseUrl;
            this.BillingPlanPreview = BillingPlanPreview;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// The GUID associated with the account ID.
        /// </summary>
        /// <value>The GUID associated with the account ID.</value>
        [DataMember(Name="accountIdGuid", EmitDefaultValue=false)]
        public string AccountIdGuid { get; set; }
        /// <summary>
        /// The account name for the new account.
        /// </summary>
        /// <value>The account name for the new account.</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Contains a token that can be used for authentication in API calls instead of using the user name and password.
        /// </summary>
        /// <value>Contains a token that can be used for authentication in API calls instead of using the user name and password.</value>
        [DataMember(Name="apiPassword", EmitDefaultValue=false)]
        public string ApiPassword { get; set; }
        /// <summary>
        /// The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri&#39;s that are relative to this baseUrl.
        /// </summary>
        /// <value>The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri&#39;s that are relative to this baseUrl.</value>
        [DataMember(Name="baseUrl", EmitDefaultValue=false)]
        public string BaseUrl { get; set; }
        /// <summary>
        /// Gets or Sets BillingPlanPreview
        /// </summary>
        [DataMember(Name="billingPlanPreview", EmitDefaultValue=false)]
        public BillingPlanPreview BillingPlanPreview { get; set; }
        /// <summary>
        /// Specifies the user ID of the new user.
        /// </summary>
        /// <value>Specifies the user ID of the new user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAccountSummary {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountIdGuid: ").Append(AccountIdGuid).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ApiPassword: ").Append(ApiPassword).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  BillingPlanPreview: ").Append(BillingPlanPreview).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as NewAccountSummary);
        }

        /// <summary>
        /// Returns true if NewAccountSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of NewAccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAccountSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AccountIdGuid == other.AccountIdGuid ||
                    this.AccountIdGuid != null &&
                    this.AccountIdGuid.Equals(other.AccountIdGuid)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.ApiPassword == other.ApiPassword ||
                    this.ApiPassword != null &&
                    this.ApiPassword.Equals(other.ApiPassword)
                ) && 
                (
                    this.BaseUrl == other.BaseUrl ||
                    this.BaseUrl != null &&
                    this.BaseUrl.Equals(other.BaseUrl)
                ) && 
                (
                    this.BillingPlanPreview == other.BillingPlanPreview ||
                    this.BillingPlanPreview != null &&
                    this.BillingPlanPreview.Equals(other.BillingPlanPreview)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.AccountIdGuid != null)
                    hash = hash * 59 + this.AccountIdGuid.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.ApiPassword != null)
                    hash = hash * 59 + this.ApiPassword.GetHashCode();
                if (this.BaseUrl != null)
                    hash = hash * 59 + this.BaseUrl.GetHashCode();
                if (this.BillingPlanPreview != null)
                    hash = hash * 59 + this.BillingPlanPreview.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}