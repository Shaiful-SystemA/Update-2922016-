using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class podetailDAO
    {
         LSEntities ctx;
            public podetailDAO()
            {
                ctx = new LSEntities();
            }
            public List<podetail> getPOdDetailByID(int purchaseorderID)
            {
                return ctx.podetails.Where(x => x.poID == purchaseorderID).ToList();
            }

          
            public string insertPODetail(podetail pod)
            {
                ctx.podetails.Add(pod);
                ctx.SaveChanges();
                return "Success";
            }
         

    }
}