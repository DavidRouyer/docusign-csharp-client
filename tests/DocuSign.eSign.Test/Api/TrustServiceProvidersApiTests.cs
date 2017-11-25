/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;
using DocuSign.eSign.Api;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing TrustServiceProvidersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TrustServiceProvidersApiTests
    {
        private TrustServiceProvidersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TrustServiceProvidersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TrustServiceProvidersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TrustServiceProvidersApi
            //Assert.IsInstanceOfType(typeof(TrustServiceProvidersApi), instance, "instance is a TrustServiceProvidersApi");
        }

        
        /// <summary>
        /// Test CompleteSignHash
        /// </summary>
        [Test]
        public void CompleteSignHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompleteSignRequest completeSignRequest = null;
            //var response = instance.CompleteSignHash(completeSignRequest);
            //Assert.IsInstanceOf<CompleteSignHashResponse> (response, "response is CompleteSignHashResponse");
        }
        
        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Test]
        public void GetUserInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserInfo();
            //Assert.IsInstanceOf<UserInfoResponse> (response, "response is UserInfoResponse");
        }
        
        /// <summary>
        /// Test HealthCheck
        /// </summary>
        [Test]
        public void HealthCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TspHealthCheckRequest tspHealthCheckRequest = null;
            //instance.HealthCheck(tspHealthCheckRequest);
            
        }
        
        /// <summary>
        /// Test SignHashSessionInfo
        /// </summary>
        [Test]
        public void SignHashSessionInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SignSessionInfoRequest signSessionInfoRequest = null;
            //var response = instance.SignHashSessionInfo(signSessionInfoRequest);
            //Assert.IsInstanceOf<SignHashSessionInfoResponse> (response, "response is SignHashSessionInfoResponse");
        }
        
        /// <summary>
        /// Test UpdateTransaction
        /// </summary>
        [Test]
        public void UpdateTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateTransactionRequest updateTransactionRequest = null;
            //var response = instance.UpdateTransaction(updateTransactionRequest);
            //Assert.IsInstanceOf<UpdateTransactionResponse> (response, "response is UpdateTransactionResponse");
        }
        
    }

}