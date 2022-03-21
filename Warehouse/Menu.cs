using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Warehouse
{
    public partial class Menu : Form
    {
        #region Fields
        private WareHouseDBEntities Entries;
        #region ID References Lists
        private System.Collections.Generic.List<int> IndexList;
        private System.Collections.Generic.List<int> IndexList1;
        private System.Collections.Generic.List<int> IndexList2;
        private System.Collections.Generic.List<int> IndexList3;
        #endregion
        #endregion

        #region Form Constructor
        public Menu()
        {
            InitializeComponent();
            InitializeDB();
        }
        #endregion

        #region Methods

        #region Initalize Database
        private void InitializeDB()
        {
            Entries = new WareHouseDBEntities();
            IndexList = new List<int>();
            IndexList1 = new List<int>();
            IndexList2 = new List<int>();
            IndexList3 = new List<int>();
        }
        #endregion

        #region Entity Select Methods

        #region Warehouse Select Method
        private void WarehouseSelect(Func<Warehouse,bool> Criteria)
        {
            Warehouse FilteredWarehouse;
            if(Criteria == null)
            {
                WarehouseIDOutput.Text = String.Empty;
                WarehouseIDOutput.Text = String.Empty;
                WarehouseNameOutput.Text = String.Empty;
                WarehouseAddressOutput.Text = String.Empty;
                WarehouseSupervisorOutput.Text = String.Empty;
                WarehouseProductGrid.DataSource = Entries.GetDetailedQty().ToList();
            }
            else
            {
                FilteredWarehouse = Entries.Warehouses.Where(Criteria).FirstOrDefault();
                WarehouseIDOutput.Text = FilteredWarehouse.ID.ToString();
                WarehouseNameOutput.Text = FilteredWarehouse.Name;
                WarehouseAddressOutput.Text = FilteredWarehouse.Address;
                WarehouseSupervisorOutput.Text = FilteredWarehouse.Supervisor;
            }
        }
        #endregion

        #region Product Select Method
        private void ProductSelect(Func<Product, bool> Criteria)
        {
            Product FilteredProduct;
            if (Criteria == null)
            {
                ProductIDOutput.Text = String.Empty;
                ProductNameOutput.Text = String.Empty;
                ProductExpiryOutput.Text = String.Empty;
            }
            else
            {
                FilteredProduct = Entries.Products.Where(Criteria).FirstOrDefault<Product>();
                ProductIDOutput.Text = FilteredProduct.Code.ToString();
                ProductNameOutput.Text = FilteredProduct.Name;
                ProductExpiryOutput.Text = FilteredProduct.ExpPeriod.ToString();
            }
        }
        #endregion

        #region Supplier Select Method
        private void SupplierSelect(Func<Supplier, bool> Criteria)
        {
            Supplier FilteredSupplier;
            if (Criteria == null)
            {
                SupplierIDOutput.Text = String.Empty;
                SupplierNameOutput.Text = String.Empty;
                SupplierMobileOutput.Text = String.Empty;
                SupplierTeleOutput.Text = String.Empty;
                SupplierMailOutput.Text = String.Empty;
                SupplierSiteOutput.Text = String.Empty;
                SupplierFaxOutput.Text = String.Empty;
            }
            else
            {
                FilteredSupplier = Entries.Suppliers.Where(Criteria).FirstOrDefault<Supplier>();
                SupplierIDOutput.Text = FilteredSupplier.ID.ToString();
                SupplierNameOutput.Text = FilteredSupplier.Name;
                SupplierMobileOutput.Text = FilteredSupplier.MobileNo.ToString();
                SupplierTeleOutput.Text = FilteredSupplier.TeleNo.ToString();
                SupplierMailOutput.Text = FilteredSupplier.Mail;
                SupplierSiteOutput.Text = FilteredSupplier.Site;
                SupplierFaxOutput.Text = FilteredSupplier.Fax.ToString();
            }
        }
        #endregion

        #region Customer Select Method
        private void CustomerSelect(Func<Customer, bool> Criteria)
        {
            Customer FilteredCustomer;
            if (Criteria == null)
            {
                CustomerIDOutput.Text = String.Empty;
                CustomerNameOutput.Text = String.Empty;
                CustomerMobileOutput.Text = String.Empty;
                CustomerTeleOutput.Text = String.Empty;
                CustomerMailOutput.Text = String.Empty;
                CustomerSiteOutput.Text = String.Empty;
                CustomerFaxOutput.Text = String.Empty;
            }
            else
            {
                FilteredCustomer = Entries.Customers.Where(Criteria).FirstOrDefault<Customer>();
                CustomerIDOutput.Text = FilteredCustomer.ID.ToString();
                CustomerNameOutput.Text = FilteredCustomer.Name;
                CustomerMobileOutput.Text = FilteredCustomer.MobileNo.ToString();
                CustomerTeleOutput.Text = FilteredCustomer.TeleNo.ToString();
                CustomerMailOutput.Text = FilteredCustomer.Mail;
                CustomerSiteOutput.Text = FilteredCustomer.Site;
                CustomerFaxOutput.Text = FilteredCustomer.Fax.ToString();
            }
        }
        #endregion

        #region Supply Permit Select Method
        private void SupplyPermitSelect(Func<Supply_Permit,bool> Criteria)
        {
            Supply_Permit FilteredSupplyPermit;
            if (Criteria == null)
            {
                SupplyPermitIDOutput.Text = String.Empty;
                SupplyPermitSupplierOutput.Text = String.Empty;
                SupplyPermitDateOutput.Text = String.Empty;
                SupplyPermitSupplierEditLocked.Text = SupplyPermitSupplierNewLocked.Text = String.Empty;
                SupplyPermitWarehouseEditLocked.Text = SupplyPermitWarehouseNewLocked.Text = String.Empty;
                SupplyPermitWarehouseOutput.Text = String.Empty;
                SupplyPermitProductDataGrid.DataSource = Entries.Supplies.ToList();
            }
            else
            {
                FilteredSupplyPermit = Entries.Supply_Permit.Where(Criteria).FirstOrDefault();
                SupplyPermitIDOutput.Text = FilteredSupplyPermit.ID.ToString();
                SupplyPermitSupplierOutput.Text = FilteredSupplyPermit.Supplier.Name;
                SupplyPermitSupplierEditLocked.Text = SupplyPermitSupplierNewLocked.Text = FilteredSupplyPermit.Supplier.ID.ToString();
                SupplyPermitDateOutput.Text = FilteredSupplyPermit.Date.ToShortDateString();
                SupplyPermitWarehouseEditLocked.Text = SupplyPermitWarehouseNewLocked.Text = FilteredSupplyPermit.Warehouse_FK.ToString();
                SupplyPermitWarehouseOutput.Text = FilteredSupplyPermit.Warehouse.Name;
            }
            SupplyPermitProductOutput.Text = String.Empty;
            SupplyPermitProDateOutput.Text = String.Empty;
            SupplyPermitQtyOutput.Text = String.Empty;
            SupplyPermitProductEditLocked.Text = SupplyPermitProductNewLocked.Text = String.Empty;
        }
        #endregion

        #endregion

        #endregion

        #region EventHandlers

        #region Warehouse Events

        #region Warehouse Active
        private void WarehouseTab_Enter(object sender, EventArgs e)
        {
            List<Warehouse> AllWarehouses = Entries.Warehouses.ToList();
            WarehouseGridView.DataSource = AllWarehouses;
            WarehouseList.Items.Clear();
            WarehouseList.Items.Add("All");
            IndexList.Clear();
            foreach (Warehouse WH in AllWarehouses)
            {
                WarehouseList.Items.Add(WH.Name);
                IndexList.Add(WH.ID);
            }
            int ColumnsCount = WarehouseGridView.Columns.Count;
            for (int i = 4; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                WarehouseGridView.Columns[i].Visible = false;
            }
        }
        #endregion

        #region Warehouse List Selected
        private void WarehouseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                int Index = List.SelectedIndex - 1;
                WarehouseSelect(WH => WH.ID == IndexList[List.SelectedIndex - 1]);
                WarehouseGridView.ClearSelection();
                WarehouseGridView.Rows[Index].Selected = true;
                WarehouseGridView_SelectionChanged(new object(), new EventArgs());
            }
            else
            {
                WarehouseGridView.ClearSelection();
                WarehouseSelect(null);
            }
        }
        #endregion

        #region Warehouse Product Row Header Multiple Selection 
        private void WarehouseGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<GetDetailedQty_Result> FilteredProducts = new List<GetDetailedQty_Result>();
            if(WarehouseGridView.SelectedRows.Count != 0)
            {
                foreach(DataGridViewRow Row in WarehouseGridView.SelectedRows)
                {
                    FilteredProducts.AddRange(Entries.GetDetailedQty().Where(DQ => DQ.Warehouse_ID == (int)Row.Cells[0].Value).ToList());
                }
            }
            else
            {
                FilteredProducts = Entries.GetDetailedQty().ToList();
            }
            WarehouseProductGrid.DataSource = FilteredProducts.OrderBy(DQ => DQ.Warehouse_ID).ToList();
            if (WarehouseGridView.SelectedRows.Count==1) {
                WarehouseProductGrid.Columns[0].Visible = false;
                WarehouseProductGrid.Columns[1].Visible = false;
            }
            else
            {
                WarehouseSelect(null);
                WarehouseProductGrid.Columns[0].Visible = true;
                WarehouseProductGrid.Columns[1].Visible = true;
            }
        }
        #endregion

        #region Warehouse Edit Button
        private void WarehouseEditBtn_Click(object sender, EventArgs e)
        {
            if (WarehouseIDOutput.Text != String.Empty)
            {
                int ID = int.Parse(WarehouseIDOutput.Text);
                Warehouse EditWH = Entries.Warehouses.Where(WH => WH.ID == ID).First();
                EditWH.Name = WarehouseNameOutput.Text != String.Empty ? WarehouseNameOutput.Text : EditWH.Name;
                EditWH.Address = WarehouseAddressOutput.Text != String.Empty ? WarehouseAddressOutput.Text : EditWH.Address;
                EditWH.Supervisor = WarehouseSupervisorOutput.Text != String.Empty ? WarehouseSupervisorOutput.Text : EditWH.Supervisor;
                Entries.SaveChanges();
                WarehouseSelect(null);
                WarehouseGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose a Warehouse to Edit!");
            }
        }
        #endregion

        #region Warehouse DataGrid Row Selected
        private void WarehouseGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            WarehouseSelect(WH => WH.ID == IndexList[e.RowIndex]);
        }
        #endregion

        #region Warehouse Add Button
        private void WarehouseAddBtn_Click(object sender, EventArgs e)
        {
            if(WarehouseNameInput.Text != String.Empty &&  WarehouseAddressInput.Text != String.Empty && WarehouseSupervisorInput.Text != String.Empty)
            {
                int ID = Entries.Warehouses.Max(WH => WH.ID);
                Entries.Warehouses.Add(new Warehouse() { ID = ID+1, Name = WarehouseNameInput.Text, Address = WarehouseAddressInput.Text, Supervisor = WarehouseSupervisorInput.Text });
                Entries.SaveChanges();
                WarehouseSelect(null);
                WarehouseGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter all Warehouse Fields!");
            }
        }
        #endregion

        #endregion

        #region Product Events

        #region Active Product Tab
        private void ProductTab_Enter(object sender, EventArgs e)
        {
            List<Product> AllProducts = Entries.Products.ToList();
            ProductGridView.DataSource = AllProducts;
            int ColumnsCount = ProductGridView.Columns.Count;
            for (int i = 3; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                ProductGridView.Columns[i].Visible = false;
            }
            ProductList.Items.Clear();
            ProductList.Items.Add("All");
            IndexList.Clear();
            foreach (Product PD in AllProducts)
            {
                ProductList.Items.Add(PD.Name);
                IndexList.Add(PD.Code);
            }
        }
        #endregion

        #region Product DataGrid Row Selected
        private void ProductGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductSelect(PD => PD.Code == IndexList[e.RowIndex]);
        }
        #endregion

        #region Product List Selected
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                ProductSelect(PD => PD.Code == IndexList[List.SelectedIndex - 1]);
                ProductGridView.ClearSelection();
                ProductGridView.Rows[List.SelectedIndex-1].Selected = true;
            }
            else
            {
                ProductGridView.ClearSelection();
                ProductSelect(null);
            }
        }
        #endregion

        #region Product Edit Button
        private void ProductEditBtn_Click(object sender, EventArgs e)
        {
            if (ProductIDOutput.Text != String.Empty)
            {
                int ID = int.Parse(ProductIDOutput.Text);
                Product EditPD = Entries.Products.Where(PD => PD.Code == ID).First();
                EditPD.Name = ProductNameOutput.Text != String.Empty ? ProductNameOutput.Text : EditPD.Name;
                EditPD.ExpPeriod = ProductExpiryOutput.Text != String.Empty ? int.Parse(ProductExpiryOutput.Text) : EditPD.ExpPeriod;
                Entries.SaveChanges();
                ProductSelect(null);
                ProductGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose a Product to Edit!");
            }
        }
        #endregion

        #region Product Add Button
        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            if (ProductNameLabelInput.Text != String.Empty && ProductExpiryInput.Text != String.Empty)
            {
                int ID = Entries.Products.Max(PD => PD.Code);
                Entries.Products.Add(new Product() { Code = ID+1, Name = ProductNameInput.Text, ExpPeriod = int.Parse(ProductExpiryInput.Text) });
                Entries.SaveChanges();
                ProductSelect(null);
                ProductGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter all Product Fields!");
            }
        }
        #endregion

        #endregion

        #region Supplier Events

        #region Supplier Tab Active
        private void SupplierPage_Enter(object sender, EventArgs e)
        {
            List<Supplier> AllSuppliers = Entries.Suppliers.ToList();
            SupplierDataGrid.DataSource = AllSuppliers;
            int ColumnsCount = SupplierDataGrid.Columns.Count;
            for (int i = 7; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                SupplierDataGrid.Columns[i].Visible=false;
            }
            SupplierList.Items.Clear();
            SupplierList.Items.Add("All");
            IndexList.Clear();
            foreach (Supplier SP in AllSuppliers)
            {
                SupplierList.Items.Add(SP.Name);
                IndexList.Add(SP.ID);
            }
        }
        #endregion

        #region Supplier DateGrid Row Selected
        private void SupplierDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SupplierSelect(SP => SP.ID == IndexList[e.RowIndex]);
        }
        #endregion

        #region Supplier List Selected
        private void SupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                SupplierSelect(SP => SP.ID == IndexList[List.SelectedIndex - 1]);
                SupplierDataGrid.ClearSelection();
                SupplierDataGrid.Rows[List.SelectedIndex - 1].Selected = true;
            }
            else
            {
                SupplierSelect(null);
                SupplierDataGrid.ClearSelection();
            }
        }
        #endregion

        #region Supplier Edit Button
        private void SupplierEditBtn_Click(object sender, EventArgs e)
        {
            if (SupplierIDOutput.Text != String.Empty)
            {
                int ID = int.Parse(SupplierIDOutput.Text);
                Supplier EditSP = Entries.Suppliers.Where(SP => SP.ID == ID).First();
                EditSP.Name = SupplierNameOutput.Text != String.Empty ? SupplierNameOutput.Text : EditSP.Name;
                EditSP.MobileNo = SupplierMobileOutput.Text != String.Empty ? int.Parse(SupplierMobileOutput.Text) : EditSP.MobileNo;
                EditSP.TeleNo = SupplierNameOutput.Text != String.Empty ? int.Parse(SupplierTeleOutput.Text) : EditSP.TeleNo;
                EditSP.Mail = SupplierMailOutput.Text != String.Empty ? SupplierMailOutput.Text : EditSP.Mail;
                EditSP.Site = SupplierSiteOutput.Text != String.Empty ? SupplierSiteOutput.Text : EditSP.Site;
                EditSP.Fax = SupplierFaxOutput.Text != String.Empty ? int.Parse(SupplierFaxOutput.Text) : EditSP.Fax;
                Entries.SaveChanges();
                SupplierSelect(null);
                SupplierDataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose a Supplier to Edit!");
            }
        }
        #endregion

        #region Supplier Add Button
        private void SupplierAddBtn_Click(object sender, EventArgs e)
        {
            if (SupplierNameInput.Text != String.Empty && SupplierMobileInput.Text != String.Empty && SupplierTeleInput.Text != String.Empty
                && SupplierMailInput.Text != String.Empty && SupplierSiteInput.Text != String.Empty && SupplierFaxInput.Text != String.Empty)
            {
                int ID = Entries.Suppliers.Max(SP => SP.ID);
                Entries.Suppliers.Add(new Supplier() { ID = ID+1, Name = SupplierNameInput.Text, MobileNo = int.Parse(SupplierMobileInput.Text),
                    TeleNo = int.Parse(SupplierTeleInput.Text), Mail = SupplierMailInput.Text, Site = SupplierSiteInput.Text, Fax = int.Parse(SupplierFaxInput.Text)});
                Entries.SaveChanges();
                SupplierSelect(null);
                SupplierDataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter all Supplier Fields!");
            }
        }
        #endregion

        #endregion

        #region Customer Events

        #region Customer Tab Active
        private void CustomerTab_Enter(object sender, EventArgs e)
        {
            List<Customer> AllCustomers = Entries.Customers.ToList<Customer>();
            CustomerDataGrid.DataSource = AllCustomers;
            int ColumnsCount = CustomerDataGrid.Columns.Count;
            for (int i = 7; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                CustomerDataGrid.Columns[i].Visible = false;
            }
            CustomerList.Items.Clear();
            CustomerList.Items.Add("All");
            IndexList.Clear();
            foreach (Customer CS in AllCustomers)
            {
                CustomerList.Items.Add(CS.Name);
                IndexList.Add(CS.ID);
            }
        }
        #endregion

        #region Customer DateGrid Row Selected
        private void CustomerDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustomerSelect(CS => CS.ID == IndexList[e.RowIndex]);
        }
        #endregion

        #region Customer List Selected
        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                CustomerSelect(CS => CS.ID == IndexList[List.SelectedIndex - 1]);
                CustomerDataGrid.ClearSelection();
                CustomerDataGrid.Rows[List.SelectedIndex - 1].Selected = true;
            }
            else
            {
                CustomerDataGrid.ClearSelection();
                CustomerSelect(null);
            }
        }
        #endregion

        #region Customer Edit Button
        private void CustomerEditBtn_Click(object sender, EventArgs e)
        {
            if (CustomerIDOutput.Text != String.Empty)
            {
                int ID = int.Parse(CustomerIDOutput.Text);
                Customer EditCS = Entries.Customers.Where(CS => CS.ID == ID).First();
                EditCS.Name = CustomerNameOutput.Text != String.Empty ? CustomerNameOutput.Text : EditCS.Name;
                EditCS.MobileNo = CustomerMobileOutput.Text != String.Empty ? int.Parse(CustomerMobileOutput.Text) : EditCS.MobileNo;
                EditCS.TeleNo = CustomerNameOutput.Text != String.Empty ? int.Parse(CustomerTeleOutput.Text) : EditCS.TeleNo;
                EditCS.Mail = CustomerMailOutput.Text != String.Empty ? CustomerMailOutput.Text : EditCS.Mail;
                EditCS.Site = CustomerSiteOutput.Text != String.Empty ? CustomerSiteOutput.Text : EditCS.Site;
                EditCS.Fax = CustomerFaxOutput.Text != String.Empty ? int.Parse(CustomerFaxOutput.Text) : EditCS.Fax;
                Entries.SaveChanges();
                CustomerSelect(null);
                CustomerDataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose a Customer to Edit!");
            }
        }
        #endregion

        #region Customer Add Button
        private void CustomerAddBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameInput.Text != String.Empty && CustomerMobileInput.Text != String.Empty && CustomerTeleInput.Text != String.Empty
                && CustomerMailInput.Text != String.Empty && CustomerSiteInput.Text != String.Empty && CustomerFaxInput.Text != String.Empty)
            {
                int ID = Entries.Customers.Max(CS => CS.ID);
                Entries.Customers.Add(new Customer()
                {
                    ID = ID + 1,
                    Name = CustomerNameInput.Text,
                    MobileNo = int.Parse(CustomerMobileInput.Text),
                    TeleNo = int.Parse(CustomerTeleInput.Text),
                    Mail = CustomerMailInput.Text,
                    Site = CustomerSiteInput.Text,
                    Fax = int.Parse(CustomerFaxInput.Text)
                });
                Entries.SaveChanges();
                CustomerSelect(null);
                CustomerDataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter all Customer Fields!");
            }
        }
        #endregion

        #endregion

        #region Supply Permit Events

        #region Supply Tab Active
        private void SupplyTab_Enter(object sender, EventArgs e)
        {
            List<Supply_Permit> AllSupplyPermits = Entries.Supply_Permit.ToList();
            List<Product> AllProducts = Entries.Products.ToList();
            List<Warehouse> AllWarehouses = Entries.Warehouses.ToList();
            List<Supplier> AllSuppliers = Entries.Suppliers.ToList();
            SupplyPermitDataGrid.DataSource = AllSupplyPermits;
            SupplyPermitList.Items.Clear();
            SupplyPermitList.Items.Add("All");
            SupplyPermitWarehouseOutput.Items.Clear();
            SupplyPermitProductOutput.Items.Clear();
            IndexList.Clear();
            IndexList1.Clear();
            IndexList2.Clear();
            IndexList3.Clear();
            foreach (Supply_Permit SP in AllSupplyPermits)
            {
                SupplyPermitList.Items.Add(SP.ID);
                IndexList.Add(SP.ID);
            }
            foreach (Warehouse WH in AllWarehouses)
            {
                IndexList1.Add(WH.ID);
                SupplyPermitWarehouseOutput.Items.Add(WH.Name);
            }
            foreach(Product PD in AllProducts)
            {
                IndexList2.Add(PD.Code);
                SupplyPermitProductOutput.Items.Add(PD.Name);
            }
            foreach(Supplier SP in AllSuppliers)
            {
                IndexList3.Add(SP.ID);
                SupplyPermitSupplierOutput.Items.Add(SP.Name);
            }
            int ColumnsCount = SupplyPermitDataGrid.Columns.Count;
            for (int i = 4; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                if (SupplyPermitDataGrid.Columns[i].Name != "Supplier" && SupplyPermitDataGrid.Columns[i].Name != "Warehouse" && SupplyPermitDataGrid.Columns[i].Name != "Warehouse_FK")
                    SupplyPermitDataGrid.Columns[i].Visible = false;
            }
            SupplyPermitDataGrid.Columns["Supplier"].DisplayIndex = 3;
        }
        #endregion

        #region Supply List Select
        private void SupplyPermitList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                int Index = List.SelectedIndex - 1;
                SupplyPermitSelect(SP => SP.ID == IndexList[List.SelectedIndex - 1]);
                SupplyPermitDataGrid.ClearSelection();
                SupplyPermitDataGrid.Rows[Index].Selected = true;
                //WarehouseGridView_SelectionChanged(new object(), new EventArgs());
            }
            else
            {
                SupplyPermitDataGrid.ClearSelection();
                SupplyPermitSelect(null);
            }
        }
        #endregion

        #region Supply Warehouse List Select
        private void SupplyPermitWarehouseOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            SupplyPermitWarehouseNewLocked.Text = IndexList1[List.SelectedIndex].ToString();

        }
        #endregion

        #region Supply Product List Select
        private void SupplyPermitProductOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            SupplyPermitProductNewLocked.Text = IndexList1[List.SelectedIndex].ToString();

        }
        #endregion

        #region Supply RowHeader Selected
        private void SupplyPermitDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SupplyPermitSelect(SP => SP.ID == IndexList[e.RowIndex]);
        }
        #endregion

        #region Supply Row Header Multiple Selection
        private void SupplyPermitDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            List<Supply> FilteredSupplies = new List<Supply>();
            if (SupplyPermitDataGrid.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow Row in SupplyPermitDataGrid.SelectedRows)
                {
                    int ID = (int)Row.Cells[0].Value;
                    FilteredSupplies.AddRange(Entries.Supplies.Where(SP => SP.Supply_Permit_FK == ID).ToList());
                }
            }
            else
            {
                FilteredSupplies = Entries.Supplies.ToList();
            }
            SupplyPermitProductDataGrid.DataSource = FilteredSupplies.OrderBy(SP => SP.Supply_Permit).OrderBy(SP => SP.Product_FK).ToList();
            SupplyPermitProductDataGrid.Columns["Supply_Permit"].HeaderText = "Warehouse";
            if (SupplyPermitDataGrid.SelectedRows.Count == 1)
            {
                SupplyPermitProductDataGrid.Columns["Supply_Permit_FK"].Visible = false;
                SupplyPermitProductDataGrid.Columns["Product"].DisplayIndex = 2;
            }
            else
            {
                SupplyPermitProductDataGrid.Columns["Supply_Permit_FK"].Visible = true;
                SupplyPermitSelect(null);
                SupplyPermitProductDataGrid.Columns["Product"].DisplayIndex = 3;
            }
            SupplyPermitProductDataGrid.Columns["Supply_Permit_FK"].DisplayIndex = 0;
            SupplyPermitProductDataGrid.Columns["Supply_Permit"].DisplayIndex = 5;
        }
        #endregion

        #region Supply Product Rowheader Selected
        private void SupplyPermitProductDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Supply> FilteredSupplies = (List<Supply>)SupplyPermitProductDataGrid.DataSource;
            Supply FilteredSupply = FilteredSupplies[e.RowIndex];
            SupplyPermitIDOutput.Text = FilteredSupply.Supply_Permit.ID.ToString();
            SupplyPermitSupplierOutput.Text = FilteredSupply.Supply_Permit.Supplier.Name;
            SupplyPermitWarehouseOutput.Text = FilteredSupply.Supply_Permit.Warehouse.Name;
            SupplyPermitProductOutput.Text = FilteredSupply.Product.Name;
            SupplyPermitProDateOutput.Text = FilteredSupply.ProDate.ToShortDateString();
            SupplyPermitProductEditLocked.Text = SupplyPermitProductNewLocked.Text = FilteredSupply.Product_FK.ToString();
            SupplyPermitQtyOutput.Text = FilteredSupply.Qty.ToString();
        }
        #endregion

        #region Supply Supplier List Select
        private void SupplyPermitSupplierOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            SupplyPermitSupplierNewLocked.Text = IndexList1[List.SelectedIndex].ToString();
        }
        #endregion

        #region Supply Permit Edit Button
        private void SupplyPermitEditBtn_Click(object sender, EventArgs e)
        {
            if(SupplyPermitIDOutput.Text != String.Empty && SupplyPermitDateOutput.Text != String.Empty &&
                SupplyPermitSupplierOutput.Text != String.Empty && SupplyPermitWarehouseOutput.Text != String.Empty)
            {
                int ID = int.Parse(SupplyPermitIDOutput.Text);
                Supply_Permit FilteredPermit = Entries.Supply_Permit.Where(SP => SP.ID == ID).FirstOrDefault();
                FilteredPermit.Supplier_FK = int.Parse(SupplyPermitSupplierNewLocked.Text);
                FilteredPermit.Warehouse_FK = int.Parse(SupplyPermitWarehouseNewLocked.Text);
                DateTimeConverter Conv = new DateTimeConverter();
                FilteredPermit.Date = (DateTime)Conv.ConvertFromString(SupplyPermitDateOutput.Text);
                Entries.SaveChanges();
                SupplyPermitSelect(null);
                SupplyPermitDataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter all Supply Permit Fields!");
            }
        }
        #endregion

        #endregion

        #endregion

    }
}
