using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Template.Response
{
    public class BikeAvailabilityRespBean
    {
        public string stationuid { get; set; }
        public string StationID { get; set; }
        public string servieAvailable { get; set; }
        public int AvailableRentBikes { get; set; }
        public UInt32 AvailableReturnBikes { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
