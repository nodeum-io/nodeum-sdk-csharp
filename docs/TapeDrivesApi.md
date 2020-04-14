# Io.Nodeum.Sdk.Api.TapeDrivesApi

All URIs are relative to *http://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTapeDriveByTapeLibrary**](TapeDrivesApi.md#createtapedrivebytapelibrary) | **POST** /tape_libraries/{tape_library_id}/tape_drives | Creates a new tape drive.
[**DestroyTapeDrive**](TapeDrivesApi.md#destroytapedrive) | **DELETE** /tape_drives/{tape_drive_id} | Destroys a specific tape drive.
[**DestroyTapeDriveByTapeLibrary**](TapeDrivesApi.md#destroytapedrivebytapelibrary) | **DELETE** /tape_libraries/{tape_library_id}/tape_drives/{tape_drive_id} | Destroys a specific tape drive.
[**IndexTapeDriveDevices**](TapeDrivesApi.md#indextapedrivedevices) | **GET** /tape_libraries/{tape_library_id}/tape_drives/-/devices | Lists tape drives devices.
[**IndexTapeDrives**](TapeDrivesApi.md#indextapedrives) | **GET** /tape_drives | Lists all tape drives.
[**IndexTapeDrivesByTapeLibrary**](TapeDrivesApi.md#indextapedrivesbytapelibrary) | **GET** /tape_libraries/{tape_library_id}/tape_drives | Lists all tape drives.
[**ShowTapeDrive**](TapeDrivesApi.md#showtapedrive) | **GET** /tape_drives/{tape_drive_id} | Displays a specific tape drive.
[**ShowTapeDriveByTapeLibrary**](TapeDrivesApi.md#showtapedrivebytapelibrary) | **GET** /tape_libraries/{tape_library_id}/tape_drives/{tape_drive_id} | Displays a specific tape drive.
[**UpdateTapeDrive**](TapeDrivesApi.md#updatetapedrive) | **PUT** /tape_drives/{tape_drive_id} | Updates a specific tape drive.
[**UpdateTapeDriveByTapeLibrary**](TapeDrivesApi.md#updatetapedrivebytapelibrary) | **PUT** /tape_libraries/{tape_library_id}/tape_drives/{tape_drive_id} | Updates a specific tape drive.


<a name="createtapedrivebytapelibrary"></a>
# **CreateTapeDriveByTapeLibrary**
> TapeDrive CreateTapeDriveByTapeLibrary (string tapeLibraryId, TapeDrive tapeDriveBody)

Creates a new tape drive.

**API Key Scope**: tape_drives / create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class CreateTapeDriveByTapeLibraryExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeDriveBody = new TapeDrive(); // TapeDrive | 

            try
            {
                // Creates a new tape drive.
                TapeDrive result = apiInstance.CreateTapeDriveByTapeLibrary(tapeLibraryId, tapeDriveBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.CreateTapeDriveByTapeLibrary: " + e.Message );
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
 **tapeDriveBody** | [**TapeDrive**](TapeDrive.md)|  | 

### Return type

[**TapeDrive**](TapeDrive.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A specific tape drive. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroytapedrive"></a>
# **DestroyTapeDrive**
> void DestroyTapeDrive (string tapeDriveId)

Destroys a specific tape drive.

**API Key Scope**: tape_drives / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTapeDriveExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeDriveId = tapeDriveId_example;  // string | Numeric ID, serial, or name of tape drive.

            try
            {
                // Destroys a specific tape drive.
                apiInstance.DestroyTapeDrive(tapeDriveId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.DestroyTapeDrive: " + e.Message );
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
 **tapeDriveId** | **string**| Numeric ID, serial, or name of tape drive. | 

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
| **204** | Tape drive destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroytapedrivebytapelibrary"></a>
# **DestroyTapeDriveByTapeLibrary**
> void DestroyTapeDriveByTapeLibrary (string tapeLibraryId, string tapeDriveId)

Destroys a specific tape drive.

**API Key Scope**: tape_drives / destroy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class DestroyTapeDriveByTapeLibraryExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeDriveId = tapeDriveId_example;  // string | Numeric ID, serial, or name of tape drive.

            try
            {
                // Destroys a specific tape drive.
                apiInstance.DestroyTapeDriveByTapeLibrary(tapeLibraryId, tapeDriveId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.DestroyTapeDriveByTapeLibrary: " + e.Message );
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
 **tapeDriveId** | **string**| Numeric ID, serial, or name of tape drive. | 

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
| **204** | Tape drive destroyed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapedrivedevices"></a>
# **IndexTapeDriveDevices**
> TapeDriveDeviceCollection IndexTapeDriveDevices (string tapeLibraryId, string jobId)

Lists tape drives devices.

**API Key Scope**: tape_drives / devices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapeDriveDevicesExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var jobId = jobId_example;  // string | ID of active job

            try
            {
                // Lists tape drives devices.
                TapeDriveDeviceCollection result = apiInstance.IndexTapeDriveDevices(tapeLibraryId, jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.IndexTapeDriveDevices: " + e.Message );
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
 **jobId** | **string**| ID of active job | 

### Return type

[**TapeDriveDeviceCollection**](TapeDriveDeviceCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, queued, working, failed, 

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tape drives devices. |  -  |
| **202** | An active job that may be queued, working, completed or failed. |  -  |
| **500** | An active job that may be queued, working, completed or failed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapedrives"></a>
# **IndexTapeDrives**
> TapeDriveCollection IndexTapeDrives (int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string tapeLibraryId = null, string name = null, string serial = null, string comment = null, string scsiAddress = null, string vendor = null, string product = null, string firmware = null, string device = null, string sgdevice = null, string libso = null, string acs = null, string lsm = null, string panel = null, string transport = null, string status = null, string full = null, string mountCount = null, string useTo = null, string useBy = null, string barcode = null, string taskId = null, string useFileProcessedSize = null, string useFileSizeToProcess = null, string useFileNameProcessed = null, string bandwidth = null)

Lists all tape drives.

**API Key Scope**: tape_drives / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapeDrivesExample
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

            var apiInstance = new TapeDrivesApi(config);
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var tapeLibraryId = tapeLibraryId_example;  // string | Filter on tape library id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var serial = serial_example;  // string | Filter on serial (optional) 
            var comment = comment_example;  // string | Filter on comment (optional) 
            var scsiAddress = scsiAddress_example;  // string | Filter on scsi address (optional) 
            var vendor = vendor_example;  // string | Filter on vendor (optional) 
            var product = product_example;  // string | Filter on product (optional) 
            var firmware = firmware_example;  // string | Filter on firmware (optional) 
            var device = device_example;  // string | Filter on device (optional) 
            var sgdevice = sgdevice_example;  // string | Filter on sgdevice (optional) 
            var libso = libso_example;  // string | Filter on libso (optional) 
            var acs = acs_example;  // string | Filter on acs (optional) 
            var lsm = lsm_example;  // string | Filter on lsm (optional) 
            var panel = panel_example;  // string | Filter on panel (optional) 
            var transport = transport_example;  // string | Filter on transport (optional) 
            var status = status_example;  // string | Filter on status (optional) 
            var full = full_example;  // string | Filter on full (optional) 
            var mountCount = mountCount_example;  // string | Filter on mount count (optional) 
            var useTo = useTo_example;  // string | Filter on use to (optional) 
            var useBy = useBy_example;  // string | Filter on use by (optional) 
            var barcode = barcode_example;  // string | Filter on barcode (optional) 
            var taskId = taskId_example;  // string | Filter on task id (optional) 
            var useFileProcessedSize = useFileProcessedSize_example;  // string | Filter on use file processed size (optional) 
            var useFileSizeToProcess = useFileSizeToProcess_example;  // string | Filter on use file size to process (optional) 
            var useFileNameProcessed = useFileNameProcessed_example;  // string | Filter on use file name processed (optional) 
            var bandwidth = bandwidth_example;  // string | Filter on bandwidth (optional) 

            try
            {
                // Lists all tape drives.
                TapeDriveCollection result = apiInstance.IndexTapeDrives(limit, offset, sortBy, id, tapeLibraryId, name, serial, comment, scsiAddress, vendor, product, firmware, device, sgdevice, libso, acs, lsm, panel, transport, status, full, mountCount, useTo, useBy, barcode, taskId, useFileProcessedSize, useFileSizeToProcess, useFileNameProcessed, bandwidth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.IndexTapeDrives: " + e.Message );
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
 **name** | **string**| Filter on name | [optional] 
 **serial** | **string**| Filter on serial | [optional] 
 **comment** | **string**| Filter on comment | [optional] 
 **scsiAddress** | **string**| Filter on scsi address | [optional] 
 **vendor** | **string**| Filter on vendor | [optional] 
 **product** | **string**| Filter on product | [optional] 
 **firmware** | **string**| Filter on firmware | [optional] 
 **device** | **string**| Filter on device | [optional] 
 **sgdevice** | **string**| Filter on sgdevice | [optional] 
 **libso** | **string**| Filter on libso | [optional] 
 **acs** | **string**| Filter on acs | [optional] 
 **lsm** | **string**| Filter on lsm | [optional] 
 **panel** | **string**| Filter on panel | [optional] 
 **transport** | **string**| Filter on transport | [optional] 
 **status** | **string**| Filter on status | [optional] 
 **full** | **string**| Filter on full | [optional] 
 **mountCount** | **string**| Filter on mount count | [optional] 
 **useTo** | **string**| Filter on use to | [optional] 
 **useBy** | **string**| Filter on use by | [optional] 
 **barcode** | **string**| Filter on barcode | [optional] 
 **taskId** | **string**| Filter on task id | [optional] 
 **useFileProcessedSize** | **string**| Filter on use file processed size | [optional] 
 **useFileSizeToProcess** | **string**| Filter on use file size to process | [optional] 
 **useFileNameProcessed** | **string**| Filter on use file name processed | [optional] 
 **bandwidth** | **string**| Filter on bandwidth | [optional] 

### Return type

[**TapeDriveCollection**](TapeDriveCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tape drives. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="indextapedrivesbytapelibrary"></a>
# **IndexTapeDrivesByTapeLibrary**
> TapeDriveCollection IndexTapeDrivesByTapeLibrary (string tapeLibraryId, int? limit = null, int? offset = null, List<string> sortBy = null, string id = null, string name = null, string serial = null, string comment = null, string scsiAddress = null, string vendor = null, string product = null, string firmware = null, string device = null, string sgdevice = null, string libso = null, string acs = null, string lsm = null, string panel = null, string transport = null, string status = null, string full = null, string mountCount = null, string useTo = null, string useBy = null, string barcode = null, string taskId = null, string useFileProcessedSize = null, string useFileSizeToProcess = null, string useFileNameProcessed = null, string bandwidth = null)

Lists all tape drives.

**API Key Scope**: tape_drives / index

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class IndexTapeDrivesByTapeLibraryExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var limit = 56;  // int? | The number of items to display for pagination. (optional) 
            var offset = 56;  // int? | The number of items to skip for pagination. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort results by attribute.  Can sort on multiple attributes, separated by `|`. Order direction can be suffixing the attribute by either `:asc` (default) or `:desc`. (optional) 
            var id = id_example;  // string | Filter on id (optional) 
            var name = name_example;  // string | Filter on name (optional) 
            var serial = serial_example;  // string | Filter on serial (optional) 
            var comment = comment_example;  // string | Filter on comment (optional) 
            var scsiAddress = scsiAddress_example;  // string | Filter on scsi address (optional) 
            var vendor = vendor_example;  // string | Filter on vendor (optional) 
            var product = product_example;  // string | Filter on product (optional) 
            var firmware = firmware_example;  // string | Filter on firmware (optional) 
            var device = device_example;  // string | Filter on device (optional) 
            var sgdevice = sgdevice_example;  // string | Filter on sgdevice (optional) 
            var libso = libso_example;  // string | Filter on libso (optional) 
            var acs = acs_example;  // string | Filter on acs (optional) 
            var lsm = lsm_example;  // string | Filter on lsm (optional) 
            var panel = panel_example;  // string | Filter on panel (optional) 
            var transport = transport_example;  // string | Filter on transport (optional) 
            var status = status_example;  // string | Filter on status (optional) 
            var full = full_example;  // string | Filter on full (optional) 
            var mountCount = mountCount_example;  // string | Filter on mount count (optional) 
            var useTo = useTo_example;  // string | Filter on use to (optional) 
            var useBy = useBy_example;  // string | Filter on use by (optional) 
            var barcode = barcode_example;  // string | Filter on barcode (optional) 
            var taskId = taskId_example;  // string | Filter on task id (optional) 
            var useFileProcessedSize = useFileProcessedSize_example;  // string | Filter on use file processed size (optional) 
            var useFileSizeToProcess = useFileSizeToProcess_example;  // string | Filter on use file size to process (optional) 
            var useFileNameProcessed = useFileNameProcessed_example;  // string | Filter on use file name processed (optional) 
            var bandwidth = bandwidth_example;  // string | Filter on bandwidth (optional) 

            try
            {
                // Lists all tape drives.
                TapeDriveCollection result = apiInstance.IndexTapeDrivesByTapeLibrary(tapeLibraryId, limit, offset, sortBy, id, name, serial, comment, scsiAddress, vendor, product, firmware, device, sgdevice, libso, acs, lsm, panel, transport, status, full, mountCount, useTo, useBy, barcode, taskId, useFileProcessedSize, useFileSizeToProcess, useFileNameProcessed, bandwidth);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.IndexTapeDrivesByTapeLibrary: " + e.Message );
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
 **name** | **string**| Filter on name | [optional] 
 **serial** | **string**| Filter on serial | [optional] 
 **comment** | **string**| Filter on comment | [optional] 
 **scsiAddress** | **string**| Filter on scsi address | [optional] 
 **vendor** | **string**| Filter on vendor | [optional] 
 **product** | **string**| Filter on product | [optional] 
 **firmware** | **string**| Filter on firmware | [optional] 
 **device** | **string**| Filter on device | [optional] 
 **sgdevice** | **string**| Filter on sgdevice | [optional] 
 **libso** | **string**| Filter on libso | [optional] 
 **acs** | **string**| Filter on acs | [optional] 
 **lsm** | **string**| Filter on lsm | [optional] 
 **panel** | **string**| Filter on panel | [optional] 
 **transport** | **string**| Filter on transport | [optional] 
 **status** | **string**| Filter on status | [optional] 
 **full** | **string**| Filter on full | [optional] 
 **mountCount** | **string**| Filter on mount count | [optional] 
 **useTo** | **string**| Filter on use to | [optional] 
 **useBy** | **string**| Filter on use by | [optional] 
 **barcode** | **string**| Filter on barcode | [optional] 
 **taskId** | **string**| Filter on task id | [optional] 
 **useFileProcessedSize** | **string**| Filter on use file processed size | [optional] 
 **useFileSizeToProcess** | **string**| Filter on use file size to process | [optional] 
 **useFileNameProcessed** | **string**| Filter on use file name processed | [optional] 
 **bandwidth** | **string**| Filter on bandwidth | [optional] 

### Return type

[**TapeDriveCollection**](TapeDriveCollection.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tape drives. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapedrive"></a>
# **ShowTapeDrive**
> TapeDrive ShowTapeDrive (string tapeDriveId)

Displays a specific tape drive.

**API Key Scope**: tape_drives / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeDriveExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeDriveId = tapeDriveId_example;  // string | Numeric ID, serial, or name of tape drive.

            try
            {
                // Displays a specific tape drive.
                TapeDrive result = apiInstance.ShowTapeDrive(tapeDriveId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.ShowTapeDrive: " + e.Message );
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
 **tapeDriveId** | **string**| Numeric ID, serial, or name of tape drive. | 

### Return type

[**TapeDrive**](TapeDrive.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape drive. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showtapedrivebytapelibrary"></a>
# **ShowTapeDriveByTapeLibrary**
> TapeDrive ShowTapeDriveByTapeLibrary (string tapeLibraryId, string tapeDriveId)

Displays a specific tape drive.

**API Key Scope**: tape_drives / show

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class ShowTapeDriveByTapeLibraryExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeDriveId = tapeDriveId_example;  // string | Numeric ID, serial, or name of tape drive.

            try
            {
                // Displays a specific tape drive.
                TapeDrive result = apiInstance.ShowTapeDriveByTapeLibrary(tapeLibraryId, tapeDriveId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.ShowTapeDriveByTapeLibrary: " + e.Message );
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
 **tapeDriveId** | **string**| Numeric ID, serial, or name of tape drive. | 

### Return type

[**TapeDrive**](TapeDrive.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape drive. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetapedrive"></a>
# **UpdateTapeDrive**
> TapeDrive UpdateTapeDrive (string tapeDriveId, TapeDrive tapeDriveBody)

Updates a specific tape drive.

**API Key Scope**: tape_drives / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateTapeDriveExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeDriveId = tapeDriveId_example;  // string | Numeric ID, serial, or name of tape drive.
            var tapeDriveBody = new TapeDrive(); // TapeDrive | 

            try
            {
                // Updates a specific tape drive.
                TapeDrive result = apiInstance.UpdateTapeDrive(tapeDriveId, tapeDriveBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.UpdateTapeDrive: " + e.Message );
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
 **tapeDriveId** | **string**| Numeric ID, serial, or name of tape drive. | 
 **tapeDriveBody** | [**TapeDrive**](TapeDrive.md)|  | 

### Return type

[**TapeDrive**](TapeDrive.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape drive. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetapedrivebytapelibrary"></a>
# **UpdateTapeDriveByTapeLibrary**
> TapeDrive UpdateTapeDriveByTapeLibrary (string tapeLibraryId, string tapeDriveId, TapeDrive tapeDriveBody)

Updates a specific tape drive.

**API Key Scope**: tape_drives / update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Nodeum.Sdk.Api;
using Io.Nodeum.Sdk.Client;
using Io.Nodeum.Sdk.Model;

namespace Example
{
    public class UpdateTapeDriveByTapeLibraryExample
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

            var apiInstance = new TapeDrivesApi(config);
            var tapeLibraryId = tapeLibraryId_example;  // string | Numeric ID, serial, or name of tape library.
            var tapeDriveId = tapeDriveId_example;  // string | Numeric ID, serial, or name of tape drive.
            var tapeDriveBody = new TapeDrive(); // TapeDrive | 

            try
            {
                // Updates a specific tape drive.
                TapeDrive result = apiInstance.UpdateTapeDriveByTapeLibrary(tapeLibraryId, tapeDriveId, tapeDriveBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TapeDrivesApi.UpdateTapeDriveByTapeLibrary: " + e.Message );
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
 **tapeDriveId** | **string**| Numeric ID, serial, or name of tape drive. | 
 **tapeDriveBody** | [**TapeDrive**](TapeDrive.md)|  | 

### Return type

[**TapeDrive**](TapeDrive.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A specific tape drive. |  -  |
| **422** | The received resource was not correctly formatted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

