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
using System.Configuration;

namespace Project1
{
    public partial class LoginForm : Form
    {
        ProductForm pf;
        string username;
        string password;
        string id;
        SqlConnection conn;
        SqlCommand cmd;
        string conStr;
     
        public LoginForm()
        {
            InitializeComponent();
            conStr = Properties.Settings.Default.NorthwindConnectionString;
            conn = new SqlConnection(conStr); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            //username = "Andrew"; //FirstName
            //password = "(206) 555-9482"; //HomePhone

            conn.Open();
            cmd = new SqlCommand("select EmployeeID from Employees where FirstName = @username and HomePhone = @password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            id = cmd.ExecuteScalar().ToString();

            if (id != "-1")
            {
                conn.Close();
                pf = new ProductForm(username, id);
                Hide();
                pf.ShowDialog();
            }
            else
            {
                conn.Close();
                MessageBox.Show("Enter the correct Username and Password!!");
            }
        }
    }
}
