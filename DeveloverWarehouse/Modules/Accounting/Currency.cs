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

namespace DeveloverWarehouse.Modules.Accounting
{
    public partial class Currency : DeveloverForm, IDeveloverFormChild
    {
        public Currency()
        {
            InitializeComponent();
        }

        public void SetStatus(string message)
        {
            throw new NotImplementedException();
        }

        public Task SetStatusAsync(string message)
        {
            throw new NotImplementedException();
        }
    }
}
