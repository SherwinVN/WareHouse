namespace DeveloverWarehouse.Modules.General
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // schHistory
            // 
            this.schHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schHistory.DataStorage = this.schDataHistory;
            this.schHistory.FieldBinding = null;
            this.schHistory.IsGUID = false;
            this.schHistory.Location = new System.Drawing.Point(266, 12);
            this.schHistory.Name = "schHistory";
            this.schHistory.Size = new System.Drawing.Size(511, 373);
            this.schHistory.Start = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.schHistory.TabIndex = 0;
            this.schHistory.Text = "schHistory";
            this.schHistory.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.schHistory.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schHistory.Views.FullWeekView.Enabled = true;
            this.schHistory.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schHistory.Views.WeekView.Enabled = false;
            this.schHistory.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schHistory.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schHistory_EditAppointmentFormShowing);
            // 
            // schDataHistory
            // 
            // 
            // 
            // 
            this.schDataHistory.AppointmentDependencies.AutoReload = false;
            // 
            // develoverDateNavigator1
            // 
            this.develoverDateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.develoverDateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.develoverDateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.develoverDateNavigator1.DateTime = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.develoverDateNavigator1.EditValue = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.develoverDateNavigator1.FieldBinding = null;
            this.develoverDateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.develoverDateNavigator1.IsGUID = false;
            this.develoverDateNavigator1.Location = new System.Drawing.Point(12, 12);
            this.develoverDateNavigator1.Name = "develoverDateNavigator1";
            this.develoverDateNavigator1.SchedulerControl = this.schHistory;
            this.develoverDateNavigator1.Size = new System.Drawing.Size(248, 239);
            this.develoverDateNavigator1.TabIndex = 1;
            this.develoverDateNavigator1.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            // 
            // grcUser
            // 
            this.grcUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grcUser.FieldBinding = null;
            this.grcUser.IsGUID = false;
            this.grcUser.Location = new System.Drawing.Point(12, 257);
            this.grcUser.MainView = this.grvUser;
            this.grcUser.Name = "grcUser";
            this.grcUser.Size = new System.Drawing.Size(248, 128);
            this.grcUser.TabIndex = 2;
            this.grcUser.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvUser});
            // 
            // grvUser
            // 
            this.grvUser.FieldBinding = null;
            this.grvUser.GridControl = this.grcUser;
            this.grvUser.IndicatorWidth = 40;
            this.grvUser.IsGUID = false;
            this.grvUser.Name = "grvUser";
            this.grvUser.OptionsSelection.MultiSelect = true;
            this.grvUser.OptionsView.ColumnAutoWidth = false;
            this.grvUser.OptionsView.ShowGroupPanel = false;
            this.grvUser.TypeFieldColumns = Develover.Utilities.Enum.EnumTypeColumns.Date;
            this.grvUser.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvUser_FocusedRowChanged);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 415);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion
    }
}