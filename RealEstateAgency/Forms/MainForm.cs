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
            // Получаем все объекты недвижимости, даже если на них нет сделок
            var data = db.Properties
                .Include(p => p.Owner)           // Загружаем владельцев
                .Include(p => p.City)            // Загружаем города
                .Include(p => p.PropertyType)    // Загружаем тип недвижимости
                .Select(p => new
                {
                    Адрес = p.Address,
                    Город = p.City.Name,
                    Владелец = p.Owner.Name,
                    Тип = p.PropertyType.Name,
                    Комнаты = p.Rooms,
                    Цена = p.Price,
                    Сделка = db.Deals
                        .Where(d => d.PropertyId == p.Id)
                        .Select(d => d.DealDate)
                        .FirstOrDefault() // Возвращаем дату первой сделки, если она есть
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