# Io.Nodeum.Sdk.Api.TaskOptionsApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTaskOption**](TaskOptionsApi.md#createtaskoption) | **POST** /tasks/{task_id}/task_options | Creates a new task option.
[**DestroyTaskOption**](TaskOptionsApi.md#destroytaskoption) | **DELETE** /tasks/{task_id}/task_options/{task_option_id} | Destroys a specific task option.
[**IndexTaskOptions**](TaskOptionsApi.md#indextaskoptions) | **GET** /tasks/{task_id}/task_options | Lists all task options.
[**ShowTaskOption**](TaskOptionsApi.md#showtaskoption) | **GET** /tasks/{task_id}/task_options/{task_option_id} | Displays a specific task option.
[**UpdateTaskOption**](TaskOptionsApi.md#updatetaskoption) | **PUT** /tasks/{task_id}/task_options/{task_option_id} | Updates a specific task option.


<a name="createtaskoption"></a>
# **CreateTaskOption**
> TaskOption CreateTaskOption (string taskId, TaskOption taskOptionBody)

Creates a new task option.

**API Key Scope**: task_options / create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateTaskOptionExample
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

            var apiInstance = new TaskOptionsApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskOptionBody = new TaskOption(); // TaskOption | 

            try
            {
                // Creates a new task option.
                TaskOption result = apiInstance.CreateTaskOption(taskId, taskOptionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskOptionsApi.CreateTaskOption: " + e.Message );
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
 **taskOptionBody** | [**TaskOption**](TaskOption.md)|  | 

### Return type

[**TaskOption**](TaskOption.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific task option. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroytaskoption"></a>
# **DestroyTaskOption**
> void DestroyTaskOption (string taskId, int taskOptionId)

Destroys a specific task option.

**API Key Scope**: task_options / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTaskOptionExample
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

            var apiInstance = new TaskOptionsApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskOptionId = 56;  // int | Numeric ID of task option.

            try
            {
                // Destroys a specific task option.
                apiInstance.DestroyTaskOption(taskId, taskOptionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskOptionsApi.DestroyTaskOption: " + e.Message );
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
 **taskOptionId** | **int**| Numeric ID of task option. | 

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
| **204** | Task option destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextaskoptions"></a>
# **IndexTaskOptions**
> TaskOptionCollection IndexTaskOptions (string taskId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string type = null, string value = null)

Lists all task options.

**API Key Scope**: task_options / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTaskOptionsExample
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

            var apiInstance = new TaskOptionsApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var value = value_example;  // string | Filter on value (optional) 

            try
            {
                // Lists all task options.
                TaskOptionCollection result = apiInstance.IndexTaskOptions(taskId, limit, offset, sortBy, id, type, value);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskOptionsApi.IndexTaskOptions: " + e.Message );
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
 **type** | **string**| Filter on type | [optional] 
 **value** | **string**| Filter on value | [optional] 

### Return type

[**TaskOptionCollection**](TaskOptionCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of task options. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtaskoption"></a>
# **ShowTaskOption**
> TaskOption ShowTaskOption (string taskId, int taskOptionId)

Displays a specific task option.

**API Key Scope**: task_options / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTaskOptionExample
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

            var apiInstance = new TaskOptionsApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskOptionId = 56;  // int | Numeric ID of task option.

            try
            {
                // Displays a specific task option.
                TaskOption result = apiInstance.ShowTaskOption(taskId, taskOptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskOptionsApi.ShowTaskOption: " + e.Message );
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
 **taskOptionId** | **int**| Numeric ID of task option. | 

### Return type

[**TaskOption**](TaskOption.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task option. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskoption"></a>
# **UpdateTaskOption**
> TaskOption UpdateTaskOption (string taskId, int taskOptionId, TaskOption taskOptionBody)

Updates a specific task option.

**API Key Scope**: task_options / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateTaskOptionExample
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

            var apiInstance = new TaskOptionsApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskOptionId = 56;  // int | Numeric ID of task option.
            var taskOptionBody = new TaskOption(); // TaskOption | 

            try
            {
                // Updates a specific task option.
                TaskOption result = apiInstance.UpdateTaskOption(taskId, taskOptionId, taskOptionBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskOptionsApi.UpdateTaskOption: " + e.Message );
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
 **taskOptionId** | **int**| Numeric ID of task option. | 
 **taskOptionBody** | [**TaskOption**](TaskOption.md)|  | 

### Return type

[**TaskOption**](TaskOption.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task option. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

