using com.pb.locationintelligence.geocode.model;
using System;


namespace com.pb.locationintelligence.geotax.model
{
    public class TaxRateAddress : Address {

        public String distanceUnits { get; set; }
        public String bufferWidth { get; set; }
        public String userBufferWidth { get; set; }



    }
}
