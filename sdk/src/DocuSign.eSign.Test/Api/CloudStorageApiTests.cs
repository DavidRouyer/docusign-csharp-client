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
    ///  Class for testing CloudStorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CloudStorageApiTests
    {
        private CloudStorageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CloudStorageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CloudStorageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CloudStorageApi
            //Assert.IsInstanceOfType(typeof(CloudStorageApi), instance, "instance is a CloudStorageApi");
        }

        
        /// <summary>
        /// Test CreateProvider
        /// </summary>
        [Test]
        public void CreateProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CloudStorageProviders cloudStorageProviders = null;
            //string accountId = null;
            //string userId = null;
            //var response = instance.CreateProvider(cloudStorageProviders, accountId, userId);
            //Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test DeleteProvider
        /// </summary>
        [Test]
        public void DeleteProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //var response = instance.DeleteProvider(accountId, userId, serviceId);
            //Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test DeleteProviders
        /// </summary>
        [Test]
        public void DeleteProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CloudStorageProviders cloudStorageProviders = null;
            //string accountId = null;
            //string userId = null;
            //var response = instance.DeleteProviders(cloudStorageProviders, accountId, userId);
            //Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test GetProvider
        /// </summary>
        [Test]
        public void GetProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string redirectUrl = null;
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //var response = instance.GetProvider(redirectUrl, accountId, userId, serviceId);
            //Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cloudStorageFolderPath = null;
            //string count = null;
            //string order = null;
            //string orderBy = null;
            //string searchText = null;
            //string startPosition = null;
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //string folderId = null;
            //var response = instance.List(cloudStorageFolderPath, count, order, orderBy, searchText, startPosition, accountId, userId, serviceId, folderId);
            //Assert.IsInstanceOf<ExternalFolder> (response, "response is ExternalFolder");
        }
        
        /// <summary>
        /// Test ListFolders
        /// </summary>
        [Test]
        public void ListFoldersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cloudStorageFolderPath = null;
            //string count = null;
            //string order = null;
            //string orderBy = null;
            //string searchText = null;
            //string startPosition = null;
            //string accountId = null;
            //string userId = null;
            //string serviceId = null;
            //var response = instance.ListFolders(cloudStorageFolderPath, count, order, orderBy, searchText, startPosition, accountId, userId, serviceId);
            //Assert.IsInstanceOf<ExternalFolder> (response, "response is ExternalFolder");
        }
        
        /// <summary>
        /// Test ListProviders
        /// </summary>
        [Test]
        public void ListProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string redirectUrl = null;
            //string accountId = null;
            //string userId = null;
            //var response = instance.ListProviders(redirectUrl, accountId, userId);
            //Assert.IsInstanceOf<CloudStorageProviders> (response, "response is CloudStorageProviders");
        }
        
    }

}