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
using Develover.GUI;
using Develover.GUI.Forms;

namespace DeveloverWarehouse.Modules.General
{
    public partial class DashBoard : DeveloverForm, IDeveloverFormChild
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public Task SetStatusAsync(string message)
        {
            throw new NotImplementedException();
        }
    }
}