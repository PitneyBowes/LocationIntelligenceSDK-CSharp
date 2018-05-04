# pb.locationIntelligence.Api.LIAPIGeocodeServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Geocode**](LIAPIGeocodeServiceApi.md#geocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
[**GeocodeBatch**](LIAPIGeocodeServiceApi.md#geocodebatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
[**GetCapabilities**](LIAPIGeocodeServiceApi.md#getcapabilities) | **GET** /geocode-service/v1/transient/{datapackBundle}/capabilities | Gets Capabilities
[**GetDictionaries**](LIAPIGeocodeServiceApi.md#getdictionaries) | **GET** /geocode-service/v1/transient/{datapackBundle}/dictionaries | Gets installed Dictionaries
[**GetPBKey**](LIAPIGeocodeServiceApi.md#getpbkey) | **GET** /geocode-service/v1/key/byaddress | Gets PBKey
[**GetPBKeys**](LIAPIGeocodeServiceApi.md#getpbkeys) | **POST** /geocode-service/v1/key/byaddress | Gets PBKeys
[**ReverseGeocodBatch**](LIAPIGeocodeServiceApi.md#reversegeocodbatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode
[**ReverseGeocode**](LIAPIGeocodeServiceApi.md#reversegeocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode


<a name="geocode"></a>
# **Geocode**
> GeocodeServiceResponse Geocode (string datapackBundle, string country = null, string placeName = null, string mainAddress = null, string lastLine = null, string areaName1 = null, string areaName2 = null, string areaName3 = null, string areaName4 = null, int? postalCode = null, string matchMode = null, bool? fallbackGeo = null, bool? fallbackPostal = null, int? maxCands = null, int? streetOffset = null, string streetOffsetUnits = null, int? cornerOffset = null, string cornerOffsetUnits = null)

Gets Geocode

Gets Geocode

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GeocodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var datapackBundle = datapackBundle_example;  // string | value of datapackBundle
            var country = country_example;  // string | Country name or ISO code. (optional)  (default to USA)
            var placeName = placeName_example;  // string | Building name, place name, Point of Interest (POI), company or firm name associated with the input address. (optional) 
            var mainAddress = mainAddress_example;  // string | Single line input, treated as collection of field elements. (optional)  (default to 4750 Walnut St., Boulder CO, 80301)
            var lastLine = lastLine_example;  // string | The last line of the address. (optional) 
            var areaName1 = areaName1_example;  // string | Specifies the largest geographic area, typically a state or province. (optional) 
            var areaName2 = areaName2_example;  // string | Specifies the secondary geographic area, typically a county or district. (optional) 
            var areaName3 = areaName3_example;  // string | Specifies a city or town name. (optional) 
            var areaName4 = areaName4_example;  // string | Specifies a city subdivision or locality. (optional) 
            var postalCode = 56;  // int? | The postal code in the appropriate format for the country. (optional) 
            var matchMode = matchMode_example;  // string | Match modes determine the leniency used to make a match between the input address and the reference data. (optional)  (default to Standard)
            var fallbackGeo = true;  // bool? | Specifies whether to attempt to determine a geographic region centroid when an address-level geocode cannot be determined. (optional)  (default to true)
            var fallbackPostal = true;  // bool? | Specifies whether to attempt to determine a post code centroid when an address-level geocode cannot be determined. (optional)  (default to true)
            var maxCands = 56;  // int? | The maximum number of candidates to return. Must be an integer value. (optional)  (default to 1)
            var streetOffset = 56;  // int? | Indicates the offset distance from the street segments to use in street-level geocoding. (optional)  (default to 7)
            var streetOffsetUnits = streetOffsetUnits_example;  // string | Specifies the unit of measurement for the street offset. (optional)  (default to METERS)
            var cornerOffset = 56;  // int? | Specifies the distance to offset the street end points in street-level matching. (optional)  (default to 7)
            var cornerOffsetUnits = cornerOffsetUnits_example;  // string | Specifies the unit of measurement for the corner offset. (optional)  (default to METERS)

            try
            {
                // Gets Geocode
                GeocodeServiceResponse result = apiInstance.Geocode(datapackBundle, country, placeName, mainAddress, lastLine, areaName1, areaName2, areaName3, areaName4, postalCode, matchMode, fallbackGeo, fallbackPostal, maxCands, streetOffset, streetOffsetUnits, cornerOffset, cornerOffsetUnits);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.Geocode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datapackBundle** | **string**| value of datapackBundle | 
 **country** | **string**| Country name or ISO code. | [optional] [default to USA]
 **placeName** | **string**| Building name, place name, Point of Interest (POI), company or firm name associated with the input address. | [optional] 
 **mainAddress** | **string**| Single line input, treated as collection of field elements. | [optional] [default to 4750 Walnut St., Boulder CO, 80301]
 **lastLine** | **string**| The last line of the address. | [optional] 
 **areaName1** | **string**| Specifies the largest geographic area, typically a state or province. | [optional] 
 **areaName2** | **string**| Specifies the secondary geographic area, typically a county or district. | [optional] 
 **areaName3** | **string**| Specifies a city or town name. | [optional] 
 **areaName4** | **string**| Specifies a city subdivision or locality. | [optional] 
 **postalCode** | **int?**| The postal code in the appropriate format for the country. | [optional] 
 **matchMode** | **string**| Match modes determine the leniency used to make a match between the input address and the reference data. | [optional] [default to Standard]
 **fallbackGeo** | **bool?**| Specifies whether to attempt to determine a geographic region centroid when an address-level geocode cannot be determined. | [optional] [default to true]
 **fallbackPostal** | **bool?**| Specifies whether to attempt to determine a post code centroid when an address-level geocode cannot be determined. | [optional] [default to true]
 **maxCands** | **int?**| The maximum number of candidates to return. Must be an integer value. | [optional] [default to 1]
 **streetOffset** | **int?**| Indicates the offset distance from the street segments to use in street-level geocoding. | [optional] [default to 7]
 **streetOffsetUnits** | **string**| Specifies the unit of measurement for the street offset. | [optional] [default to METERS]
 **cornerOffset** | **int?**| Specifies the distance to offset the street end points in street-level matching. | [optional] [default to 7]
 **cornerOffsetUnits** | **string**| Specifies the unit of measurement for the corner offset. | [optional] [default to METERS]

### Return type

[**GeocodeServiceResponse**](GeocodeServiceResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geocodebatch"></a>
# **GeocodeBatch**
> GeocodeServiceResponseList GeocodeBatch (GeocodeRequest body, string datapackBundle)

Gets Geocode

Gets Geocode

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GeocodeBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var body = new GeocodeRequest(); // GeocodeRequest | Geocode Request Object
            var datapackBundle = datapackBundle_example;  // string | value of datapackBundle

            try
            {
                // Gets Geocode
                GeocodeServiceResponseList result = apiInstance.GeocodeBatch(body, datapackBundle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.GeocodeBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeocodeRequest**](GeocodeRequest.md)| Geocode Request Object | 
 **datapackBundle** | **string**| value of datapackBundle | 

### Return type

[**GeocodeServiceResponseList**](GeocodeServiceResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcapabilities"></a>
# **GetCapabilities**
> GeocodeCapabilitiesResponse GetCapabilities (string datapackBundle, string operation = null, string country = null)

Gets Capabilities

Gets Capabilities

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetCapabilitiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var datapackBundle = datapackBundle_example;  // string | value of datapackBundle
            var operation = operation_example;  // string | Geocode or ReverseGeocode Operation. (optional)  (default to geocode)
            var country = country_example;  // string | Country name or ISO code. (optional)  (default to USA)

            try
            {
                // Gets Capabilities
                GeocodeCapabilitiesResponse result = apiInstance.GetCapabilities(datapackBundle, operation, country);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.GetCapabilities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datapackBundle** | **string**| value of datapackBundle | 
 **operation** | **string**| Geocode or ReverseGeocode Operation. | [optional] [default to geocode]
 **country** | **string**| Country name or ISO code. | [optional] [default to USA]

### Return type

[**GeocodeCapabilitiesResponse**](GeocodeCapabilitiesResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdictionaries"></a>
# **GetDictionaries**
> ConfiguredDictionaryResponse GetDictionaries (string datapackBundle, string country = null)

Gets installed Dictionaries

Gets installed Dictionaries

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetDictionariesExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var datapackBundle = datapackBundle_example;  // string | value of datapackBundle
            var country = country_example;  // string | Three Letter ISO Country code (optional)  (default to USA)

            try
            {
                // Gets installed Dictionaries
                ConfiguredDictionaryResponse result = apiInstance.GetDictionaries(datapackBundle, country);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.GetDictionaries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datapackBundle** | **string**| value of datapackBundle | 
 **country** | **string**| Three Letter ISO Country code | [optional] [default to USA]

### Return type

[**ConfiguredDictionaryResponse**](ConfiguredDictionaryResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbkey"></a>
# **GetPBKey**
> PBKeyResponse GetPBKey (string address)

Gets PBKey

Gets PBKey for an input free form address text

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPBKeyExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var address = address_example;  // string | free form address text

            try
            {
                // Gets PBKey
                PBKeyResponse result = apiInstance.GetPBKey(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.GetPBKey: " + e.Message );
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

[**PBKeyResponse**](PBKeyResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpbkeys"></a>
# **GetPBKeys**
> PBKeyResponseList GetPBKeys (PBKeyAddressRequest body)

Gets PBKeys

Gets PBKeys for multiple input addresses

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPBKeysExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var body = new PBKeyAddressRequest(); // PBKeyAddressRequest | 

            try
            {
                // Gets PBKeys
                PBKeyResponseList result = apiInstance.GetPBKeys(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.GetPBKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PBKeyAddressRequest**](PBKeyAddressRequest.md)|  | 

### Return type

[**PBKeyResponseList**](PBKeyResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reversegeocodbatch"></a>
# **ReverseGeocodBatch**
> GeocodeServiceResponseList ReverseGeocodBatch (string datapackBundle, ReverseGeocodeRequest body = null)

reverse Geocode

reverse Geocode

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class ReverseGeocodBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var datapackBundle = datapackBundle_example;  // string | value of datapackBundle
            var body = new ReverseGeocodeRequest(); // ReverseGeocodeRequest | Reverse Geocode Request object (optional) 

            try
            {
                // reverse Geocode
                GeocodeServiceResponseList result = apiInstance.ReverseGeocodBatch(datapackBundle, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.ReverseGeocodBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datapackBundle** | **string**| value of datapackBundle | 
 **body** | [**ReverseGeocodeRequest**](ReverseGeocodeRequest.md)| Reverse Geocode Request object | [optional] 

### Return type

[**GeocodeServiceResponseList**](GeocodeServiceResponseList.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reversegeocode"></a>
# **ReverseGeocode**
> GeocodeServiceResponse ReverseGeocode (string datapackBundle, decimal? x, decimal? y, string country = null, string coordSysName = null, int? distance = null, string distanceUnits = null)

reverse Geocode

reverse Geocode

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class ReverseGeocodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeocodeServiceApi();
            var datapackBundle = datapackBundle_example;  // string | value of datapackBundle
            var x = 3.4;  // decimal? | Longitude of the location. (default to -105.240976)
            var y = 3.4;  // decimal? | Latitude of the location. (default to 40.018301)
            var country = country_example;  // string | Country name or ISO code. (optional) 
            var coordSysName = coordSysName_example;  // string | Coordinate system to convert geometry in format codespace:code. (optional)  (default to EPSG:4326)
            var distance = 56;  // int? | Radius in which search is performed. (optional)  (default to 150)
            var distanceUnits = distanceUnits_example;  // string | Unit of measurement for the search distance. (optional)  (default to METERS)

            try
            {
                // reverse Geocode
                GeocodeServiceResponse result = apiInstance.ReverseGeocode(datapackBundle, x, y, country, coordSysName, distance, distanceUnits);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeocodeServiceApi.ReverseGeocode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datapackBundle** | **string**| value of datapackBundle | 
 **x** | **decimal?**| Longitude of the location. | [default to -105.240976]
 **y** | **decimal?**| Latitude of the location. | [default to 40.018301]
 **country** | **string**| Country name or ISO code. | [optional] 
 **coordSysName** | **string**| Coordinate system to convert geometry in format codespace:code. | [optional] [default to EPSG:4326]
 **distance** | **int?**| Radius in which search is performed. | [optional] [default to 150]
 **distanceUnits** | **string**| Unit of measurement for the search distance. | [optional] [default to METERS]

### Return type

[**GeocodeServiceResponse**](GeocodeServiceResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

