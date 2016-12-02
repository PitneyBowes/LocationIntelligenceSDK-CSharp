
using com.pb.locationintelligence.geocode.model;
using System;
using System.Collections.Generic;

namespace com.pb.locationintelligence.geotax.model
{
    public class TaxAddressRequest {

     public Preferences preferences { get; set; }
 
    public List<TaxAddress> taxAddresses { get; set; }


    }
}
