using Shopee.Libray.Service.Item;
using Shopee.Libray.Service.Logistics;
using Shopee.Libray.Service.Order;
using Shopee.Libray.Service.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.Service
{
    public class ShopeeFactory
    {
        #region "Local"
        /// <summary>
        /// 提供TemplateService
        /// </summary>
        private TemplateService _templateService = new TemplateService();

        /// <summary>
        /// 提供ItemService
        /// </summary>
        private ItemService _itemService = new ItemService();

        /// <summary>
        /// 提供LogisticsService
        /// </summary>
        private LogisticsService _logisticsService = new LogisticsService();

        /// <summary>
        /// 提供OrderService
        /// </summary>
        private OrderService _orderService = new OrderService();

        #endregion "Local"

        #region "Constructor"

        private static ShopeeFactory _instance;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private ShopeeFactory()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ShopeeFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new ShopeeFactory();
            }
            return _instance;
        }

        #endregion "Constructor"

        #region "Property"
        /// <summary>
        /// 取得目前的ItemService
        /// </summary>
        public ITemplateService templateService
        {
            get
            {
                return _templateService;
            }
        }

        /// <summary>
        /// 取得目前的ItemService
        /// </summary>
        public IItemService ItemService
        {
            get
            {
                return _itemService;
            }
        }

        /// <summary>
        /// 取得目前的ItemService
        /// </summary>
        public ILogisticsService LogisticsService
        {
            get
            {
                return _logisticsService;
            }
        }

        /// <summary>
        /// 取得目前的ItemService
        /// </summary>
        public IOrderService OrderService
        {
            get
            {
                return _orderService;
            }
        }
        #endregion
    }
}
