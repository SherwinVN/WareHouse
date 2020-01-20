using System;
using System.Linq;
using System.Windows.Forms;

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
