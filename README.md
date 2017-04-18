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
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

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
*LIAPIGeo911ServiceApi* | [**GetAHJPlusPSAPByAddress**](docs/LIAPIGeo911ServiceApi.md#getahjpluspsapbyaddress) | **GET** /geo911/v1/ahj-psap/byaddress | AHJ & PSAP By Address.
*LIAPIGeo911ServiceApi* | [**GetAHJPlusPSAPByLocation**](docs/LIAPIGeo911ServiceApi.md#getahjpluspsapbylocation) | **GET** /geo911/v1/ahj-psap/bylocation | AHJ & PSAP By Location
*LIAPIGeo911ServiceApi* | [**GetPSAPByAddress**](docs/LIAPIGeo911ServiceApi.md#getpsapbyaddress) | **GET** /geo911/v1/psap/byaddress | PSAP By Address.
*LIAPIGeo911ServiceApi* | [**GetPSAPByLocation**](docs/LIAPIGeo911ServiceApi.md#getpsapbylocation) | **GET** /geo911/v1/psap/bylocation | PSAP By Location.
*LIAPIGeoCommServiceApi* | [**GetRateCenterByAddress**](docs/LIAPIGeoCommServiceApi.md#getratecenterbyaddress) | **GET** /geocomm/v1/ratecenter/byaddress | Rate Center By Address.
*LIAPIGeoCommServiceApi* | [**GetRateCenterByLocation**](docs/LIAPIGeoCommServiceApi.md#getratecenterbylocation) | **GET** /geocomm/v1/ratecenter/bylocation | Rate Center By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetAddress**](docs/LIAPIGeoEnhanceServiceApi.md#getaddress) | **GET** /geoenhance/v1/address/bylocation | Address By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetEntityByLocation**](docs/LIAPIGeoEnhanceServiceApi.md#getentitybylocation) | **GET** /geoenhance/v1/poi/bylocation | Points Of Interest By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetPlaceByLocation**](docs/LIAPIGeoEnhanceServiceApi.md#getplacebylocation) | **GET** /geoenhance/v1/place/bylocation | Place By Location.
*LIAPIGeoEnhanceServiceApi* | [**GetTimezoneByLocation**](docs/LIAPIGeoEnhanceServiceApi.md#gettimezonebylocation) | **GET** /geoenhance/v1/timezone/bylocation | Timezone By Location.
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByAddress**](docs/LIAPIGeoLifeServiceApi.md#getdemographicsbyaddress) | **GET** /geolife/v1/demographics/byaddress | Demographics By Address.
*LIAPIGeoLifeServiceApi* | [**GetDemographicsByLocation**](docs/LIAPIGeoLifeServiceApi.md#getdemographicsbylocation) | **GET** /geolife/v1/demographics/bylocation | Demographics By Location.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByAddress**](docs/LIAPIGeoLifeServiceApi.md#getsegmentationbyaddress) | **GET** /geolife/v1/segmentation/byaddress | Segmentation By Address.
*LIAPIGeoLifeServiceApi* | [**GetSegmentationByLocation**](docs/LIAPIGeoLifeServiceApi.md#getsegmentationbylocation) | **GET** /geolife/v1/segmentation/bylocation | Segmentation By Location.
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getcrimeriskbyaddress) | **GET** /georisk/v1/crime/byaddress | Gets CrimeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetCrimeRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getcrimeriskbylocation) | **GET** /georisk/v1/crime/bylocation | Gets CrimeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getearthquakeriskbyaddress) | **GET** /georisk/v1/earthquake/byaddress | Gets EarthquakeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetEarthquakeRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getearthquakeriskbylocation) | **GET** /georisk/v1/earthquake/bylocation | Gets EarthquakeRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getfireriskbyaddress) | **GET** /georisk/v1/fire/byaddress | Gets FireRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getfireriskbylocation) | **GET** /georisk/v1/fire/bylocation | Gets FireRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFireStationByAddress**](docs/LIAPIGeoRiskServiceApi.md#getfirestationbyaddress) | **GET** /georisk/v1/firestation/byaddress | Gets FireStationResponse
*LIAPIGeoRiskServiceApi* | [**GetFireStationByLocation**](docs/LIAPIGeoRiskServiceApi.md#getfirestationbylocation) | **GET** /georisk/v1/firestation/bylocation | Gets FireStationResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByAddress**](docs/LIAPIGeoRiskServiceApi.md#getfloodriskbyaddress) | **GET** /georisk/v1/flood/byaddress | Gets FloodRiskResponse
*LIAPIGeoRiskServiceApi* | [**GetFloodRiskByLocation**](docs/LIAPIGeoRiskServiceApi.md#getfloodriskbylocation) | **GET** /georisk/v1/flood/bylocation | Gets FloodRiskResponse
*LIAPIGeoSearchServiceApi* | [**GeoSearch**](docs/LIAPIGeoSearchServiceApi.md#geosearch) | **GET** /geosearch/v1/locations | Gets LocationList
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxByAddress**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxbyaddress) | **POST** /geotax/v1/tax/{taxRateTypeId}/byaddress | Post Tax By Address
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxByLocation**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxbylocation) | **POST** /geotax/v1/tax/{taxRateTypeId}/bylocation | Post Tax By Location
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxRateByAddress**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxratebyaddress) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Post Taxrate By Address
*LIAPIGeoTaxServiceApi* | [**GetBatchTaxRateByLocation**](docs/LIAPIGeoTaxServiceApi.md#getbatchtaxratebylocation) | **POST** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Post Taxrate By Location
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxByAddress**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxbyaddress) | **GET** /geotax/v1/tax/{taxRateTypeId}/byaddress | Get Tax By Address
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxByLocation**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxbylocation) | **GET** /geotax/v1/tax/{taxRateTypeId}/bylocation | Get Tax By Location
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxRateByAddress**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxratebyaddress) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/byaddress | Get Taxrate By Address
*LIAPIGeoTaxServiceApi* | [**GetSpecificTaxRateByLocation**](docs/LIAPIGeoTaxServiceApi.md#getspecifictaxratebylocation) | **GET** /geotax/v1/taxrate/{taxRateTypeId}/bylocation | Get Taxrate By Location
*LIAPIGeoZoneServiceApi* | [**GetRouteByAddress**](docs/LIAPIGeoZoneServiceApi.md#getroutebyaddress) | **GET** /georoute/v1/route/byaddress | Gets Route by Address
*LIAPIGeoZoneServiceApi* | [**GetRouteByLocation**](docs/LIAPIGeoZoneServiceApi.md#getroutebylocation) | **GET** /georoute/v1/route/bylocation | Gets Route by Location
*LIAPIGeoZoneServiceApi* | [**GetTravelBoundaryByDistance**](docs/LIAPIGeoZoneServiceApi.md#gettravelboundarybydistance) | **GET** /geozone/v1/travelboundary/bydistance | Gets travel Boundary by Distance
*LIAPIGeoZoneServiceApi* | [**GetTravelBoundaryByTime**](docs/LIAPIGeoZoneServiceApi.md#gettravelboundarybytime) | **GET** /geozone/v1/travelboundary/bytime | Gets travel Boundary by Time
*LIAPIGeoZoneServiceApi* | [**GetTravelCostMatrixByAddress**](docs/LIAPIGeoZoneServiceApi.md#gettravelcostmatrixbyaddress) | **GET** /georoute/v1/travelcostmatrix/byaddress | Gets Cost Matrix by Address
*LIAPIGeoZoneServiceApi* | [**GetTravelCostMatrixByLocation**](docs/LIAPIGeoZoneServiceApi.md#gettravelcostmatrixbylocation) | **GET** /georoute/v1/travelcostmatrix/bylocation | Gets Cost Matrix by Location
*LIAPIGeocodeServiceApi* | [**Geocode**](docs/LIAPIGeocodeServiceApi.md#geocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
*LIAPIGeocodeServiceApi* | [**GeocodeBatch**](docs/LIAPIGeocodeServiceApi.md#geocodebatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/geocode | Gets Geocode
*LIAPIGeocodeServiceApi* | [**GetCapabilities**](docs/LIAPIGeocodeServiceApi.md#getcapabilities) | **GET** /geocode-service/v1/transient/{datapackBundle}/capabilities | Gets Capabilities
*LIAPIGeocodeServiceApi* | [**GetDictionaries**](docs/LIAPIGeocodeServiceApi.md#getdictionaries) | **GET** /geocode-service/v1/transient/{datapackBundle}/dictionaries | Gets installed Dictionaries
*LIAPIGeocodeServiceApi* | [**ReverseGeocodBatch**](docs/LIAPIGeocodeServiceApi.md#reversegeocodbatch) | **POST** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode
*LIAPIGeocodeServiceApi* | [**ReverseGeocode**](docs/LIAPIGeocodeServiceApi.md#reversegeocode) | **GET** /geocode-service/v1/transient/{datapackBundle}/reverseGeocode | reverse Geocode


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AHJ](docs/AHJ.md)
 - [Model.AHJList](docs/AHJList.md)
 - [Model.AHJPlusPSAPResponse](docs/AHJPlusPSAPResponse.md)
 - [Model.Address](docs/Address.md)
 - [Model.AgeTheme](docs/AgeTheme.md)
 - [Model.AreaCodeInfo](docs/AreaCodeInfo.md)
 - [Model.AttitudesAndMotivationTheme](docs/AttitudesAndMotivationTheme.md)
 - [Model.AutomobileTheme](docs/AutomobileTheme.md)
 - [Model.BaseFloodElevation](docs/BaseFloodElevation.md)
 - [Model.Boundaries](docs/Boundaries.md)
 - [Model.Boundary](docs/Boundary.md)
 - [Model.Candidate](docs/Candidate.md)
 - [Model.CandidateRange](docs/CandidateRange.md)
 - [Model.CandidateRangeUnit](docs/CandidateRangeUnit.md)
 - [Model.Cbsa](docs/Cbsa.md)
 - [Model.Census](docs/Census.md)
 - [Model.ChannelPreferencesTheme](docs/ChannelPreferencesTheme.md)
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
 - [Model.CrimeRiskResponse](docs/CrimeRiskResponse.md)
 - [Model.Crs](docs/Crs.md)
 - [Model.CustomObject](docs/CustomObject.md)
 - [Model.CustomObjectMember](docs/CustomObjectMember.md)
 - [Model.Demographics](docs/Demographics.md)
 - [Model.DemographicsThemes](docs/DemographicsThemes.md)
 - [Model.Dictionary](docs/Dictionary.md)
 - [Model.DirectionGeometry](docs/DirectionGeometry.md)
 - [Model.Distance](docs/Distance.md)
 - [Model.EarthquakeRiskResponse](docs/EarthquakeRiskResponse.md)
 - [Model.EducationalAttainmentTheme](docs/EducationalAttainmentTheme.md)
 - [Model.EthnicityTheme](docs/EthnicityTheme.md)
 - [Model.EventsCount](docs/EventsCount.md)
 - [Model.Field](docs/Field.md)
 - [Model.FieldsMatching](docs/FieldsMatching.md)
 - [Model.FinancialProductsTheme](docs/FinancialProductsTheme.md)
 - [Model.FireDepartment](docs/FireDepartment.md)
 - [Model.FireRiskResponse](docs/FireRiskResponse.md)
 - [Model.FireShed](docs/FireShed.md)
 - [Model.FireStation](docs/FireStation.md)
 - [Model.FireStations](docs/FireStations.md)
 - [Model.FloodBoundary](docs/FloodBoundary.md)
 - [Model.FloodRiskResponse](docs/FloodRiskResponse.md)
 - [Model.FloodZone](docs/FloodZone.md)
 - [Model.GenderTheme](docs/GenderTheme.md)
 - [Model.GeoPos](docs/GeoPos.md)
 - [Model.GeoRiskBoundaries](docs/GeoRiskBoundaries.md)
 - [Model.GeoRiskCrimeTheme](docs/GeoRiskCrimeTheme.md)
 - [Model.GeoRiskGeometry](docs/GeoRiskGeometry.md)
 - [Model.GeoRouteResponse](docs/GeoRouteResponse.md)
 - [Model.GeoTaxLocations](docs/GeoTaxLocations.md)
 - [Model.GeocodeAddress](docs/GeocodeAddress.md)
 - [Model.GeocodeCapabilitiesResponse](docs/GeocodeCapabilitiesResponse.md)
 - [Model.GeocodeRequest](docs/GeocodeRequest.md)
 - [Model.GeocodeServiceResponse](docs/GeocodeServiceResponse.md)
 - [Model.GeocodeServiceResponseList](docs/GeocodeServiceResponseList.md)
 - [Model.Geometry](docs/Geometry.md)
 - [Model.GeometryPolygon](docs/GeometryPolygon.md)
 - [Model.Grid](docs/Grid.md)
 - [Model.HouseholdSizeTheme](docs/HouseholdSizeTheme.md)
 - [Model.IncomeTheme](docs/IncomeTheme.md)
 - [Model.IndexVariable](docs/IndexVariable.md)
 - [Model.IndividualValueVariable](docs/IndividualValueVariable.md)
 - [Model.InputParameter](docs/InputParameter.md)
 - [Model.LatLongFields](docs/LatLongFields.md)
 - [Model.LifeStyleTheme](docs/LifeStyleTheme.md)
 - [Model.Location](docs/Location.md)
 - [Model.Locations](docs/Locations.md)
 - [Model.MaritalStatusTheme](docs/MaritalStatusTheme.md)
 - [Model.Match](docs/Match.md)
 - [Model.Mcd](docs/Mcd.md)
 - [Model.Name](docs/Name.md)
 - [Model.Operation](docs/Operation.md)
 - [Model.OutputParameter](docs/OutputParameter.md)
 - [Model.PSAPResponse](docs/PSAPResponse.md)
 - [Model.Place](docs/Place.md)
 - [Model.PlaceByLocations](docs/PlaceByLocations.md)
 - [Model.PlaceByLocationsLocation](docs/PlaceByLocationsLocation.md)
 - [Model.PlaceLocation](docs/PlaceLocation.md)
 - [Model.PlaceLocationName](docs/PlaceLocationName.md)
 - [Model.Poi](docs/Poi.md)
 - [Model.Point](docs/Point.md)
 - [Model.Points](docs/Points.md)
 - [Model.Polygon](docs/Polygon.md)
 - [Model.Preferences](docs/Preferences.md)
 - [Model.PrimaryZone](docs/PrimaryZone.md)
 - [Model.Properties](docs/Properties.md)
 - [Model.PurchasingBehaviorTheme](docs/PurchasingBehaviorTheme.md)
 - [Model.RaceTheme](docs/RaceTheme.md)
 - [Model.RangeVariable](docs/RangeVariable.md)
 - [Model.RateCenterResponse](docs/RateCenterResponse.md)
 - [Model.ReturnFieldsDescriptor](docs/ReturnFieldsDescriptor.md)
 - [Model.ReverseGeocodeRequest](docs/ReverseGeocodeRequest.md)
 - [Model.Risk](docs/Risk.md)
 - [Model.RouteDirection](docs/RouteDirection.md)
 - [Model.RouteDirections](docs/RouteDirections.md)
 - [Model.RouteGeometry](docs/RouteGeometry.md)
 - [Model.SalesTax](docs/SalesTax.md)
 - [Model.Segmentation](docs/Segmentation.md)
 - [Model.SegmentationThemes](docs/SegmentationThemes.md)
 - [Model.SiteDetails](docs/SiteDetails.md)
 - [Model.SpecialPurposeDistrict](docs/SpecialPurposeDistrict.md)
 - [Model.SpecialPurposeDistrictTax](docs/SpecialPurposeDistrictTax.md)
 - [Model.State](docs/State.md)
 - [Model.Status](docs/Status.md)
 - [Model.SupportLevel](docs/SupportLevel.md)
 - [Model.TaxAddress](docs/TaxAddress.md)
 - [Model.TaxAddressRequest](docs/TaxAddressRequest.md)
 - [Model.TaxJurisdiction](docs/TaxJurisdiction.md)
 - [Model.TaxLocationRequest](docs/TaxLocationRequest.md)
 - [Model.TaxRateAddress](docs/TaxRateAddress.md)
 - [Model.TaxRateAddressRequest](docs/TaxRateAddressRequest.md)
 - [Model.TaxRateLocationRequest](docs/TaxRateLocationRequest.md)
 - [Model.TaxResponse](docs/TaxResponse.md)
 - [Model.TaxResponses](docs/TaxResponses.md)
 - [Model.Time](docs/Time.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.TravelBoundaries](docs/TravelBoundaries.md)
 - [Model.TravelBoundary](docs/TravelBoundary.md)
 - [Model.TravelCostMatrixResponse](docs/TravelCostMatrixResponse.md)
 - [Model.TravelCostMatrixResponseEndPoint](docs/TravelCostMatrixResponseEndPoint.md)
 - [Model.TravelCostMatrixResponseEndPointCrs](docs/TravelCostMatrixResponseEndPointCrs.md)
 - [Model.TravelCostMatrixResponseEndPointCrsProperties](docs/TravelCostMatrixResponseEndPointCrsProperties.md)
 - [Model.TravelCostMatrixResponseMatrix](docs/TravelCostMatrixResponseMatrix.md)
 - [Model.UseTax](docs/UseTax.md)


## Documentation for Authorization

### oAuth2Password

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: N/A
