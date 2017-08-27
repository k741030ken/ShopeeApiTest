using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Template.Request
{
    public class UserReqBean
    {
        public string UserID { get; set; }

        public string UserName { get; set; }

        public List<CityReqBean> Citys { get; set; }
    }

    public class CityReqBean
    {
        public string name { get; set; }
        public List<BikeReqBean> Bikes { get; set; }
    }

    public class BikeReqBean
    {
        public string name { get; set; }
        public int? Top { get; set; }
    }

}
