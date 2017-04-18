![Pitney Bowes](/PitneyBowes_Logo.jpg)

# Pitney Bowes Location Intelligence API

### Description
[Location Intelligence APIs ](http://developer.pitneybowes.com/en/location-intelligence.html) help you to Incorporate Pitney Bowes extensive geodata into everyday applications, business processes, and workflows. Use our SDKs to get started quickly and easily integrate API calls in your applications.

### Location Intelligence APIs:
* [GeoEnhance](https://locate.pitneybowes.com/geoenhance ) : Returns addresses, place names, points-of-interest and timezones with the input of a location coordinate. Useful for enhancing & enriching your geo-tagged data.

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

The following platforms are supported by Location Intelligence SDKs:
*	[Android](https://github.com/PitneyBowes/LocationIntelligenceSDK-Android)
*	[JavaScript](https://github.com/PitneyBowes/LocationIntelligenceSDK-javascript) 
*	[iOS](https://github.com/PitneyBowes/LocationIntelligenceSDK-IOS)
*	[Java](https://github.com/PitneyBowes/LocationIntelligenceSDK-Java)
*	[C#](https://github.com/PitneyBowes/LocationIntelligenceSDK-CSharp)  

[Click here](https://locate.pitneybowes.com/docs/location-intelligence/v1/en/index.html) for detailed Documentation on Location Intelligence APIs 


# Location Intelligence .Net(CSharp) SDK
### Description
Location Intelligence CSharp SDK facilitates you to build .Net applications using Location Intelligence APIs.
### Getting Started
To get started with CSharp SDK, you must first register at [Location Intelligence API Home Page](http://developer.pitneybowes.com/en/location-intelligence.html) and obtain your API Key and Secret to get started with the CSharp SDK and call Location Intelligence APIs.

## Frameworks supported
- .NET 4.5 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later Which is licensed under Apache 2.0 license. The license can be downloaded from https://opensource.org/licenses/apache-2.0. 
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later which is licensed under MIT license. The license can be downloaded from http://opensource.org/licenses/mit-license. 

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

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
            
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

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
*LIAPIGeo911ServiceApi* | [**GetAHJPlusPSAPByAddress**](Documentation/LIAPIGeo911ServiceApi.md#getahjpluspsapbyaddress) | **GET** /geo911/v1/ahj-psap/byaddress | AHJ & PSAP By Address.
*LIAPIGeo911ServiceApi* | [**GetAHJPlusPSAPByLocation**](Documentation/LIAPIGeo911ServiceApi.md#getahjpluspsapbylocation) | **GET** /geo911/v1/ahj-psap/bylocation | AHJ & PSAP By Location
*LIAPIGeo911ServiceApi* | [**GetPSAPByAddress**](Documentation/LIAPIGeo911ServiceApi.md#getpsapbyaddress) | **GET** /geo911/v1/psap/byaddress | PSAP By Address.
*LIAPIGeo911ServiceApi* | [**GetPSAPByLocation**](Documentation/LIAPIGeo911ServiceApi.md#getpsapbylocation) | **GET** /geo911/v1/psap/bylocation | PSAP By Location.
*LIAPIGeoCommServiceApi* | [**GetRateCenterByAddress**](Documentation/LIAPIGeoCommServiceApi.md#getratecenterbyaddress) | **GET** /geocomm/v1/ratecenter/byaddress | Rate Center By Address.
*LIAPIGeoCommServiceApi* | [**GetRateCenterByLocation**](Documentation/LIAPIGeoCommServiceApi.md#getratecenterbylocation) | **GET** /geocomm/v1/ratecenter/bylocation | Rate Center By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetAddress**](Documentation/LIAPIGeoEnhanceServiceApi.md#getaddress) | **GET** /geoenhance/v1/address/bylocation | Address By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetEntityByLocation**](Documentation/LIAPIGeoEnhanceServiceApi.md#getentitybylocation) | **GET** /geoenhance/v1/poi/bylocation | Points Of Interest By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetPlaceByLocation**](Documentation/LIAPIGeoEnhanceServiceApi.md#getplacebylocation) | **GET** /geoenhance/v1/place/bylocation | Place By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetTimezoneByLocation**](Documentation/LIAPIGeoEnhanceServiceApi.md#gettimezonebylocation) | **GET** /geoenhance/v1/timezone/bylocation | Timezone By Location.
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByAddress**](Documentation/LIAPIGeoLifeServiceApi.md#getdemographicsbyaddress) | **GET** /geolife/v1/demographics/byaddress | Demographics By Address.
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByLocation**](Documentation/LIAPIGeoLifeServiceApi.md#getdemographicsbylocation) | **GET** /geolife/v1/demographics/bylocation | Demographics By Location.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByAddress**](Documentation/LIAPIGeoLifeServiceApi.md#getsegmentationbyaddress) | **GET** /geolife/v1/segmentation/byaddress | Segmentation By Address.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByLocation**](Documentation/LIAPIGeoLifeServiceApi.md#getsegmentationbylocation) | **GET** /geolife/v1/segmentation/bylocation | Segmentation By Location.
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByAddress**](Documentation/LIAPIGeoRiskServiceApi.md#getcrimeriskbyaddress) | **GET** /georisk/v1/crime/byaddress | Gets CrimeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByLocation**](Documentation/LIAPIGeoRiskServiceApi.md#getcrimeriskbylocation) | **GET** /georisk/v1/crime/bylocation | Gets CrimeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByAddress**](Documentation/LIAPIGeoRiskServiceApi.md#getearthquakeriskbyaddress) | **GET** /georisk/v1/earthquake/byaddress | Gets EarthquakeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByLocation**](Documentation/LIAPIGeoRiskServiceApi.md#getearthquakeriskbylocation) | **GET** /georisk/v1/earthquake/bylocation | Gets EarthquakeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByAddress**](Documentation/LIAPIGeoRiskServiceApi.md#getfireriskbyaddress) | **GET** /georisk/v1/fire/byaddress | Gets FireRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByLocation**](Documentation/LIAPIGeoRiskServiceApi.md#getfireriskbylocation) | **GET** /georisk/v1/fire/bylocation | Gets FireRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireStationByAddress**](Documentation/LIAPIGeoRiskServiceApi.md#getfirestationbyaddress) | **GET** /georisk/v1/firestation/byaddress | Gets FireStationResponse
*LIAPIGeoRiskServiceApi* | [**GetFireStationByLocation**](Documentation/LIAPIGeoRiskServiceApi.md#getfirestationbylocation) | **GET** /georisk/v1/firestation/bylocation | Gets FireStationResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByAddress**](Documentation/LIAPIGeoRiskServiceApi.md#getfloodriskbyaddress) | **GET** /georisk/v1/flood/byaddress | Gets FloodRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByLocation**](Documentation/LIAPIGeoRiskServiceApi.md#getfloodriskbylocation) | **GET** /georisk/v1/flood/bylocation | Gets FloodRiskResponse
*LIAPIGeoSearchServiceApi* | [**GeoSearch**](Documentation/LIAPIGeoSearchServiceApi.md#geosearch) | **GET** /geosearch/v1/locations | Gets LocationList
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxByAddress**](Documentation/LIAPIGeoTaxServiceApi.md#getbatchtaxbyaddress) | **POST** /geotax/v1/tax/{taxRateTypeId}/byaddress | Post Tax By Address
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxByLocation**](Documentation/LIAPIGeoTaxServiceApi.md#getbatchtaxbylocation) | **POST** /geotax/v1/tax/{taxRateTypeId}/bylocation | Post Tax By Location
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxRateByAddress**](Documentation/LIAPIGeoTaxServiceApi.md#getbatchtaxratebyaddress) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Post Taxrate By Address
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxRateByLocation**](Documentation/LIAPIGeoTaxServiceApi.md#getbatchtaxratebylocation) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Post Taxrate By Location
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxByAddress**](Documentation/LIAPIGeoTaxServiceApi.md#getspecifictaxbyaddress) | **GET** /geotax/v1/tax/{taxRateTypeId}/byaddress | Get Tax By Address
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxByLocation**](Documentation/LIAPIGeoTaxServiceApi.md#getspecifictaxbylocation) | **GET** /geotax/v1/tax/{taxRateTypeId}/bylocation | Get Tax By Location
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxRateByAddress**](Documentation/LIAPIGeoTaxServiceApi.md#getspecifictaxratebyaddress) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Get Taxrate By Address
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxRateByLocation**](Documentation/LIAPIGeoTaxServiceApi.md#getspecifictaxratebylocation) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Get Taxrate By Location
*LIAPIGeoZoneServiceApi* | [**GetRouteByAddress**](Documentation/LIAPIGeoZoneServiceApi.md#getroutebyaddress) | **GET** /georoute/v1/route/byaddress | Gets Route by Address
*LIAPIGeoZoneServiceApi* | [**GetRouteByLocation**](Documentation/LIAPIGeoZoneServiceApi.md#getroutebylocation) | **GET** /georoute/v1/route/bylocation | Gets Route by Location
*LIAPIGeoZoneServiceApi* | [**GetTravelBoundaryByDistance**](Documentation/LIAPIGeoZoneServiceApi.md#gettravelboundarybydistance) | **GET** /geozone/v1/travelboundary/bydistance | Gets travel Boundary by Distance
*LIAPIGeoZoneServiceApi* | [**GetTravelBoundaryByTime**](Documentation/LIAPIGeoZoneServiceApi.md#gettravelboundarybytime) | **GET** /geozone/v1/travelboundary/bytime | Gets travel Boundary by Time
*LIAPIGeoZoneServiceApi* | [**GetTravelCostMatrixByAddress**](Documentation/LIAPIGeoZoneServiceApi.md#gettravelcostmatrixbyaddress) | **GET** /georoute/v1/travelcostmatrix/byaddress | Gets Cost Matrix by Address
*LIAPIGeoZoneServiceApi* | [**GetTravelCostMatrixByLocation**](Documentation/LIAPIGeoZoneServiceApi.md#gettravelcostmatrixbylocation) | **GET** /georoute/v1/travelcostmatrix/bylocation | Gets Cost Matrix by Location
*LIAPIGeocodeServiceApi* | [**Geocode**](Documentation/LIAPIGeocodeServiceApi.md#geocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
*LIAPIGeocodeServiceApi* | [**GeocodeBatch**](Documentation/LIAPIGeocodeServiceApi.md#geocodebatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
*LIAPIGeocodeServiceApi* | [**GetCapabilities**](Documentation/LIAPIGeocodeServiceApi.md#getcapabilities) | **GET** /geocode-service/v1/transient/{datapackBundle}/capabilities | Gets Capabilities
*LIAPIGeocodeServiceApi* | [**GetDictionaries**](Documentation/LIAPIGeocodeServiceApi.md#getdictionaries) | **GET** /geocode-service/v1/transient/{datapackBundle}/dictionaries | Gets installed Dictionaries
*LIAPIGeocodeServiceApi* | [**ReverseGeocodBatch**](Documentation/LIAPIGeocodeServiceApi.md#reversegeocodbatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode
*LIAPIGeocodeServiceApi* | [**ReverseGeocode**](Documentation/LIAPIGeocodeServiceApi.md#reversegeocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AHJ](Documentation/AHJ.md)
 - [Model.AHJList](Documentation/AHJList.md)
 - [Model.AHJPlusPSAPResponse](Documentation/AHJPlusPSAPResponse.md)
 - [Model.Address](Documentation/Address.md)
 - [Model.AgeTheme](Documentation/AgeTheme.md)
 - [Model.AreaCodeInfo](Documentation/AreaCodeInfo.md)
 - [Model.AttitudesAndMotivationTheme](Documentation/AttitudesAndMotivationTheme.md)
 - [Model.AutomobileTheme](Documentation/AutomobileTheme.md)
 - [Model.BaseFloodElevation](Documentation/BaseFloodElevation.md)
 - [Model.Boundaries](Documentation/Boundaries.md)
 - [Model.Boundary](Documentation/Boundary.md)
 - [Model.Candidate](Documentation/Candidate.md)
 - [Model.CandidateRange](Documentation/CandidateRange.md)
 - [Model.CandidateRangeUnit](Documentation/CandidateRangeUnit.md)
 - [Model.Cbsa](Documentation/Cbsa.md)
 - [Model.Census](Documentation/Census.md)
 - [Model.ChannelPreferencesTheme](Documentation/ChannelPreferencesTheme.md)
 - [Model.Community](Documentation/Community.md)
 - [Model.CommuterPatternsTheme](Documentation/CommuterPatternsTheme.md)
 - [Model.ConfiguredDictionaryResponse](Documentation/ConfiguredDictionaryResponse.md)
 - [Model.ContactDetails](Documentation/ContactDetails.md)
 - [Model.ContactPerson](Documentation/ContactPerson.md)
 - [Model.Cost](Documentation/Cost.md)
 - [Model.Costs](Documentation/Costs.md)
 - [Model.CountrySupport](Documentation/CountrySupport.md)
 - [Model.County](Documentation/County.md)
 - [Model.Coverage](Documentation/Coverage.md)
 - [Model.CrimeBoundary](Documentation/CrimeBoundary.md)
 - [Model.CrimeIndexTheme](Documentation/CrimeIndexTheme.md)
 - [Model.CrimeRiskResponse](Documentation/CrimeRiskResponse.md)
 - [Model.Crs](Documentation/Crs.md)
 - [Model.CustomObject](Documentation/CustomObject.md)
 - [Model.CustomObjectMember](Documentation/CustomObjectMember.md)
 - [Model.Demographics](Documentation/Demographics.md)
 - [Model.DemographicsThemes](Documentation/DemographicsThemes.md)
 - [Model.Dictionary](Documentation/Dictionary.md)
 - [Model.DirectionGeometry](Documentation/DirectionGeometry.md)
 - [Model.Distance](Documentation/Distance.md)
 - [Model.EarthquakeRiskResponse](Documentation/EarthquakeRiskResponse.md)
 - [Model.EducationalAttainmentTheme](Documentation/EducationalAttainmentTheme.md)
 - [Model.EthnicityTheme](Documentation/EthnicityTheme.md)
 - [Model.EventsCount](Documentation/EventsCount.md)
 - [Model.Field](Documentation/Field.md)
 - [Model.FieldsMatching](Documentation/FieldsMatching.md)
 - [Model.FinancialProductsTheme](Documentation/FinancialProductsTheme.md)
 - [Model.FireDepartment](Documentation/FireDepartment.md)
 - [Model.FireRiskResponse](Documentation/FireRiskResponse.md)
 - [Model.FireShed](Documentation/FireShed.md)
 - [Model.FireStation](Documentation/FireStation.md)
 - [Model.FireStations](Documentation/FireStations.md)
 - [Model.FloodBoundary](Documentation/FloodBoundary.md)
 - [Model.FloodRiskResponse](Documentation/FloodRiskResponse.md)
 - [Model.FloodZone](Documentation/FloodZone.md)
 - [Model.GenderTheme](Documentation/GenderTheme.md)
 - [Model.GeoPos](Documentation/GeoPos.md)
 - [Model.GeoRiskBoundaries](Documentation/GeoRiskBoundaries.md)
 - [Model.GeoRiskCrimeTheme](Documentation/GeoRiskCrimeTheme.md)
 - [Model.GeoRiskGeometry](Documentation/GeoRiskGeometry.md)
 - [Model.GeoRouteResponse](Documentation/GeoRouteResponse.md)
 - [Model.GeoTaxLocations](Documentation/GeoTaxLocations.md)
 - [Model.GeocodeAddress](Documentation/GeocodeAddress.md)
 - [Model.GeocodeCapabilitiesResponse](Documentation/GeocodeCapabilitiesResponse.md)
 - [Model.GeocodeRequest](Documentation/GeocodeRequest.md)
 - [Model.GeocodeServiceResponse](Documentation/GeocodeServiceResponse.md)
 - [Model.GeocodeServiceResponseList](Documentation/GeocodeServiceResponseList.md)
 - [Model.Geometry](Documentation/Geometry.md)
 - [Model.GeometryPolygon](Documentation/GeometryPolygon.md)
 - [Model.Grid](Documentation/Grid.md)
 - [Model.HouseholdSizeTheme](Documentation/HouseholdSizeTheme.md)
 - [Model.IncomeTheme](Documentation/IncomeTheme.md)
 - [Model.IndexVariable](Documentation/IndexVariable.md)
 - [Model.IndividualValueVariable](Documentation/IndividualValueVariable.md)
 - [Model.InputParameter](Documentation/InputParameter.md)
 - [Model.LatLongFields](Documentation/LatLongFields.md)
 - [Model.LifeStyleTheme](Documentation/LifeStyleTheme.md)
 - [Model.Location](Documentation/Location.md)
 - [Model.Locations](Documentation/Locations.md)
 - [Model.MaritalStatusTheme](Documentation/MaritalStatusTheme.md)
 - [Model.Match](Documentation/Match.md)
 - [Model.Mcd](Documentation/Mcd.md)
 - [Model.Name](Documentation/Name.md)
 - [Model.Operation](Documentation/Operation.md)
 - [Model.OutputParameter](Documentation/OutputParameter.md)
 - [Model.PSAPResponse](Documentation/PSAPResponse.md)
 - [Model.Place](Documentation/Place.md)
 - [Model.PlaceByLocations](Documentation/PlaceByLocations.md)
 - [Model.PlaceByLocationsLocation](Documentation/PlaceByLocationsLocation.md)
 - [Model.PlaceLocation](Documentation/PlaceLocation.md)
 - [Model.PlaceLocationName](Documentation/PlaceLocationName.md)
 - [Model.Poi](Documentation/Poi.md)
 - [Model.Point](Documentation/Point.md)
 - [Model.Points](Documentation/Points.md)
 - [Model.Polygon](Documentation/Polygon.md)
 - [Model.Preferences](Documentation/Preferences.md)
 - [Model.PrimaryZone](Documentation/PrimaryZone.md)
 - [Model.Properties](Documentation/Properties.md)
 - [Model.PurchasingBehaviorTheme](Documentation/PurchasingBehaviorTheme.md)
 - [Model.RaceTheme](Documentation/RaceTheme.md)
 - [Model.RangeVariable](Documentation/RangeVariable.md)
 - [Model.RateCenterResponse](Documentation/RateCenterResponse.md)
 - [Model.ReturnFieldsDescriptor](Documentation/ReturnFieldsDescriptor.md)
 - [Model.ReverseGeocodeRequest](Documentation/ReverseGeocodeRequest.md)
 - [Model.Risk](Documentation/Risk.md)
 - [Model.RouteDirection](Documentation/RouteDirection.md)
 - [Model.RouteDirections](Documentation/RouteDirections.md)
 - [Model.RouteGeometry](Documentation/RouteGeometry.md)
 - [Model.SalesTax](Documentation/SalesTax.md)
 - [Model.Segmentation](Documentation/Segmentation.md)
 - [Model.SegmentationThemes](Documentation/SegmentationThemes.md)
 - [Model.SiteDetails](Documentation/SiteDetails.md)
 - [Model.SpecialPurposeDistrict](Documentation/SpecialPurposeDistrict.md)
 - [Model.SpecialPurposeDistrictTax](Documentation/SpecialPurposeDistrictTax.md)
 - [Model.State](Documentation/State.md)
 - [Model.Status](Documentation/Status.md)
 - [Model.SupportLevel](Documentation/SupportLevel.md)
 - [Model.TaxAddress](Documentation/TaxAddress.md)
 - [Model.TaxAddressRequest](Documentation/TaxAddressRequest.md)
 - [Model.TaxJurisdiction](Documentation/TaxJurisdiction.md)
 - [Model.TaxLocationRequest](Documentation/TaxLocationRequest.md)
 - [Model.TaxRateAddress](Documentation/TaxRateAddress.md)
 - [Model.TaxRateAddressRequest](Documentation/TaxRateAddressRequest.md)
 - [Model.TaxRateLocationRequest](Documentation/TaxRateLocationRequest.md)
 - [Model.TaxResponse](Documentation/TaxResponse.md)
 - [Model.TaxResponses](Documentation/TaxResponses.md)
 - [Model.Time](Documentation/Time.md)
 - [Model.Timezone](Documentation/Timezone.md)
 - [Model.TravelBoundaries](Documentation/TravelBoundaries.md)
 - [Model.TravelBoundary](Documentation/TravelBoundary.md)
 - [Model.TravelCostMatrixResponse](Documentation/TravelCostMatrixResponse.md)
 - [Model.TravelCostMatrixResponseEndPoint](Documentation/TravelCostMatrixResponseEndPoint.md)
 - [Model.TravelCostMatrixResponseEndPointCrs](Documentation/TravelCostMatrixResponseEndPointCrs.md)
 - [Model.TravelCostMatrixResponseEndPointCrsProperties](Documentation/TravelCostMatrixResponseEndPointCrsProperties.md)
 - [Model.TravelCostMatrixResponseMatrix](Documentation/TravelCostMatrixResponseMatrix.md)
 - [Model.UseTax](Documentation/UseTax.md)


## Documentation for Authorization

### oAuth2Password

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: N/A
