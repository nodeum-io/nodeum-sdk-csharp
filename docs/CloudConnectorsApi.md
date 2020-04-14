# Io.Nodeum.Sdk.Api.CloudConnectorsApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCloudConnector**](CloudConnectorsApi.md#createcloudconnector) | **POST** /cloud_connectors | Creates a new cloud connector.
[**DestroyCloudConnector**](CloudConnectorsApi.md#destroycloudconnector) | **DELETE** /cloud_connectors/{cloud_connector_id} | Destroys a specific cloud connector.
[**IndexCloudConnectors**](CloudConnectorsApi.md#indexcloudconnectors) | **GET** /cloud_connectors | Lists all cloud connectors.
[**ShowCloudConnector**](CloudConnectorsApi.md#showcloudconnector) | **GET** /cloud_connectors/{cloud_connector_id} | Displays a specific cloud connector.
[**TestCloudConnector**](CloudConnectorsApi.md#testcloudconnector) | **PUT** /cloud_connectors/-/test | Test an unsaved cloud connector.
[**TestResultCloudConnector**](CloudConnectorsApi.md#testresultcloudconnector) | **GET** /cloud_connectors/-/test | Check result of cloud connector test job.
[**UpdateCloudConnector**](CloudConnectorsApi.md#updatecloudconnector) | **PUT** /cloud_connectors/{cloud_connector_id} | Updates a specific cloud connector.


<a name="createcloudconnector"></a>
# **CreateCloudConnector**
> CloudConnector CreateCloudConnector (CloudConnector cloudConnectorBody)

Creates a new cloud connector.

**API Key Scope**: cloud_connectors / create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateCloudConnectorExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var cloudConnectorBody = new CloudConnector(); // CloudConnector | 

            try
            {
                // Creates a new cloud connector.
                CloudConnector result = apiInstance.CreateCloudConnector(cloudConnectorBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.CreateCloudConnector: " + e.Message );
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
 **cloudConnectorBody** | [**CloudConnector**](CloudConnector.md)|  | 

### Return type

[**CloudConnector**](CloudConnector.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific cloud connector. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroycloudconnector"></a>
# **DestroyCloudConnector**
> void DestroyCloudConnector (string cloudConnectorId)

Destroys a specific cloud connector.

**API Key Scope**: cloud_connectors / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyCloudConnectorExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.

            try
            {
                // Destroys a specific cloud connector.
                apiInstance.DestroyCloudConnector(cloudConnectorId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.DestroyCloudConnector: " + e.Message );
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
 **cloudConnectorId** | **string**| Numeric ID or name of cloud connector. | 

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
| **204** | Cloud connector destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexcloudconnectors"></a>
# **IndexCloudConnectors**
> CloudConnectorCollection IndexCloudConnectors (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string url = null, string urlProxy = null, string provider = null, string region = null, string accessKey = null)

Lists all cloud connectors.

**API Key Scope**: cloud_connectors / index   Optional API Key Explicit Scope: cloud_connectors / get_secret_key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexCloudConnectorsExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var url = url_example;  // string | Filter on url (optional) 
            var urlProxy = urlProxy_example;  // string | Filter on url proxy (optional) 
            var provider = provider_example;  // string | Filter on provider (optional) 
            var region = region_example;  // string | Filter on region (optional) 
            var accessKey = accessKey_example;  // string | Filter on access key (optional) 

            try
            {
                // Lists all cloud connectors.
                CloudConnectorCollection result = apiInstance.IndexCloudConnectors(limit, offset, sortBy, id, name, url, urlProxy, provider, region, accessKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.IndexCloudConnectors: " + e.Message );
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
 **url** | **string**| Filter on url | [optional] 
 **urlProxy** | **string**| Filter on url proxy | [optional] 
 **provider** | **string**| Filter on provider | [optional] 
 **region** | **string**| Filter on region | [optional] 
 **accessKey** | **string**| Filter on access key | [optional] 

### Return type

[**CloudConnectorCollection**](CloudConnectorCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of cloud connectors. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showcloudconnector"></a>
# **ShowCloudConnector**
> CloudConnector ShowCloudConnector (string cloudConnectorId)

Displays a specific cloud connector.

**API Key Scope**: cloud_connectors / show   Optional API Key Explicit Scope: cloud_connectors / get_secret_key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowCloudConnectorExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.

            try
            {
                // Displays a specific cloud connector.
                CloudConnector result = apiInstance.ShowCloudConnector(cloudConnectorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.ShowCloudConnector: " + e.Message );
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
 **cloudConnectorId** | **string**| Numeric ID or name of cloud connector. | 

### Return type

[**CloudConnector**](CloudConnector.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud connector. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testcloudconnector"></a>
# **TestCloudConnector**
> ActiveJobStatus TestCloudConnector (CloudConnector cloudConnectorBody)

Test an unsaved cloud connector.

**API Key Scope**: cloud_connectors / test

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class TestCloudConnectorExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var cloudConnectorBody = new CloudConnector(); // CloudConnector | 

            try
            {
                // Test an unsaved cloud connector.
                ActiveJobStatus result = apiInstance.TestCloudConnector(cloudConnectorBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.TestCloudConnector: " + e.Message );
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
 **cloudConnectorBody** | [**CloudConnector**](CloudConnector.md)|  | 

### Return type

[**ActiveJobStatus**](ActiveJobStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, queued, working, failed

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testresultcloudconnector"></a>
# **TestResultCloudConnector**
> CloudBucketSimpleCollection TestResultCloudConnector (string jobId)

Check result of cloud connector test job.

**API Key Scope**: cloud_connectors / test

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class TestResultCloudConnectorExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of cloud connector test job.
                CloudBucketSimpleCollection result = apiInstance.TestResultCloudConnector(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.TestResultCloudConnector: " + e.Message );
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
 **jobId** | **string**| ID of active job | 

### Return type

[**CloudBucketSimpleCollection**](CloudBucketSimpleCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed, 

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Simple list of cloud buckets. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecloudconnector"></a>
# **UpdateCloudConnector**
> CloudConnector UpdateCloudConnector (string cloudConnectorId, CloudConnector cloudConnectorBody)

Updates a specific cloud connector.

**API Key Scope**: cloud_connectors / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateCloudConnectorExample
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

            var apiInstance = new CloudConnectorsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.
            var cloudConnectorBody = new CloudConnector(); // CloudConnector | 

            try
            {
                // Updates a specific cloud connector.
                CloudConnector result = apiInstance.UpdateCloudConnector(cloudConnectorId, cloudConnectorBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudConnectorsApi.UpdateCloudConnector: " + e.Message );
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
 **cloudConnectorId** | **string**| Numeric ID or name of cloud connector. | 
 **cloudConnectorBody** | [**CloudConnector**](CloudConnector.md)|  | 

### Return type

[**CloudConnector**](CloudConnector.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud connector. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

