# pb.locationIntelligence.Api.LIAPIGeoPropertyServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGeoPropertyByAddress**](LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddress) | **GET** /geoproperty/v1/all/attributes/byaddress | Gets GeoPropertyResponse
[**GetGeoPropertyByAddressBatch**](LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddressbatch) | **POST** /geoproperty/v1/all/attributes/byaddress | Gets GeoPropertyResponses
[**GetGeoPropertyByPBKey**](LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkey) | **GET** /geoproperty/v1/all/attributes/bypbkey | Gets GeoPropertyResponse
[**GetGeoPropertyByPBKeyBatch**](LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkeybatch) | **POST** /geoproperty/v1/all/attributes/bypbkey | Gets GeoPropertyResponses
[**GetParcelBoundaryByAddress**](LIAPIGeoPropertyServiceApi.md#getparcelboundarybyaddress) | **GET** /geoproperty/v1/parcelboundary/byaddress | Gets ParcelBoundary
[**GetParcelBoundaryByLocation**](LIAPIGeoPropertyServiceApi.md#getparcelboundarybylocation) | **GET** /geoproperty/v1/parcelboundary/bylocation | Gets ParcelBoundary
[**GetParcelBoundaryByPBKey**](LIAPIGeoPropertyServiceApi.md#getparcelboundarybypbkey) | **GET** /geoproperty/v1/parcelboundary/bypbkey | Gets ParcelBoundary
[**GetSchoolsByAddress**](LIAPIGeoPropertyServiceApi.md#getschoolsbyaddress) | **GET** /geoproperty/v1/school/byaddress | Search Nearby Schools by Address
[**GetSchoolsNearByUsingPBKey**](LIAPIGeoPropertyServiceApi.md#getschoolsnearbyusingpbkey) | **GET** /geoproperty/v1/school/bypbkey | Search Nearby Schools by PBKey


<a name="getgeopropertybyaddress"></a>
# **GetGeoPropertyByAddress**
> GeoPropertyResponse GetGeoPropertyByAddress (string address)

Gets GeoPropertyResponse

Gets GeoPropertyResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var address = address_example;  // string | free form address text

            try
            {
                // Gets GeoPropertyResponse
                GeoPropertyResponse result = apiInstance.GetGeoPropertyByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 

### Return type

[**GeoPropertyResponse**](GeoPropertyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybyaddressbatch"></a>
# **GetGeoPropertyByAddressBatch**
> GeoPropertyResponses GetGeoPropertyByAddressBatch (GeoPropertyAddressRequest body = null)

Gets GeoPropertyResponses

Gets GeoPropertyResponses

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var body = new GeoPropertyAddressRequest(); // GeoPropertyAddressRequest |  (optional) 

            try
            {
                // Gets GeoPropertyResponses
                GeoPropertyResponses result = apiInstance.GetGeoPropertyByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeoPropertyAddressRequest**](GeoPropertyAddressRequest.md)|  | [optional] 

### Return type

[**GeoPropertyResponses**](GeoPropertyResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybypbkey"></a>
# **GetGeoPropertyByPBKey**
> GeoPropertyPBKeyResponse GetGeoPropertyByPBKey (string pbKey)

Gets GeoPropertyResponse

Gets GeoPropertyResponse

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var pbKey = pbKey_example;  // string | free form text

            try
            {
                // Gets GeoPropertyResponse
                GeoPropertyPBKeyResponse result = apiInstance.GetGeoPropertyByPBKey(pbKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByPBKey: " + e.Message );
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

[**GeoPropertyPBKeyResponse**](GeoPropertyPBKeyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeopropertybypbkeybatch"></a>
# **GetGeoPropertyByPBKeyBatch**
> GeoPropertyPBKeyResponses GetGeoPropertyByPBKeyBatch (GeoPropertyPBKeyRequest body = null)

Gets GeoPropertyResponses

Gets GeoPropertyResponses

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetGeoPropertyByPBKeyBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var body = new GeoPropertyPBKeyRequest(); // GeoPropertyPBKeyRequest |  (optional) 

            try
            {
                // Gets GeoPropertyResponses
                GeoPropertyPBKeyResponses result = apiInstance.GetGeoPropertyByPBKeyBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetGeoPropertyByPBKeyBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeoPropertyPBKeyRequest**](GeoPropertyPBKeyRequest.md)|  | [optional] 

### Return type

[**GeoPropertyPBKeyResponses**](GeoPropertyPBKeyResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelboundarybyaddress"></a>
# **GetParcelBoundaryByAddress**
> ParcelBoundary GetParcelBoundaryByAddress (string address, string accept = null)

Gets ParcelBoundary

Gets ParcelBoundary

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetParcelBoundaryByAddressExample
    {
        public void main()
        {
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var address = address_example;  // string | free form address text
            var accept = accept_example;  // string |  (optional) 

            try
            {
                // Gets ParcelBoundary
                ParcelBoundary result = apiInstance.GetParcelBoundaryByAddress(address, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetParcelBoundaryByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **accept** | **string**|  | [optional] 

### Return type

[**ParcelBoundary**](ParcelBoundary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelboundarybylocation"></a>
# **GetParcelBoundaryByLocation**
> ParcelBoundary GetParcelBoundaryByLocation (string longitude, string latitude, string accept = null)

Gets ParcelBoundary

Gets ParcelBoundary

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetParcelBoundaryByLocationExample
    {
        public void main()
        {
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var longitude = longitude_example;  // string | Longitude of Location
            var latitude = latitude_example;  // string | Latitude of Location
            var accept = accept_example;  // string |  (optional) 

            try
            {
                // Gets ParcelBoundary
                ParcelBoundary result = apiInstance.GetParcelBoundaryByLocation(longitude, latitude, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetParcelBoundaryByLocation: " + e.Message );
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
 **accept** | **string**|  | [optional] 

### Return type

[**ParcelBoundary**](ParcelBoundary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelboundarybypbkey"></a>
# **GetParcelBoundaryByPBKey**
> ParcelBoundary GetParcelBoundaryByPBKey (string pbKey, string accept = null)

Gets ParcelBoundary

Gets ParcelBoundary

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetParcelBoundaryByPBKeyExample
    {
        public void main()
        {
            
            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var pbKey = pbKey_example;  // string | PB specific unique key for each address
            var accept = accept_example;  // string |  (optional) 

            try
            {
                // Gets ParcelBoundary
                ParcelBoundary result = apiInstance.GetParcelBoundaryByPBKey(pbKey, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetParcelBoundaryByPBKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbKey** | **string**| PB specific unique key for each address | 
 **accept** | **string**|  | [optional] 

### Return type

[**ParcelBoundary**](ParcelBoundary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolsbyaddress"></a>
# **GetSchoolsByAddress**
> SchoolsNearByResponse GetSchoolsByAddress (string address, string edLevel = null, string schoolType = null, string schoolSubType = null, string gender = null, string assignedSchoolsOnly = null, string districtSchoolsOnly = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string maxCandidates = null)

Search Nearby Schools by Address

Search Nearby Schools by Address

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSchoolsByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var address = address_example;  // string | free form address text
            var edLevel = edLevel_example;  // string | Single digit code for education level applicable values are P -> primary, M -> Middle, H -> High, O -> Mixed Grades for public school type andE -> Elementary , S -> Secondary , O -> Others mixed grades for private schools  (optional) 
            var schoolType = schoolType_example;  // string | Single digit code for schoolTypes applicable values are PRI and PUB (optional) 
            var schoolSubType = schoolSubType_example;  // string | Single digit code for schoolSubType Applicable values are C, M, A, R, I, L, P, V, U, S (i.e. Charter, Magnet, Alternative, Regular, Indian, Military, Reportable Program, Vocational, Unknown, Special Education) (optional) 
            var gender = gender_example;  // string | Single digit code for gender Applicable values are C, F, M (Coed, All Females, All Males) (optional) 
            var assignedSchoolsOnly = assignedSchoolsOnly_example;  // string | Single digit code for assignedSchoolOnly applicable values are  Y/N  (optional) 
            var districtSchoolsOnly = districtSchoolsOnly_example;  // string | Single digit code for districtSchoolOnly applicable values are Y/N  (optional) 
            var searchRadius = searchRadius_example;  // string | Search Radius within which schools are searched (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search Radius unit applicable values are feet,kilometers,miles,meters (optional) 
            var travelTime = travelTime_example;  // string | Travel Time based on ‘travelMode’ within which schools are searched. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel Time unit applicable values are minutes,hours,seconds,milliseconds  (optional) 
            var travelDistance = travelDistance_example;  // string | Travel Distance based on ‘travelMode’ within which schools are searched. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distanceUnit applicable values are feet,kilometers,miles,meters (optional) 
            var travelMode = travelMode_example;  // string | Travel mode Required when travelDistance or travelTime is specified. Accepted values are walking,driving (optional) 
            var maxCandidates = maxCandidates_example;  // string | Max result to search  (optional)  (default to 10)

            try
            {
                // Search Nearby Schools by Address
                SchoolsNearByResponse result = apiInstance.GetSchoolsByAddress(address, edLevel, schoolType, schoolSubType, gender, assignedSchoolsOnly, districtSchoolsOnly, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetSchoolsByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| free form address text | 
 **edLevel** | **string**| Single digit code for education level applicable values are P -&gt; primary, M -&gt; Middle, H -&gt; High, O -&gt; Mixed Grades for public school type andE -&gt; Elementary , S -&gt; Secondary , O -&gt; Others mixed grades for private schools  | [optional] 
 **schoolType** | **string**| Single digit code for schoolTypes applicable values are PRI and PUB | [optional] 
 **schoolSubType** | **string**| Single digit code for schoolSubType Applicable values are C, M, A, R, I, L, P, V, U, S (i.e. Charter, Magnet, Alternative, Regular, Indian, Military, Reportable Program, Vocational, Unknown, Special Education) | [optional] 
 **gender** | **string**| Single digit code for gender Applicable values are C, F, M (Coed, All Females, All Males) | [optional] 
 **assignedSchoolsOnly** | **string**| Single digit code for assignedSchoolOnly applicable values are  Y/N  | [optional] 
 **districtSchoolsOnly** | **string**| Single digit code for districtSchoolOnly applicable values are Y/N  | [optional] 
 **searchRadius** | **string**| Search Radius within which schools are searched | [optional] 
 **searchRadiusUnit** | **string**| Search Radius unit applicable values are feet,kilometers,miles,meters | [optional] 
 **travelTime** | **string**| Travel Time based on ‘travelMode’ within which schools are searched. | [optional] 
 **travelTimeUnit** | **string**| Travel Time unit applicable values are minutes,hours,seconds,milliseconds  | [optional] 
 **travelDistance** | **string**| Travel Distance based on ‘travelMode’ within which schools are searched. | [optional] 
 **travelDistanceUnit** | **string**| Travel distanceUnit applicable values are feet,kilometers,miles,meters | [optional] 
 **travelMode** | **string**| Travel mode Required when travelDistance or travelTime is specified. Accepted values are walking,driving | [optional] 
 **maxCandidates** | **string**| Max result to search  | [optional] [default to 10]

### Return type

[**SchoolsNearByResponse**](SchoolsNearByResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolsnearbyusingpbkey"></a>
# **GetSchoolsNearByUsingPBKey**
> SchoolsNearByResponse GetSchoolsNearByUsingPBKey (string pbKey, string edLevel = null, string schoolType = null, string schoolSubType = null, string gender = null, string assignedSchoolsOnly = null, string districtSchoolsOnly = null, string searchRadius = null, string searchRadiusUnit = null, string travelTime = null, string travelTimeUnit = null, string travelDistance = null, string travelDistanceUnit = null, string travelMode = null, string maxCandidates = null)

Search Nearby Schools by PBKey

Search Nearby Schools by PBKey

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSchoolsNearByUsingPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeoPropertyServiceApi();
            var pbKey = pbKey_example;  // string | free form text
            var edLevel = edLevel_example;  // string | Single digit code for education level applicable values are P -> primary, M -> Middle, H -> High, O -> Mixed Grades for public school type andE -> Elementary , S -> Secondary , O -> Others mixed grades for private schools  (optional) 
            var schoolType = schoolType_example;  // string | Single digit code for schoolTypes applicable values are PRI and PUB (optional) 
            var schoolSubType = schoolSubType_example;  // string | Single digit code for schoolSubType Applicable values are C, M, A, R, I, L, P, V, U, S (i.e. Charter, Magnet, Alternative, Regular, Indian, Military, Reportable Program, Vocational, Unknown, Special Education) (optional) 
            var gender = gender_example;  // string | Single digit code for gender Applicable values are C, F, M (Coed, All Females, All Males) (optional) 
            var assignedSchoolsOnly = assignedSchoolsOnly_example;  // string | Single digit code for assignedSchoolOnly applicable values are  Y/N  (optional) 
            var districtSchoolsOnly = districtSchoolsOnly_example;  // string | Single digit code for districtSchoolOnly applicable values are Y/N  (optional) 
            var searchRadius = searchRadius_example;  // string | Search Radius within which schools are searched (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search Radius unit applicable values are feet,kilometers,miles,meters (optional) 
            var travelTime = travelTime_example;  // string | Travel Time based on ‘travelMode’ within which schools are searched. (optional) 
            var travelTimeUnit = travelTimeUnit_example;  // string | Travel Time unit applicable values are minutes,hours,seconds,milliseconds  (optional) 
            var travelDistance = travelDistance_example;  // string | Travel Distance based on ‘travelMode’ within which schools are searched. (optional) 
            var travelDistanceUnit = travelDistanceUnit_example;  // string | Travel distanceUnit applicable values are feet,kilometers,miles,meters (optional) 
            var travelMode = travelMode_example;  // string | Travel mode Required when travelDistance or travelTime is specified. Accepted values are walking,driving (optional) 
            var maxCandidates = maxCandidates_example;  // string | Max result to search  (optional)  (default to 10)

            try
            {
                // Search Nearby Schools by PBKey
                SchoolsNearByResponse result = apiInstance.GetSchoolsNearByUsingPBKey(pbKey, edLevel, schoolType, schoolSubType, gender, assignedSchoolsOnly, districtSchoolsOnly, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoPropertyServiceApi.GetSchoolsNearByUsingPBKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pbKey** | **string**| free form text | 
 **edLevel** | **string**| Single digit code for education level applicable values are P -&gt; primary, M -&gt; Middle, H -&gt; High, O -&gt; Mixed Grades for public school type andE -&gt; Elementary , S -&gt; Secondary , O -&gt; Others mixed grades for private schools  | [optional] 
 **schoolType** | **string**| Single digit code for schoolTypes applicable values are PRI and PUB | [optional] 
 **schoolSubType** | **string**| Single digit code for schoolSubType Applicable values are C, M, A, R, I, L, P, V, U, S (i.e. Charter, Magnet, Alternative, Regular, Indian, Military, Reportable Program, Vocational, Unknown, Special Education) | [optional] 
 **gender** | **string**| Single digit code for gender Applicable values are C, F, M (Coed, All Females, All Males) | [optional] 
 **assignedSchoolsOnly** | **string**| Single digit code for assignedSchoolOnly applicable values are  Y/N  | [optional] 
 **districtSchoolsOnly** | **string**| Single digit code for districtSchoolOnly applicable values are Y/N  | [optional] 
 **searchRadius** | **string**| Search Radius within which schools are searched | [optional] 
 **searchRadiusUnit** | **string**| Search Radius unit applicable values are feet,kilometers,miles,meters | [optional] 
 **travelTime** | **string**| Travel Time based on ‘travelMode’ within which schools are searched. | [optional] 
 **travelTimeUnit** | **string**| Travel Time unit applicable values are minutes,hours,seconds,milliseconds  | [optional] 
 **travelDistance** | **string**| Travel Distance based on ‘travelMode’ within which schools are searched. | [optional] 
 **travelDistanceUnit** | **string**| Travel distanceUnit applicable values are feet,kilometers,miles,meters | [optional] 
 **travelMode** | **string**| Travel mode Required when travelDistance or travelTime is specified. Accepted values are walking,driving | [optional] 
 **maxCandidates** | **string**| Max result to search  | [optional] [default to 10]

### Return type

[**SchoolsNearByResponse**](SchoolsNearByResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

