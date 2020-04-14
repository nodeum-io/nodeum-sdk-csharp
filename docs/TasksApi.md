# Io.Nodeum.Sdk.Api.TasksApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTask**](TasksApi.md#createtask) | **POST** /tasks | Creates a new task.
[**DestroyTask**](TasksApi.md#destroytask) | **DELETE** /tasks/{task_id} | Destroys a specific task.
[**IndexTasks**](TasksApi.md#indextasks) | **GET** /tasks | Lists all tasks.
[**PauseTask**](TasksApi.md#pausetask) | **PUT** /tasks/{task_id}/action/pause | Pause a task.
[**PauseTaskResult**](TasksApi.md#pausetaskresult) | **GET** /tasks/{task_id}/action/pause | Check result of a task pause request.
[**ResumeTask**](TasksApi.md#resumetask) | **PUT** /tasks/{task_id}/action/resume | Resume a task.
[**ResumeTaskResult**](TasksApi.md#resumetaskresult) | **GET** /tasks/{task_id}/action/resume | Check result of a task resume request.
[**RunTask**](TasksApi.md#runtask) | **PUT** /tasks/{task_id}/action/run | Run a task.
[**RunTaskResult**](TasksApi.md#runtaskresult) | **GET** /tasks/{task_id}/action/run | Check result of a task run request.
[**ShowTask**](TasksApi.md#showtask) | **GET** /tasks/{task_id} | Displays a specific task.
[**StopTask**](TasksApi.md#stoptask) | **PUT** /tasks/{task_id}/action/stop | Stop a task.
[**StopTaskResult**](TasksApi.md#stoptaskresult) | **GET** /tasks/{task_id}/action/stop | Check result of a task stop request.
[**UpdateTask**](TasksApi.md#updatetask) | **PUT** /tasks/{task_id} | Updates a specific task.


<a name="createtask"></a>
# **CreateTask**
> Task CreateTask (Task taskBody)

Creates a new task.

**API Key Scope**: tasks / create 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskBody = new Task(); // Task | 

            try
            {
                // Creates a new task.
                Task result = apiInstance.CreateTask(taskBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
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
 **taskBody** | [**Task**](Task.md)|  | 

### Return type

[**Task**](Task.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific task. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroytask"></a>
# **DestroyTask**
> void DestroyTask (string taskId)

Destroys a specific task.

**API Key Scope**: tasks / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.

            try
            {
                // Destroys a specific task.
                apiInstance.DestroyTask(taskId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DestroyTask: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Task destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextasks"></a>
# **IndexTasks**
> TaskCollection IndexTasks (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string comment = null, string workflowType = null, string workflowAction = null, string sourceType = null, string destinationType = null, string priority = null, string conflictResolution = null, string action = null, string activate = null, string creationDate = null, string creationUsername = null, string modificationDate = null, string modificationUsername = null, string jobStarted = null, string jobFinished = null, string status = null, string processedSize = null, string toProcessSize = null, string sourcePoolId = null, string sourcePoolName = null, string sourceTapeId = null, string sourceTapeBarcode = null, string destinationPoolId = null, string destinationPoolName = null, string destinationTapeId = null, string destinationTapeBarcode = null)

Lists all tasks.

**API Key Scope**: tasks / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTasksExample
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

            var apiInstance = new TasksApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var comment = comment_example;  // string | Filter on comment (optional) 
            var workflowType = workflowType_example;  // string | Filter on task workflow type (optional) 
            var workflowAction = workflowAction_example;  // string | Filter on task workflow action (optional) 
            var sourceType = sourceType_example;  // string | Filter on task source type (optional) 
            var destinationType = destinationType_example;  // string | Filter on task destination type (optional) 
            var priority = priority_example;  // string | Filter on priority (optional) 
            var conflictResolution = conflictResolution_example;  // string | Filter on conflict resolution (optional) 
            var action = action_example;  // string | Filter on action (optional) 
            var activate = activate_example;  // string | Filter on activate (optional) 
            var creationDate = creationDate_example;  // string | Filter on creation date (optional) 
            var creationUsername = creationUsername_example;  // string | Filter on creation username (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var modificationUsername = modificationUsername_example;  // string | Filter on modification username (optional) 
            var jobStarted = jobStarted_example;  // string | Filter on job started (optional) 
            var jobFinished = jobFinished_example;  // string | Filter on job finished (optional) 
            var status = status_example;  // string | Filter on status (optional) 
            var processedSize = processedSize_example;  // string | Filter on processed size (optional) 
            var toProcessSize = toProcessSize_example;  // string | Filter on to process size (optional) 
            var sourcePoolId = sourcePoolId_example;  // string | Filter on task source pool id (optional) 
            var sourcePoolName = sourcePoolName_example;  // string | Filter on task source pool name (optional) 
            var sourceTapeId = sourceTapeId_example;  // string | Filter on task source tape id (optional) 
            var sourceTapeBarcode = sourceTapeBarcode_example;  // string | Filter on task source tape barcode (optional) 
            var destinationPoolId = destinationPoolId_example;  // string | Filter on task destination pool id (optional) 
            var destinationPoolName = destinationPoolName_example;  // string | Filter on task destination pool name (optional) 
            var destinationTapeId = destinationTapeId_example;  // string | Filter on task destination tape id (optional) 
            var destinationTapeBarcode = destinationTapeBarcode_example;  // string | Filter on task destination tape barcode (optional) 

            try
            {
                // Lists all tasks.
                TaskCollection result = apiInstance.IndexTasks(limit, offset, sortBy, id, name, comment, workflowType, workflowAction, sourceType, destinationType, priority, conflictResolution, action, activate, creationDate, creationUsername, modificationDate, modificationUsername, jobStarted, jobFinished, status, processedSize, toProcessSize, sourcePoolId, sourcePoolName, sourceTapeId, sourceTapeBarcode, destinationPoolId, destinationPoolName, destinationTapeId, destinationTapeBarcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.IndexTasks: " + e.Message );
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
 **id** | **string**| Filter on id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **comment** | **string**| Filter on comment | [optional] 
 **workflowType** | **string**| Filter on task workflow type | [optional] 
 **workflowAction** | **string**| Filter on task workflow action | [optional] 
 **sourceType** | **string**| Filter on task source type | [optional] 
 **destinationType** | **string**| Filter on task destination type | [optional] 
 **priority** | **string**| Filter on priority | [optional] 
 **conflictResolution** | **string**| Filter on conflict resolution | [optional] 
 **action** | **string**| Filter on action | [optional] 
 **activate** | **string**| Filter on activate | [optional] 
 **creationDate** | **string**| Filter on creation date | [optional] 
 **creationUsername** | **string**| Filter on creation username | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **modificationUsername** | **string**| Filter on modification username | [optional] 
 **jobStarted** | **string**| Filter on job started | [optional] 
 **jobFinished** | **string**| Filter on job finished | [optional] 
 **status** | **string**| Filter on status | [optional] 
 **processedSize** | **string**| Filter on processed size | [optional] 
 **toProcessSize** | **string**| Filter on to process size | [optional] 
 **sourcePoolId** | **string**| Filter on task source pool id | [optional] 
 **sourcePoolName** | **string**| Filter on task source pool name | [optional] 
 **sourceTapeId** | **string**| Filter on task source tape id | [optional] 
 **sourceTapeBarcode** | **string**| Filter on task source tape barcode | [optional] 
 **destinationPoolId** | **string**| Filter on task destination pool id | [optional] 
 **destinationPoolName** | **string**| Filter on task destination pool name | [optional] 
 **destinationTapeId** | **string**| Filter on task destination tape id | [optional] 
 **destinationTapeBarcode** | **string**| Filter on task destination tape barcode | [optional] 

### Return type

[**TaskCollection**](TaskCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tasks. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pausetask"></a>
# **PauseTask**
> ActiveJobStatus PauseTask (string taskId)

Pause a task.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class PauseTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.

            try
            {
                // Pause a task.
                ActiveJobStatus result = apiInstance.PauseTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.PauseTask: " + e.Message );
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

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pausetaskresult"></a>
# **PauseTaskResult**
> ActiveJobStatus PauseTaskResult (string taskId, string jobId)

Check result of a task pause request.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class PauseTaskResultExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of a task pause request.
                ActiveJobStatus result = apiInstance.PauseTaskResult(taskId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.PauseTaskResult: " + e.Message );
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
 **jobId** | **string**| ID of active job | 

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An active job that may be queued, working, completed or failed. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resumetask"></a>
# **ResumeTask**
> ActiveJobStatus ResumeTask (string taskId)

Resume a task.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ResumeTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.

            try
            {
                // Resume a task.
                ActiveJobStatus result = apiInstance.ResumeTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ResumeTask: " + e.Message );
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

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resumetaskresult"></a>
# **ResumeTaskResult**
> ActiveJobStatus ResumeTaskResult (string taskId, string jobId)

Check result of a task resume request.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ResumeTaskResultExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of a task resume request.
                ActiveJobStatus result = apiInstance.ResumeTaskResult(taskId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ResumeTaskResult: " + e.Message );
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
 **jobId** | **string**| ID of active job | 

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An active job that may be queued, working, completed or failed. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runtask"></a>
# **RunTask**
> ActiveJobStatus RunTask (string taskId)

Run a task.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class RunTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.

            try
            {
                // Run a task.
                ActiveJobStatus result = apiInstance.RunTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RunTask: " + e.Message );
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

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runtaskresult"></a>
# **RunTaskResult**
> ActiveJobStatus RunTaskResult (string taskId, string jobId)

Check result of a task run request.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class RunTaskResultExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of a task run request.
                ActiveJobStatus result = apiInstance.RunTaskResult(taskId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RunTaskResult: " + e.Message );
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
 **jobId** | **string**| ID of active job | 

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An active job that may be queued, working, completed or failed. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtask"></a>
# **ShowTask**
> Task ShowTask (string taskId)

Displays a specific task.

**API Key Scope**: tasks / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.

            try
            {
                // Displays a specific task.
                Task result = apiInstance.ShowTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ShowTask: " + e.Message );
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

### Return type

[**Task**](Task.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stoptask"></a>
# **StopTask**
> ActiveJobStatus StopTask (string taskId)

Stop a task.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StopTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.

            try
            {
                // Stop a task.
                ActiveJobStatus result = apiInstance.StopTask(taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.StopTask: " + e.Message );
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

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stoptaskresult"></a>
# **StopTaskResult**
> ActiveJobStatus StopTaskResult (string taskId, string jobId)

Check result of a task stop request.

**API Key Scope**: tasks / action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StopTaskResultExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of a task stop request.
                ActiveJobStatus result = apiInstance.StopTaskResult(taskId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.StopTaskResult: " + e.Message );
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
 **jobId** | **string**| ID of active job | 

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An active job that may be queued, working, completed or failed. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> Task UpdateTask (string taskId, Task taskBody)

Updates a specific task.

**API Key Scope**: tasks / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateTaskExample
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

            var apiInstance = new TasksApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskBody = new Task(); // Task | 

            try
            {
                // Updates a specific task.
                Task result = apiInstance.UpdateTask(taskId, taskBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message );
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
 **taskBody** | [**Task**](Task.md)|  | 

### Return type

[**Task**](Task.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

