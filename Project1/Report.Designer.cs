namespace Project1
{
    partial class btn_SearchOrderID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NorthwindDataSet = new Project1.NorthwindDataSet();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_OrderDetails = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.OrdersTableAdapter = new Project1.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.Order_DetailsTableAdapter = new Project1.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Project1.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFill = new System.Windows.Forms.Button();
            this.customersTableAdapter = new Project1.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Project1.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Project1.NorthwindDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_DetailsBindingSource
            // 
            this.Order_DetailsBindingSource.DataMember = "Order Details";
            this.Order_DetailsBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // NorthwindDataSet
            // 
            this.NorthwindDataSet.DataSetName = "NorthwindDataSet";
            this.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // cb_OrderDetails
            // 
            this.cb_OrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_OrderDetails.FormattingEnabled = true;
            this.cb_OrderDetails.Location = new System.Drawing.Point(12, 12);
            this.cb_OrderDetails.Name = "cb_OrderDetails";
            this.cb_OrderDetails.Size = new System.Drawing.Size(141, 30);
            this.cb_OrderDetails.TabIndex = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(159, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 30);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // Order_DetailsTableAdapter
            // 
            this.Order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Order_DetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 419);
            this.reportViewer1.TabIndex = 52;
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.Location = new System.Drawing.Point(579, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(93, 30);
            this.btnFill.TabIndex = 53;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = this.Order_DetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.OrdersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_SearchOrderID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 488);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cb_OrderDetails);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "btn_SearchOrderID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Order_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private NorthwindDataSet NorthwindDataSet;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        private System.Windows.Forms.BindingSource Order_DetailsBindingSource;
        private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter Order_DetailsTableAdapter;
        private System.Windows.Forms.ComboBox cb_OrderDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnFill;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}