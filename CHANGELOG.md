## 3.6.0 - 2017-08-18
- GeoSearch API - Support for Multi-Line text search
   -Three new parameters are added to the GeoSearch API request. Addition of these parameters supports limiting address search to a state, city, and postcode for more relevant results.

- GeoTax API - New Insurance Premium Districts (IPD) Endpoints Added
  -GET IPD TaxRate - Returns the IPD tax details pertaining to the region in which the input address belongs.
	-POST IPD TaxRate - Returns the IPD tax details pertaining to the region based on the multiple addresses provided as input.

- GeoTime API - Capture detailed timezone information.
  -GeoTime API is available globally. GeoTime API has following endpoints:
  -GET Timezone By Address
  -GET Timezone By Location

- GeoEnrich API - Existing GeoEnhance API renamed to GeoEnrich
 -The GeoEnhance API is renamed to GeoEnrich. GeoEnrich API returns addresses, place names, and business listings with the input of a location coordinate.
 -Timezone By Location endpoint is removed from GeoEnrich API (previously known as GeoEnhance) and made available in GeoTime API.


## 3.5.0 - 2017-06-29
- GeoProperty API - Capture detailed property information for analysis, planning, and decisions
- GeoRisk API  - New Endpoints Added
- GeoSearch API  - Support for IP based location
- GeoCode API  - Added Support to Fetch PBKey from Addresses
- GeoCode API -  Multiple Enhancements
- GeoTax API -   Provision for a Unique 'objectId' in POST Requests

## 3.0.0 - 2017-03-24
- Changes for GeoEnhance
- Added new API GeoRisk
- Added new API GeoRoute
- Added new API GeoZone

## 2.6.0 - 2016-12-13
- Changes for GeoSearch API.

## 2.5.0 - 2016-10-03
- Changes for GeoComm API.
- Changes for AHJ Geo911.
- Changes for GeoTaxBatch.

## 2.0.0 - 2016-08-05
- Moved Segmentation under Geolife to Align LiAPIs also updated Test Cases Accordingly.


## 2.0.0 - 2016-07-04

### Added
- Added 2.0 Version of .Net(CSharp) SDK which has Location Intelligence API features GeoEnhance,GeoLife,GeoSearch,Geo911,GeoTax and Geocode.

