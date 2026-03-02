namespace RealEstateAgency.Forms
{
    partial class QueryForm
    {
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grid;

        private void InitializeComponent()
        {
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPriceFrom = new System.Windows.Forms.TextBox();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();

            txtCity.PlaceholderText = "Город";
            txtCity.Top = 10;
            txtCity.Left = 10;

            txtPriceFrom.PlaceholderText = "Цена от";
            txtPriceFrom.Top = 10;
            txtPriceFrom.Left = 150;

            txtPriceTo.PlaceholderText = "Цена до";
            txtPriceTo.Top = 10;
            txtPriceTo.Left = 290;

            txtRooms.PlaceholderText = "Комнаты";
            txtRooms.Top = 10;
            txtRooms.Left = 430;

            btnSearch.Text = "Найти";
            btnSearch.Top = 10;
            btnSearch.Left = 570;
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            grid.Height = 350;
            grid.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(txtCity);
            this.Controls.Add(txtPriceFrom);
            this.Controls.Add(txtPriceTo);
            this.Controls.Add(txtRooms);
            this.Controls.Add(btnSearch);
            this.Controls.Add(grid);

            this.Text = "Запросы";
            this.ClientSize = new System.Drawing.Size(750, 420);

            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}