#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using System;

namespace com.pb.locationintelligence.utils
{

    /// <summary>
    /// Constants Interface
    /// </summary>
    public static class Constants
    {

        /// <summary>
        /// The acces s_ token
        /// </summary>
        public static readonly String ACCESS_TOKEN = "access_token";

        /// <summary>
        /// The bearer
        /// </summary>
        public static readonly String BEARER = "Bearer ";

        /// <summary>
        /// The basic
        /// </summary>
        public static readonly String BASIC = "Basic ";

        /// <summary>
        /// The clien t_ credentials
        /// </summary>
        public static readonly String CLIENT_CREDENTIALS = "client_credentials";

        /// <summary>
        /// The gran t_ type
        /// </summary>
        public static readonly String GRANT_TYPE = "grant_type";

        /// <summary>
        /// The aut h_ header
        /// </summary>
        public static readonly String AUTH_HEADER = "Authorization";

        /// <summary>
        /// The colon
        /// </summary>
        public static readonly String COLON = ":";

        /// <summary>
        /// The erro r_ ms g_ addres s_ required
        /// </summary>
        public static readonly String ERROR_MSG_ADDRESS_REQUIRED = "Address is a required parameter and cannot be null";

        /// <summary>
        /// The erro r_ ms g_ latitud e_ required
        /// </summary>
        public static readonly String ERROR_MSG_LATITUDE_REQUIRED = "Latitude is a required parameter and cannot be null";

        /// <summary>
        /// The erro r_ ms g_ longitud e_ required
        /// </summary>
        public static readonly String ERROR_MSG_LONGITUDE_REQUIRED = "Longitude is a required parameter and cannot be null";

        /// <summary>
        /// The erro r_ ms g_ ap i_ processing
        /// </summary>
        public static readonly String ERROR_MSG_API_PROCESSING = "Unexpected Error while processing the API Request";

        /// <summary>
        /// The erro r_ ms g_ toke n_ invalid
        /// </summary>
        public static readonly String ERROR_MSG_TOKEN_INVALID = "Token is expired or not set.";

        /// <summary>
        /// The HTT p_ heade r_ valu e_ json
        /// </summary>
        public static readonly String HTTP_HEADER_VALUE_JSON = "application/json";
        /// <summary>
        /// The invali d_ custo m_ bas e_ URL
        /// </summary>
        public static readonly String INVALID_CUSTOM_BASE_URL = "Invalid Custom Base Url";

        /// <summary>
        /// The geo code dictionaries URL
        /// </summary>
        public static readonly String geoCodeDictionariesUrl = "/geocode-service/v1/transient/{0}/dictionaries";
        /// <summary>
        /// The geo code configurations URL
        /// </summary>
        public static readonly String geoCodeConfigurationsUrl = "/geocode-service/v1/transient/{0}/capabilities";
        /// <summary>
        /// The FWRD geo code service
        /// </summary>
        public static readonly String fwrdGeoCodeService = "/geocode-service/v1/transient/{0}/geocode";
        /// <summary>
        /// The reverse geocodegeo code
        /// </summary>
        public static readonly String reverseGeocodegeoCode = "/geocode-service/v1/transient/{0}/reverseGeocode";

        /// <summary>
        /// The geo taxbatch tax rate address service
        /// </summary>
        public static readonly String geoTaxbatchTaxRateAddressService = "/geotax/v1/taxrate/{0}/byaddress";
        /// <summary>
        /// The geo taxbatch tax address service
        /// </summary>
        public static readonly String geoTaxbatchTaxAddressService = "/geotax/v1/tax/{0}/byaddress";
        /// <summary>
        /// The geo taxbatch tax ratelocation service
        /// </summary>
        public static readonly String geoTaxbatchTaxRatelocationService = "/geotax/v1/taxrate/{0}/bylocation";
        /// <summary>
        /// The geo taxbatch taxlocation service
        /// </summary>
        public static readonly String geoTaxbatchTaxlocationService = "/geotax/v1/tax/{0}/bylocation";

    }
}