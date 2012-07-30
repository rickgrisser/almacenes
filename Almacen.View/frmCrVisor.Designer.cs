namespace Almacen.View
{
    partial class FrmCrVisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrVisor));
            this.crVisor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crVisor
            // 
            this.crVisor.ActiveViewIndex = -1;
            this.crVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crVisor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crVisor.EnableDrillDown = false;
            this.crVisor.EnableRefresh = false;
            this.crVisor.EnableToolTips = false;
            this.crVisor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crVisor.Location = new System.Drawing.Point(0, 0);
            this.crVisor.Name = "crVisor";
            this.crVisor.ShowCloseButton = false;
            this.crVisor.ShowCopyButton = false;
            this.crVisor.ShowGroupTreeButton = false;
            this.crVisor.ShowParameterPanelButton = false;
            this.crVisor.ShowRefreshButton = false;
            this.crVisor.ShowTextSearchButton = false;
            this.crVisor.Size = new System.Drawing.Size(939, 561);
            this.crVisor.TabIndex = 1;
            this.crVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmCrVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(939, 561);
            this.Controls.Add(this.crVisor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrVisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresión de Reportes";
            this.Load += new System.EventHandler(this.FrmCrVisor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crVisor;

    }
}