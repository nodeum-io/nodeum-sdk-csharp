# Io.Nodeum.Sdk.Api.TaskExecutionsApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IndexTaskExecutions**](TaskExecutionsApi.md#indextaskexecutions) | **GET** /task_executions | Lists all task executions.
[**IndexTaskExecutionsByTask**](TaskExecutionsApi.md#indextaskexecutionsbytask) | **GET** /tasks/{task_id}/task_executions | Lists all task executions.
[**ShowTaskExecution**](TaskExecutionsApi.md#showtaskexecution) | **GET** /task_executions/{task_execution_id} | Displays a specific task execution.
[**ShowTaskExecutionByTask**](TaskExecutionsApi.md#showtaskexecutionbytask) | **GET** /tasks/{task_id}/task_executions/{task_execution_id} | Displays a specific task execution.


<a name="indextaskexecutions"></a>
# **IndexTaskExecutions**
> TaskExecutionCollection IndexTaskExecutions (int? limit = null, int? offset = null, List<string> sortBy = null, bool? completeList = null, string id = null, string taskId = null, string name = null, string workflowType = null, string workflowAction = null, string sourceType = null, string destinationType = null, string status = null, string logTime = null, string jobStarted = null, string jobFinished = null, string creationDate = null, string modificationDate = null, string toProcessSize = null, string processedSize = null, string toProcessFiles = null, string processedFiles = null, string finalizedFiles = null, string estimationTime = null, string bandwidth = null)

Lists all task executions.

**API Key Scope**: task_executions / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTaskExecutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v2";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskExecutionsApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var completeList = true;  // bool? | If `false`, only includes the last correct execution of a task. (optional)  (default to true)
            var id = id_example;  // string | Filter on id (optional) 
            var taskId = taskId_example;  // string | Filter on task id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var workflowType = workflowType_example;  // string | Filter on task workflow type (optional) 
            var workflowAction = workflowAction_example;  // string | Filter on task workflow action (optional) 
            var sourceType = sourceType_example;  // string | Filter on task source type (optional) 
            var destinationType = destinationType_example;  // string | Filter on task destination type (optional) 
            var status = status_example;  // string | Filter on status (optional) 
            var logTime = logTime_example;  // string | Filter on log time (optional) 
            var jobStarted = jobStarted_example;  // string | Filter on job started (optional) 
            var jobFinished = jobFinished_example;  // string | Filter on job finished (optional) 
            var creationDate = creationDate_example;  // string | Filter on creation date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var toProcessSize = toProcessSize_example;  // string | Filter on to process size (optional) 
            var processedSize = processedSize_example;  // string | Filter on processed size (optional) 
            var toProcessFiles = toProcessFiles_example;  // string | Filter on to process files (optional) 
            var processedFiles = processedFiles_example;  // string | Filter on processed files (optional) 
            var finalizedFiles = finalizedFiles_example;  // string | Filter on finalized files (optional) 
            var estimationTime = estimationTime_example;  // string | Filter on estimation time (optional) 
            var bandwidth = bandwidth_example;  // string | Filter on bandwidth (optional) 

            try
            {
                // Lists all task executions.
                TaskExecutionCollection result = apiInstance.IndexTaskExecutions(limit, offset, sortBy, completeList, id, taskId, name, workflowType, workflowAction, sourceType, destinationType, status, logTime, jobStarted, jobFinished, creationDate, modificationDate, toProcessSize, processedSize, toProcessFiles, processedFiles, finalizedFiles, estimationTime, bandwidth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskExecutionsApi.IndexTaskExecutions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **completeList** | **bool?**| If &#x60;false&#x60;, only includes the last correct execution of a task. | [optional] [default to true]
 **id** | **string**| Filter on id | [optional] 
 **taskId** | **string**| Filter on task id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **workflowType** | **string**| Filter on task workflow type | [optional] 
 **workflowAction** | **string**| Filter on task workflow action | [optional] 
 **sourceType** | **string**| Filter on task source type | [optional] 
 **destinationType** | **string**| Filter on task destination type | [optional] 
 **status** | **string**| Filter on status | [optional] 
 **logTime** | **string**| Filter on log time | [optional] 
 **jobStarted** | **string**| Filter on job started | [optional] 
 **jobFinished** | **string**| Filter on job finished | [optional] 
 **creationDate** | **string**| Filter on creation date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **toProcessSize** | **string**| Filter on to process size | [optional] 
 **processedSize** | **string**| Filter on processed size | [optional] 
 **toProcessFiles** | **string**| Filter on to process files | [optional] 
 **processedFiles** | **string**| Filter on processed files | [optional] 
 **finalizedFiles** | **string**| Filter on finalized files | [optional] 
 **estimationTime** | **string**| Filter on estimation time | [optional] 
 **bandwidth** | **string**| Filter on bandwidth | [optional] 

### Return type

[**TaskExecutionCollection**](TaskExecutionCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of task executions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextaskexecutionsbytask"></a>
# **IndexTaskExecutionsByTask**
> TaskExecutionCollection IndexTaskExecutionsByTask (string taskId = null, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string workflowType = null, string workflowAction = null, string sourceType = null, string destinationType = null, string status = null, string logTime = null, string jobStarted = null, string jobFinished = null, string toProcessSize = null, string processedSize = null, string toProcessFiles = null, string processedFiles = null, string finalizedFiles = null, string estimationTime = null, string bandwidth = null)

Lists all task executions.

**API Key Scope**: task_executions / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTaskExecutionsByTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v2";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskExecutionsApi(config);
            var taskId = taskId_example;  // string | Filter on task id (optional) 
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var workflowType = workflowType_example;  // string | Filter on task workflow type (optional) 
            var workflowAction = workflowAction_example;  // string | Filter on task workflow action (optional) 
            var sourceType = sourceType_example;  // string | Filter on task source type (optional) 
            var destinationType = destinationType_example;  // string | Filter on task destination type (optional) 
            var status = status_example;  // string | Filter on status (optional) 
            var logTime = logTime_example;  // string | Filter on log time (optional) 
            var jobStarted = jobStarted_example;  // string | Filter on job started (optional) 
            var jobFinished = jobFinished_example;  // string | Filter on job finished (optional) 
            var toProcessSize = toProcessSize_example;  // string | Filter on to process size (optional) 
            var processedSize = processedSize_example;  // string | Filter on processed size (optional) 
            var toProcessFiles = toProcessFiles_example;  // string | Filter on to process files (optional) 
            var processedFiles = processedFiles_example;  // string | Filter on processed files (optional) 
            var finalizedFiles = finalizedFiles_example;  // string | Filter on finalized files (optional) 
            var estimationTime = estimationTime_example;  // string | Filter on estimation time (optional) 
            var bandwidth = bandwidth_example;  // string | Filter on bandwidth (optional) 

            try
            {
                // Lists all task executions.
                TaskExecutionCollection result = apiInstance.IndexTaskExecutionsByTask(taskId, limit, offset, sortBy, id, name, workflowType, workflowAction, sourceType, destinationType, status, logTime, jobStarted, jobFinished, toProcessSize, processedSize, toProcessFiles, processedFiles, finalizedFiles, estimationTime, bandwidth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskExecutionsApi.IndexTaskExecutionsByTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| Filter on task id | [optional] 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **id** | **string**| Filter on id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **workflowType** | **string**| Filter on task workflow type | [optional] 
 **workflowAction** | **string**| Filter on task workflow action | [optional] 
 **sourceType** | **string**| Filter on task source type | [optional] 
 **destinationType** | **string**| Filter on task destination type | [optional] 
 **status** | **string**| Filter on status | [optional] 
 **logTime** | **string**| Filter on log time | [optional] 
 **jobStarted** | **string**| Filter on job started | [optional] 
 **jobFinished** | **string**| Filter on job finished | [optional] 
 **toProcessSize** | **string**| Filter on to process size | [optional] 
 **processedSize** | **string**| Filter on processed size | [optional] 
 **toProcessFiles** | **string**| Filter on to process files | [optional] 
 **processedFiles** | **string**| Filter on processed files | [optional] 
 **finalizedFiles** | **string**| Filter on finalized files | [optional] 
 **estimationTime** | **string**| Filter on estimation time | [optional] 
 **bandwidth** | **string**| Filter on bandwidth | [optional] 

### Return type

[**TaskExecutionCollection**](TaskExecutionCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of task executions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtaskexecution"></a>
# **ShowTaskExecution**
> TaskExecution ShowTaskExecution (string taskExecutionId)

Displays a specific task execution.

**API Key Scope**: task_executions / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTaskExecutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v2";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskExecutionsApi(config);
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.

            try
            {
                // Displays a specific task execution.
                TaskExecution result = apiInstance.ShowTaskExecution(taskExecutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskExecutionsApi.ShowTaskExecution: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskExecutionId** | **string**| Numeric ID of task execution. | 

### Return type

[**TaskExecution**](TaskExecution.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task execution. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtaskexecutionbytask"></a>
# **ShowTaskExecutionByTask**
> TaskExecution ShowTaskExecutionByTask (string taskId, string taskExecutionId)

Displays a specific task execution.

**API Key Scope**: task_executions / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTaskExecutionByTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/api/v2";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TaskExecutionsApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.

            try
            {
                // Displays a specific task execution.
                TaskExecution result = apiInstance.ShowTaskExecutionByTask(taskId, taskExecutionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskExecutionsApi.ShowTaskExecutionByTask: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| Numeric ID or name of task. Task names are not unique, it&#39;s recommanded to use numeric ID. | 
 **taskExecutionId** | **string**| Numeric ID of task execution. | 

### Return type

[**TaskExecution**](TaskExecution.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task execution. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

