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
    ///  Class for testing TaskSchedulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaskSchedulesApiTests : IDisposable
    {
        private TaskSchedulesApi instance;

        public TaskSchedulesApiTests()
        {
            instance = new TaskSchedulesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TaskSchedulesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TaskSchedulesApi
            //Assert.IsType(typeof(TaskSchedulesApi), instance, "instance is a TaskSchedulesApi");
        }

        
        /// <summary>
        /// Test CreateTaskSchedule
        /// </summary>
        [Fact]
        public void CreateTaskScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //TaskSchedule taskScheduleBody = null;
            //var response = instance.CreateTaskSchedule(taskId, taskScheduleBody);
            //Assert.IsType<TaskSchedule> (response, "response is TaskSchedule");
        }
        
        /// <summary>
        /// Test DestroyTaskSchedule
        /// </summary>
        [Fact]
        public void DestroyTaskScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //instance.DestroyTaskSchedule(taskId);
            
        }
        
        /// <summary>
        /// Test IndexTaskSchedules
        /// </summary>
        [Fact]
        public void IndexTaskSchedulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? withNext = null;
            //int? limit = null;
            //int? offset = null;
            //List<string> sortBy = null;
            //string id = null;
            //string rrule = null;
            //string done = null;
            //string taskId = null;
            //var response = instance.IndexTaskSchedules(withNext, limit, offset, sortBy, id, rrule, done, taskId);
            //Assert.IsType<TaskScheduleCollection> (response, "response is TaskScheduleCollection");
        }
        
        /// <summary>
        /// Test ShowTaskSchedule
        /// </summary>
        [Fact]
        public void ShowTaskScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //var response = instance.ShowTaskSchedule(taskId);
            //Assert.IsType<TaskSchedule> (response, "response is TaskSchedule");
        }
        
        /// <summary>
        /// Test UpdateTaskSchedule
        /// </summary>
        [Fact]
        public void UpdateTaskScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //TaskSchedule taskScheduleBody = null;
            //var response = instance.UpdateTaskSchedule(taskId, taskScheduleBody);
            //Assert.IsType<TaskSchedule> (response, "response is TaskSchedule");
        }
        
    }

}
