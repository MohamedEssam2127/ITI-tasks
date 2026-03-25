using DAL;
using D16PCSharp_HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Frontend : Form
    {
        private ReservationManagment manager = new ReservationManagment();
        private bool editClicked = false;
        private int primaryID = 0;
        private double currentRoomPrice = 0;
        private double finalTotalWithTax = 0;
        private int breakfast = 0, lunch = 0, dinner = 0, foodBill = 0;
        private bool cleaning = false, towel = false, surprise = false;
        private string pType, cType, cNum, cExp, cCvc;

        public Frontend()
        {
            InitializeComponent();
            InitializeAllComboBoxes();
            SetInitialVisibility();
            AttachEvents();
        }

        private void AttachEvents()
        {
            btnClose.Click += (s, e) => this.Close();
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            resEditButton.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
            updateButton.Click += updateButton_Click;
        }

        private void SetInitialVisibility()
        {
            submitButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
        }

        private void InitializeAllComboBoxes()
        {
            monthComboBox.Items.Clear();
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });

            dayComboBox.Items.Clear();
            for (int i = 1; i <= 31; i++) dayComboBox.Items.Add(i.ToString("D2"));

            qtGuestComboBox.Items.Clear();
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });

            genderComboBox.Items.Clear();
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });

            roomTypeComboBox.Items.Clear();
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });

            floorComboBox.Items.Clear();
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });

            roomNComboBox.Items.Clear();
            for (int i = 1; i <= 2; i++)
                for (int j = 1; j <= 10; j++)
                    roomNComboBox.Items.Add($"{i}{j:D2}");

            stateComboBox.Items.Clear();
            stateComboBox.Items.AddRange(new object[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana" });
        }

        private void PopulateEditList()
        {
            resEditButton.Items.Clear();
            var all = manager.GetAllReservations();
            foreach (var res in all)
            {
                resEditButton.Items.Add($"{res.Id} | {res.first_name} {res.last_name}");
            }
        }

        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resEditButton.SelectedItem == null) return;

            string selected = resEditButton.SelectedItem.ToString();
            int id = int.Parse(selected.Split('|')[0].Trim());

            var res = manager.GetAllReservations().FirstOrDefault(r => r.Id == id);
            if (res != null)
            {
                primaryID = res.Id;
                firstNameTextBox.Text = res.first_name;
                lastNameTextBox.Text = res.last_name;
                phoneNumberTextBox.Text = res.phone_number;
                emailTextBox.Text = res.email_address;
                addLabel.Text = res.street_address;
                aptTextBox.Text = res.apt_suite;
                cityTextBox.Text = res.city;
                zipComboBox.Text = res.zip_code;

                genderComboBox.SelectedItem = res.gender;
                stateComboBox.SelectedItem = res.state;
                roomTypeComboBox.SelectedItem = res.room_type;
                floorComboBox.SelectedItem = res.room_floor?.ToString();
                roomNComboBox.SelectedItem = res.room_number?.ToString();
                qtGuestComboBox.SelectedItem = res.number_guest?.ToString();

                if (!string.IsNullOrEmpty(res.birth_day))
                {
                    string[] bparts = res.birth_day.Split('-');
                    if (bparts.Length == 3)
                    {
                        monthComboBox.SelectedItem = bparts[0];
                        dayComboBox.SelectedItem = bparts[1];
                        yearTextBox.Text = bparts[2];
                    }
                }

                entryDatePicker.Value = res.arrival_time ?? DateTime.Now;
                depDatePicker.Value = res.leaving_time ?? DateTime.Now;
                checkinCheckBox.Checked = res.check_in ?? false;
                foodSupplyCheckBox.Checked = res.supply_status;

                breakfast = res.break_fast ?? 0;
                lunch = res.lunch ?? 0;
                dinner = res.dinner ?? 0;
                cleaning = res.cleaning;
                towel = res.towel;
                surprise = res.s_surprise;
                foodBill = res.food_bill ?? 0;

                finalTotalWithTax = res.total_bill ?? 0;
                pType = res.payment_type;
                cType = res.card_type;
                cNum = res.card_number;
                cExp = res.card_exp;
                cCvc = res.card_cvc;
            }
        }

        private Reservation MapToEntity()
        {
            return new Reservation
            {
                Id = primaryID,
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                birth_day = $"{monthComboBox.SelectedItem}-{dayComboBox.SelectedItem}-{yearTextBox.Text}",
                gender = genderComboBox.SelectedItem?.ToString(),
                phone_number = phoneNumberTextBox.Text,
                email_address = emailTextBox.Text,
                number_guest = int.TryParse(qtGuestComboBox.SelectedItem?.ToString(), out int g) ? g : 1,
                street_address = addLabel.Text,
                apt_suite = aptTextBox.Text,
                city = cityTextBox.Text,
                state = stateComboBox.SelectedItem?.ToString(),
                zip_code = zipComboBox.Text,
                room_type = roomTypeComboBox.SelectedItem?.ToString(),
                room_floor = int.TryParse(floorComboBox.SelectedItem?.ToString(), out int f) ? f : 0,
                room_number = int.TryParse(roomNComboBox.SelectedItem?.ToString(), out int rn) ? rn : 0,
                arrival_time = entryDatePicker.Value,
                leaving_time = depDatePicker.Value,
                check_in = checkinCheckBox.Checked,
                break_fast = breakfast,
                lunch = lunch,
                dinner = dinner,
                cleaning = cleaning,
                towel = towel,
                s_surprise = surprise,
                food_bill = foodBill,
                supply_status = foodSupplyCheckBox.Checked,
                total_bill = finalTotalWithTax,
                payment_type = pType,
                card_type = cType,
                card_number = cNum,
                card_exp = cExp,
                card_cvc = cCvc
            };
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (primaryID == 0) return;
            try
            {
                manager.UpdateReservation(MapToEntity());
                MessageBox.Show("Updated Successfully!");
                RefreshUI();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeComboBox.SelectedItem == null) return;
            string selectedType = roomTypeComboBox.SelectedItem.ToString();

            switch (selectedType)
            {
                case "Single": floorComboBox.SelectedItem = "1"; currentRoomPrice = 149; break;
                case "Double": floorComboBox.SelectedItem = "2"; currentRoomPrice = 299; break;
                case "Twin": floorComboBox.SelectedItem = "3"; currentRoomPrice = 349; break;
                case "Duplex": floorComboBox.SelectedItem = "4"; currentRoomPrice = 399; break;
                case "Suite": floorComboBox.SelectedItem = "5"; currentRoomPrice = 499; break;
            }
        }

        private void foodMenuButton_Click(object sender, EventArgs e)
        {
            FoodMenu menu = new FoodMenu();
            menu.Bfast = breakfast;
            menu.Lunch = lunch;
            menu.Dinner = dinner;
            menu.Cleaning = cleaning;
            menu.Towel = towel;
            menu.Surprise = surprise;

            if (menu.ShowDialog() == DialogResult.OK)
            {
                breakfast = menu.Bfast;
                lunch = menu.Lunch;
                dinner = menu.Dinner;
                cleaning = menu.Cleaning;
                towel = menu.Towel;
                surprise = menu.Surprise;
                foodBill = (breakfast * 7) + (lunch * 15) + (dinner * 15);
            }
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            FinalizePayment finalizeForm = new FinalizePayment();
            finalizeForm.ReservationPrice = currentRoomPrice;
            finalizeForm.FoodBill = foodBill;

            if (finalizeForm.ShowDialog() == DialogResult.OK)
            {
                finalTotalWithTax = finalizeForm.FinalTotal;
                pType = finalizeForm.PaymentType;
                cType = finalizeForm.CardType;
                cNum = finalizeForm.CardNumber;
                cExp = finalizeForm.CardExp;
                cCvc = finalizeForm.CardCvc;

                updateButton.Enabled = true;
                if (!editClicked) submitButton.Visible = true;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = manager.AddReservation(MapToEntity());
                MessageBox.Show("Saved! ID: " + id);
                RefreshUI();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void Frontend_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            submitButton.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;
            PopulateEditList();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            editClicked = false;
            primaryID = 0;
            SetInitialVisibility();
            ClearForm();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dgvSearch.DataSource = manager.SearchReservations(searchTextBox.Text);
        }

        private void RefreshUI()
        {
            dgvTotal.DataSource = null;
            dgvTotal.DataSource = manager.GetAllReservations();
            lstReserved.DataSource = manager.GetCheckInReservations(false);
            lstOccupied.DataSource = manager.GetCheckInReservations(true);
        }

        private void ClearForm()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
            yearTextBox.Clear();
            addLabel.Clear();
            aptTextBox.Clear();
            cityTextBox.Clear();
            zipComboBox.Clear();
            primaryID = 0;
            breakfast = 0; lunch = 0; dinner = 0; foodBill = 0;
            currentRoomPrice = 0; finalTotalWithTax = 0;
            cleaning = false; towel = false; surprise = false;
            checkinCheckBox.Checked = false;
            foodSupplyCheckBox.Checked = false;
            submitButton.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (primaryID == 0) return;
            if (MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    manager.DeleteReservation(primaryID);
                    MessageBox.Show("Deleted Successfully!");
                    RefreshUI();
                    ClearForm();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            
            this.Hide();
        }
    }
}