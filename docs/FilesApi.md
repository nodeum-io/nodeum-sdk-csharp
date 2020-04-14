# Io.Nodeum.Sdk.Api.FilesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilesChildren**](FilesApi.md#fileschildren) | **GET** /files/{file_parent_id}/children | Lists files under a specific folder.
[**FilesChildrenByContainer**](FilesApi.md#fileschildrenbycontainer) | **GET** /containers/{container_id}/files/{file_parent_id}/children | Lists files under a specific folder.
[**FilesChildrenByPool**](FilesApi.md#fileschildrenbypool) | **GET** /pools/{pool_id}/files/{file_parent_id}/children | Lists files under a specific folder.
[**FilesChildrenByTask**](FilesApi.md#fileschildrenbytask) | **GET** /tasks/{task_id}/files/{file_parent_id}/children | Lists files under a specific folder.
[**FilesChildrenByTaskExecution**](FilesApi.md#fileschildrenbytaskexecution) | **GET** /task_executions/{task_execution_id}/files/{file_parent_id}/children | Lists files under a specific folder.
[**FilesChildrenByTaskExecutionByTask**](FilesApi.md#fileschildrenbytaskexecutionbytask) | **GET** /tasks/{task_id}/task_executions/{task_execution_id}/files/{file_parent_id}/children | Lists files under a specific folder.
[**ImportFilesChildrenByPool**](FilesApi.md#importfileschildrenbypool) | **GET** /pools/{pool_id}/import_files/{file_parent_id}/children | Lists files under a specific folder on tape of pools, specific for Data Exchange.
[**IndexFiles**](FilesApi.md#indexfiles) | **GET** /files | Lists files on root.
[**IndexFilesByContainer**](FilesApi.md#indexfilesbycontainer) | **GET** /containers/{container_id}/files | Lists files on root.
[**IndexFilesByPool**](FilesApi.md#indexfilesbypool) | **GET** /pools/{pool_id}/files | Lists files on root.
[**IndexFilesByTask**](FilesApi.md#indexfilesbytask) | **GET** /tasks/{task_id}/files | Lists files on root.
[**IndexFilesByTaskExecution**](FilesApi.md#indexfilesbytaskexecution) | **GET** /task_executions/{task_execution_id}/files | Lists files on root.
[**IndexFilesByTaskExecutionByTask**](FilesApi.md#indexfilesbytaskexecutionbytask) | **GET** /tasks/{task_id}/task_executions/{task_execution_id}/files | Lists files on root.
[**IndexImportFilesByPool**](FilesApi.md#indeximportfilesbypool) | **GET** /pools/{pool_id}/import_files | Lists files on root of tape of pools, specific for Data Exchange.
[**IndexOnTapesFilesByPool**](FilesApi.md#indexontapesfilesbypool) | **GET** /pools/{pool_id}/on_tapes_files | Lists files on root of tape of pools, specific for Active and Offline.
[**IndexTapesByFileByPool**](FilesApi.md#indextapesbyfilebypool) | **GET** /pools/{pool_id}/files/{file_id}/tapes | Displays tapes containing specific file, related to the specific pool.
[**IndexTapesByFileByTask**](FilesApi.md#indextapesbyfilebytask) | **GET** /tasks/{task_id}/files/{file_id}/tapes | Displays tapes containing specific file, related to the specific task.
[**IndexTapesByFileByTaskExecution**](FilesApi.md#indextapesbyfilebytaskexecution) | **GET** /task_executions/{task_execution_id}/files/{file_id}/tapes | Displays tapes containing specific file, related to the specific task.
[**IndexTapesByFileByTaskExecutionByTask**](FilesApi.md#indextapesbyfilebytaskexecutionbytask) | **GET** /tasks/{task_id}/task_executions/{task_execution_id}/files/{file_id}/tapes | Displays tapes containing specific file, related to the specific task.
[**OnTapesFilesChildrenByPool**](FilesApi.md#ontapesfileschildrenbypool) | **GET** /pools/{pool_id}/on_tapes_files/{file_parent_id}/children | Lists files under a specific folder on tape of pools, specific for Active and Offline.
[**ShowFile**](FilesApi.md#showfile) | **GET** /files/{file_id} | Displays a specific file.
[**ShowFileByContainer**](FilesApi.md#showfilebycontainer) | **GET** /containers/{container_id}/files/{file_id} | Displays a specific file.
[**ShowFileByPool**](FilesApi.md#showfilebypool) | **GET** /pools/{pool_id}/files/{file_id} | Displays a specific file.
[**ShowFileByTask**](FilesApi.md#showfilebytask) | **GET** /tasks/{task_id}/files/{file_id} | Displays a specific file.
[**ShowFileByTaskExecution**](FilesApi.md#showfilebytaskexecution) | **GET** /task_executions/{task_execution_id}/files/{file_id} | Displays a specific file.
[**ShowFileByTaskExecutionByTask**](FilesApi.md#showfilebytaskexecutionbytask) | **GET** /tasks/{task_id}/task_executions/{task_execution_id}/files/{file_id} | Displays a specific file.
[**ShowImportFileByPool**](FilesApi.md#showimportfilebypool) | **GET** /pools/{pool_id}/import_files/{file_id} | Displays a specific file on tape of pools, specific for Data Exchange.
[**ShowOnTapeFileByPool**](FilesApi.md#showontapefilebypool) | **GET** /pools/{pool_id}/on_tapes_files/{file_id} | Displays a specific file on tape of pools, specific for Active and Offline.


<a name="fileschildren"></a>
# **FilesChildren**
> NodeumFileCollection FilesChildren (int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class FilesChildrenExample
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

            var apiInstance = new FilesApi(config);
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder.
                NodeumFileCollection result = apiInstance.FilesChildren(fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesChildren: " + e.Message );
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
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileschildrenbycontainer"></a>
# **FilesChildrenByContainer**
> NodeumFileCollection FilesChildrenByContainer (string containerId, int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class FilesChildrenByContainerExample
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

            var apiInstance = new FilesApi(config);
            var containerId = containerId_example;  // string | Numeric ID or name of container.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder.
                NodeumFileCollection result = apiInstance.FilesChildrenByContainer(containerId, fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesChildrenByContainer: " + e.Message );
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
 **containerId** | **string**| Numeric ID or name of container. | 
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileschildrenbypool"></a>
# **FilesChildrenByPool**
> NodeumFileCollection FilesChildrenByPool (string poolId, int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class FilesChildrenByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder.
                NodeumFileCollection result = apiInstance.FilesChildrenByPool(poolId, fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesChildrenByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileschildrenbytask"></a>
# **FilesChildrenByTask**
> NodeumFileCollection FilesChildrenByTask (string taskId, int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class FilesChildrenByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder.
                NodeumFileCollection result = apiInstance.FilesChildrenByTask(taskId, fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesChildrenByTask: " + e.Message );
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
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileschildrenbytaskexecution"></a>
# **FilesChildrenByTaskExecution**
> NodeumFileCollection FilesChildrenByTaskExecution (string taskExecutionId, int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class FilesChildrenByTaskExecutionExample
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

            var apiInstance = new FilesApi(config);
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder.
                NodeumFileCollection result = apiInstance.FilesChildrenByTaskExecution(taskExecutionId, fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesChildrenByTaskExecution: " + e.Message );
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
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileschildrenbytaskexecutionbytask"></a>
# **FilesChildrenByTaskExecutionByTask**
> NodeumFileCollection FilesChildrenByTaskExecutionByTask (string taskId, string taskExecutionId, int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class FilesChildrenByTaskExecutionByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder.
                NodeumFileCollection result = apiInstance.FilesChildrenByTaskExecutionByTask(taskId, taskExecutionId, fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesChildrenByTaskExecutionByTask: " + e.Message );
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
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importfileschildrenbypool"></a>
# **ImportFilesChildrenByPool**
> ImportFileCollection ImportFilesChildrenByPool (string poolId, int fileParentId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files under a specific folder on tape of pools, specific for Data Exchange.

**API Key Scope**: import_files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ImportFilesChildrenByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files under a specific folder on tape of pools, specific for Data Exchange.
                ImportFileCollection result = apiInstance.ImportFilesChildrenByPool(poolId, fileParentId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ImportFilesChildrenByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**ImportFileCollection**](ImportFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of imported files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexfiles"></a>
# **IndexFiles**
> NodeumFileCollection IndexFiles (int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFilesExample
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

            var apiInstance = new FilesApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root.
                NodeumFileCollection result = apiInstance.IndexFiles(limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexFiles: " + e.Message );
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
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexfilesbycontainer"></a>
# **IndexFilesByContainer**
> NodeumFileCollection IndexFilesByContainer (string containerId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFilesByContainerExample
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

            var apiInstance = new FilesApi(config);
            var containerId = containerId_example;  // string | Numeric ID or name of container.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root.
                NodeumFileCollection result = apiInstance.IndexFilesByContainer(containerId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexFilesByContainer: " + e.Message );
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
 **containerId** | **string**| Numeric ID or name of container. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexfilesbypool"></a>
# **IndexFilesByPool**
> NodeumFileCollection IndexFilesByPool (string poolId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFilesByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root.
                NodeumFileCollection result = apiInstance.IndexFilesByPool(poolId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexFilesByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexfilesbytask"></a>
# **IndexFilesByTask**
> NodeumFileCollection IndexFilesByTask (string taskId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFilesByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root.
                NodeumFileCollection result = apiInstance.IndexFilesByTask(taskId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexFilesByTask: " + e.Message );
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
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexfilesbytaskexecution"></a>
# **IndexFilesByTaskExecution**
> NodeumFileCollection IndexFilesByTaskExecution (string taskExecutionId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFilesByTaskExecutionExample
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

            var apiInstance = new FilesApi(config);
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root.
                NodeumFileCollection result = apiInstance.IndexFilesByTaskExecution(taskExecutionId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexFilesByTaskExecution: " + e.Message );
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
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexfilesbytaskexecutionbytask"></a>
# **IndexFilesByTaskExecutionByTask**
> NodeumFileCollection IndexFilesByTaskExecutionByTask (string taskId, string taskExecutionId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root.

**API Key Scope**: files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFilesByTaskExecutionByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root.
                NodeumFileCollection result = apiInstance.IndexFilesByTaskExecutionByTask(taskId, taskExecutionId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexFilesByTaskExecutionByTask: " + e.Message );
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
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**NodeumFileCollection**](NodeumFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indeximportfilesbypool"></a>
# **IndexImportFilesByPool**
> ImportFileCollection IndexImportFilesByPool (string poolId, int? limit = null, int? offset = null, string fileId = null, string name = null, string type = null, string permission = null, string size = null, string changeDate = null, string modificationDate = null, string accessDate = null, string gid = null, string uid = null)

Lists files on root of tape of pools, specific for Data Exchange.

**API Key Scope**: import_files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexImportFilesByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var fileId = fileId_example;  // string | Filter on file id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var permission = permission_example;  // string | Filter on permission (optional) 
            var size = size_example;  // string | Filter on size (optional) 
            var changeDate = changeDate_example;  // string | Filter on change date (optional) 
            var modificationDate = modificationDate_example;  // string | Filter on modification date (optional) 
            var accessDate = accessDate_example;  // string | Filter on access date (optional) 
            var gid = gid_example;  // string | Filter on gid (optional) 
            var uid = uid_example;  // string | Filter on uid (optional) 

            try
            {
                // Lists files on root of tape of pools, specific for Data Exchange.
                ImportFileCollection result = apiInstance.IndexImportFilesByPool(poolId, limit, offset, fileId, name, type, permission, size, changeDate, modificationDate, accessDate, gid, uid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexImportFilesByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **fileId** | **string**| Filter on file id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **permission** | **string**| Filter on permission | [optional] 
 **size** | **string**| Filter on size | [optional] 
 **changeDate** | **string**| Filter on change date | [optional] 
 **modificationDate** | **string**| Filter on modification date | [optional] 
 **accessDate** | **string**| Filter on access date | [optional] 
 **gid** | **string**| Filter on gid | [optional] 
 **uid** | **string**| Filter on uid | [optional] 

### Return type

[**ImportFileCollection**](ImportFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of imported files. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexontapesfilesbypool"></a>
# **IndexOnTapesFilesByPool**
> OnTapesFileCollection IndexOnTapesFilesByPool (string poolId, int? limit = null, int? offset = null, string name = null, string type = null, string size = null)

Lists files on root of tape of pools, specific for Active and Offline.

**API Key Scope**: on_tapes_files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexOnTapesFilesByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var size = size_example;  // string | Filter on size (optional) 

            try
            {
                // Lists files on root of tape of pools, specific for Active and Offline.
                OnTapesFileCollection result = apiInstance.IndexOnTapesFilesByPool(poolId, limit, offset, name, type, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexOnTapesFilesByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **size** | **string**| Filter on size | [optional] 

### Return type

[**OnTapesFileCollection**](OnTapesFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files on tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapesbyfilebypool"></a>
# **IndexTapesByFileByPool**
> TapeCollection IndexTapesByFileByPool (string poolId, int fileId)

Displays tapes containing specific file, related to the specific pool.

**API Key Scope**: files / tapes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesByFileByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays tapes containing specific file, related to the specific pool.
                TapeCollection result = apiInstance.IndexTapesByFileByPool(poolId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexTapesByFileByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**TapeCollection**](TapeCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapesbyfilebytask"></a>
# **IndexTapesByFileByTask**
> TapeCollection IndexTapesByFileByTask (string taskId, int fileId)

Displays tapes containing specific file, related to the specific task.

**API Key Scope**: files / tapes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesByFileByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays tapes containing specific file, related to the specific task.
                TapeCollection result = apiInstance.IndexTapesByFileByTask(taskId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexTapesByFileByTask: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**TapeCollection**](TapeCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapesbyfilebytaskexecution"></a>
# **IndexTapesByFileByTaskExecution**
> TapeCollection IndexTapesByFileByTaskExecution (string taskExecutionId, int fileId)

Displays tapes containing specific file, related to the specific task.

**API Key Scope**: files / tapes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesByFileByTaskExecutionExample
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

            var apiInstance = new FilesApi(config);
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays tapes containing specific file, related to the specific task.
                TapeCollection result = apiInstance.IndexTapesByFileByTaskExecution(taskExecutionId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexTapesByFileByTaskExecution: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**TapeCollection**](TapeCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapesbyfilebytaskexecutionbytask"></a>
# **IndexTapesByFileByTaskExecutionByTask**
> TapeCollection IndexTapesByFileByTaskExecutionByTask (string taskId, string taskExecutionId, int fileId)

Displays tapes containing specific file, related to the specific task.

**API Key Scope**: files / tapes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesByFileByTaskExecutionByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays tapes containing specific file, related to the specific task.
                TapeCollection result = apiInstance.IndexTapesByFileByTaskExecutionByTask(taskId, taskExecutionId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.IndexTapesByFileByTaskExecutionByTask: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**TapeCollection**](TapeCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ontapesfileschildrenbypool"></a>
# **OnTapesFilesChildrenByPool**
> OnTapesFileCollection OnTapesFilesChildrenByPool (string poolId, int fileParentId, int? limit = null, int? offset = null, string name = null, string type = null, string size = null)

Lists files under a specific folder on tape of pools, specific for Active and Offline.

**API Key Scope**: on_tapes_files / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class OnTapesFilesChildrenByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileParentId = 56;  // int | Numeric ID of parent folder.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var size = size_example;  // string | Filter on size (optional) 

            try
            {
                // Lists files under a specific folder on tape of pools, specific for Active and Offline.
                OnTapesFileCollection result = apiInstance.OnTapesFilesChildrenByPool(poolId, fileParentId, limit, offset, name, type, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.OnTapesFilesChildrenByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileParentId** | **int**| Numeric ID of parent folder. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **size** | **string**| Filter on size | [optional] 

### Return type

[**OnTapesFileCollection**](OnTapesFileCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of files on tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfile"></a>
# **ShowFile**
> NodeumFileWithPath ShowFile (int fileId)

Displays a specific file.

**API Key Scope**: files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileExample
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

            var apiInstance = new FilesApi(config);
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file.
                NodeumFileWithPath result = apiInstance.ShowFile(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowFile: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**NodeumFileWithPath**](NodeumFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfilebycontainer"></a>
# **ShowFileByContainer**
> NodeumFileWithPath ShowFileByContainer (string containerId, int fileId)

Displays a specific file.

**API Key Scope**: files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileByContainerExample
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

            var apiInstance = new FilesApi(config);
            var containerId = containerId_example;  // string | Numeric ID or name of container.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file.
                NodeumFileWithPath result = apiInstance.ShowFileByContainer(containerId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowFileByContainer: " + e.Message );
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
 **containerId** | **string**| Numeric ID or name of container. | 
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**NodeumFileWithPath**](NodeumFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfilebypool"></a>
# **ShowFileByPool**
> NodeumFileWithPath ShowFileByPool (string poolId, int fileId)

Displays a specific file.

**API Key Scope**: files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file.
                NodeumFileWithPath result = apiInstance.ShowFileByPool(poolId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowFileByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**NodeumFileWithPath**](NodeumFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfilebytask"></a>
# **ShowFileByTask**
> NodeumFileWithPath ShowFileByTask (string taskId, int fileId)

Displays a specific file.

**API Key Scope**: files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file.
                NodeumFileWithPath result = apiInstance.ShowFileByTask(taskId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowFileByTask: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**NodeumFileWithPath**](NodeumFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfilebytaskexecution"></a>
# **ShowFileByTaskExecution**
> NodeumFileWithPath ShowFileByTaskExecution (string taskExecutionId, int fileId)

Displays a specific file.

**API Key Scope**: files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileByTaskExecutionExample
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

            var apiInstance = new FilesApi(config);
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file.
                NodeumFileWithPath result = apiInstance.ShowFileByTaskExecution(taskExecutionId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowFileByTaskExecution: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**NodeumFileWithPath**](NodeumFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfilebytaskexecutionbytask"></a>
# **ShowFileByTaskExecutionByTask**
> NodeumFileWithPath ShowFileByTaskExecutionByTask (string taskId, string taskExecutionId, int fileId)

Displays a specific file.

**API Key Scope**: files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileByTaskExecutionByTaskExample
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

            var apiInstance = new FilesApi(config);
            var taskId = taskId_example;  // string | Numeric ID or name of task. Task names are not unique, it's recommanded to use numeric ID.
            var taskExecutionId = taskExecutionId_example;  // string | Numeric ID of task execution.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file.
                NodeumFileWithPath result = apiInstance.ShowFileByTaskExecutionByTask(taskId, taskExecutionId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowFileByTaskExecutionByTask: " + e.Message );
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
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**NodeumFileWithPath**](NodeumFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showimportfilebypool"></a>
# **ShowImportFileByPool**
> ImportFileWithPath ShowImportFileByPool (string poolId, int fileId)

Displays a specific file on tape of pools, specific for Data Exchange.

**API Key Scope**: import_files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowImportFileByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file on tape of pools, specific for Data Exchange.
                ImportFileWithPath result = apiInstance.ShowImportFileByPool(poolId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowImportFileByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**ImportFileWithPath**](ImportFileWithPath.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific imported file. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showontapefilebypool"></a>
# **ShowOnTapeFileByPool**
> OnTapesFile ShowOnTapeFileByPool (string poolId, int fileId)

Displays a specific file on tape of pools, specific for Active and Offline.

**API Key Scope**: on_tapes_files / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowOnTapeFileByPoolExample
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

            var apiInstance = new FilesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var fileId = 56;  // int | Numeric ID of file.

            try
            {
                // Displays a specific file on tape of pools, specific for Active and Offline.
                OnTapesFile result = apiInstance.ShowOnTapeFileByPool(poolId, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.ShowOnTapeFileByPool: " + e.Message );
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
 **poolId** | **string**| Numeric ID, or name of pool. | 
 **fileId** | **int**| Numeric ID of file. | 

### Return type

[**OnTapesFile**](OnTapesFile.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file on tapes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

