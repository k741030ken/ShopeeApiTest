using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region AddBean
    public class AddBean
    {

    } 
    #endregion

    #region AddReturnBean
    public class AddReturnBean
    {
        public string Error { get; set; }

        public UInt32 Item_Id { get; set; }

        public string Warning { get; set; }
    }
    #endregion
}
