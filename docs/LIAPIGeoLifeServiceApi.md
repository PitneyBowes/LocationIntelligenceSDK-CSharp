# pb.locationIntelligence.Api.LIAPIGeoLifeServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDemographicsByAddressV2**](LIAPIGeoLifeServiceApi.md#getdemographicsbyaddressv2) | **GET** /geolife/v2/demographics/byaddress | Demographics By Address.
[**GetDemographicsByLocationV2**](LIAPIGeoLifeServiceApi.md#getdemographicsbylocationv2) | **GET** /geolife/v2/demographics/bylocation | Demographics By Location.
[**GetDemographicsByPBKey**](LIAPIGeoLifeServiceApi.md#getdemographicsbypbkey) | **GET** /geolife/v2/demographics/bypbkey | Demographics By PBKey.
[**GetSegmentationByAddress**](LIAPIGeoLifeServiceApi.md#getsegmentationbyaddress) | **GET** /geolife/v1/segmentation/byaddress | Segmentation By Address.
[**GetSegmentationByLocation**](LIAPIGeoLifeServiceApi.md#getsegmentationbylocation) | **GET** /geolife/v1/segmentation/bylocation | Segmentation By Location.
[**GetSegmentationByPBKey**](LIAPIGeoLifeServiceApi.md#getsegmentationbypbkey) | **GET** /geolife/v1/segmentation/bypbkey | Segmentation By PB Key.


<a name="getdemographicsbyaddressv2"></a>
# **GetDemographicsByAddressV2**
> DemographicsV2 GetDemographicsByAddressV2 (string address, string country = null, string profile = null, string filter = null, string valueFormat = null, string variableLevel = null)

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
    public class GetDemographicsByAddressV2Example
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var address = address_example;  // string | The address to be searched.
            var country = country_example;  // string | 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,AUS. (optional) 
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 
            var valueFormat = valueFormat_example;  // string | The 'valueFormat' parameter is applicable for few ranged variables where percent & count both are available and filter response based on the input value. (optional)  (default to PercentAsAvailable)
            var variableLevel = variableLevel_example;  // string | The 'variableLevel' retrieves demographic facts in response based on the input value (optional)  (default to Key)

            try
            {
                // Demographics By Address.
                DemographicsV2 result = apiInstance.GetDemographicsByAddressV2(address, country, profile, filter, valueFormat, variableLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetDemographicsByAddressV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 
 **country** | **string**| 3 letter ISO code of the country to be searched.Allowed values USA,CAN,GBR,AUS. | [optional] 
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 
 **valueFormat** | **string**| The &#39;valueFormat&#39; parameter is applicable for few ranged variables where percent &amp; count both are available and filter response based on the input value. | [optional] [default to PercentAsAvailable]
 **variableLevel** | **string**| The &#39;variableLevel&#39; retrieves demographic facts in response based on the input value | [optional] [default to Key]

### Return type

[**DemographicsV2**](DemographicsV2.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdemographicsbylocationv2"></a>
# **GetDemographicsByLocationV2**
> DemographicsV2 GetDemographicsByLocationV2 (string longitude, string latitude, string profile = null, string filter = null, string valueFormat = null, string variableLevel = null)

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
    public class GetDemographicsByLocationV2Example
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by location) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 
            var valueFormat = valueFormat_example;  // string | The 'valueFormat' parameter is applicable for few ranged variables where percent & count both are available and filter response based on the input value. (optional)  (default to PercentAsAvailable)
            var variableLevel = variableLevel_example;  // string | The 'variableLevel' retrieves demographic facts in response based on the input value (optional)  (default to Key)

            try
            {
                // Demographics By Location.
                DemographicsV2 result = apiInstance.GetDemographicsByLocationV2(longitude, latitude, profile, filter, valueFormat, variableLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetDemographicsByLocationV2: " + e.Message );
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
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by location) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 
 **valueFormat** | **string**| The &#39;valueFormat&#39; parameter is applicable for few ranged variables where percent &amp; count both are available and filter response based on the input value. | [optional] [default to PercentAsAvailable]
 **variableLevel** | **string**| The &#39;variableLevel&#39; retrieves demographic facts in response based on the input value | [optional] [default to Key]

### Return type

[**DemographicsV2**](DemographicsV2.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdemographicsbypbkey"></a>
# **GetDemographicsByPBKey**
> DemographicsV2 GetDemographicsByPBKey (string pbKey, string profile = null, string filter = null, string valueFormat = null, string variableLevel = null)

Demographics By PBKey.

Provides the demographic details for a specified PB Key. GeoLife 'bypbkey' service accepts pbkey as an input to return a specific population segment's age group, ethnicity, income, purchasing behaviour, commuter patterns and more.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetDemographicsByPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var pbKey = pbKey_example;  // string | free form text
            var profile = profile_example;  // string | Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending (optional) 
            var filter = filter_example;  // string | The 'filter' parameter retrieves the demographic data based upon specified input themes. (optional) 
            var valueFormat = valueFormat_example;  // string | The 'valueFormat' parameter is applicable for few ranged variables where percent & count both are available and filter response based on the input value. (optional)  (default to PercentAsAvailable)
            var variableLevel = variableLevel_example;  // string | The 'variableLevel' retrieves demographic facts in response based on the input value (optional)  (default to Key)

            try
            {
                // Demographics By PBKey.
                DemographicsV2 result = apiInstance.GetDemographicsByPBKey(pbKey, profile, filter, valueFormat, variableLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetDemographicsByPBKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbKey** | **string**| free form text | 
 **profile** | **string**| Retrieves the sorted demographic data on the basis of pre-defined profiles that can display the top 3 or top 5 results (by address) either in ascending or descending order.Allowed values Top5Ascending,Top5Descending,Top3Ascending,Top3Descending | [optional] 
 **filter** | **string**| The &#39;filter&#39; parameter retrieves the demographic data based upon specified input themes. | [optional] 
 **valueFormat** | **string**| The &#39;valueFormat&#39; parameter is applicable for few ranged variables where percent &amp; count both are available and filter response based on the input value. | [optional] [default to PercentAsAvailable]
 **variableLevel** | **string**| The &#39;variableLevel&#39; retrieves demographic facts in response based on the input value | [optional] [default to Key]

### Return type

[**DemographicsV2**](DemographicsV2.md)

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

Provides the segmentation details around a specified address. GeoLife 'Segmentation by Address' service accepts address as an input to return the lifestyle characteristics of households in terms of their family status, children characteristics, income behaviors, financial preferences and interests.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

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

<a name="getsegmentationbypbkey"></a>
# **GetSegmentationByPBKey**
> Segmentation GetSegmentationByPBKey (string pbKey)

Segmentation By PB Key.

Provides the segmentation details for a PB Key. GeoLife 'segmentation bypbkey' service accepts free form text PB Key as an input to return the lifestyle characteristics of households in terms of their family status, children characteristics, income behaviors, financial preferences and interests.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSegmentationByPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoLifeServiceApi();
            var pbKey = pbKey_example;  // string | free form text

            try
            {
                // Segmentation By PB Key.
                Segmentation result = apiInstance.GetSegmentationByPBKey(pbKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoLifeServiceApi.GetSegmentationByPBKey: " + e.Message );
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

[**Segmentation**](Segmentation.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

