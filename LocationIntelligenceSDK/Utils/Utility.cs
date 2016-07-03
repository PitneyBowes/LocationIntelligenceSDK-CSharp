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
using com.pb.locationintelligence.exception;
using com.pb.locationintelligence.oauth;
using com.pb.locationintelligence.geocode.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace com.pb.locationintelligence.utils
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="url">The URL.</param>
    /// <param name="httpVerb">The HTTP verb.</param>
    /// <param name="payload">The payload.</param>
    /// <returns></returns>
    internal delegate  T processAPIRequestDelegate<T> (String url,Utility.HttpVerb httpVerb,String payload);

    /// <summary>
    /// 
    /// </summary>
    public class Utility {



        /// <summary>
        /// The county code map
        /// </summary>
        private static Dictionary<Country, string> countyCodeMap = new Dictionary<Country, string> {
            {Country.AMERICAN_SAMOA ,"USA"},
            {Country.ANDORRA, "AND"},
            {Country.ANGOLA, "AGO"},
            {Country.ARGENTINA , "ARG"},
            {Country.ARUBA, "ABW"},
            {Country.AUSTRALIA, "AUS"},
            {Country.AUSTRIA, "AUT"},
            {Country.BAHAMAS, "BHS"},
            {Country.BAHRAIN, "BHR"},
            {Country.BARBADOS, "BRB"},
            {Country.BELGIUM, "BEL"},
            {Country.BELIZE, "BLZ"},
            {Country.BENIN, "BEN"},
            {Country.BERMUDA, "BMU"},
            {Country.BOLIVIA, "BOL"},
            {Country.BOTSWANA, "BWA"},
            {Country.BRAZIL, "BRA"},
            {Country.BURKINA_FASO, "BFA"},
            {Country.BURUNDI, "BDI"},
            {Country.CAMEROON, "CMR"},
            {Country.CANADA, "CAN"},
            {Country.CHILE, "CHL"},
            {Country.CHINA, "CHN"},
            {Country.CONGO, "COG"},
            {Country.DEMOCRATIC_REPUBLIC_OF_CONGO, "COD"},
            {Country.COSTA_RICA, "CRI"},
            {Country.CROATIA, "HRV"},
            {Country.CUBA, "CUB"},
            {Country.CZECH_REPUBLIC, "CZE"},
            {Country.DENMARK, "DNK"},
            {Country.DOMINICAN_REPUBLIC, "DOM"},
            {Country.ECUADOR, "ECU"},
            {Country.EGYPT, "EGY"},
            {Country.EL_SALVADOR, "SLV"},
            {Country.ESTONIA, "EST"},
            {Country.FINLAND, "FIN"},
            {Country.FRANCE , "FRA"},
            {Country.FRENCH_GUYANA, "GUF"},
            {Country.GABON, "GAB"},
            {Country.GERMANY, "DEU"},
            {Country.GHANA, "GHA"},
            {Country.GREAT_BRITAIN, "GBR"},
            {Country.GREECE, "GRC"},
            {Country.GUADELOUPE, "GLP"},
            {Country.GUAM, "USA"},
            {Country.GUATEMALA, "GTM"},
            {Country.GUYANA, "GUY"},
            {Country.HONDURAS, "HND"},
            {Country.HONG_KONG, "HKG"},
            {Country.HUNGARY , "HUN"},
            {Country.ICELAND, "ISL"},
            {Country.INDIA , "IND"},
            {Country.INDONESIA, "IDN"},
            {Country.IRELAND, "IRL"},
            {Country.ITALY, "ITA"},
            {Country.JAMAICA, "JAM"},
            {Country.JAPAN, "JPN"},
            {Country.KENYA, "KEN"},
            {Country.KUWAIT, "KWT"},
            {Country.LATVIA, "LVA"},
            {Country.LEBANON, "LBN"},
            {Country.LESOTHO, "LSO"},
            {Country.LIECHTENSTEIN  , "LIE"},
            {Country.LITHUANIA, "LTU"},
            {Country.LUXEMBOURG, "LUX"},
            {Country.MACAO, "MAC"},
            {Country.MALAWI , "MWI"},
            {Country.MALAYSIA, "MYS"},
            {Country.MALI , "MLI"},
            {Country.MARTINIQUE, "MTQ"},
            {Country.MAURITANIA, "MRT"},
            {Country.MAURITIUS, "MUS"},
            {Country.MAYOTTE, "MYT"},
            {Country.MEXICO, "MEX"},
            {Country.MONACO, "MCO"},
            {Country.MOROCCO, "MAR"},
            {Country.MOZAMBIQUE, "MOZ"},
            {Country.NAMIBIA, "NAM"},
            {Country.NETHERLANDS, "NLD"},
            {Country.NEW_ZEALAND, "NZL"},
            {Country.NICARAGUA, "NIC"},
            {Country.NIGER, "NER"},
            {Country.NIGERIA, "NGA"},
            {Country.NORTH_MARIANA_ISLANDS, "USA"},
            {Country.NORWAY, "NOR"},
            {Country.OMAN, "OMN"},
            {Country.PALAU, "USA"},
            {Country.PANAMA, "PAN"},
            {Country.PARAGUAY, "PRY"},
            {Country.PERU, "PER"},
            {Country.PHILIPPINES, "PHL"},
            {Country.POLAND, "POL"},
            {Country.PORTUGAL, "PRT"},
            {Country.PUERTO_RICO, "USA"},
            {Country.QATAR, "QAT"},
            {Country.REUNION, "REU"},
            {Country.ROMANIA, "ROU"},
            {Country.RUSSIAN_FEDERATION, "RUS"},
            {Country.RWANDA, "RWA"},
            {Country.SAINT_KITTS_AND_NEVIS, "KNA"},
            {Country.SAUDI_ARABIA, "SAU"},
            {Country.SENEGAL, "SEN"},
            {Country.SINGAPORE, "SGP"},
            {Country.SLOVAKIA, "SVK"},
            {Country.SLOVENIA, "SVN"},
            {Country.SOUTH_AFRICA, "ZAF"},
            {Country.SPAIN, "ESP"},
            {Country.SURINAME, "SUR"},
            {Country.SWAZILAND, "SWZ"},
            {Country.SWEDEN, "SWE"},
            {Country.SWITZERLAND, "CHE"},
            {Country.TAIWAN, "TWN"},
            {Country.UNITED_REPUBLIC_OF_TANZANIA, "TZA"},
            {Country.THAILAND, "THA"},
            {Country.TOGO, "TGO"},
            {Country.TRINIDAD_AND_TOBAGO, "TTO"},
            {Country.TUNISIA, "TUN"},
            {Country.TURKEY, "TUR"},
            {Country.UGANDA, "UGA"},
            {Country.UKRAINE, "UKR"},
            {Country.UNITED_ARAB_EMIRATES, "ARE"},
            {Country.UNITED_KINGDOM , "GBR"},
            {Country.UNITED_STATES, "USA"},
            {Country.URUGUAY, "URY"},
            {Country.VENEZUELA, "VEN"},
            {Country.VIRGIN_ISLANDS, "USA"},
            {Country.WORLD_GEOCODER, "XWG"},
            {Country.ZAMBIA, "ZMB"},
            {Country.ZIMBABWE , "ZWE"}
                        };

        /// <summary>
        /// 
        /// </summary>
        public enum HttpVerb
        {
            /// <summary>
            /// The get
            /// </summary>
            Get,
            /// <summary>
            /// The post
            /// </summary>
            Post
        }



        /// <summary>
        /// Appends if not null.
        /// </summary>
        /// <param name="urlToAppendTo">The URL to append to.</param>
        /// <param name="queryParametersMap">The query parameters map.</param>
        public static void appendIfNotNull(StringBuilder urlToAppendTo, Dictionary<String,Object> queryParametersMap)
   {
	   if(urlToAppendTo==null || queryParametersMap==null || queryParametersMap.Count<1) return;

	   Boolean firstParam = true;

	   foreach(String key in queryParametersMap.Keys)
	   {
		   object value;
		   if(queryParametersMap.TryGetValue(key, out value ))

		   if(value!=null)
		   {
			   String separator;
			   if(firstParam){separator="?";}else{separator="&";}
			   String encodedParam = getEncodedParam(value.ToString());
			   if(encodedParam!=null)
			   {
				   urlToAppendTo.Append(separator).Append(key).Append("=").Append(encodedParam);
				   firstParam=false;
			   }
		   }
	   }

   }

        /// <summary>
        /// Gets the encoded parameter.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns></returns>
        public static String getEncodedParam(String param)
	{
		String encodedParam = null;
		try {
			
			encodedParam =System.Web.HttpUtility.UrlEncode(param, new System.Text.UTF8Encoding());
		} catch (Exception e) {
			
                Debug.WriteLine("Unsupported Encoding Exception " + e.Message);
		}
		return encodedParam;
	}

        /// <summary>
        /// Processes the API request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="httpVerb">The HTTP verb.</param>
        /// <param name="Payload">The payload.</param>
        /// <returns></returns>
        public static  T processAPIRequest<T> (String url, HttpVerb httpVerb , String Payload) {
		T response ;
		SdkException exception = null;
		String JsonResponse=String.Empty;
		JavaScriptSerializer serializer= new JavaScriptSerializer();
       try
		{
            String accessToken = OAuthFactory.getOAuthService().getAuthenticationToken();
            Uri uri = new Uri(url);
			using (ExtendedWebClient client = new ExtendedWebClient(uri))
			{
				client.Headers.Add(Constants.AUTH_HEADER, accessToken);
				client.Headers.Add(HttpRequestHeader.Accept, Constants.HTTP_HEADER_VALUE_JSON);


                    if (httpVerb.Equals(HttpVerb.Get))
                    {

                    JsonResponse = client.DownloadString(url);
				    response = (T)serializer.Deserialize<T>(JsonResponse);
                    }
                    else
                    {
                        client.Headers.Add(HttpRequestHeader.ContentType, Constants.HTTP_HEADER_VALUE_JSON);
                        JsonResponse = client.UploadString(url,Payload);
     
                        response = (T)serializer.Deserialize<T>(JsonResponse);
                    }


                 Debug.WriteLine("Got a valid response from API");
			}
			
			return response;
		}
		
		catch (WebException webException)
		{
            Debug.WriteLine("Got an error response from API" + webException);
			string responseText=string.Empty;
			int statusCode=0;

			if (webException.Response != null)
			{
				var responseStream = webException.Response.GetResponseStream();
				statusCode = (int)((HttpWebResponse)webException.Response).StatusCode;
				
				using (var reader = new StreamReader(responseStream))
				{
					responseText = reader.ReadToEnd();
				}
				try
				{
					Object errObj = serializer.DeserializeObject(responseText);
					ErrorInfo apiError = serializer.Deserialize<ErrorInfo>(responseText);
					apiError.HttpStatusCode = statusCode;
					apiError.Reason = webException.Message;
					apiError.JsonResponse = responseText;
					exception = new SdkException(apiError);


				}
				catch (Exception e)
				{
                    Debug.WriteLine("Unexpected Error: " + e);
					exception = new SdkException(new SdkInternalError(Constants.ERROR_MSG_API_PROCESSING, e));
				}
			}
			else
			{
                Debug.WriteLine("Unexpected Error: " + webException);
				exception = new SdkException(new SdkInternalError(Constants.ERROR_MSG_API_PROCESSING, webException));
			}
			
		}
		catch(Exception e){
            Debug.WriteLine("Unexpected Error: " + e);
			exception = new SdkException(new SdkInternalError(Constants.ERROR_MSG_API_PROCESSING, e));
		}

		throw exception;
		
	}


        /// <summary>
        /// Prints the object as json.
        /// </summary>
        /// <param name="objects">The objects.</param>
        public static void printObjectAsJson(Object objects)
	{

		JavaScriptSerializer serializer = new JavaScriptSerializer();
		string json=serializer.Serialize(objects);
		Console.WriteLine(json);
		
	}

        /// <summary>
        /// Gets the country code.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        public static string getCountryCode(Country? country)
        {
            int EnumVal = country==null ? -1 : (int)country.Value;

            if (EnumVal != -1)
            {
                return countyCodeMap[((Country)EnumVal)];
            }
            else
            {
                return String.Empty;
            }
        }


        /// <summary>
        /// Gets the preferred dictionary order list.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <returns></returns>
        public static List<String> getPreferredDictionaryOrderList(Dictionary<Country, int[]> dictionary)
        {
            List<String> arrayDicOrder = new List<String>();

            foreach (var element in dictionary)
            {
                arrayDicOrder.Add(getCountryCode(element.Key));

                foreach (var orderNumber in element.Value)
                {
                    arrayDicOrder.Add(orderNumber.ToString());
                }
            }
            return arrayDicOrder;
        }

        /// <summary>
        /// Gets the returned custom fields keys.
        /// </summary>
        /// <param name="returnedCustomFieldsKeys">The returned custom fields keys.</param>
        /// <returns></returns>
        public static String GetReturnedCustomFieldsKeys(ReturnedCustomFieldsKeys returnedCustomFieldsKeys)
        {
            return returnedCustomFieldsKeys.ToString().Substring(4, returnedCustomFieldsKeys.ToString().Length-4);
        }

    }
    
}