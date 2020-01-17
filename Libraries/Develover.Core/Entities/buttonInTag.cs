using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Develover.Core
{
    public partial class buttonInTag : DevExpress.XtraEditors.XtraUserControl
    {
        string stringDisplay;
        string stringValue;
        public buttonInTag(string strDisplay,string strValue)
        {
            InitializeComponent();
            labDisplayValue.Text = stringDisplay = strDisplay;
            stringValue = strValue;
            
            Width = 80;
            Height = 20;
        }

        public string StringDisplay { get => StringDisplay; set => StringDisplay = value; }
        public string StringValue { get => stringValue; set => stringValue = value; }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            this.Dispose();
        }



    }
}
