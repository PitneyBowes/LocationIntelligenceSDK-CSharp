# pb.locationIntelligence.Api.LIAPIGeoLifeServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDemographicsByAddress**](LIAPIGeoLifeServiceApi.md#getdemographicsbyaddress) | **GET** /geolife/v1/demographics/byaddress | Demographics By Address.
[**GetDemographicsByLocation**](LIAPIGeoLifeServiceApi.md#getdemographicsbylocation) | **GET** /geolife/v1/demographics/bylocation | Demographics By Location.
[**GetSegmentationByAddress**](LIAPIGeoLifeServiceApi.md#getsegmentationbyaddress) | **GET** /geolife/v1/segmentation/byaddress | Segmentation By Address.
[**GetSegmentationByLocation**](LIAPIGeoLifeServiceApi.md#getsegmentationbylocation) | **GET** /geolife/v1/segmentation/bylocation | Segmentation By Location.


<a name="getdemographicsbyaddress"></a>
# **GetDemographicsByAddress**
> Demographics GetDemographicsByAddress (string address, string profile = null, string filter = null, string country = null)

Demographics By Address.

Provides the demographic details around a specified address. GeoLife 'byaddress' service accepts address as an input to return a specific population segment's age group, ethnicity, income, purchasing behaviour, commuter patterns and more.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetDemographicsByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var address = address_example;  // string | The address to be searched.
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 
            var country = country_example;  // string | 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,FRA,IND,ITA,AUS,DEU. (optional) 

            try
            {
                // Demographics By Address.
                Demographics result = apiInstance.GetDemographicsByAddress(address, profile, filter, country);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetDemographicsByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 
 **country** | **string**| 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,FRA,IND,ITA,AUS,DEU. | [optional] 

### Return type

[**Demographics**](Demographics.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdemographicsbylocation"></a>
# **GetDemographicsByLocation**
> Demographics GetDemographicsByLocation (string longitude, string latitude, string profile = null, string filter = null)

Demographics By Location.

Provides the demographic details around a specified location. GeoLife 'bylocation' service accepts longitude and latitude as an input to return a specific population segment's age group, ethnicity, income, purchasing behaviour, commuter patterns and more.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetDemographicsByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 

            try
            {
                // Demographics By Location.
                Demographics result = apiInstance.GetDemographicsByLocation(longitude, latitude, profile, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetDemographicsByLocation: " + e.Message );
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
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 

### Return type

[**Demographics**](Demographics.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegmentationbyaddress"></a>
# **GetSegmentationByAddress**
> Segmentation GetSegmentationByAddress (string address, string country = null)

Segmentation By Address.

Provides the segmentation details around a specified address. GeoLife 'segmentation byaddress' service accepts address as an input to return the lifestyle characteristics of households in terms of their family status, children characteristics, income behaviors, financial preferences and interests.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSegmentationByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var address = address_example;  // string | The address to be searched.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,FRA,ITA,AUS,DEU. (optional) 

            try
            {
                // Segmentation By Address.
                Segmentation result = apiInstance.GetSegmentationByAddress(address, country);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetSegmentationByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 
 **country** | **string**| 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,FRA,ITA,AUS,DEU. | [optional] 

### Return type

[**Segmentation**](Segmentation.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegmentationbylocation"></a>
# **GetSegmentationByLocation**
> Segmentation GetSegmentationByLocation (string longitude, string latitude)

Segmentation By Location.

Provides the segmentation details around a specified location. GeoLife 'segmentation bylocation' service accepts longitude and latitude as an input to return the lifestyle characteristics of households in terms of their family status, children characteristics, income behaviors, financial preferences and interests.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSegmentationByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // Segmentation By Location.
                Segmentation result = apiInstance.GetSegmentationByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetSegmentationByLocation: " + e.Message );
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

### Return type

[**Segmentation**](Segmentation.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

