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

namespace DeveloverWarehouse.Modules.Accounting
{
    public partial class Currency : DeveloverCatalogForm, IDeveloverFormChild
    {
        public Currency()
        {
            InitializeComponent();
            SQLDataSourceSearch = "SELECT * FROM Currency ORDER BY CurrencyID";
            CodeVoucher = "Currency";        
            NameFieldCodePrimary = "CurrencyID";
            ControlCheckDuplicate = new IDeveloverControl[] { txtCurrencyName };
            ControlCheckEmty = new IDeveloverControl[] { txtCurrencyName };
            DeveloverControlsFocus = txtCurrencyName;
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void txtCurrencyName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gro_general_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
