using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class UpdatePersonalInformationForm : Form
    {
        string id;
        public UpdatePersonalInformationForm(string empID)
        {
            InitializeComponent();
            id = empID;
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            employeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(northwindDataSet);

        }

        private void UpdatePersonalInformationForm_Load(object sender, EventArgs e)
        {
            employeesTableAdapter.Fill(northwindDataSet.Employees);
            employeesBindingSource.Filter = "EmployeeID = " + id; ;

        }
    }
}
