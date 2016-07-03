/*****************************************************************************
 *       Copyright  ©  2014, Pitney Bowes Software Inc.
 *       All  rights reserved.
 *       Confidential Property of Pitney Bowes Software Inc.
 */
using System;
using System.Collections.Generic;
namespace com.pb.locationintelligence.common.model
{

    public class Timezone
    {

        public string timezoneName { set; get; }

        public long utcOffset { set; get; }

        public long dstOffset { set; get; }

        public long timestamp { set; get; }

        

    }
}
