using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class catalogueDAO
    {
          LSEntities ctx;
      public catalogueDAO()
        {
            ctx = new LSEntities();
        }
       

          public catalogue selectCatalogueByID(string itemid)
        {
            return ctx.catalogues.Where(x => x.itemID == itemid).FirstOrDefault();
        }

        public catalogue selectCatalogueByDescription(string description)
        {
            return ctx.catalogues.Where(x => x.description == description).FirstOrDefault();
        }
        public List<catalogue> selectAllItems()
        {
            return ctx.catalogues.Where(x=>x.category!="free gift").ToList();
        }
        public List<catalogue> selectItemsByCategory(string category)
        {
            return ctx.catalogues.Where(x => x.category == category).ToList();
        }
       public string updateCatalogue( catalogue c)
        {
     
           
            catalogue ca = ctx.catalogues.Where(x => x.itemID == c.itemID).FirstOrDefault();
            if (null == c)
                return "Fail";
          ca.category=c.category;
           ca.description=c.description;
           ca.reorderlevel=c.reorderlevel;
           ca.reorderqty=c.reorderqty;
           ca.unit=c.unit;
           ca.bin=c.bin;
           ca.image = c.image;
           ca.balance=c.balance;
           ca.avgprice=c.avgprice;
            ctx.SaveChanges();
            return "Success";
        }
    }
}