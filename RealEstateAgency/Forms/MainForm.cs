using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Data;

namespace RealEstateAgency.Forms
{
    public partial class MainForm : Form
    {
        private AppDbContext db;

        public MainForm()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = db.Properties
                .Include(p => p.Owner)
                .Include(p => p.City)
                .Include(p => p.PropertyType)
                .Select(p => new
                {
                    Адрес = p.Address,
                    Комнаты = p.Rooms,
                    Цена = p.Price,
                    Владелец = p.Owner.Name,
                    Город = p.City.Name,
                    Тип = p.PropertyType.Name
                })
                .ToList();

            grid.DataSource = data;
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            new PropertyForm().ShowDialog();
            LoadData(); // обновление после изменений
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            new QueryForm().ShowDialog();
        }
    }
}