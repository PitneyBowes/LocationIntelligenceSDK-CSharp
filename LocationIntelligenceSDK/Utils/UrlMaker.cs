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
using System.Diagnostics;


namespace com.pb.locationintelligence.utils
{
    /// <summary>
    /// Class with information regarding location Intelligence Base URL and helps in URL encoding and URL creation
    /// </summary>
    public class UrlMaker {


        /// <summary>
        /// The _ URL maker reference
        /// </summary>
        private static UrlMaker _UrlMakerReference = null;
        /// <summary>
        /// The strategy
        /// </summary>
        private UrlStrategy strategy=null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlMaker"/> class.
        /// </summary>
        /// <param name="strategy">The strategy.</param>
        private UrlMaker(UrlStrategy strategy) {
		this.strategy = strategy;
	}

        /// <summary>
        /// Sets the URL strategy.
        /// </summary>
        /// <param name="strategy">The strategy.</param>
        /// <exception cref="System.ArgumentException">Cannot set Null strategy</exception>
        public void setUrlStrategy(UrlStrategy strategy){
		if(strategy == null){
			throw new ArgumentException("Cannot set Null strategy");
		}
		this.strategy = strategy;
	}

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static UrlMaker getInstance() {

		if (_UrlMakerReference == null)
			_UrlMakerReference = new UrlMaker(new UrlStrategy());
		return _UrlMakerReference;
	}

        /// <summary>
        /// Gets the absolute URL.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <returns></returns>
        public String getAbsoluteUrl(String relativeUrl) {
		return strategy.getAbsoluteUrl(relativeUrl);
	}

        /// <summary>
        /// Gets the encoded URL.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public String getEncodedURL(String param){
		 String url = null;
			try {
				url =  System.Web.HttpUtility.UrlEncode(param, new System.Text.UTF8Encoding());
			} catch (InvalidOperationException e) {
                Debug.WriteLine("Unsupported Encoding Exception " + e);
			}
			return url;
	}

        /// <summary>
        /// 
        /// </summary>
        public class UrlStrategy
	{


            /// <summary>
            /// The bas e_ URL
            /// </summary>
            public static  String BASE_URL = "https://api.pitneybowes.com/";
            /// <summary>
            /// The relativ e_ path
            /// </summary>
            public static readonly String RELATIVE_PATH = "location-intelligence";

            /// <summary>
            /// Gets the absolute URL.
            /// </summary>
            /// <param name="relativeUrl">The relative URL.</param>
            /// <returns></returns>
            public virtual String getAbsoluteUrl(String relativeUrl)
		{
			if (relativeUrl.Contains("oauth"))
			{
				return BASE_URL + relativeUrl;
			}
			return BASE_URL + RELATIVE_PATH + relativeUrl;
		}

	}

}

}