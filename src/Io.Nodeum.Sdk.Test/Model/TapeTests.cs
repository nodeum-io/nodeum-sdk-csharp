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
    ///  Class for testing Tape
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TapeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Tape
        //private Tape instance;

        public TapeTests()
        {
            // TODO uncomment below to create an instance of Tape
            //instance = new Tape();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Tape
        /// </summary>
        [Fact]
        public void TapeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Tape
            //Assert.IsInstanceOfType<Tape> (instance, "variable 'instance' is a Tape");
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
        /// Test the property 'TapeLibraryId'
        /// </summary>
        [Fact]
        public void TapeLibraryIdTest()
        {
            // TODO unit test for the property 'TapeLibraryId'
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
        /// Test the property 'Barcode'
        /// </summary>
        [Fact]
        public void BarcodeTest()
        {
            // TODO unit test for the property 'Barcode'
        }
        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Locked'
        /// </summary>
        [Fact]
        public void LockedTest()
        {
            // TODO unit test for the property 'Locked'
        }
        /// <summary>
        /// Test the property 'Scratch'
        /// </summary>
        [Fact]
        public void ScratchTest()
        {
            // TODO unit test for the property 'Scratch'
        }
        /// <summary>
        /// Test the property 'Cleaning'
        /// </summary>
        [Fact]
        public void CleaningTest()
        {
            // TODO unit test for the property 'Cleaning'
        }
        /// <summary>
        /// Test the property 'WriteProtect'
        /// </summary>
        [Fact]
        public void WriteProtectTest()
        {
            // TODO unit test for the property 'WriteProtect'
        }
        /// <summary>
        /// Test the property 'Mounted'
        /// </summary>
        [Fact]
        public void MountedTest()
        {
            // TODO unit test for the property 'Mounted'
        }
        /// <summary>
        /// Test the property 'Ejected'
        /// </summary>
        [Fact]
        public void EjectedTest()
        {
            // TODO unit test for the property 'Ejected'
        }
        /// <summary>
        /// Test the property 'Known'
        /// </summary>
        [Fact]
        public void KnownTest()
        {
            // TODO unit test for the property 'Known'
        }
        /// <summary>
        /// Test the property 'MountCount'
        /// </summary>
        [Fact]
        public void MountCountTest()
        {
            // TODO unit test for the property 'MountCount'
        }
        /// <summary>
        /// Test the property 'DateIn'
        /// </summary>
        [Fact]
        public void DateInTest()
        {
            // TODO unit test for the property 'DateIn'
        }
        /// <summary>
        /// Test the property 'DateMove'
        /// </summary>
        [Fact]
        public void DateMoveTest()
        {
            // TODO unit test for the property 'DateMove'
        }
        /// <summary>
        /// Test the property 'Free'
        /// </summary>
        [Fact]
        public void FreeTest()
        {
            // TODO unit test for the property 'Free'
        }
        /// <summary>
        /// Test the property 'Max'
        /// </summary>
        [Fact]
        public void MaxTest()
        {
            // TODO unit test for the property 'Max'
        }
        /// <summary>
        /// Test the property 'LastSizeUpdate'
        /// </summary>
        [Fact]
        public void LastSizeUpdateTest()
        {
            // TODO unit test for the property 'LastSizeUpdate'
        }
        /// <summary>
        /// Test the property 'LastMaintenance'
        /// </summary>
        [Fact]
        public void LastMaintenanceTest()
        {
            // TODO unit test for the property 'LastMaintenance'
        }
        /// <summary>
        /// Test the property 'LastRepack'
        /// </summary>
        [Fact]
        public void LastRepackTest()
        {
            // TODO unit test for the property 'LastRepack'
        }
        /// <summary>
        /// Test the property 'RepackStatus'
        /// </summary>
        [Fact]
        public void RepackStatusTest()
        {
            // TODO unit test for the property 'RepackStatus'
        }
        /// <summary>
        /// Test the property 'Hash'
        /// </summary>
        [Fact]
        public void HashTest()
        {
            // TODO unit test for the property 'Hash'
        }
        /// <summary>
        /// Test the property 'ForceImportType'
        /// </summary>
        [Fact]
        public void ForceImportTypeTest()
        {
            // TODO unit test for the property 'ForceImportType'
        }
        /// <summary>
        /// Test the property 'NeedToCheck'
        /// </summary>
        [Fact]
        public void NeedToCheckTest()
        {
            // TODO unit test for the property 'NeedToCheck'
        }

    }

}
