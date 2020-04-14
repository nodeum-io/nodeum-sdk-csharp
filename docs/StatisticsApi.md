# Io.Nodeum.Sdk.Api.StatisticsApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatisticsByFileExtension**](StatisticsApi.md#statisticsbyfileextension) | **GET** /statistics/by_file_extension | TODO
[**StatisticsByGroupOwner**](StatisticsApi.md#statisticsbygroupowner) | **GET** /statistics/by_group_owner | TODO
[**StatisticsByPrimaryName**](StatisticsApi.md#statisticsbyprimaryname) | **GET** /statistics/by_primary_name | TODO
[**StatisticsBySecondaryStorage**](StatisticsApi.md#statisticsbysecondarystorage) | **GET** /statistics/by_secondary_storage | TODO
[**StatisticsBySize**](StatisticsApi.md#statisticsbysize) | **GET** /statistics/by_size | TODO
[**StatisticsByUserOwner**](StatisticsApi.md#statisticsbyuserowner) | **GET** /statistics/by_user_owner | TODO


<a name="statisticsbyfileextension"></a>
# **StatisticsByFileExtension**
> ByFileExtensionFacet StatisticsByFileExtension (string q = null, string dateAttr = null)

TODO

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
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // TODO
                ByFileExtensionFacet result = apiInstance.StatisticsByFileExtension(q, dateAttr);
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
 **dateAttr** | **string**| Type of date to facet on | [optional] 

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
> ByGroupOwnerFacet StatisticsByGroupOwner (string q = null, string dateAttr = null)

TODO

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
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // TODO
                ByGroupOwnerFacet result = apiInstance.StatisticsByGroupOwner(q, dateAttr);
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
 **dateAttr** | **string**| Type of date to facet on | [optional] 

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

<a name="statisticsbyprimaryname"></a>
# **StatisticsByPrimaryName**
> ByPrimaryFacet StatisticsByPrimaryName (string q = null, string dateAttr = null)

TODO

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
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // TODO
                ByPrimaryFacet result = apiInstance.StatisticsByPrimaryName(q, dateAttr);
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
 **dateAttr** | **string**| Type of date to facet on | [optional] 

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

<a name="statisticsbysecondarystorage"></a>
# **StatisticsBySecondaryStorage**
> BySecondaryFacet StatisticsBySecondaryStorage (string q = null, string dateAttr = null)

TODO

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
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // TODO
                BySecondaryFacet result = apiInstance.StatisticsBySecondaryStorage(q, dateAttr);
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
 **dateAttr** | **string**| Type of date to facet on | [optional] 

### Return type

[**BySecondaryFacet**](BySecondaryFacet.md)

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
> BySizeFacet StatisticsBySize (string q = null, string dateAttr = null)

TODO

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
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // TODO
                BySizeFacet result = apiInstance.StatisticsBySize(q, dateAttr);
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
> ByUserOwnerFacet StatisticsByUserOwner (string q = null, string dateAttr = null)

TODO

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
            var dateAttr = dateAttr_example;  // string | Type of date to facet on (optional) 

            try
            {
                // TODO
                ByUserOwnerFacet result = apiInstance.StatisticsByUserOwner(q, dateAttr);
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
 **dateAttr** | **string**| Type of date to facet on | [optional] 

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

