using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class departmentDAO
    {

        LSEntities ctx;

        public departmentDAO()
        {
            ctx = new LSEntities();
        }
        //add by simon
        public List<department> getAllDepartments()
        {
            return ctx.departments.ToList(); 
        }
        //add by simon
        //public string getHeadNameByHeadID(string headID)
        //{
        //    return ctx.users.Where(x=>x.userID==headID).FirstOrDefault().name;
        //}
        ////add by simon
        //public string getRepNameByRepID(string repID)
        //{
        //    return ctx.users.Where(x => x.userID == repID).FirstOrDefault().name;
        //}
        ////add by simon
        public string updateDepartment(department d)
        {
            department dep = ctx.departments.Where(x => x.departmentID == d.departmentID).FirstOrDefault(); 
            if (null == dep)
            {
                return "Fail";
            }
            else
            { 
                dep.phone=d.phone ;
                dep.collectionpoint = d.collectionpoint;
                ctx.SaveChanges();
                return "Success";
            }
        }
        //add by simon
        //public string updateDepartmentContactName(department d, string contactname)
        //{
        //    department dep = ctx.departments.Where(x => x.departmentID == d.departmentID).FirstOrDefault(); 
        //    user u=ctx.users.Where(x => x.name == contactname).FirstOrDefault();
        //    if (null == u)
        //    {
        //        return "No this employee";
        //    }
        //    else
        //    {
        //        dep.contactID = u.userID;
        //        ctx.SaveChanges();
        //        return "Success";
        //    }
        //}
        //add by simon
        //public string updateDepartmentHeadName(department d, string headname)
        //{
        //    department dep = ctx.departments.Where(x => x.departmentID == d.departmentID).FirstOrDefault();
        //    user u = ctx.users.Where(x => x.name == headname).FirstOrDefault();
        //    if (null == u)
        //    {
        //        return "No this employee";
        //    }
        //    else
        //    {
        //        dep.headID = u.userID;
        //        ctx.SaveChanges();
        //        return "Success";
        //    }
        //}
        //add by simon
        //public string updateDepartmentRepName(department d, string repname)
        //{
        //    department dep = ctx.departments.Where(x => x.departmentID == d.departmentID).FirstOrDefault();
        //    user u = ctx.users.Where(x => x.name == repname).FirstOrDefault();
        //    if (null == u)
        //    {
        //        return "No this employee";
        //    }
        //    else
        //    {
        //        dep.repID = u.userID;
        //        ctx.SaveChanges();
        //        return "Success";
        //    }
        //}

        public department getDepartmentByName(string name)
        {
            return ctx.departments.Where(x => x.name == name).First();
        }

        public department getDepartmentByID(string deptID)
        {
            return ctx.departments.Where(x => x.departmentID == deptID).First();
        }
    }
}