using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using sa41team7_logicuniversity_stationery.DAO;
using sa41team7_logicuniversity_stationery;

namespace sa41team7_logicuniversity_stationery.Controller
{
    public class MaintainSupplierInformationController
    {
        private PagedDataSource pg;

        private supplierDAO su;
        private List<supplier> sp;


        public MaintainSupplierInformationController()
        {
            pg = new PagedDataSource();
        }

        public int getPagedDataSourcePageCount()
        {
            return pg.PageCount;
        }


        public PagedDataSource getPagedDataSource()
        {
            return pg;
        }

        public int getPagedDataSourceIndex()
        {
            return pg.CurrentPageIndex;
        }


        public void setPagedDataSourceCurrentPageIndex(int pos)
        {
            pg.CurrentPageIndex = pos;
        }

        public void getAllSuppliers()
        {
            su = null;
            su = new supplierDAO();
            sp = null;
            sp = su.getAllSuppliers();

            fillDataList();
        }

        public string fillDataList()
        {
            List<supplier> SupplierList = new List<supplier>();
            string flag = "success";
            Boolean typeExists;

            if (sp.Count != 0)
            {
                foreach (supplier prod in sp)
                {
                    typeExists = false;

                    foreach (supplier pt in SupplierList)
                    {
                        if (pt.name.Equals(prod.name) && pt.supplierID.Equals(prod.supplierID))
                        {
                            typeExists = true;
                        }
                    }

                    if (!typeExists)
                    {
                        SupplierList.Add(prod);
                    }
                }

                foreach (supplier prod in SupplierList)
                {
                    System.Diagnostics.Debug.WriteLine(prod.name);
                }

                pg = new PagedDataSource();
                pg.DataSource = SupplierList;
                pg.AllowPaging = true;
                pg.PageSize = 4;
                return flag;
            }
            else
            {
                flag = "fail";
                return flag;
            }

        }

    }
}