/* 
 * Nodeum API
 *
 * The Nodeum API makes it easy to tap into the digital data mesh that runs across your organisation. Make requests to our API endpoints and we’ll give you everything you need to interconnect your business workflows with your storage.  All production API requests are made to:  http://nodeumhostname/api/  The current production version of the API is v1.   **REST** The Nodeum API is a RESTful API. This means that the API is designed to allow you to get, create, update, & delete objects with the HTTP verbs GET, POST, PUT, PATCH, & DELETE.  **JSON** The Nodeum API speaks exclusively in JSON. This means that you should always set the Content-Type header to application/json to ensure that your requests are properly accepted and processed by the API.  **Authentication** All API calls require user-password authentication.   **Cross-Origin Resource Sharing** The Nodeum API supports CORS for communicating from Javascript for these endpoints. You will need to specify an Origin URI when creating your application to allow for CORS to be whitelisted for your domain.   **Pagination** Some endpoints such as File Listing return a potentially lengthy array of objects. In order to keep the response sizes manageable the API will take advantage of pagination. Pagination is a mechanism for returning a subset of the results for a request and allowing for subsequent requests to “page” through the rest of the results until the end is reached. Paginated endpoints follow a standard interface that accepts two query parameters, limit and offset, and return a payload that follows a standard form. These parameters names and their behavior are borrowed from SQL LIMIT and OFFSET keywords.  **Versioning** The Nodeum API is constantly being worked on to add features, make improvements, and fix bugs. This means that you should expect changes to be introduced and documented.   However, there are some changes or additions that are considered backwards-compatible and your applications should be flexible enough to handle them. These include:  - Adding new endpoints to the API - Adding new attributes to the response of an existing endpoint - Changing the order of attributes of responses (JSON by definition is an object of unordered key/value pairs)  **Filter parameters** When browsing a list of items, multiple filter parameters may be applied. Some operators can be added to the value as a prefix:  - `=` value is equal. Default operator, may be omitted  - `!=` value is different  - `>` greater than  - `>=` greater than or equal  - `<` lower than  - `>=` lower than or equal  - `><` included in list, items should be separated by `|`  - `!><` not included in list, items should be separated by `|`  - `~` pattern matching, may include `%` (any characters) and `_` (one character)  - `!~` pattern not matching, may include `%` (any characters) and `_` (one character)  
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: info@nodeum.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Model;

namespace Io.Nodeum.Sdk.Test
{
    /// <summary>
    ///  Class for testing PoolsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PoolsApiTests : IDisposable
    {
        private PoolsApi instance;

        public PoolsApiTests()
        {
            instance = new PoolsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PoolsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PoolsApi
            //Assert.IsType(typeof(PoolsApi), instance, "instance is a PoolsApi");
        }

        
        /// <summary>
        /// Test CreatePool
        /// </summary>
        [Fact]
        public void CreatePoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PoolUp poolBody = null;
            //var response = instance.CreatePool(poolBody);
            //Assert.IsType<Pool> (response, "response is Pool");
        }
        
        /// <summary>
        /// Test CreatePrimaryScan
        /// </summary>
        [Fact]
        public void CreatePrimaryScanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //PrimaryScan primaryScanBody = null;
            //var response = instance.CreatePrimaryScan(poolId, primaryScanBody);
            //Assert.IsType<PrimaryScan> (response, "response is PrimaryScan");
        }
        
        /// <summary>
        /// Test DestroyPool
        /// </summary>
        [Fact]
        public void DestroyPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //instance.DestroyPool(poolId);
            
        }
        
        /// <summary>
        /// Test DestroyPrimaryScan
        /// </summary>
        [Fact]
        public void DestroyPrimaryScanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //instance.DestroyPrimaryScan(poolId);
            
        }
        
        /// <summary>
        /// Test IndexPools
        /// </summary>
        [Fact]
        public void IndexPoolsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //List<string> sortBy = null;
            //string id = null;
            //string name = null;
            //string comment = null;
            //string type = null;
            //string content = null;
            //string primaryId = null;
            //var response = instance.IndexPools(limit, offset, sortBy, id, name, comment, type, content, primaryId);
            //Assert.IsType<PoolCollection> (response, "response is PoolCollection");
        }
        
        /// <summary>
        /// Test MountPool
        /// </summary>
        [Fact]
        public void MountPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //var response = instance.MountPool(poolId);
            //Assert.IsType<MountStatus> (response, "response is MountStatus");
        }
        
        /// <summary>
        /// Test MountStatusPool
        /// </summary>
        [Fact]
        public void MountStatusPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //var response = instance.MountStatusPool(poolId);
            //Assert.IsType<MountStatus> (response, "response is MountStatus");
        }
        
        /// <summary>
        /// Test ShowPool
        /// </summary>
        [Fact]
        public void ShowPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //var response = instance.ShowPool(poolId);
            //Assert.IsType<Pool> (response, "response is Pool");
        }
        
        /// <summary>
        /// Test ShowPrimaryScan
        /// </summary>
        [Fact]
        public void ShowPrimaryScanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //var response = instance.ShowPrimaryScan(poolId);
            //Assert.IsType<PrimaryScan> (response, "response is PrimaryScan");
        }
        
        /// <summary>
        /// Test SyncPrimaryPool
        /// </summary>
        [Fact]
        public void SyncPrimaryPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //int tx = null;
            //instance.SyncPrimaryPool(poolId, tx);
            
        }
        
        /// <summary>
        /// Test UnmountPool
        /// </summary>
        [Fact]
        public void UnmountPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //var response = instance.UnmountPool(poolId);
            //Assert.IsType<MountStatus> (response, "response is MountStatus");
        }
        
        /// <summary>
        /// Test UpdatePool
        /// </summary>
        [Fact]
        public void UpdatePoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //PoolUp poolBody = null;
            //var response = instance.UpdatePool(poolId, poolBody);
            //Assert.IsType<Pool> (response, "response is Pool");
        }
        
        /// <summary>
        /// Test UpdatePrimaryScan
        /// </summary>
        [Fact]
        public void UpdatePrimaryScanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string poolId = null;
            //PrimaryScan primaryScanBody = null;
            //var response = instance.UpdatePrimaryScan(poolId, primaryScanBody);
            //Assert.IsType<PrimaryScan> (response, "response is PrimaryScan");
        }
        
    }

}