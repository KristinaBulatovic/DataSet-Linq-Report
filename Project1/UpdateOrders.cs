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
    public partial class UpdateOrders : Form
    {
        SqlTransaction tr;
        string id;
        string com = "";
        SqlConnection conn;
        SqlCommand cmd1;
        SqlCommand cmd2;
        string conStr;
        public UpdateOrders(string empID)
        {
            InitializeComponent();
            id = empID;
            conStr = Properties.Settings.Default.NorthwindConnectionString;
            conn = new SqlConnection(conStr);
            cmd1 = new SqlCommand("select * from Orders");
            cmd2 = new SqlCommand("select * from Order_Details");
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string text = "";
            if(com == "add")
            {
                text = "Uspesno ste dodali porudzbinu!";
            }
            else if (com == "del")
            {
                text = "Uspesno ste obrisali porudzbinu!";
            }
            else if(com == "")
            {
                text = "Uspesno ste izmenili porudzbinu!";
            }

            Validate();
            ordersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(northwindDataSet);

            MessageBox.Show(text);
        }

        private void UpdateOrders_Load(object sender, EventArgs e)
        {
            order_DetailsTableAdapter.Fill(northwindDataSet.Order_Details);


            ordersTableAdapter.FillEmpoloyeeID(northwindDataSet.Orders, Convert.ToInt32(id));
            //ordersTableAdapter.Fill(northwindDataSet.Orders);
            //ordersBindingSource.Filter = "EmployeeID = " + id;

            labCount.Text = comboBox1.SelectedValue.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            com = "del";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            com = "add";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labCount.Text = comboBox1.SelectedValue.ToString();
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            order_DetailsTableAdapter.Connection = ordersTableAdapter.Connection;

            ordersTableAdapter.Connection.Open();
            
            ordersTableAdapter.Connection.BeginTransaction();

            ordersTableAdapter.Transaction = tr;
            order_DetailsTableAdapter.Transaction = tr;

            NorthwindDataSet.OrdersRow tekOrd = (NorthwindDataSet.OrdersRow) ((DataRowView) ordersBindingSource.Current).Row;
            tekOrd.GetOrder_DetailsRows()

            //try
            //{
            //    order_DetailsTableAdapter.DeleteOrdersDetalis(northwindDataSet.Orders);
            //}
            //catch
            //{

            //}

        }
    }
}
