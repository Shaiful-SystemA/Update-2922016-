using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class itempriceDAO
    {
        LSEntities ctx;

        public itempriceDAO() 
        {
            ctx = new LSEntities();
        }

        public double getItemPriceByItemIDAndSupplierID(string itemID, string supplierID)
        {
            itemprice itmprice = ctx.itemprices.Where(x => x.itemID == itemID && x.supplierID == supplierID).FirstOrDefault();

            return itmprice.price;            
        }

        public List<double> getListOfItemPricesByItemID(string itemID)
        {
            List<itemprice> ip = ctx.itemprices.Where(x => x.itemID == itemID).ToList();

            List<double> prices = new List<double>();
            foreach(itemprice i in ip)
            {
                prices.Add(i.price);
            }

            return prices;
        }
    }
}