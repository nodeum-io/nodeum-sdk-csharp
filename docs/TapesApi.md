# Io.Nodeum.Sdk.Api.TapesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DestroyTape**](TapesApi.md#destroytape) | **DELETE** /tapes/{tape_id} | Destroys a specific tape. Only when it&#39;s an orphan.
[**IndexTapeStats**](TapesApi.md#indextapestats) | **GET** /tape_stats | List all tape statistics.
[**IndexTapes**](TapesApi.md#indextapes) | **GET** /tapes | Lists all tapes.
[**IndexTapesByPool**](TapesApi.md#indextapesbypool) | **GET** /pools/{pool_id}/tapes | Lists all tapes.
[**IndexTapesByTapeLibrary**](TapesApi.md#indextapesbytapelibrary) | **GET** /tape_libraries/{tape_library_id}/tapes | Lists all tapes.
[**MountStatusTape**](TapesApi.md#mountstatustape) | **GET** /tapes/{tape_id}/mount | Get mount status of Tape.
[**MountStatusTapeByPool**](TapesApi.md#mountstatustapebypool) | **GET** /pools/{pool_id}/tapes/{tape_id}/mount | Get mount status of Tape.
[**MountStatusTapeByTapeLibrary**](TapesApi.md#mountstatustapebytapelibrary) | **GET** /tape_libraries/{tape_library_id}/tapes/{tape_id}/mount | Get mount status of Tape.
[**ShowTape**](TapesApi.md#showtape) | **GET** /tapes/{tape_id} | Displays a specific tape.
[**ShowTapeByPool**](TapesApi.md#showtapebypool) | **GET** /pools/{pool_id}/tapes/{tape_id} | Displays a specific tape.
[**ShowTapeByTapeLibrary**](TapesApi.md#showtapebytapelibrary) | **GET** /tape_libraries/{tape_library_id}/tapes/{tape_id} | Displays a specific tape.
[**ShowTapeStat**](TapesApi.md#showtapestat) | **GET** /tapes/{tape_id}/tape_stat | Display statistic for a specific tape.
[**ShowTapeStatByPool**](TapesApi.md#showtapestatbypool) | **GET** /pools/{pool_id}/tapes/{tape_id}/tape_stat | Display statistic for a specific tape.
[**ShowTapeStatByTapeLibrary**](TapesApi.md#showtapestatbytapelibrary) | **GET** /tape_libraries/{tape_library_id}/tapes/{tape_id}/tape_stat | Display statistic for a specific tape.


<a name="destroytape"></a>
# **DestroyTape**
> void DestroyTape (string tapeId)

Destroys a specific tape. Only when it's an orphan.

**API Key Scope**: tapes / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTapeExample
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

            var apiInstance = new TapesApi(config);
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Destroys a specific tape. Only when it's an orphan.
                apiInstance.DestroyTape(tapeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.DestroyTape: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

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
| **204** | Tape destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapestats"></a>
# **IndexTapeStats**
> TapeStatCollection IndexTapeStats (int? limit = null, int? offset = null)

List all tape statistics.

**API Key Scope**: tape_stats / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapeStatsExample
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

            var apiInstance = new TapesApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 

            try
            {
                // List all tape statistics.
                TapeStatCollection result = apiInstance.IndexTapeStats(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.IndexTapeStats: " + e.Message );
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

[**TapeStatCollection**](TapeStatCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tape statistics. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapes"></a>
# **IndexTapes**
> TapeCollection IndexTapes (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string tapeLibraryId = null, string poolId = null, string barcode = null, string location = null, string type = null, string locked = null, string scratch = null, string cleaning = null, string writeProtect = null, string mounted = null, string ejected = null, string known = null, string mountCount = null, string dateIn = null, string dateMove = null, string free = null, string max = null, string lastSizeUpdate = null, string lastMaintenance = null, string lastRepack = null, string repackStatus = null, string hash = null, string forceImportType = null, string needToCheck = null)

Lists all tapes.

**API Key Scope**: tapes / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesExample
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

            var apiInstance = new TapesApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var tapeLibraryId = tapeLibraryId_example;  // string | Filter on tape library id (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 
            var barcode = barcode_example;  // string | Filter on barcode (optional) 
            var location = location_example;  // string | Filter on location (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var locked = locked_example;  // string | Filter on locked (optional) 
            var scratch = scratch_example;  // string | Filter on scratch (optional) 
            var cleaning = cleaning_example;  // string | Filter on cleaning (optional) 
            var writeProtect = writeProtect_example;  // string | Filter on write protect (optional) 
            var mounted = mounted_example;  // string | Filter on mounted (optional) 
            var ejected = ejected_example;  // string | Filter on ejected (optional) 
            var known = known_example;  // string | Filter on known (optional) 
            var mountCount = mountCount_example;  // string | Filter on mount count (optional) 
            var dateIn = dateIn_example;  // string | Filter on date in (optional) 
            var dateMove = dateMove_example;  // string | Filter on date move (optional) 
            var free = free_example;  // string | Filter on free (optional) 
            var max = max_example;  // string | Filter on max (optional) 
            var lastSizeUpdate = lastSizeUpdate_example;  // string | Filter on last size update (optional) 
            var lastMaintenance = lastMaintenance_example;  // string | Filter on last maintenance (optional) 
            var lastRepack = lastRepack_example;  // string | Filter on last repack (optional) 
            var repackStatus = repackStatus_example;  // string | Filter on repack status (optional) 
            var hash = hash_example;  // string | Filter on hash (optional) 
            var forceImportType = forceImportType_example;  // string | Filter on force import type (optional) 
            var needToCheck = needToCheck_example;  // string | Filter on need to check (optional) 

            try
            {
                // Lists all tapes.
                TapeCollection result = apiInstance.IndexTapes(limit, offset, sortBy, id, tapeLibraryId, poolId, barcode, location, type, locked, scratch, cleaning, writeProtect, mounted, ejected, known, mountCount, dateIn, dateMove, free, max, lastSizeUpdate, lastMaintenance, lastRepack, repackStatus, hash, forceImportType, needToCheck);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.IndexTapes: " + e.Message );
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
 **tapeLibraryId** | **string**| Filter on tape library id | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 
 **barcode** | **string**| Filter on barcode | [optional] 
 **location** | **string**| Filter on location | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **locked** | **string**| Filter on locked | [optional] 
 **scratch** | **string**| Filter on scratch | [optional] 
 **cleaning** | **string**| Filter on cleaning | [optional] 
 **writeProtect** | **string**| Filter on write protect | [optional] 
 **mounted** | **string**| Filter on mounted | [optional] 
 **ejected** | **string**| Filter on ejected | [optional] 
 **known** | **string**| Filter on known | [optional] 
 **mountCount** | **string**| Filter on mount count | [optional] 
 **dateIn** | **string**| Filter on date in | [optional] 
 **dateMove** | **string**| Filter on date move | [optional] 
 **free** | **string**| Filter on free | [optional] 
 **max** | **string**| Filter on max | [optional] 
 **lastSizeUpdate** | **string**| Filter on last size update | [optional] 
 **lastMaintenance** | **string**| Filter on last maintenance | [optional] 
 **lastRepack** | **string**| Filter on last repack | [optional] 
 **repackStatus** | **string**| Filter on repack status | [optional] 
 **hash** | **string**| Filter on hash | [optional] 
 **forceImportType** | **string**| Filter on force import type | [optional] 
 **needToCheck** | **string**| Filter on need to check | [optional] 

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

<a name="indextapesbypool"></a>
# **IndexTapesByPool**
> TapeCollection IndexTapesByPool (string poolId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string tapeLibraryId = null, string barcode = null, string location = null, string type = null, string locked = null, string scratch = null, string cleaning = null, string writeProtect = null, string mounted = null, string ejected = null, string known = null, string mountCount = null, string dateIn = null, string dateMove = null, string free = null, string max = null, string lastSizeUpdate = null, string lastMaintenance = null, string lastRepack = null, string repackStatus = null, string hash = null, string forceImportType = null, string needToCheck = null)

Lists all tapes.

**API Key Scope**: tapes / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesByPoolExample
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

            var apiInstance = new TapesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var tapeLibraryId = tapeLibraryId_example;  // string | Filter on tape library id (optional) 
            var barcode = barcode_example;  // string | Filter on barcode (optional) 
            var location = location_example;  // string | Filter on location (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var locked = locked_example;  // string | Filter on locked (optional) 
            var scratch = scratch_example;  // string | Filter on scratch (optional) 
            var cleaning = cleaning_example;  // string | Filter on cleaning (optional) 
            var writeProtect = writeProtect_example;  // string | Filter on write protect (optional) 
            var mounted = mounted_example;  // string | Filter on mounted (optional) 
            var ejected = ejected_example;  // string | Filter on ejected (optional) 
            var known = known_example;  // string | Filter on known (optional) 
            var mountCount = mountCount_example;  // string | Filter on mount count (optional) 
            var dateIn = dateIn_example;  // string | Filter on date in (optional) 
            var dateMove = dateMove_example;  // string | Filter on date move (optional) 
            var free = free_example;  // string | Filter on free (optional) 
            var max = max_example;  // string | Filter on max (optional) 
            var lastSizeUpdate = lastSizeUpdate_example;  // string | Filter on last size update (optional) 
            var lastMaintenance = lastMaintenance_example;  // string | Filter on last maintenance (optional) 
            var lastRepack = lastRepack_example;  // string | Filter on last repack (optional) 
            var repackStatus = repackStatus_example;  // string | Filter on repack status (optional) 
            var hash = hash_example;  // string | Filter on hash (optional) 
            var forceImportType = forceImportType_example;  // string | Filter on force import type (optional) 
            var needToCheck = needToCheck_example;  // string | Filter on need to check (optional) 

            try
            {
                // Lists all tapes.
                TapeCollection result = apiInstance.IndexTapesByPool(poolId, limit, offset, sortBy, id, tapeLibraryId, barcode, location, type, locked, scratch, cleaning, writeProtect, mounted, ejected, known, mountCount, dateIn, dateMove, free, max, lastSizeUpdate, lastMaintenance, lastRepack, repackStatus, hash, forceImportType, needToCheck);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.IndexTapesByPool: " + e.Message );
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
 **tapeLibraryId** | **string**| Filter on tape library id | [optional] 
 **barcode** | **string**| Filter on barcode | [optional] 
 **location** | **string**| Filter on location | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **locked** | **string**| Filter on locked | [optional] 
 **scratch** | **string**| Filter on scratch | [optional] 
 **cleaning** | **string**| Filter on cleaning | [optional] 
 **writeProtect** | **string**| Filter on write protect | [optional] 
 **mounted** | **string**| Filter on mounted | [optional] 
 **ejected** | **string**| Filter on ejected | [optional] 
 **known** | **string**| Filter on known | [optional] 
 **mountCount** | **string**| Filter on mount count | [optional] 
 **dateIn** | **string**| Filter on date in | [optional] 
 **dateMove** | **string**| Filter on date move | [optional] 
 **free** | **string**| Filter on free | [optional] 
 **max** | **string**| Filter on max | [optional] 
 **lastSizeUpdate** | **string**| Filter on last size update | [optional] 
 **lastMaintenance** | **string**| Filter on last maintenance | [optional] 
 **lastRepack** | **string**| Filter on last repack | [optional] 
 **repackStatus** | **string**| Filter on repack status | [optional] 
 **hash** | **string**| Filter on hash | [optional] 
 **forceImportType** | **string**| Filter on force import type | [optional] 
 **needToCheck** | **string**| Filter on need to check | [optional] 

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

<a name="indextapesbytapelibrary"></a>
# **IndexTapesByTapeLibrary**
> TapeCollection IndexTapesByTapeLibrary (string tapeLibraryId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string poolId = null, string barcode = null, string location = null, string type = null, string locked = null, string scratch = null, string cleaning = null, string writeProtect = null, string mounted = null, string ejected = null, string known = null, string mountCount = null, string dateIn = null, string dateMove = null, string free = null, string max = null, string lastSizeUpdate = null, string lastMaintenance = null, string lastRepack = null, string repackStatus = null, string hash = null, string forceImportType = null, string needToCheck = null)

Lists all tapes.

**API Key Scope**: tapes / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapesByTapeLibraryExample
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

            var apiInstance = new TapesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var poolId = poolId_example;  // string | Filter on a pool id (optional) 
            var barcode = barcode_example;  // string | Filter on barcode (optional) 
            var location = location_example;  // string | Filter on location (optional) 
            var type = type_example;  // string | Filter on type (optional) 
            var locked = locked_example;  // string | Filter on locked (optional) 
            var scratch = scratch_example;  // string | Filter on scratch (optional) 
            var cleaning = cleaning_example;  // string | Filter on cleaning (optional) 
            var writeProtect = writeProtect_example;  // string | Filter on write protect (optional) 
            var mounted = mounted_example;  // string | Filter on mounted (optional) 
            var ejected = ejected_example;  // string | Filter on ejected (optional) 
            var known = known_example;  // string | Filter on known (optional) 
            var mountCount = mountCount_example;  // string | Filter on mount count (optional) 
            var dateIn = dateIn_example;  // string | Filter on date in (optional) 
            var dateMove = dateMove_example;  // string | Filter on date move (optional) 
            var free = free_example;  // string | Filter on free (optional) 
            var max = max_example;  // string | Filter on max (optional) 
            var lastSizeUpdate = lastSizeUpdate_example;  // string | Filter on last size update (optional) 
            var lastMaintenance = lastMaintenance_example;  // string | Filter on last maintenance (optional) 
            var lastRepack = lastRepack_example;  // string | Filter on last repack (optional) 
            var repackStatus = repackStatus_example;  // string | Filter on repack status (optional) 
            var hash = hash_example;  // string | Filter on hash (optional) 
            var forceImportType = forceImportType_example;  // string | Filter on force import type (optional) 
            var needToCheck = needToCheck_example;  // string | Filter on need to check (optional) 

            try
            {
                // Lists all tapes.
                TapeCollection result = apiInstance.IndexTapesByTapeLibrary(tapeLibraryId, limit, offset, sortBy, id, poolId, barcode, location, type, locked, scratch, cleaning, writeProtect, mounted, ejected, known, mountCount, dateIn, dateMove, free, max, lastSizeUpdate, lastMaintenance, lastRepack, repackStatus, hash, forceImportType, needToCheck);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.IndexTapesByTapeLibrary: " + e.Message );
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
 **tapeLibraryId** | **string**| Numeric ID, serial, or name of tape library. | 
 **limit** | **int?**| The number of items to display for pagination. | [optional] 
 **offset** | **int?**| The number of items to skip for pagination. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort results by attribute.  Can sort on multiple attributes, separated by &#x60;|&#x60;. Order direction can be suffixing the attribute by either &#x60;:asc&#x60; (default) or &#x60;:desc&#x60;. | [optional] 
 **id** | **string**| Filter on id | [optional] 
 **poolId** | **string**| Filter on a pool id | [optional] 
 **barcode** | **string**| Filter on barcode | [optional] 
 **location** | **string**| Filter on location | [optional] 
 **type** | **string**| Filter on type | [optional] 
 **locked** | **string**| Filter on locked | [optional] 
 **scratch** | **string**| Filter on scratch | [optional] 
 **cleaning** | **string**| Filter on cleaning | [optional] 
 **writeProtect** | **string**| Filter on write protect | [optional] 
 **mounted** | **string**| Filter on mounted | [optional] 
 **ejected** | **string**| Filter on ejected | [optional] 
 **known** | **string**| Filter on known | [optional] 
 **mountCount** | **string**| Filter on mount count | [optional] 
 **dateIn** | **string**| Filter on date in | [optional] 
 **dateMove** | **string**| Filter on date move | [optional] 
 **free** | **string**| Filter on free | [optional] 
 **max** | **string**| Filter on max | [optional] 
 **lastSizeUpdate** | **string**| Filter on last size update | [optional] 
 **lastMaintenance** | **string**| Filter on last maintenance | [optional] 
 **lastRepack** | **string**| Filter on last repack | [optional] 
 **repackStatus** | **string**| Filter on repack status | [optional] 
 **hash** | **string**| Filter on hash | [optional] 
 **forceImportType** | **string**| Filter on force import type | [optional] 
 **needToCheck** | **string**| Filter on need to check | [optional] 

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

<a name="mountstatustape"></a>
# **MountStatusTape**
> MountStatus MountStatusTape (string tapeId)

Get mount status of Tape.

**API Key Scope**: tapes / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusTapeExample
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

            var apiInstance = new TapesApi(config);
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Get mount status of Tape.
                MountStatus result = apiInstance.MountStatusTape(tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.MountStatusTape: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

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

<a name="mountstatustapebypool"></a>
# **MountStatusTapeByPool**
> MountStatus MountStatusTapeByPool (string poolId, string tapeId)

Get mount status of Tape.

**API Key Scope**: tapes / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusTapeByPoolExample
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

            var apiInstance = new TapesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Get mount status of Tape.
                MountStatus result = apiInstance.MountStatusTapeByPool(poolId, tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.MountStatusTapeByPool: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

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

<a name="mountstatustapebytapelibrary"></a>
# **MountStatusTapeByTapeLibrary**
> MountStatus MountStatusTapeByTapeLibrary (string tapeLibraryId, string tapeId)

Get mount status of Tape.

**API Key Scope**: tapes / mount_status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class MountStatusTapeByTapeLibraryExample
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

            var apiInstance = new TapesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Get mount status of Tape.
                MountStatus result = apiInstance.MountStatusTapeByTapeLibrary(tapeLibraryId, tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.MountStatusTapeByTapeLibrary: " + e.Message );
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
 **tapeLibraryId** | **string**| Numeric ID, serial, or name of tape library. | 
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

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

<a name="showtape"></a>
# **ShowTape**
> Tape ShowTape (string tapeId)

Displays a specific tape.

**API Key Scope**: tapes / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeExample
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

            var apiInstance = new TapesApi(config);
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Displays a specific tape.
                Tape result = apiInstance.ShowTape(tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.ShowTape: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

### Return type

[**Tape**](Tape.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapebypool"></a>
# **ShowTapeByPool**
> Tape ShowTapeByPool (string poolId, string tapeId)

Displays a specific tape.

**API Key Scope**: tapes / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeByPoolExample
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

            var apiInstance = new TapesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Displays a specific tape.
                Tape result = apiInstance.ShowTapeByPool(poolId, tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.ShowTapeByPool: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

### Return type

[**Tape**](Tape.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapebytapelibrary"></a>
# **ShowTapeByTapeLibrary**
> Tape ShowTapeByTapeLibrary (string tapeLibraryId, string tapeId)

Displays a specific tape.

**API Key Scope**: tapes / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeByTapeLibraryExample
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

            var apiInstance = new TapesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Displays a specific tape.
                Tape result = apiInstance.ShowTapeByTapeLibrary(tapeLibraryId, tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.ShowTapeByTapeLibrary: " + e.Message );
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
 **tapeLibraryId** | **string**| Numeric ID, serial, or name of tape library. | 
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

### Return type

[**Tape**](Tape.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapestat"></a>
# **ShowTapeStat**
> TapeStat ShowTapeStat (string tapeId)

Display statistic for a specific tape.

**API Key Scope**: tape_stats / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeStatExample
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

            var apiInstance = new TapesApi(config);
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Display statistic for a specific tape.
                TapeStat result = apiInstance.ShowTapeStat(tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.ShowTapeStat: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

### Return type

[**TapeStat**](TapeStat.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape statistic. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapestatbypool"></a>
# **ShowTapeStatByPool**
> TapeStat ShowTapeStatByPool (string poolId, string tapeId)

Display statistic for a specific tape.

**API Key Scope**: tape_stats / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeStatByPoolExample
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

            var apiInstance = new TapesApi(config);
            var poolId = poolId_example;  // string | Numeric ID, or name of pool.
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Display statistic for a specific tape.
                TapeStat result = apiInstance.ShowTapeStatByPool(poolId, tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.ShowTapeStatByPool: " + e.Message );
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
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

### Return type

[**TapeStat**](TapeStat.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape statistic. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapestatbytapelibrary"></a>
# **ShowTapeStatByTapeLibrary**
> TapeStat ShowTapeStatByTapeLibrary (string tapeLibraryId, string tapeId)

Display statistic for a specific tape.

**API Key Scope**: tape_stats / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeStatByTapeLibraryExample
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

            var apiInstance = new TapesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeId = tapeId_example;  // string | Numeric ID, or barcode of tape.

            try
            {
                // Display statistic for a specific tape.
                TapeStat result = apiInstance.ShowTapeStatByTapeLibrary(tapeLibraryId, tapeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapesApi.ShowTapeStatByTapeLibrary: " + e.Message );
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
 **tapeLibraryId** | **string**| Numeric ID, serial, or name of tape library. | 
 **tapeId** | **string**| Numeric ID, or barcode of tape. | 

### Return type

[**TapeStat**](TapeStat.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape statistic. |  -  |
| **404** | The requested resource was not found. The detailed error will be of type &#x60;not_found&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

