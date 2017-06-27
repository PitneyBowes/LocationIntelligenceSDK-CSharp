# pb.locationIntelligence.Api.LIAPIGeoPropertyServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGeoPropertyByAddress**](LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddress) | **GET** /geoproperty/v1/{category}/attributes/byaddress | Gets GeoPropertyResponse
[**GetGeoPropertyByAddressBatch**](LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddressbatch) | **POST** /geoproperty/v1/{category}/attributes/byaddress | Gets GeoPropertyResponses
[**GetGeoPropertyByPBKey**](LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkey) | **GET** /geoproperty/v1/{category}/attributes/bypbkey | Gets GeoPropertyResponse
[**GetGeoPropertyByPBKeyBatch**](LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkeybatch) | **POST** /geoproperty/v1/{category}/attributes/bypbkey | Gets GeoPropertyResponses


<a name="getgeopropertybyaddress"></a>
# **GetGeoPropertyByAddress**
> GeoPropertyResponse GetGeoPropertyByAddress (string address, string category)

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
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var address = address_example;  // string | free form address text
            var category = category_example;  // string | all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate

            try
            {
                // Gets GeoPropertyResponse
                GeoPropertyResponse result = apiInstance.GetGeoPropertyByAddress(address, category);
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
 **category** | **string**| all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate | 

### Return type

[**GeoPropertyResponse**](GeoPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybyaddressbatch"></a>
# **GetGeoPropertyByAddressBatch**
> GeoPropertyResponses GetGeoPropertyByAddressBatch (string category, GeoPropertyAddressRequest body = null)

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
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var category = category_example;  // string | all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate
            var body = new GeoPropertyAddressRequest(); // GeoPropertyAddressRequest |  (optional) 

            try
            {
                // Gets GeoPropertyResponses
                GeoPropertyResponses result = apiInstance.GetGeoPropertyByAddressBatch(category, body);
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
 **category** | **string**| all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate | 
 **body** | [**GeoPropertyAddressRequest**](GeoPropertyAddressRequest.md)|  | [optional] 

### Return type

[**GeoPropertyResponses**](GeoPropertyResponses.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybypbkey"></a>
# **GetGeoPropertyByPBKey**
> GeoPropertyResponse GetGeoPropertyByPBKey (string pbKey, string category)

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
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var pbKey = pbKey_example;  // string | free form text
            var category = category_example;  // string | all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate

            try
            {
                // Gets GeoPropertyResponse
                GeoPropertyResponse result = apiInstance.GetGeoPropertyByPBKey(pbKey, category);
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
 **category** | **string**| all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate | 

### Return type

[**GeoPropertyResponse**](GeoPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybypbkeybatch"></a>
# **GetGeoPropertyByPBKeyBatch**
> GeoPropertyResponses GetGeoPropertyByPBKeyBatch (string category, GeoPropertyPBKeyRequest body = null)

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
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var category = category_example;  // string | all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate
            var body = new GeoPropertyPBKeyRequest(); // GeoPropertyPBKeyRequest |  (optional) 

            try
            {
                // Gets GeoPropertyResponses
                GeoPropertyResponses result = apiInstance.GetGeoPropertyByPBKeyBatch(category, body);
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
 **category** | **string**| all, insuranceBasic, insuranceExtended, owner, financialServices, retail, realEstate | 
 **body** | [**GeoPropertyPBKeyRequest**](GeoPropertyPBKeyRequest.md)|  | [optional] 

### Return type

[**GeoPropertyResponses**](GeoPropertyResponses.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

