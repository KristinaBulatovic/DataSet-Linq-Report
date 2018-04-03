using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class ProductForm : Form
    {

        UpdateOrders uo;
        UpdatePersonalInformationForm upif;
        btn_SearchOrderID report;
        string username;
        string id;

        public ProductForm(string empUsername, string empID)
        {
            InitializeComponent();
            username = empUsername;
            id = empID;
            labUsername.Text = empUsername;
            uo = new UpdateOrders(id);
        }

        private string Total()
        {
            string conStr = Properties.Settings.Default.NorthwindConnectionString;
            SqlConnection conn = new SqlConnection(conStr); ;
            SqlCommand cmd;
            string t;

            conn.Open();
            cmd = new SqlCommand("SELECT sum(UnitPrice * Quantity) FROM dbo.[Order Details]", conn);
            t = cmd.ExecuteScalar().ToString();
            conn.Close();

            t = (Math.Round(Convert.ToDecimal(t), 2)).ToString();

            return t;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(northwindDataSet.Products);
            order_DetailsTableAdapter.Fill(northwindDataSet.Order_Details);

            customersTableAdapter.Fill(northwindDataSet.Customers);
            employeesTableAdapter.Fill(northwindDataSet.Employees);

            ordersTableAdapter.FillEmpoloyeeID(northwindDataSet.Orders, Convert.ToInt32(id));
            //ordersTableAdapter.Fill(northwindDataSet.Orders);
            //ordersBindingSource.Filter = "EmployeeID = " + id;

            if (comboBox2.Text != "")
            {
                labTotal.Text = Total();
                labCount.Text = comboBox2.SelectedValue.ToString();
            }
            else
            {
                labTotal.Text = "0";
                labCount.Text = "0";
            }

        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dateFrom = dtFrom.Value.ToShortDateString();
            string dateTo = dtTo.Value.ToShortDateString();
            ordersTableAdapter.FilterDate(northwindDataSet.Orders, Convert.ToDateTime(dateFrom), Convert.ToDateTime(dateTo), Convert.ToInt32(id));

            if (comboBox2.Text != "")
            {
                labTotal.Text = Total();
                labCount.Text = comboBox2.SelectedValue.ToString();
            }
            else
            {
                labTotal.Text = "0";
                labCount.Text = "0";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                labCount.Text = comboBox2.SelectedValue.ToString();
            }
            else
            {
                labCount.Text = "0";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            upif = new UpdatePersonalInformationForm(id);
            upif.ShowDialog();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            uo = new UpdateOrders(id);
            uo.ShowDialog();

            if (comboBox2.Text != "")
            {
                labTotal.Text = Total();
            }
            else
            {
                labTotal.Text = "0";
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.FillEmpoloyeeID(northwindDataSet.Orders, Convert.ToInt32(id));

            if (comboBox2.Text != "")
            {
                labTotal.Text = Total();
                labCount.Text = comboBox2.SelectedValue.ToString();
            }
            else
            {
                labTotal.Text = "0";
                labCount.Text = "0";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            report = new btn_SearchOrderID(id);
            report.ShowDialog();
        }
    }
}
