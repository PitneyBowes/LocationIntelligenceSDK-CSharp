# pb.locationIntelligence.Api.LIAPIGeoPlacesServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCategoryCodeMetadata**](LIAPIGeoPlacesServiceApi.md#getcategorycodemetadata) | **GET** /geoplaces/v1/metadata/category | Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping
[**GetPOIsByAddress**](LIAPIGeoPlacesServiceApi.md#getpoisbyaddress) | **GET** /geoplaces/v1/poi/byaddress | Point of Interests By Address.
[**GetPOIsByLocation**](LIAPIGeoPlacesServiceApi.md#getpoisbylocation) | **GET** /geoplaces/v1/poi/bylocation | Point of Interests By Location.
[**GetSICMetadata**](LIAPIGeoPlacesServiceApi.md#getsicmetadata) | **GET** /geoplaces/v1/metadata/sic | Returns SIC Codes with their Industry Titles and Category Codes mapping


<a name="getcategorycodemetadata"></a>
# **GetCategoryCodeMetadata**
> GeoPlaceMetadataResponse GetCategoryCodeMetadata (string categoryCode = null)

Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping

Accepts first partial digits or full category codes to filter the response

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetCategoryCodeMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPlacesServiceApi();
            var categoryCode = categoryCode_example;  // string | Specify starting digits or full category code to filter the response (optional) 

            try
            {
                // Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping
                GeoPlaceMetadataResponse result = apiInstance.GetCategoryCodeMetadata(categoryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPlacesServiceApi.GetCategoryCodeMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryCode** | **string**| Specify starting digits or full category code to filter the response | [optional] 

### Return type

[**GeoPlaceMetadataResponse**](GeoPlaceMetadataResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoisbyaddress"></a>
# **GetPOIsByAddress**
> GeoplacesResponse GetPOIsByAddress (string address, string country = null, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string sortBy = null)

Point of Interests By Address.

Accepts address as an input to retrieve nearby point of interests.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPOIsByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPlacesServiceApi();
            var address = address_example;  // string | Address
            var country = country_example;  // string | Country (optional) 
            var name = name_example;  // string | Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) (optional) 
            var type = type_example;  // string | Matched against the content which defines the type of the poi.  (optional) 
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer2.pitneybowes.com/docs/location-intelligence/v1/en/poicategory/LiApiPOICategoryCodes.xlsx  (optional) 
            var sicCode = sicCode_example;  // string | Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var travelTime = travelTime_example;  // string | Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in 'travelTimeUnit'. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Specifies the search boundary in terms of distance mentioned in 'travelDistanceUnit'. The results are retrieved from the polygon formed based on the travel distance specified. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters (optional) 
            var travelMode = travelMode_example;  // string | Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking (optional) 
            var sortBy = sortBy_example;  // string | Specifies the order in which POIs are retrieved. (optional)  (default to distance)

            try
            {
                // Point of Interests By Address.
                GeoplacesResponse result = apiInstance.GetPOIsByAddress(address, country, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPlacesServiceApi.GetPOIsByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 
 **country** | **string**| Country | [optional] 
 **name** | **string**| Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) | [optional] 
 **type** | **string**| Matched against the content which defines the type of the poi.  | [optional] 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://developer2.pitneybowes.com/docs/location-intelligence/v1/en/poicategory/LiApiPOICategoryCodes.xlsx  | [optional] 
 **sicCode** | **string**| Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **travelTime** | **string**| Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in &#39;travelTimeUnit&#39;. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. | [optional] 
 **travelTimeUnit** | **string**| Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds | [optional] 
 **travelDistance** | **string**| Specifies the search boundary in terms of distance mentioned in &#39;travelDistanceUnit&#39;. The results are retrieved from the polygon formed based on the travel distance specified. | [optional] 
 **travelDistanceUnit** | **string**| Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters | [optional] 
 **travelMode** | **string**| Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking | [optional] 
 **sortBy** | **string**| Specifies the order in which POIs are retrieved. | [optional] [default to distance]

### Return type

[**GeoplacesResponse**](GeoplacesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoisbylocation"></a>
# **GetPOIsByLocation**
> GeoplacesResponse GetPOIsByLocation (string longitude, string latitude, string name = null, string type = null, string categoryCode = null, string sicCode = null, string maxCandidates = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string sortBy = null)

Point of Interests By Location.

Accepts longitude and latitude as an input to retrieve nearby point of interests.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPOIsByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPlacesServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var name = name_example;  // string | Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) (optional) 
            var type = type_example;  // string | Matched against the content which defines the type of the poi.  (optional) 
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://locate.pitneybowes.com/docs/location-intelligence/v1/en/poicategory/LiApiPOICategoryCodes.xlsx  (optional) 
            var sicCode = sicCode_example;  // string | Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var travelTime = travelTime_example;  // string | Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in 'travelTimeUnit'. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Specifies the search boundary in terms of distance mentioned in 'travelDistanceUnit'. The results are retrieved from the polygon formed based on the travel distance specified. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters (optional) 
            var travelMode = travelMode_example;  // string | Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking (optional) 
            var sortBy = sortBy_example;  // string | Specifies the order in which POIs are retrieved. (optional)  (default to distance)

            try
            {
                // Point of Interests By Location.
                GeoplacesResponse result = apiInstance.GetPOIsByLocation(longitude, latitude, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPlacesServiceApi.GetPOIsByLocation: " + e.Message );
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
 **name** | **string**| Matched against Name, BrandName and Trade Name. Partial terms are also matched with fuzziness (max edit distance is 1) | [optional] 
 **type** | **string**| Matched against the content which defines the type of the poi.  | [optional] 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. https://locate.pitneybowes.com/docs/location-intelligence/v1/en/poicategory/LiApiPOICategoryCodes.xlsx  | [optional] 
 **sicCode** | **string**| Specific SIC Codes/Codes for the desired POIs. Accepts a mix of 4 digit (Top Category) and 8 digit (Low-Level Category) SIC Codes. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **travelTime** | **string**| Specifies the travel time within which method searches for results (POIs which can be reached within travel time)the search boundary in terms of time mentioned in &#39;travelTimeUnit&#39;. The results are retrieved from the polygon formed based on the travel time specified. This means search can be done in the mentioned time results be from the mentioned time. | [optional] 
 **travelTimeUnit** | **string**| Specifies acceptable time units.Allowed values Minutes,Hours,Seconds and Milliseconds | [optional] 
 **travelDistance** | **string**| Specifies the search boundary in terms of distance mentioned in &#39;travelDistanceUnit&#39;. The results are retrieved from the polygon formed based on the travel distance specified. | [optional] 
 **travelDistanceUnit** | **string**| Specifies acceptable time units.Allowed values Feet,Kilometers,Miles and Meters | [optional] 
 **travelMode** | **string**| Specifies the available mode of commute. This is required when u r trying to do search by travel distance or travel time. Allowed values driving and walking | [optional] 
 **sortBy** | **string**| Specifies the order in which POIs are retrieved. | [optional] [default to distance]

### Return type

[**GeoplacesResponse**](GeoplacesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsicmetadata"></a>
# **GetSICMetadata**
> GeoPlaceMetadataResponse GetSICMetadata (string sicCode = null)

Returns SIC Codes with their Industry Titles and Category Codes mapping

Accepts first few partial digits or full SIC codes to filter the response

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSICMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPlacesServiceApi();
            var sicCode = sicCode_example;  // string | Specify starting digits or full sic code to filter the response (optional) 

            try
            {
                // Returns SIC Codes with their Industry Titles and Category Codes mapping
                GeoPlaceMetadataResponse result = apiInstance.GetSICMetadata(sicCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPlacesServiceApi.GetSICMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sicCode** | **string**| Specify starting digits or full sic code to filter the response | [optional] 

### Return type

[**GeoPlaceMetadataResponse**](GeoPlaceMetadataResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml, text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

