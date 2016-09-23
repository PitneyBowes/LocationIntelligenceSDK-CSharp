#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.geo911;
using com.pb.locationintelligence.geoenhance;
using com.pb.locationintelligence.geolifeDemographics;
using com.pb.locationintelligence.geosearch;
using com.pb.locationintelligence.geotax;
using com.pb.locationintelligence.geocomm;
using com.pb.locationintelligence.geocode;
using com.pb.locationintelligence.oauth;

using com.pb.locationintelligence.utils;
using System.Configuration;
using System;
using System.Diagnostics;
using System.Security.Policy;
using com.pb.locationintelligence.exception;

namespace com.pb.locationintelligence.manager

{
    /// <summary>
    /// LIServiceManager class is responsible for providing entry point all LI specific
    /// interfaces.It provides singleton object for this class
    /// </summary>
    public class LIServiceManager {


        /// <summary>
        /// The _ li service manager
        /// </summary>
        private static LIServiceManager _LIServiceManager = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="LIServiceManager" /> class from being created.
        /// </summary>
        private LIServiceManager() {
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["BASE_URL"]))
            {

                String url = ConfigurationManager.AppSettings["BASE_URL"];

               if(!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    SdkException sdkException = new SdkException(new common.model.SdkInternalError( Constants.INVALID_CUSTOM_BASE_URL));
                    throw sdkException;
                }


                UrlMaker.UrlStrategy.BASE_URL = ConfigurationManager.AppSettings["BASE_URL"];
            }
           
	}


        /// <summary>
        /// Gets the instance of LIServiceManager.
        /// </summary>
        /// <param name="baseOAuthService">The base oAuth service.</param>
        /// <returns>
        /// LIServiceManager
        /// </returns>
        public static  LIServiceManager getInstance(BaseOAuthService baseOAuthService) {
		if (_LIServiceManager == null) {
			 OAuthFactory.setInstance(baseOAuthService);
			_LIServiceManager = new LIServiceManager();
            Debug.WriteLine("LI Service instance has been created");
		}
        Debug.WriteLine("LI Service instance has been already created");
		return _LIServiceManager;
	}


        /// <summary>
        /// Method to initialize LI interfaces with user login credentials.
        /// </summary>
        /// <param name="consumerKey">The consumer key.</param>
        /// <param name="consumerSecretKey">The consumer secret key.</param>
        /// <returns>
        /// LIServiceManager
        /// </returns>
        public static  LIServiceManager getInstance(String consumerKey, String consumerSecretKey ) {
		if (_LIServiceManager == null) {
			 OAuthFactory.setInstance(new BaseOAuthServiceImpl(consumerKey, consumerSecretKey));
			_LIServiceManager = new LIServiceManager();
            Debug.WriteLine("LI Service instance has been created");
		}
        Debug.WriteLine("LI Service instance has been already created");
		return _LIServiceManager;

	}


        /// <summary>
        /// Method to initialize LI services with a user supplied token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>
        /// LIServiceManager
        /// </returns>
        public static  LIServiceManager getInstance(String token) {
		if (_LIServiceManager == null) {
			 OAuthFactory.setInstance(new BaseOAuthServiceImpl(token));
			_LIServiceManager = new LIServiceManager();
            Debug.WriteLine("LI Service instance has been created");
		}
        Debug.WriteLine("LI Service instance has been already created");
		return _LIServiceManager;

	}


        /// <summary>
        /// OAuth Service APIs Handler.
        /// </summary>
        /// <returns>
        /// an instance of BaseOAuthService
        /// </returns>
        public BaseOAuthService getBaseAuthService() {
		return new OAuthService();
	}

        /// <summary>
        /// GeoLife Service Handler.
        /// </summary>
        /// <returns>
        /// an instance of GeoLifeService
        /// </returns>
        public GeoLifeService getGeoLifeService() {
		return new GeoLifeServiceImpl();
	}


        /// <summary>
        /// Locations Service Handler.
        /// </summary>
        /// <returns>
        /// an instance of GeoSearchService
        /// </returns>

        public GeoSearchService getGeoSearchService()
	{
		return new GeoSearchServiceImpl();
	}

        /// <summary>
        /// GeoEnhance Service Handler.
        /// </summary>
        /// <returns>
        /// an instance of GeoEnhanceService
        /// </returns>
        public GeoEnhanceService getGeoEnhanceService()
	{
		return new GeoEnhanceServiceImpl();
	}


        /// <summary>
        /// Geo911 Service Handler.
        /// </summary>
        /// <returns>
        /// an instance of Geo911Service
        /// </returns>
        public Geo911Service getGeo911Service() {
		return new Geo911ServiceImpl();
	}

        /// <summary>
        /// GeoTaxService Service Handler.
        /// </summary>
        /// <returns>
        /// an instance of GeoTaxService
        /// </returns>
        public GeoTaxService getGeoTaxService()
	{
		return new GeoTaxServiceImpl();
	}


        /// <summary>
        /// Gets the geocode service.
        /// </summary>
        /// <returns></returns>
        public GeocodeService getGeocodeService()
        {
            return new GeocodeServiceImpl();
        }

        /// <summary>
        /// Gets the geocomm service.
        /// </summary>
        /// <returns></returns>
        public GeoCommService getGeoCommService()
        {
            return new GeoCommServiceImpl();
        }


        /**
         * To invalidate the LI static reference
         */
        /// <summary>
        /// Invalidates the li service manager instance.
        /// </summary>
        public void invalidateLIServiceManagerInstance() {
		if (_LIServiceManager != null) {
			_LIServiceManager = null;
            Debug.WriteLine("LI instance has been invalidated");
		}
	}

}
}