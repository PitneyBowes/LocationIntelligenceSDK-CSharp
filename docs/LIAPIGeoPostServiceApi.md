# pb.locationIntelligence.Api.LIAPIGeoPostServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCarrierRoutesByAddress**](LIAPIGeoPostServiceApi.md#getcarrierroutesbyaddress) | **GET** /geopost/v1/carrierroute/byaddress | Carrier Route By Address.
[**GetCarrierRoutesByAddressBatch**](LIAPIGeoPostServiceApi.md#getcarrierroutesbyaddressbatch) | **POST** /geopost/v1/carrierroute/byaddress | Gets GeoPost Carrier Routes for Multiple Addresses


<a name="getcarrierroutesbyaddress"></a>
# **GetCarrierRoutesByAddress**
> CarrierRouteResponse GetCarrierRoutesByAddress (string address, string includeGeometry = null)

Carrier Route By Address.

Get United States Postal Service (USPS) carrier route data for the requested address

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetCarrierRoutesByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPostServiceApi();
            var address = address_example;  // string | free form address text
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is Y) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Carrier Route By Address.
                CarrierRouteResponse result = apiInstance.GetCarrierRoutesByAddress(address, includeGeometry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPostServiceApi.GetCarrierRoutesByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **includeGeometry** | **string**| Y or N (default is Y) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**CarrierRouteResponse**](CarrierRouteResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarrierroutesbyaddressbatch"></a>
# **GetCarrierRoutesByAddressBatch**
> CarrierRouteResponseList GetCarrierRoutesByAddressBatch (CarrierRouteAddressRequest body = null)

Gets GeoPost Carrier Routes for Multiple Addresses

Gets GeoPost Carrier Routes for Multiple Addresses

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetCarrierRoutesByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPostServiceApi();
            var body = new CarrierRouteAddressRequest(); // CarrierRouteAddressRequest |  (optional) 

            try
            {
                // Gets GeoPost Carrier Routes for Multiple Addresses
                CarrierRouteResponseList result = apiInstance.GetCarrierRoutesByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPostServiceApi.GetCarrierRoutesByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarrierRouteAddressRequest**](CarrierRouteAddressRequest.md)|  | [optional] 

### Return type

[**CarrierRouteResponseList**](CarrierRouteResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

