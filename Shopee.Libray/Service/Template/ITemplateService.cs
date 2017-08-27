using Shopee.Libray.DataBeans;
using Shopee.Libray.DataBeans.Template.Request;
using Shopee.Libray.DataBeans.Template.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Service.Template
{
    public interface ITemplateService
    {

        ReturnModel<List<BikeAvailabilityRespBean>> GetBikeAvailabilityData(UserReqBean user);
    }
}
