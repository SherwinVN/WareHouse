namespace Develover.Core
{
    partial class buttonInTag
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buttonInTag));
            this.labDisplayValue = new DevExpress.XtraEditors.LabelControl();
            this.butDelete = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labDisplayValue
            // 
            this.labDisplayValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labDisplayValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDisplayValue.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labDisplayValue.Location = new System.Drawing.Point(0, 0);
            this.labDisplayValue.Name = "labDisplayValue";
            this.labDisplayValue.Size = new System.Drawing.Size(91, 25);
            this.labDisplayValue.TabIndex = 0;
            this.labDisplayValue.Text = "Display Value";
            // 
            // butDelete
            // 
            this.butDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.butDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.butDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.butDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.butDelete.Location = new System.Drawing.Point(91, 0);
            this.butDelete.Name = "butDelete";
            this.butDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.butDelete.Size = new System.Drawing.Size(28, 25);
            this.butDelete.TabIndex = 1;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // buttonInTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labDisplayValue);
            this.Controls.Add(this.butDelete);
            this.Name = "buttonInTag";
            this.Size = new System.Drawing.Size(119, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labDisplayValue;
        private DevExpress.XtraEditors.SimpleButton butDelete;
    }
}
