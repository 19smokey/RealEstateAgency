using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Data;

namespace RealEstateAgency.Forms
{
    public partial class QueryForm : Form
    {
        private AppDbContext db = new AppDbContext();

        public QueryForm()
        {
            InitializeComponent();
        }

        // поиск по параметрам
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = db.Properties
                .Include(p => p.Owner)
                .Include(p => p.City)
                .Include(p => p.PropertyType)
                .AsQueryable();

            // город
            if (!string.IsNullOrWhiteSpace(txtCity.Text))
                query = query.Where(p =>
                    p.City.Name.Contains(txtCity.Text));

            // цена от
            if (decimal.TryParse(txtPriceFrom.Text, out decimal from))
                query = query.Where(p => p.Price >= from);

            // цена до
            if (decimal.TryParse(txtPriceTo.Text, out decimal to))
                query = query.Where(p => p.Price <= to);

            // комнаты
            if (int.TryParse(txtRooms.Text, out int rooms))
                query = query.Where(p => p.Rooms == rooms);

            grid.DataSource = query
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
        }
    }
}