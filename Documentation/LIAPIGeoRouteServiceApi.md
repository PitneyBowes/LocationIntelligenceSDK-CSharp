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
> GeoRouteResponse GetRouteByAddress (string startAddress, string endAddress, string db = null, string country = null, string intermediateAddresses = null, string oip = null, string destinationSrs = null, string optimizeBy = null, string returnDistance = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string language = null, string directionsStyle = null, string segmentGeometryStyle = null, string primaryNameOnly = null, string majorRoads = null, string historicTrafficTimeBucket = null, string returnDirectionGeometry = null)

Gets Route by Address

Gets Route by Address

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
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startAddress = startAddress_example;  // string | Start Address
            var endAddress = endAddress_example;  // string | End Address
            var db = db_example;  // string | Database to retrieve boundary data (optional)  (default to driving)
            var country = country_example;  // string | Three digit ISO country code (optional)  (default to USA)
            var intermediateAddresses = intermediateAddresses_example;  // string | Intermediate Addresses (optional) 
            var oip = oip_example;  // string | Specify waypoints optimization (optional)  (default to false)
            var destinationSrs = destinationSrs_example;  // string | Coordinate sytem (optional) 
            var optimizeBy = optimizeBy_example;  // string | Otimize by time/distance (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specify distance in response (optional)  (default to true)
            var distanceUnit = distanceUnit_example;  // string | Unit to return distance (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specify time in response (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Unit to return time (optional)  (default to min)
            var language = language_example;  // string | Language for travel direction (optional)  (default to en)
            var directionsStyle = directionsStyle_example;  // string | Route direction text style (optional)  (default to None)
            var segmentGeometryStyle = segmentGeometryStyle_example;  // string | Geometry segement for response (optional)  (default to none)
            var primaryNameOnly = primaryNameOnly_example;  // string | Return Primary street name only (optional)  (default to false)
            var majorRoads = majorRoads_example;  // string | Include major Roads only (optional)  (default to false)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional)  (default to None)
            var returnDirectionGeometry = returnDirectionGeometry_example;  // string | Include the geometry associated with each route instruction in route response (optional)  (default to false)

            try
            {
                // Gets Route by Address
                GeoRouteResponse result = apiInstance.GetRouteByAddress(startAddress, endAddress, db, country, intermediateAddresses, oip, destinationSrs, optimizeBy, returnDistance, distanceUnit, returnTime, timeUnit, language, directionsStyle, segmentGeometryStyle, primaryNameOnly, majorRoads, historicTrafficTimeBucket, returnDirectionGeometry);
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
 **startAddress** | **string**| Start Address | 
 **endAddress** | **string**| End Address | 
 **db** | **string**| Database to retrieve boundary data | [optional] [default to driving]
 **country** | **string**| Three digit ISO country code | [optional] [default to USA]
 **intermediateAddresses** | **string**| Intermediate Addresses | [optional] 
 **oip** | **string**| Specify waypoints optimization | [optional] [default to false]
 **destinationSrs** | **string**| Coordinate sytem | [optional] 
 **optimizeBy** | **string**| Otimize by time/distance | [optional] [default to time]
 **returnDistance** | **string**| Specify distance in response | [optional] [default to true]
 **distanceUnit** | **string**| Unit to return distance | [optional] [default to m]
 **returnTime** | **string**| Specify time in response | [optional] [default to true]
 **timeUnit** | **string**| Unit to return time | [optional] [default to min]
 **language** | **string**| Language for travel direction | [optional] [default to en]
 **directionsStyle** | **string**| Route direction text style | [optional] [default to None]
 **segmentGeometryStyle** | **string**| Geometry segement for response | [optional] [default to none]
 **primaryNameOnly** | **string**| Return Primary street name only | [optional] [default to false]
 **majorRoads** | **string**| Include major Roads only | [optional] [default to false]
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] [default to None]
 **returnDirectionGeometry** | **string**| Include the geometry associated with each route instruction in route response | [optional] [default to false]

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
> GeoRouteResponse GetRouteByLocation (string startPoint, string endPoint, string db = null, string intermediatePoints = null, string oip = null, string destinationSrs = null, string optimizeBy = null, string returnDistance = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string language = null, string directionsStyle = null, string segmentGeometryStyle = null, string primaryNameOnly = null, string majorRoads = null, string historicTrafficTimeBucket = null, string returnDirectionGeometry = null)

Gets Route by Location

Gets Route by Location

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
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startPoint = startPoint_example;  // string | Start Point in Lat,Long,coordsys format
            var endPoint = endPoint_example;  // string | End Point in Lat,Long,coordsys format
            var db = db_example;  // string | Database to retrieve boundary data (optional)  (default to driving)
            var intermediatePoints = intermediatePoints_example;  // string | Intermediate Points in Multipoint format (optional) 
            var oip = oip_example;  // string | Specify waypoints optimization (optional)  (default to false)
            var destinationSrs = destinationSrs_example;  // string | Coordinate sytem (optional) 
            var optimizeBy = optimizeBy_example;  // string | Optimize by time/distance (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specify distance in response (optional)  (default to true)
            var distanceUnit = distanceUnit_example;  // string | Unit to return distance (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specify time in response (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Unit to return time (optional)  (default to min)
            var language = language_example;  // string | Language for travel direction (optional)  (default to en)
            var directionsStyle = directionsStyle_example;  // string | Route direction text style (optional)  (default to None)
            var segmentGeometryStyle = segmentGeometryStyle_example;  // string | Geometry segement for response (optional)  (default to none)
            var primaryNameOnly = primaryNameOnly_example;  // string | Return Primary street name only (optional)  (default to false)
            var majorRoads = majorRoads_example;  // string | Include major Roads only (optional)  (default to false)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional)  (default to None)
            var returnDirectionGeometry = returnDirectionGeometry_example;  // string | Include the geometry associated with each route instruction in route response (optional)  (default to false)

            try
            {
                // Gets Route by Location
                GeoRouteResponse result = apiInstance.GetRouteByLocation(startPoint, endPoint, db, intermediatePoints, oip, destinationSrs, optimizeBy, returnDistance, distanceUnit, returnTime, timeUnit, language, directionsStyle, segmentGeometryStyle, primaryNameOnly, majorRoads, historicTrafficTimeBucket, returnDirectionGeometry);
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
 **startPoint** | **string**| Start Point in Lat,Long,coordsys format | 
 **endPoint** | **string**| End Point in Lat,Long,coordsys format | 
 **db** | **string**| Database to retrieve boundary data | [optional] [default to driving]
 **intermediatePoints** | **string**| Intermediate Points in Multipoint format | [optional] 
 **oip** | **string**| Specify waypoints optimization | [optional] [default to false]
 **destinationSrs** | **string**| Coordinate sytem | [optional] 
 **optimizeBy** | **string**| Optimize by time/distance | [optional] [default to time]
 **returnDistance** | **string**| Specify distance in response | [optional] [default to true]
 **distanceUnit** | **string**| Unit to return distance | [optional] [default to m]
 **returnTime** | **string**| Specify time in response | [optional] [default to true]
 **timeUnit** | **string**| Unit to return time | [optional] [default to min]
 **language** | **string**| Language for travel direction | [optional] [default to en]
 **directionsStyle** | **string**| Route direction text style | [optional] [default to None]
 **segmentGeometryStyle** | **string**| Geometry segement for response | [optional] [default to none]
 **primaryNameOnly** | **string**| Return Primary street name only | [optional] [default to false]
 **majorRoads** | **string**| Include major Roads only | [optional] [default to false]
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] [default to None]
 **returnDirectionGeometry** | **string**| Include the geometry associated with each route instruction in route response | [optional] [default to false]

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
> TravelCostMatrixResponse GetTravelCostMatrixByAddress (string startAddresses, string endAddresses, string db = null, string country = null, string optimizeBy = null, string returnDistance = null, string destinationSrs = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string majorRoads = null, string returnOptimalRoutesOnly = null, string historicTrafficTimeBucket = null)

Gets Cost Matrix by Address

Gets Cost Matrix by Address

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
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startAddresses = startAddresses_example;  // string | Start Addresses
            var endAddresses = endAddresses_example;  // string | End Addresses
            var db = db_example;  // string | Database to retrieve boundary data (optional)  (default to driving)
            var country = country_example;  // string | 3 Digit ISO country code (optional)  (default to USA)
            var optimizeBy = optimizeBy_example;  // string | Otimize by time/distance (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specify distance in response (optional)  (default to true)
            var destinationSrs = destinationSrs_example;  // string | Coordinate sytem (optional) 
            var distanceUnit = distanceUnit_example;  // string | Unit to return distance (optional)  (default to m)
            var returnTime = returnTime_example;  // string | pecify time in response (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Unit to return time (optional)  (default to min)
            var majorRoads = majorRoads_example;  // string | Include major Roads only (optional)  (default to false)
            var returnOptimalRoutesOnly = returnOptimalRoutesOnly_example;  // string | Return optimal rutes only (optional)  (default to true)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional)  (default to None)

            try
            {
                // Gets Cost Matrix by Address
                TravelCostMatrixResponse result = apiInstance.GetTravelCostMatrixByAddress(startAddresses, endAddresses, db, country, optimizeBy, returnDistance, destinationSrs, distanceUnit, returnTime, timeUnit, majorRoads, returnOptimalRoutesOnly, historicTrafficTimeBucket);
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
 **startAddresses** | **string**| Start Addresses | 
 **endAddresses** | **string**| End Addresses | 
 **db** | **string**| Database to retrieve boundary data | [optional] [default to driving]
 **country** | **string**| 3 Digit ISO country code | [optional] [default to USA]
 **optimizeBy** | **string**| Otimize by time/distance | [optional] [default to time]
 **returnDistance** | **string**| Specify distance in response | [optional] [default to true]
 **destinationSrs** | **string**| Coordinate sytem | [optional] 
 **distanceUnit** | **string**| Unit to return distance | [optional] [default to m]
 **returnTime** | **string**| pecify time in response | [optional] [default to true]
 **timeUnit** | **string**| Unit to return time | [optional] [default to min]
 **majorRoads** | **string**| Include major Roads only | [optional] [default to false]
 **returnOptimalRoutesOnly** | **string**| Return optimal rutes only | [optional] [default to true]
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] [default to None]

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
> TravelCostMatrixResponse GetTravelCostMatrixByLocation (string startPoints, string endPoints, string db = null, string optimizeBy = null, string returnDistance = null, string destinationSrs = null, string distanceUnit = null, string returnTime = null, string timeUnit = null, string majorRoads = null, string returnOptimalRoutesOnly = null, string historicTrafficTimeBucket = null)

Gets Cost Matrix by Location

Gets Cost Matrix by Location

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
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRouteServiceApi();
            var startPoints = startPoints_example;  // string | Start points in multipoint format
            var endPoints = endPoints_example;  // string | End points in multipoint format
            var db = db_example;  // string | Database to retrieve boundary data (optional)  (default to driving)
            var optimizeBy = optimizeBy_example;  // string | Otimize by time/distance (optional)  (default to time)
            var returnDistance = returnDistance_example;  // string | Specify distance in response (optional)  (default to true)
            var destinationSrs = destinationSrs_example;  // string | Coordinate sytem (optional) 
            var distanceUnit = distanceUnit_example;  // string | Unit to return distance (optional)  (default to m)
            var returnTime = returnTime_example;  // string | Specify time in response (optional)  (default to true)
            var timeUnit = timeUnit_example;  // string | Unit to return time (optional)  (default to min)
            var majorRoads = majorRoads_example;  // string | Include major Roads only (optional)  (default to false)
            var returnOptimalRoutesOnly = returnOptimalRoutesOnly_example;  // string | Return optimal rutes only (optional)  (default to true)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Historic traffic time slab (optional)  (default to None)

            try
            {
                // Gets Cost Matrix by Location
                TravelCostMatrixResponse result = apiInstance.GetTravelCostMatrixByLocation(startPoints, endPoints, db, optimizeBy, returnDistance, destinationSrs, distanceUnit, returnTime, timeUnit, majorRoads, returnOptimalRoutesOnly, historicTrafficTimeBucket);
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
 **startPoints** | **string**| Start points in multipoint format | 
 **endPoints** | **string**| End points in multipoint format | 
 **db** | **string**| Database to retrieve boundary data | [optional] [default to driving]
 **optimizeBy** | **string**| Otimize by time/distance | [optional] [default to time]
 **returnDistance** | **string**| Specify distance in response | [optional] [default to true]
 **destinationSrs** | **string**| Coordinate sytem | [optional] 
 **distanceUnit** | **string**| Unit to return distance | [optional] [default to m]
 **returnTime** | **string**| Specify time in response | [optional] [default to true]
 **timeUnit** | **string**| Unit to return time | [optional] [default to min]
 **majorRoads** | **string**| Include major Roads only | [optional] [default to false]
 **returnOptimalRoutesOnly** | **string**| Return optimal rutes only | [optional] [default to true]
 **historicTrafficTimeBucket** | **string**| Historic traffic time slab | [optional] [default to None]

### Return type

[**TravelCostMatrixResponse**](TravelCostMatrixResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

