namespace RealEstateAgency.Forms
{
    partial class QueryForm
    {
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.Button btnByCity;
        private System.Windows.Forms.Button btnByPrice;
        private System.Windows.Forms.Button btnByClients;
        private System.Windows.Forms.DataGridView grid;

        private void InitializeComponent()
        {
            txtCity = new TextBox();
            txtPriceFrom = new TextBox();
            txtPriceTo = new TextBox();
            btnByCity = new Button();
            btnByPrice = new Button();
            btnByClients = new Button();
            grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(10, 10);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Город";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 0;
            // 
            // txtPriceFrom
            // 
            txtPriceFrom.Location = new Point(150, 10);
            txtPriceFrom.Name = "txtPriceFrom";
            txtPriceFrom.PlaceholderText = "Цена от";
            txtPriceFrom.Size = new Size(100, 23);
            txtPriceFrom.TabIndex = 1;
            // 
            // txtPriceTo
            // 
            txtPriceTo.Location = new Point(290, 10);
            txtPriceTo.Name = "txtPriceTo";
            txtPriceTo.PlaceholderText = "Цена до";
            txtPriceTo.Size = new Size(100, 23);
            txtPriceTo.TabIndex = 2;
            // 
            // btnByCity
            // 
            btnByCity.Location = new Point(10, 40);
            btnByCity.Name = "btnByCity";
            btnByCity.Size = new Size(75, 23);
            btnByCity.TabIndex = 3;
            btnByCity.Text = "По городу";
            btnByCity.Click += btnByCity_Click;
            // 
            // btnByPrice
            // 
            btnByPrice.Location = new Point(233, 40);
            btnByPrice.Name = "btnByPrice";
            btnByPrice.Size = new Size(75, 23);
            btnByPrice.TabIndex = 4;
            btnByPrice.Text = "По цене";
            btnByPrice.Click += btnByPrice_Click;
            // 
            // btnByClients
            // 
            btnByClients.Location = new Point(483, 12);
            btnByClients.Name = "btnByClients";
            btnByClients.Size = new Size(165, 23);
            btnByClients.TabIndex = 5;
            btnByClients.Text = "По арендаторам";
            btnByClients.Click += btnByClients_Click;
            // 
            // grid
            // 
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Dock = DockStyle.Bottom;
            grid.Location = new Point(0, 170);
            grid.Name = "grid";
            grid.Size = new Size(750, 250);
            grid.TabIndex = 6;
            // 
            // QueryForm
            // 
            ClientSize = new Size(750, 420);
            Controls.Add(txtCity);
            Controls.Add(txtPriceFrom);
            Controls.Add(txtPriceTo);
            Controls.Add(btnByCity);
            Controls.Add(btnByPrice);
            Controls.Add(btnByClients);
            Controls.Add(grid);
            Name = "QueryForm";
            Text = "Запросы";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}