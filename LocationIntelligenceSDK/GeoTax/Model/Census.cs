using com.pb.locationintelligence.geocode.model;
using System;


namespace com.pb.locationintelligence.geotax.model
{
    public class Census
    {
        public Cbsa cbsa { get; set; }

        public String matchLevel { get; set; }

        public String matchCode { get; set; }

        public String tract { get; set; }

        public Mcd mcd { get; set; }



    }
}
