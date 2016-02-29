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
    public class MaintainDepartmentListController
    {
        private PagedDataSource pg;

        private departmentDAO dt;
        private List<department> sp;


        public MaintainDepartmentListController()
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

        public void getAllDepartments()
        {
            dt = null;
            dt = new departmentDAO();
            sp = null;
            sp = dt.getAllDepartments();

            fillDataList();
        }

        public string fillDataList()
        {
            List<department> departmentList = new List<department>();
            string flag = "success";
            Boolean typeExists;

            if (sp.Count != 0)
            {
                foreach (department prod in sp)
                {
                    typeExists = false;

                    foreach (department pt in departmentList)
                    {
                        if (pt.name.Equals(prod.name) && pt.departmentID.Equals(prod.departmentID))
                        {
                            typeExists = true;
                        }
                    }

                    if (!typeExists)
                    {
                        departmentList.Add(prod);
                    }
                }

                foreach (department prod in departmentList)
                {
                    System.Diagnostics.Debug.WriteLine(prod.name);
                }

                pg = new PagedDataSource();
                pg.DataSource = departmentList;
                pg.AllowPaging = true;
                pg.PageSize = 5;
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