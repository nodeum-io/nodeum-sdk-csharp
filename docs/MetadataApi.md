# Io.Nodeum.Sdk.Api.MetadataApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IndexFileMetadataDefinitions**](MetadataApi.md#indexfilemetadatadefinitions) | **GET** /file_metadata_definitions | List file metadata definitions
[**IndexTaskMetadataDefinitions**](MetadataApi.md#indextaskmetadatadefinitions) | **GET** /task_metadata_definitions | List task metadata definitions
[**ShowFileMetadataDefinition**](MetadataApi.md#showfilemetadatadefinition) | **GET** /file_metadata_definitions/{metadata_definition_id} | Displays a specific task metadata definition.
[**ShowTaskMetadataDefinition**](MetadataApi.md#showtaskmetadatadefinition) | **GET** /task_metadata_definitions/{metadata_definition_id} | Displays a specific task metadata definition.


<a name="indexfilemetadatadefinitions"></a>
# **IndexFileMetadataDefinitions**
> FileMetadataDefinitionCollection IndexFileMetadataDefinitions (int? limit = null, int? offset = null)

List file metadata definitions

**API Key Scope**: file_metadata_definitions / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexFileMetadataDefinitionsExample
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

            var apiInstance = new MetadataApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 

            try
            {
                // List file metadata definitions
                FileMetadataDefinitionCollection result = apiInstance.IndexFileMetadataDefinitions(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.IndexFileMetadataDefinitions: " + e.Message );
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

### Return type

[**FileMetadataDefinitionCollection**](FileMetadataDefinitionCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of file metadata |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextaskmetadatadefinitions"></a>
# **IndexTaskMetadataDefinitions**
> TaskMetadataDefinitionCollection IndexTaskMetadataDefinitions (int? limit = null, int? offset = null)

List task metadata definitions

**API Key Scope**: task_metadata_definitions / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTaskMetadataDefinitionsExample
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

            var apiInstance = new MetadataApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 

            try
            {
                // List task metadata definitions
                TaskMetadataDefinitionCollection result = apiInstance.IndexTaskMetadataDefinitions(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.IndexTaskMetadataDefinitions: " + e.Message );
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

### Return type

[**TaskMetadataDefinitionCollection**](TaskMetadataDefinitionCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of task metadata |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showfilemetadatadefinition"></a>
# **ShowFileMetadataDefinition**
> FileMetadataDefinition ShowFileMetadataDefinition (string metadataDefinitionId)

Displays a specific task metadata definition.

**API Key Scope**: file_metadata_definitions / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowFileMetadataDefinitionExample
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

            var apiInstance = new MetadataApi(config);
            var metadataDefinitionId = metadataDefinitionId_example;  // string | Numeric ID or key of a metadata definition

            try
            {
                // Displays a specific task metadata definition.
                FileMetadataDefinition result = apiInstance.ShowFileMetadataDefinition(metadataDefinitionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.ShowFileMetadataDefinition: " + e.Message );
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
 **metadataDefinitionId** | **string**| Numeric ID or key of a metadata definition | 

### Return type

[**FileMetadataDefinition**](FileMetadataDefinition.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific file metadata |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtaskmetadatadefinition"></a>
# **ShowTaskMetadataDefinition**
> TaskMetadataDefinition ShowTaskMetadataDefinition (string metadataDefinitionId)

Displays a specific task metadata definition.

**API Key Scope**: task_metadata_definitions / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTaskMetadataDefinitionExample
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

            var apiInstance = new MetadataApi(config);
            var metadataDefinitionId = metadataDefinitionId_example;  // string | Numeric ID or key of a metadata definition

            try
            {
                // Displays a specific task metadata definition.
                TaskMetadataDefinition result = apiInstance.ShowTaskMetadataDefinition(metadataDefinitionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.ShowTaskMetadataDefinition: " + e.Message );
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
 **metadataDefinitionId** | **string**| Numeric ID or key of a metadata definition | 

### Return type

[**TaskMetadataDefinition**](TaskMetadataDefinition.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific task metadata |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

