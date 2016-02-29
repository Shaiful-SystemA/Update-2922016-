using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class requisitionDAO
    {
        LSEntities ctx;
        public requisitionDAO()
        {
            ctx = new LSEntities();
        }

        public requisition getRequisitionByID(int reqID)
        {
            return ctx.requisitions.Where(x => x.requestID == reqID).First();
        }

        public List<requisition> getRequisitionByUrgent()
        {
            return ctx.requisitions.Where(x => x.type == "Urgent").ToList();
        }

        //Add By Alice(29/2/2016)
        public List<requisition> getRequisitionByDeptID(string DeptID)
        {
            return ctx.requisitions.Where(x => x.departmentID == DeptID).ToList();
        }

        public List<requisition> selectAllRequisitionList()
        {
            return ctx.requisitions.ToList();
        }

        public String createRequisitionList(requisition req)
        {
            ctx.requisitions.Add(req);
            ctx.SaveChanges();
            return "Success";
        }

        public string updateRequisitionList(requisition req)
        {
            requisition requi = ctx.requisitions.Where(x => x.requestID == req.requestID).First();
            if (null == requi)
                return "Fail";
            requi.requestdate = req.requestdate;
            requi.status = req.status;
            requi.type = req.type;
            ctx.SaveChanges();
            return "Success";
        }
    }
}