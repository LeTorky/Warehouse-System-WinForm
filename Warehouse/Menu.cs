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
                ProductDateOutput.Text = DateEditLocked.Text = String.Empty;
                ProductUnitOutput.Text = UnitEditLocked.Text = String.Empty;
                ProductGridView.ClearSelection();
                ProductGridView_SelectionChanged(new object(), null);
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

        #region Sale Permit Select Method
        #endregion

        #region Movement Select Method
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
                WarehouseGridView.DataSource = Entries.Warehouses.ToList();
                WarehouseSelect(null);
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
                WarehouseGridView.DataSource = Entries.Warehouses.ToList();
                WarehouseSelect(null);
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
                ProductGridView.DataSource = Entries.Products.ToList();
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
                ProductGridView.DataSource = Entries.Products.ToList();
            }
            else
            {
                MessageBox.Show("Please enter all Product Fields!");
            }
        }
        #endregion

        #region Product MultiSelection 
        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<Product_Date> FilteredDates = new List<Product_Date>();
            List<Unit> FilteredUnits = new List<Unit>();
            if(ProductGridView.SelectedRows.Count != 0)
            {
                foreach(DataGridViewRow Row in ProductGridView.SelectedRows)
                {
                    int ID = IndexList[Row.Index];
                    FilteredDates.AddRange(Entries.Product_Date.Where(PD => PD.Product_FK == ID).ToList());
                    FilteredUnits.AddRange(Entries.Units.Where(UN => UN.Product_FK == ID).ToList());
                }
            }
            else
            {
                FilteredDates = Entries.Product_Date.ToList();
                FilteredUnits = Entries.Units.ToList();
            }
            ProductUnitDataGrid.DataSource = FilteredUnits.OrderBy(UN => UN.Product_FK).ToList();
            ProductDateDataGrid.DataSource = FilteredDates.OrderBy(PD => PD.Product_FK).ToList();
            ProductDateDataGrid.Columns["Product"].DisplayIndex = 1;
            ProductUnitDataGrid.Columns["Product_FK"].DisplayIndex = 0;
            ProductUnitDataGrid.Columns["Product"].DisplayIndex = 1;
            if(ProductGridView.SelectedRows.Count == 1)
            {
                ProductDateDataGrid.Columns["Product_FK"].Visible = false;
                ProductDateDataGrid.Columns["Product"].Visible = false;
                ProductUnitDataGrid.Columns["Product"].Visible = false;
                ProductUnitDataGrid.Columns["Product_FK"].Visible = false;
            }
            else
            {
                ProductDateDataGrid.Columns["Product_FK"].Visible = true;
                ProductDateDataGrid.Columns["Product"].Visible = true;
                ProductUnitDataGrid.Columns["Product_FK"].Visible = true;
                ProductUnitDataGrid.Columns["Product"].Visible = true;
            }
            foreach(DataGridViewColumn Column in ProductDateDataGrid.Columns)
            {
                if (Column.Index > 2)
                {
                    Column.Visible = false;
                }
            }
        }
        #endregion

        #region Product Date Selection
        private void ProductDateDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = ProductDateDataGrid.Rows[e.RowIndex];
            int ID = int.Parse(Row.Cells["Product_FK"].Value.ToString());
            DateEditLocked.Text = ProductDateOutput.Text = Row.Cells["Production_Date"].Value.ToString();
            ProductSelect(PD => PD.Code == ID);            
        }
        #endregion

        #region Product Unit Selection
        private void ProductUnitDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = ProductUnitDataGrid.Rows[e.RowIndex];
            int ID = int.Parse(Row.Cells["Product_FK"].Value.ToString());
            UnitEditLocked.Text = ProductUnitOutput.Text = Row.Cells["Name"].Value.ToString();
            ProductSelect(PD => PD.Code == ID);
        }
        #endregion

        #region Product Edit Date
        private void ProductDateEditBtn_Click(object sender, EventArgs e)
        {
            if (ProductIDOutput.Text != String.Empty && ProductDateOutput.Text != String.Empty && DateEditLocked.Text != String.Empty)
            {
                int ID = int.Parse(ProductIDOutput.Text);
                DateTimeConverter Conv = new DateTimeConverter();
                DateTime Date = (DateTime)Conv.ConvertFromString(DateEditLocked.Text);
                DateTime NewDate = (DateTime)Conv.ConvertFromString(ProductDateOutput.Text);
                DbEntityEntry<Product_Date> Entry = Entries.Entry(Entries.Product_Date.Where(PD=>(PD.Product_FK==ID)&&(PD.Production_Date==Date)).FirstOrDefault());
                Entries.CascadingProductDate(ID, Date, NewDate);
                Entry.Reload();
                Entries.SaveChanges();
                ProductSelect(null);
            }
            else
            {
                MessageBox.Show("Please select a Product and enter a Production Date!");
            }
        }
        #endregion

        #region Product Add Date
        private void ProductDateAddBtn_Click(object sender, EventArgs e)
        {
            if (ProductIDOutput.Text != String.Empty && ProductDateOutput.Text != String.Empty)
            {
                int ID = int.Parse(ProductIDOutput.Text);
                DateTimeConverter Conv = new DateTimeConverter();
                Entries.Product_Date.Add(new Product_Date() { Product_FK = ID, Production_Date = (DateTime)Conv.ConvertFromString(ProductDateOutput.Text) });
                Entries.SaveChanges();
                ProductSelect(null);
            }
            else
            {
                MessageBox.Show("Please select a Product and enter a Production Date!");
            }
        }
        #endregion

        #region Product Edit Unit
        private void ProductUnitAddBtn_Click(object sender, EventArgs e)
        {
            if (ProductIDOutput.Text != String.Empty && ProductUnitOutput.Text != String.Empty)
            {
                int ID = int.Parse(ProductIDOutput.Text);
                Entries.Units.Add(new Unit() { Product_FK = ID, Name = ProductUnitOutput.Text});
                Entries.SaveChanges();
                ProductSelect(null);
            }
            else
            {
                MessageBox.Show("Please select a Product and enter a Unit Name!");
            }
        }
        #endregion

        #region Product Add Unit
        private void ProductUnitEditBtn_Click(object sender, EventArgs e)
        {
            if (ProductIDOutput.Text != String.Empty && ProductUnitOutput.Text != String.Empty && UnitEditLocked.Text != String.Empty)
            {
                int ID = int.Parse(ProductIDOutput.Text);
                string Key = UnitEditLocked.Text.PadRight(10);
                Entries.CascadingProductUnit(ID, UnitEditLocked.Text, ProductUnitOutput.Text);
                Entries.SaveChanges();
                ProductSelect(null);
            }
            else
            {
                MessageBox.Show("Please select a Product and enter a Unit Name!");
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
                SupplierDataGrid.DataSource = Entries.Suppliers.ToList();
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
                SupplierDataGrid.DataSource = Entries.Suppliers.ToList();
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
                CustomerDataGrid.DataSource = Entries.Customers.ToList();
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
                CustomerDataGrid.DataSource = Entries.Customers.ToList();
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
            SupplyPermitSupplierOutput.Items.Clear();
            SupplyPermitPanelWarehouse.Items.Clear();
            IndexList.Clear();
            IndexList1.Clear();
            IndexList2.Clear();
            IndexList3.Clear();
            foreach (Supply_Permit SP in AllSupplyPermits)
            {
                IndexList.Add(SP.ID);
                SupplyPermitList.Items.Add(SP.ID);
            }
            foreach (Warehouse WH in AllWarehouses)
            {
                IndexList1.Add(WH.ID);
                SupplyPermitWarehouseOutput.Items.Add(WH.Name);
                SupplyPermitPanelWarehouse.Items.Add(WH.Name);
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
                SupplyPermitPanelSupplier.Items.Add(SP.Name);
            }
            foreach(SupplyPermitAddGroup Group in SupplyPermitAddGroup.AddGroup)
            {
                Group.Dispose();
            }
            SupplyPermitAddGroup.AddGroup.Clear();
            SupplyPermitPanel.AutoScroll = false;
            SupplyPermitPanel.HorizontalScroll.Enabled = false;
            SupplyPermitPanel.HorizontalScroll.Visible = false;
            SupplyPermitPanel.HorizontalScroll.Maximum = 0;
            SupplyPermitPanel.AutoScroll = true;
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
            SupplyPermitProductDataGrid.DataSource = FilteredSupplies.OrderBy(SP => SP.Supply_Permit_FK).OrderBy(SP => SP.Product_FK).ToList();
            SupplyPermitProductDataGrid.Columns["Supply_Permit"].HeaderText = "Warehouse";
            if (SupplyPermitDataGrid.SelectedRows.Count == 1)
            {
                SupplyPermitProductDataGrid.Columns["Supply_Permit_FK"].Visible = false;
            }
            else
            {
                SupplyPermitProductDataGrid.Columns["Supply_Permit_FK"].Visible = true;
                SupplyPermitSelect(null);
            }
            SupplyPermitProductDataGrid.Columns["Product_Date"].DisplayIndex = 2;
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
            SupplyPermitProductOutput.Text = FilteredSupply.Product_Date.Product.Name;
            SupplyPermitProductEditLocked.Text = SupplyPermitProductNewLocked.Text = FilteredSupply.Product_FK.ToString();
            SupplyPermitQtyOutput.Text = FilteredSupply.Qty.ToString();
            SupplyPermitWarehouseNewLocked.Text = SupplyPermitWarehouseEditLocked.Text = FilteredSupply.Supply_Permit.Warehouse_FK.ToString();
            SupplyPermitSupplierEditLocked.Text = SupplyPermitSupplierNewLocked.Text = FilteredSupply.Supply_Permit.Supplier_FK.ToString();
            SupplyPermitProDateOutput.Text = SupplyPermitProDateEditLocked.Text = FilteredSupply.ProDate.ToShortDateString();
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
                SupplyPermitDataGrid.DataSource = Entries.Supply_Permit.ToList();
                SupplyPermitSelect(null);
            }
            else
            {
                MessageBox.Show("Please enter all Supply Permit Fields!");
            }
        }
        #endregion

        #region Supply Permit Entry Edit Button
        private void SupplyPermitEntryEditBtn_Click(object sender, EventArgs e)
        {
            if((SupplyPermitIDOutput.Text != String.Empty) && (SupplyPermitProductNewLocked.Text != String.Empty)
                && (SupplyPermitProDateOutput.Text != String.Empty) && (SupplyPermitQtyOutput.Text != String.Empty))
            {
                DialogResult dialogResult = MessageBox.Show("These edits may have a cascading effect on Sales and Movements!", "Warning", MessageBoxButtons.OKCancel);
                if((dialogResult == DialogResult.OK))
                {
                    int SupplyPermitFK = int.Parse(SupplyPermitIDOutput.Text);
                    int SupplyPermitProductFK = int.Parse(SupplyPermitProductEditLocked.Text);
                    DateTimeConverter Conv = new DateTimeConverter();
                    DateTime SupplyPermitDateTime = (DateTime)Conv.ConvertFromString(SupplyPermitProDateEditLocked.Text);
                    int NewProductFK = int.Parse(SupplyPermitProductNewLocked.Text);
                    DateTime NewProDate = (DateTime)Conv.ConvertFromString(SupplyPermitProDateOutput.Text);
                    int NewQty = int.Parse(SupplyPermitQtyOutput.Text);
                    DbEntityEntry<Supply> Entry = Entries.Entry(Entries.Supplies.Where(SP=>(SP.Supply_Permit_FK == SupplyPermitFK)&&(SP.Product_FK == SupplyPermitProductFK)&&(SP.Product_Date.Production_Date == SupplyPermitDateTime)).FirstOrDefault());
                    Entries.CascadingSupplyPermit(SupplyPermitFK, SupplyPermitProductFK, SupplyPermitDateTime, NewProductFK, NewProDate, NewQty);
                    Entries.SaveChanges();
                    Entry.Reload();
                    SupplyPermitDataGrid_SelectionChanged(new object(), new EventArgs());
                    SupplyPermitSelect(null);
                }
                else
                {
                    MessageBox.Show("Edit Cancelled!");
                }
            }
            else
            {
                MessageBox.Show("Please enter all fields for Supply Entry!");
            }
        }
        #endregion

        #region Supply Permit Panel Supplier List Select
        private void SupplyPermitPanelSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            SupplyPermitPanelSupplierLocked.Text = IndexList3[List.SelectedIndex].ToString();
        }
        #endregion

        #region Supply Permit Panel Warehouse List Select
        private void SupplyPermitPanelWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            SupplyPermitPanelWarehouseLocked.Text = IndexList1[List.SelectedIndex].ToString();
        }
        #endregion

        #region Supply Permit Panel Product Add Button
        private void SupplyPermitProductAddBtn_Click(object sender, EventArgs e)
        {
            SupplyPermitPanel.AddSupplyGroup(SupplyPermitProductOutput, DynamicListSelection);
        }
        #endregion

        #region Supply Permit Selected Entry Change Date List
        private void SupplyPermitProductOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplyPermitProDateOutput.Items.Clear();
            ComboBox List = (ComboBox)sender;
            int ID = IndexList2[List.SelectedIndex];
            string[] ProdDate = Entries.Product_Date.Where(PD => PD.Product_FK == ID).Select(PD => PD.Production_Date.ToString()).ToArray();
            SupplyPermitProDateOutput.Items.AddRange(ProdDate);
        }
        #endregion

        #region Dynamic List Selection
        public void DynamicListSelection (object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            SupplyPermitAddGroup AddGroup = SupplyPermitAddGroup.AddGroup.Where(AG => AG.ProductList == List).FirstOrDefault();
            AddGroup.ProductID.Text = IndexList2[List.SelectedIndex].ToString();
            int ID = IndexList2[List.SelectedIndex];
            string[] ProdDate = Entries.Product_Date.Where(PD => PD.Product_FK == ID).Select(PD => PD.Production_Date.ToString()).ToArray();
            AddGroup.ProDate.Items.AddRange(ProdDate);
        }

        #endregion

        #region Supply Permit Add Permit
        private void SupplyPermitAddBtn_Click(object sender, EventArgs e)
        {
            List<string> ProductDateFlag = new List<string>();
            if (SupplyPermitAddGroup.AddGroup.Count > 0)
            {
                if (SupplyPermitPanelWarehouseLocked.Text != String.Empty && SupplyPermitPanelSupplierLocked.Text != String.Empty &&
                    SupplyPermitPanelDate.Text != String.Empty)
                {
                    int i;
                    List<SupplyPermitAddGroup> Group = SupplyPermitAddGroup.AddGroup;
                    int ProductGroupCount = Group.Count;
                    for (i = 0; (i < ProductGroupCount) && (Group[i].ProductID.Text != String.Empty) && (Group[i].ProDate.Text != String.Empty) && (Group[i].Qty.Text != String.Empty); i++);
                    if (i == ProductGroupCount)
                    {
                        for (i = 0; (i < ProductGroupCount) && (!ProductDateFlag.Contains(SupplyPermitAddGroup.AddGroup[i].ProductID.Text + "-" + SupplyPermitAddGroup.AddGroup[i].ProDate.Text)); i++)
                        {
                            ProductDateFlag.Add(SupplyPermitAddGroup.AddGroup[i].ProductID.Text + "-" + SupplyPermitAddGroup.AddGroup[i].ProDate.Text);
                        }
                        if (i == ProductGroupCount)
                        {
                            DateTimeConverter Conv = new DateTimeConverter();
                            Supply_Permit NewPermit = new Supply_Permit()
                            {
                                ID = Entries.Supply_Permit.Max(SP => SP.ID) + 1,
                                Warehouse_FK = int.Parse(SupplyPermitPanelWarehouseLocked.Text),
                                Supplier_FK = int.Parse(SupplyPermitPanelSupplierLocked.Text),
                                Date = (DateTime)Conv.ConvertFromString(SupplyPermitPanelDate.Text),
                            };
                            Entries.Supply_Permit.Add(NewPermit);
                            foreach (SupplyPermitAddGroup GP in Group)
                            {
                                Entries.Supplies.Add(new Supply()
                                {
                                    Supply_Permit_FK = NewPermit.ID,
                                    Product_FK = int.Parse(GP.ProductID.Text),
                                    ProDate = (DateTime)Conv.ConvertFromString(GP.ProDate.Text),
                                    Qty = int.Parse(GP.Qty.Text)
                                });
                            }
                            Entries.SaveChanges();
                            SupplyPermitDataGrid.DataSource = Entries.Supply_Permit.ToList();
                            SupplyPermitSelect(null);
                        }
                        else
                        {
                            MessageBox.Show("Please enter unique Product - Production Date pairs!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter all Product fields!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all Supply Permit fields!");
                }
            }
            else
            {
                MessageBox.Show("Please add a Product to the Supply Permit!");
            }
        }


        #endregion

        #endregion

        #region Movement Events

        #region Movement Tab Active
        private void MovementTab_Enter(object sender, EventArgs e)
        {
            MovementDataGrid.DataSource = Entries.Movements.ToList();
            MovementDataGrid.Columns["Warehouse_From_FK"].DisplayIndex = 0;
            MovementDataGrid.Columns["Warehouse"].DisplayIndex = 1;
            MovementDataGrid.Columns["Warehouse_To_FK"].DisplayIndex = 2;
            MovementDataGrid.Columns["Warehouse1"].DisplayIndex = 3;
            MovementDataGrid.Columns["Supply_Permit_FK"].DisplayIndex = 4;
            MovementDataGrid.Columns["Supply_Permit"].DisplayIndex = 5;
            MovementDataGrid.Columns["Supply_Permit"].HeaderText = "Supplier_Name";
            MovementDataGrid.Columns["Product_FK"].DisplayIndex = 6;
            MovementDataGrid.Columns["Product_Date"].HeaderText = "Product_Name";
            MovementDataGrid.Columns["Product_Date"].DisplayIndex = 7;
            MovementDataGrid.Columns["ProDate"].DisplayIndex = 8;
            MovementDataGrid.Columns["Qty"].DisplayIndex = 9;
            MovementDataGrid.Columns["Date"].DisplayIndex = 10;
            MovementWHToAddLocked.Text =
            MovementWHFromAddLocked.Text =
            MovementProductAddLocked.Text = 
            MovementWHFromOutput.Text =
            MovementWHFromLocked.Text =
            MovementWHToOutput.Text =
            MovementWHToLocked.Text =
            MovementSupplierOutput.Text =
            MovementSupplierLocked.Text =
            MovementPermitOutput.Text =
            MovementProductOutput.Text =
            MovementProductLocked.Text =
            MovementProDateLocked.Text =
            MovementQtyLocked.Text =
            MovementWHFromAdd.Text =
            MovementWHToAdd.Text =
            MovementPermitAdd.Text =
            MovementQtyOutput.Text =
            MovementProductAdd.Text =
            MovementProDateOutput.Text =
            MovementDateLocked.Text = String.Empty;
            MovementWHFromAdd.Items.Clear();
            MovementWHToAdd.Items.Clear();
            MovementPermitAdd.Items.Clear();
            MovementQtyOutput.Items.Clear();
            MovementProductAdd.Items.Clear();
            MovementProDateOutput.Items.Clear();
            IndexList.Clear();
            IndexList1.Clear();
            IndexList2.Clear();
            foreach(Warehouse WH in Entries.Warehouses)
            {
                IndexList.Add(WH.ID);
                MovementWHFromAdd.Items.Add(WH.Name);
            }
        }
        #endregion

        #region Movement Row Header Click
        private void MovementDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = MovementDataGrid.Rows[e.RowIndex];
            int ID = int.Parse(Row.Cells["Supply_Permit_FK"].Value.ToString());
            Supply_Permit FilteredSupplyPermit = Entries.Supply_Permit.FirstOrDefault(SP => SP.ID == ID);
            MovementWHFromOutput.Text = Row.Cells["Warehouse"].Value.ToString();
            MovementWHFromLocked.Text = Row.Cells["Warehouse_From_FK"].Value.ToString();
            MovementWHToOutput.Text = Row.Cells["Warehouse1"].Value.ToString();
            MovementWHToLocked.Text = Row.Cells["Warehouse_To_FK"].Value.ToString();
            MovementSupplierOutput.Text = Row.Cells["Supply_Permit"].Value.ToString();
            MovementSupplierLocked.Text = FilteredSupplyPermit.Supplier_FK.ToString();
            MovementPermitOutput.Text = Row.Cells["Supply_Permit_FK"].Value.ToString();
            MovementProductOutput.Text = Row.Cells["Product_Date"].Value.ToString();
            MovementProductLocked.Text = Row.Cells["Product_FK"].Value.ToString();
            MovementProDateLocked.Text = Row.Cells["ProDate"].Value.ToString();
            MovementQtyLocked.Text = Row.Cells["Qty"].Value.ToString();
            MovementDateLocked.Text = Row.Cells["Date"].Value.ToString();
        }
        #endregion

        #region Movement Lists Cascading Selection
        private void MovementWHFromAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            int ID = IndexList[List.SelectedIndex];
            List<GetDetailedQty_Result> QtyResult = Entries.GetDetailedQty().Where(GDQ => (GDQ.Warehouse_ID == ID) && (GDQ.Qty > 0)).ToList();
            IndexList1.Clear();
            IndexList2.Clear();
            MovementWHToAdd.Items.Clear();
            MovementPermitAdd.Items.Clear();
            MovementQtyOutput.Items.Clear();
            MovementProductAdd.Items.Clear();
            MovementProDateOutput.Items.Clear();
            MovementWHFromAddLocked.Text = ID.ToString();
            MovementProDateOutput.Text =
            MovementWHToAdd.Text =
            MovementPermitAdd.Text =
            MovementQtyOutput.Text =
            MovementProductAdd.Text =
            MovementWHToAddLocked.Text =
            MovementProductAddLocked.Text = String.Empty;
            foreach (Warehouse WH in Entries.Warehouses.Where(W => W.ID != ID))
            {
                IndexList1.Add(WH.ID);
                MovementWHToAdd.Items.Add(WH.Name);
            }
            foreach (int Result in QtyResult.Select(QR => QR.Supply_Permit_ID).OrderBy(QR=>QR).Distinct())
            {
                MovementPermitAdd.Items.Add(Result);
            }
        }

        private void MovementPermitAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int WHID = IndexList[MovementWHFromAdd.SelectedIndex];
            int SPID = int.Parse(MovementPermitAdd.SelectedItem.ToString());
            var QtyResult = Entries.GetDetailedQty().Where(GDQ => (GDQ.Warehouse_ID == WHID) && (GDQ.Qty > 0) && (GDQ.Supply_Permit_ID == SPID)).Select(GDQ=> new { GDQ.Product_ID, GDQ.Product_Name} ).OrderBy(GDQ=>GDQ.Product_ID).Distinct().ToList();
            IndexList2.Clear();
            MovementQtyOutput.Items.Clear();
            MovementProductAdd.Items.Clear();
            MovementProDateOutput.Items.Clear();
            MovementProDateOutput.Text =
            MovementQtyOutput.Text =
            MovementProductAdd.Text =
            MovementProductAddLocked.Text = String.Empty;
            foreach(var Result in QtyResult)
            {
                IndexList2.Add(Result.Product_ID.Value);
                MovementProductAdd.Items.Add(Result.Product_Name);
            }
        }
        private void MovementWHToAdd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            int ID = IndexList1[List.SelectedIndex];
            MovementWHToAddLocked.Text = ID.ToString();
        }

        private void MovementProductAdd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            int PID = IndexList2[List.SelectedIndex];
            int WHID = IndexList[MovementWHFromAdd.SelectedIndex];
            int SPID = int.Parse(MovementPermitAdd.SelectedItem.ToString());
            var QtyResult = Entries.GetDetailedQty().Where(GDQ => (GDQ.Warehouse_ID == WHID) && (GDQ.Qty > 0) && (GDQ.Supply_Permit_ID == SPID) && (GDQ.Product_ID == PID)).Select(GDQ=> GDQ.Prod_Date ).OrderBy(GDQ => GDQ).Distinct().ToList();
            MovementProductAddLocked.Text = PID.ToString();
            MovementQtyOutput.Items.Clear();
            MovementQtyOutput.Text = String.Empty;
            MovementProDateOutput.Items.Clear();
            DateTimeConverter Conv = new DateTimeConverter();
            foreach(var Result in QtyResult)
            {
                MovementProDateOutput.Items.Add(Result.Value.ToShortDateString());
            }
        }

        private void MovementProDateOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            int PID = IndexList2[MovementProductAdd.SelectedIndex];
            int WHID = IndexList[MovementWHFromAdd.SelectedIndex];
            int SPID = int.Parse(MovementPermitAdd.SelectedItem.ToString());
            MovementQtyOutput.Items.Clear();
            MovementQtyOutput.Text = String.Empty;
            DateTimeConverter Conv = new DateTimeConverter();
            DateTime DateID = (DateTime)Conv.ConvertFromString(MovementProDateOutput.Text);
            var QtyResult = Entries.GetDetailedQty().Where(GDQ => (GDQ.Warehouse_ID == WHID) && (GDQ.Qty > 0) && (GDQ.Supply_Permit_ID == SPID) && (GDQ.Product_ID == PID) && (GDQ.Prod_Date.Value.ToShortDateString().Contains(MovementProDateOutput.Text))).Select(GDQ => GDQ.Qty).Sum(GDQ=>GDQ);
            for (int i = 1; i <= QtyResult; i++)
            {
                MovementQtyOutput.Items.Add(i.ToString());
            }
        }
        #endregion

        #region Movement Move Button
        private void MovementAddBtn_Click(object sender, EventArgs e)
        {
            if((MovementWHFromAddLocked.Text != String.Empty) && (MovementWHToAddLocked.Text != String.Empty) &&
                (MovementPermitAdd.Text != String.Empty) && (MovementProDateOutput.Text != String.Empty) &&
                (MovementProductAddLocked.Text != String.Empty) && (MovementQtyOutput.Text != String.Empty)
                && (MovementMoveDate.Text != String.Empty))
            {
                DateTimeConverter Conv = new DateTimeConverter();
                DateTime NewDate = (DateTime)Conv.ConvertFromString(MovementProDateOutput.Text);
                DateTime MoveDate = (DateTime)Conv.ConvertFromString(MovementMoveDate.Text);
                Entries.AddMovement(int.Parse(MovementWHFromAddLocked.Text), int.Parse(MovementWHToAddLocked.Text),
                    int.Parse(MovementPermitAdd.Text), int.Parse(MovementProductAddLocked.Text), NewDate, int.Parse(MovementQtyOutput.Text), MoveDate);
                Entries.SaveChanges();
                DbEntityEntry<Movement> Entry = Entries.Entry(Entries.Movements.FirstOrDefault());
                Entry.Reload();
                MovementTab_Enter(null, null);
            }
            else
            {
                MessageBox.Show("Please select all Movement fields!");
            }
        }

        #endregion

        #endregion

        #region Sale Permit Events

        #region Sale Permit Tab Active

        #endregion

        #endregion

        #endregion

        private void SaleTab_Enter(object sender, EventArgs e)
        {
            SalePermitDataGrid.DataSource = Entries.Sale_Permit.ToList();
            SalePermitDataGrid.Columns["Sales"].Visible = false;
            SalePermitDataGrid.Columns["Customer"].DisplayIndex = 3;
            SalePermitDataGrid.Columns["Warehouse"].DisplayIndex = 5;
            SalePermitSelect(null);
            IndexList.Clear();
            IndexList1.Clear();
            IndexList2.Clear();
            IndexList3.Clear();
            SalePermitCustomerListOutput.Items.Clear();
            SalePermitWarehouseListOutput.Items.Clear();
            SalePermitEntryWarehouseList.Items.Clear();
            SalePermitProductListOutput.Items.Clear();
            SalePermitListOutput.Items.Add("All");
            foreach (Sale_Permit SP in Entries.Sale_Permit)
            {
                IndexList.Add(SP.ID);
                SalePermitListOutput.Items.Add(SP.ID);
            }
            foreach(Customer CS in Entries.Customers)
            {
                IndexList1.Add(CS.ID);
                SalePermitCustomerListOutput.Items.Add(CS.Name);
            }
            foreach (Warehouse WH in Entries.Warehouses)
            {
                IndexList2.Add(WH.ID);
                SalePermitWarehouseListOutput.Items.Add(WH.Name);
                SalePermitEntryWarehouseList.Items.Add(WH.Name);
            }
            foreach (Product PD in Entries.Products)
            {
                IndexList3.Add(PD.Code);
                SalePermitProductListOutput.Items.Add(PD.Name);
            }
        }

        private void SalePermitSelect(Func<Sale_Permit,bool> Critera)
        {
            if(Critera == null)
            {
                SalePermitListOutput.Text =
                SalePermitIDOutput.Text =
                SalePermitDateOutput.Text =
                SalePermitCustomerListOutput.Text =
                SalePermitCustomerIDNewLocked.Text =
                SalePermitCustomerIDEditLocked.Text =
                SalePermitWarehouseListOutput.Text =
                SalePermitWarehouseNewLocked.Text =
                SalePermitWarehouseEditLocked.Text = String.Empty;
                SalePermitEntryDataGrid.DataSource = Entries.Sales.ToList();
            }
            else
            {
                Sale_Permit FilteredSalePermit = Entries.Sale_Permit.FirstOrDefault(Critera);
                SalePermitEntryDataGrid.DataSource = FilteredSalePermit.Sales.OrderBy(SP => SP.Product_FK).ToList();
                SalePermitListOutput.Text = SalePermitIDOutput.Text = FilteredSalePermit.ID.ToString();
                SalePermitDateOutput.Text = FilteredSalePermit.Date.ToShortDateString();
                SalePermitCustomerListOutput.Text = FilteredSalePermit.Customer.Name;
                SalePermitCustomerIDNewLocked.Text = SalePermitCustomerIDEditLocked.Text = FilteredSalePermit.Customer_FK.ToString();
                SalePermitWarehouseListOutput.Text = FilteredSalePermit.Warehouse.Name;
                SalePermitWarehouseNewLocked.Text = SalePermitWarehouseEditLocked.Text = FilteredSalePermit.Warehouse_FK.ToString();
            }
            SalePermitEntryDataGrid.ClearSelection();
            SalePermitProductListOutput.Text =
            SalePermitProductNewLocked.Text =
            SalePermitProductEditLocked.Text =
            SalePermitProDateOutput.Text =
            SalePermitProDateEditLocked.Text =
            SalePermitSupPermitListOutput.Text =
            SalePermitQtyOutput.Text =
            SalePermitEntryWarehouseList.Text =
            SalePermitEntryWarehouseLocked.Text =
            SalePermitCustomerEntryList.Text =
            SalePermitEntryCustomerLocked.Text =
            SalePermitEntryDate.Text = string.Empty;
        }

        private void SalePermitDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = IndexList[e.RowIndex];
            SalePermitSelect(SP=>SP.ID == ID);
        }

        private void SalePermitListOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if(List.SelectedIndex == 0)
            {
                SalePermitDataGrid.ClearSelection();
                SalePermitSelect(null);
            }
            else
            {
                int ID = IndexList[List.SelectedIndex-1];
                int SelectionID = List.SelectedIndex - 1;
                SalePermitSelect(SP=>SP.ID == ID);
                SalePermitDataGrid.ClearSelection();
                SalePermitDataGrid.Rows[SelectionID].Selected = true;
                SalePermitDataGrid_RowHeaderMouseClick(null, new DataGridViewCellMouseEventArgs(0, SelectionID,0,0, new MouseEventArgs(MouseButtons.Right,1,0,0,0)));
            }
        }

        private void SalePermitEntryDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Sale> FilteredSales = (List<Sale>)SalePermitEntryDataGrid.DataSource;
            Sale FilteredSale = FilteredSales[e.RowIndex];
            SalePermitSelect(SP => SP.ID == FilteredSale.Sale_Permit_FK);
            SalePermitProductListOutput.Text = FilteredSale.Product_Date.Product.Name;
            SalePermitProductNewLocked.Text = SalePermitProductEditLocked.Text = FilteredSale.Product_FK.ToString();
            SalePermitProDateOutput.Text = SalePermitProDateEditLocked.Text = FilteredSale.ProDate.ToString();
            SalePermitSupPermitListOutput.Text = FilteredSale.Supply_Permit_FK.ToString();
            SalePermitQtyOutput.Text = FilteredSale.Qty.ToString();
        }

        private void SalePermitDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SalePermitDataGrid.SelectedRows.Count > 1)
            {
                List<Sale_Permit> FilteredSalePermits = (List<Sale_Permit>)SalePermitDataGrid.DataSource;
                List<Sale> AllSales = new List<Sale>();
                foreach (DataGridViewRow Row in SalePermitDataGrid.SelectedRows)
                {
                    AllSales.AddRange(FilteredSalePermits[Row.Index].Sales.ToList());
                }
                SalePermitEntryDataGrid.DataSource = AllSales;
            }
            else
            {
                SalePermitSelect(null);
            }
        }
    }
}
