using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FinalizePayment : Form
    {
        public FinalizePayment()
        {
            InitializeComponent();
            btnClose.Click += (s, e) => this.Close();
            btnFinish.Click += btnFinish_Click;
            cardNumTextBox.Leave += cardNumTextBox_Leave;
            this.Load += FinalizePayment_Load;
        }

        public double ReservationPrice;
        public int FoodBill;
        public double FinalTotal { get; private set; }

        public string PaymentType => paymentComboBox.SelectedItem?.ToString();
        public string CardType => cardTypeComboBox.SelectedItem?.ToString();
        public string CardNumber => cardNumTextBox.Text;
        public string CardExp => $"{monthComboBox.SelectedItem}/{yearComboBox.SelectedItem}";
        public string CardCvc => cvcTextBox.Text;

        private void FinalizePayment_Load(object sender, EventArgs e)
        {
            double tax = ReservationPrice * 0.07;
            FinalTotal = ReservationPrice + tax + FoodBill;

            lblTotal.Text = $"Reservation: ${ReservationPrice:F2}";
            lblFood.Text = $"Food Bill: ${FoodBill:F2}";
            lblFinalTotal.Text = $"Total: ${FinalTotal:F2}";

            InitializePaymentOptions();
        }

         

        private void InitializePaymentOptions()
        {
            paymentComboBox.Items.Clear();
            paymentComboBox.Items.AddRange(new object[] { "Credit Card", "Debit Card", "Cash" });

            cardTypeComboBox.Items.Clear();
            cardTypeComboBox.Items.AddRange(new object[] { "Visa", "MasterCard", "Amex", "Discover" });

            monthComboBox.Items.Clear();
            for (int i = 1; i <= 12; i++) monthComboBox.Items.Add(i.ToString("D2"));

            yearComboBox.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int i = 0; i <= 10; i++) yearComboBox.Items.Add((currentYear + i).ToString());
        }

        private void cardNumTextBox_Leave(object sender, EventArgs e)
        {
            if (cardNumTextBox.Text.Length > 0)
            {
                char firstDigit = cardNumTextBox.Text[0];
                switch (firstDigit)
                {
                    case '3': cardTypeComboBox.SelectedItem = "Amex"; break;
                    case '4': cardTypeComboBox.SelectedItem = "Visa"; break;
                    case '5': cardTypeComboBox.SelectedItem = "MasterCard"; break;
                    case '6': cardTypeComboBox.SelectedItem = "Discover"; break;
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}