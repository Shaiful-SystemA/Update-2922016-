using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sa41team7_logicuniversity_stationery.DAO
{
    public class purchaseorderDAO
    {
      
     
            LSEntities ctx;
            public purchaseorderDAO()
            {
                ctx = new LSEntities();
            }
            //test
            public purchaseorder getPurchaseOrderByID(int purchaseorderID)
            {
                return ctx.purchaseorders.Where(x => x.poID == purchaseorderID).FirstOrDefault();
            }
        //test
            public List<purchaseorder> getPurchaseOrderBySupplierName(string supplierName)
            {
                return ctx.purchaseorders.Where(x => x.supplier.name == supplierName).ToList();
            }
            //test
            public List<purchaseorder> getAllPurchaseOrderByClerkID(string clerkID)
            {
                return ctx.purchaseorders.Where(x => x.clerkID == clerkID && x.status == "Approved").ToList();
            }
        //test
            public List<purchaseorder> getAllPurchaseOrderByApproverID(string approverID)
            {
                return ctx.purchaseorders.Where(x => x.approverid == approverID && x.status == "Pending").ToList();
            }
        //test
            public string insertPurchaseOrder(purchaseorder po)
            {
                ctx.purchaseorders.Add(po);
                ctx.SaveChanges();
                return "Success";
            }
        //test
            public string updatePurchaseOrderStatus(int poId,string flag)
            {
                purchaseorder po = ctx.purchaseorders.Where(x => x.poID == poId).FirstOrDefault();
                if (null == po)
                { return "Fail"; }
                else
                {
                    po.status =flag;
                    ctx.SaveChanges();
                    return "Success";
                }


            }
        }
    }
