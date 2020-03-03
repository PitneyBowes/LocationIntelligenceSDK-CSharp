![Pitney Bowes](/PitneyBowes_Logo.jpg)

# Pitney Bowes Location Intelligence API

### Description
[Location Intelligence APIs ](http://developer.pitneybowes.com/en/location-intelligence.html) help you to Incorporate Pitney Bowes extensive geodata into everyday applications, business processes, and workflows. Use our SDKs to get started quickly and easily integrate API calls in your applications.

### Location Intelligence APIs:

* [GeoEnrich](https://locate.pitneybowes.com/geoenrich ) : Returns addresses, place names, points-of-interest and timezones with the input of a location coordinate. Useful for enhancing & enriching your geo-tagged data.

* [GeoLife](https://locate.pitneybowes.com/geolife) : Returns household demographics and lifestyle characteristics with the input of an address or location coordinate. Useful for data analysts and commercial and corporate developers building mobile apps and services.

* [GeoSearch](https://locate.pitneybowes.com/geosearch): Returns an autocompleted list of addresses and places based on the input of a partial address. Useful for commercial developers and content providers, or anyone wanting to offer their own search.

* [GeoComm](https://locate.pitneybowes.com/geocomm): Identifies Local Exchange Carrier presence with a Rate Center area. The GeoComm API retrieves Incumbent Local Exchange Carrier (ILEC) doing-business-as names with the input of an address. Useful for local telecommunications competitive intelligence, partnerships, and provisioning subscribers.

* [Geo911](https://locate.pitneybowes.com/geo911): Integrates Public Safety Answering Point (PSAP) administrative call routing information plus Authority Having Jurisdiction (AHJ) phone numbers into your 911 products and services. The Geo911 API retrieves 10-digit phone numbers and local contact info with the input of a location coordinate. Useful for emergency services administrators, call handlers, and dispatchers.

* [GeoTax](https://locate.pitneybowes.com/geotax): Returns local tax rates with the input of a location coordinate or an address. Critical for any billing, commerce, payment, or payroll application or service.

* [GeoCode](https://locate.pitneybowes.com/geocode): Converts addresses to location coordinates and vice versa. The GeoCode API returns latitude & longitude coordinates with the input of an address and vice versa. Useful for enhancing & enriching your customer addresses.

* [GeoMap](https://locate.pitneybowes.com/geomap): Adds data and more atop Maps. Choose from three map styles - Iron, Bronze, and Steel.

* [GeoZone](https://locate.pitneybowes.com/geozone): Returns drive Distance and Drive Time Zones with the input of Location Coordinates or Addresses. Useful for anyone wanting to create smarter geofence zones for Local Engagement and Analysis.

* [GeoRoute](https://locate.pitneybowes.com/georoute): Returns Point-to-Point and Multi-Point Travel Directions by Various Travel Modes. Critical for any Simple or Complex Routing Requirement.

* [GeoRisk](https://locate.pitneybowes.com/georisk): Returns critical risk intelligence with the input of Location Coordinates or Addresses. Critical for any Risk Mitigation Analyses involving threats to lives or property.

* [GeoProperty](https://locate.pitneybowes.com/geoproperty)::  Property Details. Capture property details for analysis and planning. The GeoProperty API returns extensive property attributes with the input of address or PB key. Critical for any property investment, insurance or risk analysis and mitigation.

* [GeoTime](https://locate.pitneybowes.com/geotime): Local time. The GeoTime API returns timezones and UTC offsets with the input of a location coordinate or address. Useful for do-not-call, logistics, and customer engagement applications, business processes and workflows.

* [GeoLocation](http://locate.pitneybowes.com/geolocation): Device Location. The GeoLocation API returns location coordinates based on the input of an IP Address, WiFi Access point MAC address, Fixed line phone number and/or Wireless phone number. Useful for a variety of applications, business processes and workflows in eCommerce, Fraud Detection, Physical-Digital interactions, Field Service and more.
* [GeoStreets](https://locate.pitneybowes.com/geostreets): Enrich your applications, business processes, and workflows with global street information including nearest intersections and more. GeoStreets accepts an address or location and returns nearest intersection information. Useful for enriching your data and/or analytics processes with footfall potential.


The following platforms are supported by Location Intelligence SDKs:
*	[Android](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html#Android%20SDK/android_intro.html)
*	[JavaScript](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html#Java%20Script%20SDK/js_intro.html) 
*	[iOS](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html#iOS%20SDK/ios_intro.html)
*	[Java](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html#Java%20SDK/java_intro.html)
*	[C#](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html#C_sdk/java_intro.html)  

[Click here](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html) for detailed Documentation on Location Intelligence APIs 
# pb.locationIntelligence - the C# library for the Location Intelligence APIs

Incorporate our extensive geodata into everyday applications, business processes and workflows.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 8.5.0
- SDK version: 8.5.0
- Build date: 2020-03-03T15:29:38.002+05:30
- Build package: class io.swagger.codegen.languages.CSharpClientCodegen

## Frameworks supported
- .NET 4.5 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Client;
using Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.pitneybowes.com/location-intelligence*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*LIAPIGeo911ServiceApi* | [**GetAHJPlusPSAPByAddress**](docs/LIAPIGeo911ServiceApi.md#getahjpluspsapbyaddress) | **GET** /geo911/v1/ahj-psap/byaddress | AHJ & PSAP By Address.
*LIAPIGeo911ServiceApi* | [**GetAHJPlusPSAPByLocation**](docs/LIAPIGeo911ServiceApi.md#getahjpluspsapbylocation) | **GET** /geo911/v1/ahj-psap/bylocation | AHJ & PSAP By Location
*LIAPIGeo911ServiceApi* | [**GetPSAPByAddress**](docs/LIAPIGeo911ServiceApi.md#getpsapbyaddress) | **GET** /geo911/v1/psap/byaddress | PSAP By Address.
*LIAPIGeo911ServiceApi* | [**GetPSAPByLocation**](docs/LIAPIGeo911ServiceApi.md#getpsapbylocation) | **GET** /geo911/v1/psap/bylocation | PSAP By Location.
*LIAPIGeoCommServiceApi* | [**GetRateCenterByAddress**](docs/LIAPIGeoCommServiceApi.md#getratecenterbyaddress) | **GET** /geocomm/v1/ratecenter/byaddress | Rate Center By Address.
*LIAPIGeoCommServiceApi* | [**GetRateCenterByLocation**](docs/LIAPIGeoCommServiceApi.md#getratecenterbylocation) | **GET** /geocomm/v1/ratecenter/bylocation | Rate Center By Location.
*LIAPIGeoEnrichServiceApi* | [**GetCategoryCodeMetadata**](docs/LIAPIGeoEnrichServiceApi.md#getcategorycodemetadata) | **GET** /geoenrich/v1/metadata/category | Returns Category Codes with their sub-categories (if exist), descriptions and SIC Codes mapping
*LIAPIGeoEnrichServiceApi* | [**GetPOIById**](docs/LIAPIGeoEnrichServiceApi.md#getpoibyid) | **GET** /geoenrich/v1/poi/{id} | Point of Interest By Id.
*LIAPIGeoEnrichServiceApi* | [**GetPOIsByAddress**](docs/LIAPIGeoEnrichServiceApi.md#getpoisbyaddress) | **GET** /geoenrich/v1/poi/byaddress | Points of Interest By Address.
*LIAPIGeoEnrichServiceApi* | [**GetPOIsByArea**](docs/LIAPIGeoEnrichServiceApi.md#getpoisbyarea) | **GET** /geoenrich/v1/poi/byarea | Points of Interest By Area.
*LIAPIGeoEnrichServiceApi* | [**GetPOIsByGeometry**](docs/LIAPIGeoEnrichServiceApi.md#getpoisbygeometry) | **POST** /geoenrich/v1/poi/byboundary | Point of Interests By Geometry.
*LIAPIGeoEnrichServiceApi* | [**GetPOIsByLocation**](docs/LIAPIGeoEnrichServiceApi.md#getpoisbylocation) | **GET** /geoenrich/v1/poi/bylocation | Points of Interest By Location.
*LIAPIGeoEnrichServiceApi* | [**GetPOIsCount**](docs/LIAPIGeoEnrichServiceApi.md#getpoiscount) | **POST** /geoenrich/v1/poicount | Point of Interests count By Geometry.
*LIAPIGeoEnrichServiceApi* | [**GetPlaceByLocation**](docs/LIAPIGeoEnrichServiceApi.md#getplacebylocation) | **GET** /geoenrich/v1/place/bylocation | Place By Location.
*LIAPIGeoEnrichServiceApi* | [**GetSICMetadata**](docs/LIAPIGeoEnrichServiceApi.md#getsicmetadata) | **GET** /geoenrich/v1/metadata/sic | Returns SIC Codes with their Industry Titles and Category Codes mapping
*LIAPIGeoEnrichServiceApi* | [**PoisAutocomplete**](docs/LIAPIGeoEnrichServiceApi.md#poisautocomplete) | **GET** /geoenrich/v1/poi/autocomplete | Points of Interest Autocomplete.
*LIAPIGeoIdentityServiceApi* | [**GetIdentityByAddress**](docs/LIAPIGeoIdentityServiceApi.md#getidentitybyaddress) | **GET** /geoidentity/v1/identity/byaddress | Gets GeoIdentityResponse
*LIAPIGeoIdentityServiceApi* | [**GetIdentityByEmail**](docs/LIAPIGeoIdentityServiceApi.md#getidentitybyemail) | **GET** /geoidentity/v1/identity/byemail | Gets Identity
*LIAPIGeoIdentityServiceApi* | [**GetIdentityByPBKey**](docs/LIAPIGeoIdentityServiceApi.md#getidentitybypbkey) | **GET** /geoidentity/v1/identity/bypbkey | Gets GeoIdentityResponse
*LIAPIGeoIdentityServiceApi* | [**GetIdentityByTwitter**](docs/LIAPIGeoIdentityServiceApi.md#getidentitybytwitter) | **GET** /geoidentity/v1/identity/bytwitter | Gets Identity
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByAddressV2**](docs/LIAPIGeoLifeServiceApi.md#getdemographicsbyaddressv2) | **GET** /geolife/v2/demographics/byaddress | Demographics By Address.
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByLocationV2**](docs/LIAPIGeoLifeServiceApi.md#getdemographicsbylocationv2) | **GET** /geolife/v2/demographics/bylocation | Demographics By Location.
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByPBKey**](docs/LIAPIGeoLifeServiceApi.md#getdemographicsbypbkey) | **GET** /geolife/v2/demographics/bypbkey | Demographics By PBKey.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByAddress**](docs/LIAPIGeoLifeServiceApi.md#getsegmentationbyaddress) | **GET** /geolife/v1/segmentation/byaddress | Segmentation By Address.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByLocation**](docs/LIAPIGeoLifeServiceApi.md#getsegmentationbylocation) | **GET** /geolife/v1/segmentation/bylocation | Segmentation By Location.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByPBKey**](docs/LIAPIGeoLifeServiceApi.md#getsegmentationbypbkey) | **GET** /geolife/v1/segmentation/bypbkey | Segmentation By PB Key.
*LIAPIGeoLocationServiceApi* | [**GetDeviceStatus**](docs/LIAPIGeoLocationServiceApi.md#getdevicestatus) | **GET** /geolocation/v1/devicestatus | Location By Device Status.
*LIAPIGeoLocationServiceApi* | [**GetLocationByIPAddress**](docs/LIAPIGeoLocationServiceApi.md#getlocationbyipaddress) | **GET** /geolocation/v1/location/byipaddress | Location By IP Address.
*LIAPIGeoLocationServiceApi* | [**GetLocationByWiFiAccessPoint**](docs/LIAPIGeoLocationServiceApi.md#getlocationbywifiaccesspoint) | **GET** /geolocation/v1/location/byaccesspoint | Location by WiFi Access Point.
*LIAPIGeoPostServiceApi* | [**GetCarrierRoutesByAddress**](docs/LIAPIGeoPostServiceApi.md#getcarrierroutesbyaddress) | **GET** /geopost/v1/carrierroute/byaddress | Carrier Route By Address.
*LIAPIGeoPostServiceApi* | [**GetCarrierRoutesByAddressBatch**](docs/LIAPIGeoPostServiceApi.md#getcarrierroutesbyaddressbatch) | **POST** /geopost/v1/carrierroute/byaddress | Gets GeoPost Carrier Routes for Multiple Addresses
*LIAPIGeoPropertyServiceApi* | [**GetGeoPropertyByAddress**](docs/LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddress) | **GET** /geoproperty/v1/all/attributes/byaddress | Gets GeoPropertyResponse
*LIAPIGeoPropertyServiceApi* | [**GetGeoPropertyByAddressBatch**](docs/LIAPIGeoPropertyServiceApi.md#getgeopropertybyaddressbatch) | **POST** /geoproperty/v1/all/attributes/byaddress | Gets GeoPropertyResponses
*LIAPIGeoPropertyServiceApi* | [**GetGeoPropertyByPBKey**](docs/LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkey) | **GET** /geoproperty/v1/all/attributes/bypbkey | Gets GeoPropertyResponse
*LIAPIGeoPropertyServiceApi* | [**GetGeoPropertyByPBKeyBatch**](docs/LIAPIGeoPropertyServiceApi.md#getgeopropertybypbkeybatch) | **POST** /geoproperty/v1/all/attributes/bypbkey | Gets GeoPropertyResponses
*LIAPIGeoPropertyServiceApi* | [**GetParcelBoundaryByAddress**](docs/LIAPIGeoPropertyServiceApi.md#getparcelboundarybyaddress) | **GET** /geoproperty/v1/parcelboundary/byaddress | Gets ParcelBoundary
*LIAPIGeoPropertyServiceApi* | [**GetParcelBoundaryByLocation**](docs/LIAPIGeoPropertyServiceApi.md#getparcelboundarybylocation) | **GET** /geoproperty/v1/parcelboundary/bylocation | Gets ParcelBoundary
*LIAPIGeoPropertyServiceApi* | [**GetParcelBoundaryByPBKey**](docs/LIAPIGeoPropertyServiceApi.md#getparcelboundarybypbkey) | **GET** /geoproperty/v1/parcelboundary/bypbkey | Gets ParcelBoundary
*LIAPIGeoPropertyServiceApi* | [**GetSchoolsByAddress**](docs/LIAPIGeoPropertyServiceApi.md#getschoolsbyaddress) | **GET** /geoproperty/v1/school/byaddress | Search Nearby Schools by Address
*LIAPIGeoPropertyServiceApi* | [**GetSchoolsNearByUsingPBKey**](docs/LIAPIGeoPropertyServiceApi.md#getschoolsnearbyusingpbkey) | **GET** /geoproperty/v1/school/bypbkey | Search Nearby Schools by PBKey
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getcrimeriskbyaddress) | **GET** /georisk/v1/crime/byaddress | Gets CrimeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByAddressBatch**](docs/LIAPIGeoRiskServiceApi.md#getcrimeriskbyaddressbatch) | **POST** /georisk/v1/crime/byaddress | Batch method for getting crime risk by address
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getcrimeriskbylocation) | **GET** /georisk/v1/crime/bylocation | Gets CrimeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByLocationBatch**](docs/LIAPIGeoRiskServiceApi.md#getcrimeriskbylocationbatch) | **POST** /georisk/v1/crime/bylocation | Batch method for getting crime risk by location
*LIAPIGeoRiskServiceApi* | [**GetDistanceToFloodHazardByAddress**](docs/LIAPIGeoRiskServiceApi.md#getdistancetofloodhazardbyaddress) | **GET** /georisk/v1/shoreline/distancetofloodhazard/byaddress | Gets WaterBodyResponse
*LIAPIGeoRiskServiceApi* | [**GetDistanceToFloodHazardByAddressBatch**](docs/LIAPIGeoRiskServiceApi.md#getdistancetofloodhazardbyaddressbatch) | **POST** /georisk/v1/shoreline/distancetofloodhazard/byaddress | Batch method for getting Water Bodies by address
*LIAPIGeoRiskServiceApi* | [**GetDistanceToFloodHazardByLocation**](docs/LIAPIGeoRiskServiceApi.md#getdistancetofloodhazardbylocation) | **GET** /georisk/v1/shoreline/distancetofloodhazard/bylocation | Gets WaterBodyResponse
*LIAPIGeoRiskServiceApi* | [**GetDistanceToFloodHazardByLocationBatch**](docs/LIAPIGeoRiskServiceApi.md#getdistancetofloodhazardbylocationbatch) | **POST** /georisk/v1/shoreline/distancetofloodhazard/bylocation | Batch method for getting Water Bodies by location
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeHistory**](docs/LIAPIGeoRiskServiceApi.md#getearthquakehistory) | **GET** /georisk/v1/earthquakehistory | Gets EarthquakeHistory
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getearthquakeriskbyaddress) | **GET** /georisk/v1/earthquake/byaddress | Gets EarthquakeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByAddressBatch**](docs/LIAPIGeoRiskServiceApi.md#getearthquakeriskbyaddressbatch) | **POST** /georisk/v1/earthquake/byaddress | Batch method for getting earthquake risk by address
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getearthquakeriskbylocation) | **GET** /georisk/v1/earthquake/bylocation | Gets EarthquakeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByLocationBatch**](docs/LIAPIGeoRiskServiceApi.md#getearthquakeriskbylocationbatch) | **POST** /georisk/v1/earthquake/bylocation | Batch method for getting earthquake risk by location
*LIAPIGeoRiskServiceApi* | [**GetFireHistory**](docs/LIAPIGeoRiskServiceApi.md#getfirehistory) | **GET** /georisk/v1/firehistory | Gets FireHistory
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getfireriskbyaddress) | **GET** /georisk/v1/fire/byaddress | Gets FireRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByAddressBatch**](docs/LIAPIGeoRiskServiceApi.md#getfireriskbyaddressbatch) | **POST** /georisk/v1/fire/byaddress | Batch method for getting fire risk by address
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getfireriskbylocation) | **GET** /georisk/v1/fire/bylocation | Gets FireRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByLocationBatch**](docs/LIAPIGeoRiskServiceApi.md#getfireriskbylocationbatch) | **POST** /georisk/v1/fire/bylocation | Batch method for getting fire risk by location
*LIAPIGeoRiskServiceApi* | [**GetFireStationByAddress**](docs/LIAPIGeoRiskServiceApi.md#getfirestationbyaddress) | **GET** /georisk/v1/firestation/byaddress | Gets FireStationResponse
*LIAPIGeoRiskServiceApi* | [**GetFireStationByLocation**](docs/LIAPIGeoRiskServiceApi.md#getfirestationbylocation) | **GET** /georisk/v1/firestation/bylocation | Gets FireStationResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getfloodriskbyaddress) | **GET** /georisk/v1/flood/byaddress | Gets FloodRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByAddressBatch**](docs/LIAPIGeoRiskServiceApi.md#getfloodriskbyaddressbatch) | **POST** /georisk/v1/flood/byaddress | Batch method for getting flood risk by address
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getfloodriskbylocation) | **GET** /georisk/v1/flood/bylocation | Gets FloodRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByLocationBatch**](docs/LIAPIGeoRiskServiceApi.md#getfloodriskbylocationbatch) | **POST** /georisk/v1/flood/bylocation | Batch method for getting flood risk by location
*LIAPIGeoRouteServiceApi* | [**GetRouteByAddress**](docs/LIAPIGeoRouteServiceApi.md#getroutebyaddress) | **GET** /georoute/v1/route/byaddress | Gets Route by Address
*LIAPIGeoRouteServiceApi* | [**GetRouteByLocation**](docs/LIAPIGeoRouteServiceApi.md#getroutebylocation) | **GET** /georoute/v1/route/bylocation | Gets Route by Location
*LIAPIGeoRouteServiceApi* | [**GetTravelCostMatrixByAddress**](docs/LIAPIGeoRouteServiceApi.md#gettravelcostmatrixbyaddress) | **GET** /georoute/v1/travelcostmatrix/byaddress | Gets Cost Matrix by Address
*LIAPIGeoRouteServiceApi* | [**GetTravelCostMatrixByLocation**](docs/LIAPIGeoRouteServiceApi.md#gettravelcostmatrixbylocation) | **GET** /georoute/v1/travelcostmatrix/bylocation | Gets Cost Matrix by Location
*LIAPIGeoSearchServiceApi* | [**GeoSearch**](docs/LIAPIGeoSearchServiceApi.md#geosearch) | **GET** /geosearch/v2/locations | Gets LocationList
*LIAPIGeoStreetsServiceApi* | [**GetIntersectionByAddress**](docs/LIAPIGeoStreetsServiceApi.md#getintersectionbyaddress) | **GET** /geostreets/v1/intersection/byaddress | Gets NearestIntersection of major roads
*LIAPIGeoStreetsServiceApi* | [**GetIntersectionByLocation**](docs/LIAPIGeoStreetsServiceApi.md#getintersectionbylocation) | **GET** /geostreets/v1/intersection/bylocation | Gets NearestIntersection of major roads
*LIAPIGeoStreetsServiceApi* | [**GetNearestSpeedLimit**](docs/LIAPIGeoStreetsServiceApi.md#getnearestspeedlimit) | **GET** /geostreets/v1/speedlimit | Gets NearestSpeedLimit
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxByAddress**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxbyaddress) | **POST** /geotax/v1/tax/{taxRateTypeId}/byaddress | Post Tax By Address
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxByLocation**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxbylocation) | **POST** /geotax/v1/tax/{taxRateTypeId}/bylocation | Post Tax By Location
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxRateByAddress**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxratebyaddress) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Post Taxrate By Address
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxRateByLocation**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxratebylocation) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Post Taxrate By Location
*LIAPIGeoTaxServiceApi* | [**GetIPDTaxByAddress**](docs/LIAPIGeoTaxServiceApi.md#getipdtaxbyaddress) | **GET** /geotax/v1/taxdistrict/ipd/byaddress | Get IPD Tax by Address
*LIAPIGeoTaxServiceApi* | [**GetIPDTaxByAddressBatch**](docs/LIAPIGeoTaxServiceApi.md#getipdtaxbyaddressbatch) | **POST** /geotax/v1/taxdistrict/ipd/byaddress | Get IPD Tax for batch requests
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxByAddress**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxbyaddress) | **GET** /geotax/v1/tax/{taxRateTypeId}/byaddress | Get Tax By Address
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxByLocation**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxbylocation) | **GET** /geotax/v1/tax/{taxRateTypeId}/bylocation | Get Tax By Location
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxRateByAddress**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxratebyaddress) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Get Taxrate By Address
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxRateByLocation**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxratebylocation) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Get Taxrate By Location
*LIAPIGeoTimeServiceApi* | [**GetBatchTimezoneByAddress**](docs/LIAPIGeoTimeServiceApi.md#getbatchtimezonebyaddress) | **POST** /geotime/v1/timezone/byaddress | Timezone Batch by Address
*LIAPIGeoTimeServiceApi* | [**GetBatchTimezoneByLocation**](docs/LIAPIGeoTimeServiceApi.md#getbatchtimezonebylocation) | **POST** /geotime/v1/timezone/bylocation | Timezone Batch by Location
*LIAPIGeoTimeServiceApi* | [**GetTimezoneByAddress**](docs/LIAPIGeoTimeServiceApi.md#gettimezonebyaddress) | **GET** /geotime/v1/timezone/byaddress | Timezone By Address.
*LIAPIGeoTimeServiceApi* | [**GetTimezoneByLocation**](docs/LIAPIGeoTimeServiceApi.md#gettimezonebylocation) | **GET** /geotime/v1/timezone/bylocation | Timezone By Location.
*LIAPIGeoZoneServiceApi* | [**GetBasicBoundaryByAddress**](docs/LIAPIGeoZoneServiceApi.md#getbasicboundarybyaddress) | **GET** /geozone/v1/basicboundary/byaddress | Gets Basic Boundary by Address
*LIAPIGeoZoneServiceApi* | [**GetBasicBoundaryByLocation**](docs/LIAPIGeoZoneServiceApi.md#getbasicboundarybylocation) | **GET** /geozone/v1/basicboundary/bylocation | Gets Basic Boundary by Location
*LIAPIGeoZoneServiceApi* | [**GetPOIBoundaryByAddress**](docs/LIAPIGeoZoneServiceApi.md#getpoiboundarybyaddress) | **GET** /geozone/v1/poiboundary/byaddress | Get Point of Interests Boundary by Address
*LIAPIGeoZoneServiceApi* | [**GetPOIBoundaryByAddressBatch**](docs/LIAPIGeoZoneServiceApi.md#getpoiboundarybyaddressbatch) | **POST** /geozone/v1/poiboundary/byaddress | Batch method for getting Point of Interests Boundary by Address
*LIAPIGeoZoneServiceApi* | [**GetPOIBoundaryByLocation**](docs/LIAPIGeoZoneServiceApi.md#getpoiboundarybylocation) | **GET** /geozone/v1/poiboundary/bylocation | Get Point of Interests Boundary by Location
*LIAPIGeoZoneServiceApi* | [**GetPOIBoundaryByLocationBatch**](docs/LIAPIGeoZoneServiceApi.md#getpoiboundarybylocationbatch) | **POST** /geozone/v1/poiboundary/bylocation | Batch method for getting Point of Interests Boundary by Location
*LIAPIGeoZoneServiceApi* | [**GetPOIBoundaryByPBKey**](docs/LIAPIGeoZoneServiceApi.md#getpoiboundarybypbkey) | **GET** /geozone/v1/poiboundary/bypbkey | Gets Point of Interests Boundary by PBKey
*LIAPIGeoZoneServiceApi* | [**GetPOIBoundaryByPBKeyBatch**](docs/LIAPIGeoZoneServiceApi.md#getpoiboundarybypbkeybatch) | **POST** /geozone/v1/poiboundary/bypbkey | Batch method for getting Point of Interests Boundary by PBKey
*LIAPIGeoZoneServiceApi* | [**GetTravelBoundaryByDistance**](docs/LIAPIGeoZoneServiceApi.md#gettravelboundarybydistance) | **GET** /geozone/v1/travelboundary/bydistance | Gets travel Boundary by Distance
*LIAPIGeoZoneServiceApi* | [**GetTravelBoundaryByTime**](docs/LIAPIGeoZoneServiceApi.md#gettravelboundarybytime) | **GET** /geozone/v1/travelboundary/bytime | Gets travel Boundary by Time
*LIAPIGeocodeServiceApi* | [**Geocode**](docs/LIAPIGeocodeServiceApi.md#geocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
*LIAPIGeocodeServiceApi* | [**GeocodeBatch**](docs/LIAPIGeocodeServiceApi.md#geocodebatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
*LIAPIGeocodeServiceApi* | [**GetCapabilities**](docs/LIAPIGeocodeServiceApi.md#getcapabilities) | **GET** /geocode-service/v1/transient/{datapackBundle}/capabilities | Gets Capabilities
*LIAPIGeocodeServiceApi* | [**GetDictionaries**](docs/LIAPIGeocodeServiceApi.md#getdictionaries) | **GET** /geocode-service/v1/transient/{datapackBundle}/dictionaries | Gets installed Dictionaries
*LIAPIGeocodeServiceApi* | [**GetPBKey**](docs/LIAPIGeocodeServiceApi.md#getpbkey) | **GET** /geocode-service/v1/key/byaddress | Gets PBKey
*LIAPIGeocodeServiceApi* | [**GetPBKeys**](docs/LIAPIGeocodeServiceApi.md#getpbkeys) | **POST** /geocode-service/v1/key/byaddress | Gets PBKeys
*LIAPIGeocodeServiceApi* | [**KeyLookup**](docs/LIAPIGeocodeServiceApi.md#keylookup) | **GET** /geocode-service/v1/keylookup | Get Address
*LIAPIGeocodeServiceApi* | [**KeyLookupBatch**](docs/LIAPIGeocodeServiceApi.md#keylookupbatch) | **POST** /geocode-service/v1/keylookup | Get List of Address
*LIAPIGeocodeServiceApi* | [**ReverseGeocodBatch**](docs/LIAPIGeocodeServiceApi.md#reversegeocodbatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode
*LIAPIGeocodeServiceApi* | [**ReverseGeocode**](docs/LIAPIGeocodeServiceApi.md#reversegeocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AHJ](docs/AHJ.md)
 - [Model.AHJList](docs/AHJList.md)
 - [Model.AHJPlusPSAPResponse](docs/AHJPlusPSAPResponse.md)
 - [Model.AHJmailingAddress](docs/AHJmailingAddress.md)
 - [Model.Accuracy](docs/Accuracy.md)
 - [Model.Address](docs/Address.md)
 - [Model.AddressTime](docs/AddressTime.md)
 - [Model.Age](docs/Age.md)
 - [Model.AgeTheme](docs/AgeTheme.md)
 - [Model.Area](docs/Area.md)
 - [Model.AreaCodeInfo](docs/AreaCodeInfo.md)
 - [Model.AssetsAndWealthTheme](docs/AssetsAndWealthTheme.md)
 - [Model.AttitudesAndMotivationTheme](docs/AttitudesAndMotivationTheme.md)
 - [Model.AutomobileTheme](docs/AutomobileTheme.md)
 - [Model.BaseFloodElevation](docs/BaseFloodElevation.md)
 - [Model.BasicBoundary](docs/BasicBoundary.md)
 - [Model.BasicBoundaryAddress](docs/BasicBoundaryAddress.md)
 - [Model.Birthday](docs/Birthday.md)
 - [Model.Boundaries](docs/Boundaries.md)
 - [Model.Boundary](docs/Boundary.md)
 - [Model.BoundaryBuffer](docs/BoundaryBuffer.md)
 - [Model.BoundaryPoint](docs/BoundaryPoint.md)
 - [Model.BufferRelation](docs/BufferRelation.md)
 - [Model.Candidate](docs/Candidate.md)
 - [Model.CandidateRange](docs/CandidateRange.md)
 - [Model.CandidateRangeUnit](docs/CandidateRangeUnit.md)
 - [Model.Carrier](docs/Carrier.md)
 - [Model.CarrierRouteAddressRequest](docs/CarrierRouteAddressRequest.md)
 - [Model.CarrierRouteBoundaries](docs/CarrierRouteBoundaries.md)
 - [Model.CarrierRoutePreference](docs/CarrierRoutePreference.md)
 - [Model.CarrierRouteResponse](docs/CarrierRouteResponse.md)
 - [Model.CarrierRouteResponseList](docs/CarrierRouteResponseList.md)
 - [Model.Category](docs/Category.md)
 - [Model.CategoryMetadata](docs/CategoryMetadata.md)
 - [Model.Cbsa](docs/Cbsa.md)
 - [Model.Census](docs/Census.md)
 - [Model.Center](docs/Center.md)
 - [Model.ChannelPreferencesTheme](docs/ChannelPreferencesTheme.md)
 - [Model.City](docs/City.md)
 - [Model.CommonAddress](docs/CommonAddress.md)
 - [Model.CommonGeometry](docs/CommonGeometry.md)
 - [Model.CommonState](docs/CommonState.md)
 - [Model.Community](docs/Community.md)
 - [Model.CommuterPatternsTheme](docs/CommuterPatternsTheme.md)
 - [Model.ConfiguredDictionaryResponse](docs/ConfiguredDictionaryResponse.md)
 - [Model.ContactDetails](docs/ContactDetails.md)
 - [Model.ContactPerson](docs/ContactPerson.md)
 - [Model.Cost](docs/Cost.md)
 - [Model.Costs](docs/Costs.md)
 - [Model.CountrySupport](docs/CountrySupport.md)
 - [Model.County](docs/County.md)
 - [Model.Coverage](docs/Coverage.md)
 - [Model.CrimeBoundary](docs/CrimeBoundary.md)
 - [Model.CrimeIndexTheme](docs/CrimeIndexTheme.md)
 - [Model.CrimeRiskByAddressRequest](docs/CrimeRiskByAddressRequest.md)
 - [Model.CrimeRiskByLocationRequest](docs/CrimeRiskByLocationRequest.md)
 - [Model.CrimeRiskLocationResponse](docs/CrimeRiskLocationResponse.md)
 - [Model.CrimeRiskLocationResponseList](docs/CrimeRiskLocationResponseList.md)
 - [Model.CrimeRiskPreferences](docs/CrimeRiskPreferences.md)
 - [Model.CrimeRiskResponse](docs/CrimeRiskResponse.md)
 - [Model.CrimeRiskResponseList](docs/CrimeRiskResponseList.md)
 - [Model.Crs](docs/Crs.md)
 - [Model.CustomObject](docs/CustomObject.md)
 - [Model.CustomObjectMember](docs/CustomObjectMember.md)
 - [Model.CustomPreferences](docs/CustomPreferences.md)
 - [Model.DateTimeEarthQuake](docs/DateTimeEarthQuake.md)
 - [Model.DemographicsThemes](docs/DemographicsThemes.md)
 - [Model.DemographicsThemesV2](docs/DemographicsThemesV2.md)
 - [Model.DemographicsV2](docs/DemographicsV2.md)
 - [Model.Depth](docs/Depth.md)
 - [Model.DeviceStatusNetwork](docs/DeviceStatusNetwork.md)
 - [Model.Dictionary](docs/Dictionary.md)
 - [Model.DirectionGeometry](docs/DirectionGeometry.md)
 - [Model.Distance](docs/Distance.md)
 - [Model.DistanceToBorder](docs/DistanceToBorder.md)
 - [Model.DistanceToFloodHazardAddressRequest](docs/DistanceToFloodHazardAddressRequest.md)
 - [Model.DistanceToFloodHazardLocationRequest](docs/DistanceToFloodHazardLocationRequest.md)
 - [Model.DistanceToFloodHazardLocationResponse](docs/DistanceToFloodHazardLocationResponse.md)
 - [Model.DistanceToFloodHazardResponse](docs/DistanceToFloodHazardResponse.md)
 - [Model.DistrictType](docs/DistrictType.md)
 - [Model.DomesticUltimateBusiness](docs/DomesticUltimateBusiness.md)
 - [Model.EarthquakeEvent](docs/EarthquakeEvent.md)
 - [Model.EarthquakeEventsResponse](docs/EarthquakeEventsResponse.md)
 - [Model.EarthquakeHistory](docs/EarthquakeHistory.md)
 - [Model.EarthquakeLocation](docs/EarthquakeLocation.md)
 - [Model.EarthquakeRiskByAddressRequest](docs/EarthquakeRiskByAddressRequest.md)
 - [Model.EarthquakeRiskByLocationRequest](docs/EarthquakeRiskByLocationRequest.md)
 - [Model.EarthquakeRiskLocationResponse](docs/EarthquakeRiskLocationResponse.md)
 - [Model.EarthquakeRiskLocationResponseList](docs/EarthquakeRiskLocationResponseList.md)
 - [Model.EarthquakeRiskPreferences](docs/EarthquakeRiskPreferences.md)
 - [Model.EarthquakeRiskResponse](docs/EarthquakeRiskResponse.md)
 - [Model.EarthquakeRiskResponseList](docs/EarthquakeRiskResponseList.md)
 - [Model.Education](docs/Education.md)
 - [Model.EducationTheme](docs/EducationTheme.md)
 - [Model.EducationalAttainmentTheme](docs/EducationalAttainmentTheme.md)
 - [Model.Email](docs/Email.md)
 - [Model.EmployeeCount](docs/EmployeeCount.md)
 - [Model.Employment](docs/Employment.md)
 - [Model.EmploymentTheme](docs/EmploymentTheme.md)
 - [Model.End](docs/End.md)
 - [Model.EthnicityTheme](docs/EthnicityTheme.md)
 - [Model.EventsCount](docs/EventsCount.md)
 - [Model.ExpenditureTheme](docs/ExpenditureTheme.md)
 - [Model.Field](docs/Field.md)
 - [Model.FieldV2](docs/FieldV2.md)
 - [Model.FieldsMatching](docs/FieldsMatching.md)
 - [Model.FinancialProductsTheme](docs/FinancialProductsTheme.md)
 - [Model.FireDepartment](docs/FireDepartment.md)
 - [Model.FireDepartmentContactDetails](docs/FireDepartmentContactDetails.md)
 - [Model.FireEvent](docs/FireEvent.md)
 - [Model.FireEventsResponse](docs/FireEventsResponse.md)
 - [Model.FireHistory](docs/FireHistory.md)
 - [Model.FireRiskByAddressRequest](docs/FireRiskByAddressRequest.md)
 - [Model.FireRiskByLocationRequest](docs/FireRiskByLocationRequest.md)
 - [Model.FireRiskLocationResponse](docs/FireRiskLocationResponse.md)
 - [Model.FireRiskLocationResponseList](docs/FireRiskLocationResponseList.md)
 - [Model.FireRiskResponse](docs/FireRiskResponse.md)
 - [Model.FireRiskResponseList](docs/FireRiskResponseList.md)
 - [Model.FireShed](docs/FireShed.md)
 - [Model.FireStation](docs/FireStation.md)
 - [Model.FireStationContactDetails](docs/FireStationContactDetails.md)
 - [Model.FireStations](docs/FireStations.md)
 - [Model.FireStationsLocation](docs/FireStationsLocation.md)
 - [Model.FloodBoundary](docs/FloodBoundary.md)
 - [Model.FloodHazardPreferences](docs/FloodHazardPreferences.md)
 - [Model.FloodRiskByAddressRequest](docs/FloodRiskByAddressRequest.md)
 - [Model.FloodRiskByLocationRequest](docs/FloodRiskByLocationRequest.md)
 - [Model.FloodRiskLocationResponse](docs/FloodRiskLocationResponse.md)
 - [Model.FloodRiskLocationResponseList](docs/FloodRiskLocationResponseList.md)
 - [Model.FloodRiskPreferences](docs/FloodRiskPreferences.md)
 - [Model.FloodRiskResponse](docs/FloodRiskResponse.md)
 - [Model.FloodRiskResponseList](docs/FloodRiskResponseList.md)
 - [Model.FloodZone](docs/FloodZone.md)
 - [Model.FreeOrReducedPriceLunches](docs/FreeOrReducedPriceLunches.md)
 - [Model.GenderTheme](docs/GenderTheme.md)
 - [Model.GeoEnrichMetadataResponse](docs/GeoEnrichMetadataResponse.md)
 - [Model.GeoEnrichResponse](docs/GeoEnrichResponse.md)
 - [Model.GeoIdentityName](docs/GeoIdentityName.md)
 - [Model.GeoIdentityPlace](docs/GeoIdentityPlace.md)
 - [Model.GeoIdentityResponse](docs/GeoIdentityResponse.md)
 - [Model.GeoLocationAccessPoint](docs/GeoLocationAccessPoint.md)
 - [Model.GeoLocationCountry](docs/GeoLocationCountry.md)
 - [Model.GeoLocationDeviceSatus](docs/GeoLocationDeviceSatus.md)
 - [Model.GeoLocationFixedLine](docs/GeoLocationFixedLine.md)
 - [Model.GeoLocationFixedLineCountry](docs/GeoLocationFixedLineCountry.md)
 - [Model.GeoLocationIpAddr](docs/GeoLocationIpAddr.md)
 - [Model.GeoLocationPlace](docs/GeoLocationPlace.md)
 - [Model.GeoLocationState](docs/GeoLocationState.md)
 - [Model.GeoPos](docs/GeoPos.md)
 - [Model.GeoPostGeometry](docs/GeoPostGeometry.md)
 - [Model.GeoPropertyAddressRequest](docs/GeoPropertyAddressRequest.md)
 - [Model.GeoPropertyPBKeyRequest](docs/GeoPropertyPBKeyRequest.md)
 - [Model.GeoPropertyPBKeyResponse](docs/GeoPropertyPBKeyResponse.md)
 - [Model.GeoPropertyPBKeyResponses](docs/GeoPropertyPBKeyResponses.md)
 - [Model.GeoPropertyResponse](docs/GeoPropertyResponse.md)
 - [Model.GeoPropertyResponses](docs/GeoPropertyResponses.md)
 - [Model.GeoRiskBoundaries](docs/GeoRiskBoundaries.md)
 - [Model.GeoRiskCrimeTheme](docs/GeoRiskCrimeTheme.md)
 - [Model.GeoRiskGeometry](docs/GeoRiskGeometry.md)
 - [Model.GeoRiskLocations](docs/GeoRiskLocations.md)
 - [Model.GeoRouteResponse](docs/GeoRouteResponse.md)
 - [Model.GeoTaxLocations](docs/GeoTaxLocations.md)
 - [Model.GeoTaxRateLocations](docs/GeoTaxRateLocations.md)
 - [Model.GeoZoneGeometry](docs/GeoZoneGeometry.md)
 - [Model.GeocodeAddress](docs/GeocodeAddress.md)
 - [Model.GeocodeCapabilitiesResponse](docs/GeocodeCapabilitiesResponse.md)
 - [Model.GeocodeCustomPreferences](docs/GeocodeCustomPreferences.md)
 - [Model.GeocodePreferences](docs/GeocodePreferences.md)
 - [Model.GeocodeRequest](docs/GeocodeRequest.md)
 - [Model.GeocodeRequestAddress](docs/GeocodeRequestAddress.md)
 - [Model.GeocodeServiceResponse](docs/GeocodeServiceResponse.md)
 - [Model.GeocodeServiceResponseList](docs/GeocodeServiceResponseList.md)
 - [Model.Geometry](docs/Geometry.md)
 - [Model.GeosearchLocation](docs/GeosearchLocation.md)
 - [Model.GeosearchLocations](docs/GeosearchLocations.md)
 - [Model.GlobalUltimateBusiness](docs/GlobalUltimateBusiness.md)
 - [Model.GradeLevelsTaught](docs/GradeLevelsTaught.md)
 - [Model.Greatschools](docs/Greatschools.md)
 - [Model.Grid](docs/Grid.md)
 - [Model.HealthTheme](docs/HealthTheme.md)
 - [Model.HouseholdFinance](docs/HouseholdFinance.md)
 - [Model.HouseholdSizeTheme](docs/HouseholdSizeTheme.md)
 - [Model.HouseholdsTheme](docs/HouseholdsTheme.md)
 - [Model.HousingTheme](docs/HousingTheme.md)
 - [Model.IPDTaxByAddressBatchRequest](docs/IPDTaxByAddressBatchRequest.md)
 - [Model.IPDTaxJurisdiction](docs/IPDTaxJurisdiction.md)
 - [Model.Identity](docs/Identity.md)
 - [Model.IdentityDetail](docs/IdentityDetail.md)
 - [Model.IncomeTheme](docs/IncomeTheme.md)
 - [Model.IncomeThemeV2](docs/IncomeThemeV2.md)
 - [Model.IndexVariable](docs/IndexVariable.md)
 - [Model.IndividualValueVariable](docs/IndividualValueVariable.md)
 - [Model.IndividualValueVariableV2](docs/IndividualValueVariableV2.md)
 - [Model.InputParameter](docs/InputParameter.md)
 - [Model.Interest](docs/Interest.md)
 - [Model.Intersection](docs/Intersection.md)
 - [Model.IntersectionResponse](docs/IntersectionResponse.md)
 - [Model.IpInfo](docs/IpInfo.md)
 - [Model.Ipd](docs/Ipd.md)
 - [Model.KeyLookupRequest](docs/KeyLookupRequest.md)
 - [Model.Keys](docs/Keys.md)
 - [Model.LatLongFields](docs/LatLongFields.md)
 - [Model.LifeStyleTheme](docs/LifeStyleTheme.md)
 - [Model.Lifestyle](docs/Lifestyle.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationTime](docs/LocationTime.md)
 - [Model.Magnitude](docs/Magnitude.md)
 - [Model.MaritalStatusTheme](docs/MaritalStatusTheme.md)
 - [Model.Match](docs/Match.md)
 - [Model.MatchedAddress](docs/MatchedAddress.md)
 - [Model.Matrix](docs/Matrix.md)
 - [Model.Mcd](docs/Mcd.md)
 - [Model.Neighborhood](docs/Neighborhood.md)
 - [Model.Network](docs/Network.md)
 - [Model.Operation](docs/Operation.md)
 - [Model.OrganizationType](docs/OrganizationType.md)
 - [Model.OutputParameter](docs/OutputParameter.md)
 - [Model.PBKeyAddressRequest](docs/PBKeyAddressRequest.md)
 - [Model.PBKeyResponse](docs/PBKeyResponse.md)
 - [Model.PBKeyResponseList](docs/PBKeyResponseList.md)
 - [Model.POIBoundaryAddressRequest](docs/POIBoundaryAddressRequest.md)
 - [Model.POIBoundaryLocationRequest](docs/POIBoundaryLocationRequest.md)
 - [Model.POIBoundaryLocations](docs/POIBoundaryLocations.md)
 - [Model.POIBoundaryPBKey](docs/POIBoundaryPBKey.md)
 - [Model.POIBoundaryPBKeyRequest](docs/POIBoundaryPBKeyRequest.md)
 - [Model.POIBoundaryResponse](docs/POIBoundaryResponse.md)
 - [Model.POIByGeometryRequest](docs/POIByGeometryRequest.md)
 - [Model.POIPlaces](docs/POIPlaces.md)
 - [Model.PSAPResponse](docs/PSAPResponse.md)
 - [Model.Parcel](docs/Parcel.md)
 - [Model.ParcelBoundary](docs/ParcelBoundary.md)
 - [Model.ParentBusiness](docs/ParentBusiness.md)
 - [Model.PbKey](docs/PbKey.md)
 - [Model.Photo](docs/Photo.md)
 - [Model.PlaceByLocations](docs/PlaceByLocations.md)
 - [Model.PlaceByLocationsLocation](docs/PlaceByLocationsLocation.md)
 - [Model.PlaceLocation](docs/PlaceLocation.md)
 - [Model.PlaceLocationName](docs/PlaceLocationName.md)
 - [Model.Poi](docs/Poi.md)
 - [Model.PoiBoundary](docs/PoiBoundary.md)
 - [Model.PoiBoundaryPreferences](docs/PoiBoundaryPreferences.md)
 - [Model.PoiClassification](docs/PoiClassification.md)
 - [Model.PoiContactDetails](docs/PoiContactDetails.md)
 - [Model.PoiCount](docs/PoiCount.md)
 - [Model.PoiCountRequest](docs/PoiCountRequest.md)
 - [Model.Points](docs/Points.md)
 - [Model.Pois](docs/Pois.md)
 - [Model.PolygonGeometry](docs/PolygonGeometry.md)
 - [Model.PopulationTheme](docs/PopulationTheme.md)
 - [Model.PreferencTimeZone](docs/PreferencTimeZone.md)
 - [Model.Preferences](docs/Preferences.md)
 - [Model.PrimaryZone](docs/PrimaryZone.md)
 - [Model.Profile](docs/Profile.md)
 - [Model.Properties](docs/Properties.md)
 - [Model.Property](docs/Property.md)
 - [Model.Proxy](docs/Proxy.md)
 - [Model.PurchasingBehaviorTheme](docs/PurchasingBehaviorTheme.md)
 - [Model.RaceAndEthnicityTheme](docs/RaceAndEthnicityTheme.md)
 - [Model.RaceTheme](docs/RaceTheme.md)
 - [Model.RangeVariable](docs/RangeVariable.md)
 - [Model.RangeVariableV2](docs/RangeVariableV2.md)
 - [Model.Rate](docs/Rate.md)
 - [Model.RateCenterResponse](docs/RateCenterResponse.md)
 - [Model.ReturnFieldsDescriptor](docs/ReturnFieldsDescriptor.md)
 - [Model.ReverseGeocodeRequest](docs/ReverseGeocodeRequest.md)
 - [Model.Risk](docs/Risk.md)
 - [Model.RiskAddress](docs/RiskAddress.md)
 - [Model.Road](docs/Road.md)
 - [Model.RouteBoundary](docs/RouteBoundary.md)
 - [Model.RouteDelivery](docs/RouteDelivery.md)
 - [Model.RouteDirection](docs/RouteDirection.md)
 - [Model.RouteDirections](docs/RouteDirections.md)
 - [Model.RouteGeometry](docs/RouteGeometry.md)
 - [Model.SalesTax](docs/SalesTax.md)
 - [Model.SalesTaxRate](docs/SalesTaxRate.md)
 - [Model.SalesVolume](docs/SalesVolume.md)
 - [Model.School](docs/School.md)
 - [Model.SchoolDistrict](docs/SchoolDistrict.md)
 - [Model.SchoolProfile](docs/SchoolProfile.md)
 - [Model.SchoolRanking](docs/SchoolRanking.md)
 - [Model.SchoolsNearByResponse](docs/SchoolsNearByResponse.md)
 - [Model.Segmentation](docs/Segmentation.md)
 - [Model.SegmentationThemes](docs/SegmentationThemes.md)
 - [Model.ShoreLineDistance](docs/ShoreLineDistance.md)
 - [Model.Sic](docs/Sic.md)
 - [Model.SicMetadata](docs/SicMetadata.md)
 - [Model.SiteDetails](docs/SiteDetails.md)
 - [Model.SpecialPurposeDistrict](docs/SpecialPurposeDistrict.md)
 - [Model.SpecialPurposeDistrictTax](docs/SpecialPurposeDistrictTax.md)
 - [Model.SpecialPurposeDistrictTaxRate](docs/SpecialPurposeDistrictTaxRate.md)
 - [Model.SpeedLimit](docs/SpeedLimit.md)
 - [Model.SpeedRoad](docs/SpeedRoad.md)
 - [Model.Start](docs/Start.md)
 - [Model.StartEndPoint](docs/StartEndPoint.md)
 - [Model.Status](docs/Status.md)
 - [Model.StudentEthnicity](docs/StudentEthnicity.md)
 - [Model.SupplyAndDemandTheme](docs/SupplyAndDemandTheme.md)
 - [Model.SupportLevel](docs/SupportLevel.md)
 - [Model.TaxAddress](docs/TaxAddress.md)
 - [Model.TaxAddressRequest](docs/TaxAddressRequest.md)
 - [Model.TaxBatchLocationResponse](docs/TaxBatchLocationResponse.md)
 - [Model.TaxBatchResponse](docs/TaxBatchResponse.md)
 - [Model.TaxCounty](docs/TaxCounty.md)
 - [Model.TaxDistrictResponse](docs/TaxDistrictResponse.md)
 - [Model.TaxDistrictResponseList](docs/TaxDistrictResponseList.md)
 - [Model.TaxJurisdiction](docs/TaxJurisdiction.md)
 - [Model.TaxLocationPreferences](docs/TaxLocationPreferences.md)
 - [Model.TaxLocationRequest](docs/TaxLocationRequest.md)
 - [Model.TaxLocationResponses](docs/TaxLocationResponses.md)
 - [Model.TaxPlace](docs/TaxPlace.md)
 - [Model.TaxRateAddress](docs/TaxRateAddress.md)
 - [Model.TaxRateAddressRequest](docs/TaxRateAddressRequest.md)
 - [Model.TaxRateBatchLocationResponse](docs/TaxRateBatchLocationResponse.md)
 - [Model.TaxRateBatchResponse](docs/TaxRateBatchResponse.md)
 - [Model.TaxRateLocationRequest](docs/TaxRateLocationRequest.md)
 - [Model.TaxRateLocationResponses](docs/TaxRateLocationResponses.md)
 - [Model.TaxRateResponse](docs/TaxRateResponse.md)
 - [Model.TaxRateResponses](docs/TaxRateResponses.md)
 - [Model.TaxResponse](docs/TaxResponse.md)
 - [Model.TaxResponses](docs/TaxResponses.md)
 - [Model.TaxState](docs/TaxState.md)
 - [Model.Time](docs/Time.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.TimezoneAddressRequest](docs/TimezoneAddressRequest.md)
 - [Model.TimezoneLocation](docs/TimezoneLocation.md)
 - [Model.TimezoneLocationRequest](docs/TimezoneLocationRequest.md)
 - [Model.TimezoneLocationResponse](docs/TimezoneLocationResponse.md)
 - [Model.TimezoneResponse](docs/TimezoneResponse.md)
 - [Model.Topic](docs/Topic.md)
 - [Model.TravelBoundaries](docs/TravelBoundaries.md)
 - [Model.TravelBoundary](docs/TravelBoundary.md)
 - [Model.TravelCostMatrixResponse](docs/TravelCostMatrixResponse.md)
 - [Model.Type](docs/Type.md)
 - [Model.Unit](docs/Unit.md)
 - [Model.Url](docs/Url.md)
 - [Model.UseTax](docs/UseTax.md)
 - [Model.UseTaxRate](docs/UseTaxRate.md)
 - [Model.WaterBody](docs/WaterBody.md)
 - [Model.WaterBodyLocationResponse](docs/WaterBodyLocationResponse.md)
 - [Model.WaterBodyResponse](docs/WaterBodyResponse.md)


## Documentation for Authorization

### oAuth2Password

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: N/A

