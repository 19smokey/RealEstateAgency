namespace RealEstateAgency.Forms
{
    partial class PropertyForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbOwner;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbOwner = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();

            txtAddress.Left = 10;
            txtAddress.Top = 10;
            txtAddress.Width = 150;
            txtAddress.PlaceholderText = "Адрес";

            txtRooms.Left = 170;
            txtRooms.Top = 10;
            txtRooms.Width = 80;
            txtRooms.PlaceholderText = "Комнаты";

            txtPrice.Left = 260;
            txtPrice.Top = 10;
            txtPrice.Width = 100;
            txtPrice.PlaceholderText = "Цена";

            cbOwner.Left = 370;
            cbOwner.Top = 10;
            cbOwner.Width = 120;

            cbCity.Left = 500;
            cbCity.Top = 10;
            cbCity.Width = 120;

            cbType.Left = 630;
            cbType.Top = 10;
            cbType.Width = 120;

            btnAdd.Text = "Добавить";
            btnAdd.Left = 10;
            btnAdd.Top = 45;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            btnUpdate.Text = "Изменить";
            btnUpdate.Left = 120;
            btnUpdate.Top = 45;
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            btnDelete.Text = "Удалить";
            btnDelete.Left = 230;
            btnDelete.Top = 45;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            grid.Height = 350;
            grid.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);

            this.Controls.Add(txtAddress);
            this.Controls.Add(txtRooms);
            this.Controls.Add(txtPrice);
            this.Controls.Add(cbOwner);
            this.Controls.Add(cbCity);
            this.Controls.Add(cbType);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(grid);

            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.PropertyForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}