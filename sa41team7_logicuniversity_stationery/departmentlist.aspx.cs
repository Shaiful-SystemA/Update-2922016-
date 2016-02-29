using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using sa41team7_logicuniversity_stationery.DAO;
using sa41team7_logicuniversity_stationery.Controller;


namespace sa41team7_logicuniversity_stationery
{
    public partial class departmentlist : System.Web.UI.Page
    {
        private int pos;
        private MaintainDepartmentListController c1;


        protected void Page_Load(object sender, EventArgs e)
        {
            c1 = new MaintainDepartmentListController();


            if (!IsPostBack)
            {
                this.ViewState["vs"] = 0;
            }

            pos = (int)this.ViewState["vs"];
            c1.getAllDepartments();

            c1.setPagedDataSourceCurrentPageIndex(pos);

            GridView1.DataSource = c1.getPagedDataSource();
            GridView1.DataBind(); 

        }
    }
}