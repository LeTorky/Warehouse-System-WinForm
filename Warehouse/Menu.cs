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
        private System.Collections.Generic.List<int> IndexList;
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
        }
        #endregion

        #region Warehouse Select Method
        private void WarehouseSelect(Func<Warehouse,bool> Criteria)
        {
            List<Warehouse> AllWarehouses = Entries.Warehouses.ToList<Warehouse>();
            List<Warehouse> FilteredWarehouses;
            Warehouse FilteredWarehouse;
            if(Criteria == null)
            {
                FilteredWarehouses = AllWarehouses;
                WarehouseIDOutput.Text = String.Empty;
                WarehouseNameOutput.Text = String.Empty;
                WarehouseAddressOutput.Text = String.Empty;
                WarehouseSupervisorOutput.Text = String.Empty;
            }
            else
            {
                FilteredWarehouses = Entries.Warehouses.Where(Criteria).ToList<Warehouse>();
                FilteredWarehouse = FilteredWarehouses.FirstOrDefault<Warehouse>();
                WarehouseIDOutput.Text = FilteredWarehouse.ID.ToString();
                WarehouseNameOutput.Text = FilteredWarehouse.Name;
                WarehouseAddressOutput.Text = FilteredWarehouse.Address;
                WarehouseSupervisorOutput.Text = FilteredWarehouse.Supervisor;
            }
            WarehouseGridView.DataSource = FilteredWarehouses;
            int ColumnsCount = WarehouseGridView.Columns.Count;
            for (int i=4; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                WarehouseGridView.Columns.RemoveAt(4);
            }
            WarehouseList.Items.Clear();
            WarehouseList.Items.Add("All");
            IndexList.Clear();
            foreach (Warehouse WH in AllWarehouses)
            {
                WarehouseList.Items.Add(WH.Name);
                IndexList.Add(WH.ID);
            }    
        }
        #endregion

        #region Product Select Method
        private void ProductSelect(Func<Product, bool> Criteria)
        {
            List<Product> AllProducts = Entries.Products.ToList<Product>();
            List<Product> FilteredProducts;
            Product FilteredProduct;
            if (Criteria == null)
            {
                FilteredProducts = AllProducts;
                ProductIDOutput.Text = String.Empty;
                ProductNameOutput.Text = String.Empty;
                ProductExpiryOutput.Text = String.Empty;
            }
            else
            {
                FilteredProducts = Entries.Products.Where(Criteria).ToList<Product>();
                FilteredProduct = FilteredProducts.FirstOrDefault<Product>();
                ProductIDOutput.Text = FilteredProduct.Code.ToString();
                ProductNameOutput.Text = FilteredProduct.Name;
                ProductExpiryOutput.Text = FilteredProduct.ExpPeriod.ToString();
            }
            ProductGridView.DataSource = FilteredProducts;
            int ColumnsCount = ProductGridView.Columns.Count;
            for (int i = 3; i < ColumnsCount; i++) //Removes Navigation Columns.
            {
                ProductGridView.Columns.RemoveAt(3);
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

        #endregion

        #region EventHandlers

        #region Warehouse Events

        #region Warehouse Active
        private void WarehouseTab_Enter(object sender, EventArgs e)
        {
            WarehouseSelect(null);
        }
        #endregion

        #region Warehouse List Selected
        private void WarehouseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                WarehouseSelect(WH => WH.ID == IndexList[List.SelectedIndex - 1]);
            }
            else
            {
                WarehouseSelect(null);
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
            if(WarehouseIDOutput.Text == String.Empty)
            {
                WarehouseSelect(WH => WH.ID == IndexList[e.RowIndex]);
            }
        }
        #endregion

        #region Warehouse Add Button
        private void WarehouseAddBtn_Click(object sender, EventArgs e)
        {
            if(WarehouseNameInput.Text != String.Empty &&  WarehouseAddressInput.Text != String.Empty && WarehouseSupervisorInput.Text != String.Empty)
            {
                int ID = Entries.Warehouses.Max(WH => WH.ID);
                Entries.Warehouses.Add(new Warehouse() { ID = ID, Name = WarehouseNameInput.Text, Address = WarehouseAddressInput.Text, Supervisor = WarehouseSupervisorInput.Text });
                Entries.SaveChanges();
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
            ProductSelect(null);
        }
        #endregion

        #region DataGrid Row Selected
        private void ProductGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ProductIDOutput.Text == String.Empty)
            {
                ProductSelect(PD => PD.Code == IndexList[e.RowIndex]);
            }
        }
        #endregion

        #region Product List Selected
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            if (List.SelectedIndex != 0)
            {
                ProductSelect(PD => PD.Code == IndexList[List.SelectedIndex - 1]);
            }
            else
            {
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
                Entries.Products.Add(new Product() { Code = ID, Name = ProductNameInput.Text, ExpPeriod = int.Parse(ProductExpiryInput.Text) });
                Entries.SaveChanges();
                ProductSelect(null);
            }
            else
            {
                MessageBox.Show("Please enter all Product Fields!");
            }
        }
        #endregion

        #endregion

        #endregion

    }
}
