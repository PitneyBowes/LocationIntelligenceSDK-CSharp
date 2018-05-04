# pb.locationIntelligence.Api.LIAPIGeoEnrichServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddress**](LIAPIGeoEnrichServiceApi.md#getaddress) | **GET** /geoenrich/v1/address/bylocation | Address By Location.
[**GetEntityByLocation**](LIAPIGeoEnrichServiceApi.md#getentitybylocation) | **GET** /geoenrich/v1/poi/bylocation | Points Of Interest By Location.
[**GetPlaceByLocation**](LIAPIGeoEnrichServiceApi.md#getplacebylocation) | **GET** /geoenrich/v1/place/bylocation | Place By Location.


<a name="getaddress"></a>
# **GetAddress**
> Locations GetAddress (string latitude, string longitude, string searchRadius = null, string searchRadiusUnit = null)

Address By Location.

This service accepts longitude and latitude as input and returns an address for that location.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoEnrichServiceApi();
            var latitude = latitude_example;  // string | Latitude of the location.
            var longitude = longitude_example;  // string | Longitude of the location.
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as feet, kilometers, miles or meters. (optional) 

            try
            {
                // Address By Location.
                Locations result = apiInstance.GetAddress(latitude, longitude, searchRadius, searchRadiusUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoEnrichServiceApi.GetAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latitude** | **string**| Latitude of the location. | 
 **longitude** | **string**| Longitude of the location. | 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as feet, kilometers, miles or meters. | [optional] 

### Return type

[**Locations**](Locations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitybylocation"></a>
# **GetEntityByLocation**
> PoiByLocation GetEntityByLocation (string longitude, string latitude, string brandName = null, string category = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string searchDataset = null, string searchPriority = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string mode = null)

Points Of Interest By Location.

Identifies and retrieves Points of Interest that exist around a specific location (ordered by distance from the location).

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetEntityByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoEnrichServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var brandName = brandName_example;  // string | Specifies the name of the brand to be searched. Also performs search on partially specified brand names. (optional) 
            var category = category_example;  // string | Specific Category/Categories for which the POI search is performed. (Categories 10020102,10020103 are for Chinese and Italian Restaurants .https://developer2.pitneybowes.com/docs/location-intelligence/v1/en/poicategory/EightDigitPOICategoryCodes.xlsx  (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var searchDataset = searchDataset_example;  // string | The datasets upon which the POI search can be performed. (optional) 
            var searchPriority = searchPriority_example;  // string | Search order of POI datasets mentioned in searchDataset. (optional) 
            var travelTime = travelTime_example;  // string | Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in 'travelTimeUnit'. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Specifies the search boundary in terms of distance mentioned in 'travelDistanceUnit'. The results are retrieved from the polygon formed based on the travel distance specified. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters (optional) 
            var mode = mode_example;  // string | Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time.Allowed values driving and walking (optional) 

            try
            {
                // Points Of Interest By Location.
                PoiByLocation result = apiInstance.GetEntityByLocation(longitude, latitude, brandName, category, maxCandidates, searchRadius, searchRadiusUnit, searchDataset, searchPriority, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, mode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoEnrichServiceApi.GetEntityByLocation: " + e.Message );
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
 **brandName** | **string**| Specifies the name of the brand to be searched. Also performs search on partially specified brand names. | [optional] 
 **category** | **string**| Specific Category/Categories for which the POI search is performed. (Categories 10020102,10020103 are for Chinese and Italian Restaurants .https://developer2.pitneybowes.com/docs/location-intelligence/v1/en/poicategory/EightDigitPOICategoryCodes.xlsx  | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **searchDataset** | **string**| The datasets upon which the POI search can be performed. | [optional] 
 **searchPriority** | **string**| Search order of POI datasets mentioned in searchDataset. | [optional] 
 **travelTime** | **string**| Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in &#39;travelTimeUnit&#39;. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. | [optional] 
 **travelTimeUnit** | **string**| Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds | [optional] 
 **travelDistance** | **string**| Specifies the search boundary in terms of distance mentioned in &#39;travelDistanceUnit&#39;. The results are retrieved from the polygon formed based on the travel distance specified. | [optional] 
 **travelDistanceUnit** | **string**| Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters | [optional] 
 **mode** | **string**| Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time.Allowed values driving and walking | [optional] 

### Return type

[**PoiByLocation**](PoiByLocation.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplacebylocation"></a>
# **GetPlaceByLocation**
> PlaceByLocations GetPlaceByLocation (string longitude, string latitude, string levelHint = null)

Place By Location.

Identifies and retrieves the nearest neighborhood around a specific location. This GeoEnrich service accepts latitude & longitude as input and returns a place name.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPlaceByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoEnrichServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var levelHint = levelHint_example;  // string | Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional) 

            try
            {
                // Place By Location.
                PlaceByLocations result = apiInstance.GetPlaceByLocation(longitude, latitude, levelHint);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoEnrichServiceApi.GetPlaceByLocation: " + e.Message );
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
 **levelHint** | **string**| Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 | [optional] 

### Return type

[**PlaceByLocations**](PlaceByLocations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

