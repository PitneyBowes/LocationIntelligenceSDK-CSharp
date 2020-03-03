# pb.locationIntelligence.Api.LIAPIGeoRouteServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRouteByAddress**](LIAPIGeoRouteServiceApi.md#getroutebyaddress) | **GET** /georoute/v1/route/byaddress | Gets Route by Address
[**GetRouteByLocation**](LIAPIGeoRouteServiceApi.md#getroutebylocation) | **GET** /georoute/v1/route/bylocation | Gets Route by Location
[**GetTravelCostMatrixByAddress**](LIAPIGeoRouteServiceApi.md#gettravelcostmatrixbyaddress) | **GET** /georoute/v1/travelcostmatrix/byaddress | Gets Cost Matrix by Address
[**GetTravelCostMatrixByLocation**](LIAPIGeoRouteServiceApi.md#gettravelcostmatrixbylocation) | **GET** /georoute/v1/travelcostmatrix/bylocation | Gets Cost Matrix by Location


<a name="getroutebyaddress"></a>
# **GetRouteByAddress**
> GeoRouteResponse GetRouteByAddress (string startAddress, string endAddress, string db = null, string country = null, string intermediateAddresses = null, string oip = null, string destinationSrs = null, string optimizeBy = null, string returnDistance = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string language = null, string directionsStyle = null, string segmentGeometryStyle = null, string primaryNameOnly = null, string majorRoads = null, string historicTrafficTimeBucket = null, string returnDirectionGeometry = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Gets Route by Address

Routing Directions for Single and Multiple Origin & Destination Inputs. Accepts addresses as input and Returns Point-to-Point and Multi-Point travel directions by various travel modes.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetRouteByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startAddress = startAddress_example;  // string | Starting address of the route.
            var endAddress = endAddress_example;  // string | Ending address of the route.
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var country = country_example;  // string | Three digit ISO country code (optional)  (default to USA)
            var intermediateAddresses = intermediateAddresses_example;  // string | List of intermediate addresses of the route. (optional) 
            var oip = oip_example;  // string | Specifies whether waypoints need to be optimized. (optional)  (default to false)
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of the returned route. (optional) 
            var optimizeBy = optimizeBy_example;  // string | Specifies whether the route should be optimized by time or distance. (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be part of direction information in response. (optional)  (default to true)
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be part of direction information in response. (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to min)
            var language = language_example;  // string | Language of travel directions. (optional)  (default to en)
            var directionsStyle = directionsStyle_example;  // string | Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). (optional)  (default to None)
            var segmentGeometryStyle = segmentGeometryStyle_example;  // string | Specifies whether the route geometry is to be returned in the response and in what detail (End or All). (optional)  (default to none)
            var primaryNameOnly = primaryNameOnly_example;  // string | If true then only the primary street name is returned otherwise all the names for a street. (optional)  (default to false)
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in route calculation or just major roads. (optional)  (default to false)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to None)
            var returnDirectionGeometry = returnDirectionGeometry_example;  // string | Whether to include geometry associated with each route instruction in response. (optional)  (default to false)
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs (optional)  (default to N)
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route (optional)  (default to Y)
            var vehicleType = vehicleType_example;  // string | vehicle type (optional)  (default to ALL)
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) (optional)  (default to kg)
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)

            try
            {
                // Gets Route by Address
                GeoRouteResponse result = apiInstance.GetRouteByAddress(startAddress, endAddress, db, country, intermediateAddresses, oip, destinationSrs, optimizeBy, returnDistance, distanceUnit, returnTime, timeUnit, language, directionsStyle, segmentGeometryStyle, primaryNameOnly, majorRoads, historicTrafficTimeBucket, returnDirectionGeometry, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRouteServiceApi.GetRouteByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startAddress** | **string**| Starting address of the route. | 
 **endAddress** | **string**| Ending address of the route. | 
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **country** | **string**| Three digit ISO country code | [optional] [default to USA]
 **intermediateAddresses** | **string**| List of intermediate addresses of the route. | [optional] 
 **oip** | **string**| Specifies whether waypoints need to be optimized. | [optional] [default to false]
 **destinationSrs** | **string**| Specifies the desired coordinate system of the returned route. | [optional] 
 **optimizeBy** | **string**| Specifies whether the route should be optimized by time or distance. | [optional] [default to time]
 **returnDistance** | **string**| Specifies whether distance needs to be part of direction information in response. | [optional] [default to true]
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to m]
 **returnTime** | **string**| Specifies whether time needs to be part of direction information in response. | [optional] [default to true]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to min]
 **language** | **string**| Language of travel directions. | [optional] [default to en]
 **directionsStyle** | **string**| Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). | [optional] [default to None]
 **segmentGeometryStyle** | **string**| Specifies whether the route geometry is to be returned in the response and in what detail (End or All). | [optional] [default to none]
 **primaryNameOnly** | **string**| If true then only the primary street name is returned otherwise all the names for a street. | [optional] [default to false]
 **majorRoads** | **string**| Whether to include all roads in route calculation or just major roads. | [optional] [default to false]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to None]
 **returnDirectionGeometry** | **string**| Whether to include geometry associated with each route instruction in response. | [optional] [default to false]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs | [optional] [default to N]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route | [optional] [default to Y]
 **vehicleType** | **string**| vehicle type | [optional] [default to ALL]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) | [optional] [default to kg]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]

### Return type

[**GeoRouteResponse**](GeoRouteResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutebylocation"></a>
# **GetRouteByLocation**
> GeoRouteResponse GetRouteByLocation (string startPoint, string endPoint, string db = null, string intermediatePoints = null, string oip = null, string destinationSrs = null, string optimizeBy = null, string returnDistance = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string language = null, string directionsStyle = null, string segmentGeometryStyle = null, string primaryNameOnly = null, string majorRoads = null, string historicTrafficTimeBucket = null, string returnDirectionGeometry = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Gets Route by Location

Returns the fastest or shortest route based on a starting and ending location with optional intermediate points as input.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetRouteByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startPoint = startPoint_example;  // string | Start Point in 'Lat,Long,coordsys' format
            var endPoint = endPoint_example;  // string | End Point in 'Lat,Long,coordsys' format
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var intermediatePoints = intermediatePoints_example;  // string | List of intermediate points of the route. (optional) 
            var oip = oip_example;  // string | Specifies whether waypoints need to be optimized. (optional)  (default to false)
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of the returned route. (optional) 
            var optimizeBy = optimizeBy_example;  // string | Specifies whether the route should be optimized by time or distance. (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be part of direction information in response. (optional)  (default to true)
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be part of direction information in response. (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to min)
            var language = language_example;  // string | Specifies the language of travel directions. (optional)  (default to en)
            var directionsStyle = directionsStyle_example;  // string | Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). (optional)  (default to None)
            var segmentGeometryStyle = segmentGeometryStyle_example;  // string | Specifies whether the route geometry is to be returned in the response and in what detail (End or All). (optional)  (default to none)
            var primaryNameOnly = primaryNameOnly_example;  // string | If true then only the primary street name is returned otherwise all the names for a street. (optional)  (default to false)
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in route calculation or just major roads. (optional)  (default to false)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to None)
            var returnDirectionGeometry = returnDirectionGeometry_example;  // string | Whether to include geometry associated with each route instruction in response. (optional)  (default to false)
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs (optional)  (default to N)
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route (optional)  (default to Y)
            var vehicleType = vehicleType_example;  // string | vehicle type (optional)  (default to ALL)
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) (optional)  (default to kg)
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)

            try
            {
                // Gets Route by Location
                GeoRouteResponse result = apiInstance.GetRouteByLocation(startPoint, endPoint, db, intermediatePoints, oip, destinationSrs, optimizeBy, returnDistance, distanceUnit, returnTime, timeUnit, language, directionsStyle, segmentGeometryStyle, primaryNameOnly, majorRoads, historicTrafficTimeBucket, returnDirectionGeometry, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRouteServiceApi.GetRouteByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startPoint** | **string**| Start Point in &#39;Lat,Long,coordsys&#39; format | 
 **endPoint** | **string**| End Point in &#39;Lat,Long,coordsys&#39; format | 
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **intermediatePoints** | **string**| List of intermediate points of the route. | [optional] 
 **oip** | **string**| Specifies whether waypoints need to be optimized. | [optional] [default to false]
 **destinationSrs** | **string**| Specifies the desired coordinate system of the returned route. | [optional] 
 **optimizeBy** | **string**| Specifies whether the route should be optimized by time or distance. | [optional] [default to time]
 **returnDistance** | **string**| Specifies whether distance needs to be part of direction information in response. | [optional] [default to true]
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to m]
 **returnTime** | **string**| Specifies whether time needs to be part of direction information in response. | [optional] [default to true]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to min]
 **language** | **string**| Specifies the language of travel directions. | [optional] [default to en]
 **directionsStyle** | **string**| Specifies whether route directions text is to be returned in the response and in what detail (Normal or Terse). | [optional] [default to None]
 **segmentGeometryStyle** | **string**| Specifies whether the route geometry is to be returned in the response and in what detail (End or All). | [optional] [default to none]
 **primaryNameOnly** | **string**| If true then only the primary street name is returned otherwise all the names for a street. | [optional] [default to false]
 **majorRoads** | **string**| Whether to include all roads in route calculation or just major roads. | [optional] [default to false]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to None]
 **returnDirectionGeometry** | **string**| Whether to include geometry associated with each route instruction in response. | [optional] [default to false]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs | [optional] [default to N]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route | [optional] [default to Y]
 **vehicleType** | **string**| vehicle type | [optional] [default to ALL]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) | [optional] [default to kg]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]

### Return type

[**GeoRouteResponse**](GeoRouteResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettravelcostmatrixbyaddress"></a>
# **GetTravelCostMatrixByAddress**
> TravelCostMatrixResponse GetTravelCostMatrixByAddress (string startAddresses, string endAddresses, string db = null, string country = null, string optimizeBy = null, string returnDistance = null, string destinationSrs = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string majorRoads = null, string returnOptimalRoutesOnly = null, string historicTrafficTimeBucket = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Gets Cost Matrix by Address

Calculates the travel time and distances between an array of start and end addresses.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetTravelCostMatrixByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startAddresses = startAddresses_example;  // string | Start locations in text based addresses.
            var endAddresses = endAddresses_example;  // string | End locations in text based addresses.
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var country = country_example;  // string | 3 Digit ISO country code. (optional)  (default to USA)
            var optimizeBy = optimizeBy_example;  // string | Specifies the type of optimizing to use for the route (time/distance). (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specifies whether to return the travel distance in the response or not. (optional)  (default to true)
            var destinationSrs = destinationSrs_example;  // string | Coordinate system used for the returned routes. (optional) 
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specifies whether to return the travel time in the response or not. (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to min)
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in routes calculation or just major roads. (optional)  (default to false)
            var returnOptimalRoutesOnly = returnOptimalRoutesOnly_example;  // string | Specifies whether to return only the optimized route for each start and end point combination. (optional)  (default to true)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to None)
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs (optional)  (default to N)
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route (optional)  (default to Y)
            var vehicleType = vehicleType_example;  // string | vehicle type (optional)  (default to ALL)
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) (optional)  (default to kg)
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)

            try
            {
                // Gets Cost Matrix by Address
                TravelCostMatrixResponse result = apiInstance.GetTravelCostMatrixByAddress(startAddresses, endAddresses, db, country, optimizeBy, returnDistance, destinationSrs, distanceUnit, returnTime, timeUnit, majorRoads, returnOptimalRoutesOnly, historicTrafficTimeBucket, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRouteServiceApi.GetTravelCostMatrixByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startAddresses** | **string**| Start locations in text based addresses. | 
 **endAddresses** | **string**| End locations in text based addresses. | 
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **country** | **string**| 3 Digit ISO country code. | [optional] [default to USA]
 **optimizeBy** | **string**| Specifies the type of optimizing to use for the route (time/distance). | [optional] [default to time]
 **returnDistance** | **string**| Specifies whether to return the travel distance in the response or not. | [optional] [default to true]
 **destinationSrs** | **string**| Coordinate system used for the returned routes. | [optional] 
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to m]
 **returnTime** | **string**| Specifies whether to return the travel time in the response or not. | [optional] [default to true]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to min]
 **majorRoads** | **string**| Whether to include all roads in routes calculation or just major roads. | [optional] [default to false]
 **returnOptimalRoutesOnly** | **string**| Specifies whether to return only the optimized route for each start and end point combination. | [optional] [default to true]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to None]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs | [optional] [default to N]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route | [optional] [default to Y]
 **vehicleType** | **string**| vehicle type | [optional] [default to ALL]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) | [optional] [default to kg]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]

### Return type

[**TravelCostMatrixResponse**](TravelCostMatrixResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettravelcostmatrixbylocation"></a>
# **GetTravelCostMatrixByLocation**
> TravelCostMatrixResponse GetTravelCostMatrixByLocation (string startPoints, string endPoints, string db = null, string optimizeBy = null, string returnDistance = null, string destinationSrs = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string majorRoads = null, string returnOptimalRoutesOnly = null, string historicTrafficTimeBucket = null, string useCvr = null, string looseningBarrierRestrictions = null, string vehicleType = null, string weight = null, string weightUnit = null, string height = null, string heightUnit = null, string length = null, string lengthUnit = null, string width = null, string widthUnit = null)

Gets Cost Matrix by Location

GeoRoute's 'Travel Cost Matrix By Location' service calculates the travel time and distances between an array of start and end points based on location coordinates.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetTravelCostMatrixByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startPoints = startPoints_example;  // string | The address to be searched.
            var endPoints = endPoints_example;  // string | The address to be searched.
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var optimizeBy = optimizeBy_example;  // string | Specifies whether routes should be optimized by time or distance. (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specifies whether distance needs to be returned in response. (optional)  (default to true)
            var destinationSrs = destinationSrs_example;  // string | Specifies the desired coordinate system of returned routes. (optional) 
            var distanceUnit = distanceUnit_example;  // string | Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specifies whether time needs to be returned in response. (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to min)
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in routes calculation or just major roads. (optional)  (default to false)
            var returnOptimalRoutesOnly = returnOptimalRoutesOnly_example;  // string | Specifies whether to return only the optimized route for each start and end point combination. (optional)  (default to true)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Specifies whether routing calculation uses the historic traffic speeds. (optional)  (default to None)
            var useCvr = useCvr_example;  // string | This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs (optional)  (default to N)
            var looseningBarrierRestrictions = looseningBarrierRestrictions_example;  // string | Specifies that barriers will be removed when determining the route (optional)  (default to Y)
            var vehicleType = vehicleType_example;  // string | vehicle type (optional)  (default to ALL)
            var weight = weight_example;  // string | Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var weightUnit = weightUnit_example;  // string | The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) (optional)  (default to kg)
            var height = height_example;  // string | Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var heightUnit = heightUnit_example;  // string | The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var length = length_example;  // string | Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var lengthUnit = lengthUnit_example;  // string | The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)
            var width = width_example;  // string | Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. (optional) 
            var widthUnit = widthUnit_example;  // string | The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) (optional)  (default to ft)

            try
            {
                // Gets Cost Matrix by Location
                TravelCostMatrixResponse result = apiInstance.GetTravelCostMatrixByLocation(startPoints, endPoints, db, optimizeBy, returnDistance, destinationSrs, distanceUnit, returnTime, timeUnit, majorRoads, returnOptimalRoutesOnly, historicTrafficTimeBucket, useCvr, looseningBarrierRestrictions, vehicleType, weight, weightUnit, height, heightUnit, length, lengthUnit, width, widthUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRouteServiceApi.GetTravelCostMatrixByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startPoints** | **string**| The address to be searched. | 
 **endPoints** | **string**| The address to be searched. | 
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **optimizeBy** | **string**| Specifies whether routes should be optimized by time or distance. | [optional] [default to time]
 **returnDistance** | **string**| Specifies whether distance needs to be returned in response. | [optional] [default to true]
 **destinationSrs** | **string**| Specifies the desired coordinate system of returned routes. | [optional] 
 **distanceUnit** | **string**| Return Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to m]
 **returnTime** | **string**| Specifies whether time needs to be returned in response. | [optional] [default to true]
 **timeUnit** | **string**| Return time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to min]
 **majorRoads** | **string**| Whether to include all roads in routes calculation or just major roads. | [optional] [default to false]
 **returnOptimalRoutesOnly** | **string**| Specifies whether to return only the optimized route for each start and end point combination. | [optional] [default to true]
 **historicTrafficTimeBucket** | **string**| Specifies whether routing calculation uses the historic traffic speeds. | [optional] [default to None]
 **useCvr** | **string**| This parameter will enable/disable CVR (Commercial Vehicle Restrictions) capability in our APIs | [optional] [default to N]
 **looseningBarrierRestrictions** | **string**| Specifies that barriers will be removed when determining the route | [optional] [default to Y]
 **vehicleType** | **string**| vehicle type | [optional] [default to ALL]
 **weight** | **string**| Specifies the maximum weight of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **weightUnit** | **string**| The unit of weight eg. kg(kilogram), lb(pound), mt(metric ton), t(ton) | [optional] [default to kg]
 **height** | **string**| Specifies the maximum height of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **heightUnit** | **string**| The unit of height e.g m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **length** | **string**| Specifies the maximum length of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **lengthUnit** | **string**| The unit of length eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]
 **width** | **string**| Specifies the maximum width of a vehicle. Any vehicles over this value will be restricted when determining the route. | [optional] 
 **widthUnit** | **string**| The unit of width eg. m(meter), km(kilometer), yd(yard), ft(foot), mi(mile) | [optional] [default to ft]

### Return type

[**TravelCostMatrixResponse**](TravelCostMatrixResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

