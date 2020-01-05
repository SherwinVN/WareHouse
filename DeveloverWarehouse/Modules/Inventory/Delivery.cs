
using Develover.GUI.Forms;
using Develover.GUI;

namespace DeveloverWarehouse.Modules.Inventory
{
    public partial class Delivery : DeveloverVoucherForm, IDeveloverFormChild
    {
        public Delivery()
        {
            InitializeComponent();
            CodeVoucher = "Delivery";
            ViewSearch = "VDeliverySearch";
            ViewVouvher = "VDelivery";



            DeveloverControlsFocus = lokCustomer;
            ControlCheckExit = new IDeveloverControl[] { };
            ControlCheckEmty = new IDeveloverControl[] { lokCustomer };
        }

        private void groHeader_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void Delivery_Load(object sender, System.EventArgs e)
        {
            InitForm();

        }
        protected override void LoadDataControls()
        {
            lokCustomer.LoadData("SELECT * FROM CUSTOMER", "CUSTOMMER", "CustomerID", "CustomerID", "CustomerName", "");
        }
    }
}