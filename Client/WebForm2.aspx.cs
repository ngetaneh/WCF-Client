using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace Client
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region GetEmployee
        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            ServiceReference1.IDepartmentService client = new ServiceReference1.DepartmentServiceClient();
            ServiceReference1.DepartmentRequest request = new ServiceReference1.DepartmentRequest("AXG120ABC",txtdept.Text);
            ServiceReference1.DepartmentInfo Department = client.GetDeptInfo(request);

            txtGender.Text = Department.Gender;
            txtDateOfBirth.Text = Department.DOB.ToShortDateString();
            txtTitle.Text = Department.jobTitle;
            txtSickLeave.Text = Department.sickLeave.ToString();
            txtVacationHrs.Text = Department.Vacation.ToString();

            lblMessage.Text = "Dept Info Retrived";

            //DepartmentService.IDepartmentService client = new DepartmentService.EmployeeServiceClient();
            //EmployeeService.EmployeeRequest request = new EmployeeService.EmployeeRequest("AXG120ABC", Convert.ToInt32(txtdept.Text));
            //EmployeeService.EmployeeInfo employee = client.GetEmployee(request);


            //txtName.Text = employee.Name;
            //txtGender.Text = employee.Gender;
            //txtDateOfBirth.Text = employee.DOB.ToShortDateString();

            //lblMessage.Text = "Employee retrieved";
        }
        #endregion

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
