using Develover.GUI;
using Develover.GUI.Forms;
using Develover.GUI.OverideClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Develover.GUI.OverideClass.Enum;
using static Develover.GUI.OverideClass.DelMessageBox;


namespace DeveloverWarehouse.Modules.Sales
{
    public partial class Unit : DeveloverForm, IDeveloverFormChild
    {
        public Unit()
        {
            InitializeComponent();

            StringNameForm = "UNIT";
            LoadPermission();
        }

        private void LoadPermission()
        {
            PermissionNew = true;
            PermissionEdit = true;
            PermissionDelete = true;
            PermissionPrint = true;
        }

        public void SetStatus(string message)
        {
            throw new NotImplementedException();
        }

        public Task SetStatusAsync(string message)
        {
            throw new NotImplementedException();
        }

        private void but_item_new_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PermissionNew)
            {

            }
            else {
                DelMessageBoxPermission(EnumPermission.New);
                return;
            }
        }

        private void but_item_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (PermissionEdit )
            {

            }
            else
            {
                DelMessageBoxPermission(EnumPermission.Edit);
                return;
            }
        }

        private void but_item_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void but_item_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (PermissionDelete)
            {

            }
            else
            {
                DelMessageBoxPermission(EnumPermission.Delete);
                return;
            }
        }


        private void but_item_print(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PermissionPrint)
            {

            }
            else
            {
                DelMessageBoxPermission(EnumPermission.Print);
                return;
            }
        }
    }
}
