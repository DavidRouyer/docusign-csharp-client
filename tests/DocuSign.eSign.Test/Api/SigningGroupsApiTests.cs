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
    ///  Class for testing SigningGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SigningGroupsApiTests
    {
        private SigningGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SigningGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SigningGroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SigningGroupsApi
            //Assert.IsInstanceOfType(typeof(SigningGroupsApi), instance, "instance is a SigningGroupsApi");
        }

        
        /// <summary>
        /// Test CreateList
        /// </summary>
        [Test]
        public void CreateListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupInformation signingGroupInformation = null;
            //string accountId = null;
            //var response = instance.CreateList(signingGroupInformation, accountId);
            //Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test DeleteList
        /// </summary>
        [Test]
        public void DeleteListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupInformation signingGroupInformation = null;
            //string accountId = null;
            //var response = instance.DeleteList(signingGroupInformation, accountId);
            //Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test DeleteUsers
        /// </summary>
        [Test]
        public void DeleteUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupUsers signingGroupUsers = null;
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.DeleteUsers(signingGroupUsers, accountId, signingGroupId);
            //Assert.IsInstanceOf<SigningGroupUsers> (response, "response is SigningGroupUsers");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.Get(accountId, signingGroupId);
            //Assert.IsInstanceOf<SigningGroup> (response, "response is SigningGroup");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupType = null;
            //string includeUsers = null;
            //string accountId = null;
            //var response = instance.List(groupType, includeUsers, accountId);
            //Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test ListUsers
        /// </summary>
        [Test]
        public void ListUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.ListUsers(accountId, signingGroupId);
            //Assert.IsInstanceOf<SigningGroupUsers> (response, "response is SigningGroupUsers");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroup signingGroup = null;
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.Update(signingGroup, accountId, signingGroupId);
            //Assert.IsInstanceOf<SigningGroup> (response, "response is SigningGroup");
        }
        
        /// <summary>
        /// Test UpdateList
        /// </summary>
        [Test]
        public void UpdateListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupInformation signingGroupInformation = null;
            //string accountId = null;
            //var response = instance.UpdateList(signingGroupInformation, accountId);
            //Assert.IsInstanceOf<SigningGroupInformation> (response, "response is SigningGroupInformation");
        }
        
        /// <summary>
        /// Test UpdateUsers
        /// </summary>
        [Test]
        public void UpdateUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SigningGroupUsers signingGroupUsers = null;
            //string accountId = null;
            //string signingGroupId = null;
            //var response = instance.UpdateUsers(signingGroupUsers, accountId, signingGroupId);
            //Assert.IsInstanceOf<SigningGroupUsers> (response, "response is SigningGroupUsers");
        }
        
    }

}
