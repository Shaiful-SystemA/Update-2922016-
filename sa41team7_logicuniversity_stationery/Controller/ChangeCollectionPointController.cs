using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using sa41team7_logicuniversity_stationery.DAO;
using sa41team7_logicuniversity_stationery;


namespace sa41team7_logicuniversity_stationery.Controller
{
    public class ChangeCollectionPointController
    {

        DAO.departmentDAO dept;
        
        public ChangeCollectionPointController()
        {
            dept = new DAO.departmentDAO();

        }

        public string updateDepartment(department p)
        {
            return dept.updateDepartment(p);

        }

        public department getDepartmentByName(string u)
        {
            return dept.getDepartmentByName(u);
        }


    }
}