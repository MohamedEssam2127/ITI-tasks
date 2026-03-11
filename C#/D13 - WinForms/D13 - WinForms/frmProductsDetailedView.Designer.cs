namespace D13___WinForms
{
    partial class frmProductsDetailedView
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

        private void InitializeComponent()
        {
            numJobLevel = new NumericUpDown();
            txtFirstName = new TextBox();
            btnPrev = new Button();
            btnNext = new Button();
            lblIdTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblJobLevel = new Label();
            lblJobId = new Label();
            txtLastName = new TextBox();
            cmbJobId = new ComboBox();
            cmbPubId = new ComboBox();
            dtpHireDate = new DateTimePicker();
            lblPubId = new Label();
            lblHireDate = new Label();
            IdValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numJobLevel).BeginInit();
            SuspendLayout();
            // 
            // numJobLevel
            // 
            numJobLevel.Location = new Point(242, 194);
            numJobLevel.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numJobLevel.Name = "numJobLevel";
            numJobLevel.Size = new Size(158, 27);
            numJobLevel.TabIndex = 14;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(242, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(158, 27);
            txtFirstName.TabIndex = 13;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(196, 388);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(50, 29);
            btnPrev.TabIndex = 12;
            btnPrev.Text = "<";
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(347, 388);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(53, 29);
            btnNext.TabIndex = 11;
            btnNext.Text = ">";
            btnNext.Click += btnNext_Click;
            // 
            // lblIdTitle
            // 
            lblIdTitle.AutoSize = true;
            lblIdTitle.Location = new Point(125, 47);
            lblIdTitle.Name = "lblIdTitle";
            lblIdTitle.Size = new Size(97, 20);
            lblIdTitle.TabIndex = 10;
            lblIdTitle.Text = "Employee ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(125, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 9;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(125, 126);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last Name:";
            // 
            // lblJobLevel
            // 
            lblJobLevel.AutoSize = true;
            lblJobLevel.Location = new Point(125, 196);
            lblJobLevel.Name = "lblJobLevel";
            lblJobLevel.Size = new Size(73, 20);
            lblJobLevel.TabIndex = 7;
            lblJobLevel.Text = "Job Level:";
            // 
            // lblJobId
            // 
            lblJobId.AutoSize = true;
            lblJobId.Location = new Point(125, 243);
            lblJobId.Name = "lblJobId";
            lblJobId.Size = new Size(54, 20);
            lblJobId.TabIndex = 6;
            lblJobId.Text = "Job ID:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(242, 123);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(158, 27);
            txtLastName.TabIndex = 5;
            // 
            // cmbJobId
            // 
            cmbJobId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJobId.Location = new Point(242, 240);
            cmbJobId.Name = "cmbJobId";
            cmbJobId.Size = new Size(158, 28);
            cmbJobId.TabIndex = 4;
            // 
            // cmbPubId
            // 
            cmbPubId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPubId.Location = new Point(242, 286);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(158, 28);
            cmbPubId.TabIndex = 3;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Format = DateTimePickerFormat.Short;
            dtpHireDate.Location = new Point(242, 331);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(158, 27);
            dtpHireDate.TabIndex = 2;
            // 
            // lblPubId
            // 
            lblPubId.AutoSize = true;
            lblPubId.Location = new Point(125, 289);
            lblPubId.Name = "lblPubId";
            lblPubId.Size = new Size(91, 20);
            lblPubId.TabIndex = 1;
            lblPubId.Text = "Publisher ID:";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(125, 336);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(76, 20);
            lblHireDate.TabIndex = 0;
            lblHireDate.Text = "Hire Date:";
            // 
            // IdValue
            // 
            IdValue.Location = new Point(242, 44);
            IdValue.Name = "IdValue";
            IdValue.Size = new Size(158, 27);
            IdValue.TabIndex = 16;
            // 
            // frmProductsDetailedView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 480);
            Controls.Add(IdValue);
            Controls.Add(lblHireDate);
            Controls.Add(lblPubId);
            Controls.Add(dtpHireDate);
            Controls.Add(cmbPubId);
            Controls.Add(cmbJobId);
            Controls.Add(txtLastName);
            Controls.Add(lblJobId);
            Controls.Add(lblJobLevel);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblIdTitle);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(txtFirstName);
            Controls.Add(numJobLevel);
            Name = "frmProductsDetailedView";
            Text = "Employee Details Manager";
            ((System.ComponentModel.ISupportInitialize)numJobLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblIdTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblJobLevel;
        private Label lblJobId;
        private Label lblPubId;
        private Label lblHireDate;
        private NumericUpDown numJobLevel;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnPrev;
        private Button btnNext;
        private ComboBox cmbJobId;
        private ComboBox cmbPubId;
        private DateTimePicker dtpHireDate;
        private TextBox IdValue;
    }
}