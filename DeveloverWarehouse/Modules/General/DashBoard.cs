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
using DevExpress.XtraScheduler;
using Develover.Services;
using DevExpress.XtraGrid.Views.Grid;

namespace DeveloverWarehouse.Modules.General
{
    public partial class DashBoard : DeveloverForm, IDeveloverFormChild
    {
        public DashBoard()
        {
            InitializeComponent();
            grcUser.BuildGridControlsView("SELECT * FROM sysDELUser", "User");
            grcUser.LoadData();

            schDataHistory.Appointments.DataSource = new DataTable();

        }

        public Task SetStatusAsync(string message)
        {
            throw new NotImplementedException();
        }

        private void grvUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            schDataHistory.Appointments.Clear();
            schHistory.Start = DateTime.Now;


            schHistory.ActiveViewType = SchedulerViewType.Month;
            schHistory.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schHistory.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            schHistory.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            schHistory.Views.MonthView.AppointmentDisplayOptions.TimeDisplayType = DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text;

            Functions functions = new Functions();

            string UserID = ((GridView)sender).GetRowCellValue(e.FocusedRowHandle, "ID").ToString();
            DataTable data;

            if (UserID is null)
            {
                data = functions.dataBase.GetDataTable("SELECT * FROM VSysDELHistoryLogin");
            }
            else
            if (UserID.Equals(""))
                data = functions.dataBase.GetDataTable("SELECT * FROM VSysDELHistoryLogin");
            else
                data = functions.dataBase.GetDataTable("SELECT * FROM VSysDELHistoryLogin WHERE USERID = '" + UserID + "'");


            DataView dataView = new DataView(data);
            DataRow[] dataRow;
            Appointment app;
            DateTime dateTime;
            using (DataTable dataListUser = dataView.ToTable(true, new string[] { "USERID" }))
            {
                foreach (DataRow dataRow1 in dataListUser.Rows)
                {
                    dataRow = data.Select(" UserID = '" + dataRow1["UserID"] + "'");
                    foreach (DataRow dataRow2 in dataRow)
                    {
                        app = schDataHistory.CreateAppointment(AppointmentType.Normal);

                        dateTime = DateTime.Now;
                        DateTime.TryParse(dataRow2["DateLogin"].ToString(), out dateTime);
                        app.Start = dateTime;

                        dateTime = DateTime.Now;
                        DateTime.TryParse(dataRow2["DateLogout"].ToString(), out dateTime);
                        app.End = dateTime;

                        app.Subject = "Đăng nhập: " + app.Start.ToString("dd/MM/yyyy") + " - Đăng xuất: " + app.End.ToString("dd/MM/yyyy");
                        app.Location = dataRow2["ComputerName"].ToString()+"/"+ dataRow2["IPAddress"].ToString();
                        app.Description = dataRow2["UserName"].ToString()+"/"+ dataRow2["Name"].ToString()+"/"+ dataRow2["Address"].ToString();
                        app.LabelId = 3;
                        app.StatusId = 3;
                        schDataHistory.Appointments.Add(app);
                    }
                }
            }
        }

        private void schHistory_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            DeveloverWarehouse.Modules.General.CustomAppointmentForm form = new DeveloverWarehouse.Modules.General.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }
    }
}
