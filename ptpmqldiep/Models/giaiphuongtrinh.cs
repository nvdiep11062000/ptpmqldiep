using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ptpmqldiep.Models
{
    public class giaiphuongtrinh
    {
        public Double Index(double a, double b)
        {
            double gtx = 0;
            gtx = -b/a;
            return gtx;
        }
    }
}