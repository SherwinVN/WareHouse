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

namespace DeveloverWarehouse
{
    public partial class Company : DeveloverCatalogForm, IDeveloverFormChild
    {
        public Company()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM Company ORDER BY CompanyID";
            CodeVoucher = "Company";        
            NameFieldCodePrimary = "CompanyID";
            ControlCheckDuplicate = new IDeveloverControl[] { txtVenderName };
            ControlCheckEmty = new IDeveloverControl[] { txtVenderName };
            DeveloverControlsFocus = txtVenderName;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            InitForm();
            //lokLocationDefault.LoadData("SELECT * FROM Location ORDER BY LocationID", "Location", "LocationID", "LocationID", "LocationName", "");
            //lokUOM.LoadData("SELECT * FROM UOM ORDER BY UOMID", "UOM", "UOMID", "UOMID", "UOMName", "");
            //lokUOMSize.LoadData("SELECT * FROM UOM ORDER BY UOMID", "UOM", "UOMID", "UOMID", "UOMName", "");
            //lokUOMWeight.LoadData("SELECT * FROM UOM ORDER BY UOMID", "UOM", "UOMID", "UOMID", "UOMName", "");
        }
    }
}
