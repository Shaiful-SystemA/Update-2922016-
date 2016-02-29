using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class adjustvoucherdetailDAO
    {
        LSEntities ctx;

        public adjustvoucherdetailDAO()
        {
            ctx = new LSEntities();
        }

        public List<adjustvoucherdetail> getAllAdjustmentVouchers()
        {
            return ctx.adjustvoucherdetails.ToList();
        }

        public List<adjustvoucherdetail> getAllAdjustmentVouchersByVoucherID(int voucherID)
        {
            return ctx.adjustvoucherdetails.Where(x => x.voucherID == voucherID).ToList();
        }
    }
}