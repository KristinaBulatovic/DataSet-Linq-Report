namespace Project1
{
    partial class UpdateOrders
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
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.Windows.Forms.Label shipViaLabel;
            System.Windows.Forms.Label freightLabel;
            System.Windows.Forms.Label shipNameLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label shipCityLabel;
            System.Windows.Forms.Label shipRegionLabel;
            System.Windows.Forms.Label shipPostalCodeLabel;
            System.Windows.Forms.Label shipCountryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOrders));
            this.northwindDataSet = new Project1.NorthwindDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Project1.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Project1.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipViaTextBox = new System.Windows.Forms.TextBox();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.shipNameTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.shipCityTextBox = new System.Windows.Forms.TextBox();
            this.shipRegionTextBox = new System.Windows.Forms.TextBox();
            this.shipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailsTableAdapter = new Project1.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.labCount = new System.Windows.Forms.Label();
            this.fKOrderDetailsOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            orderIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            shipViaLabel = new System.Windows.Forms.Label();
            freightLabel = new System.Windows.Forms.Label();
            shipNameLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            shipCityLabel = new System.Windows.Forms.Label();
            shipRegionLabel = new System.Windows.Forms.Label();
            shipPostalCodeLabel = new System.Windows.Forms.Label();
            shipCountryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(14, 118);
            orderIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(76, 22);
            orderIDLabel.TabIndex = 1;
            orderIDLabel.Text = "Order ID:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(14, 162);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(101, 22);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "Customer ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(14, 206);
            employeeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(103, 22);
            employeeIDLabel.TabIndex = 5;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(14, 252);
            orderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(91, 22);
            orderDateLabel.TabIndex = 7;
            orderDateLabel.Text = "Order Date:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(14, 296);
            requiredDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(111, 22);
            requiredDateLabel.TabIndex = 9;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(14, 340);
            shippedDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(106, 22);
            shippedDateLabel.TabIndex = 11;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shipViaLabel
            // 
            shipViaLabel.AutoSize = true;
            shipViaLabel.Location = new System.Drawing.Point(14, 382);
            shipViaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipViaLabel.Name = "shipViaLabel";
            shipViaLabel.Size = new System.Drawing.Size(72, 22);
            shipViaLabel.TabIndex = 13;
            shipViaLabel.Text = "Ship Via:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(486, 120);
            freightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(63, 22);
            freightLabel.TabIndex = 15;
            freightLabel.Text = "Freight:";
            // 
            // shipNameLabel
            // 
            shipNameLabel.AutoSize = true;
            shipNameLabel.Location = new System.Drawing.Point(486, 164);
            shipNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipNameLabel.Name = "shipNameLabel";
            shipNameLabel.Size = new System.Drawing.Size(91, 22);
            shipNameLabel.TabIndex = 17;
            shipNameLabel.Text = "Ship Name:";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(486, 208);
            shipAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(102, 22);
            shipAddressLabel.TabIndex = 19;
            shipAddressLabel.Text = "Ship Address:";
            // 
            // shipCityLabel
            // 
            shipCityLabel.AutoSize = true;
            shipCityLabel.Location = new System.Drawing.Point(486, 252);
            shipCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipCityLabel.Name = "shipCityLabel";
            shipCityLabel.Size = new System.Drawing.Size(78, 22);
            shipCityLabel.TabIndex = 21;
            shipCityLabel.Text = "Ship City:";
            // 
            // shipRegionLabel
            // 
            shipRegionLabel.AutoSize = true;
            shipRegionLabel.Location = new System.Drawing.Point(486, 296);
            shipRegionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipRegionLabel.Name = "shipRegionLabel";
            shipRegionLabel.Size = new System.Drawing.Size(96, 22);
            shipRegionLabel.TabIndex = 23;
            shipRegionLabel.Text = "Ship Region:";
            // 
            // shipPostalCodeLabel
            // 
            shipPostalCodeLabel.AutoSize = true;
            shipPostalCodeLabel.Location = new System.Drawing.Point(486, 340);
            shipPostalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipPostalCodeLabel.Name = "shipPostalCodeLabel";
            shipPostalCodeLabel.Size = new System.Drawing.Size(129, 22);
            shipPostalCodeLabel.TabIndex = 25;
            shipPostalCodeLabel.Text = "Ship Postal Code:";
            // 
            // shipCountryLabel
            // 
            shipCountryLabel.AutoSize = true;
            shipCountryLabel.Location = new System.Drawing.Point(486, 384);
            shipCountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            shipCountryLabel.Name = "shipCountryLabel";
            shipCountryLabel.Size = new System.Drawing.Size(106, 22);
            shipCountryLabel.TabIndex = 27;
            shipCountryLabel.Text = "Ship Country:";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(950, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            this.bindingNavigatorDeleteItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorDeleteItem_MouseDown);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(160, 113);
            this.orderIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(298, 29);
            this.orderIDTextBox.TabIndex = 2;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(160, 157);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(298, 29);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(160, 201);
            this.employeeIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(298, 29);
            this.employeeIDTextBox.TabIndex = 6;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(160, 245);
            this.orderDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.orderDateDateTimePicker.TabIndex = 8;
            // 
            // requiredDateDateTimePicker
            // 
            this.requiredDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateDateTimePicker.Location = new System.Drawing.Point(160, 289);
            this.requiredDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requiredDateDateTimePicker.Name = "requiredDateDateTimePicker";
            this.requiredDateDateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.requiredDateDateTimePicker.TabIndex = 10;
            // 
            // shippedDateDateTimePicker
            // 
            this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateDateTimePicker.Location = new System.Drawing.Point(160, 333);
            this.shippedDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
            this.shippedDateDateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.shippedDateDateTimePicker.TabIndex = 12;
            // 
            // shipViaTextBox
            // 
            this.shipViaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipVia", true));
            this.shipViaTextBox.Location = new System.Drawing.Point(160, 377);
            this.shipViaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipViaTextBox.Name = "shipViaTextBox";
            this.shipViaTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipViaTextBox.TabIndex = 14;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "Freight", true));
            this.freightTextBox.Location = new System.Drawing.Point(632, 115);
            this.freightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(298, 29);
            this.freightTextBox.TabIndex = 16;
            // 
            // shipNameTextBox
            // 
            this.shipNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipName", true));
            this.shipNameTextBox.Location = new System.Drawing.Point(632, 159);
            this.shipNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipNameTextBox.Name = "shipNameTextBox";
            this.shipNameTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipNameTextBox.TabIndex = 18;
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(632, 203);
            this.shipAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipAddressTextBox.TabIndex = 20;
            // 
            // shipCityTextBox
            // 
            this.shipCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCity", true));
            this.shipCityTextBox.Location = new System.Drawing.Point(632, 247);
            this.shipCityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipCityTextBox.Name = "shipCityTextBox";
            this.shipCityTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipCityTextBox.TabIndex = 22;
            // 
            // shipRegionTextBox
            // 
            this.shipRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipRegion", true));
            this.shipRegionTextBox.Location = new System.Drawing.Point(632, 291);
            this.shipRegionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipRegionTextBox.Name = "shipRegionTextBox";
            this.shipRegionTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipRegionTextBox.TabIndex = 24;
            // 
            // shipPostalCodeTextBox
            // 
            this.shipPostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipPostalCode", true));
            this.shipPostalCodeTextBox.Location = new System.Drawing.Point(632, 335);
            this.shipPostalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipPostalCodeTextBox.Name = "shipPostalCodeTextBox";
            this.shipPostalCodeTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipPostalCodeTextBox.TabIndex = 26;
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShipCountry", true));
            this.shipCountryTextBox.Location = new System.Drawing.Point(632, 379);
            this.shipCountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(298, 29);
            this.shipCountryTextBox.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "Total", true));
            this.comboBox1.DataSource = this.ordersBindingSource;
            this.comboBox1.DisplayMember = "OrderID";
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(369, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 30);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Total";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // order_DetailsBindingSource
            // 
            this.order_DetailsBindingSource.DataMember = "Order Details";
            this.order_DetailsBindingSource.DataSource = this.northwindDataSet;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(798, 45);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(18, 22);
            this.labCount.TabIndex = 30;
            this.labCount.Text = "0";
            // 
            // fKOrderDetailsOrdersBindingSource
            // 
            this.fKOrderDetailsOrdersBindingSource.DataMember = "FK_Order_Details_Orders";
            this.fKOrderDetailsOrdersBindingSource.DataSource = this.ordersBindingSource;
            // 
            // UpdateOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(950, 430);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateDateTimePicker);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateDateTimePicker);
            this.Controls.Add(shipViaLabel);
            this.Controls.Add(this.shipViaTextBox);
            this.Controls.Add(freightLabel);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(shipNameLabel);
            this.Controls.Add(this.shipNameTextBox);
            this.Controls.Add(shipAddressLabel);
            this.Controls.Add(this.shipAddressTextBox);
            this.Controls.Add(shipCityLabel);
            this.Controls.Add(this.shipCityTextBox);
            this.Controls.Add(shipRegionLabel);
            this.Controls.Add(this.shipRegionTextBox);
            this.Controls.Add(shipPostalCodeLabel);
            this.Controls.Add(this.shipPostalCodeTextBox);
            this.Controls.Add(shipCountryLabel);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UpdateOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrders";
            this.Load += new System.EventHandler(this.UpdateOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker requiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
        private System.Windows.Forms.TextBox shipViaTextBox;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.TextBox shipNameTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox shipCityTextBox;
        private System.Windows.Forms.TextBox shipRegionTextBox;
        private System.Windows.Forms.TextBox shipPostalCodeTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource order_DetailsBindingSource;
        private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.BindingSource fKOrderDetailsOrdersBindingSource;
    }
}