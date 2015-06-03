using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//ref model binding
using EntityFramework_Class_EC.Models;
using System.Web.ModelBinding;

namespace EntityFramework_Class_EC

{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time, populate student list
            if(!IsPostBack)
            {
                GetStudents();
            }
        }

        protected void GetStudents()
        {
            using (EnterpriseComputingEntities db = new EnterpriseComputingEntities())
            {

                var Students = from s in db.Students
                               select s;

                //bind the result to the gridview
                grdStudents.DataSource = Students.ToList();
                grdStudents.DataBind();
            }

        }
    }
}