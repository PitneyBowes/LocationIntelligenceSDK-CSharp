
using System;


namespace com.pb.locationintelligence.geotax.model
{
    // <summary>
    /// Model for seding TaxBatch Address request to send Amount.
    /// </summary>
    public class TaxAddress : TaxRateAddress
    {


        /// <summary>
        /// Gets or sets the purchase amount.
        /// </summary>
        /// <value>
        /// The purchase amount.
        /// </value>
        public String purchaseAmount { get; set; }

    }
}
