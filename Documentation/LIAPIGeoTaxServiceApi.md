# pb.locationIntelligence.Api.LIAPIGeoTaxServiceApi

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBatchTaxByAddress**](LIAPIGeoTaxServiceApi.md#getbatchtaxbyaddress) | **POST** /geotax/v1/tax/{taxRateTypeId}/byaddress | Post Tax By Address
[**GetBatchTaxByLocation**](LIAPIGeoTaxServiceApi.md#getbatchtaxbylocation) | **POST** /geotax/v1/tax/{taxRateTypeId}/bylocation | Post Tax By Location
[**GetBatchTaxRateByAddress**](LIAPIGeoTaxServiceApi.md#getbatchtaxratebyaddress) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Post Taxrate By Address
[**GetBatchTaxRateByLocation**](LIAPIGeoTaxServiceApi.md#getbatchtaxratebylocation) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Post Taxrate By Location
[**GetSpecificTaxByAddress**](LIAPIGeoTaxServiceApi.md#getspecifictaxbyaddress) | **GET** /geotax/v1/tax/{taxRateTypeId}/byaddress | Get Tax By Address
[**GetSpecificTaxByLocation**](LIAPIGeoTaxServiceApi.md#getspecifictaxbylocation) | **GET** /geotax/v1/tax/{taxRateTypeId}/bylocation | Get Tax By Location
[**GetSpecificTaxRateByAddress**](LIAPIGeoTaxServiceApi.md#getspecifictaxratebyaddress) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Get Taxrate By Address
[**GetSpecificTaxRateByLocation**](LIAPIGeoTaxServiceApi.md#getspecifictaxratebylocation) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Get Taxrate By Location


<a name="getbatchtaxbyaddress"></a>
# **GetBatchTaxByAddress**
> TaxResponses GetBatchTaxByAddress (string taxRateTypeId, TaxAddressRequest body)

Post Tax By Address

This is a Batch offering for 'Tax By Address' service. It accepts a single address, purchase amount or a list of addresses, purchase amounts and retrieve applicable taxes.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetBatchTaxByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var body = new TaxAddressRequest(); // TaxAddressRequest | TaxAddressRequest Class Object having tax request.

            try
            {
                // Post Tax By Address
                TaxResponses result = apiInstance.GetBatchTaxByAddress(taxRateTypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetBatchTaxByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **body** | [**TaxAddressRequest**](TaxAddressRequest.md)| TaxAddressRequest Class Object having tax request. | 

### Return type

[**TaxResponses**](TaxResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatchtaxbylocation"></a>
# **GetBatchTaxByLocation**
> TaxResponses GetBatchTaxByLocation (string taxRateTypeId, TaxLocationRequest body)

Post Tax By Location

This is a Batch offering for 'Tax By Location' service. It accepts a single location coordinate, purchase amount or a list of location coordinates, purchase amounts and retrieve applicable tax.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetBatchTaxByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var body = new TaxLocationRequest(); // TaxLocationRequest | TaxAddressRequest Class Object having tax request.

            try
            {
                // Post Tax By Location
                TaxResponses result = apiInstance.GetBatchTaxByLocation(taxRateTypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetBatchTaxByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **body** | [**TaxLocationRequest**](TaxLocationRequest.md)| TaxAddressRequest Class Object having tax request. | 

### Return type

[**TaxResponses**](TaxResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatchtaxratebyaddress"></a>
# **GetBatchTaxRateByAddress**
> TaxResponses GetBatchTaxRateByAddress (string taxRateTypeId, TaxRateAddressRequest body)

Post Taxrate By Address

This is a Batch offering for 'Taxrate By Address' service. It accepts a single address or a list of addresses and retrieve applicable tax rates.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetBatchTaxRateByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var body = new TaxRateAddressRequest(); // TaxRateAddressRequest | TaxRateAddressRequest Class Object having tax rate request.

            try
            {
                // Post Taxrate By Address
                TaxResponses result = apiInstance.GetBatchTaxRateByAddress(taxRateTypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetBatchTaxRateByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **body** | [**TaxRateAddressRequest**](TaxRateAddressRequest.md)| TaxRateAddressRequest Class Object having tax rate request. | 

### Return type

[**TaxResponses**](TaxResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbatchtaxratebylocation"></a>
# **GetBatchTaxRateByLocation**
> TaxResponses GetBatchTaxRateByLocation (string taxRateTypeId, TaxRateLocationRequest body)

Post Taxrate By Location

This is a Batch offering for 'Taxrate By Location' service. It accepts a single location coordinate or a list of location coordinates and retrieve applicable tax rates.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetBatchTaxRateByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var body = new TaxRateLocationRequest(); // TaxRateLocationRequest | TaxRateLocationRequest Class Object having tax rate request.

            try
            {
                // Post Taxrate By Location
                TaxResponses result = apiInstance.GetBatchTaxRateByLocation(taxRateTypeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetBatchTaxRateByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **body** | [**TaxRateLocationRequest**](TaxRateLocationRequest.md)| TaxRateLocationRequest Class Object having tax rate request. | 

### Return type

[**TaxResponses**](TaxResponses.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspecifictaxbyaddress"></a>
# **GetSpecificTaxByAddress**
> TaxResponse GetSpecificTaxByAddress (string taxRateTypeId, string address, string purchaseAmount)

Get Tax By Address

This service calculates and returns taxes applicable at a specific address. Address, purchase amount and supported tax rate type are inputs to the service.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSpecificTaxByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var address = address_example;  // string | The address to be searched.
            var purchaseAmount = purchaseAmount_example;  // string | The amount on which tax to be calculated.

            try
            {
                // Get Tax By Address
                TaxResponse result = apiInstance.GetSpecificTaxByAddress(taxRateTypeId, address, purchaseAmount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetSpecificTaxByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **address** | **string**| The address to be searched. | 
 **purchaseAmount** | **string**| The amount on which tax to be calculated. | 

### Return type

[**TaxResponse**](TaxResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspecifictaxbylocation"></a>
# **GetSpecificTaxByLocation**
> TaxResponse GetSpecificTaxByLocation (string taxRateTypeId, string latitude, string longitude, string purchaseAmount)

Get Tax By Location

This service calculates and returns tax applicable at a specific location. Longitude, latitude, purchase amount and supported tax rate type are inputs to the service.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSpecificTaxByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var latitude = latitude_example;  // string | Latitude of the location.
            var longitude = longitude_example;  // string | Longitude of the location.
            var purchaseAmount = purchaseAmount_example;  // string | The amount on which tax to be calculated.

            try
            {
                // Get Tax By Location
                TaxResponse result = apiInstance.GetSpecificTaxByLocation(taxRateTypeId, latitude, longitude, purchaseAmount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetSpecificTaxByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **latitude** | **string**| Latitude of the location. | 
 **longitude** | **string**| Longitude of the location. | 
 **purchaseAmount** | **string**| The amount on which tax to be calculated. | 

### Return type

[**TaxResponse**](TaxResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspecifictaxratebyaddress"></a>
# **GetSpecificTaxRateByAddress**
> TaxResponse GetSpecificTaxRateByAddress (string taxRateTypeId, string address)

Get Taxrate By Address

Retrieves tax rates applicable to a specific address. This service accepts address and supported tax rate type as inputs to retrieve applicable tax rates.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSpecificTaxRateByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var address = address_example;  // string | The address to be searched.

            try
            {
                // Get Taxrate By Address
                TaxResponse result = apiInstance.GetSpecificTaxRateByAddress(taxRateTypeId, address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetSpecificTaxRateByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **address** | **string**| The address to be searched. | 

### Return type

[**TaxResponse**](TaxResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspecifictaxratebylocation"></a>
# **GetSpecificTaxRateByLocation**
> TaxResponse GetSpecificTaxRateByLocation (string taxRateTypeId, string latitude, string longitude)

Get Taxrate By Location

Retrieves tax rates applicable to a specific location. This service accepts longitude, latitude and supported tax rate type as inputs to retrieve applicable tax rates.

### Example
```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using pb.locationIntelligence.Model;

namespace Example
{
    public class GetSpecificTaxRateByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LIAPIGeoTaxServiceApi();
            var taxRateTypeId = taxRateTypeId_example;  // string | The tax rate id.
            var latitude = latitude_example;  // string | Latitude of the location.
            var longitude = longitude_example;  // string | Longitude of the location.

            try
            {
                // Get Taxrate By Location
                TaxResponse result = apiInstance.GetSpecificTaxRateByLocation(taxRateTypeId, latitude, longitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LIAPIGeoTaxServiceApi.GetSpecificTaxRateByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taxRateTypeId** | **string**| The tax rate id. | 
 **latitude** | **string**| Latitude of the location. | 
 **longitude** | **string**| Longitude of the location. | 

### Return type

[**TaxResponse**](TaxResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

