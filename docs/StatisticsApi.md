# Io.Nodeum.Sdk.Api.StatisticsApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatisticsByDate**](StatisticsApi.md#statisticsbydate) | **GET** /statistics/by_date | Get statistics about files, grouped by date
[**StatisticsByFileExtension**](StatisticsApi.md#statisticsbyfileextension) | **GET** /statistics/by_file_extension | Get statistics about files, grouped by file extension
[**StatisticsByGroupOwner**](StatisticsApi.md#statisticsbygroupowner) | **GET** /statistics/by_group_owner | Get statistics about files, grouped by owner (group)
[**StatisticsByMetadata**](StatisticsApi.md#statisticsbymetadata) | **GET** /statistics/by_metadata | Get statistics about files, grouped by metadata
[**StatisticsByPrimaryCloud**](StatisticsApi.md#statisticsbyprimarycloud) | **GET** /statistics/by_primary_cloud | Get statistics about files, grouped by primary Cloud
[**StatisticsByPrimaryName**](StatisticsApi.md#statisticsbyprimaryname) | **GET** /statistics/by_primary_name | Get statistics about files, grouped by primary storages
[**StatisticsByPrimaryNas**](StatisticsApi.md#statisticsbyprimarynas) | **GET** /statistics/by_primary_nas | Get statistics about files, grouped by primary NAS
[**StatisticsByPrimaryStorage**](StatisticsApi.md#statisticsbyprimarystorage) | **GET** /statistics/by_primary_storage | Get statistics about files, grouped by primary storage
[**StatisticsBySecondaryCloud**](StatisticsApi.md#statisticsbysecondarycloud) | **GET** /statistics/by_secondary_cloud | Get statistics about files, grouped by secondary Cloud
[**StatisticsBySecondaryNas**](StatisticsApi.md#statisticsbysecondarynas) | **GET** /statistics/by_secondary_nas | Get statistics about files, grouped by secondary NAS
[**StatisticsBySecondaryStorage**](StatisticsApi.md#statisticsbysecondarystorage) | **GET** /statistics/by_secondary_storage | Get statistics about files, grouped by secondary storage
[**StatisticsBySecondaryTape**](StatisticsApi.md#statisticsbysecondarytape) | **GET** /statistics/by_secondary_tape | Get statistics about files, grouped by secondary Tape
[**StatisticsBySize**](StatisticsApi.md#statisticsbysize) | **GET** /statistics/by_size | Get statistics about files, grouped by size
[**StatisticsByUserOwner**](StatisticsApi.md#statisticsbyuserowner) | **GET** /statistics/by_user_owner | Get statistics about files, grouped by owner (user)
[**StatisticsStorage**](StatisticsApi.md#statisticsstorage) | **GET** /statistics/storage | Get statistics about storages, grouped by types
[**StatisticsTaskByMetadata**](StatisticsApi.md#statisticstaskbymetadata) | **GET** /statistics/task_by_metadata | Get statistics about tasks executions, grouped by metadata
[**StatisticsTaskByStatus**](StatisticsApi.md#statisticstaskbystatus) | **GET** /statistics/task_by_status | Get statistics about tasks executions, grouped by status
[**StatisticsTaskByStorage**](StatisticsApi.md#statisticstaskbystorage) | **GET** /statistics/task_by_storage | Get statistics about tasks executions, grouped by source and destination
[**StatisticsTaskByWorkflow**](StatisticsApi.md#statisticstaskbyworkflow) | **GET** /statistics/task_by_workflow | Get statistics about tasks executions, grouped by workflow


<a name="statisticsbydate"></a>
# **StatisticsByDate**
> ByDateFacet StatisticsByDate (string q = null, List<string> fq = null, string dateAttr = null)

Get statistics about files, grouped by date

**API Key Scope**: statistics / by_date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByDateExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // Get statistics about files, grouped by date
                ByDateFacet result = apiInstance.StatisticsByDate(q, fq, dateAttr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByDate: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 

### Return type

[**ByDateFacet**](ByDateFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbyfileextension"></a>
# **StatisticsByFileExtension**
> ByFileExtensionFacet StatisticsByFileExtension (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by file extension

**API Key Scope**: statistics / by_file_extension

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByFileExtensionExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by file extension
                ByFileExtensionFacet result = apiInstance.StatisticsByFileExtension(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByFileExtension: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByFileExtensionFacet**](ByFileExtensionFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbygroupowner"></a>
# **StatisticsByGroupOwner**
> ByGroupOwnerFacet StatisticsByGroupOwner (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by owner (group)

**API Key Scope**: statistics / by_group_owner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByGroupOwnerExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by owner (group)
                ByGroupOwnerFacet result = apiInstance.StatisticsByGroupOwner(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByGroupOwner: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByGroupOwnerFacet**](ByGroupOwnerFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbymetadata"></a>
# **StatisticsByMetadata**
> ByMetadataFacet StatisticsByMetadata (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by metadata

**API Key Scope**: statistics / by_metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByMetadataExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by metadata
                ByMetadataFacet result = apiInstance.StatisticsByMetadata(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByMetadata: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByMetadataFacet**](ByMetadataFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbyprimarycloud"></a>
# **StatisticsByPrimaryCloud**
> ByPrimaryCloudFacet StatisticsByPrimaryCloud (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by primary Cloud

**API Key Scope**: statistics / by_primary_cloud

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByPrimaryCloudExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by primary Cloud
                ByPrimaryCloudFacet result = apiInstance.StatisticsByPrimaryCloud(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByPrimaryCloud: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByPrimaryCloudFacet**](ByPrimaryCloudFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbyprimaryname"></a>
# **StatisticsByPrimaryName**
> ByPrimaryFacet StatisticsByPrimaryName (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by primary storages

**API Key Scope**: statistics / by_primary_name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByPrimaryNameExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by primary storages
                ByPrimaryFacet result = apiInstance.StatisticsByPrimaryName(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByPrimaryName: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByPrimaryFacet**](ByPrimaryFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbyprimarynas"></a>
# **StatisticsByPrimaryNas**
> ByPrimaryNasFacet StatisticsByPrimaryNas (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by primary NAS

**API Key Scope**: statistics / by_primary_nas

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByPrimaryNasExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by primary NAS
                ByPrimaryNasFacet result = apiInstance.StatisticsByPrimaryNas(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByPrimaryNas: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByPrimaryNasFacet**](ByPrimaryNasFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbyprimarystorage"></a>
# **StatisticsByPrimaryStorage**
> ByPrimaryStorageFacet StatisticsByPrimaryStorage (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by primary storage

**API Key Scope**: statistics / by_primary_storage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByPrimaryStorageExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by primary storage
                ByPrimaryStorageFacet result = apiInstance.StatisticsByPrimaryStorage(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByPrimaryStorage: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByPrimaryStorageFacet**](ByPrimaryStorageFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbysecondarycloud"></a>
# **StatisticsBySecondaryCloud**
> BySecondaryCloudFacet StatisticsBySecondaryCloud (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by secondary Cloud

**API Key Scope**: statistics / by_secondary_cloud

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsBySecondaryCloudExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by secondary Cloud
                BySecondaryCloudFacet result = apiInstance.StatisticsBySecondaryCloud(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsBySecondaryCloud: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**BySecondaryCloudFacet**](BySecondaryCloudFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbysecondarynas"></a>
# **StatisticsBySecondaryNas**
> BySecondaryNasFacet StatisticsBySecondaryNas (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by secondary NAS

**API Key Scope**: statistics / by_secondary_nas

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsBySecondaryNasExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by secondary NAS
                BySecondaryNasFacet result = apiInstance.StatisticsBySecondaryNas(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsBySecondaryNas: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**BySecondaryNasFacet**](BySecondaryNasFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbysecondarystorage"></a>
# **StatisticsBySecondaryStorage**
> BySecondaryStorageFacet StatisticsBySecondaryStorage (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by secondary storage

**API Key Scope**: statistics / by_secondary_storage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsBySecondaryStorageExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by secondary storage
                BySecondaryStorageFacet result = apiInstance.StatisticsBySecondaryStorage(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsBySecondaryStorage: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**BySecondaryStorageFacet**](BySecondaryStorageFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbysecondarytape"></a>
# **StatisticsBySecondaryTape**
> BySecondaryTapeFacet StatisticsBySecondaryTape (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by secondary Tape

**API Key Scope**: statistics / by_secondary_tape

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsBySecondaryTapeExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by secondary Tape
                BySecondaryTapeFacet result = apiInstance.StatisticsBySecondaryTape(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsBySecondaryTape: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**BySecondaryTapeFacet**](BySecondaryTapeFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbysize"></a>
# **StatisticsBySize**
> BySizeFacet StatisticsBySize (string q = null, List<string> fq = null, string dateAttr = null)

Get statistics about files, grouped by size

**API Key Scope**: statistics / by_size

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsBySizeExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // Get statistics about files, grouped by size
                BySizeFacet result = apiInstance.StatisticsBySize(q, fq, dateAttr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsBySize: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 

### Return type

[**BySizeFacet**](BySizeFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsbyuserowner"></a>
# **StatisticsByUserOwner**
> ByUserOwnerFacet StatisticsByUserOwner (string q = null, List<string> fq = null, string dateAttr = null, string sort = null, int? limit = null)

Get statistics about files, grouped by owner (user)

**API Key Scope**: statistics / by_user_owner

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsByUserOwnerExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 
            var sort = sort_example;  // string | Sort results of facet (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about files, grouped by owner (user)
                ByUserOwnerFacet result = apiInstance.StatisticsByUserOwner(q, fq, dateAttr, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsByUserOwner: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **dateAttr** | **string**| Type of date to facet on | [optional] 
 **sort** | **string**| Sort results of facet | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByUserOwnerFacet**](ByUserOwnerFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticsstorage"></a>
# **StatisticsStorage**
> StorageFacet StatisticsStorage (string q = null, List<string> fq = null)

Get statistics about storages, grouped by types

**API Key Scope**: statistics / storages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsStorageExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 

            try
            {
                // Get statistics about storages, grouped by types
                StorageFacet result = apiInstance.StatisticsStorage(q, fq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsStorage: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 

### Return type

[**StorageFacet**](StorageFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticstaskbymetadata"></a>
# **StatisticsTaskByMetadata**
> ByTaskMetadataFacet StatisticsTaskByMetadata (string q = null, List<string> fq = null, string sort = null, int? limit = null)

Get statistics about tasks executions, grouped by metadata

**API Key Scope**: statistics / task_by_metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsTaskByMetadataExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 
            var sort = sort_example;  // string | Sort results of facet on task (optional)  (default to count)
            var limit = 56;  // int? | Limit results of facet (optional)  (default to 10)

            try
            {
                // Get statistics about tasks executions, grouped by metadata
                ByTaskMetadataFacet result = apiInstance.StatisticsTaskByMetadata(q, fq, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsTaskByMetadata: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 
 **sort** | **string**| Sort results of facet on task | [optional] [default to count]
 **limit** | **int?**| Limit results of facet | [optional] [default to 10]

### Return type

[**ByTaskMetadataFacet**](ByTaskMetadataFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticstaskbystatus"></a>
# **StatisticsTaskByStatus**
> ByTaskStatusFacet StatisticsTaskByStatus (string q = null, List<string> fq = null)

Get statistics about tasks executions, grouped by status

**API Key Scope**: statistics / task_by_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsTaskByStatusExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 

            try
            {
                // Get statistics about tasks executions, grouped by status
                ByTaskStatusFacet result = apiInstance.StatisticsTaskByStatus(q, fq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsTaskByStatus: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 

### Return type

[**ByTaskStatusFacet**](ByTaskStatusFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticstaskbystorage"></a>
# **StatisticsTaskByStorage**
> ByTaskStorageFacet StatisticsTaskByStorage (string q = null, List<string> fq = null)

Get statistics about tasks executions, grouped by source and destination

**API Key Scope**: statistics / task_by_storage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsTaskByStorageExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 

            try
            {
                // Get statistics about tasks executions, grouped by source and destination
                ByTaskStorageFacet result = apiInstance.StatisticsTaskByStorage(q, fq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsTaskByStorage: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 

### Return type

[**ByTaskStorageFacet**](ByTaskStorageFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="statisticstaskbyworkflow"></a>
# **StatisticsTaskByWorkflow**
> ByTaskWorkflowFacet StatisticsTaskByWorkflow (string q = null, List<string> fq = null)

Get statistics about tasks executions, grouped by workflow

**API Key Scope**: statistics / task_by_workflow

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class StatisticsTaskByWorkflowExample
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

            var apiInstance = new StatisticsApi(config);
            var q = q_example;  // string | Solr query (optional) 
            var fq = new List<string>(); // List<string> | Solr filter query  Multiple query can be separated by `|`. (optional) 

            try
            {
                // Get statistics about tasks executions, grouped by workflow
                ByTaskWorkflowFacet result = apiInstance.StatisticsTaskByWorkflow(q, fq);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsTaskByWorkflow: " + e.Message );
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
 **q** | **string**| Solr query | [optional] 
 **fq** | [**List&lt;string&gt;**](string.md)| Solr filter query  Multiple query can be separated by &#x60;|&#x60;. | [optional] 

### Return type

[**ByTaskWorkflowFacet**](ByTaskWorkflowFacet.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

