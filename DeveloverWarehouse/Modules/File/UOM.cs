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
    public partial class UOM : DeveloverCatalogForm, IDeveloverFormChild
    {
        public UOM()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM UOM order by UOMID";
            Model = "UOM";           
            Table = "UOM";
            NameFieldCodePrimary = "UOMID";
            NameFieldNamePrimary = "UOMName";
            DeveloverControlsNamePrimary = txtName;
            DeveloverControlsFocus = txtName;
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
