using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopee.Libray.DataBeans.Item
{
    #region GetCategoriesBean
    public class GetCategoriesBean
    {
        public UInt32 Partner_Id { get; set; }

        public UInt32 Shopid { get; set; }

        public UInt32 Timestamp { get; set; }
    } 
    #endregion

    #region CategoriesBean
    public class CategoriesBean
    {
        public string Error { get; set; }

        public List<Categorie> Categories { get; set; }
    } 
    #endregion

    #region Categorie
    public class Categorie
    {
        public UInt32 Category_Id { get; set; }

        public UInt32 Parent_Id { get; set; }

        public UInt32 Category_Name { get; set; }

        public UInt32 Has_Children { get; set; }
    }
    #endregion
}
