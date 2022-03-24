using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public class SupplyPermitAddGroup
    {
        public Label ID { get; set; }
        public Label ProductLabel { get; set; }
        public ComboBox ProductList { get; set; }
        public TextBox ProductID { get; set; }
        public Label ProDateLabel { get; set; }
        public ComboBox ProDate { get; set; }
        public Label QtyLabel { get; set; }
        public TextBox Qty { get; set; }
        public static List<SupplyPermitAddGroup> AddGroup;
        public SupplyPermitAddGroup()
        {
            int Padding;
            if (AddGroup.Count != 0)
            {
                Padding = (AddGroup[AddGroup.Count-1].ProDate.Top) + 30;
            }
            else
            {
                Padding = 30;
            }
            ID = new Label();
            ProductLabel = new Label();
            ProDateLabel = new Label();
            QtyLabel = new Label();
            ID.Text = (AddGroup.Count + 1).ToString()+":";
            ProductLabel.Text = "Product:";
            ProDateLabel.Text = "ProDate:";
            QtyLabel.Text = "Qty:";
            ProductID = new TextBox();
            ProductID.Enabled = false;
            Qty = new TextBox();
            ProDate = new ComboBox();
            ProductList = new ComboBox();
            ID.Top = ProductLabel.Top = ProDateLabel.Top = QtyLabel.Top = ProductID.Top = Qty.Top = ProDate.Top = ProductList.Top = Padding;
            ID.Left = 11;
            ProductLabel.Left = 30;
            ProductList.Width = 85;
            ProductList.Left = 89;
            ProductID.Width = 24;
            ProductID.Left = 182;
            ProDateLabel.Left = 224;
            ProDate.Width = 119;
            ProDate.Left = 280;
            QtyLabel.Left = 424;
            Qty.Left = 460;
            Qty.Width = 116;
            AddGroup.Add(this);
        }
        static SupplyPermitAddGroup()
        {
            AddGroup = new List<SupplyPermitAddGroup>();
        }
        public void Dispose()
        {
            ProductLabel.Dispose();
            ProductList.Dispose();
            ProductID.Dispose();
            ProDateLabel.Dispose();
            ProDate.Dispose();
            QtyLabel.Dispose();
            Qty.Dispose();
            ID.Dispose();
        }
    }
    public static class ControlsExtended
    {
        public static void AddSupplyGroup(this Panel panel, ComboBox Products, EventHandler eventHandler)
        {
            SupplyPermitAddGroup AddGroup = new SupplyPermitAddGroup();
            foreach(String Product in Products.Items)
            {
                AddGroup.ProductList.Items.Add(Product);
            }
            AddGroup.ProductList.SelectedIndexChanged += eventHandler;
            panel.Controls.Add(AddGroup.ProDate);
            panel.Controls.Add(AddGroup.ProductList);
            panel.Controls.Add(AddGroup.Qty);
            panel.Controls.Add(AddGroup.ProductLabel);
            panel.Controls.Add(AddGroup.ProDateLabel);
            panel.Controls.Add(AddGroup.QtyLabel);
            panel.Controls.Add(AddGroup.ProductID);
            panel.Controls.Add(AddGroup.ID);
        }
    }
}
