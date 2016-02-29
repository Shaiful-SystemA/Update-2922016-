using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class requisitiondetailDAO
    {
        LSEntities ctx;

        public requisitiondetailDAO()
        {
            ctx = new LSEntities();
        }

        public requisitiondetail getReqDetailByID(int reqDetailID)
        {
            return ctx.requisitiondetails.Where(x => x.reqdetailID == reqDetailID).First();
        }

        public List<requisitiondetail> getReqDetailByReqID(int reqID)
        {
            return ctx.requisitiondetails.Where(x => x.requestID == reqID).ToList();
        }

        public List<requisitiondetail> selectAllReqDetail()
        {
            return ctx.requisitiondetails.ToList();
        }

        public String createReqDetail(requisitiondetail reqDetail)
        {
            ctx.requisitiondetails.Add(reqDetail);
            ctx.SaveChanges();
            return "Success";
        }

        public String updateReqDetail(requisitiondetail reqDetail)
        {
            requisitiondetail requiDetail = ctx.requisitiondetails.Where(x => x.reqdetailID == reqDetail.reqdetailID).First();
            if (null == requiDetail)
                return "Fail";
            requiDetail.qty = reqDetail.qty;
            ctx.SaveChanges();
            return "Success";
        }
    }
}