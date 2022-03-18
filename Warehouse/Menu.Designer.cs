namespace Warehouse
{
    partial class Menu
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
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.WarehouseTab = new System.Windows.Forms.TabPage();
            this.WarehouseAddBox = new System.Windows.Forms.GroupBox();
            this.WarehouseSupervisorAddLabel = new System.Windows.Forms.Label();
            this.WarehouseSupervisorInput = new System.Windows.Forms.TextBox();
            this.WarehouseAddressAddLabel = new System.Windows.Forms.Label();
            this.WarehouseAddressInput = new System.Windows.Forms.TextBox();
            this.WarehouseAddBtn = new System.Windows.Forms.Button();
            this.WarehouseNameAddLabel = new System.Windows.Forms.Label();
            this.WarehouseNameInput = new System.Windows.Forms.TextBox();
            this.WarehouseEditBox = new System.Windows.Forms.GroupBox();
            this.WarehouseSupervisorEditLabel = new System.Windows.Forms.Label();
            this.WarehouseSupervisorOutput = new System.Windows.Forms.TextBox();
            this.WarehouseAddressEditLabel = new System.Windows.Forms.Label();
            this.WarehouseAddressOutput = new System.Windows.Forms.TextBox();
            this.WarehouseEditBtn = new System.Windows.Forms.Button();
            this.WarehouseNameEditLabel = new System.Windows.Forms.Label();
            this.WarehouseIDEditLabel = new System.Windows.Forms.Label();
            this.WarehouseNameOutput = new System.Windows.Forms.TextBox();
            this.WarehouseIDOutput = new System.Windows.Forms.TextBox();
            this.WarehouseList = new System.Windows.Forms.ComboBox();
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.ProductAddBox = new System.Windows.Forms.GroupBox();
            this.ProductExpiryLabelInput = new System.Windows.Forms.Label();
            this.ProductExpiryInput = new System.Windows.Forms.TextBox();
            this.ProductAddBtn = new System.Windows.Forms.Button();
            this.ProductNameLabelInput = new System.Windows.Forms.Label();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.ProductEditBox = new System.Windows.Forms.GroupBox();
            this.ProductExpiryLabelOutput = new System.Windows.Forms.Label();
            this.ProductExpiryOutput = new System.Windows.Forms.TextBox();
            this.ProductEditBtn = new System.Windows.Forms.Button();
            this.ProductNameLabelOutput = new System.Windows.Forms.Label();
            this.ProductIDLabelOutput = new System.Windows.Forms.Label();
            this.ProductNameOutput = new System.Windows.Forms.TextBox();
            this.ProductIDOutput = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.SupplierPage = new System.Windows.Forms.TabPage();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.SupplyTab = new System.Windows.Forms.TabPage();
            this.SaleTab = new System.Windows.Forms.TabPage();
            this.ReportTab = new System.Windows.Forms.TabPage();
            this.TabMenu.SuspendLayout();
            this.WarehouseTab.SuspendLayout();
            this.WarehouseAddBox.SuspendLayout();
            this.WarehouseEditBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            this.ProductTab.SuspendLayout();
            this.ProductAddBox.SuspendLayout();
            this.ProductEditBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.WarehouseTab);
            this.TabMenu.Controls.Add(this.ProductTab);
            this.TabMenu.Controls.Add(this.SupplierPage);
            this.TabMenu.Controls.Add(this.CustomerTab);
            this.TabMenu.Controls.Add(this.SupplyTab);
            this.TabMenu.Controls.Add(this.SaleTab);
            this.TabMenu.Controls.Add(this.ReportTab);
            this.TabMenu.Location = new System.Drawing.Point(1, -1);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(799, 452);
            this.TabMenu.TabIndex = 0;
            // 
            // WarehouseTab
            // 
            this.WarehouseTab.BackColor = System.Drawing.SystemColors.Control;
            this.WarehouseTab.Controls.Add(this.WarehouseAddBox);
            this.WarehouseTab.Controls.Add(this.WarehouseEditBox);
            this.WarehouseTab.Location = new System.Drawing.Point(4, 25);
            this.WarehouseTab.Name = "WarehouseTab";
            this.WarehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.WarehouseTab.Size = new System.Drawing.Size(791, 423);
            this.WarehouseTab.TabIndex = 0;
            this.WarehouseTab.Text = "Warehouse";
            this.WarehouseTab.Enter += new System.EventHandler(this.WarehouseTab_Enter);
            // 
            // WarehouseAddBox
            // 
            this.WarehouseAddBox.Controls.Add(this.WarehouseSupervisorAddLabel);
            this.WarehouseAddBox.Controls.Add(this.WarehouseSupervisorInput);
            this.WarehouseAddBox.Controls.Add(this.WarehouseAddressAddLabel);
            this.WarehouseAddBox.Controls.Add(this.WarehouseAddressInput);
            this.WarehouseAddBox.Controls.Add(this.WarehouseAddBtn);
            this.WarehouseAddBox.Controls.Add(this.WarehouseNameAddLabel);
            this.WarehouseAddBox.Controls.Add(this.WarehouseNameInput);
            this.WarehouseAddBox.Location = new System.Drawing.Point(41, 277);
            this.WarehouseAddBox.Name = "WarehouseAddBox";
            this.WarehouseAddBox.Size = new System.Drawing.Size(714, 117);
            this.WarehouseAddBox.TabIndex = 1;
            this.WarehouseAddBox.TabStop = false;
            this.WarehouseAddBox.Text = "Add Warehouse";
            // 
            // WarehouseSupervisorAddLabel
            // 
            this.WarehouseSupervisorAddLabel.AutoSize = true;
            this.WarehouseSupervisorAddLabel.Location = new System.Drawing.Point(466, 36);
            this.WarehouseSupervisorAddLabel.Name = "WarehouseSupervisorAddLabel";
            this.WarehouseSupervisorAddLabel.Size = new System.Drawing.Size(78, 17);
            this.WarehouseSupervisorAddLabel.TabIndex = 12;
            this.WarehouseSupervisorAddLabel.Text = "Supervisor:";
            // 
            // WarehouseSupervisorInput
            // 
            this.WarehouseSupervisorInput.Location = new System.Drawing.Point(548, 31);
            this.WarehouseSupervisorInput.Name = "WarehouseSupervisorInput";
            this.WarehouseSupervisorInput.Size = new System.Drawing.Size(154, 24);
            this.WarehouseSupervisorInput.TabIndex = 11;
            // 
            // WarehouseAddressAddLabel
            // 
            this.WarehouseAddressAddLabel.AutoSize = true;
            this.WarehouseAddressAddLabel.Location = new System.Drawing.Point(239, 35);
            this.WarehouseAddressAddLabel.Name = "WarehouseAddressAddLabel";
            this.WarehouseAddressAddLabel.Size = new System.Drawing.Size(61, 17);
            this.WarehouseAddressAddLabel.TabIndex = 10;
            this.WarehouseAddressAddLabel.Text = "Address:";
            // 
            // WarehouseAddressInput
            // 
            this.WarehouseAddressInput.Location = new System.Drawing.Point(302, 31);
            this.WarehouseAddressInput.Name = "WarehouseAddressInput";
            this.WarehouseAddressInput.Size = new System.Drawing.Size(149, 24);
            this.WarehouseAddressInput.TabIndex = 9;
            // 
            // WarehouseAddBtn
            // 
            this.WarehouseAddBtn.Location = new System.Drawing.Point(21, 74);
            this.WarehouseAddBtn.Name = "WarehouseAddBtn";
            this.WarehouseAddBtn.Size = new System.Drawing.Size(681, 23);
            this.WarehouseAddBtn.TabIndex = 7;
            this.WarehouseAddBtn.Text = "Add";
            this.WarehouseAddBtn.UseVisualStyleBackColor = true;
            this.WarehouseAddBtn.Click += new System.EventHandler(this.WarehouseAddBtn_Click);
            // 
            // WarehouseNameAddLabel
            // 
            this.WarehouseNameAddLabel.AutoSize = true;
            this.WarehouseNameAddLabel.Location = new System.Drawing.Point(18, 35);
            this.WarehouseNameAddLabel.Name = "WarehouseNameAddLabel";
            this.WarehouseNameAddLabel.Size = new System.Drawing.Size(48, 17);
            this.WarehouseNameAddLabel.TabIndex = 8;
            this.WarehouseNameAddLabel.Text = "Name:";
            // 
            // WarehouseNameInput
            // 
            this.WarehouseNameInput.Location = new System.Drawing.Point(69, 31);
            this.WarehouseNameInput.Name = "WarehouseNameInput";
            this.WarehouseNameInput.Size = new System.Drawing.Size(154, 24);
            this.WarehouseNameInput.TabIndex = 7;
            // 
            // WarehouseEditBox
            // 
            this.WarehouseEditBox.Controls.Add(this.WarehouseSupervisorEditLabel);
            this.WarehouseEditBox.Controls.Add(this.WarehouseSupervisorOutput);
            this.WarehouseEditBox.Controls.Add(this.WarehouseAddressEditLabel);
            this.WarehouseEditBox.Controls.Add(this.WarehouseAddressOutput);
            this.WarehouseEditBox.Controls.Add(this.WarehouseEditBtn);
            this.WarehouseEditBox.Controls.Add(this.WarehouseNameEditLabel);
            this.WarehouseEditBox.Controls.Add(this.WarehouseIDEditLabel);
            this.WarehouseEditBox.Controls.Add(this.WarehouseNameOutput);
            this.WarehouseEditBox.Controls.Add(this.WarehouseIDOutput);
            this.WarehouseEditBox.Controls.Add(this.WarehouseList);
            this.WarehouseEditBox.Controls.Add(this.WarehouseGridView);
            this.WarehouseEditBox.Location = new System.Drawing.Point(41, 28);
            this.WarehouseEditBox.Name = "WarehouseEditBox";
            this.WarehouseEditBox.Size = new System.Drawing.Size(714, 231);
            this.WarehouseEditBox.TabIndex = 0;
            this.WarehouseEditBox.TabStop = false;
            this.WarehouseEditBox.Text = "Edit Warehouse";
            // 
            // WarehouseSupervisorEditLabel
            // 
            this.WarehouseSupervisorEditLabel.AutoSize = true;
            this.WarehouseSupervisorEditLabel.Location = new System.Drawing.Point(7, 164);
            this.WarehouseSupervisorEditLabel.Name = "WarehouseSupervisorEditLabel";
            this.WarehouseSupervisorEditLabel.Size = new System.Drawing.Size(78, 17);
            this.WarehouseSupervisorEditLabel.TabIndex = 10;
            this.WarehouseSupervisorEditLabel.Text = "Supervisor:";
            // 
            // WarehouseSupervisorOutput
            // 
            this.WarehouseSupervisorOutput.Location = new System.Drawing.Point(91, 160);
            this.WarehouseSupervisorOutput.Name = "WarehouseSupervisorOutput";
            this.WarehouseSupervisorOutput.Size = new System.Drawing.Size(132, 24);
            this.WarehouseSupervisorOutput.TabIndex = 9;
            // 
            // WarehouseAddressEditLabel
            // 
            this.WarehouseAddressEditLabel.AutoSize = true;
            this.WarehouseAddressEditLabel.Location = new System.Drawing.Point(24, 134);
            this.WarehouseAddressEditLabel.Name = "WarehouseAddressEditLabel";
            this.WarehouseAddressEditLabel.Size = new System.Drawing.Size(61, 17);
            this.WarehouseAddressEditLabel.TabIndex = 8;
            this.WarehouseAddressEditLabel.Text = "Address:";
            // 
            // WarehouseAddressOutput
            // 
            this.WarehouseAddressOutput.Location = new System.Drawing.Point(91, 130);
            this.WarehouseAddressOutput.Name = "WarehouseAddressOutput";
            this.WarehouseAddressOutput.Size = new System.Drawing.Size(132, 24);
            this.WarehouseAddressOutput.TabIndex = 7;
            // 
            // WarehouseEditBtn
            // 
            this.WarehouseEditBtn.Location = new System.Drawing.Point(11, 192);
            this.WarehouseEditBtn.Name = "WarehouseEditBtn";
            this.WarehouseEditBtn.Size = new System.Drawing.Size(212, 23);
            this.WarehouseEditBtn.TabIndex = 6;
            this.WarehouseEditBtn.Text = "Edit";
            this.WarehouseEditBtn.UseVisualStyleBackColor = true;
            this.WarehouseEditBtn.Click += new System.EventHandler(this.WarehouseEditBtn_Click);
            // 
            // WarehouseNameEditLabel
            // 
            this.WarehouseNameEditLabel.AutoSize = true;
            this.WarehouseNameEditLabel.Location = new System.Drawing.Point(36, 104);
            this.WarehouseNameEditLabel.Name = "WarehouseNameEditLabel";
            this.WarehouseNameEditLabel.Size = new System.Drawing.Size(48, 17);
            this.WarehouseNameEditLabel.TabIndex = 5;
            this.WarehouseNameEditLabel.Text = "Name:";
            // 
            // WarehouseIDEditLabel
            // 
            this.WarehouseIDEditLabel.AutoSize = true;
            this.WarehouseIDEditLabel.Location = new System.Drawing.Point(57, 73);
            this.WarehouseIDEditLabel.Name = "WarehouseIDEditLabel";
            this.WarehouseIDEditLabel.Size = new System.Drawing.Size(27, 17);
            this.WarehouseIDEditLabel.TabIndex = 4;
            this.WarehouseIDEditLabel.Text = "ID:";
            // 
            // WarehouseNameOutput
            // 
            this.WarehouseNameOutput.Location = new System.Drawing.Point(91, 100);
            this.WarehouseNameOutput.Name = "WarehouseNameOutput";
            this.WarehouseNameOutput.Size = new System.Drawing.Size(132, 24);
            this.WarehouseNameOutput.TabIndex = 2;
            // 
            // WarehouseIDOutput
            // 
            this.WarehouseIDOutput.Enabled = false;
            this.WarehouseIDOutput.Location = new System.Drawing.Point(91, 69);
            this.WarehouseIDOutput.Name = "WarehouseIDOutput";
            this.WarehouseIDOutput.Size = new System.Drawing.Size(132, 24);
            this.WarehouseIDOutput.TabIndex = 3;
            // 
            // WarehouseList
            // 
            this.WarehouseList.FormattingEnabled = true;
            this.WarehouseList.Location = new System.Drawing.Point(11, 37);
            this.WarehouseList.Name = "WarehouseList";
            this.WarehouseList.Size = new System.Drawing.Size(212, 24);
            this.WarehouseList.TabIndex = 1;
            this.WarehouseList.SelectedIndexChanged += new System.EventHandler(this.WarehouseList_SelectedIndexChanged);
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.Location = new System.Drawing.Point(302, 37);
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.RowHeadersWidth = 51;
            this.WarehouseGridView.RowTemplate.Height = 26;
            this.WarehouseGridView.Size = new System.Drawing.Size(400, 176);
            this.WarehouseGridView.TabIndex = 0;
            this.WarehouseGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WarehouseGridView_RowHeaderMouseClick);
            // 
            // ProductTab
            // 
            this.ProductTab.BackColor = System.Drawing.SystemColors.Control;
            this.ProductTab.Controls.Add(this.ProductAddBox);
            this.ProductTab.Controls.Add(this.ProductEditBox);
            this.ProductTab.Location = new System.Drawing.Point(4, 25);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTab.Size = new System.Drawing.Size(791, 423);
            this.ProductTab.TabIndex = 1;
            this.ProductTab.Text = "Product";
            this.ProductTab.Enter += new System.EventHandler(this.ProductTab_Enter);
            // 
            // ProductAddBox
            // 
            this.ProductAddBox.Controls.Add(this.ProductExpiryLabelInput);
            this.ProductAddBox.Controls.Add(this.ProductExpiryInput);
            this.ProductAddBox.Controls.Add(this.ProductAddBtn);
            this.ProductAddBox.Controls.Add(this.ProductNameLabelInput);
            this.ProductAddBox.Controls.Add(this.ProductNameInput);
            this.ProductAddBox.Location = new System.Drawing.Point(41, 277);
            this.ProductAddBox.Name = "ProductAddBox";
            this.ProductAddBox.Size = new System.Drawing.Size(714, 117);
            this.ProductAddBox.TabIndex = 2;
            this.ProductAddBox.TabStop = false;
            this.ProductAddBox.Text = "Add Product";
            // 
            // ProductExpiryLabelInput
            // 
            this.ProductExpiryLabelInput.AutoSize = true;
            this.ProductExpiryLabelInput.Location = new System.Drawing.Point(248, 35);
            this.ProductExpiryLabelInput.Name = "ProductExpiryLabelInput";
            this.ProductExpiryLabelInput.Size = new System.Drawing.Size(52, 17);
            this.ProductExpiryLabelInput.TabIndex = 10;
            this.ProductExpiryLabelInput.Text = "Expiry:";
            // 
            // ProductExpiryInput
            // 
            this.ProductExpiryInput.Location = new System.Drawing.Point(302, 31);
            this.ProductExpiryInput.Name = "ProductExpiryInput";
            this.ProductExpiryInput.Size = new System.Drawing.Size(149, 24);
            this.ProductExpiryInput.TabIndex = 9;
            // 
            // ProductAddBtn
            // 
            this.ProductAddBtn.Location = new System.Drawing.Point(21, 74);
            this.ProductAddBtn.Name = "ProductAddBtn";
            this.ProductAddBtn.Size = new System.Drawing.Size(681, 23);
            this.ProductAddBtn.TabIndex = 7;
            this.ProductAddBtn.Text = "Add";
            this.ProductAddBtn.UseVisualStyleBackColor = true;
            this.ProductAddBtn.Click += new System.EventHandler(this.ProductAddBtn_Click);
            // 
            // ProductNameLabelInput
            // 
            this.ProductNameLabelInput.AutoSize = true;
            this.ProductNameLabelInput.Location = new System.Drawing.Point(18, 35);
            this.ProductNameLabelInput.Name = "ProductNameLabelInput";
            this.ProductNameLabelInput.Size = new System.Drawing.Size(48, 17);
            this.ProductNameLabelInput.TabIndex = 8;
            this.ProductNameLabelInput.Text = "Name:";
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Location = new System.Drawing.Point(69, 31);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(154, 24);
            this.ProductNameInput.TabIndex = 7;
            // 
            // ProductEditBox
            // 
            this.ProductEditBox.Controls.Add(this.ProductExpiryLabelOutput);
            this.ProductEditBox.Controls.Add(this.ProductExpiryOutput);
            this.ProductEditBox.Controls.Add(this.ProductEditBtn);
            this.ProductEditBox.Controls.Add(this.ProductNameLabelOutput);
            this.ProductEditBox.Controls.Add(this.ProductIDLabelOutput);
            this.ProductEditBox.Controls.Add(this.ProductNameOutput);
            this.ProductEditBox.Controls.Add(this.ProductIDOutput);
            this.ProductEditBox.Controls.Add(this.ProductList);
            this.ProductEditBox.Controls.Add(this.ProductGridView);
            this.ProductEditBox.Location = new System.Drawing.Point(41, 28);
            this.ProductEditBox.Name = "ProductEditBox";
            this.ProductEditBox.Size = new System.Drawing.Size(714, 231);
            this.ProductEditBox.TabIndex = 1;
            this.ProductEditBox.TabStop = false;
            this.ProductEditBox.Text = "Edit Product";
            // 
            // ProductExpiryLabelOutput
            // 
            this.ProductExpiryLabelOutput.AutoSize = true;
            this.ProductExpiryLabelOutput.Location = new System.Drawing.Point(32, 134);
            this.ProductExpiryLabelOutput.Name = "ProductExpiryLabelOutput";
            this.ProductExpiryLabelOutput.Size = new System.Drawing.Size(52, 17);
            this.ProductExpiryLabelOutput.TabIndex = 8;
            this.ProductExpiryLabelOutput.Text = "Expiry:";
            // 
            // ProductExpiryOutput
            // 
            this.ProductExpiryOutput.Location = new System.Drawing.Point(91, 130);
            this.ProductExpiryOutput.Name = "ProductExpiryOutput";
            this.ProductExpiryOutput.Size = new System.Drawing.Size(132, 24);
            this.ProductExpiryOutput.TabIndex = 7;
            // 
            // ProductEditBtn
            // 
            this.ProductEditBtn.Location = new System.Drawing.Point(11, 192);
            this.ProductEditBtn.Name = "ProductEditBtn";
            this.ProductEditBtn.Size = new System.Drawing.Size(212, 23);
            this.ProductEditBtn.TabIndex = 6;
            this.ProductEditBtn.Text = "Edit";
            this.ProductEditBtn.UseVisualStyleBackColor = true;
            this.ProductEditBtn.Click += new System.EventHandler(this.ProductEditBtn_Click);
            // 
            // ProductNameLabelOutput
            // 
            this.ProductNameLabelOutput.AutoSize = true;
            this.ProductNameLabelOutput.Location = new System.Drawing.Point(36, 104);
            this.ProductNameLabelOutput.Name = "ProductNameLabelOutput";
            this.ProductNameLabelOutput.Size = new System.Drawing.Size(48, 17);
            this.ProductNameLabelOutput.TabIndex = 5;
            this.ProductNameLabelOutput.Text = "Name:";
            // 
            // ProductIDLabelOutput
            // 
            this.ProductIDLabelOutput.AutoSize = true;
            this.ProductIDLabelOutput.Location = new System.Drawing.Point(57, 73);
            this.ProductIDLabelOutput.Name = "ProductIDLabelOutput";
            this.ProductIDLabelOutput.Size = new System.Drawing.Size(27, 17);
            this.ProductIDLabelOutput.TabIndex = 4;
            this.ProductIDLabelOutput.Text = "ID:";
            // 
            // ProductNameOutput
            // 
            this.ProductNameOutput.Location = new System.Drawing.Point(91, 100);
            this.ProductNameOutput.Name = "ProductNameOutput";
            this.ProductNameOutput.Size = new System.Drawing.Size(132, 24);
            this.ProductNameOutput.TabIndex = 2;
            // 
            // ProductIDOutput
            // 
            this.ProductIDOutput.Enabled = false;
            this.ProductIDOutput.Location = new System.Drawing.Point(91, 69);
            this.ProductIDOutput.Name = "ProductIDOutput";
            this.ProductIDOutput.Size = new System.Drawing.Size(132, 24);
            this.ProductIDOutput.TabIndex = 3;
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(11, 37);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(212, 24);
            this.ProductList.TabIndex = 1;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(302, 37);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowTemplate.Height = 26;
            this.ProductGridView.Size = new System.Drawing.Size(400, 176);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductGridView_RowHeaderMouseClick);
            // 
            // SupplierPage
            // 
            this.SupplierPage.BackColor = System.Drawing.SystemColors.Control;
            this.SupplierPage.Location = new System.Drawing.Point(4, 25);
            this.SupplierPage.Name = "SupplierPage";
            this.SupplierPage.Padding = new System.Windows.Forms.Padding(3);
            this.SupplierPage.Size = new System.Drawing.Size(791, 423);
            this.SupplierPage.TabIndex = 1;
            this.SupplierPage.Text = "Supplier";
            // 
            // CustomerTab
            // 
            this.CustomerTab.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerTab.Location = new System.Drawing.Point(4, 25);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTab.Size = new System.Drawing.Size(791, 423);
            this.CustomerTab.TabIndex = 1;
            this.CustomerTab.Text = "Customer";
            // 
            // SupplyTab
            // 
            this.SupplyTab.BackColor = System.Drawing.SystemColors.Control;
            this.SupplyTab.ForeColor = System.Drawing.Color.Transparent;
            this.SupplyTab.Location = new System.Drawing.Point(4, 25);
            this.SupplyTab.Name = "SupplyTab";
            this.SupplyTab.Padding = new System.Windows.Forms.Padding(3);
            this.SupplyTab.Size = new System.Drawing.Size(791, 423);
            this.SupplyTab.TabIndex = 2;
            this.SupplyTab.Text = "Supply Permit";
            // 
            // SaleTab
            // 
            this.SaleTab.BackColor = System.Drawing.SystemColors.Control;
            this.SaleTab.Location = new System.Drawing.Point(4, 25);
            this.SaleTab.Name = "SaleTab";
            this.SaleTab.Padding = new System.Windows.Forms.Padding(3);
            this.SaleTab.Size = new System.Drawing.Size(791, 423);
            this.SaleTab.TabIndex = 3;
            this.SaleTab.Text = "Sale Permit";
            // 
            // ReportTab
            // 
            this.ReportTab.BackColor = System.Drawing.SystemColors.Control;
            this.ReportTab.Location = new System.Drawing.Point(4, 25);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTab.Size = new System.Drawing.Size(791, 423);
            this.ReportTab.TabIndex = 4;
            this.ReportTab.Text = "Report";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Control";
            this.TabMenu.ResumeLayout(false);
            this.WarehouseTab.ResumeLayout(false);
            this.WarehouseAddBox.ResumeLayout(false);
            this.WarehouseAddBox.PerformLayout();
            this.WarehouseEditBox.ResumeLayout(false);
            this.WarehouseEditBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            this.ProductTab.ResumeLayout(false);
            this.ProductAddBox.ResumeLayout(false);
            this.ProductAddBox.PerformLayout();
            this.ProductEditBox.ResumeLayout(false);
            this.ProductEditBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage WarehouseTab;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.TabPage SupplierPage;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.TabPage SupplyTab;
        private System.Windows.Forms.TabPage SaleTab;
        private System.Windows.Forms.TabPage ReportTab;
        private System.Windows.Forms.GroupBox WarehouseAddBox;
        private System.Windows.Forms.GroupBox WarehouseEditBox;
        private System.Windows.Forms.Label WarehouseNameEditLabel;
        private System.Windows.Forms.Label WarehouseIDEditLabel;
        private System.Windows.Forms.TextBox WarehouseNameOutput;
        private System.Windows.Forms.TextBox WarehouseIDOutput;
        private System.Windows.Forms.ComboBox WarehouseList;
        private System.Windows.Forms.DataGridView WarehouseGridView;
        private System.Windows.Forms.Button WarehouseAddBtn;
        private System.Windows.Forms.Label WarehouseNameAddLabel;
        private System.Windows.Forms.TextBox WarehouseNameInput;
        private System.Windows.Forms.Button WarehouseEditBtn;
        private System.Windows.Forms.Label WarehouseAddressAddLabel;
        private System.Windows.Forms.TextBox WarehouseAddressInput;
        private System.Windows.Forms.Label WarehouseSupervisorAddLabel;
        private System.Windows.Forms.TextBox WarehouseSupervisorInput;
        private System.Windows.Forms.Label WarehouseAddressEditLabel;
        private System.Windows.Forms.TextBox WarehouseAddressOutput;
        private System.Windows.Forms.Label WarehouseSupervisorEditLabel;
        private System.Windows.Forms.TextBox WarehouseSupervisorOutput;
        private System.Windows.Forms.GroupBox ProductAddBox;
        private System.Windows.Forms.Label ProductExpiryLabelInput;
        private System.Windows.Forms.TextBox ProductExpiryInput;
        private System.Windows.Forms.Button ProductAddBtn;
        private System.Windows.Forms.Label ProductNameLabelInput;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.GroupBox ProductEditBox;
        private System.Windows.Forms.Label ProductExpiryLabelOutput;
        private System.Windows.Forms.TextBox ProductExpiryOutput;
        private System.Windows.Forms.Button ProductEditBtn;
        private System.Windows.Forms.Label ProductNameLabelOutput;
        private System.Windows.Forms.Label ProductIDLabelOutput;
        private System.Windows.Forms.TextBox ProductNameOutput;
        private System.Windows.Forms.TextBox ProductIDOutput;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.DataGridView ProductGridView;
    }
}

