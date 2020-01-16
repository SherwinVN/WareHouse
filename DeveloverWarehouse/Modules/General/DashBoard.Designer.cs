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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schHistory = new Develover.GUI.Controls.DeveloverSchedulerControl();
            this.schDataHistory = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.develoverDateNavigator1 = new Develover.GUI.Controls.DeveloverDateNavigator();
            this.grcUser = new Develover.GUI.Controls.DeveloverGridControl();
            this.grvUser = new Develover.GUI.Controls.DeveloverGridView();
            ((System.ComponentModel.ISupportInitialize)(this.schHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schDataHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverDateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverDateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // schHistory
            // 
           // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 397);
            this.Controls.Add(this.grcUser);
            this.Controls.Add(this.schHistory);
            this.Controls.Add(this.develoverDateNavigator1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.schHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schDataHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverDateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.develoverDateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Develover.GUI.Controls.DeveloverSchedulerControl schHistory;
        private DevExpress.XtraScheduler.SchedulerDataStorage schDataHistory;
        private Develover.GUI.Controls.DeveloverDateNavigator develoverDateNavigator1;
        private Develover.GUI.Controls.DeveloverGridControl grcUser;
        private Develover.GUI.Controls.DeveloverGridView grvUser;
    }
}