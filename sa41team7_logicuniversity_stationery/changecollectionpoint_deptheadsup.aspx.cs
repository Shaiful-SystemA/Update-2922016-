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
    public partial class collectionpoint1 : System.Web.UI.Page
    {
        Controller.ChangeCollectionPointController ctrCollectionPoint;
        department dept;

        ChangeCollectionPointController mcpc = new ChangeCollectionPointController();

        protected void Page_Load(object sender, EventArgs e)
        {
            ctrCollectionPoint = new Controller.ChangeCollectionPointController();

          //  tb_currentcollectionpoint.Text = ctrCollectionPoint.getDepartmentByName();

        }

        public void Display(staff u)
        {
          //  tb_currentcollectionpoint.DataSource = mcpc.getDepartmentByName(u);

        }


        protected void rb_stationerystore_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            department p = new department();
            p.collectionpoint=rb_stationerystore.Text;
            p.collectionpoint=rb_managementschool.Text;
            p.collectionpoint=rb_medicalschool.Text;
            p.collectionpoint=rb_engineeringschool.Text;
            p.collectionpoint=rb_scienceschool.Text;
            p.collectionpoint = rb_universityhospital.Text;

            ctrCollectionPoint.updateDepartment(p);

            Response.Redirect("~/changecollectionpoint_deptheadsup.aspx");

        }


    }
}