namespace UI
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            pnlTop = new Panel();
            btnClose = new Button();
            lblHeader = new Label();
            foodPanel = new Panel();
            dinnerQTY = new TextBox();
            lunchQTY = new TextBox();
            breakfastQTY = new TextBox();
            dinnerPicture = new PictureBox();
            lunchPicture = new PictureBox();
            breakfastPicture = new PictureBox();
            dinnerCheckBox = new CheckBox();
            lunchCheckBox = new CheckBox();
            breakfastCheckBox = new CheckBox();
            lblFoodSelection = new Label();
            needPanel = new Panel();
            surpriseCheckBox = new CheckBox();
            towelsCheckBox = new CheckBox();
            cleaningCheckBox = new CheckBox();
            lblSpecialNeeds = new Label();
            nextButton = new Button();
            pnlTop.SuspendLayout();
            foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).BeginInit();
            needPanel.SuspendLayout();
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
            pnlTop.TabIndex = 7;
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
            btnClose.TabIndex = 2;
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
            lblHeader.Size = new Size(154, 28);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Menu Selection";
            // 
            // foodPanel
            // 
            foodPanel.BackColor = Color.White;
            foodPanel.Controls.Add(dinnerQTY);
            foodPanel.Controls.Add(lunchQTY);
            foodPanel.Controls.Add(breakfastQTY);
            foodPanel.Controls.Add(dinnerPicture);
            foodPanel.Controls.Add(lunchPicture);
            foodPanel.Controls.Add(breakfastPicture);
            foodPanel.Controls.Add(dinnerCheckBox);
            foodPanel.Controls.Add(lunchCheckBox);
            foodPanel.Controls.Add(breakfastCheckBox);
            foodPanel.Controls.Add(lblFoodSelection);
            foodPanel.Location = new Point(14, 55);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(332, 367);
            foodPanel.TabIndex = 10;
            // 
            // dinnerQTY
            // 
            dinnerQTY.Enabled = false;
            dinnerQTY.Location = new Point(14, 327);
            dinnerQTY.Name = "dinnerQTY";
            dinnerQTY.Size = new Size(129, 27);
            dinnerQTY.TabIndex = 0;
            dinnerQTY.Text = "0";
            // 
            // lunchQTY
            // 
            lunchQTY.Enabled = false;
            lunchQTY.Location = new Point(172, 181);
            lunchQTY.Name = "lunchQTY";
            lunchQTY.Size = new Size(144, 27);
            lunchQTY.TabIndex = 1;
            lunchQTY.Text = "0";
            // 
            // breakfastQTY
            // 
            breakfastQTY.Enabled = false;
            breakfastQTY.Location = new Point(14, 181);
            breakfastQTY.Name = "breakfastQTY";
            breakfastQTY.Size = new Size(129, 27);
            breakfastQTY.TabIndex = 2;
            breakfastQTY.Text = "0";
            // 
            // dinnerPicture
            // 
            dinnerPicture.BorderStyle = BorderStyle.FixedSingle;
            dinnerPicture.Image = (Image)resources.GetObject("dinnerPicture.Image");
            dinnerPicture.Location = new Point(14, 226);
            dinnerPicture.Name = "dinnerPicture";
            dinnerPicture.Size = new Size(129, 75);
            dinnerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            dinnerPicture.TabIndex = 3;
            dinnerPicture.TabStop = false;
            // 
            // lunchPicture
            // 
            lunchPicture.BorderStyle = BorderStyle.FixedSingle;
            lunchPicture.Image = (Image)resources.GetObject("lunchPicture.Image");
            lunchPicture.Location = new Point(172, 55);
            lunchPicture.Name = "lunchPicture";
            lunchPicture.Size = new Size(144, 92);
            lunchPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lunchPicture.TabIndex = 4;
            lunchPicture.TabStop = false;
            // 
            // breakfastPicture
            // 
            breakfastPicture.BorderStyle = BorderStyle.FixedSingle;
            breakfastPicture.Image = (Image)resources.GetObject("breakfastPicture.Image");
            breakfastPicture.Location = new Point(14, 55);
            breakfastPicture.Name = "breakfastPicture";
            breakfastPicture.Size = new Size(129, 92);
            breakfastPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            breakfastPicture.TabIndex = 5;
            breakfastPicture.TabStop = false;
            // 
            // dinnerCheckBox
            // 
            dinnerCheckBox.AutoSize = true;
            dinnerCheckBox.Location = new Point(14, 307);
            dinnerCheckBox.Name = "dinnerCheckBox";
            dinnerCheckBox.Size = new Size(113, 24);
            dinnerCheckBox.TabIndex = 6;
            dinnerCheckBox.Text = "Dinner ($15)";
            // 
            // lunchCheckBox
            // 
            lunchCheckBox.AutoSize = true;
            lunchCheckBox.Location = new Point(172, 156);
            lunchCheckBox.Name = "lunchCheckBox";
            lunchCheckBox.Size = new Size(107, 24);
            lunchCheckBox.TabIndex = 7;
            lunchCheckBox.Text = "Lunch ($15)";
            // 
            // breakfastCheckBox
            // 
            breakfastCheckBox.AutoSize = true;
            breakfastCheckBox.Location = new Point(14, 156);
            breakfastCheckBox.Name = "breakfastCheckBox";
            breakfastCheckBox.Size = new Size(127, 24);
            breakfastCheckBox.TabIndex = 8;
            breakfastCheckBox.Text = "Break Fast ($7)";
            // 
            // lblFoodSelection
            // 
            lblFoodSelection.AutoSize = true;
            lblFoodSelection.Font = new Font("Segoe UI Semibold", 10F);
            lblFoodSelection.ForeColor = Color.FromArgb(52, 152, 219);
            lblFoodSelection.Location = new Point(3, 10);
            lblFoodSelection.Name = "lblFoodSelection";
            lblFoodSelection.Size = new Size(148, 23);
            lblFoodSelection.TabIndex = 9;
            lblFoodSelection.Text = "FOOD SELECTION";
            // 
            // needPanel
            // 
            needPanel.BackColor = Color.White;
            needPanel.Controls.Add(surpriseCheckBox);
            needPanel.Controls.Add(towelsCheckBox);
            needPanel.Controls.Add(cleaningCheckBox);
            needPanel.Controls.Add(lblSpecialNeeds);
            needPanel.Location = new Point(355, 55);
            needPanel.Name = "needPanel";
            needPanel.Size = new Size(164, 326);
            needPanel.TabIndex = 9;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.AutoSize = true;
            surpriseCheckBox.Location = new Point(18, 128);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(84, 24);
            surpriseCheckBox.TabIndex = 0;
            surpriseCheckBox.Text = "Surprise";
           
            // 
            // towelsCheckBox
            // 
            towelsCheckBox.AutoSize = true;
            towelsCheckBox.Location = new Point(18, 91);
            towelsCheckBox.Name = "towelsCheckBox";
            towelsCheckBox.Size = new Size(76, 24);
            towelsCheckBox.TabIndex = 1;
            towelsCheckBox.Text = "Towels";
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.AutoSize = true;
            cleaningCheckBox.Location = new Point(18, 55);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(89, 24);
            cleaningCheckBox.TabIndex = 2;
            cleaningCheckBox.Text = "Cleaning";
            // 
            // lblSpecialNeeds
            // 
            lblSpecialNeeds.AutoSize = true;
            lblSpecialNeeds.Font = new Font("Segoe UI Semibold", 10F);
            lblSpecialNeeds.ForeColor = Color.FromArgb(52, 152, 219);
            lblSpecialNeeds.Location = new Point(3, 10);
            lblSpecialNeeds.Name = "lblSpecialNeeds";
            lblSpecialNeeds.Size = new Size(130, 23);
            lblSpecialNeeds.TabIndex = 3;
            lblSpecialNeeds.Text = "SPECIAL NEEDS";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(44, 62, 80);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI Semibold", 10F);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(355, 388);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(164, 42);
            nextButton.TabIndex = 8;
            nextButton.Text = "NEXT";
            nextButton.UseVisualStyleBackColor = false;
            // 
            // FoodMenu
            // 
            ClientSize = new Size(534, 442);
            Controls.Add(pnlTop);
            Controls.Add(nextButton);
            Controls.Add(needPanel);
            Controls.Add(foodPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FoodMenu";
            StartPosition = FormStartPosition.CenterParent;
            Load += FoodMenu_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dinnerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)lunchPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)breakfastPicture).EndInit();
            needPanel.ResumeLayout(false);
            needPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.Label lblFoodSelection;
        private System.Windows.Forms.PictureBox dinnerPicture;
        private System.Windows.Forms.PictureBox lunchPicture;
        private System.Windows.Forms.PictureBox breakfastPicture;
        public System.Windows.Forms.TextBox breakfastQTY;
        public System.Windows.Forms.TextBox dinnerQTY;
        public System.Windows.Forms.TextBox lunchQTY;
        private System.Windows.Forms.Label lblSpecialNeeds;
        public System.Windows.Forms.CheckBox dinnerCheckBox;
        public System.Windows.Forms.CheckBox lunchCheckBox;
        public System.Windows.Forms.CheckBox breakfastCheckBox;
        public System.Windows.Forms.CheckBox surpriseCheckBox;
        public System.Windows.Forms.CheckBox towelsCheckBox;
        public System.Windows.Forms.CheckBox cleaningCheckBox;
        public System.Windows.Forms.Panel needPanel;
        public System.Windows.Forms.Button nextButton;
    }
}