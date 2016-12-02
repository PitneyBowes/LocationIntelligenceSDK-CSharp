using com.pb.locationintelligence.geocode.model;
using System;
using System.Collections.Generic;

namespace com.pb.locationintelligence.geotax.model
{
    public class TaxLocationRequest {


        public Preferences preferences { set; get; }
   
        public List<Locations> locations { set; get; }

     


    }
}
