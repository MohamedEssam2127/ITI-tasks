namespace UI
{
    partial class Kitchen
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
            btnLogout = new Button();
            btnClose = new Button();
            lblHeader = new Label();
            tabKitchen = new TabControl();
            tpTodo = new TabPage();
            btnUpdate = new Button();
            lblQueue = new Label();
            lstQueue = new ListBox();
            grpServices = new GroupBox();
            lblBfast = new Label();
            txtBfast = new TextBox();
            lblLunch = new Label();
            txtLunch = new TextBox();
            lblDinner = new Label();
            txtDinner = new TextBox();
            chkCleaning = new CheckBox();
            chkTowel = new CheckBox();
            chkSurprise = new CheckBox();
            chkSupplyStatus = new CheckBox();
            btnFoodSelect = new Button();
            grpGuestInfo = new GroupBox();
            lblFirst = new Label();
            txtFirst = new TextBox();
            lblLast = new Label();
            txtLast = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblRoomType = new Label();
            txtRoomType = new TextBox();
            lblFloor = new Label();
            txtFloor = new TextBox();
            lblRoomNum = new Label();
            txtRoomNum = new TextBox();
            tpOverview = new TabPage();
            dgvOverview = new DataGridView();
            pnlTop.SuspendLayout();
            tabKitchen.SuspendLayout();
            tpTodo.SuspendLayout();
            grpServices.SuspendLayout();
            grpGuestInfo.SuspendLayout();
            tpOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(52, 152, 219);
            pnlTop.Controls.Add(btnLogout);
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(lblHeader);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1000, 40);
            pnlTop.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Brown;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(882, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(73, 40);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(955, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 12F);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(307, 28);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Room Service - Kitchen Terminal";
            // 
            // tabKitchen
            // 
            tabKitchen.Controls.Add(tpTodo);
            tabKitchen.Controls.Add(tpOverview);
            tabKitchen.Dock = DockStyle.Fill;
            tabKitchen.Font = new Font("Segoe UI", 10F);
            tabKitchen.Location = new Point(0, 40);
            tabKitchen.Name = "tabKitchen";
            tabKitchen.Padding = new Point(20, 10);
            tabKitchen.SelectedIndex = 0;
            tabKitchen.Size = new Size(1000, 510);
            tabKitchen.TabIndex = 0;
            // 
            // tpTodo
            // 
            tpTodo.BackColor = Color.White;
            tpTodo.Controls.Add(btnUpdate);
            tpTodo.Controls.Add(lblQueue);
            tpTodo.Controls.Add(lstQueue);
            tpTodo.Controls.Add(grpServices);
            tpTodo.Controls.Add(grpGuestInfo);
            tpTodo.Location = new Point(4, 46);
            tpTodo.Name = "tpTodo";
            tpTodo.Size = new Size(992, 460);
            tpTodo.TabIndex = 0;
            tpTodo.Text = "Current Orders";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(44, 62, 80);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(730, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(230, 50);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "UPDATE CHANGES";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblQueue
            // 
            lblQueue.Location = new Point(730, 25);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(100, 23);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "On the Line (Queue)";
            // 
            // lstQueue
            // 
            lstQueue.Location = new Point(730, 50);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(230, 280);
            lstQueue.TabIndex = 2;
            // 
            // grpServices
            // 
            grpServices.Controls.Add(lblBfast);
            grpServices.Controls.Add(txtBfast);
            grpServices.Controls.Add(lblLunch);
            grpServices.Controls.Add(txtLunch);
            grpServices.Controls.Add(lblDinner);
            grpServices.Controls.Add(txtDinner);
            grpServices.Controls.Add(chkCleaning);
            grpServices.Controls.Add(chkTowel);
            grpServices.Controls.Add(chkSurprise);
            grpServices.Controls.Add(chkSupplyStatus);
            grpServices.Controls.Add(btnFoodSelect);
            grpServices.Location = new Point(390, 20);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(320, 320);
            grpServices.TabIndex = 3;
            grpServices.TabStop = false;
            grpServices.Text = "Service & Food Todo";
            // 
            // lblBfast
            // 
            lblBfast.Location = new Point(20, 30);
            lblBfast.Name = "lblBfast";
            lblBfast.Size = new Size(100, 23);
            lblBfast.TabIndex = 0;
            lblBfast.Text = "B-Fast Qty";
            // 
            // txtBfast
            // 
            txtBfast.Location = new Point(20, 55);
            txtBfast.Name = "txtBfast";
            txtBfast.ReadOnly = true;
            txtBfast.Size = new Size(80, 30);
            txtBfast.TabIndex = 1;
            // 
            // lblLunch
            // 
            lblLunch.Location = new Point(120, 30);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(100, 23);
            lblLunch.TabIndex = 2;
            lblLunch.Text = "Lunch Qty";
            // 
            // txtLunch
            // 
            txtLunch.Location = new Point(120, 55);
            txtLunch.Name = "txtLunch";
            txtLunch.ReadOnly = true;
            txtLunch.Size = new Size(80, 30);
            txtLunch.TabIndex = 3;
            // 
            // lblDinner
            // 
            lblDinner.Location = new Point(220, 30);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(100, 23);
            lblDinner.TabIndex = 4;
            lblDinner.Text = "Dinner Qty";
            // 
            // txtDinner
            // 
            txtDinner.Location = new Point(220, 55);
            txtDinner.Name = "txtDinner";
            txtDinner.ReadOnly = true;
            txtDinner.Size = new Size(80, 30);
            txtDinner.TabIndex = 5;
            // 
            // chkCleaning
            // 
            chkCleaning.Enabled = false;
            chkCleaning.Location = new Point(20, 100);
            chkCleaning.Name = "chkCleaning";
            chkCleaning.Size = new Size(104, 24);
            chkCleaning.TabIndex = 6;
            chkCleaning.Text = "Cleaning";
            // 
            // chkTowel
            // 
            chkTowel.Enabled = false;
            chkTowel.Location = new Point(120, 100);
            chkTowel.Name = "chkTowel";
            chkTowel.Size = new Size(104, 24);
            chkTowel.TabIndex = 7;
            chkTowel.Text = "Towels";
            // 
            // chkSurprise
            // 
            chkSurprise.Enabled = false;
            chkSurprise.Location = new Point(220, 100);
            chkSurprise.Name = "chkSurprise";
            chkSurprise.Size = new Size(104, 24);
            chkSurprise.TabIndex = 8;
            chkSurprise.Text = "Surprise";
            // 
            // chkSupplyStatus
            // 
            chkSupplyStatus.ForeColor = Color.FromArgb(52, 152, 219);
            chkSupplyStatus.Location = new Point(20, 150);
            chkSupplyStatus.Name = "chkSupplyStatus";
            chkSupplyStatus.Size = new Size(250, 25);
            chkSupplyStatus.TabIndex = 9;
            chkSupplyStatus.Text = "Is Food/Supply Delivered?";
            chkSupplyStatus.CheckedChanged += chkSupplyStatus_CheckedChanged;
            // 
            // btnFoodSelect
            // 
            btnFoodSelect.BackColor = Color.FromArgb(52, 152, 219);
            btnFoodSelect.FlatStyle = FlatStyle.Flat;
            btnFoodSelect.ForeColor = Color.White;
            btnFoodSelect.Location = new Point(20, 250);
            btnFoodSelect.Name = "btnFoodSelect";
            btnFoodSelect.Size = new Size(280, 40);
            btnFoodSelect.TabIndex = 10;
            btnFoodSelect.Text = "Change Food Selection";
            btnFoodSelect.UseVisualStyleBackColor = false;
            btnFoodSelect.Click += btnFoodSelect_Click;
            // 
            // grpGuestInfo
            // 
            grpGuestInfo.Controls.Add(lblFirst);
            grpGuestInfo.Controls.Add(txtFirst);
            grpGuestInfo.Controls.Add(lblLast);
            grpGuestInfo.Controls.Add(txtLast);
            grpGuestInfo.Controls.Add(lblPhone);
            grpGuestInfo.Controls.Add(txtPhone);
            grpGuestInfo.Controls.Add(lblRoomType);
            grpGuestInfo.Controls.Add(txtRoomType);
            grpGuestInfo.Controls.Add(lblFloor);
            grpGuestInfo.Controls.Add(txtFloor);
            grpGuestInfo.Controls.Add(lblRoomNum);
            grpGuestInfo.Controls.Add(txtRoomNum);
            grpGuestInfo.Location = new Point(20, 20);
            grpGuestInfo.Name = "grpGuestInfo";
            grpGuestInfo.Size = new Size(350, 320);
            grpGuestInfo.TabIndex = 4;
            grpGuestInfo.TabStop = false;
            grpGuestInfo.Text = "Guest Details";
            // 
            // lblFirst
            // 
            lblFirst.Location = new Point(15, 30);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(100, 23);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(15, 55);
            txtFirst.Name = "txtFirst";
            txtFirst.ReadOnly = true;
            txtFirst.Size = new Size(150, 30);
            txtFirst.TabIndex = 1;
            // 
            // lblLast
            // 
            lblLast.Location = new Point(180, 30);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(100, 23);
            lblLast.TabIndex = 2;
            lblLast.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(180, 55);
            txtLast.Name = "txtLast";
            txtLast.ReadOnly = true;
            txtLast.Size = new Size(150, 30);
            txtLast.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(15, 95);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(15, 120);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(315, 30);
            txtPhone.TabIndex = 5;
            // 
            // lblRoomType
            // 
            lblRoomType.Location = new Point(15, 160);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(100, 23);
            lblRoomType.TabIndex = 6;
            lblRoomType.Text = "Room Type";
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(15, 185);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ReadOnly = true;
            txtRoomType.Size = new Size(150, 30);
            txtRoomType.TabIndex = 7;
            // 
            // lblFloor
            // 
            lblFloor.Location = new Point(180, 160);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(100, 23);
            lblFloor.TabIndex = 8;
            lblFloor.Text = "Floor #";
            // 
            // txtFloor
            // 
            txtFloor.Location = new Point(180, 185);
            txtFloor.Name = "txtFloor";
            txtFloor.ReadOnly = true;
            txtFloor.Size = new Size(150, 30);
            txtFloor.TabIndex = 9;
            // 
            // lblRoomNum
            // 
            lblRoomNum.Location = new Point(15, 230);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(100, 23);
            lblRoomNum.TabIndex = 10;
            lblRoomNum.Text = "Room #";
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(15, 255);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.ReadOnly = true;
            txtRoomNum.Size = new Size(315, 30);
            txtRoomNum.TabIndex = 11;
            // 
            // tpOverview
            // 
            tpOverview.BackColor = Color.White;
            tpOverview.Controls.Add(dgvOverview);
            tpOverview.Location = new Point(4, 46);
            tpOverview.Name = "tpOverview";
            tpOverview.Size = new Size(992, 460);
            tpOverview.TabIndex = 1;
            tpOverview.Text = "All Active Orders";
            // 
            // dgvOverview
            // 
            dgvOverview.BackgroundColor = Color.White;
            dgvOverview.BorderStyle = BorderStyle.None;
            dgvOverview.ColumnHeadersHeight = 29;
            dgvOverview.Dock = DockStyle.Fill;
            dgvOverview.Location = new Point(0, 0);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.RowHeadersWidth = 51;
            dgvOverview.Size = new Size(992, 460);
            dgvOverview.TabIndex = 0;
            // 
            // Kitchen
            // 
            ClientSize = new Size(1000, 550);
            Controls.Add(tabKitchen);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kitchen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitchen Management";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tabKitchen.ResumeLayout(false);
            tpTodo.ResumeLayout(false);
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            grpGuestInfo.ResumeLayout(false);
            grpGuestInfo.PerformLayout();
            tpOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnClose;
        private Button btnLogout;
        private Label lblHeader;
        private TabControl tabKitchen;
        private TabPage tpTodo;
        private TabPage tpOverview;
        private GroupBox grpGuestInfo;
        private GroupBox grpServices;
        private ListBox lstQueue;
        private Label lblQueue;
        private Button btnUpdate;
        private Button btnFoodSelect;
        private DataGridView dgvOverview;

        private Label lblFirst, lblLast, lblPhone, lblRoomType, lblFloor, lblRoomNum;
        private Label lblBfast, lblLunch, lblDinner;
        private TextBox txtFirst, txtLast, txtPhone, txtRoomType, txtFloor, txtRoomNum;
        private TextBox txtBfast, txtLunch, txtDinner;
        private CheckBox chkCleaning, chkTowel, chkSurprise, chkSupplyStatus;
    }
}