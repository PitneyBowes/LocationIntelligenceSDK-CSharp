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

Returns the travel boundary based on travel distance.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoZoneServiceApi();
            var costs = costs_example;  // string | Travel distance(s)
            var point = point_example;  // string | Starting point from where the travel boundary is calculated. Point in 'Lat,Long,coordsys' format (optional) 
            var address = address_example;  // string | Starting address from where the travel boundary is calculated. (optional) 
            var costUnit = costUnit_example;  // string | Travel distance such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to m)
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var country = country_example;  // string | Three digit ISO country code. (optional)  (default to USA)
            var maxOffroadDistance = maxOffroadDistance_example;  // string | Maximum distance to allow travel off the road network. (optional) 
            var maxOffroadDistanceUnit = maxOffroadDistanceUnit_example;  // string | MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional) 
            var destinationSrs = destinationSrs_example;  // string | Desired coordinate system of the travel boundary. (optional) 
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in the calculation or just major roads. (optional)  (default to false)
            var returnHoles = returnHoles_example;  // string | Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired distance. (optional)  (default to false)
            var returnIslands = returnIslands_example;  // string | Whether to return islands, which are small areas outside the main boundary that can be reached within the desired distance. (optional)  (default to false)
            var simplificationFactor = simplificationFactor_example;  // string | Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. (optional)  (default to 0.5)
            var bandingStyle = bandingStyle_example;  // string | Style of banding to be used in the result. (optional)  (default to Donut)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Whether routing calculation uses the historic traffic speeds. (optional)  (default to None)

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
 **point** | **string**| Starting point from where the travel boundary is calculated. Point in &#39;Lat,Long,coordsys&#39; format | [optional] 
 **address** | **string**| Starting address from where the travel boundary is calculated. | [optional] 
 **costUnit** | **string**| Travel distance such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to m]
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **country** | **string**| Three digit ISO country code. | [optional] [default to USA]
 **maxOffroadDistance** | **string**| Maximum distance to allow travel off the road network. | [optional] 
 **maxOffroadDistanceUnit** | **string**| MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] 
 **destinationSrs** | **string**| Desired coordinate system of the travel boundary. | [optional] 
 **majorRoads** | **string**| Whether to include all roads in the calculation or just major roads. | [optional] [default to false]
 **returnHoles** | **string**| Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired distance. | [optional] [default to false]
 **returnIslands** | **string**| Whether to return islands, which are small areas outside the main boundary that can be reached within the desired distance. | [optional] [default to false]
 **simplificationFactor** | **string**| Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. | [optional] [default to 0.5]
 **bandingStyle** | **string**| Style of banding to be used in the result. | [optional] [default to Donut]
 **historicTrafficTimeBucket** | **string**| Whether routing calculation uses the historic traffic speeds. | [optional] [default to None]

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

Travel boundary based on travel time.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoZoneServiceApi();
            var costs = costs_example;  // string | Travel time used to calculate the travel boundary.
            var point = point_example;  // string | Starting point from where the travel boundary is calculated. Point in Lat,Long,coordsys format (optional) 
            var address = address_example;  // string | Starting address from where the travel boundary is calculated. (optional) 
            var costUnit = costUnit_example;  // string | Travel time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to min)
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var country = country_example;  // string | 3 character ISO code or country name. (optional)  (default to USA)
            var maxOffroadDistance = maxOffroadDistance_example;  // string | Maximum distance to allow travel off the road network. (optional) 
            var maxOffroadDistanceUnit = maxOffroadDistanceUnit_example;  // string | MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional) 
            var destinationSrs = destinationSrs_example;  // string | Desired coordinate system of the travel boundary. (optional) 
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in the calculation or just major roads. (optional)  (default to false)
            var returnHoles = returnHoles_example;  // string | Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired time. (optional)  (default to false)
            var returnIslands = returnIslands_example;  // string | Whether to return islands, which are small areas outside the main boundary that can be reached within the desired time. (optional)  (default to false)
            var simplificationFactor = simplificationFactor_example;  // string | Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. (optional)  (default to 0.5)
            var bandingStyle = bandingStyle_example;  // string | Style of banding to be used in the result. (optional)  (default to Donut)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Whether routing calculation uses the historic traffic speeds. (optional)  (default to None)

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
 **costs** | **string**| Travel time used to calculate the travel boundary. | 
 **point** | **string**| Starting point from where the travel boundary is calculated. Point in Lat,Long,coordsys format | [optional] 
 **address** | **string**| Starting address from where the travel boundary is calculated. | [optional] 
 **costUnit** | **string**| Travel time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to min]
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **country** | **string**| 3 character ISO code or country name. | [optional] [default to USA]
 **maxOffroadDistance** | **string**| Maximum distance to allow travel off the road network. | [optional] 
 **maxOffroadDistanceUnit** | **string**| MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] 
 **destinationSrs** | **string**| Desired coordinate system of the travel boundary. | [optional] 
 **majorRoads** | **string**| Whether to include all roads in the calculation or just major roads. | [optional] [default to false]
 **returnHoles** | **string**| Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired time. | [optional] [default to false]
 **returnIslands** | **string**| Whether to return islands, which are small areas outside the main boundary that can be reached within the desired time. | [optional] [default to false]
 **simplificationFactor** | **string**| Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. | [optional] [default to 0.5]
 **bandingStyle** | **string**| Style of banding to be used in the result. | [optional] [default to Donut]
 **historicTrafficTimeBucket** | **string**| Whether routing calculation uses the historic traffic speeds. | [optional] [default to None]

### Return type

[**TravelBoundaries**](TravelBoundaries.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

