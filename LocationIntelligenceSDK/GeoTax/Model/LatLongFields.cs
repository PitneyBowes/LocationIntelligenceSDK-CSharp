using com.pb.locationintelligence.geocode.model;
using System;


namespace com.pb.locationintelligence.geotax.model
{
    public class LatLongFields
    {

        public String matchCode { get; set; }
        public String matchLevel { get; set; }
        public String streetMatchCode { get; set; }
        public String streetMatchLevel { get; set; }

        public Geometry geometry { get; set; }




    }
}
