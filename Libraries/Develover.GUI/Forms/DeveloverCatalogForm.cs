using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Develover.GUI.Forms
{
    public partial class DeveloverCatalogForm : DeveloverForm
    {
        public DeveloverCatalogForm()
        {
            InitializeComponent();
        }

        protected virtual void BarButtonNew_Click()
        {

        }

        protected virtual void BarButtonEdit_Click()
        {

        }

        protected virtual void BarButtonCancel_Click()
        {

        }

        protected virtual void BarButtonDelete_Click()
        {

        }

        private void BarButtonNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonNew_Click();
        }

        private void BarButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonEdit_Click();
        }

        private void BarButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonCancel_Click();
        }

        private void BarButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonDelete_Click();
        }
    }
}