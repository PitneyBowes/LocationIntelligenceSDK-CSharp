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
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using System.Configuration;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.pb.locationintelligence.utils;

namespace LocationIntelligenceSDKTest
{
    public class TestUtility
    {
        private static String AUTH_HEADER = "Authorization";
        private static String DEFAULT_MEDIA_TYPE = "application/json";

        public static String getJSONResponseFromAPI(String baseURL,String serviceEndPoint,Dictionary<String,Object> keyValueMap) {
		    StringBuilder URL = new StringBuilder(baseURL + serviceEndPoint);
		    Utility.appendIfNotNull(URL, keyValueMap);
	    return MakeRequest(DEFAULT_MEDIA_TYPE, URL.ToString());
     }

    /**
		 * Generic client for HTTP Web Request execution.This method returns response of the web request submitted to it.
		 * @param ContentType
		 * @param EndPoint
		 * @param parameters
		 * @param accesstoken
		 * @param HttpMethod
		 * @param PostData
		 */
		private static String MakeRequest(string acceptHttpHeader, string url, string httpMethod = "GET", string postData = null)
		{
			var responseValue = string.Empty;
			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = httpMethod;
			request.ContentLength = 0;
			request.Accept = acceptHttpHeader;
			request.Headers.Add(AUTH_HEADER, "");
			try
			{
				using (var response = (HttpWebResponse)request.GetResponse())
				{
					if (response.StatusCode != HttpStatusCode.OK)
					{
						var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
						throw new ApplicationException(message);
					}

					// grab the response
					using (var responseStream = response.GetResponseStream())
					{
						if (responseStream != null)
							using (var reader = new StreamReader(responseStream))
							{
								responseValue = reader.ReadToEnd();
							}
					}

					
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

			}
			return responseValue;
		}

    }
}
 