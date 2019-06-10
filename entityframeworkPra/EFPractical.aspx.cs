using System;
using System.Linq;
using System.Web.UI.WebControls;


namespace entityframeworkPra
{
    public partial class EFPractical : System.Web.UI.Page
    {
        //demoEntities _dbObj;
        protected void Page_Load(object sender, EventArgs e)
        {
            //_dbObj = new demoEntities();

            BindGrid();




        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            using (demoEntities entities = new demoEntities())
            {
                employee emp = new employee();
                emp.Name = txtName.Text;
                emp.CompanyName = txtCname.Text;
                emp.Address = txtAdd.Text;

                entities.employees.Add(emp);
                entities.SaveChanges();
                Response.Write("<script>alert('Inserted Successfully..');</script>");
                BindGrid();
            }




            //employee emp = new employee();
            //emp.Name = txtName.Text;
            //emp.CompanyName = txtCname.Text;
            //emp.Address = txtAdd.Text;

            //_dbObj.employees.Add(emp);
            //_dbObj.SaveChanges();

            //Response.Write("<script>alert('Inserted Successfully..');</script>");

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //HERE I JUST CHANGE COMAPNAYNAME OF EMPLOYEE

            string empuser = txtName.Text;
            using (demoEntities entities = new demoEntities())
            {
                employee emp = entities.employees.First(i => i.Name == txtName.Text);
                emp.CompanyName = txtCname.Text;

                entities.SaveChanges();
                Response.Write("<script>alert('Updated Successfully..');</script>");
                BindGrid();

            }
        }

            protected void btnDelete_Click(object sender, EventArgs e)
            {
                string empuser = txtName.Text;
                using (demoEntities entities = new demoEntities())
                {
                    employee emp = entities.employees.First(i => i.Name == txtName.Text);
                    entities.employees.Remove(emp);

                    entities.SaveChanges();
                    Response.Write("<script>alert('Deleted Successfully..');</script>");
                    BindGrid();

                }
            }

            private void BindGrid()
            {
                using (demoEntities entities = new demoEntities())
                {

                gridView.DataSource = entities.employees.ToList<employee>();
                gridView.DataBind();
                //var load = from g in entities.employees select g;
                //if (load != null)
                //{
                //    gridView.DataSource = load.ToList();
                //    gridView.DataBind();
                //}
            }
            }
        }
    }
