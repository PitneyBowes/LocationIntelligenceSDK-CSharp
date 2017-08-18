# pb.locationIntelligence.Api.LIAPIGeoPropertyServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGeoPropertyByAddress**](LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddress) | **GET** /geoproperty/v1/all/attributes/byaddress | Gets GeoPropertyResponse
[**GetGeoPropertyByAddressBatch**](LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddressbatch) | **POST** /geoproperty/v1/all/attributes/byaddress | Gets GeoPropertyResponses
[**GetGeoPropertyByPBKey**](LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkey) | **GET** /geoproperty/v1/all/attributes/bypbkey | Gets GeoPropertyResponse
[**GetGeoPropertyByPBKeyBatch**](LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkeybatch) | **POST** /geoproperty/v1/all/attributes/bypbkey | Gets GeoPropertyResponses


<a name="getgeopropertybyaddress"></a>
# **GetGeoPropertyByAddress**
> GeoPropertyResponse GetGeoPropertyByAddress (string address)

Gets GeoPropertyResponse

Gets GeoPropertyResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var address = address_example;  // string | free form address text

            try
            {
                // Gets GeoPropertyResponse
                GeoPropertyResponse result = apiInstance.GetGeoPropertyByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 

### Return type

[**GeoPropertyResponse**](GeoPropertyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybyaddressbatch"></a>
# **GetGeoPropertyByAddressBatch**
> GeoPropertyResponses GetGeoPropertyByAddressBatch (GeoPropertyAddressRequest body = null)

Gets GeoPropertyResponses

Gets GeoPropertyResponses

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var body = new GeoPropertyAddressRequest(); // GeoPropertyAddressRequest |  (optional) 

            try
            {
                // Gets GeoPropertyResponses
                GeoPropertyResponses result = apiInstance.GetGeoPropertyByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeoPropertyAddressRequest**](GeoPropertyAddressRequest.md)|  | [optional] 

### Return type

[**GeoPropertyResponses**](GeoPropertyResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybypbkey"></a>
# **GetGeoPropertyByPBKey**
> GeoPropertyResponse GetGeoPropertyByPBKey (string pbKey)

Gets GeoPropertyResponse

Gets GeoPropertyResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var pbKey = pbKey_example;  // string | free form text

            try
            {
                // Gets GeoPropertyResponse
                GeoPropertyResponse result = apiInstance.GetGeoPropertyByPBKey(pbKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByPBKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbKey** | **string**| free form text | 

### Return type

[**GeoPropertyResponse**](GeoPropertyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybypbkeybatch"></a>
# **GetGeoPropertyByPBKeyBatch**
> GeoPropertyResponses GetGeoPropertyByPBKeyBatch (GeoPropertyPBKeyRequest body = null)

Gets GeoPropertyResponses

Gets GeoPropertyResponses

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByPBKeyBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var body = new GeoPropertyPBKeyRequest(); // GeoPropertyPBKeyRequest |  (optional) 

            try
            {
                // Gets GeoPropertyResponses
                GeoPropertyResponses result = apiInstance.GetGeoPropertyByPBKeyBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByPBKeyBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeoPropertyPBKeyRequest**](GeoPropertyPBKeyRequest.md)|  | [optional] 

### Return type

[**GeoPropertyResponses**](GeoPropertyResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

