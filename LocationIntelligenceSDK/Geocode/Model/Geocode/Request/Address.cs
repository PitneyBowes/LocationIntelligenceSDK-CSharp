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
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.pb.locationintelligence.geocode.model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract (Name="address")]
    public class Address
    {



        /**
         * Gets the value of the mainAddressLine property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember (Name = "mainAddressLine")]
        public String MainAddressLine
        {
            get; set;
        }


        /**
         * Gets the value of the addressLastLine property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "addressLastLine")]
        public String AddressLastLine
        {
            get; set;
        }



        /**
         * Gets the value of the placeName property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "placeName")]
        public String PlaceName
        {
            get; set;
        }


        /**
         * Gets the value of the areaName1 property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "areaName1")]
        public String AreaName1
        {
            get; set;
        }


        /**
         * Gets the value of the areaName2 property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "areaName2")]
        public String AreaName2
        {
            get; set;
        }

        /**
         * Sets the value of the areaName2 property.
         * 
         * @param value
         *     allowed object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "areaName3")]
        public String AreaName3
        {
            get; set;
        }


        /**
         * Gets the value of the areaName4 property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "areaName4")]
        public String AreaName4
        {
            get; set;
        }



        /**
         * Gets the value of the postCode1 property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "postCode1")]
        public String PostCode1
        {
            get; set;
        }



        /**
         * Gets the value of the postCode2 property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "postCode2")]
        public String PostCode2
        {
            get; set;
        }



        /**
         * Gets the value of the country property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "country")]
        public String Country
        {
            get; set;
        }
    


        /**
         * Gets the value of the addressNumber property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "addressNumber")]
        public String AddressNumber
        {
            get; set;
        }



        /**
         * Gets the value of the streetName property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "streetName")]
        public String StreetName
        {
            get; set;
        }



        /**
         * Gets the value of the unitType property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "unitType")]
        public String UnitType
        {
            get; set;
        }



        /**
         * Gets the value of the unitValue property.
         * 
         * @return
         *     possible object is
         *     {@link String }
         *     
         */
        [DataMember(Name = "unitValue")]
        public String UnitValue
        {
            get; set;
        }



        



    }
}
