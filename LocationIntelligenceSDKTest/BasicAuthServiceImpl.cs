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
using com.pb.locationintelligence.utils;


namespace com.pb.locationintelligence.oauth
{
/**
 * This class is used for returning token for Basic Auth. 
 *
 * 
 */
public class BasicAuthServiceImpl : OAuthService , BaseOAuthService {

	
	private String authToken;
   
	
	/**
	 * @param token
	 * @param url
	 */
	private class UrlStrategyTest:UrlMaker.UrlStrategy
	{
		new public String  BASE_URL = String.Empty;
		public UrlStrategyTest(String url)
		{
			BASE_URL = url;
		}
		
		 public override string getAbsoluteUrl(String relativeUrl) 
         {
				
             return BASE_URL + "" + relativeUrl;
			 }
	}


	public BasicAuthServiceImpl(String token, String url) {
		authToken = token;

		UrlMaker.getInstance().setUrlStrategy(new UrlStrategyTest(url));
		
	}
	
	public override String getAuthenticationToken() {
		 setAuthToken(authToken);
		 return getToken();
	}


	

}

}