#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.locationintelligence.utils;

using System;
using System.Diagnostics;

namespace com.pb.locationintelligence.oauth
{

    /// <summary>
    /// Stores Token Information to be used across and invalidate it if required.
    /// </summary>
    /// <seealso cref="com.pb.locationintelligence.oauth.BaseOAuthService" />
    public class OAuthService : BaseOAuthService{


        /// <summary>
        /// The authentication token
        /// </summary>
        private static String authToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthService"/> class.
        /// </summary>
        public OAuthService()
	{
		
	}

        /// <summary>
        /// returns token as String.
        /// </summary>
        /// <returns>
        /// token as String
        /// </returns>
        public virtual String getAuthenticationToken()
	{
		if (authToken != null) {
            Debug.WriteLine("Token is already generated");
		}
		else{
			authToken = OAuthFactory.getOAuthService().getAuthenticationToken();
		}
		return authToken;
	}




        /// <summary>
        /// Sets the authentication token.
        /// </summary>
        /// <param name="token">The token.</param>
        protected void setAuthToken(String token){
		authToken = Constants.BEARER+token;
	}

        /// <summary>
        /// Determines whether [is token available].
        /// </summary>
        /// <returns></returns>
        public Boolean isTokenAvailable(){
		return !String.IsNullOrEmpty(authToken);
	}

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <returns></returns>
        public String getToken(){
		if(authToken!=null){
			return authToken;
		}
		return null;
	}






        /// <summary>
        /// Invalidates the access token.
        /// </summary>
        public virtual void invalidateLIServiceManagerInstance()
    {
        if (authToken != null)
        {
            authToken = null;
            Debug.WriteLine("Token has been deleted");
        }
    }
}
}
