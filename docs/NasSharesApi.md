# Io.Nodeum.Sdk.Api.NasSharesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNasShareByNas**](NasSharesApi.md#createnassharebynas) | **POST** /nas/{nas_id}/nas_shares | Creates a new NAS share.
[**DestroyNasShare**](NasSharesApi.md#destroynasshare) | **DELETE** /nas_shares/{nas_share_id} | Destroys a specific NAS share.
[**DestroyNasShareByNas**](NasSharesApi.md#destroynassharebynas) | **DELETE** /nas/{nas_id}/nas_shares/{nas_share_id} | Destroys a specific NAS share.
[**DestroyNasShareByPool**](NasSharesApi.md#destroynassharebypool) | **DELETE** /pools/{pool_id}/nas_shares/{nas_share_id} | Destroys a specific NAS share.
[**IndexNasShares**](NasSharesApi.md#indexnasshares) | **GET** /nas_shares | Lists all NAS shares.
[**IndexNasSharesByNas**](NasSharesApi.md#indexnassharesbynas) | **GET** /nas/{nas_id}/nas_shares | Lists all NAS shares.
[**IndexNasSharesByPool**](NasSharesApi.md#indexnassharesbypool) | **GET** /pools/{pool_id}/nas_shares | Lists all NAS shares from pool.
[**MountStatusNasShare**](NasSharesApi.md#mountstatusnasshare) | **GET** /nas_shares/{nas_share_id}/mount | Get mount status of NAS Share.
[**MountStatusNasShareByNas**](NasSharesApi.md#mountstatusnassharebynas) | **GET** /nas/{nas_id}/nas_shares/{nas_share_id}/mount | Get mount status of NAS Share.
[**MountStatusNasShareByPool**](NasSharesApi.md#mountstatusnassharebypool) | **GET** /pools/{pool_id}/nas_shares/{nas_share_id}/mount | Get mount status of NAS Share.
[**ShowNasShare**](NasSharesApi.md#shownasshare) | **GET** /nas_shares/{nas_share_id} | Displays a specific NAS share.
[**ShowNasShareByNas**](NasSharesApi.md#shownassharebynas) | **GET** /nas/{nas_id}/nas_shares/{nas_share_id} | Displays a specific NAS share.
[**ShowNasShareByPool**](NasSharesApi.md#shownassharebypool) | **GET** /pools/{pool_id}/nas_shares/{nas_share_id} | Displays a specific NAS share.
[**TestNasShare**](NasSharesApi.md#testnasshare) | **PUT** /nas/{nas_id}/nas_shares/-/test | Test an unsaved NAS Share.
[**TestResultNasShare**](NasSharesApi.md#testresultnasshare) | **GET** /nas/{nas_id}/nas_shares/-/test | Check result of a NAS Share test job.
[**UpdateNasShare**](NasSharesApi.md#updatenasshare) | **PUT** /nas_shares/{nas_share_id} | Updates a specific NAS share.
[**UpdateNasShareByNas**](NasSharesApi.md#updatenassharebynas) | **PUT** /nas/{nas_id}/nas_shares/{nas_share_id} | Updates a specific NAS share.
[**UpdateNasShareByPool**](NasSharesApi.md#updatenassharebypool) | **PUT** /pools/{pool_id}/nas_shares/{nas_share_id} | Updates a specific NAS share.


<a name="createnassharebynas"></a>
# **CreateNasShareByNas**
> NasShare CreateNasShareByNas (string nasId, NasShare nasShareBody)

Creates a new NAS share.

**API Key Scope**: nas_shares / create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateNasShareByNasExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var nasShareBody = new NasShare(); // NasShare | 

            try
            {
                // Creates a new NAS share.
                NasShare result = apiInstance.CreateNasShareByNas(nasId, nasShareBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.CreateNasShareByNas: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **nasShareBody** | [**NasShare**](NasShare.md)|  | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific NAS share. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroynasshare"></a>
# **DestroyNasShare**
> void DestroyNasShare (string nasShareId)

Destroys a specific NAS share.

**API Key Scope**: nas_shares / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyNasShareExample
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

            var apiInstance = new NasSharesApi(config);
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Destroys a specific NAS share.
                apiInstance.DestroyNasShare(nasShareId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.DestroyNasShare: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

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
| **204** | NAS share destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroynassharebynas"></a>
# **DestroyNasShareByNas**
> void DestroyNasShareByNas (string nasId, string nasShareId)

Destroys a specific NAS share.

**API Key Scope**: nas_shares / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyNasShareByNasExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Destroys a specific NAS share.
                apiInstance.DestroyNasShareByNas(nasId, nasShareId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.DestroyNasShareByNas: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

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
| **204** | NAS share destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroynassharebypool"></a>
# **DestroyNasShareByPool**
> void DestroyNasShareByPool (string poolId, string nasShareId)

Destroys a specific NAS share.

**API Key Scope**: nas_shares / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyNasShareByPoolExample
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

            var apiInstance = new NasSharesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Destroys a specific NAS share.
                apiInstance.DestroyNasShareByPool(poolId, nasShareId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.DestroyNasShareByPool: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

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
| **204** | NAS share destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexnasshares"></a>
# **IndexNasShares**
> NasShareCollection IndexNasShares (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string path = null, string options = null, string username = null, string nasId = null, string poolId = null)

Lists all NAS shares.

**API Key Scope**: nas_shares / index   Optional API Key Explicit Scope: nas_shares / get_password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexNasSharesExample
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

            var apiInstance = new NasSharesApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var path = path_example;  // string | Filter on path (optional) 
            var options = options_example;  // string | Filter on options (optional) 
            var username = username_example;  // string | Filter on username (optional) 
            var nasId = nasId_example;  // string | Filter on NAS id (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 

            try
            {
                // Lists all NAS shares.
                NasShareCollection result = apiInstance.IndexNasShares(limit, offset, sortBy, id, name, path, options, username, nasId, poolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.IndexNasShares: " + e.Message );
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
 **path** | **string**| Filter on path | [optional] 
 **options** | **string**| Filter on options | [optional] 
 **username** | **string**| Filter on username | [optional] 
 **nasId** | **string**| Filter on NAS id | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 

### Return type

[**NasShareCollection**](NasShareCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of NAS shares. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexnassharesbynas"></a>
# **IndexNasSharesByNas**
> NasShareCollection IndexNasSharesByNas (string nasId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string path = null, string options = null, string username = null, string poolId = null)

Lists all NAS shares.

**API Key Scope**: nas_shares / index   Optional API Key Explicit Scope: nas_shares / get_password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexNasSharesByNasExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var path = path_example;  // string | Filter on path (optional) 
            var options = options_example;  // string | Filter on options (optional) 
            var username = username_example;  // string | Filter on username (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 

            try
            {
                // Lists all NAS shares.
                NasShareCollection result = apiInstance.IndexNasSharesByNas(nasId, limit, offset, sortBy, id, name, path, options, username, poolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.IndexNasSharesByNas: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **id** | **string**| Filter on id | [optional] 
 **name** | **string**| Filter on name | [optional] 
 **path** | **string**| Filter on path | [optional] 
 **options** | **string**| Filter on options | [optional] 
 **username** | **string**| Filter on username | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 

### Return type

[**NasShareCollection**](NasShareCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of NAS shares. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indexnassharesbypool"></a>
# **IndexNasSharesByPool**
> NasShareCollection IndexNasSharesByPool (string poolId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string path = null, string options = null, string username = null, string nasId = null)

Lists all NAS shares from pool.

**API Key Scope**: nas_shares / index   Optional API Key Explicit Scope: nas_shares / get_password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexNasSharesByPoolExample
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

            var apiInstance = new NasSharesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var path = path_example;  // string | Filter on path (optional) 
            var options = options_example;  // string | Filter on options (optional) 
            var username = username_example;  // string | Filter on username (optional) 
            var nasId = nasId_example;  // string | Filter on NAS id (optional) 

            try
            {
                // Lists all NAS shares from pool.
                NasShareCollection result = apiInstance.IndexNasSharesByPool(poolId, limit, offset, sortBy, id, name, path, options, username, nasId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.IndexNasSharesByPool: " + e.Message );
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
 **name** | **string**| Filter on name | [optional] 
 **path** | **string**| Filter on path | [optional] 
 **options** | **string**| Filter on options | [optional] 
 **username** | **string**| Filter on username | [optional] 
 **nasId** | **string**| Filter on NAS id | [optional] 

### Return type

[**NasShareCollection**](NasShareCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of NAS shares. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountstatusnasshare"></a>
# **MountStatusNasShare**
> MountStatus MountStatusNasShare (string nasShareId)

Get mount status of NAS Share.

**API Key Scope**: nas_shares / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusNasShareExample
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

            var apiInstance = new NasSharesApi(config);
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Get mount status of NAS Share.
                MountStatus result = apiInstance.MountStatusNasShare(nasShareId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.MountStatusNasShare: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

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

<a name="mountstatusnassharebynas"></a>
# **MountStatusNasShareByNas**
> MountStatus MountStatusNasShareByNas (string nasId, string nasShareId)

Get mount status of NAS Share.

**API Key Scope**: nas_shares / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusNasShareByNasExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Get mount status of NAS Share.
                MountStatus result = apiInstance.MountStatusNasShareByNas(nasId, nasShareId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.MountStatusNasShareByNas: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

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

<a name="mountstatusnassharebypool"></a>
# **MountStatusNasShareByPool**
> MountStatus MountStatusNasShareByPool (string poolId, string nasShareId)

Get mount status of NAS Share.

**API Key Scope**: nas_shares / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusNasShareByPoolExample
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

            var apiInstance = new NasSharesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Get mount status of NAS Share.
                MountStatus result = apiInstance.MountStatusNasShareByPool(poolId, nasShareId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.MountStatusNasShareByPool: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

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

<a name="shownasshare"></a>
# **ShowNasShare**
> NasShare ShowNasShare (string nasShareId)

Displays a specific NAS share.

**API Key Scope**: nas_shares / show   Optional API Key Explicit Scope: nas_shares / get_password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowNasShareExample
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

            var apiInstance = new NasSharesApi(config);
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Displays a specific NAS share.
                NasShare result = apiInstance.ShowNasShare(nasShareId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.ShowNasShare: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific NAS share. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shownassharebynas"></a>
# **ShowNasShareByNas**
> NasShare ShowNasShareByNas (string nasId, string nasShareId)

Displays a specific NAS share.

**API Key Scope**: nas_shares / show   Optional API Key Explicit Scope: nas_shares / get_password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowNasShareByNasExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Displays a specific NAS share.
                NasShare result = apiInstance.ShowNasShareByNas(nasId, nasShareId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.ShowNasShareByNas: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific NAS share. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shownassharebypool"></a>
# **ShowNasShareByPool**
> NasShare ShowNasShareByPool (string poolId, string nasShareId)

Displays a specific NAS share.

**API Key Scope**: nas_shares / show   Optional API Key Explicit Scope: nas_shares / get_password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowNasShareByPoolExample
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

            var apiInstance = new NasSharesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.

            try
            {
                // Displays a specific NAS share.
                NasShare result = apiInstance.ShowNasShareByPool(poolId, nasShareId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.ShowNasShareByPool: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific NAS share. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnasshare"></a>
# **TestNasShare**
> ActiveJobStatus TestNasShare (string nasId, NasShare nasShareBody)

Test an unsaved NAS Share.

**API Key Scope**: nas_shares / test

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class TestNasShareExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var nasShareBody = new NasShare(); // NasShare | 

            try
            {
                // Test an unsaved NAS Share.
                ActiveJobStatus result = apiInstance.TestNasShare(nasId, nasShareBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.TestNasShare: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **nasShareBody** | [**NasShare**](NasShare.md)|  | 

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

<a name="testresultnasshare"></a>
# **TestResultNasShare**
> ActiveJobStatus TestResultNasShare (string nasId, string jobId)

Check result of a NAS Share test job.

**API Key Scope**: nas_shares / test

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class TestResultNasShareExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Check result of a NAS Share test job.
                ActiveJobStatus result = apiInstance.TestResultNasShare(nasId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.TestResultNasShare: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
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

<a name="updatenasshare"></a>
# **UpdateNasShare**
> NasShare UpdateNasShare (string nasShareId, NasShare nasShareBody)

Updates a specific NAS share.

**API Key Scope**: nas_shares / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateNasShareExample
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

            var apiInstance = new NasSharesApi(config);
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.
            var nasShareBody = new NasShare(); // NasShare | 

            try
            {
                // Updates a specific NAS share.
                NasShare result = apiInstance.UpdateNasShare(nasShareId, nasShareBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.UpdateNasShare: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 
 **nasShareBody** | [**NasShare**](NasShare.md)|  | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific NAS share. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenassharebynas"></a>
# **UpdateNasShareByNas**
> NasShare UpdateNasShareByNas (string nasId, string nasShareId, NasShare nasShareBody)

Updates a specific NAS share.

**API Key Scope**: nas_shares / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateNasShareByNasExample
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

            var apiInstance = new NasSharesApi(config);
            var nasId = nasId_example;  // string | Numeric ID or name of NAS.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.
            var nasShareBody = new NasShare(); // NasShare | 

            try
            {
                // Updates a specific NAS share.
                NasShare result = apiInstance.UpdateNasShareByNas(nasId, nasShareId, nasShareBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.UpdateNasShareByNas: " + e.Message );
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
 **nasId** | **string**| Numeric ID or name of NAS. | 
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 
 **nasShareBody** | [**NasShare**](NasShare.md)|  | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific NAS share. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenassharebypool"></a>
# **UpdateNasShareByPool**
> NasShare UpdateNasShareByPool (string poolId, string nasShareId, NasShare nasShareBody)

Updates a specific NAS share.

**API Key Scope**: nas_shares / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateNasShareByPoolExample
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

            var apiInstance = new NasSharesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var nasShareId = nasShareId_example;  // string | Numeric ID or name of NAS share.
            var nasShareBody = new NasShare(); // NasShare | 

            try
            {
                // Updates a specific NAS share.
                NasShare result = apiInstance.UpdateNasShareByPool(poolId, nasShareId, nasShareBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NasSharesApi.UpdateNasShareByPool: " + e.Message );
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
 **nasShareId** | **string**| Numeric ID or name of NAS share. | 
 **nasShareBody** | [**NasShare**](NasShare.md)|  | 

### Return type

[**NasShare**](NasShare.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific NAS share. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

