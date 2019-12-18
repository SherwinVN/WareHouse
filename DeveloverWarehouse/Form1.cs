using Develover.GUI;
using Develover.GUI.Controls;
using Develover.GUI.Forms;
using Develover.GUI.RepositoryItems;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloverWarehouse
{
    public partial class Form1 : DeveloverCatalogForm, IDeveloverFormChild
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
