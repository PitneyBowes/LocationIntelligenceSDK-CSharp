# pb.locationIntelligence.Api.LIAPIGeoRiskServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrimeRiskByAddress**](LIAPIGeoRiskServiceApi.md#getcrimeriskbyaddress) | **GET** /georisk/v1/crime/byaddress | Gets CrimeRiskResponse
[**GetCrimeRiskByLocation**](LIAPIGeoRiskServiceApi.md#getcrimeriskbylocation) | **GET** /georisk/v1/crime/bylocation | Gets CrimeRiskResponse
[**GetEarthquakeRiskByAddress**](LIAPIGeoRiskServiceApi.md#getearthquakeriskbyaddress) | **GET** /georisk/v1/earthquake/byaddress | Gets EarthquakeRiskResponse
[**GetEarthquakeRiskByLocation**](LIAPIGeoRiskServiceApi.md#getearthquakeriskbylocation) | **GET** /georisk/v1/earthquake/bylocation | Gets EarthquakeRiskResponse
[**GetFireRiskByAddress**](LIAPIGeoRiskServiceApi.md#getfireriskbyaddress) | **GET** /georisk/v1/fire/byaddress | Gets FireRiskResponse
[**GetFireRiskByLocation**](LIAPIGeoRiskServiceApi.md#getfireriskbylocation) | **GET** /georisk/v1/fire/bylocation | Gets FireRiskResponse
[**GetFireStationByAddress**](LIAPIGeoRiskServiceApi.md#getfirestationbyaddress) | **GET** /georisk/v1/firestation/byaddress | Gets FireStationResponse
[**GetFireStationByLocation**](LIAPIGeoRiskServiceApi.md#getfirestationbylocation) | **GET** /georisk/v1/firestation/bylocation | Gets FireStationResponse
[**GetFloodRiskByAddress**](LIAPIGeoRiskServiceApi.md#getfloodriskbyaddress) | **GET** /georisk/v1/flood/byaddress | Gets FloodRiskResponse
[**GetFloodRiskByLocation**](LIAPIGeoRiskServiceApi.md#getfloodriskbylocation) | **GET** /georisk/v1/flood/bylocation | Gets FloodRiskResponse


<a name="getcrimeriskbyaddress"></a>
# **GetCrimeRiskByAddress**
> CrimeRiskResponse GetCrimeRiskByAddress (string address, string type = null)

Gets CrimeRiskResponse

Gets CrimeRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetCrimeRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | free form address text
            var type = type_example;  // string | this is crime type; valid values are following 11 crime types with 'all' as default (more than one can also be given as comma separated types) (optional) 

            try
            {
                // Gets CrimeRiskResponse
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByAddress(address, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetCrimeRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **type** | **string**| this is crime type; valid values are following 11 crime types with &#39;all&#39; as default (more than one can also be given as comma separated types) | [optional] 

### Return type

[**CrimeRiskResponse**](CrimeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcrimeriskbylocation"></a>
# **GetCrimeRiskByLocation**
> CrimeRiskResponse GetCrimeRiskByLocation (string longitude, string latitude, string type = null)

Gets CrimeRiskResponse

Gets CrimeRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetCrimeRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var type = type_example;  // string | this is crime type; valid values are following 11 crime types with 'all' as default (more than one can also be given as comma separated types) (optional) 

            try
            {
                // Gets CrimeRiskResponse
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByLocation(longitude, latitude, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetCrimeRiskByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| The longitude of the location | 
 **latitude** | **string**| The latitude of the location | 
 **type** | **string**| this is crime type; valid values are following 11 crime types with &#39;all&#39; as default (more than one can also be given as comma separated types) | [optional] 

### Return type

[**CrimeRiskResponse**](CrimeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbyaddress"></a>
# **GetEarthquakeRiskByAddress**
> EarthquakeRiskResponse GetEarthquakeRiskByAddress (string address, string richterValue = null)

Gets EarthquakeRiskResponse

Gets EarthquakeRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetEarthquakeRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | free form address text
            var richterValue = richterValue_example;  // string | all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 

            try
            {
                // Gets EarthquakeRiskResponse
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByAddress(address, richterValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetEarthquakeRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **richterValue** | **string**| all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 

### Return type

[**EarthquakeRiskResponse**](EarthquakeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbylocation"></a>
# **GetEarthquakeRiskByLocation**
> EarthquakeRiskResponse GetEarthquakeRiskByLocation (string longitude, string latitude, string richterValue = null)

Gets EarthquakeRiskResponse

Gets EarthquakeRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetEarthquakeRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var richterValue = richterValue_example;  // string | all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 

            try
            {
                // Gets EarthquakeRiskResponse
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByLocation(longitude, latitude, richterValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetEarthquakeRiskByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| The longitude of the location | 
 **latitude** | **string**| The latitude of the location | 
 **richterValue** | **string**| all (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 

### Return type

[**EarthquakeRiskResponse**](EarthquakeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbyaddress"></a>
# **GetFireRiskByAddress**
> FireRiskResponse GetFireRiskByAddress (string address)

Gets FireRiskResponse

Gets FireRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free form address text

            try
            {
                // Gets FireRiskResponse
                FireRiskResponse result = apiInstance.GetFireRiskByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free form address text | 

### Return type

[**FireRiskResponse**](FireRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbylocation"></a>
# **GetFireRiskByLocation**
> FireRiskResponse GetFireRiskByLocation (string longitude, string latitude)

Gets FireRiskResponse

Gets FireRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location

            try
            {
                // Gets FireRiskResponse
                FireRiskResponse result = apiInstance.GetFireRiskByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireRiskByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Longitude of Location | 
 **latitude** | **string**| Latitude of Location | 

### Return type

[**FireRiskResponse**](FireRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirestationbyaddress"></a>
# **GetFireStationByAddress**
> FireStations GetFireStationByAddress (string address, string maxCandidates = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string sortBy = null)

Gets FireStationResponse

Gets FireStationResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireStationByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free Address
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. (optional) 
            var travelTime = travelTime_example;  // string | Max travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | minutes (default), hours, seconds, milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Max travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Feet (default), Kilometers, Miles, Meters (optional) 
            var sortBy = sortBy_example;  // string | time (default), distance (optional) 

            try
            {
                // Gets FireStationResponse
                FireStations result = apiInstance.GetFireStationByAddress(address, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireStationByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free Address | 
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. | [optional] 
 **travelTime** | **string**| Max travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| minutes (default), hours, seconds, milliseconds | [optional] 
 **travelDistance** | **string**| Max travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Feet (default), Kilometers, Miles, Meters | [optional] 
 **sortBy** | **string**| time (default), distance | [optional] 

### Return type

[**FireStations**](FireStations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirestationbylocation"></a>
# **GetFireStationByLocation**
> FireStations GetFireStationByLocation (string longitude, string latitude, string maxCandidates = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string sortBy = null)

Gets FireStationResponse

Gets FireStationResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireStationByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. (optional) 
            var travelTime = travelTime_example;  // string | Max travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | minutes (default), hours, seconds, milliseconds (optional) 
            var travelDistance = travelDistance_example;  // string | Max travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Feet (default), Kilometers, Miles, Meters (optional) 
            var sortBy = sortBy_example;  // string | time (default), distance (optional) 

            try
            {
                // Gets FireStationResponse
                FireStations result = apiInstance.GetFireStationByLocation(longitude, latitude, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireStationByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Longitude of Location | 
 **latitude** | **string**| Latitude of Location | 
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. | [optional] 
 **travelTime** | **string**| Max travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| minutes (default), hours, seconds, milliseconds | [optional] 
 **travelDistance** | **string**| Max travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Feet (default), Kilometers, Miles, Meters | [optional] 
 **sortBy** | **string**| time (default), distance | [optional] 

### Return type

[**FireStations**](FireStations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbyaddress"></a>
# **GetFloodRiskByAddress**
> FloodRiskResponse GetFloodRiskByAddress (string address, string includeZoneDesc = null)

Gets FloodRiskResponse

Gets FloodRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFloodRiskByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free text Address
            var includeZoneDesc = includeZoneDesc_example;  // string | Flag to return zone description (optional) 

            try
            {
                // Gets FloodRiskResponse
                FloodRiskResponse result = apiInstance.GetFloodRiskByAddress(address, includeZoneDesc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFloodRiskByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Free text Address | 
 **includeZoneDesc** | **string**| Flag to return zone description | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbylocation"></a>
# **GetFloodRiskByLocation**
> FloodRiskResponse GetFloodRiskByLocation (string longitude, string latitude, string includeZoneDesc = null)

Gets FloodRiskResponse

Gets FloodRiskResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFloodRiskByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var includeZoneDesc = includeZoneDesc_example;  // string | Flag to return zone description (optional) 

            try
            {
                // Gets FloodRiskResponse
                FloodRiskResponse result = apiInstance.GetFloodRiskByLocation(longitude, latitude, includeZoneDesc);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFloodRiskByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Longitude of Location | 
 **latitude** | **string**| Latitude of Location | 
 **includeZoneDesc** | **string**| Flag to return zone description | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

