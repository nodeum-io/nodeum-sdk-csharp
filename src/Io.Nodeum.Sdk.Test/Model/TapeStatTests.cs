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
    ///  Class for testing TapeStat
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TapeStatTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TapeStat
        //private TapeStat instance;

        public TapeStatTests()
        {
            // TODO uncomment below to create an instance of TapeStat
            //instance = new TapeStat();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TapeStat
        /// </summary>
        [Fact]
        public void TapeStatInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TapeStat
            //Assert.IsInstanceOfType<TapeStat> (instance, "variable 'instance' is a TapeStat");
        }


        /// <summary>
        /// Test the property 'LogTime'
        /// </summary>
        [Fact]
        public void LogTimeTest()
        {
            // TODO unit test for the property 'LogTime'
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
        /// Test the property 'Mounts'
        /// </summary>
        [Fact]
        public void MountsTest()
        {
            // TODO unit test for the property 'Mounts'
        }
        /// <summary>
        /// Test the property 'DatasetsWritten'
        /// </summary>
        [Fact]
        public void DatasetsWrittenTest()
        {
            // TODO unit test for the property 'DatasetsWritten'
        }
        /// <summary>
        /// Test the property 'DatasetsRead'
        /// </summary>
        [Fact]
        public void DatasetsReadTest()
        {
            // TODO unit test for the property 'DatasetsRead'
        }
        /// <summary>
        /// Test the property 'RecoveredWriteDataErrors'
        /// </summary>
        [Fact]
        public void RecoveredWriteDataErrorsTest()
        {
            // TODO unit test for the property 'RecoveredWriteDataErrors'
        }
        /// <summary>
        /// Test the property 'UnrecoveredWriteDataErrors'
        /// </summary>
        [Fact]
        public void UnrecoveredWriteDataErrorsTest()
        {
            // TODO unit test for the property 'UnrecoveredWriteDataErrors'
        }
        /// <summary>
        /// Test the property 'WriteServoErrors'
        /// </summary>
        [Fact]
        public void WriteServoErrorsTest()
        {
            // TODO unit test for the property 'WriteServoErrors'
        }
        /// <summary>
        /// Test the property 'UnrecoveredWriteServoErrors'
        /// </summary>
        [Fact]
        public void UnrecoveredWriteServoErrorsTest()
        {
            // TODO unit test for the property 'UnrecoveredWriteServoErrors'
        }
        /// <summary>
        /// Test the property 'RecoveredReadErrors'
        /// </summary>
        [Fact]
        public void RecoveredReadErrorsTest()
        {
            // TODO unit test for the property 'RecoveredReadErrors'
        }
        /// <summary>
        /// Test the property 'UnrecoveredReadErrors'
        /// </summary>
        [Fact]
        public void UnrecoveredReadErrorsTest()
        {
            // TODO unit test for the property 'UnrecoveredReadErrors'
        }
        /// <summary>
        /// Test the property 'LastMountUnrecoveredWriteErrors'
        /// </summary>
        [Fact]
        public void LastMountUnrecoveredWriteErrorsTest()
        {
            // TODO unit test for the property 'LastMountUnrecoveredWriteErrors'
        }
        /// <summary>
        /// Test the property 'LastMountUnrecoveredReadErrors'
        /// </summary>
        [Fact]
        public void LastMountUnrecoveredReadErrorsTest()
        {
            // TODO unit test for the property 'LastMountUnrecoveredReadErrors'
        }
        /// <summary>
        /// Test the property 'LastMountMbytesWritten'
        /// </summary>
        [Fact]
        public void LastMountMbytesWrittenTest()
        {
            // TODO unit test for the property 'LastMountMbytesWritten'
        }
        /// <summary>
        /// Test the property 'LastMountMbytesRead'
        /// </summary>
        [Fact]
        public void LastMountMbytesReadTest()
        {
            // TODO unit test for the property 'LastMountMbytesRead'
        }
        /// <summary>
        /// Test the property 'LifetimeMbytesWritten'
        /// </summary>
        [Fact]
        public void LifetimeMbytesWrittenTest()
        {
            // TODO unit test for the property 'LifetimeMbytesWritten'
        }
        /// <summary>
        /// Test the property 'LifetimeMbytesRead'
        /// </summary>
        [Fact]
        public void LifetimeMbytesReadTest()
        {
            // TODO unit test for the property 'LifetimeMbytesRead'
        }
        /// <summary>
        /// Test the property 'LastLoadWriteCompressionRatio'
        /// </summary>
        [Fact]
        public void LastLoadWriteCompressionRatioTest()
        {
            // TODO unit test for the property 'LastLoadWriteCompressionRatio'
        }
        /// <summary>
        /// Test the property 'LastLoadReadCompressionRatio'
        /// </summary>
        [Fact]
        public void LastLoadReadCompressionRatioTest()
        {
            // TODO unit test for the property 'LastLoadReadCompressionRatio'
        }
        /// <summary>
        /// Test the property 'MediumMountTime'
        /// </summary>
        [Fact]
        public void MediumMountTimeTest()
        {
            // TODO unit test for the property 'MediumMountTime'
        }
        /// <summary>
        /// Test the property 'MediumReadyTime'
        /// </summary>
        [Fact]
        public void MediumReadyTimeTest()
        {
            // TODO unit test for the property 'MediumReadyTime'
        }
        /// <summary>
        /// Test the property 'TotalNativeCapacity'
        /// </summary>
        [Fact]
        public void TotalNativeCapacityTest()
        {
            // TODO unit test for the property 'TotalNativeCapacity'
        }
        /// <summary>
        /// Test the property 'TotalUsedNativeCapacity'
        /// </summary>
        [Fact]
        public void TotalUsedNativeCapacityTest()
        {
            // TODO unit test for the property 'TotalUsedNativeCapacity'
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
        /// Test the property 'Worm'
        /// </summary>
        [Fact]
        public void WormTest()
        {
            // TODO unit test for the property 'Worm'
        }
        /// <summary>
        /// Test the property 'BeginningOfMediumPasses'
        /// </summary>
        [Fact]
        public void BeginningOfMediumPassesTest()
        {
            // TODO unit test for the property 'BeginningOfMediumPasses'
        }
        /// <summary>
        /// Test the property 'MiddleOfTapePasses'
        /// </summary>
        [Fact]
        public void MiddleOfTapePassesTest()
        {
            // TODO unit test for the property 'MiddleOfTapePasses'
        }
        /// <summary>
        /// Test the property 'ReadCompressionRatio'
        /// </summary>
        [Fact]
        public void ReadCompressionRatioTest()
        {
            // TODO unit test for the property 'ReadCompressionRatio'
        }
        /// <summary>
        /// Test the property 'WriteCompressionRatio'
        /// </summary>
        [Fact]
        public void WriteCompressionRatioTest()
        {
            // TODO unit test for the property 'WriteCompressionRatio'
        }
        /// <summary>
        /// Test the property 'MbytesTransferredToAppClient'
        /// </summary>
        [Fact]
        public void MbytesTransferredToAppClientTest()
        {
            // TODO unit test for the property 'MbytesTransferredToAppClient'
        }
        /// <summary>
        /// Test the property 'BytesTransferredToAppClient'
        /// </summary>
        [Fact]
        public void BytesTransferredToAppClientTest()
        {
            // TODO unit test for the property 'BytesTransferredToAppClient'
        }
        /// <summary>
        /// Test the property 'MbytesReadFromMedium'
        /// </summary>
        [Fact]
        public void MbytesReadFromMediumTest()
        {
            // TODO unit test for the property 'MbytesReadFromMedium'
        }
        /// <summary>
        /// Test the property 'BytesReadFromMedium'
        /// </summary>
        [Fact]
        public void BytesReadFromMediumTest()
        {
            // TODO unit test for the property 'BytesReadFromMedium'
        }
        /// <summary>
        /// Test the property 'MbytesTransferredFromAppClient'
        /// </summary>
        [Fact]
        public void MbytesTransferredFromAppClientTest()
        {
            // TODO unit test for the property 'MbytesTransferredFromAppClient'
        }
        /// <summary>
        /// Test the property 'BytesTransferredFromAppClient'
        /// </summary>
        [Fact]
        public void BytesTransferredFromAppClientTest()
        {
            // TODO unit test for the property 'BytesTransferredFromAppClient'
        }
        /// <summary>
        /// Test the property 'MbytesWrittenToMedium'
        /// </summary>
        [Fact]
        public void MbytesWrittenToMediumTest()
        {
            // TODO unit test for the property 'MbytesWrittenToMedium'
        }
        /// <summary>
        /// Test the property 'BytesWrittenToMedium'
        /// </summary>
        [Fact]
        public void BytesWrittenToMediumTest()
        {
            // TODO unit test for the property 'BytesWrittenToMedium'
        }
        /// <summary>
        /// Test the property 'DataCompressionEnabled'
        /// </summary>
        [Fact]
        public void DataCompressionEnabledTest()
        {
            // TODO unit test for the property 'DataCompressionEnabled'
        }
        /// <summary>
        /// Test the property 'WriteRetries'
        /// </summary>
        [Fact]
        public void WriteRetriesTest()
        {
            // TODO unit test for the property 'WriteRetries'
        }
        /// <summary>
        /// Test the property 'WritePerms'
        /// </summary>
        [Fact]
        public void WritePermsTest()
        {
            // TODO unit test for the property 'WritePerms'
        }
        /// <summary>
        /// Test the property 'SuspendedWrites'
        /// </summary>
        [Fact]
        public void SuspendedWritesTest()
        {
            // TODO unit test for the property 'SuspendedWrites'
        }
        /// <summary>
        /// Test the property 'FatalSuspendedWrites'
        /// </summary>
        [Fact]
        public void FatalSuspendedWritesTest()
        {
            // TODO unit test for the property 'FatalSuspendedWrites'
        }
        /// <summary>
        /// Test the property 'ReadRetries'
        /// </summary>
        [Fact]
        public void ReadRetriesTest()
        {
            // TODO unit test for the property 'ReadRetries'
        }
        /// <summary>
        /// Test the property 'ReadPerms'
        /// </summary>
        [Fact]
        public void ReadPermsTest()
        {
            // TODO unit test for the property 'ReadPerms'
        }
        /// <summary>
        /// Test the property 'SuspendedReads'
        /// </summary>
        [Fact]
        public void SuspendedReadsTest()
        {
            // TODO unit test for the property 'SuspendedReads'
        }
        /// <summary>
        /// Test the property 'FatalSuspendedReads'
        /// </summary>
        [Fact]
        public void FatalSuspendedReadsTest()
        {
            // TODO unit test for the property 'FatalSuspendedReads'
        }
        /// <summary>
        /// Test the property 'Partition0RemainingCapacity'
        /// </summary>
        [Fact]
        public void Partition0RemainingCapacityTest()
        {
            // TODO unit test for the property 'Partition0RemainingCapacity'
        }
        /// <summary>
        /// Test the property 'Partition1RemainingCapacity'
        /// </summary>
        [Fact]
        public void Partition1RemainingCapacityTest()
        {
            // TODO unit test for the property 'Partition1RemainingCapacity'
        }
        /// <summary>
        /// Test the property 'Partition0MaximumCapacity'
        /// </summary>
        [Fact]
        public void Partition0MaximumCapacityTest()
        {
            // TODO unit test for the property 'Partition0MaximumCapacity'
        }
        /// <summary>
        /// Test the property 'Partition1MaximumCapacity'
        /// </summary>
        [Fact]
        public void Partition1MaximumCapacityTest()
        {
            // TODO unit test for the property 'Partition1MaximumCapacity'
        }

    }

}
