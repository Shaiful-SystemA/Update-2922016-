using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sa41team7_logicuniversity_stationery.DAO;
using sa41team7_logicuniversity_stationery;



namespace sa41team7_logicuniversity_stationery.Controller
{
    public class MaintainChangeRepresentativeController
    {
            DAO.staffDAO stf;

        public MaintainChangeRepresentativeController()
        {
            stf = new DAO.staffDAO();

        }

        public string updateRep(staff p)
        {
            return stf.updateRep(p);

        }

        public staff getRepByName(string u)
        {
            return stf.getRepByName(u);
        }



    }
}