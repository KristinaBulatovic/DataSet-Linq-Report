using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Project1
{
    public partial class btn_SearchOrderID : Form
    {

        string id;
        DataSet ds;
        SqlDataAdapter da;
        BindingSource bs;
        List<string> employee = new List<string>();
        List<string> customer = new List<string>();

        public btn_SearchOrderID(string empID)
        {
            InitializeComponent();
            id = empID;
            ds = new DataSet();
            da = new SqlDataAdapter("select * from Orders", Properties.Settings.Default.NorthwindConnectionString);
            ds.Tables.Add("Orders");
            bs = new BindingSource(ds, "Orders");
        }

        public void Order_Details_fill_name()
        {
            foreach (NorthwindDataSet.Order_DetailsRow row in NorthwindDataSet.Order_Details)
            { 
                row.ProductName = NorthwindDataSet.Products.FindByProductID(row.ProductID).ProductName; ;
            }
            reportViewer1.RefreshReport();
        }

        private void Report_Load(object sender, EventArgs e)
        {
           
            productsTableAdapter.Fill(NorthwindDataSet.Products);
            employeesTableAdapter.Fill(NorthwindDataSet.Employees);
            customersTableAdapter.Fill(NorthwindDataSet.Customers);
            OrdersTableAdapter.Fill(NorthwindDataSet.Orders);

            var q = from em in NorthwindDataSet.Employees
                    where em.EmployeeID == Convert.ToInt32(id)
                    select new
                    {
                        firstName = em.FirstName,
                        lastName = em.LastName
                    };

            foreach (var i in q)
            {
                employee.Add(i.firstName);
                employee.Add(i.lastName);
            }

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("parameterFirstName", employee[0]));
            reportParameters.Add(new ReportParameter("parameterLastName", employee[1]));
            reportViewer1.LocalReport.SetParameters(reportParameters);

            da.Fill(ds.Tables["Orders"]);
            cb_OrderDetails.DataSource = bs;
            cb_OrderDetails.DisplayMember = "OrderID";

            Order_DetailsTableAdapter.Fill(NorthwindDataSet.Order_Details);
            Order_Details_fill_name();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customer.Clear();
            var innerJoin = from cust in NorthwindDataSet.Customers
                            join ord in NorthwindDataSet.Orders on cust.CustomerID equals ord.CustomerID
                            where ord.OrderID == Convert.ToInt32(cb_OrderDetails.Text)
                            select new
                            {
                                name = cust.CompanyName,
                                contact = cust.ContactName,
                                address = cust.Address,
                                city = cust.City
                            };

            foreach (var i in innerJoin)
            {
                customer.Add(i.name);
                customer.Add(i.contact);
                customer.Add(i.address);
                customer.Add(i.city);
            }

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("parameterCompanyName", customer[0]));
            reportParameters.Add(new ReportParameter("parameterContactName", customer[1]));
            reportParameters.Add(new ReportParameter("parameterAddress", customer[2]));
            reportParameters.Add(new ReportParameter("parameterCity", customer[3]));
            reportViewer1.LocalReport.SetParameters(reportParameters);

            Order_DetailsTableAdapter.FillOrderID(NorthwindDataSet.Order_Details, Convert.ToInt32(cb_OrderDetails.Text));
            Order_Details_fill_name();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("parameterCompanyName", " "));
            reportParameters.Add(new ReportParameter("parameterContactName", " "));
            reportParameters.Add(new ReportParameter("parameterAddress", " "));
            reportParameters.Add(new ReportParameter("parameterCity", " "));
            reportViewer1.LocalReport.SetParameters(reportParameters);

            Order_DetailsTableAdapter.Fill(NorthwindDataSet.Order_Details);
            Order_Details_fill_name();
        }
    }
}
