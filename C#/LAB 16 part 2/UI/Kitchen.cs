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

                chkCleaning.Checked = res.cleaning ;
                chkTowel.Checked = res.towel ;
                chkSurprise.Checked = res.s_surprise ;
                chkSupplyStatus.Checked = res.supply_status ;
            }
        }
    }
}