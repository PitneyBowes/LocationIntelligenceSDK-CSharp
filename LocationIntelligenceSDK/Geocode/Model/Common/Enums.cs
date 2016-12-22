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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.pb.locationintelligence.geocode.model
{

    /// <summary>
    /// 
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// The geocode
        /// </summary>
        Geocode,
        /// <summary>
        /// The reverse geocode
        /// </summary>
        ReverseGeocode
    }

    /// <summary>
    /// 
    /// </summary>
    public enum BundleType
    {
        /// <summary>
        /// The basic
        /// </summary>
        basic,
        /// <summary>
        /// The premium
        /// </summary>
        premium
    }


    /// <summary>
    /// 
    /// </summary>
    public enum GeocodeType
    {
        /// <summary>
        /// The address
        /// </summary>
        ADDRESS,
        /// <summary>
        /// The geographic
        /// </summary>
        GEOGRAPHIC,
        /// <summary>
        /// The postal
        /// </summary>
        POSTAL
    }


    /// <summary>
    /// 
    /// </summary>
    public enum MatchMode
    {
        /// <summary>
        /// The exact
        /// </summary>
        Exact,
        /// <summary>
        /// The standard
        /// </summary>
        Standard,
        /// <summary>
        /// The relaxed
        /// </summary>
        Relaxed,
        /// <summary>
        /// The custom
        /// </summary>
        Custom,
        /// <summary>
        /// The interactive
        /// </summary>
        Interactive,
        /// <summary>
        /// The cass
        /// </summary>
        CASS
    }



    /// <summary>
    /// 
    /// </summary>
    public enum ReturnedCustomFieldsKeys
    {
        /// <summary>
        /// The au s_ stree t_ typ e_ abb
        /// </summary>
        AUS_STREET_TYPE_ABB,
        /// <summary>
        /// The au s_ origina l_ latitude
        /// </summary>
        AUS_ORIGINAL_LATITUDE,
        /// <summary>
        /// The au s_ origina l_ longitude
        /// </summary>
        AUS_ORIGINAL_LONGITUDE,
        /// <summary>
        /// The au s_ u d_ origina l_ latitude
        /// </summary>
        AUS_UD_ORIGINAL_LATITUDE,
        /// <summary>
        /// The au s_ u d_ origina l_ longitude
        /// </summary>
        AUS_UD_ORIGINAL_LONGITUDE,
        /// <summary>
        /// The au s_ gna f_ parce l_ identifier
        /// </summary>
        AUS_GNAF_PARCEL_ID,
        /// <summary>
        /// The au s_ gna f_ pid
        /// </summary>
        AUS_GNAF_PID,
        /// <summary>
        /// The au s_ gna f_ principa l_ pid
        /// </summary>
        AUS_GNAF_PRINCIPAL_PID,
        /// <summary>
        /// The au s_ geocontainment
        /// </summary>
        AUS_GEOCONTAINMENT,
        /// <summary>
        /// The au s_ geofeature
        /// </summary>
        AUS_GEOFEATURE,
        /// <summary>
        /// The au s_ gna f_ addres s_ class
        /// </summary>
        AUS_GNAF_ADDRESS_CLASS,
        /// <summary>
        /// The au s_ gna f_ s a1
        /// </summary>
        AUS_GNAF_SA1,
        /// <summary>
        /// The au s_ leve l_ number
        /// </summary>
        AUS_LEVEL_NUMBER,
        /// <summary>
        /// The au s_ leve l_ type
        /// </summary>
        AUS_LEVEL_TYPE,
        /// <summary>
        /// The au s_ lo t_ number
        /// </summary>
        AUS_LOT_NUMBER,
        /// <summary>
        /// The au s_ mes h_ bloc k_ identifier
        /// </summary>
        AUS_MESH_BLOCK_ID,


        /// <summary>
        /// The ca n_ censu s_ cd
        /// </summary>
        CAN_CENSUS_CD,
        /// <summary>
        /// The ca n_ censu s_ cma
        /// </summary>
        CAN_CENSUS_CMA,
        /// <summary>
        /// The ca n_ censu s_ CSD
        /// </summary>
        CAN_CENSUS_CSD,
        /// <summary>
        /// The ca n_ censu s_ ct
        /// </summary>
        CAN_CENSUS_CT,
        /// <summary>
        /// The ca n_ censu s_ da
        /// </summary>
        CAN_CENSUS_DA,
        /// <summary>
        /// The ca n_ formatte d_ stree t_ range
        /// </summary>
        CAN_FORMATTED_STREET_RANGE,

        //usa
        /// <summary>
        /// The us a_ matc h_ code
        /// </summary>
        USA_MATCH_CODE,
        /// <summary>
        /// The us a_ lo c_ code
        /// </summary>
        USA_LOC_CODE,
        /// <summary>
        /// The us a_ m m_ resul t_ code
        /// </summary>
        USA_MM_RESULT_CODE,
        /// <summary>
        /// The us a_ addrline
        /// </summary>
        USA_ADDRLINE,
        /// <summary>
        /// The us a_ city
        /// </summary>
        USA_CITY,
        /// <summary>
        /// The us a_ count y_ name
        /// </summary>
        USA_COUNTY_NAME,
        /// <summary>
        /// The us a_ fir m_ name
        /// </summary>
        USA_FIRM_NAME,
        /// <summary>
        /// The us a_ hous e_ number
        /// </summary>
        USA_HOUSE_NUMBER,
        /// <summary>
        /// The us a_ las t_ line
        /// </summary>
        USA_LAST_LINE,
        /// <summary>
        /// The us a_ mainaddrline
        /// </summary>
        USA_MAINADDRLINE,
        /// <summary>
        /// The us a_ name
        /// </summary>
        USA_NAME,
        /// <summary>
        /// The us a_ nam e_ city
        /// </summary>
        USA_NAME_CITY,
        /// <summary>
        /// The us a_ pre f_ city
        /// </summary>
        USA_PREF_CITY,
        /// <summary>
        /// The us a_ state
        /// </summary>
        USA_STATE,
        /// <summary>
        /// The us a_ uni t_ number
        /// </summary>
        USA_UNIT_NUMBER,
        /// <summary>
        /// The us a_ uni t_ type
        /// </summary>
        USA_UNIT_TYPE,
        /// <summary>
        /// The us a_ zip
        /// </summary>
        USA_ZIP,
        /// <summary>
        /// The us a_ zi p4
        /// </summary>
        USA_ZIP4,
        /// <summary>
        /// The us a_ zi p9
        /// </summary>
        USA_ZIP9,
        /// <summary>
        /// The us a_ zi P10
        /// </summary>
        USA_ZIP10,
        /// <summary>
        /// The us a_ ap n_ identifier
        /// </summary>
        USA_APN_ID,
        /// <summary>
        /// The us a_ neares t_ dist
        /// </summary>
        USA_NEAREST_DIST,
        /// <summary>
        /// The us a_ parce n_ elevation
        /// </summary>
        USA_PARCEN_ELEVATION,
        /// <summary>
        /// The us a_ poin t_ identifier
        /// </summary>
        USA_POINT_ID,
        /// <summary>
        /// The us a_ bearing
        /// </summary>
        USA_BEARING,
        /// <summary>
        /// The us a_ bloc k_ left
        /// </summary>
        USA_BLOCK_LEFT,
        /// <summary>
        /// The us a_ bloc k_ right
        /// </summary>
        USA_BLOCK_RIGHT,
        /// <summary>
        /// The us a_ bloc k_ sf x_ left
        /// </summary>
        USA_BLOCK_SFX_LEFT,
        /// <summary>
        /// The us a_ bloc k_ sf x_ right
        /// </summary>
        USA_BLOCK_SFX_RIGHT,
        /// <summary>
        /// The us a_ centerlin e_ datatype
        /// </summary>
        USA_CENTERLINE_DATATYPE,
        /// <summary>
        /// The us a_ centerlin e_ i s_ alias
        /// </summary>
        USA_CENTERLINE_IS_ALIAS,
        /// <summary>
        /// The us a_ centerlin e_ lat
        /// </summary>
        USA_CENTERLINE_LAT,
        /// <summary>
        /// The us a_ centerlin e_ lon
        /// </summary>
        USA_CENTERLINE_LON,
        /// <summary>
        /// The us a_ centerlin e_ name
        /// </summary>
        USA_CENTERLINE_NAME,
        /// <summary>
        /// The us a_ centerlin e_ neares t_ dist
        /// </summary>
        USA_CENTERLINE_NEAREST_DIST,
        /// <summary>
        /// The us a_ centerlin e_ postdir
        /// </summary>
        USA_CENTERLINE_POSTDIR,
        /// <summary>
        /// The us a_ centerlin e_ predir
        /// </summary>
        USA_CENTERLINE_PREDIR,
        /// <summary>
        /// The us a_ centerlin e_ qcity
        /// </summary>
        USA_CENTERLINE_QCITY,
        /// <summary>
        /// The us a_ centerlin e_ roa d_ class
        /// </summary>
        USA_CENTERLINE_ROAD_CLASS,
        /// <summary>
        /// The us a_ centerlin e_ segmen t_ direction
        /// </summary>
        USA_CENTERLINE_SEGMENT_DIRECTION,
        /// <summary>
        /// The us a_ centerlin e_ se g_ hirange
        /// </summary>
        USA_CENTERLINE_SEG_HIRANGE,
        /// <summary>
        /// The us a_ centerlin e_ segmen t_ parity
        /// </summary>
        USA_CENTERLINE_SEGMENT_PARITY,
        /// <summary>
        /// The us a_ centerlin e_ se g_ lorange
        /// </summary>
        USA_CENTERLINE_SEG_LORANGE,
        /// <summary>
        /// The us a_ centerlin e_ segmen t_ identifier
        /// </summary>
        USA_CENTERLINE_SEGMENT_ID,
        /// <summary>
        /// The us a_ centerlin e_ type
        /// </summary>
        USA_CENTERLINE_TYPE,
        /// <summary>
        /// The us a_ bloc k_ lef t2
        /// </summary>
        USA_BLOCK_LEFT2,
        /// <summary>
        /// The us a_ bloc k_ righ t2
        /// </summary>
        USA_BLOCK_RIGHT2,
        /// <summary>
        /// The us a_ bloc k_ sf x_ lef t2
        /// </summary>
        USA_BLOCK_SFX_LEFT2,
        /// <summary>
        /// The us a_ bloc k_ sf x_ righ t2
        /// </summary>
        USA_BLOCK_SFX_RIGHT2,
        /// <summary>
        /// The us a_ CBS a_ divisio n_ nam e2
        /// </summary>
        USA_CBSA_DIVISION_NAME2,
        /// <summary>
        /// The us a_ CBS a_ divisio n_ numbe r2
        /// </summary>
        USA_CBSA_DIVISION_NUMBER2,
        /// <summary>
        /// The us a_ CBS a_ nam e2
        /// </summary>
        USA_CBSA_NAME2,
        /// <summary>
        /// The us a_ CBS a_ numbe r2
        /// </summary>
        USA_CBSA_NUMBER2,
        /// <summary>
        /// The us a_ count y_ nam e2
        /// </summary>
        USA_COUNTY_NAME2,
        /// <summary>
        /// The us a_ count y2
        /// </summary>
        USA_COUNTY2,
        /// <summary>
        /// The us a_ cs a_ nam e2
        /// </summary>
        USA_CSA_NAME2,
        /// <summary>
        /// The us a_ cs a_ numbe r2
        /// </summary>
        USA_CSA_NUMBER2,
        /// <summary>
        /// The us a_ datatyp e2
        /// </summary>
        USA_DATATYPE2,
        /// <summary>
        /// The us a_ metr o_ fla g2
        /// </summary>
        USA_METRO_FLAG2,
        /// <summary>
        /// The us a_ nam e2
        /// </summary>
        USA_NAME2,
        /// <summary>
        /// The us a_ postdi r2
        /// </summary>
        USA_POSTDIR2,
        /// <summary>
        /// The us a_ predi r2
        /// </summary>
        USA_PREDIR2,
        /// <summary>
        /// The us a_ roa d_ clas s2
        /// </summary>
        USA_ROAD_CLASS2,
        /// <summary>
        /// The us a_ se g_ hirang e2
        /// </summary>
        USA_SEG_HIRANGE2,
        /// <summary>
        /// The us a_ se g_ lorang e2
        /// </summary>
        USA_SEG_LORANGE2,
        /// <summary>
        /// The us a_ segmen t_ directio n2
        /// </summary>
        USA_SEGMENT_DIRECTION2,
        /// <summary>
        /// The us a_ segmen t_ i d2
        /// </summary>
        USA_SEGMENT_ID2,
        /// <summary>
        /// The us a_ segmen t_ parit y2
        /// </summary>
        USA_SEGMENT_PARITY2,
        /// <summary>
        /// The us a_ typ e2
        /// </summary>
        USA_TYPE2,
        /// <summary>
        /// The us a_ block
        /// </summary>
        USA_BLOCK,
        /// <summary>
        /// The us a_ county
        /// </summary>
        USA_COUNTY,
        /// <summary>
        /// The us a_ stat e_ fips
        /// </summary>
        USA_STATE_FIPS,
        /// <summary>
        /// The us a_ al t_ flag
        /// </summary>
        USA_ALT_FLAG,
        /// <summary>
        /// The us a_ cart
        /// </summary>
        USA_CART,
        /// <summary>
        /// The us a_ chec k_ digit
        /// </summary>
        USA_CHECK_DIGIT,
        /// <summary>
        /// The us a_ ctys t_ key
        /// </summary>
        USA_CTYST_KEY,
        /// <summary>
        /// The us a_ DFLT
        /// </summary>
        USA_DFLT,
        /// <summary>
        /// The us a_ DPBC
        /// </summary>
        USA_DPBC,
        /// <summary>
        /// The us a_ ew s_ match
        /// </summary>
        USA_EWS_MATCH,
        /// <summary>
        /// The us a_ gov t_ flag
        /// </summary>
        USA_GOVT_FLAG,
        /// <summary>
        /// The us a_ h i_ ris e_ DFLT
        /// </summary>
        USA_HI_RISE_DFLT,
        /// <summary>
        /// The us a_ lo t_ code
        /// </summary>
        USA_LOT_CODE,
        /// <summary>
        /// The us a_ lo t_ number
        /// </summary>
        USA_LOT_NUM,
        /// <summary>
        /// The us a_ mai l_ stop
        /// </summary>
        USA_MAIL_STOP,
        /// <summary>
        /// The us a_ pm b_ designator
        /// </summary>
        USA_PMB_DESIGNATOR,
        /// <summary>
        /// The us a_ pm b_ number
        /// </summary>
        USA_PMB_NUMBER,
        /// <summary>
        /// The us a_ r_ rt e_ DFLT
        /// </summary>
        USA_R_RTE_DFLT,
        /// <summary>
        /// The us a_ ur b_ name
        /// </summary>
        USA_URB_NAME,
        /// <summary>
        /// The us a_ zi p_ carrtsort
        /// </summary>
        USA_ZIP_CARRTSORT,
        /// <summary>
        /// The us a_ zi p_ class
        /// </summary>
        USA_ZIP_CLASS,
        /// <summary>
        /// The us a_ zi p_ facility
        /// </summary>
        USA_ZIP_FACILITY,
        /// <summary>
        /// The us a_ dp v_ cmra
        /// </summary>
        USA_DPV_CMRA,
        /// <summary>
        /// The us a_ dp v_ confirm
        /// </summary>
        USA_DPV_CONFIRM,
        /// <summary>
        /// The us a_ dp v_ fals e_ position
        /// </summary>
        USA_DPV_FALSE_POS,
        /// <summary>
        /// The us a_ dp v_ footnot e1
        /// </summary>
        USA_DPV_FOOTNOTE1,
        /// <summary>
        /// The us a_ dp v_ footnot e2
        /// </summary>
        USA_DPV_FOOTNOTE2,
        /// <summary>
        /// The us a_ dp v_ footnot e3
        /// </summary>
        USA_DPV_FOOTNOTE3,
        /// <summary>
        /// The us a_ dp v_ n o_ stat
        /// </summary>
        USA_DPV_NO_STAT,
        /// <summary>
        /// The us a_ dp v_ shutdown
        /// </summary>
        USA_DPV_SHUTDOWN,
        /// <summary>
        /// The us a_ dp v_ vacant
        /// </summary>
        USA_DPV_VACANT,
        /// <summary>
        /// The us a_ lac s_ flag
        /// </summary>
        USA_LACS_FLAG,
        /// <summary>
        /// The us a_ lacslin k_ indicator
        /// </summary>
        USA_LACSLINK_INDICATOR,
        /// <summary>
        /// The us a_ lacslin k_ retcode
        /// </summary>
        USA_LACSLINK_RETCODE,
        /// <summary>
        /// The us a_ lacslin k_ shutdown
        /// </summary>
        USA_LACSLINK_SHUTDOWN,
        /// <summary>
        /// The us a_ suitelin k_ re t_ code
        /// </summary>
        USA_SUITELINK_RET_CODE,
        /// <summary>
        /// The us a_ addrlin e_ short
        /// </summary>
        USA_ADDRLINE_SHORT,
        /// <summary>
        /// The us a_ cit y_ short
        /// </summary>
        USA_CITY_SHORT,
        /// <summary>
        /// The us a_ lastlin e_ short
        /// </summary>
        USA_LASTLINE_SHORT,
        /// <summary>
        /// The us a_ nam e_ short
        /// </summary>
        USA_NAME_SHORT,
        /// <summary>
        /// The us a_ postdi r_ short
        /// </summary>
        USA_POSTDIR_SHORT,
        /// <summary>
        /// The us a_ us a_ predi r_ short
        /// </summary>
        USA_USA_PREDIR_SHORT,
        /// <summary>
        /// The typ e_ short
        /// </summary>
        TYPE_SHORT,
        /// <summary>
        /// The us a_ datatype
        /// </summary>
        USA_DATATYPE,
        /// <summary>
        /// The us a_ datatyp e_ name
        /// </summary>
        USA_DATATYPE_NAME,
        /// <summary>
        /// The us a_ hirange
        /// </summary>
        USA_HIRANGE,
        /// <summary>
        /// The us a_ hiunit
        /// </summary>
        USA_HIUNIT,
        /// <summary>
        /// The us a_ hizi p4
        /// </summary>
        USA_HIZIP4,
        /// <summary>
        /// The us a_ i s_ alias
        /// </summary>
        USA_IS_ALIAS,
        /// <summary>
        /// The us a_ lorange
        /// </summary>
        USA_LORANGE,
        /// <summary>
        /// The us a_ lounit
        /// </summary>
        USA_LOUNIT,
        /// <summary>
        /// The us a_ lozi p4
        /// </summary>
        USA_LOZIP4,
        /// <summary>
        /// The us a_ postdir
        /// </summary>
        USA_POSTDIR,
        /// <summary>
        /// The us a_ predir
        /// </summary>
        USA_PREDIR,
        /// <summary>
        /// The us a_ qcity
        /// </summary>
        USA_QCITY,
        /// <summary>
        /// The us a_ rang e_ parity
        /// </summary>
        USA_RANGE_PARITY,
        /// <summary>
        /// The us a_ re c_ type
        /// </summary>
        USA_REC_TYPE,
        /// <summary>
        /// The us a_ roa d_ class
        /// </summary>
        USA_ROAD_CLASS,
        /// <summary>
        /// The us a_ se g_ hirange
        /// </summary>
        USA_SEG_HIRANGE,
        /// <summary>
        /// The us a_ se g_ lorange
        /// </summary>
        USA_SEG_LORANGE,
        /// <summary>
        /// The us a_ segmen t_ direction
        /// </summary>
        USA_SEGMENT_DIRECTION,
        /// <summary>
        /// The us a_ segmen t_ identifier
        /// </summary>
        USA_SEGMENT_ID,
        /// <summary>
        /// The us a_ segmen t_ parity
        /// </summary>
        USA_SEGMENT_PARITY,
        /// <summary>
        /// The us a_ stree t_ side
        /// </summary>
        USA_STREET_SIDE,
        /// <summary>
        /// The us a_ type
        /// </summary>
        USA_TYPE,
        /// <summary>
        /// The us a_ au x_ userdata
        /// </summary>
        USA_AUX_USERDATA,
        /// <summary>
        /// The us a_ CBS a_ divisio n_ name
        /// </summary>
        USA_CBSA_DIVISION_NAME,
        /// <summary>
        /// The us a_ CBS a_ divisio n_ number
        /// </summary>
        USA_CBSA_DIVISION_NUMBER,
        /// <summary>
        /// The us a_ CBS a_ name
        /// </summary>
        USA_CBSA_NAME,
        /// <summary>
        /// The us a_ CBS a_ number
        /// </summary>
        USA_CBSA_NUMBER,
        /// <summary>
        /// The us a_ cs a_ name
        /// </summary>
        USA_CSA_NAME,
        /// <summary>
        /// The us a_ cs a_ number
        /// </summary>
        USA_CSA_NUMBER,
        /// <summary>
        /// The us a_ lat
        /// </summary>
        USA_LAT,
        /// <summary>
        /// The us a_ lon
        /// </summary>
        USA_LON,
        /// <summary>
        /// The us a_ matche d_ database
        /// </summary>
        USA_MATCHED_DB,
        /// <summary>
        /// The us a_ mc d_ name
        /// </summary>
        USA_MCD_NAME,
        /// <summary>
        /// The us a_ mc d_ number
        /// </summary>
        USA_MCD_NUMBER,
        /// <summary>
        /// The us a_ metr o_ flag
        /// </summary>
        USA_METRO_FLAG,
        /// <summary>
        /// The us a_ percen t_ geocode
        /// </summary>
        USA_PERCENT_GEOCODE,
        /// <summary>
        /// The us a_ resolve d_ line
        /// </summary>
        USA_RESOLVED_LINE,

        //India
        /// <summary>
        /// The in d_ isrural
        /// </summary>
        IND_ISRURAL,
        /// <summary>
        /// The in d_ po i_ category
        /// </summary>
        IND_POI_CATEGORY,
        /// <summary>
        /// The in d_ block
        /// </summary>
        IND_BLOCK,
        /// <summary>
        /// The in d_ su b_ locality
        /// </summary>
        IND_SUB_LOCALITY,

        //Itlay
        /// <summary>
        /// It a_ historicalpostcode
        /// </summary>
        ITA_HISTORICALPOSTCODE,

        //Japan

        /// <summary>
        /// The jp n_ banchi
        /// </summary>
        JPN_BANCHI,
        /// <summary>
        /// The jp n_ chomoku
        /// </summary>
        JPN_CHOMOKU,
        /// <summary>
        /// The jp n_ chooaza
        /// </summary>
        JPN_CHOOAZA,
        /// <summary>
        /// The jp n_ go
        /// </summary>
        JPN_GO,
        /// <summary>
        /// The jp n_ jush o_ code
        /// </summary>
        JPN_JUSHO_CODE,

        //XWG
        /// <summary>
        /// The xw g_ cityrank
        /// </summary>
        XWG_CITYRANK,

        //NZL
        /// <summary>
        /// The nz l_ aliase d_ suburb
        /// </summary>
        NZL_ALIASED_SUBURB,
        /// <summary>
        /// The nz l_ ke y_ ufi
        /// </summary>
        NZL_KEY_UFI,
        /// <summary>
        /// The nz l_ meshbloc k_ identifier
        /// </summary>
        NZL_MESHBLOCK_ID,
        /// <summary>
        /// The nz l_ origina l_ latitude
        /// </summary>
        NZL_ORIGINAL_LATITUDE,
        /// <summary>
        /// The nz l_ origina l_ longitude
        /// </summary>
        NZL_ORIGINAL_LONGITUDE,

    }

    /// <summary>
    /// 
    /// </summary>
    public enum DistanceUnits
    {


        /// <summary>
        /// The feet
        /// </summary>
        FEET,

        /// <summary>
        /// The meters
        /// </summary>
        METERS,

        /// <summary>
        /// The miles
        /// </summary>
        MILES,

        /// <summary>
        /// The kilometers
        /// </summary>
        KILOMETERS,

        /// <summary>
        /// The foot
        /// </summary>
        FOOT,

        /// <summary>
        /// The meter
        /// </summary>
        METER,

        /// <summary>
        /// The mile
        /// </summary>
        MILE,

        /// <summary>
        /// The kilometer
        /// </summary>
        KILOMETER
    };

    /// <summary>
    /// 
    /// </summary>
    enum AlternameLookup
    {
        /// <summary>
        /// The street_lookup_only
        /// </summary>
        Street_lookup_only = 3,
        /// <summary>
        /// The prefer_firm_lookup
        /// </summary>
        Prefer_firm_lookup = 2,
        /// <summary>
        /// The prefer_street_lookup
        /// </summary>
        Prefer_street_lookup = 1
    }
}
