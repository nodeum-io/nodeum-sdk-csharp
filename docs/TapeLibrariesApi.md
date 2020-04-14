# Io.Nodeum.Sdk.Api.TapeLibrariesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTapeLibrary**](TapeLibrariesApi.md#createtapelibrary) | **POST** /tape_libraries | Creates a new tape library.
[**DestroyTapeLibrary**](TapeLibrariesApi.md#destroytapelibrary) | **DELETE** /tape_libraries/{tape_library_id} | Destroys a specific tape library.
[**IndexTapeLibraries**](TapeLibrariesApi.md#indextapelibraries) | **GET** /tape_libraries | Lists all tape libraries.
[**IndexTapeLibraryDevices**](TapeLibrariesApi.md#indextapelibrarydevices) | **GET** /tape_libraries/-/devices | Lists tape libraries devices.
[**ShowTapeLibrary**](TapeLibrariesApi.md#showtapelibrary) | **GET** /tape_libraries/{tape_library_id} | Displays a specific tape library.
[**UpdateTapeLibrary**](TapeLibrariesApi.md#updatetapelibrary) | **PUT** /tape_libraries/{tape_library_id} | Updates a specific tape library.


<a name="createtapelibrary"></a>
# **CreateTapeLibrary**
> TapeLibrary CreateTapeLibrary (TapeLibrary tapeLibraryBody)

Creates a new tape library.

**API Key Scope**: tape_libraries / create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateTapeLibraryExample
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

            var apiInstance = new TapeLibrariesApi(config);
            var tapeLibraryBody = new TapeLibrary(); // TapeLibrary | 

            try
            {
                // Creates a new tape library.
                TapeLibrary result = apiInstance.CreateTapeLibrary(tapeLibraryBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeLibrariesApi.CreateTapeLibrary: " + e.Message );
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
 **tapeLibraryBody** | [**TapeLibrary**](TapeLibrary.md)|  | 

### Return type

[**TapeLibrary**](TapeLibrary.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific tape library. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroytapelibrary"></a>
# **DestroyTapeLibrary**
> void DestroyTapeLibrary (string tapeLibraryId)

Destroys a specific tape library.

**API Key Scope**: tape_libraries / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTapeLibraryExample
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

            var apiInstance = new TapeLibrariesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.

            try
            {
                // Destroys a specific tape library.
                apiInstance.DestroyTapeLibrary(tapeLibraryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeLibrariesApi.DestroyTapeLibrary: " + e.Message );
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
| **204** | Tape library destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapelibraries"></a>
# **IndexTapeLibraries**
> TapeLibraryCollection IndexTapeLibraries (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string serial = null, string comment = null, string protocol = null, string vendor = null, string product = null, string firmware = null, string device = null, string libso = null, string acs = null, string status = null, string storageSlots = null, string storageSlotsAddress = null, string ioSlots = null, string ioSlotsAddress = null, string price = null)

Lists all tape libraries.

**API Key Scope**: tape_libraries / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapeLibrariesExample
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

            var apiInstance = new TapeLibrariesApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var serial = serial_example;  // string | Filter on serial (optional) 
            var comment = comment_example;  // string | Filter on comment (optional) 
            var protocol = protocol_example;  // string | Filter on protocol (optional) 
            var vendor = vendor_example;  // string | Filter on vendor (optional) 
            var product = product_example;  // string | Filter on product (optional) 
            var firmware = firmware_example;  // string | Filter on firmware (optional) 
            var device = device_example;  // string | Filter on device (optional) 
            var libso = libso_example;  // string | Filter on libso (optional) 
            var acs = acs_example;  // string | Filter on acs (optional) 
            var status = status_example;  // string | Filter on status (optional) 
            var storageSlots = storageSlots_example;  // string | Filter on storage slots (optional) 
            var storageSlotsAddress = storageSlotsAddress_example;  // string | Filter on storage slots address (optional) 
            var ioSlots = ioSlots_example;  // string | Filter on io slots (optional) 
            var ioSlotsAddress = ioSlotsAddress_example;  // string | Filter on io slots address (optional) 
            var price = price_example;  // string | Filter on price (optional) 

            try
            {
                // Lists all tape libraries.
                TapeLibraryCollection result = apiInstance.IndexTapeLibraries(limit, offset, sortBy, id, name, serial, comment, protocol, vendor, product, firmware, device, libso, acs, status, storageSlots, storageSlotsAddress, ioSlots, ioSlotsAddress, price);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeLibrariesApi.IndexTapeLibraries: " + e.Message );
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
 **serial** | **string**| Filter on serial | [optional] 
 **comment** | **string**| Filter on comment | [optional] 
 **protocol** | **string**| Filter on protocol | [optional] 
 **vendor** | **string**| Filter on vendor | [optional] 
 **product** | **string**| Filter on product | [optional] 
 **firmware** | **string**| Filter on firmware | [optional] 
 **device** | **string**| Filter on device | [optional] 
 **libso** | **string**| Filter on libso | [optional] 
 **acs** | **string**| Filter on acs | [optional] 
 **status** | **string**| Filter on status | [optional] 
 **storageSlots** | **string**| Filter on storage slots | [optional] 
 **storageSlotsAddress** | **string**| Filter on storage slots address | [optional] 
 **ioSlots** | **string**| Filter on io slots | [optional] 
 **ioSlotsAddress** | **string**| Filter on io slots address | [optional] 
 **price** | **string**| Filter on price | [optional] 

### Return type

[**TapeLibraryCollection**](TapeLibraryCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tape libraries. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapelibrarydevices"></a>
# **IndexTapeLibraryDevices**
> TapeLibraryDeviceCollection IndexTapeLibraryDevices (string jobId)

Lists tape libraries devices.

**API Key Scope**: tape_libraries / devices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapeLibraryDevicesExample
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

            var apiInstance = new TapeLibrariesApi(config);
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Lists tape libraries devices.
                TapeLibraryDeviceCollection result = apiInstance.IndexTapeLibraryDevices(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeLibrariesApi.IndexTapeLibraryDevices: " + e.Message );
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

[**TapeLibraryDeviceCollection**](TapeLibraryDeviceCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed, 

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tape libraries devices. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |
| **500** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapelibrary"></a>
# **ShowTapeLibrary**
> TapeLibrary ShowTapeLibrary (string tapeLibraryId)

Displays a specific tape library.

**API Key Scope**: tape_libraries / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeLibraryExample
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

            var apiInstance = new TapeLibrariesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.

            try
            {
                // Displays a specific tape library.
                TapeLibrary result = apiInstance.ShowTapeLibrary(tapeLibraryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeLibrariesApi.ShowTapeLibrary: " + e.Message );
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

### Return type

[**TapeLibrary**](TapeLibrary.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape library. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetapelibrary"></a>
# **UpdateTapeLibrary**
> TapeLibrary UpdateTapeLibrary (string tapeLibraryId, TapeLibrary tapeLibraryBody)

Updates a specific tape library.

**API Key Scope**: tape_libraries / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateTapeLibraryExample
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

            var apiInstance = new TapeLibrariesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeLibraryBody = new TapeLibrary(); // TapeLibrary | 

            try
            {
                // Updates a specific tape library.
                TapeLibrary result = apiInstance.UpdateTapeLibrary(tapeLibraryId, tapeLibraryBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeLibrariesApi.UpdateTapeLibrary: " + e.Message );
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
 **tapeLibraryBody** | [**TapeLibrary**](TapeLibrary.md)|  | 

### Return type

[**TapeLibrary**](TapeLibrary.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape library. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

