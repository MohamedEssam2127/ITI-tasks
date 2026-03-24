namespace UI
{
    partial class FinalizePayment
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
            pnlBillDetails = new Panel();
            lblFinalTotal = new Label();
            lblFood = new Label();
            lblTotal = new Label();
            lblBillHeader = new Label();
            pnlPayment = new Panel();
            cvcTextBox = new TextBox();
            yearComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            cardNumTextBox = new TextBox();
            cardTypeComboBox = new ComboBox();
            paymentComboBox = new ComboBox();
            lblPaymentHeader = new Label();
            btnFinish = new Button();
            pnlTop.SuspendLayout();
            pnlBillDetails.SuspendLayout();
            pnlPayment.SuspendLayout();
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
            pnlTop.Size = new Size(534, 40);
            pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(489, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 12F);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(116, 28);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Finalize Bill";
            // 
            // pnlBillDetails
            // 
            pnlBillDetails.BackColor = Color.White;
            pnlBillDetails.Controls.Add(lblFinalTotal);
            pnlBillDetails.Controls.Add(lblFood);
            pnlBillDetails.Controls.Add(lblTotal);
            pnlBillDetails.Controls.Add(lblBillHeader);
            pnlBillDetails.Location = new Point(14, 55);
            pnlBillDetails.Name = "pnlBillDetails";
            pnlBillDetails.Size = new Size(250, 326);
            pnlBillDetails.TabIndex = 1;
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinalTotal.ForeColor = Color.Black;
            lblFinalTotal.Location = new Point(10, 150);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(198, 28);
            lblFinalTotal.TabIndex = 0;
            lblFinalTotal.Text = "Total: $0.00";
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Segoe UI", 10F);
            lblFood.Location = new Point(10, 90);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(125, 23);
            lblFood.TabIndex = 0;
            lblFood.Text = "Food Bill: $0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.Location = new Point(10, 55);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(149, 23);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Reservation: $0.00";
            // 
            // lblBillHeader
            // 
            lblBillHeader.AutoSize = true;
            lblBillHeader.Font = new Font("Segoe UI Semibold", 10F);
            lblBillHeader.ForeColor = Color.FromArgb(52, 152, 219);
            lblBillHeader.Location = new Point(3, 10);
            lblBillHeader.Name = "lblBillHeader";
            lblBillHeader.Size = new Size(109, 23);
            lblBillHeader.TabIndex = 0;
            lblBillHeader.Text = "BILL DETAILS";
            // 
            // pnlPayment
            // 
            pnlPayment.BackColor = Color.White;
            pnlPayment.Controls.Add(cvcTextBox);
            pnlPayment.Controls.Add(yearComboBox);
            pnlPayment.Controls.Add(monthComboBox);
            pnlPayment.Controls.Add(cardNumTextBox);
            pnlPayment.Controls.Add(cardTypeComboBox);
            pnlPayment.Controls.Add(paymentComboBox);
            pnlPayment.Controls.Add(lblPaymentHeader);
            pnlPayment.Location = new Point(275, 55);
            pnlPayment.Name = "pnlPayment";
            pnlPayment.Size = new Size(244, 326);
            pnlPayment.TabIndex = 2;
            // 
            // cvcTextBox
            // 
            cvcTextBox.Location = new Point(160, 210);
            cvcTextBox.Name = "cvcTextBox";
            cvcTextBox.PlaceholderText = "CVC";
            cvcTextBox.Size = new Size(68, 27);
            cvcTextBox.TabIndex = 5;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(85, 210);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(65, 28);
            yearComboBox.TabIndex = 4;
            yearComboBox.Text = "YY";
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(14, 210);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(65, 28);
            monthComboBox.TabIndex = 3;
            monthComboBox.Text = "MM";
            // 
            // cardNumTextBox
            // 
            cardNumTextBox.Location = new Point(14, 160);
            cardNumTextBox.Name = "cardNumTextBox";
            cardNumTextBox.PlaceholderText = "Card Number";
            cardNumTextBox.Size = new Size(214, 27);
            cardNumTextBox.TabIndex = 2;
            // 
            // cardTypeComboBox
            // 
            cardTypeComboBox.FormattingEnabled = true;
            cardTypeComboBox.Location = new Point(14, 110);
            cardTypeComboBox.Name = "cardTypeComboBox";
            cardTypeComboBox.Size = new Size(214, 28);
            cardTypeComboBox.TabIndex = 1;
            cardTypeComboBox.Text = "Card Type";
            // 
            // paymentComboBox
            // 
            paymentComboBox.FormattingEnabled = true;
            paymentComboBox.Location = new Point(14, 60);
            paymentComboBox.Name = "paymentComboBox";
            paymentComboBox.Size = new Size(214, 28);
            paymentComboBox.TabIndex = 0;
            paymentComboBox.Text = "Payment Method";
            // 
            // lblPaymentHeader
            // 
            lblPaymentHeader.AutoSize = true;
            lblPaymentHeader.Font = new Font("Segoe UI Semibold", 10F);
            lblPaymentHeader.ForeColor = Color.FromArgb(52, 152, 219);
            lblPaymentHeader.Location = new Point(3, 10);
            lblPaymentHeader.Name = "lblPaymentHeader";
            lblPaymentHeader.Size = new Size(134, 23);
            lblPaymentHeader.TabIndex = 0;
            lblPaymentHeader.Text = "PAYMENT INFO";
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.FromArgb(44, 62, 80);
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Segoe UI Semibold", 10F);
            btnFinish.ForeColor = Color.White;
            btnFinish.Location = new Point(275, 388);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(244, 42);
            btnFinish.TabIndex = 3;
            btnFinish.Text = "FINISH && SAVE";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // FinalizePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 442);
            Controls.Add(btnFinish);
            Controls.Add(pnlPayment);
            Controls.Add(pnlBillDetails);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FinalizePayment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FinalizePayment";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBillDetails.ResumeLayout(false);
            pnlBillDetails.PerformLayout();
            pnlPayment.ResumeLayout(false);
            pnlPayment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnClose;
        private Label lblHeader;
        private Panel pnlBillDetails;
        private Label lblBillHeader;
        private Label lblTotal;
        private Label lblFood;
        private Label lblFinalTotal;
        private Panel pnlPayment;
        private Label lblPaymentHeader;
        public ComboBox paymentComboBox;
        public ComboBox cardTypeComboBox;
        public TextBox cardNumTextBox;
        public ComboBox monthComboBox;
        public ComboBox yearComboBox;
        public TextBox cvcTextBox;
        private Button btnFinish;
    }
}