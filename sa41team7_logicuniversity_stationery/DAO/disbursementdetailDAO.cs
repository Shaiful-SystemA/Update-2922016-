using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class disbursementdetailDAO
    {
        LSEntities ctx;

        public disbursementdetailDAO()
        {
            ctx = new LSEntities();
        }

        public disbursementdetail getDisburseDetailIDByDisburseID(int disburseID)
        {
            return ctx.disbursementdetails.Where(x => x.disbursementID == disburseID).First();
        }

        public disbursementdetail getDisburseByID(int disburseDetailID)
        {
            return ctx.disbursementdetails.Where(x => x.disbursedetailID == disburseDetailID).First();
        }

        public List<disbursementdetail> selectAllDisbursementDetailList()
        {
            return ctx.disbursementdetails.ToList();
        }

        public string createDisbursementDetailList(disbursementdetail disburseDetail)
        {
            ctx.disbursementdetails.Add(disburseDetail);
            ctx.SaveChanges();
            return "Success";
        }

        public string updateDisbursementDetailList(disbursementdetail disburseDetail)
        {
            disbursementdetail disDetail = ctx.disbursementdetails.Where(x => x.disbursedetailID == disburseDetail.disbursedetailID).First();
            if (null == disDetail)
                return "Fail";
            disDetail.actualqty = disburseDetail.actualqty;
            disDetail.neededqty = disburseDetail.neededqty;
            ctx.SaveChanges();
            return "Success";
        }
    }
}