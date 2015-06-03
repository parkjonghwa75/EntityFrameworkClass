using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EntityFramework_Class_EC.Models;
using System.Web.ModelBinding;

namespace EntityFramework_Class_EC
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // use EF to connect to SQL
            using (EnterpriseComputingEntities db = new EnterpriseComputingEntities())
            {
                //use the student model to save the new model
                Student s = new Student();
                s.LastName = txtLastName.Text;
                s.FirstMidName = txtFirstName.Text;
                s.EnrollmentDate = Convert.ToDateTime(txtEnrollement.Text);

                db.Students.Add(s);
                db.SaveChanges();

                //redirect to the updated list page
                Response.Redirect("students.aspx");

            }
        }
    }
}