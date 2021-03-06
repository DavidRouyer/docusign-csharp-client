/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;
using DocuSign.eSign.Api;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountsApiTests
    {
        private AccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountsApi
            //Assert.IsInstanceOfType(typeof(AccountsApi), instance, "instance is a AccountsApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string previewBillingPlan = null;
            //NewAccountDefinition newAccountDefinition = null;
            //var response = instance.Create(previewBillingPlan, newAccountDefinition);
            //Assert.IsInstanceOf<NewAccountSummary> (response, "response is NewAccountSummary");
        }
        
        /// <summary>
        /// Test CreateBrand
        /// </summary>
        [Test]
        public void CreateBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Brand brand = null;
            //string accountId = null;
            //var response = instance.CreateBrand(brand, accountId);
            //Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test CreateEMortgageTransaction
        /// </summary>
        [Test]
        public void CreateEMortgageTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostTransactionsRequest postTransactionsRequest = null;
            //string accountId = null;
            //var response = instance.CreateEMortgageTransaction(postTransactionsRequest, accountId);
            //Assert.IsInstanceOf<PostTransactionsResponse> (response, "response is PostTransactionsResponse");
        }
        
        /// <summary>
        /// Test CreatePermissionProfile
        /// </summary>
        [Test]
        public void CreatePermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //PermissionProfile permissionProfile = null;
            //string accountId = null;
            //var response = instance.CreatePermissionProfile(include, permissionProfile, accountId);
            //Assert.IsInstanceOf<PermissionProfile> (response, "response is PermissionProfile");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //instance.Delete(accountId);
            
        }
        
        /// <summary>
        /// Test DeleteBrand
        /// </summary>
        [Test]
        public void DeleteBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //instance.DeleteBrand(accountId, brandId);
            
        }
        
        /// <summary>
        /// Test DeleteBrandLogoByType
        /// </summary>
        [Test]
        public void DeleteBrandLogoByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.DeleteBrandLogoByType(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test DeleteBrands
        /// </summary>
        [Test]
        public void DeleteBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BrandsRequest brandsRequest = null;
            //string accountId = null;
            //var response = instance.DeleteBrands(brandsRequest, accountId);
            //Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test DeleteCaptiveRecipient
        /// </summary>
        [Test]
        public void DeleteCaptiveRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CaptiveRecipientInformation captiveRecipientInformation = null;
            //string accountId = null;
            //string recipientPart = null;
            //var response = instance.DeleteCaptiveRecipient(captiveRecipientInformation, accountId, recipientPart);
            //Assert.IsInstanceOf<CaptiveRecipientInformation> (response, "response is CaptiveRecipientInformation");
        }
        
        /// <summary>
        /// Test DeleteENoteConfiguration
        /// </summary>
        [Test]
        public void DeleteENoteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //instance.DeleteENoteConfiguration(accountId);
            
        }
        
        /// <summary>
        /// Test DeletePermissionProfile
        /// </summary>
        [Test]
        public void DeletePermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string permissionProfileId = null;
            //instance.DeletePermissionProfile(accountId, permissionProfileId);
            
        }
        
        /// <summary>
        /// Test GetAccountInformation
        /// </summary>
        [Test]
        public void GetAccountInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeAccountSettings = null;
            //string accountId = null;
            //var response = instance.GetAccountInformation(includeAccountSettings, accountId);
            //Assert.IsInstanceOf<AccountInformation> (response, "response is AccountInformation");
        }
        
        /// <summary>
        /// Test GetAccountTabSettings
        /// </summary>
        [Test]
        public void GetAccountTabSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.GetAccountTabSettings(accountId);
            //Assert.IsInstanceOf<TabAccountSettings> (response, "response is TabAccountSettings");
        }
        
        /// <summary>
        /// Test GetBillingCharges
        /// </summary>
        [Test]
        public void GetBillingChargesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeCharges = null;
            //string accountId = null;
            //var response = instance.GetBillingCharges(includeCharges, accountId);
            //Assert.IsInstanceOf<BillingChargeResponse> (response, "response is BillingChargeResponse");
        }
        
        /// <summary>
        /// Test GetBrand
        /// </summary>
        [Test]
        public void GetBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string includeExternalReferences = null;
            //string includeLogos = null;
            //string accountId = null;
            //string brandId = null;
            //var response = instance.GetBrand(includeExternalReferences, includeLogos, accountId, brandId);
            //Assert.IsInstanceOf<Brand> (response, "response is Brand");
        }
        
        /// <summary>
        /// Test GetBrandLogoByType
        /// </summary>
        [Test]
        public void GetBrandLogoByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.GetBrandLogoByType(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test GetBrandResources
        /// </summary>
        [Test]
        public void GetBrandResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //var response = instance.GetBrandResources(accountId, brandId);
            //Assert.IsInstanceOf<BrandResourcesList> (response, "response is BrandResourcesList");
        }
        
        /// <summary>
        /// Test GetBrandResourcesByContentType
        /// </summary>
        [Test]
        public void GetBrandResourcesByContentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string langcode = null;
            //string returnMaster = null;
            //string accountId = null;
            //string brandId = null;
            //string resourceContentType = null;
            //instance.GetBrandResourcesByContentType(langcode, returnMaster, accountId, brandId, resourceContentType);
            
        }
        
        /// <summary>
        /// Test GetConsumerDisclosure
        /// </summary>
        [Test]
        public void GetConsumerDisclosureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string langCode = null;
            //var response = instance.GetConsumerDisclosure(accountId, langCode);
            //Assert.IsInstanceOf<ConsumerDisclosure> (response, "response is ConsumerDisclosure");
        }
        
        /// <summary>
        /// Test GetConsumerDisclosureDefault
        /// </summary>
        [Test]
        public void GetConsumerDisclosureDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string langCode = null;
            //string accountId = null;
            //var response = instance.GetConsumerDisclosureDefault(langCode, accountId);
            //Assert.IsInstanceOf<ConsumerDisclosure> (response, "response is ConsumerDisclosure");
        }
        
        /// <summary>
        /// Test GetENoteConfiguration
        /// </summary>
        [Test]
        public void GetENoteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.GetENoteConfiguration(accountId);
            //Assert.IsInstanceOf<ENoteConfiguration> (response, "response is ENoteConfiguration");
        }
        
        /// <summary>
        /// Test GetPermissionProfile
        /// </summary>
        [Test]
        public void GetPermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //string accountId = null;
            //string permissionProfileId = null;
            //var response = instance.GetPermissionProfile(include, accountId, permissionProfileId);
            //Assert.IsInstanceOf<PermissionProfile> (response, "response is PermissionProfile");
        }
        
        /// <summary>
        /// Test GetProvisioning
        /// </summary>
        [Test]
        public void GetProvisioningTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetProvisioning();
            //Assert.IsInstanceOf<ProvisioningInformation> (response, "response is ProvisioningInformation");
        }
        
        /// <summary>
        /// Test ListBrands
        /// </summary>
        [Test]
        public void ListBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string excludeDistributorBrand = null;
            //string includeLogos = null;
            //string accountId = null;
            //var response = instance.ListBrands(excludeDistributorBrand, includeLogos, accountId);
            //Assert.IsInstanceOf<BrandsResponse> (response, "response is BrandsResponse");
        }
        
        /// <summary>
        /// Test ListCustomFields
        /// </summary>
        [Test]
        public void ListCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListCustomFields(accountId);
            //Assert.IsInstanceOf<CustomFields> (response, "response is CustomFields");
        }
        
        /// <summary>
        /// Test ListPermissions
        /// </summary>
        [Test]
        public void ListPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //string accountId = null;
            //var response = instance.ListPermissions(include, accountId);
            //Assert.IsInstanceOf<PermissionProfileInformation> (response, "response is PermissionProfileInformation");
        }
        
        /// <summary>
        /// Test ListRecipientNamesByEmail
        /// </summary>
        [Test]
        public void ListRecipientNamesByEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string accountId = null;
            //var response = instance.ListRecipientNamesByEmail(email, accountId);
            //Assert.IsInstanceOf<RecipientNamesResponse> (response, "response is RecipientNamesResponse");
        }
        
        /// <summary>
        /// Test ListSettings
        /// </summary>
        [Test]
        public void ListSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListSettings(accountId);
            //Assert.IsInstanceOf<AccountSettingsInformation> (response, "response is AccountSettingsInformation");
        }
        
        /// <summary>
        /// Test ListSharedAccess
        /// </summary>
        [Test]
        public void ListSharedAccessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string count = null;
            //string envelopesNotSharedUserStatus = null;
            //string folderIds = null;
            //string itemType = null;
            //string searchText = null;
            //string shared = null;
            //string startPosition = null;
            //string userIds = null;
            //string accountId = null;
            //var response = instance.ListSharedAccess(count, envelopesNotSharedUserStatus, folderIds, itemType, searchText, shared, startPosition, userIds, accountId);
            //Assert.IsInstanceOf<AccountSharedAccess> (response, "response is AccountSharedAccess");
        }
        
        /// <summary>
        /// Test ListSignatureProviders
        /// </summary>
        [Test]
        public void ListSignatureProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListSignatureProviders(accountId);
            //Assert.IsInstanceOf<AccountSignatureProviders> (response, "response is AccountSignatureProviders");
        }
        
        /// <summary>
        /// Test ListUnsupportedFileTypes
        /// </summary>
        [Test]
        public void ListUnsupportedFileTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListUnsupportedFileTypes(accountId);
            //Assert.IsInstanceOf<FileTypeList> (response, "response is FileTypeList");
        }
        
        /// <summary>
        /// Test UpdateAccountTabSettings
        /// </summary>
        [Test]
        public void UpdateAccountTabSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TabAccountSettings tabAccountSettings = null;
            //string accountId = null;
            //var response = instance.UpdateAccountTabSettings(tabAccountSettings, accountId);
            //Assert.IsInstanceOf<TabAccountSettings> (response, "response is TabAccountSettings");
        }
        
        /// <summary>
        /// Test UpdateBrand
        /// </summary>
        [Test]
        public void UpdateBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Brand brand = null;
            //string accountId = null;
            //string brandId = null;
            //var response = instance.UpdateBrand(brand, accountId, brandId);
            //Assert.IsInstanceOf<Brand> (response, "response is Brand");
        }
        
        /// <summary>
        /// Test UpdateBrandLogoByType
        /// </summary>
        [Test]
        public void UpdateBrandLogoByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.UpdateBrandLogoByType(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test UpdateBrandResourcesByContentType
        /// </summary>
        [Test]
        public void UpdateBrandResourcesByContentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string resourceContentType = null;
            //var response = instance.UpdateBrandResourcesByContentType(accountId, brandId, resourceContentType);
            //Assert.IsInstanceOf<BrandResources> (response, "response is BrandResources");
        }
        
        /// <summary>
        /// Test UpdateENoteConfiguration
        /// </summary>
        [Test]
        public void UpdateENoteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ENoteConfiguration eNoteConfiguration = null;
            //string accountId = null;
            //var response = instance.UpdateENoteConfiguration(eNoteConfiguration, accountId);
            //Assert.IsInstanceOf<ENoteConfiguration> (response, "response is ENoteConfiguration");
        }
        
        /// <summary>
        /// Test UpdatePermissionProfile
        /// </summary>
        [Test]
        public void UpdatePermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string include = null;
            //PermissionProfile permissionProfile = null;
            //string accountId = null;
            //string permissionProfileId = null;
            //var response = instance.UpdatePermissionProfile(include, permissionProfile, accountId, permissionProfileId);
            //Assert.IsInstanceOf<PermissionProfile> (response, "response is PermissionProfile");
        }
        
        /// <summary>
        /// Test UpdateSettings
        /// </summary>
        [Test]
        public void UpdateSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountSettingsInformation accountSettingsInformation = null;
            //string accountId = null;
            //instance.UpdateSettings(accountSettingsInformation, accountId);
            
        }
        
        /// <summary>
        /// Test UpdateSharedAccess
        /// </summary>
        [Test]
        public void UpdateSharedAccessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemType = null;
            //string userIds = null;
            //AccountSharedAccess accountSharedAccess = null;
            //string accountId = null;
            //var response = instance.UpdateSharedAccess(itemType, userIds, accountSharedAccess, accountId);
            //Assert.IsInstanceOf<AccountSharedAccess> (response, "response is AccountSharedAccess");
        }
        
    }

}
