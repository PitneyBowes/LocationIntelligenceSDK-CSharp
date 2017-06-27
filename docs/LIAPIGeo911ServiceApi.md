# pb.locationIntelligence.Api.LIAPIGeo911ServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAHJPlusPSAPByAddress**](LIAPIGeo911ServiceApi.md#getahjpluspsapbyaddress) | **GET** /geo911/v1/ahj-psap/byaddress | AHJ &amp; PSAP By Address.
[**GetAHJPlusPSAPByLocation**](LIAPIGeo911ServiceApi.md#getahjpluspsapbylocation) | **GET** /geo911/v1/ahj-psap/bylocation | AHJ &amp; PSAP By Location
[**GetPSAPByAddress**](LIAPIGeo911ServiceApi.md#getpsapbyaddress) | **GET** /geo911/v1/psap/byaddress | PSAP By Address.
[**GetPSAPByLocation**](LIAPIGeo911ServiceApi.md#getpsapbylocation) | **GET** /geo911/v1/psap/bylocation | PSAP By Location.


<a name="getahjpluspsapbyaddress"></a>
# **GetAHJPlusPSAPByAddress**
> AHJPlusPSAPResponse GetAHJPlusPSAPByAddress (string address)

AHJ & PSAP By Address.

Accepts addresses as input and Returns contact details for Authorities Having Jurisdiction (AHJ) on-behalf-of local Public Safety Answering Points (PSAP). Geo911 accepts an address and returns PSAP contact data plus contact data for an AHJ to communicate directly with a PSAP. Details include agency name, phone number, city name, coverage, contact person's details, site details and mailing addresses for EMS, Fire, and Police PSAP contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetAHJPlusPSAPByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeo911ServiceApi();
            var address = address_example;  // string | The address to be searched.

            try
            {
                // AHJ & PSAP By Address.
                AHJPlusPSAPResponse result = apiInstance.GetAHJPlusPSAPByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeo911ServiceApi.GetAHJPlusPSAPByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 

### Return type

[**AHJPlusPSAPResponse**](AHJPlusPSAPResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getahjpluspsapbylocation"></a>
# **GetAHJPlusPSAPByLocation**
> AHJPlusPSAPResponse GetAHJPlusPSAPByLocation (string longitude, string latitude)

AHJ & PSAP By Location

Accepts latitude & longitude as input and Returns contact details for Authorities Having Jurisdiction (AHJ) on-behalf-of local Public Safety Answering Points (PSAP). Geo911 accepts a location coordinate and returns PSAP contact data plus contact data for an AHJ to communicate directly with a PSAP. Details include agency name, phone number, city name, coverage, contact person's details, site details and mailing addresses for EMS, Fire, and Police PSAP contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetAHJPlusPSAPByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeo911ServiceApi();
            var longitude = longitude_example;  // string | Latitude of the location.
            var latitude = latitude_example;  // string | Longitude of the location.

            try
            {
                // AHJ & PSAP By Location
                AHJPlusPSAPResponse result = apiInstance.GetAHJPlusPSAPByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeo911ServiceApi.GetAHJPlusPSAPByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Latitude of the location. | 
 **latitude** | **string**| Longitude of the location. | 

### Return type

[**AHJPlusPSAPResponse**](AHJPlusPSAPResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpsapbyaddress"></a>
# **GetPSAPByAddress**
> PSAPResponse GetPSAPByAddress (string address)

PSAP By Address.

Accepts addresses as input and returns contact details for local Public Safety Answering Points (PSAP). Geo911 accepts an address as input and returns the relevant PSAP address and contact details including agency name, phone number, county name, coverage, contact person's details, site details and mailing address.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPSAPByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeo911ServiceApi();
            var address = address_example;  // string | The address to be searched.

            try
            {
                // PSAP By Address.
                PSAPResponse result = apiInstance.GetPSAPByAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeo911ServiceApi.GetPSAPByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| The address to be searched. | 

### Return type

[**PSAPResponse**](PSAPResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpsapbylocation"></a>
# **GetPSAPByLocation**
> PSAPResponse GetPSAPByLocation (string longitude, string latitude)

PSAP By Location.

Accepts latitude & longitude as input and Returns contact details for local Public Safety Answering Points (PSAP). Geo911 accepts a location coordinate and returns the relevant PSAP address and contact details including dispatch name, phone number, county name, coverage, contact person's details, site details and mailing address.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetPSAPByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new LIAPIGeo911ServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.

            try
            {
                // PSAP By Location.
                PSAPResponse result = apiInstance.GetPSAPByLocation(longitude, latitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeo911ServiceApi.GetPSAPByLocation: " + e.Message );
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

### Return type

[**PSAPResponse**](PSAPResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

