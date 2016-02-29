using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class adjustvoucherDAO
    {
        LSEntities ctx;

        public adjustvoucherDAO()
        {
            ctx = new LSEntities();
        }

        public string createAdjustmentVoucher(adjustvoucher av)
        {
            ctx.adjustvouchers.Add(av);
            ctx.SaveChanges();
            return "Success";
        }

        public string getNewVoucherNumber()
        {
           adjustvoucher av = ctx.adjustvouchers.Last();

           int id = Convert.ToInt32(av.voucherID);

           id++;
          
           return id.ToString();  
        }
    }
}