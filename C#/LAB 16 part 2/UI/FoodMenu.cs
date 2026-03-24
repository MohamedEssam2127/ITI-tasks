using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
            btnClose.Click += (s, e) => this.Close();
            nextButton.Click += nextButton_Click;
            AttachToggleEvents();
        }

        public int Bfast, Lunch, Dinner;
        public bool Cleaning, Towel, Surprise;

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            breakfastQTY.Text = Bfast.ToString();
            lunchQTY.Text = Lunch.ToString();
            dinnerQTY.Text = Dinner.ToString();

            cleaningCheckBox.Checked = Cleaning;
            towelsCheckBox.Checked = Towel;
            surpriseCheckBox.Checked = Surprise;

            breakfastCheckBox.Checked = Bfast > 0;
            lunchCheckBox.Checked = Lunch > 0;
            dinnerCheckBox.Checked = Dinner > 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int.TryParse(breakfastQTY.Text, out Bfast);
            int.TryParse(lunchQTY.Text, out Lunch);
            int.TryParse(dinnerQTY.Text, out Dinner);

            Cleaning = cleaningCheckBox.Checked;
            Towel = towelsCheckBox.Checked;
            Surprise = surpriseCheckBox.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void AttachToggleEvents()
        {
            breakfastCheckBox.CheckedChanged += (s, e) =>
            {
                breakfastQTY.Enabled = breakfastCheckBox.Checked;
                if (!breakfastCheckBox.Checked) breakfastQTY.Text = "0";
            };

            lunchCheckBox.CheckedChanged += (s, e) =>
            {
                lunchQTY.Enabled = lunchCheckBox.Checked;
                if (!lunchCheckBox.Checked) lunchQTY.Text = "0";
            };

            dinnerCheckBox.CheckedChanged += (s, e) =>
            {
                dinnerQTY.Enabled = dinnerCheckBox.Checked;
                if (!dinnerCheckBox.Checked) dinnerQTY.Text = "0";
            };
        }

        
    }
}