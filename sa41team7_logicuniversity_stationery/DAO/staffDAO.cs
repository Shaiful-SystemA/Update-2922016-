using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class staffDAO
    {

      LSEntities ctx;
      public staffDAO()
        {
            ctx = new LSEntities();
        }
       
        public List<staff> selectAllUser()
        {
            return ctx.staffs.ToList();
        }
      
        public staff selectUserByID(string userid)
        {
            return ctx.staffs.Where(x => x.userID == userid).FirstOrDefault();
        }

        //public List<user> getAllEmployee(User u)
        //{
        //    var t = (from x in luse.users
        //             where x.departmentId == u.DepartmentId
        //             select x).ToList();
        //    return t;
        //}
      
    }
}