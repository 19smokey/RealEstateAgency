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

        // Запрос по району
        private void btnByCity_Click(object sender, EventArgs e)
        {
            var city = txtCity.Text;

            var data = db.Properties
                .Where(p => p.City.Name.Contains(city))
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

        // Запрос по ценовому диапазону
        private void btnByPrice_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPriceFrom.Text, out decimal from) &&
                decimal.TryParse(txtPriceTo.Text, out decimal to))
            {
                var data = db.Properties
                    .Where(p => p.Price >= from && p.Price <= to)
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
            else
            {
                MessageBox.Show("Введите корректные значения для ценового диапазона.");
            }
        }

        // Запрос по клиентам, арендующим недвижимость
        private void btnByClients_Click(object sender, EventArgs e)
        {
            // Запрос на получение клиентов, которые арендовали недвижимость
            var data = db.Deals
                .Where(d => d.Client != null && d.Property != null)  // Только если клиент и объект недвижимости существуют
                .Select(d => new
                {
                    Клиент = d.Client.Name,
                    Объект = d.Property.Address,
                    Агент = d.Agent.Name,
                    Тип = d.Property.PropertyType.Name,
                    Город = d.Property.City.Name,
                    ДатаСделки = d.DealDate
                })
                .ToList();

            grid.DataSource = data;
        }
    }
}