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

namespace Develover.Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DeveloverEntities entities = new DeveloverEntities();
            InitializeComponent();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            List<SysDELListVoucher> sysDELListVoucher = entities.SysDELListVouchers.ToList();
            sysDELListVoucher.ForEach((s) =>
            {

                collection.Add(s.ModelName);
            });
            textEdit1.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textEdit1.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textEdit1.MaskBox.AutoCompleteCustomSource = collection;

            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.HorizontalScroll.Visible = true;
            textEdit1.KeyDown += TextEdit1_KeyDown; ;
        }

        private void TextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonInTag button= new buttonInTag(((TextEdit)sender).Text, groupControl1.Controls.Count.ToString());
    
                flowLayoutPanel1.Controls.Add(button);
                
                textEdit1.Text = "";
            }
        }


    }
}
