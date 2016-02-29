using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class disbursementDAO
    {
        LSEntities ctx;

        public disbursementDAO()
        {
            ctx = new LSEntities();
        }

        public disbursement getDisbursementID(String clerkID, String deptID, String repID, String status)
        {
            return ctx.disbursements.Where(x => x.clerkID == clerkID && x.departmentID == deptID && x.repID == repID && x.status == status).First();
        }

        public disbursement getDisbursementIDByClerkAndDept(String clerkID, String deptID, String status)
        {
            return ctx.disbursements.Where(x => x.clerkID == clerkID && x.departmentID == deptID && x.status == status).First();
        }

        public disbursement getDisbursementIDByStatus(String status)
        {
            return ctx.disbursements.Where(x => x.status == status).First();
        }

        public List<disbursement> selectAllDisbursementList()
        {
            return ctx.disbursements.ToList();
        }

        public disbursement selectDisbursementListByID(int disburseID)
        {
            return ctx.disbursements.Where(x => x.disbursementID == disburseID).First();
        }
        public string createDisbursementList(disbursement dis)
        {
            ctx.disbursements.Add(dis);
            ctx.SaveChanges();
            return "Success";
        }

        public string updateDisbursementList(disbursement dis)
        {
            disbursement disburse = ctx.disbursements.Where(x => x.disbursementID == dis.disbursementID).First();
            if (null == disburse)
                return "Fail";
            disburse.createdate = dis.createdate;
            disburse.clerkID = dis.clerkID;
            disburse.departmentID = dis.departmentID;
            disburse.repID = dis.repID;
            disburse.status = dis.status;
            ctx.SaveChanges();
            return "Success";
        }
    }
}