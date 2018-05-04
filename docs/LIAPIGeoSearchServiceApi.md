# pb.locationIntelligence.Api.LIAPIGeoSearchServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GeoSearch**](LIAPIGeoSearchServiceApi.md#geosearch) | **GET** /geosearch/v1/locations | Gets LocationList


<a name="geosearch"></a>
# **GeoSearch**
> GeosearchLocations GeoSearch (string searchText, string latitude = null, string longitude = null, string searchRadius = null, string searchRadiusUnit = null, string maxCandidates = null, string country = null, string matchOnAddressNumber = null, string autoDetectLocation = null, string ipAddress = null, string areaName1 = null, string areaName3 = null, string postCode = null)

Gets LocationList

Gets LocationList

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GeoSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoSearchServiceApi();
            var searchText = searchText_example;  // string | The input to be searched.
            var latitude = latitude_example;  // string | Latitude of the location. Either the latitude or the longitude must be provided. (optional) 
            var longitude = longitude_example;  // string | Longitude of the location. Either the latitude or the longitude must be provided. (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of addresses that can be retrieved. (optional) 
            var country = country_example;  // string | Country ISO code. We need to make sure that either Lat/Lng or Country is provided to API (optional) 
            var matchOnAddressNumber = matchOnAddressNumber_example;  // string | Option so that we force api to match on address number (optional) 
            var autoDetectLocation = autoDetectLocation_example;  // string | Option to allow API to detect origin of API request automatically (optional)  (default to true)
            var ipAddress = ipAddress_example;  // string |  (optional) 
            var areaName1 = areaName1_example;  // string | State province of the input to be searched (optional) 
            var areaName3 = areaName3_example;  // string | City of the input to be searched (optional) 
            var postCode = postCode_example;  // string | Postal Code of the input to be searched (optional) 

            try
            {
                // Gets LocationList
                GeosearchLocations result = apiInstance.GeoSearch(searchText, latitude, longitude, searchRadius, searchRadiusUnit, maxCandidates, country, matchOnAddressNumber, autoDetectLocation, ipAddress, areaName1, areaName3, postCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoSearchServiceApi.GeoSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchText** | **string**| The input to be searched. | 
 **latitude** | **string**| Latitude of the location. Either the latitude or the longitude must be provided. | [optional] 
 **longitude** | **string**| Longitude of the location. Either the latitude or the longitude must be provided. | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **maxCandidates** | **string**| Maximum number of addresses that can be retrieved. | [optional] 
 **country** | **string**| Country ISO code. We need to make sure that either Lat/Lng or Country is provided to API | [optional] 
 **matchOnAddressNumber** | **string**| Option so that we force api to match on address number | [optional] 
 **autoDetectLocation** | **string**| Option to allow API to detect origin of API request automatically | [optional] [default to true]
 **ipAddress** | **string**|  | [optional] 
 **areaName1** | **string**| State province of the input to be searched | [optional] 
 **areaName3** | **string**| City of the input to be searched | [optional] 
 **postCode** | **string**| Postal Code of the input to be searched | [optional] 

### Return type

[**GeosearchLocations**](GeosearchLocations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

