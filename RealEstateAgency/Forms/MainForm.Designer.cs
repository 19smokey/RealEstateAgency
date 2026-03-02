namespace RealEstateAgency.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel topPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 50;
            this.lblTitle.Text = "Агентство недвижимости";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font =
                new System.Drawing.Font("Segoe UI", 14F,
                System.Drawing.FontStyle.Bold);

            // topPanel
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 50;

            // btnProperties
            this.btnProperties.Text = "Объекты";
            this.btnProperties.Width = 140;
            this.btnProperties.Left = 20;
            this.btnProperties.Top = 10;
            this.btnProperties.Click +=
                new System.EventHandler(this.btnProperties_Click);

            // btnQueries
            this.btnQueries.Text = "Запросы";
            this.btnQueries.Width = 140;
            this.btnQueries.Left = 180;
            this.btnQueries.Top = 10;
            this.btnQueries.Click +=
                new System.EventHandler(this.btnQueries_Click);

            this.topPanel.Controls.Add(this.btnProperties);
            this.topPanel.Controls.Add(this.btnQueries);

            // grid
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.ReadOnly = true;
            this.grid.AllowUserToAddRows = false;
            this.grid.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // MainForm
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.lblTitle);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}