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

namespace DeveloverWarehouse.Modules.File
{
    public partial class Location : DeveloverCatalogForm, IDeveloverFormChild
    {
        public Location()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM Location ORDER BY LocationID";
            Model = "Location";           
            Table = "Location";
            NameFieldCodePrimary = "LocationID";
            ControlCheckDuplicate = new IDeveloverControl[] { lokBranchID,txtLocationName };
            ControlCheckEmty = new IDeveloverControl[] { lokBranchID,txtLocationName };
            DeveloverControlsFocus = lokBranchID;
        }

        private void Location_Load(object sender, EventArgs e)
        {
            InitForm();
            lokBranchID.LoadData("SELECT * FROM UOM ", "UOM", "UOMID", "UOMName", "UOMID");
        }


    }
}
