using Develover.GUI;
using Develover.GUI.Forms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloverWarehouse.Modules.Inventory
{
    public partial class Product : XtraForm, IDeveloverFormChild
    {
        public Product()
        {
            InitializeComponent();
            //grc_search.InitializeDataSource(typeof(Product));

            //txt_product.DataBindings.Add("Text", grc_search.DefaultView.DataSource, "name",true);
        }

        private void Grv_search_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }
    }
}
