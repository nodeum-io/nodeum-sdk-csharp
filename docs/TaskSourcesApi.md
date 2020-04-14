# Io.Nodeum.Sdk.Api.TaskSourcesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTaskSource**](TaskSourcesApi.md#createtasksource) | **POST** /tasks/{task_id}/task_sources | Creates a new task source.
[**DestroyTaskSource**](TaskSourcesApi.md#destroytasksource) | **DELETE** /tasks/{task_id}/task_sources/{task_source_id} | Destroys a specific task source.
[**IndexTaskSources**](TaskSourcesApi.md#indextasksources) | **GET** /tasks/{task_id}/task_sources | Lists all task sources.
[**ShowTaskSource**](TaskSourcesApi.md#showtasksource) | **GET** /tasks/{task_id}/task_sources/{task_source_id} | Displays a specific task source.
[**UpdateTaskSource**](TaskSourcesApi.md#updatetasksource) | **PUT** /tasks/{task_id}/task_sources/{task_source_id} | Updates a specific task source.


<a name="createtasksource"></a>
# **CreateTaskSource**
> TaskSourceDown CreateTaskSource (string taskId, TaskSourceUp taskSourceBody)

Creates a new task source.

**API Key Scope**: task_sources / create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateTaskSourceExample
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

            var apiInstance = new TaskSourcesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskSourceBody = new TaskSourceUp(); // TaskSourceUp | 

            try
            {
                // Creates a new task source.
                TaskSourceDown result = apiInstance.CreateTaskSource(taskId, taskSourceBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskSourcesApi.CreateTaskSource: " + e.Message );
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
 **taskSourceBody** | [**TaskSourceUp**](TaskSourceUp.md)|  | 

### Return type

[**TaskSourceDown**](TaskSourceDown.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific task source. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroytasksource"></a>
# **DestroyTaskSource**
> void DestroyTaskSource (string taskId, int taskSourceId)

Destroys a specific task source.

**API Key Scope**: task_sources / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTaskSourceExample
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

            var apiInstance = new TaskSourcesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskSourceId = 56;  // int | Numeric ID of task source.

            try
            {
                // Destroys a specific task source.
                apiInstance.DestroyTaskSource(taskId, taskSourceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskSourcesApi.DestroyTaskSource: " + e.Message );
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
 **taskSourceId** | **int**| Numeric ID of task source. | 

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
| **204** | Task source destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextasksources"></a>
# **IndexTaskSources**
> TaskSourceCollection IndexTaskSources (string taskId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string fileId = null, string importFileId = null, string tapeId = null, string poolId = null)

Lists all task sources.

**API Key Scope**: task_sources / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTaskSourcesExample
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

            var apiInstance = new TaskSourcesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var importFileId = importFileId_example;  // string | Filter on import file id (optional) 
            var tapeId = tapeId_example;  // string | Filter on tape id (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 

            try
            {
                // Lists all task sources.
                TaskSourceCollection result = apiInstance.IndexTaskSources(taskId, limit, offset, sortBy, id, fileId, importFileId, tapeId, poolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskSourcesApi.IndexTaskSources: " + e.Message );
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
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **id** | **string**| Filter on id | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **importFileId** | **string**| Filter on import file id | [optional] 
 **tapeId** | **string**| Filter on tape id | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 

### Return type

[**TaskSourceCollection**](TaskSourceCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of task sources. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtasksource"></a>
# **ShowTaskSource**
> TaskSourceDown ShowTaskSource (string taskId, int taskSourceId)

Displays a specific task source.

**API Key Scope**: task_sources / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTaskSourceExample
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

            var apiInstance = new TaskSourcesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskSourceId = 56;  // int | Numeric ID of task source.

            try
            {
                // Displays a specific task source.
                TaskSourceDown result = apiInstance.ShowTaskSource(taskId, taskSourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskSourcesApi.ShowTaskSource: " + e.Message );
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
 **taskSourceId** | **int**| Numeric ID of task source. | 

### Return type

[**TaskSourceDown**](TaskSourceDown.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task source. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetasksource"></a>
# **UpdateTaskSource**
> TaskSourceDown UpdateTaskSource (string taskId, int taskSourceId, TaskSourceUp taskSourceBody)

Updates a specific task source.

**API Key Scope**: task_sources / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateTaskSourceExample
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

            var apiInstance = new TaskSourcesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskSourceId = 56;  // int | Numeric ID of task source.
            var taskSourceBody = new TaskSourceUp(); // TaskSourceUp | 

            try
            {
                // Updates a specific task source.
                TaskSourceDown result = apiInstance.UpdateTaskSource(taskId, taskSourceId, taskSourceBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskSourcesApi.UpdateTaskSource: " + e.Message );
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
 **taskSourceId** | **int**| Numeric ID of task source. | 
 **taskSourceBody** | [**TaskSourceUp**](TaskSourceUp.md)|  | 

### Return type

[**TaskSourceDown**](TaskSourceDown.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task source. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

