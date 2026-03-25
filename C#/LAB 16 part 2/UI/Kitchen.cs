using D16PCSharp_HotelManagement.Entities;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
            btnClose.Click += (s, e) => this.Close();
            lstQueue.SelectedIndexChanged += lstQueue_SelectedIndexChanged;

            LoadKitchenDataGrid();
            LoadQueueList();
        }

        HotelContext Context = new HotelContext();
        Reservation currentReservation;

        private void LoadKitchenDataGrid()
        {
            dgvOverview.DataSource = Context.Reservations
                .AsNoTracking()
                .Where(p => p.check_in == true && p.supply_status == false)
                .Select(p => new
                {
                    p.Id,
                    FirstName = p.first_name,
                    LastName = p.last_name,
                    Phone = p.phone_number,
                    RoomType = p.room_type,
                    Floor = p.room_floor,
                    Breakfast = p.break_fast,
                    Lunch = p.lunch,
                    Dinner = p.dinner,
                    Cleaning = p.cleaning,
                    Towel = p.towel,
                    Surprise = p.s_surprise,
                    Status = p.supply_status,
                    FoodBill = p.food_bill
                })
                .ToList();
        }

        private void LoadQueueList()
        {
            var activeList = Context.Reservations
                .Where(r => r.check_in == true && r.supply_status == false)
                .ToList();

            lstQueue.DataSource = activeList;
            lstQueue.DisplayMember = "first_name";
            lstQueue.ValueMember = "Id";
        }

        private void lstQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQueue.SelectedItem is Reservation res)
            {
                currentReservation = res;

                txtFirst.Text = res.first_name;
                txtLast.Text = res.last_name;
                txtPhone.Text = res.phone_number;
                txtRoomType.Text = res.room_type;
                txtFloor.Text = res.room_floor?.ToString();
                txtRoomNum.Text = res.room_number?.ToString();

                txtBfast.Text = res.break_fast?.ToString() ?? "0";
                txtLunch.Text = res.lunch?.ToString() ?? "0";
                txtDinner.Text = res.dinner?.ToString() ?? "0";

                chkCleaning.Checked = res.cleaning;
                chkTowel.Checked = res.towel;
                chkSurprise.Checked = res.s_surprise;
                chkSupplyStatus.Checked = res.supply_status;
            }
        }

        private void btnFoodSelect_Click(object sender, EventArgs e)
        {
            if (currentReservation == null) return;

            FoodMenu menu = new FoodMenu();

            menu.Bfast = int.Parse(txtBfast.Text);
            menu.Lunch = int.Parse(txtLunch.Text);
            menu.Dinner = int.Parse(txtDinner.Text);
            menu.Cleaning = chkCleaning.Checked;
            menu.Towel = chkTowel.Checked;
            menu.Surprise = chkSurprise.Checked;

            if (menu.ShowDialog() == DialogResult.OK)
            {
                txtBfast.Text = menu.Bfast.ToString();
                txtLunch.Text = menu.Lunch.ToString();
                txtDinner.Text = menu.Dinner.ToString();

                chkCleaning.Checked = menu.Cleaning;
                chkTowel.Checked = menu.Towel;
                chkSurprise.Checked = menu.Surprise;

                currentReservation.break_fast = menu.Bfast;
                currentReservation.lunch = menu.Lunch;
                currentReservation.dinner = menu.Dinner;
                currentReservation.cleaning = menu.Cleaning;
                currentReservation.towel = menu.Towel;
                currentReservation.s_surprise = menu.Surprise;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentReservation == null) return;

            int b = int.Parse(txtBfast.Text);
            int l = int.Parse(txtLunch.Text);
            int d = int.Parse(txtDinner.Text);
            int fBill = (b * 7) + (l * 15) + (d * 15);

            Context.Database.ExecuteSqlInterpolated($@"EXEC sp_UpdateReservationKitchen 
               {currentReservation.Id}, {b}, {l}, {d}, 
               {chkCleaning.Checked}, {chkTowel.Checked}, {chkSurprise.Checked}, 
               {chkSupplyStatus.Checked}, {fBill}");

            LoadKitchenDataGrid();
            LoadQueueList();
            MessageBox.Show("Updated Successfully!");
        }

        private void chkSupplyStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (currentReservation == null) return;
            if (!chkSupplyStatus.Checked)
            {
                chkCleaning.Text = "Cleaning";
                chkTowel.Text = "Toweling";
                chkSurprise.Text = "Surprise";
                chkCleaning.Checked = currentReservation.cleaning;
                chkTowel.Checked = currentReservation.towel;
                chkSurprise.Checked = currentReservation.s_surprise;

            }
            else
            {
                chkCleaning.Checked = false;
                chkCleaning.Text = "Cleaned";
                chkTowel.Checked = false;
                chkTowel.Text = "Toweled";
                chkSurprise.Checked = false;
                chkSurprise.Text = "Surprised";

            }


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}