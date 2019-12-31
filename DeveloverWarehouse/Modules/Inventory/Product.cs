using Develover.GUI;
using Develover.GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Develover.Utilities.Enum;

namespace DeveloverWarehouse.Modules.Inventory
{
    public partial class Product : DeveloverCatalogForm, IDeveloverFormChild
    {
        public Product()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM VProduct ORDER BY ProductName";
            CodeVoucher = "PRODUCT";        
            NameFieldCodePrimary = "ProductID";
            ControlCheckDuplicate = new IDeveloverControl[] { txtProductName };
            ControlCheckEmty = new IDeveloverControl[] { txtProductName,lokUOM };
            DeveloverControlsFocus = txtProductName;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            InitForm();
            lokLocationDefault.LoadData("SELECT * FROM Location ORDER BY LocationID", "Location", "LocationID", "LocationID", "LocationName", "");
            lokUOM.LoadData("SELECT * FROM UOM ORDER BY UOMID", "UOM", "UOMID", "UOMID", "UOMName", "");
            lokUOMSize.LoadData("SELECT * FROM UOM ORDER BY UOMID", "UOM", "UOMID", "UOMID", "UOMName", "");
            lokUOMWeight.LoadData("SELECT * FROM UOM ORDER BY UOMID", "UOM", "UOMID", "UOMID", "UOMName", "");
            
        }
    }
}
