/* 
 * Nodeum API
 *
 * The Nodeum API makes it easy to tap into the digital data mesh that runs across your organisation. Make requests to our API endpoints and we’ll give you everything you need to interconnect your business workflows with your storage.  All production API requests are made to:  http://nodeumhostname/api/  The current production version of the API is v1.   **REST** The Nodeum API is a RESTful API. This means that the API is designed to allow you to get, create, update, & delete objects with the HTTP verbs GET, POST, PUT, PATCH, & DELETE.  **JSON** The Nodeum API speaks exclusively in JSON. This means that you should always set the Content-Type header to application/json to ensure that your requests are properly accepted and processed by the API.  **Authentication** All API calls require user-password authentication.   **Cross-Origin Resource Sharing** The Nodeum API supports CORS for communicating from Javascript for these endpoints. You will need to specify an Origin URI when creating your application to allow for CORS to be whitelisted for your domain.   **Pagination** Some endpoints such as File Listing return a potentially lengthy array of objects. In order to keep the response sizes manageable the API will take advantage of pagination. Pagination is a mechanism for returning a subset of the results for a request and allowing for subsequent requests to “page” through the rest of the results until the end is reached. Paginated endpoints follow a standard interface that accepts two query parameters, limit and offset, and return a payload that follows a standard form. These parameters names and their behavior are borrowed from SQL LIMIT and OFFSET keywords.  **Versioning** The Nodeum API is constantly being worked on to add features, make improvements, and fix bugs. This means that you should expect changes to be introduced and documented.   However, there are some changes or additions that are considered backwards-compatible and your applications should be flexible enough to handle them. These include:  - Adding new endpoints to the API - Adding new attributes to the response of an existing endpoint - Changing the order of attributes of responses (JSON by definition is an object of unordered key/value pairs)  **Filter parameters** When browsing a list of items, multiple filter parameters may be applied. Some operators can be added to the value as a prefix:  - `=` value is equal. Default operator, may be omitted  - `!=` value is different  - `>` greater than  - `>=` greater than or equal  - `<` lower than  - `>=` lower than or equal  - `><` included in list, items should be separated by `|`  - `!><` not included in list, items should be separated by `|`  - `~` pattern matching, may include `%` (any characters) and `_` (one character)  - `!~` pattern not matching, may include `%` (any characters) and `_` (one character)  
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: info@nodeum.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Model;
using Io.Nodeum.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Io.Nodeum.Sdk.Test
{
    /// <summary>
    ///  Class for testing NasShare
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NasShareTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NasShare
        //private NasShare instance;

        public NasShareTests()
        {
            // TODO uncomment below to create an instance of NasShare
            //instance = new NasShare();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NasShare
        /// </summary>
        [Fact]
        public void NasShareInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NasShare
            //Assert.IsInstanceOfType<NasShare> (instance, "variable 'instance' is a NasShare");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'NasId'
        /// </summary>
        [Fact]
        public void NasIdTest()
        {
            // TODO unit test for the property 'NasId'
        }
        /// <summary>
        /// Test the property 'PoolId'
        /// </summary>
        [Fact]
        public void PoolIdTest()
        {
            // TODO unit test for the property 'PoolId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }
        /// <summary>
        /// Test the property 'Options'
        /// </summary>
        [Fact]
        public void OptionsTest()
        {
            // TODO unit test for the property 'Options'
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'FileCount'
        /// </summary>
        [Fact]
        public void FileCountTest()
        {
            // TODO unit test for the property 'FileCount'
        }
        /// <summary>
        /// Test the property 'FileSizeSum'
        /// </summary>
        [Fact]
        public void FileSizeSumTest()
        {
            // TODO unit test for the property 'FileSizeSum'
        }

    }

}