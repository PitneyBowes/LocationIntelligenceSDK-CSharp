using com.pb.locationintelligence.geocode.model;
using System;
using System.Collections.Generic;

namespace com.pb.locationintelligence.geotax.model
{
    public class TaxRateAddressRequest {

        public Preferences preferences { set; get; }
   
        public List<TaxRateAddress> taxRateAddresses { set; get; }


}
}