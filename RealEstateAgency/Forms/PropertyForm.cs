using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Data;
using RealEstateAgency.Models;

namespace RealEstateAgency.Forms
{
    public partial class PropertyForm : Form
    {
        private AppDbContext db = new AppDbContext();
        private int selectedId = -1;

        public PropertyForm()
        {
            InitializeComponent();
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            cbOwner.DataSource = db.Owners.ToList();
            cbOwner.DisplayMember = "Name";
            cbOwner.ValueMember = "Id";

            cbCity.DataSource = db.Cities.ToList();
            cbCity.DisplayMember = "Name";
            cbCity.ValueMember = "Id";

            cbType.DataSource = db.PropertyTypes.ToList();
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";

            LoadData();
        }

        private void LoadData()
        {
            grid.DataSource = db.Properties
                .Include(p => p.Owner)
                .Include(p => p.City)
                .Include(p => p.PropertyType)
                .Select(p => new
                {
                    p.Id,
                    p.Address,
                    p.Rooms,
                    p.Price,
                    Owner = p.Owner.Name,
                    City = p.City.Name,
                    Type = p.PropertyType.Name
                })
                .ToList();
        }

        // ДОБАВИТЬ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Property p = new Property()
            {
                Address = txtAddress.Text,
                Rooms = int.Parse(txtRooms.Text),
                Price = decimal.Parse(txtPrice.Text),
                OwnerId = (int)cbOwner.SelectedValue,
                CityId = (int)cbCity.SelectedValue,
                PropertyTypeId = (int)cbType.SelectedValue
            };

            db.Properties.Add(p);
            db.SaveChanges();
            LoadData();
        }

        // ВЫБОР СТРОКИ
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedId =
                (int)grid.Rows[e.RowIndex].Cells["Id"].Value;
        }

        // ИЗМЕНИТЬ
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var p = db.Properties.Find(selectedId);
            if (p == null) return;

            p.Address = txtAddress.Text;
            p.Rooms = int.Parse(txtRooms.Text);
            p.Price = decimal.Parse(txtPrice.Text);
            p.OwnerId = (int)cbOwner.SelectedValue;
            p.CityId = (int)cbCity.SelectedValue;
            p.PropertyTypeId = (int)cbType.SelectedValue;

            db.SaveChanges();
            LoadData();
        }

        // УДАЛИТЬ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var p = db.Properties.Find(selectedId);
            if (p == null) return;

            db.Properties.Remove(p);
            db.SaveChanges();
            LoadData();
        }
    }
}