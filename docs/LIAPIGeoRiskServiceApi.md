# pb.locationIntelligence.Api.LIAPIGeoRiskServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCrimeRiskByAddress**](LIAPIGeoRiskServiceApi.md#getcrimeriskbyaddress) | **GET** /georisk/v1/crime/byaddress | Gets CrimeRiskResponse
[**GetCrimeRiskByLocation**](LIAPIGeoRiskServiceApi.md#getcrimeriskbylocation) | **GET** /georisk/v1/crime/bylocation | Gets CrimeRiskResponse
[**GetDistanceToCoastByAddress**](LIAPIGeoRiskServiceApi.md#getdistancetocoastbyaddress) | **GET** /georisk/v1/shoreline/distancetocoast/byaddress | Gets WaterBodyResponse
[**GetDistanceToCoastByLocation**](LIAPIGeoRiskServiceApi.md#getdistancetocoastbylocation) | **GET** /georisk/v1/shoreline/distancetocoast/bylocation | Gets WaterBodyResponse
[**GetEarthquakeHistory**](LIAPIGeoRiskServiceApi.md#getearthquakehistory) | **GET** /georisk/v1/earthquakehistory | Gets EarthquakeHistory
[**GetEarthquakeRiskByAddress**](LIAPIGeoRiskServiceApi.md#getearthquakeriskbyaddress) | **GET** /georisk/v1/earthquake/byaddress | Gets EarthquakeRiskResponse
[**GetEarthquakeRiskByLocation**](LIAPIGeoRiskServiceApi.md#getearthquakeriskbylocation) | **GET** /georisk/v1/earthquake/bylocation | Gets EarthquakeRiskResponse
[**GetFireHistory**](LIAPIGeoRiskServiceApi.md#getfirehistory) | **GET** /georisk/v1/firehistory | Gets FireHistory
[**GetFireRiskByAddress**](LIAPIGeoRiskServiceApi.md#getfireriskbyaddress) | **GET** /georisk/v1/fire/byaddress | Gets FireRiskResponse
[**GetFireRiskByAddressBatch**](LIAPIGeoRiskServiceApi.md#getfireriskbyaddressbatch) | **POST** /georisk/v1/fire/byaddress | Batch method for getting fire risk by address
[**GetFireRiskByLocation**](LIAPIGeoRiskServiceApi.md#getfireriskbylocation) | **GET** /georisk/v1/fire/bylocation | Gets FireRiskResponse
[**GetFireRiskByLocationBatch**](LIAPIGeoRiskServiceApi.md#getfireriskbylocationbatch) | **POST** /georisk/v1/fire/bylocation | Batch method for getting fire risk by location
[**GetFireStationByAddress**](LIAPIGeoRiskServiceApi.md#getfirestationbyaddress) | **GET** /georisk/v1/firestation/byaddress | Gets FireStationResponse
[**GetFireStationByLocation**](LIAPIGeoRiskServiceApi.md#getfirestationbylocation) | **GET** /georisk/v1/firestation/bylocation | Gets FireStationResponse
[**GetFloodRiskByAddress**](LIAPIGeoRiskServiceApi.md#getfloodriskbyaddress) | **GET** /georisk/v1/flood/byaddress | Gets FloodRiskResponse
[**GetFloodRiskByAddressBatch**](LIAPIGeoRiskServiceApi.md#getfloodriskbyaddressbatch) | **POST** /georisk/v1/flood/byaddress | Batch method for getting flood risk by address
[**GetFloodRiskByLocation**](LIAPIGeoRiskServiceApi.md#getfloodriskbylocation) | **GET** /georisk/v1/flood/bylocation | Gets FloodRiskResponse
[**GetFloodRiskByLocationBatch**](LIAPIGeoRiskServiceApi.md#getfloodriskbylocationbatch) | **POST** /georisk/v1/flood/bylocation | Batch method for getting flood risk by location


<a name="getcrimeriskbyaddress"></a>
# **GetCrimeRiskByAddress**
> CrimeRiskResponse GetCrimeRiskByAddress (string address, string type = null, string includeGeometry = null)

Gets CrimeRiskResponse

Returns the crime data or crime indexes for a given address input.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free-form address text.
            var type = type_example;  // string | Type of crime like violent crime, property crime, etc., multiple crime type indexes could be requested as comma separated values with 'all' as default.) (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Gets CrimeRiskResponse
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByAddress(address, type, includeGeometry);
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
 **address** | **string**| Free-form address text. | 
 **type** | **string**| Type of crime like violent crime, property crime, etc., multiple crime type indexes could be requested as comma separated values with &#39;all&#39; as default.) | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

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
> CrimeRiskResponse GetCrimeRiskByLocation (string longitude, string latitude, string type = null, string includeGeometry = null)

Gets CrimeRiskResponse

Returns the crime data or crime indexes for a given location.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var type = type_example;  // string | Refers to crime type. Valid values are following 11 crime types with 'all' as default (more than one can also be given as comma separated types) (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Gets CrimeRiskResponse
                CrimeRiskResponse result = apiInstance.GetCrimeRiskByLocation(longitude, latitude, type, includeGeometry);
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
 **type** | **string**| Refers to crime type. Valid values are following 11 crime types with &#39;all&#39; as default (more than one can also be given as comma separated types) | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**CrimeRiskResponse**](CrimeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistancetocoastbyaddress"></a>
# **GetDistanceToCoastByAddress**
> WaterBodyResponse GetDistanceToCoastByAddress (string address, string maxCandidates = null, string waterBodyType = null, string searchDistance = null, string searchDistanceUnit = null)

Gets WaterBodyResponse

Gets WaterBodyResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetDistanceToCoastByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | The address of the location
            var maxCandidates = maxCandidates_example;  // string | 1 (default value), Maximum value is 3 (optional) 
            var waterBodyType = waterBodyType_example;  // string | all (default value), oceanandsea,lake,others,unknown,intermittent (optional) 
            var searchDistance = searchDistance_example;  // string | 5000 miles (default value), minimum should be 0 (optional) 
            var searchDistanceUnit = searchDistanceUnit_example;  // string | miles (default value),feet, kilometers, meters (optional) 

            try
            {
                // Gets WaterBodyResponse
                WaterBodyResponse result = apiInstance.GetDistanceToCoastByAddress(address, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetDistanceToCoastByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address of the location | 
 **maxCandidates** | **string**| 1 (default value), Maximum value is 3 | [optional] 
 **waterBodyType** | **string**| all (default value), oceanandsea,lake,others,unknown,intermittent | [optional] 
 **searchDistance** | **string**| 5000 miles (default value), minimum should be 0 | [optional] 
 **searchDistanceUnit** | **string**| miles (default value),feet, kilometers, meters | [optional] 

### Return type

[**WaterBodyResponse**](WaterBodyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdistancetocoastbylocation"></a>
# **GetDistanceToCoastByLocation**
> WaterBodyResponse GetDistanceToCoastByLocation (string longitude, string latitude, string maxCandidates = null, string waterBodyType = null, string searchDistance = null, string searchDistanceUnit = null)

Gets WaterBodyResponse

Gets WaterBodyResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetDistanceToCoastByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var maxCandidates = maxCandidates_example;  // string | 1 (default value), Maximum value is 3 (optional) 
            var waterBodyType = waterBodyType_example;  // string | all (default value), oceanandsea,lake,others,unknown,intermittent (optional) 
            var searchDistance = searchDistance_example;  // string | This specifies the search distance (optional) 
            var searchDistanceUnit = searchDistanceUnit_example;  // string | miles (default value),feet, kilometers, meters (optional) 

            try
            {
                // Gets WaterBodyResponse
                WaterBodyResponse result = apiInstance.GetDistanceToCoastByLocation(longitude, latitude, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetDistanceToCoastByLocation: " + e.Message );
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
 **maxCandidates** | **string**| 1 (default value), Maximum value is 3 | [optional] 
 **waterBodyType** | **string**| all (default value), oceanandsea,lake,others,unknown,intermittent | [optional] 
 **searchDistance** | **string**| This specifies the search distance | [optional] 
 **searchDistanceUnit** | **string**| miles (default value),feet, kilometers, meters | [optional] 

### Return type

[**WaterBodyResponse**](WaterBodyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakehistory"></a>
# **GetEarthquakeHistory**
> EarthquakeHistory GetEarthquakeHistory (string postCode, string startDate = null, string endDate = null, string minMagnitude = null, string maxMagnitude = null, string maxCandidates = null)

Gets EarthquakeHistory

Gets EarthquakeHistory

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetEarthquakeHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var minMagnitude = minMagnitude_example;  // string | Minimum richter scale magnitude (optional) 
            var maxMagnitude = maxMagnitude_example;  // string | Maximum Richter scale magnitude (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional)  (default to 1)

            try
            {
                // Gets EarthquakeHistory
                EarthquakeHistory result = apiInstance.GetEarthquakeHistory(postCode, startDate, endDate, minMagnitude, maxMagnitude, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetEarthquakeHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postCode** | **string**| 5 digit Postal code to search | 
 **startDate** | **string**| Start time in milliseconds(UTC) | [optional] 
 **endDate** | **string**| End time in milliseconds(UTC) | [optional] 
 **minMagnitude** | **string**| Minimum richter scale magnitude | [optional] 
 **maxMagnitude** | **string**| Maximum Richter scale magnitude | [optional] 
 **maxCandidates** | **string**| Maximum response events | [optional] [default to 1]

### Return type

[**EarthquakeHistory**](EarthquakeHistory.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearthquakeriskbyaddress"></a>
# **GetEarthquakeRiskByAddress**
> EarthquakeRiskResponse GetEarthquakeRiskByAddress (string address, string richterValue = null, string includeGeometry = null)

Gets EarthquakeRiskResponse

Returns the count of earthquake events for various richter measurements and values for an input address.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free-form address text
            var richterValue = richterValue_example;  // string | Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events >= richter scale 6), etc., multiple richter scales could be requested as comma separated values with 'all' as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Gets EarthquakeRiskResponse
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByAddress(address, richterValue, includeGeometry);
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
 **address** | **string**| Free-form address text | 
 **richterValue** | **string**| Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events &gt;&#x3D; richter scale 6), etc., multiple richter scales could be requested as comma separated values with &#39;all&#39; as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

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
> EarthquakeRiskResponse GetEarthquakeRiskByLocation (string longitude, string latitude, string richterValue = null, string includeGeometry = null)

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | The longitude of the location
            var latitude = latitude_example;  // string | The latitude of the location
            var richterValue = richterValue_example;  // string | Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events >= richter scale 6), etc., multiple richter scales could be requested as comma separated values with 'all' as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Gets EarthquakeRiskResponse
                EarthquakeRiskResponse result = apiInstance.GetEarthquakeRiskByLocation(longitude, latitude, richterValue, includeGeometry);
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
 **richterValue** | **string**| Richter values like R5 (count of richter scale 5 events), R7 (count of richter scale 7 events), R6_GE (count of events &gt;&#x3D; richter scale 6), etc., multiple richter scales could be requested as comma separated values with &#39;all&#39; as default. Valid values: All (default value), R0, R1, R2, R3, R4, R5, R6, R7, R0_GE, R1_GE, R2_GE, R3_GE, R4_GE, R5_GE, R6_GE, R7_GE | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**EarthquakeRiskResponse**](EarthquakeRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirehistory"></a>
# **GetFireHistory**
> FireHistory GetFireHistory (string postCode, string startDate = null, string endDate = null, string maxCandidates = null)

Gets FireHistory

Gets FireHistory

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var postCode = postCode_example;  // string | 5 digit Postal code to search
            var startDate = startDate_example;  // string | Start time in milliseconds(UTC) (optional) 
            var endDate = endDate_example;  // string | End time in milliseconds(UTC) (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum response events (optional)  (default to 1)

            try
            {
                // Gets FireHistory
                FireHistory result = apiInstance.GetFireHistory(postCode, startDate, endDate, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postCode** | **string**| 5 digit Postal code to search | 
 **startDate** | **string**| Start time in milliseconds(UTC) | [optional] 
 **endDate** | **string**| End time in milliseconds(UTC) | [optional] 
 **maxCandidates** | **string**| Maximum response events | [optional] [default to 1]

### Return type

[**FireHistory**](FireHistory.md)

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

Returns the fire data based on address input.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free-form address text

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
 **address** | **string**| Free-form address text | 

### Return type

[**FireRiskResponse**](FireRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfireriskbyaddressbatch"></a>
# **GetFireRiskByAddressBatch**
> FireRiskResponseList GetFireRiskByAddressBatch (FireRiskByAddressRequest body = null)

Batch method for getting fire risk by address

Batch method for getting fire risk by address

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireRiskByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var body = new FireRiskByAddressRequest(); // FireRiskByAddressRequest |  (optional) 

            try
            {
                // Batch method for getting fire risk by address
                FireRiskResponseList result = apiInstance.GetFireRiskByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireRiskByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FireRiskByAddressRequest**](FireRiskByAddressRequest.md)|  | [optional] 

### Return type

[**FireRiskResponseList**](FireRiskResponseList.md)

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

Returns the fire data based on location input.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

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

<a name="getfireriskbylocationbatch"></a>
# **GetFireRiskByLocationBatch**
> FireRiskResponseList GetFireRiskByLocationBatch (FireRiskByLocationRequest body = null)

Batch method for getting fire risk by location

Batch method for getting fire risk by location

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFireRiskByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var body = new FireRiskByLocationRequest(); // FireRiskByLocationRequest |  (optional) 

            try
            {
                // Batch method for getting fire risk by location
                FireRiskResponseList result = apiInstance.GetFireRiskByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFireRiskByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FireRiskByLocationRequest**](FireRiskByLocationRequest.md)|  | [optional] 

### Return type

[**FireRiskResponseList**](FireRiskResponseList.md)

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

Returns the nearest Firestations from an input address.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | The address to be searched.
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. (optional) 
            var travelTime = travelTime_example;  // string | Max travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Maximum travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var sortBy = sortBy_example;  // string | Sort the fire stations results by either travel time or travel distance (nearest first). Default sorting is by travel time. (optional) 

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
 **address** | **string**| The address to be searched. | 
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3 and maximum value is 5. The retrieved results are traveldistance sorted from the input location. | [optional] 
 **travelTime** | **string**| Max travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Maximum travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **sortBy** | **string**| Sort the fire stations results by either travel time or travel distance (nearest first). Default sorting is by travel time. | [optional] 

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

Returns the nearest Firestations from an input location.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var maxCandidates = maxCandidates_example;  // string | Specifies the maximum number of fire stations that this service retrieves. The default value is 3. The retrieved fire stations are distance ordered from the specified location. Maximum of 5 fire stations can be retrieved. (optional) 
            var travelTime = travelTime_example;  // string | Maximum travel time from input location to fire station. Maximum allowed is 2 hours (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel time unit such as minutes (default), hours, seconds or milliseconds. (optional) 
            var travelDistance = travelDistance_example;  // string | Maximum travel distance from input location to fire station. Maximum allowed is 50 miles (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distance unit such as Feet (default), Kilometers, Miles or Meters. (optional) 
            var sortBy = sortBy_example;  // string | Sorting of fire stations in result by travel time/distance (nearest first from input location). (optional) 

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
 **maxCandidates** | **string**| Specifies the maximum number of fire stations that this service retrieves. The default value is 3. The retrieved fire stations are distance ordered from the specified location. Maximum of 5 fire stations can be retrieved. | [optional] 
 **travelTime** | **string**| Maximum travel time from input location to fire station. Maximum allowed is 2 hours | [optional] 
 **travelTimeUnit** | **string**| Travel time unit such as minutes (default), hours, seconds or milliseconds. | [optional] 
 **travelDistance** | **string**| Maximum travel distance from input location to fire station. Maximum allowed is 50 miles | [optional] 
 **travelDistanceUnit** | **string**| Travel distance unit such as Feet (default), Kilometers, Miles or Meters. | [optional] 
 **sortBy** | **string**| Sorting of fire stations in result by travel time/distance (nearest first from input location). | [optional] 

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
> FloodRiskResponse GetFloodRiskByAddress (string address, string includeZoneDesc = null, string includeGeometry = null)

Gets FloodRiskResponse

Returns the Flood Risk data for flood zones based on an address.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var address = address_example;  // string | Free-text Address
            var includeZoneDesc = includeZoneDesc_example;  // string | Specifies primary zone description. Valid Values: 'Y' or 'N'. (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Gets FloodRiskResponse
                FloodRiskResponse result = apiInstance.GetFloodRiskByAddress(address, includeZoneDesc, includeGeometry);
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
 **address** | **string**| Free-text Address | 
 **includeZoneDesc** | **string**| Specifies primary zone description. Valid Values: &#39;Y&#39; or &#39;N&#39;. | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbyaddressbatch"></a>
# **GetFloodRiskByAddressBatch**
> FloodRiskResponseList GetFloodRiskByAddressBatch (FloodRiskByAddressRequest body = null)

Batch method for getting flood risk by address

Batch method for getting flood risk by address

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFloodRiskByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var body = new FloodRiskByAddressRequest(); // FloodRiskByAddressRequest |  (optional) 

            try
            {
                // Batch method for getting flood risk by address
                FloodRiskResponseList result = apiInstance.GetFloodRiskByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFloodRiskByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FloodRiskByAddressRequest**](FloodRiskByAddressRequest.md)|  | [optional] 

### Return type

[**FloodRiskResponseList**](FloodRiskResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbylocation"></a>
# **GetFloodRiskByLocation**
> FloodRiskResponse GetFloodRiskByLocation (string longitude, string latitude, string includeZoneDesc = null, string includeGeometry = null)

Gets FloodRiskResponse

Returns the Flood Risk data for Flood Zones and Base Flood Elevation, based on location.

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
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var includeZoneDesc = includeZoneDesc_example;  // string | Specifies primary zone description. Valid Values: 'Y' or 'N'. Default: 'Y' (optional) 
            var includeGeometry = includeGeometry_example;  // string | Y or N (default is N) - if it is Y, then geometry will be part of response (optional) 

            try
            {
                // Gets FloodRiskResponse
                FloodRiskResponse result = apiInstance.GetFloodRiskByLocation(longitude, latitude, includeZoneDesc, includeGeometry);
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
 **includeZoneDesc** | **string**| Specifies primary zone description. Valid Values: &#39;Y&#39; or &#39;N&#39;. Default: &#39;Y&#39; | [optional] 
 **includeGeometry** | **string**| Y or N (default is N) - if it is Y, then geometry will be part of response | [optional] 

### Return type

[**FloodRiskResponse**](FloodRiskResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfloodriskbylocationbatch"></a>
# **GetFloodRiskByLocationBatch**
> FloodRiskResponseList GetFloodRiskByLocationBatch (FloodRiskByLocationRequest body = null)

Batch method for getting flood risk by location

Batch method for getting flood risk by location

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetFloodRiskByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoRiskServiceApi();
            var body = new FloodRiskByLocationRequest(); // FloodRiskByLocationRequest |  (optional) 

            try
            {
                // Batch method for getting flood risk by location
                FloodRiskResponseList result = apiInstance.GetFloodRiskByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoRiskServiceApi.GetFloodRiskByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FloodRiskByLocationRequest**](FloodRiskByLocationRequest.md)|  | [optional] 

### Return type

[**FloodRiskResponseList**](FloodRiskResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

