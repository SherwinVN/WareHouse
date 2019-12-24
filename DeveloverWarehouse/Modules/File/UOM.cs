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

            TitleForm = "Danh mục dơn vị tính";
            SQLDataSourceSearch = "SELECT * FROM UOM order by UOMID";
            Model = "UOM";
            txtName.FieldBinding = "UOMName";
            txtName.TypeFieldColumns = EnumTypeColumns.Text;
            memDescription.FieldBinding = "Description";
            memDescription.TypeFieldColumns = EnumTypeColumns.Text;
            chkActive.FieldBinding = "Active";
            chkActive.TypeFieldColumns = EnumTypeColumns.Check;
            DeveloverControls = new IDeveloverControl[] { txtName,memDescription,chkActive};

            DeveloverControlsFocus = txtName;
        }

        private void UOM_Load(object sender, EventArgs e)
        {
            InitForm();
        }
    }
}
