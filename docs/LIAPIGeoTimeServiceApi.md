# pb.locationIntelligence.Api.LIAPIGeoTimeServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTimezoneByAddress**](LIAPIGeoTimeServiceApi.md#gettimezonebyaddress) | **GET** /geotime/v1/timezone/byaddress | Timezone By Address.
[**GetTimezoneByLocation**](LIAPIGeoTimeServiceApi.md#gettimezonebylocation) | **GET** /geotime/v1/timezone/bylocation | Timezone By Location.


<a name="gettimezonebyaddress"></a>
# **GetTimezoneByAddress**
> Timezone GetTimezoneByAddress (string timestamp, string address)

Timezone By Address.

Identifies and retrieves the local time of any location in the world for a given address and time. The input and retrieved time format is in milliseconds.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetTimezoneByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoTimeServiceApi();
            var timestamp = timestamp_example;  // string | Timestamp in miliseconds.
            var address = address_example;  // string | The address to be searched.

            try
            {
                // Timezone By Address.
                Timezone result = apiInstance.GetTimezoneByAddress(timestamp, address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTimeServiceApi.GetTimezoneByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timestamp** | **string**| Timestamp in miliseconds. | 
 **address** | **string**| The address to be searched. | 

### Return type

[**Timezone**](Timezone.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimezonebylocation"></a>
# **GetTimezoneByLocation**
> Timezone GetTimezoneByLocation (string timestamp, string longitude, string latitude)

Timezone By Location.

Identifies and retrieves the local time of any location in the world for a given latitude, longitude and time. The input and retrieved time format is in milliseconds.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetTimezoneByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoTimeServiceApi();
            var timestamp = timestamp_example;  // string | Timestamp in miliseconds.
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // Timezone By Location.
                Timezone result = apiInstance.GetTimezoneByLocation(timestamp, longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTimeServiceApi.GetTimezoneByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timestamp** | **string**| Timestamp in miliseconds. | 
 **longitude** | **string**| Longitude of the location. | 
 **latitude** | **string**| Latitude of the location. | 

### Return type

[**Timezone**](Timezone.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

