namespace UI
{
    partial class Frontend
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btnClose = new Button();
            lblHeader = new Label();
            tabMain = new TabControl();
            tpReservation = new TabPage();
            leftMPanel = new Panel();
            lblPersonalInfo = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            monthComboBox = new ComboBox();
            dayComboBox = new ComboBox();
            yearTextBox = new TextBox();
            genderComboBox = new ComboBox();
            phoneNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            addLabel = new TextBox();
            aptTextBox = new TextBox();
            cityTextBox = new TextBox();
            stateComboBox = new ComboBox();
            zipComboBox = new TextBox();
            middlePanel = new Panel();
            lblResInfo = new Label();
            qtGuestComboBox = new ComboBox();
            roomTypeComboBox = new ComboBox();
            floorComboBox = new ComboBox();
            roomNComboBox = new ComboBox();
            entryDatePicker = new DateTimePicker();
            depDatePicker = new DateTimePicker();
            foodMenuButton = new Button();
            checkinCheckBox = new CheckBox();
            smsCheckBox = new CheckBox();
            foodSupplyCheckBox = new CheckBox();
            finalizeButton = new Button();
            submitButton = new Button();
            rightMPanel = new Panel();
            lblEditControls = new Label();
            resEditButton = new ComboBox();
            updateButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            newButton = new Button();
            tpSearch = new TabPage();
            searchButton = new Button();
            dgvSearch = new DataGridView();
            searchTextBox = new TextBox();
            tpAdvView = new TabPage();
            dgvTotal = new DataGridView();
            tpRoomAvail = new TabPage();
            lblOccupiedHeader = new Label();
            lblReservedHeader = new Label();
            lstOccupied = new ListBox();
            lstReserved = new ListBox();
            pnlTop.SuspendLayout();
            tabMain.SuspendLayout();
            tpReservation.SuspendLayout();
            leftMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            rightMPanel.SuspendLayout();
            tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            tpAdvView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotal).BeginInit();
            tpRoomAvail.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(52, 152, 219);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(lblHeader);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1330, 45);
            pnlTop.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1280, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 12F);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(364, 28);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Hotel Management - Frontend System";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tpReservation);
            tabMain.Controls.Add(tpSearch);
            tabMain.Controls.Add(tpAdvView);
            tabMain.Controls.Add(tpRoomAvail);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 45);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Point(15, 10);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1330, 605);
            tabMain.TabIndex = 0;
            // 
            // tpReservation
            // 
            tpReservation.BackColor = Color.White;
            tpReservation.Controls.Add(leftMPanel);
            tpReservation.Controls.Add(middlePanel);
            tpReservation.Controls.Add(rightMPanel);
            tpReservation.Location = new Point(4, 43);
            tpReservation.Name = "tpReservation";
            tpReservation.Size = new Size(1322, 558);
            tpReservation.TabIndex = 0;
            tpReservation.Text = "Reservation";
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = Color.FromArgb(245, 245, 245);
            leftMPanel.Controls.Add(lblPersonalInfo);
            leftMPanel.Controls.Add(firstNameTextBox);
            leftMPanel.Controls.Add(lastNameTextBox);
            leftMPanel.Controls.Add(monthComboBox);
            leftMPanel.Controls.Add(dayComboBox);
            leftMPanel.Controls.Add(yearTextBox);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(phoneNumberTextBox);
            leftMPanel.Controls.Add(emailTextBox);
            leftMPanel.Controls.Add(addLabel);
            leftMPanel.Controls.Add(aptTextBox);
            leftMPanel.Controls.Add(cityTextBox);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(zipComboBox);
            leftMPanel.Location = new Point(20, 20);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new Size(420, 510);
            leftMPanel.TabIndex = 0;
            // 
            // lblPersonalInfo
            // 
            lblPersonalInfo.Font = new Font("Segoe UI Semibold", 10F);
            lblPersonalInfo.Location = new Point(15, 10);
            lblPersonalInfo.Name = "lblPersonalInfo";
            lblPersonalInfo.Size = new Size(200, 25);
            lblPersonalInfo.TabIndex = 0;
            lblPersonalInfo.Text = "Personal Information";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(15, 45);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First Name";
            firstNameTextBox.Size = new Size(190, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(215, 45);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last Name";
            lastNameTextBox.Size = new Size(190, 27);
            lastNameTextBox.TabIndex = 2;
            // 
            // monthComboBox
            // 
            monthComboBox.Location = new Point(15, 85);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(120, 28);
            monthComboBox.TabIndex = 3;
            monthComboBox.Text = "Month";
            // 
            // dayComboBox
            // 
            dayComboBox.Location = new Point(140, 85);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(80, 28);
            dayComboBox.TabIndex = 4;
            dayComboBox.Text = "Day";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(225, 85);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year";
            yearTextBox.Size = new Size(180, 27);
            yearTextBox.TabIndex = 5;
            // 
            // genderComboBox
            // 
            genderComboBox.Location = new Point(15, 125);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(390, 28);
            genderComboBox.TabIndex = 6;
            genderComboBox.Text = "Gender";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(15, 165);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.PlaceholderText = "Phone Number";
            phoneNumberTextBox.Size = new Size(390, 27);
            phoneNumberTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(15, 205);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email Address";
            emailTextBox.Size = new Size(390, 27);
            emailTextBox.TabIndex = 8;
            // 
            // addLabel
            // 
            addLabel.Location = new Point(15, 245);
            addLabel.Name = "addLabel";
            addLabel.PlaceholderText = "Street Address";
            addLabel.Size = new Size(390, 27);
            addLabel.TabIndex = 9;
            // 
            // aptTextBox
            // 
            aptTextBox.Location = new Point(15, 285);
            aptTextBox.Name = "aptTextBox";
            aptTextBox.PlaceholderText = "Apt./Suite";
            aptTextBox.Size = new Size(190, 27);
            aptTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(215, 285);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PlaceholderText = "City";
            cityTextBox.Size = new Size(190, 27);
            cityTextBox.TabIndex = 11;
            // 
            // stateComboBox
            // 
            stateComboBox.Location = new Point(15, 325);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(190, 28);
            stateComboBox.TabIndex = 12;
            stateComboBox.Text = "State";
            // 
            // zipComboBox
            // 
            zipComboBox.Location = new Point(215, 325);
            zipComboBox.Name = "zipComboBox";
            zipComboBox.PlaceholderText = "Zip Code";
            zipComboBox.Size = new Size(190, 27);
            zipComboBox.TabIndex = 13;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.FromArgb(245, 245, 245);
            middlePanel.Controls.Add(lblResInfo);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(smsCheckBox);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Location = new Point(455, 20);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(420, 510);
            middlePanel.TabIndex = 1;
            // 
            // lblResInfo
            // 
            lblResInfo.Font = new Font("Segoe UI Semibold", 10F);
            lblResInfo.Location = new Point(20, 10);
            lblResInfo.Name = "lblResInfo";
            lblResInfo.Size = new Size(200, 25);
            lblResInfo.TabIndex = 0;
            lblResInfo.Text = "Reservation Details";
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.Location = new Point(20, 45);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.Size = new Size(185, 28);
            qtGuestComboBox.TabIndex = 1;
            qtGuestComboBox.Text = "# Guests";
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.Location = new Point(215, 45);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(185, 28);
            roomTypeComboBox.TabIndex = 2;
            roomTypeComboBox.Text = "Room Type";
            // 
            // floorComboBox
            // 
            floorComboBox.Location = new Point(20, 85);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.Size = new Size(185, 28);
            floorComboBox.TabIndex = 3;
            floorComboBox.Text = "Floor";
            // 
            // roomNComboBox
            // 
            roomNComboBox.Location = new Point(215, 85);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.Size = new Size(185, 28);
            roomNComboBox.TabIndex = 4;
            roomNComboBox.Text = "Room #";
            // 
            // entryDatePicker
            // 
            entryDatePicker.Location = new Point(20, 130);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(380, 27);
            entryDatePicker.TabIndex = 5;
            // 
            // depDatePicker
            // 
            depDatePicker.Location = new Point(20, 170);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new Size(380, 27);
            depDatePicker.TabIndex = 6;
            // 
            // foodMenuButton
            // 
            foodMenuButton.Location = new Point(20, 220);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new Size(380, 40);
            foodMenuButton.TabIndex = 7;
            foodMenuButton.Text = "Food and Menu Selection";
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.Location = new Point(20, 275);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new Size(120, 24);
            checkinCheckBox.TabIndex = 8;
            checkinCheckBox.Text = "Check in?";
            // 
            // smsCheckBox
            // 
            smsCheckBox.Location = new Point(140, 275);
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.Size = new Size(120, 24);
            smsCheckBox.TabIndex = 9;
            smsCheckBox.Text = "Send SMS?";
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.Location = new Point(260, 275);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new Size(140, 24);
            foodSupplyCheckBox.TabIndex = 10;
            foodSupplyCheckBox.Text = "Food Supplied?";
            // 
            // finalizeButton
            // 
            finalizeButton.Location = new Point(20, 320);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(380, 45);
            finalizeButton.TabIndex = 11;
            finalizeButton.Text = "Finalize Bill";
            finalizeButton.Click += finalizeButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(0, 192, 0);
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            submitButton.ForeColor = SystemColors.ButtonHighlight;
            submitButton.Location = new Point(20, 380);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(380, 55);
            submitButton.TabIndex = 12;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = Color.FromArgb(245, 245, 245);
            rightMPanel.Controls.Add(lblEditControls);
            rightMPanel.Controls.Add(resEditButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Location = new Point(890, 20);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new Size(400, 510);
            rightMPanel.TabIndex = 2;
            // 
            // lblEditControls
            // 
            lblEditControls.Font = new Font("Segoe UI Semibold", 10F);
            lblEditControls.Location = new Point(20, 10);
            lblEditControls.Name = "lblEditControls";
            lblEditControls.Size = new Size(250, 25);
            lblEditControls.TabIndex = 0;
            lblEditControls.Text = "Edit / Manage Reservation";
            // 
            // resEditButton
            // 
            resEditButton.Location = new Point(20, 45);
            resEditButton.Name = "resEditButton";
            resEditButton.Size = new Size(360, 28);
            resEditButton.TabIndex = 1;
            resEditButton.Text = "Search to Edit";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(20, 260);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(360, 40);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(20, 310);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(360, 40);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(20, 370);
            editButton.Name = "editButton";
            editButton.Size = new Size(360, 40);
            editButton.TabIndex = 4;
            editButton.Text = "Edit Existing";
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.Location = new Point(20, 420);
            newButton.Name = "newButton";
            newButton.Size = new Size(360, 40);
            newButton.TabIndex = 5;
            newButton.Text = "New Reservation";
            newButton.Click += newButton_Click;
            // 
            // tpSearch
            // 
            tpSearch.BackColor = Color.White;
            tpSearch.Controls.Add(searchButton);
            tpSearch.Controls.Add(dgvSearch);
            tpSearch.Controls.Add(searchTextBox);
            tpSearch.Location = new Point(4, 43);
            tpSearch.Name = "tpSearch";
            tpSearch.Size = new Size(1322, 558);
            tpSearch.TabIndex = 1;
            tpSearch.Text = "Universal Search";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1150, 20);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(140, 35);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.Click += searchButton_Click;
            // 
            // dgvSearch
            // 
            dgvSearch.BackgroundColor = Color.White;
            dgvSearch.BorderStyle = BorderStyle.Fixed3D;
            dgvSearch.ColumnHeadersHeight = 29;
            dgvSearch.Location = new Point(20, 70);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.RowHeadersWidth = 51;
            dgvSearch.Size = new Size(1270, 450);
            dgvSearch.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(20, 20);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Enter Name, Phone, or ID to search...";
            searchTextBox.Size = new Size(1120, 27);
            searchTextBox.TabIndex = 0;
            // 
            // tpAdvView
            // 
            tpAdvView.BackColor = Color.White;
            tpAdvView.Controls.Add(dgvTotal);
            tpAdvView.Location = new Point(4, 43);
            tpAdvView.Name = "tpAdvView";
            tpAdvView.Size = new Size(1322, 558);
            tpAdvView.TabIndex = 2;
            tpAdvView.Text = "Reservation Adv. View";
            // 
            // dgvTotal
            // 
            dgvTotal.BackgroundColor = Color.White;
            dgvTotal.ColumnHeadersHeight = 29;
            dgvTotal.Dock = DockStyle.Fill;
            dgvTotal.Location = new Point(0, 0);
            dgvTotal.Name = "dgvTotal";
            dgvTotal.RowHeadersWidth = 51;
            dgvTotal.Size = new Size(1322, 558);
            dgvTotal.TabIndex = 0;
            // 
            // tpRoomAvail
            // 
            tpRoomAvail.BackColor = Color.White;
            tpRoomAvail.Controls.Add(lblOccupiedHeader);
            tpRoomAvail.Controls.Add(lblReservedHeader);
            tpRoomAvail.Controls.Add(lstOccupied);
            tpRoomAvail.Controls.Add(lstReserved);
            tpRoomAvail.Location = new Point(4, 43);
            tpRoomAvail.Name = "tpRoomAvail";
            tpRoomAvail.Size = new Size(1322, 558);
            tpRoomAvail.TabIndex = 3;
            tpRoomAvail.Text = "Room Availability";
            // 
            // lblOccupiedHeader
            // 
            lblOccupiedHeader.Font = new Font("Segoe UI Semibold", 10F);
            lblOccupiedHeader.Location = new Point(20, 20);
            lblOccupiedHeader.Name = "lblOccupiedHeader";
            lblOccupiedHeader.Size = new Size(300, 25);
            lblOccupiedHeader.TabIndex = 0;
            lblOccupiedHeader.Text = "Occupied Rooms (Checked-in)";
            // 
            // lblReservedHeader
            // 
            lblReservedHeader.Font = new Font("Segoe UI Semibold", 10F);
            lblReservedHeader.Location = new Point(660, 20);
            lblReservedHeader.Name = "lblReservedHeader";
            lblReservedHeader.Size = new Size(300, 25);
            lblReservedHeader.TabIndex = 1;
            lblReservedHeader.Text = "Reserved Rooms (Future)";
            // 
            // lstOccupied
            // 
            lstOccupied.BackColor = Color.FromArgb(245, 245, 245);
            lstOccupied.Location = new Point(20, 50);
            lstOccupied.Name = "lstOccupied";
            lstOccupied.SelectionMode = SelectionMode.None;
            lstOccupied.Size = new Size(620, 444);
            lstOccupied.TabIndex = 2;
            // 
            // lstReserved
            // 
            lstReserved.BackColor = Color.FromArgb(245, 245, 245);
            lstReserved.Location = new Point(660, 50);
            lstReserved.Name = "lstReserved";
            lstReserved.SelectionMode = SelectionMode.None;
            lstReserved.Size = new Size(620, 444);
            lstReserved.TabIndex = 3;
            // 
            // Frontend
            // 
            ClientSize = new Size(1330, 650);
            Controls.Add(tabMain);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frontend";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frontend_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tabMain.ResumeLayout(false);
            tpReservation.ResumeLayout(false);
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            middlePanel.ResumeLayout(false);
            rightMPanel.ResumeLayout(false);
            tpSearch.ResumeLayout(false);
            tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            tpAdvView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTotal).EndInit();
            tpRoomAvail.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Cursor = Cursors.Hand;
        }

        #endregion

        private Panel pnlTop;
        private Button btnClose;
        private Label lblHeader;
        private TabControl tabMain;
        private TabPage tpReservation, tpSearch, tpAdvView, tpRoomAvail;
        private Panel leftMPanel, middlePanel, rightMPanel;
        private Label lblPersonalInfo, lblResInfo, lblEditControls, lblOccupiedHeader, lblReservedHeader;
        private TextBox firstNameTextBox, lastNameTextBox, phoneNumberTextBox, emailTextBox, yearTextBox, cityTextBox, aptTextBox, addLabel, zipComboBox, searchTextBox;
        private ComboBox dayComboBox, monthComboBox, genderComboBox, stateComboBox, roomTypeComboBox, floorComboBox, roomNComboBox, qtGuestComboBox, resEditButton;
        private DateTimePicker entryDatePicker, depDatePicker;
        private Button submitButton, updateButton, editButton, finalizeButton, newButton, foodMenuButton, deleteButton, searchButton;
        private CheckBox checkinCheckBox, foodSupplyCheckBox, smsCheckBox;
        private DataGridView dgvSearch, dgvTotal;
        private ListBox lstOccupied, lstReserved;
    }
}