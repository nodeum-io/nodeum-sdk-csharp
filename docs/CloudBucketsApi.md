# Io.Nodeum.Sdk.Api.CloudBucketsApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IndexCloudBuckets**](CloudBucketsApi.md#indexcloudbuckets) | **GET** /cloud_buckets | Lists all cloud buckets.
[**IndexCloudBucketsByCloudConnector**](CloudBucketsApi.md#indexcloudbucketsbycloudconnector) | **GET** /cloud_connectors/{cloud_connector_id}/cloud_buckets | Lists all cloud buckets.
[**IndexCloudBucketsByPool**](CloudBucketsApi.md#indexcloudbucketsbypool) | **GET** /pools/{pool_id}/cloud_buckets | Lists all cloud buckets from pool.
[**MountStatusCloudBucket**](CloudBucketsApi.md#mountstatuscloudbucket) | **GET** /cloud_buckets/{cloud_bucket_id}/mount | Get mount status of Cloud bucket.
[**MountStatusCloudBucketByCloudConnector**](CloudBucketsApi.md#mountstatuscloudbucketbycloudconnector) | **GET** /cloud_connectors/{cloud_connector_id}/cloud_buckets/{cloud_bucket_id}/mount | Get mount status of Cloud bucket.
[**MountStatusCloudBucketByPool**](CloudBucketsApi.md#mountstatuscloudbucketbypool) | **GET** /pools/{pool_id}/cloud_buckets/{cloud_bucket_id}/mount | Get mount status of Cloud bucket.
[**ShowCloudBucket**](CloudBucketsApi.md#showcloudbucket) | **GET** /cloud_buckets/{cloud_bucket_id} | Displays a specific cloud bucket.
[**ShowCloudBucketByCloudConnector**](CloudBucketsApi.md#showcloudbucketbycloudconnector) | **GET** /cloud_connectors/{cloud_connector_id}/cloud_buckets/{cloud_bucket_id} | Displays a specific cloud bucket.
[**ShowCloudBucketByPool**](CloudBucketsApi.md#showcloudbucketbypool) | **GET** /pools/{pool_id}/cloud_buckets/{cloud_bucket_id} | Displays a specific cloud bucket.
[**SyncCloudBuckets**](CloudBucketsApi.md#synccloudbuckets) | **PUT** /cloud_connectors/{cloud_connector_id}/cloud_buckets/-/sync | Synchronize internal cloud buckets with their remote equivalent.
[**SyncResultCloudBuckets**](CloudBucketsApi.md#syncresultcloudbuckets) | **GET** /cloud_connectors/{cloud_connector_id}/cloud_buckets/-/sync | Check result of cloud connector sync job.
[**UpdateCloudBucket**](CloudBucketsApi.md#updatecloudbucket) | **PUT** /cloud_buckets/{cloud_bucket_id} | Updates a specific cloud bucket.
[**UpdateCloudBucketByCloudConnector**](CloudBucketsApi.md#updatecloudbucketbycloudconnector) | **PUT** /cloud_connectors/{cloud_connector_id}/cloud_buckets/{cloud_bucket_id} | Updates a specific cloud bucket.
[**UpdateCloudBucketByPool**](CloudBucketsApi.md#updatecloudbucketbypool) | **PUT** /pools/{pool_id}/cloud_buckets/{cloud_bucket_id} | Updates a specific cloud bucket.


<a name="indexcloudbuckets"></a>
# **IndexCloudBuckets**
> CloudBucketCollection IndexCloudBuckets (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string cloudConnectorId = null, string poolId = null, string name = null, string location = null, string price = null)

Lists all cloud buckets.

**API Key Scope**: cloud_buckets / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexCloudBucketsExample
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

            var apiInstance = new CloudBucketsApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var cloudConnectorId = cloudConnectorId_example;  // string | Filter on cloud connector id (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var location = location_example;  // string | Filter on location (optional) 
            var price = price_example;  // string | Filter on price (optional) 

            try
            {
                // Lists all cloud buckets.
                CloudBucketCollection result = apiInstance.IndexCloudBuckets(limit, offset, sortBy, id, cloudConnectorId, poolId, name, location, price);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.IndexCloudBuckets: " + e.Message );
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
 **cloudConnectorId** | **string**| Filter on cloud connector id | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **location** | **string**| Filter on location | [optional] 
 **price** | **string**| Filter on price | [optional] 

### Return type

[**CloudBucketCollection**](CloudBucketCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of cloud buckets. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexcloudbucketsbycloudconnector"></a>
# **IndexCloudBucketsByCloudConnector**
> CloudBucketCollection IndexCloudBucketsByCloudConnector (string cloudConnectorId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string poolId = null, string name = null, string location = null, string price = null)

Lists all cloud buckets.

**API Key Scope**: cloud_buckets / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexCloudBucketsByCloudConnectorExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var location = location_example;  // string | Filter on location (optional) 
            var price = price_example;  // string | Filter on price (optional) 

            try
            {
                // Lists all cloud buckets.
                CloudBucketCollection result = apiInstance.IndexCloudBucketsByCloudConnector(cloudConnectorId, limit, offset, sortBy, id, poolId, name, location, price);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.IndexCloudBucketsByCloudConnector: " + e.Message );
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
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **id** | **string**| Filter on id | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **location** | **string**| Filter on location | [optional] 
 **price** | **string**| Filter on price | [optional] 

### Return type

[**CloudBucketCollection**](CloudBucketCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of cloud buckets. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexcloudbucketsbypool"></a>
# **IndexCloudBucketsByPool**
> CloudBucketCollection IndexCloudBucketsByPool (string poolId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string cloudConnectorId = null, string name = null, string location = null, string price = null)

Lists all cloud buckets from pool.

**API Key Scope**: cloud_buckets / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexCloudBucketsByPoolExample
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

            var apiInstance = new CloudBucketsApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var cloudConnectorId = cloudConnectorId_example;  // string | Filter on cloud connector id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var location = location_example;  // string | Filter on location (optional) 
            var price = price_example;  // string | Filter on price (optional) 

            try
            {
                // Lists all cloud buckets from pool.
                CloudBucketCollection result = apiInstance.IndexCloudBucketsByPool(poolId, limit, offset, sortBy, id, cloudConnectorId, name, location, price);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.IndexCloudBucketsByPool: " + e.Message );
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
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **id** | **string**| Filter on id | [optional] 
 **cloudConnectorId** | **string**| Filter on cloud connector id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **location** | **string**| Filter on location | [optional] 
 **price** | **string**| Filter on price | [optional] 

### Return type

[**CloudBucketCollection**](CloudBucketCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of cloud buckets. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountstatuscloudbucket"></a>
# **MountStatusCloudBucket**
> MountStatus MountStatusCloudBucket (string cloudBucketId)

Get mount status of Cloud bucket.

**API Key Scope**: cloud_buckets / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusCloudBucketExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.

            try
            {
                // Get mount status of Cloud bucket.
                MountStatus result = apiInstance.MountStatusCloudBucket(cloudBucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.MountStatusCloudBucket: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 

### Return type

[**MountStatus**](MountStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mount status of storage. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountstatuscloudbucketbycloudconnector"></a>
# **MountStatusCloudBucketByCloudConnector**
> MountStatus MountStatusCloudBucketByCloudConnector (string cloudConnectorId, string cloudBucketId)

Get mount status of Cloud bucket.

**API Key Scope**: cloud_buckets / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusCloudBucketByCloudConnectorExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.

            try
            {
                // Get mount status of Cloud bucket.
                MountStatus result = apiInstance.MountStatusCloudBucketByCloudConnector(cloudConnectorId, cloudBucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.MountStatusCloudBucketByCloudConnector: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 

### Return type

[**MountStatus**](MountStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mount status of storage. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountstatuscloudbucketbypool"></a>
# **MountStatusCloudBucketByPool**
> MountStatus MountStatusCloudBucketByPool (string poolId, string cloudBucketId)

Get mount status of Cloud bucket.

**API Key Scope**: cloud_buckets / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusCloudBucketByPoolExample
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

            var apiInstance = new CloudBucketsApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.

            try
            {
                // Get mount status of Cloud bucket.
                MountStatus result = apiInstance.MountStatusCloudBucketByPool(poolId, cloudBucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.MountStatusCloudBucketByPool: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 

### Return type

[**MountStatus**](MountStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mount status of storage. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showcloudbucket"></a>
# **ShowCloudBucket**
> CloudBucket ShowCloudBucket (string cloudBucketId)

Displays a specific cloud bucket.

**API Key Scope**: cloud_buckets / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowCloudBucketExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.

            try
            {
                // Displays a specific cloud bucket.
                CloudBucket result = apiInstance.ShowCloudBucket(cloudBucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.ShowCloudBucket: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 

### Return type

[**CloudBucket**](CloudBucket.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud bucket. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showcloudbucketbycloudconnector"></a>
# **ShowCloudBucketByCloudConnector**
> CloudBucket ShowCloudBucketByCloudConnector (string cloudConnectorId, string cloudBucketId)

Displays a specific cloud bucket.

**API Key Scope**: cloud_buckets / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowCloudBucketByCloudConnectorExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.

            try
            {
                // Displays a specific cloud bucket.
                CloudBucket result = apiInstance.ShowCloudBucketByCloudConnector(cloudConnectorId, cloudBucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.ShowCloudBucketByCloudConnector: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 

### Return type

[**CloudBucket**](CloudBucket.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud bucket. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showcloudbucketbypool"></a>
# **ShowCloudBucketByPool**
> CloudBucket ShowCloudBucketByPool (string poolId, string cloudBucketId)

Displays a specific cloud bucket.

**API Key Scope**: cloud_buckets / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowCloudBucketByPoolExample
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

            var apiInstance = new CloudBucketsApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.

            try
            {
                // Displays a specific cloud bucket.
                CloudBucket result = apiInstance.ShowCloudBucketByPool(poolId, cloudBucketId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.ShowCloudBucketByPool: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 

### Return type

[**CloudBucket**](CloudBucket.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud bucket. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="synccloudbuckets"></a>
# **SyncCloudBuckets**
> ActiveJobStatus SyncCloudBuckets (string cloudConnectorId)

Synchronize internal cloud buckets with their remote equivalent.

**API Key Scope**: cloud_buckets / sync

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class SyncCloudBucketsExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.

            try
            {
                // Synchronize internal cloud buckets with their remote equivalent.
                ActiveJobStatus result = apiInstance.SyncCloudBuckets(cloudConnectorId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.SyncCloudBuckets: " + e.Message );
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

<a name="syncresultcloudbuckets"></a>
# **SyncResultCloudBuckets**
> CloudBucketSimpleCollection SyncResultCloudBuckets (string cloudConnectorId, string jobId)

Check result of cloud connector sync job.

**API Key Scope**: cloud_buckets / sync

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class SyncResultCloudBucketsExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of cloud connector sync job.
                CloudBucketSimpleCollection result = apiInstance.SyncResultCloudBuckets(cloudConnectorId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.SyncResultCloudBuckets: " + e.Message );
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

<a name="updatecloudbucket"></a>
# **UpdateCloudBucket**
> CloudBucket UpdateCloudBucket (string cloudBucketId, CloudBucket cloudBucketBody)

Updates a specific cloud bucket.

**API Key Scope**: cloud_buckets / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateCloudBucketExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.
            var cloudBucketBody = new CloudBucket(); // CloudBucket | 

            try
            {
                // Updates a specific cloud bucket.
                CloudBucket result = apiInstance.UpdateCloudBucket(cloudBucketId, cloudBucketBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.UpdateCloudBucket: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 
 **cloudBucketBody** | [**CloudBucket**](CloudBucket.md)|  | 

### Return type

[**CloudBucket**](CloudBucket.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud bucket. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecloudbucketbycloudconnector"></a>
# **UpdateCloudBucketByCloudConnector**
> CloudBucket UpdateCloudBucketByCloudConnector (string cloudConnectorId, string cloudBucketId, CloudBucket cloudBucketBody)

Updates a specific cloud bucket.

**API Key Scope**: cloud_buckets / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateCloudBucketByCloudConnectorExample
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

            var apiInstance = new CloudBucketsApi(config);
            var cloudConnectorId = cloudConnectorId_example;  // string | Numeric ID or name of cloud connector.
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.
            var cloudBucketBody = new CloudBucket(); // CloudBucket | 

            try
            {
                // Updates a specific cloud bucket.
                CloudBucket result = apiInstance.UpdateCloudBucketByCloudConnector(cloudConnectorId, cloudBucketId, cloudBucketBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.UpdateCloudBucketByCloudConnector: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 
 **cloudBucketBody** | [**CloudBucket**](CloudBucket.md)|  | 

### Return type

[**CloudBucket**](CloudBucket.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud bucket. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecloudbucketbypool"></a>
# **UpdateCloudBucketByPool**
> CloudBucket UpdateCloudBucketByPool (string poolId, string cloudBucketId, CloudBucket cloudBucketBody)

Updates a specific cloud bucket.

**API Key Scope**: cloud_buckets / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateCloudBucketByPoolExample
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

            var apiInstance = new CloudBucketsApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var cloudBucketId = cloudBucketId_example;  // string | Numeric ID or name of cloud bucket.
            var cloudBucketBody = new CloudBucket(); // CloudBucket | 

            try
            {
                // Updates a specific cloud bucket.
                CloudBucket result = apiInstance.UpdateCloudBucketByPool(poolId, cloudBucketId, cloudBucketBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CloudBucketsApi.UpdateCloudBucketByPool: " + e.Message );
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
 **cloudBucketId** | **string**| Numeric ID or name of cloud bucket. | 
 **cloudBucketBody** | [**CloudBucket**](CloudBucket.md)|  | 

### Return type

[**CloudBucket**](CloudBucket.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific cloud bucket. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

