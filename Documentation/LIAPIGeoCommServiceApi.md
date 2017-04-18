# pb.locationIntelligence.Api.LIAPIGeoCommServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRateCenterByAddress**](LIAPIGeoCommServiceApi.md#getratecenterbyaddress) | **GET** /geocomm/v1/ratecenter/byaddress | Rate Center By Address.
[**GetRateCenterByLocation**](LIAPIGeoCommServiceApi.md#getratecenterbylocation) | **GET** /geocomm/v1/ratecenter/bylocation | Rate Center By Location.


<a name="getratecenterbyaddress"></a>
# **GetRateCenterByAddress**
> RateCenterResponse GetRateCenterByAddress (string address, string country = null, string areaCodeInfo = null, string level = null)

Rate Center By Address.

Accepts addresses as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetRateCenterByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoCommServiceApi();
            var address = address_example;  // string | The address to be searched.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched.Allowed values USA,CAN (optional)  (default to USA)
            var areaCodeInfo = areaCodeInfo_example;  // string | Specifies whether area code information will be part of response.Allowed values True,False (optional)  (default to False)
            var level = level_example;  // string | Level (basic/detail).Allowed values detail,basic. (optional)  (default to basic)

            try
            {
                // Rate Center By Address.
                RateCenterResponse result = apiInstance.GetRateCenterByAddress(address, country, areaCodeInfo, level);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoCommServiceApi.GetRateCenterByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 
 **country** | **string**| 3 letter ISO code of the country to be searched.Allowed values USA,CAN | [optional] [default to USA]
 **areaCodeInfo** | **string**| Specifies whether area code information will be part of response.Allowed values True,False | [optional] [default to False]
 **level** | **string**| Level (basic/detail).Allowed values detail,basic. | [optional] [default to basic]

### Return type

[**RateCenterResponse**](RateCenterResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getratecenterbylocation"></a>
# **GetRateCenterByLocation**
> RateCenterResponse GetRateCenterByLocation (string longitude, string latitude, string areaCodeInfo = null, string level = null)

Rate Center By Location.

Accepts latitude & longitude as input and returns Incumbent Local Exchange Carrier (ILEC) doing-business-as names.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetRateCenterByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoCommServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var areaCodeInfo = areaCodeInfo_example;  // string | Specifies whether area code information will be part of response.Allowed values True,False. (optional)  (default to False)
            var level = level_example;  // string | Level (basic/detail).Allowed values detail,basic. (optional)  (default to basic)

            try
            {
                // Rate Center By Location.
                RateCenterResponse result = apiInstance.GetRateCenterByLocation(longitude, latitude, areaCodeInfo, level);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoCommServiceApi.GetRateCenterByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Longitude of the location. | 
 **latitude** | **string**| Latitude of the location. | 
 **areaCodeInfo** | **string**| Specifies whether area code information will be part of response.Allowed values True,False. | [optional] [default to False]
 **level** | **string**| Level (basic/detail).Allowed values detail,basic. | [optional] [default to basic]

### Return type

[**RateCenterResponse**](RateCenterResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

