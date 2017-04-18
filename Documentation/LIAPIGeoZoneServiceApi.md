# pb.locationIntelligence.Api.LIAPIGeoZoneServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTravelBoundaryByDistance**](LIAPIGeoZoneServiceApi.md#gettravelboundarybydistance) | **GET** /geozone/v1/travelboundary/bydistance | Gets travel Boundary by Distance
[**GetTravelBoundaryByTime**](LIAPIGeoZoneServiceApi.md#gettravelboundarybytime) | **GET** /geozone/v1/travelboundary/bytime | Gets travel Boundary by Time


<a name="gettravelboundarybydistance"></a>
# **GetTravelBoundaryByDistance**
> TravelBoundaries GetTravelBoundaryByDistance (string costs, string point = null, string address = null, string costUnit = null, string db = null, string country = null, string maxOffroadDistance = null, string maxOffroadDistanceUnit = null, string destinationSrs = null, string majorRoads = null, string returnHoles = null, string returnIslands = null, string simplificationFactor = null, string bandingStyle = null, string historicTrafficTimeBucket = null)

Gets travel Boundary by Distance

Gets travel Boundary by Distance

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetTravelBoundaryByDistanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoZoneServiceApi();
            var costs = costs_example;  // string | Travel distance(s)
            var point = point_example;  // string | Point in Lat,Long,coordsys format (optional) 
            var address = address_example;  // string | Adress (optional) 
            var costUnit = costUnit_example;  // string | Travel distance Unit (optional)  (default to m)
            var db = db_example;  // string | Database to retrieve boundary data (optional)  (default to driving)
            var country = country_example;  // string | Three digit ISO country code (optional)  (default to USA)
            var maxOffroadDistance = maxOffroadDistance_example;  // string | Maximum distance off the road (optional) 
            var maxOffroadDistanceUnit = maxOffroadDistanceUnit_example;  // string | Distance Unit for maximum Offroad distance (optional) 
            var destinationSrs = destinationSrs_example;  // string | Coordinate sytem (optional) 
            var majorRoads = majorRoads_example;  // string | Consider major roads (optional)  (default to false)
            var returnHoles = returnHoles_example;  // string | Return holes (optional)  (default to false)
            var returnIslands = returnIslands_example;  // string | Return islands (optional)  (default to false)
            var simplificationFactor = simplificationFactor_example;  // string | Simplification factor (optional)  (default to 0.5)
            var bandingStyle = bandingStyle_example;  // string | Type of distance band (optional)  (default to Donut)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional)  (default to None)

            try
            {
                // Gets travel Boundary by Distance
                TravelBoundaries result = apiInstance.GetTravelBoundaryByDistance(costs, point, address, costUnit, db, country, maxOffroadDistance, maxOffroadDistanceUnit, destinationSrs, majorRoads, returnHoles, returnIslands, simplificationFactor, bandingStyle, historicTrafficTimeBucket);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoZoneServiceApi.GetTravelBoundaryByDistance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **costs** | **string**| Travel distance(s) | 
 **point** | **string**| Point in Lat,Long,coordsys format | [optional] 
 **address** | **string**| Adress | [optional] 
 **costUnit** | **string**| Travel distance Unit | [optional] [default to m]
 **db** | **string**| Database to retrieve boundary data | [optional] [default to driving]
 **country** | **string**| Three digit ISO country code | [optional] [default to USA]
 **maxOffroadDistance** | **string**| Maximum distance off the road | [optional] 
 **maxOffroadDistanceUnit** | **string**| Distance Unit for maximum Offroad distance | [optional] 
 **destinationSrs** | **string**| Coordinate sytem | [optional] 
 **majorRoads** | **string**| Consider major roads | [optional] [default to false]
 **returnHoles** | **string**| Return holes | [optional] [default to false]
 **returnIslands** | **string**| Return islands | [optional] [default to false]
 **simplificationFactor** | **string**| Simplification factor | [optional] [default to 0.5]
 **bandingStyle** | **string**| Type of distance band | [optional] [default to Donut]
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] [default to None]

### Return type

[**TravelBoundaries**](TravelBoundaries.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettravelboundarybytime"></a>
# **GetTravelBoundaryByTime**
> TravelBoundaries GetTravelBoundaryByTime (string costs, string point = null, string address = null, string costUnit = null, string db = null, string country = null, string maxOffroadDistance = null, string maxOffroadDistanceUnit = null, string destinationSrs = null, string majorRoads = null, string returnHoles = null, string returnIslands = null, string simplificationFactor = null, string bandingStyle = null, string historicTrafficTimeBucket = null)

Gets travel Boundary by Time

Gets travel Boundary by Time

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetTravelBoundaryByTimeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoZoneServiceApi();
            var costs = costs_example;  // string | Travel time(s)
            var point = point_example;  // string | Point in Lat,Long,coordsys format (optional) 
            var address = address_example;  // string | Adress (optional) 
            var costUnit = costUnit_example;  // string | Travel time Unit (optional)  (default to min)
            var db = db_example;  // string | Database to retrieve boundary data (optional)  (default to driving)
            var country = country_example;  // string | Three digit ISO country code (optional)  (default to USA)
            var maxOffroadDistance = maxOffroadDistance_example;  // string | Maximum distance off the road (optional) 
            var maxOffroadDistanceUnit = maxOffroadDistanceUnit_example;  // string | Distance Unit for maximum Offroad distance (optional) 
            var destinationSrs = destinationSrs_example;  // string | Coordinate sytem (optional) 
            var majorRoads = majorRoads_example;  // string | Consider major roads (optional)  (default to false)
            var returnHoles = returnHoles_example;  // string | Return holes (optional)  (default to false)
            var returnIslands = returnIslands_example;  // string | Return islands (optional)  (default to false)
            var simplificationFactor = simplificationFactor_example;  // string | Simplification factor (optional)  (default to 0.5)
            var bandingStyle = bandingStyle_example;  // string | Type of distance band (optional)  (default to Donut)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional)  (default to None)

            try
            {
                // Gets travel Boundary by Time
                TravelBoundaries result = apiInstance.GetTravelBoundaryByTime(costs, point, address, costUnit, db, country, maxOffroadDistance, maxOffroadDistanceUnit, destinationSrs, majorRoads, returnHoles, returnIslands, simplificationFactor, bandingStyle, historicTrafficTimeBucket);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoZoneServiceApi.GetTravelBoundaryByTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **costs** | **string**| Travel time(s) | 
 **point** | **string**| Point in Lat,Long,coordsys format | [optional] 
 **address** | **string**| Adress | [optional] 
 **costUnit** | **string**| Travel time Unit | [optional] [default to min]
 **db** | **string**| Database to retrieve boundary data | [optional] [default to driving]
 **country** | **string**| Three digit ISO country code | [optional] [default to USA]
 **maxOffroadDistance** | **string**| Maximum distance off the road | [optional] 
 **maxOffroadDistanceUnit** | **string**| Distance Unit for maximum Offroad distance | [optional] 
 **destinationSrs** | **string**| Coordinate sytem | [optional] 
 **majorRoads** | **string**| Consider major roads | [optional] [default to false]
 **returnHoles** | **string**| Return holes | [optional] [default to false]
 **returnIslands** | **string**| Return islands | [optional] [default to false]
 **simplificationFactor** | **string**| Simplification factor | [optional] [default to 0.5]
 **bandingStyle** | **string**| Type of distance band | [optional] [default to Donut]
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] [default to None]

### Return type

[**TravelBoundaries**](TravelBoundaries.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

