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


    public partial class supplierinformation : System.Web.UI.Page
    {
        private int pos;        
        private MaintainSupplierInformationController c1;

        protected void Page_Load(object sender, EventArgs e)
        {
            c1 = new MaintainSupplierInformationController();


            if (!IsPostBack)
            {
                this.ViewState["vs"] = 0;
            }

            pos = (int)this.ViewState["vs"];
            c1.getAllSuppliers();

            c1.setPagedDataSourceCurrentPageIndex(pos);

            GridView1.DataSource = c1.getPagedDataSource();
            GridView1.DataBind(); 

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}