using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class delegateauthorityDAO
    {
        LSEntities ctx;
        public delegateauthorityDAO()
        {
            ctx = new LSEntities();
        }
        public delegateauthority getDelegateIDByUserID(String userID)//employeeID is same with UserID
        {
            return ctx.delegateauthorities.Where(x => x.employeeID == userID).FirstOrDefault();
        }

        public delegateauthority getDelegateIDByHeadAndDept(String headID, String employeeID)
        {
            return ctx.delegateauthorities.Where(x => x.headID == headID && x.employeeID == employeeID).FirstOrDefault();
        }

        public List<delegateauthority> getDelegateByStatus(String status)
        {
            return ctx.delegateauthorities.Where(x => x.status == status).ToList();
        }

        public delegateauthority getDelegateByID(int delID)
        {
            return ctx.delegateauthorities.Where(x => x.delegateID == delID).FirstOrDefault();
        }

        public List<delegateauthority> selectAllDelegateAuthority()
        {
            return ctx.delegateauthorities.ToList();
        }

        public String createDelegateAuthority(delegateauthority delAuthority)
        {
            ctx.delegateauthorities.Add(delAuthority);
            ctx.SaveChanges();
            return "Success";
        }

        public String UpdateDelegateAuthority(delegateauthority delAuthority)
        {
            delegateauthority delegateAuthority = ctx.delegateauthorities.Where(x => x.delegateID == delAuthority.delegateID).First();
            if (null == delegateAuthority)
                return "Fail";
            delegateAuthority.startdate = delAuthority.startdate;
            delegateAuthority.enddate = delAuthority.enddate;
            delegateAuthority.status = delAuthority.status;
            ctx.SaveChanges();
            return "Success";
        }
    }
}