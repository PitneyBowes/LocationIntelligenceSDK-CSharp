#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.common.model;
using com.pb.locationintelligence.common;
using com.pb.locationintelligence.utils;

using System;
using System.Collections.Specialized;
using System.Text;
using System.Web.Script.Serialization;
using System.Diagnostics;
using com.pb.locationintelligence.exception;

namespace com.pb.locationintelligence.oauth

{

    /// <summary>
    /// Implementation of BaseOAuthService interface. Get the access token for authentication
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.oauth.OAuthService" />
    /// <seealso cref="com.pb.locationintelligence.oauth.BaseOAuthService" />
    public class BaseOAuthServiceImpl : OAuthService , BaseOAuthService {


        /// <summary>
        /// The consumer key
        /// </summary>
        private String consumerKey;
        /// <summary>
        /// The consumer secret key
        /// </summary>
        private String consumerSecretKey;
        /// <summary>
        /// The token regeneration
        /// </summary>
        private Boolean tokenRegeneration = true;
        /// <summary>
        /// The o authentication URL
        /// </summary>
        private String oAuthUrl = "oauth/token";

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOAuthServiceImpl"/> class.
        /// </summary>
        /// <param name="consumerKey">The consumer key.</param>
        /// <param name="consumerSecretKey">The consumer secret key.</param>
        public BaseOAuthServiceImpl(String consumerKey, String consumerSecretKey) {
		
		this.consumerKey = consumerKey;
		this.consumerSecretKey = consumerSecretKey;
	}

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOAuthServiceImpl"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        public BaseOAuthServiceImpl(String token) {
		
		this.tokenRegeneration = false;
		setAuthToken(token);
	}


        /// <summary>
        /// Gets the authentication token.
        /// </summary>
        /// <returns></returns>
        public override String getAuthenticationToken() {
		String authToken=getToken();
		JavaScriptSerializer serializer = new JavaScriptSerializer();
        Debug.WriteLine("It seems token is not generated yet, Going for OAuth mechanism");
		// Token is not generated yet
		if (authToken == null && tokenRegeneration) {
			try{
				UrlMaker maker = UrlMaker.getInstance();
				String url = maker.getAbsoluteUrl(oAuthUrl);

				String authHeader = Constants.BASIC + Convert.ToBase64String(Encoding.UTF8.GetBytes(consumerKey + ":" + consumerSecretKey));
				Uri uri = new Uri(url);

				using (ExtendedWebClient webClient = new ExtendedWebClient(uri))
				{
					NameValueCollection headers= new NameValueCollection();

					headers.Add(Constants.AUTH_HEADER,authHeader);
					webClient.Headers.Add(headers);

					string jsonResponse=webClient.UploadString(url, Constants.GRANT_TYPE+"="+Constants.CLIENT_CREDENTIALS);

					OAuthServiceResponse oAuthServiceResponse = serializer.Deserialize<OAuthServiceResponse>(jsonResponse);
					authToken = Constants.BEARER + oAuthServiceResponse.access_token;
				
				}

			}
			
			catch(Exception e){
                Debug.WriteLine("Unexpected Exception while generating token, so Invalidating the Authentication Token" + e);
                invalidateLIServiceManagerInstance();
                throw new SdkException( new SdkInternalError(e.Message));
				
			}
		}
		
		return authToken;
	}


        /// <summary>
        /// Invalidates the li service manager instance.
        /// </summary>
        void BaseOAuthService.invalidateLIServiceManagerInstance()
    {
        if (getToken() != null)
        {
            setAuthToken(null);
        }

    }
}
}