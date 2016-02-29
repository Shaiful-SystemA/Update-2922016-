using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class supplierDAO
    {
        LSEntities ctx;

        public supplierDAO()
        {
            ctx = new LSEntities();
        }
       
        public List<supplier> getAllSuppliers()
        {
            return ctx.suppliers.ToList();
        }

        public string updateSupplier(supplier s)
        {
            supplier sup = ctx.suppliers.Where(x => x.supplierID ==s.supplierID).FirstOrDefault();

            if(null==sup)
            {
                return "Fail";
            }
            else
            {
                sup.name = s.name;
                sup.contactname = s.contactname;
                sup.phone = s.phone;
                sup.fax = s.fax;
                sup.address = s.address;
                ctx.SaveChanges();
                return "Success";
            }
        }
    }
}