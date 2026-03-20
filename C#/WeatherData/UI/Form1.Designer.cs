namespace UI
{
    partial class Form1
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
            lblTempInput = new Label();
            lblHumidityInput = new Label();
            lblPressureInput = new Label();
            txtTemperature = new TextBox();
            txtHumidity = new TextBox();
            txtPressure = new TextBox();
            btnEnter = new Button();
            lblCurrentDisplay = new Label();
            lblStatsDisplay = new Label();
            lblForecastDisplay = new Label();
            SuspendLayout();
            // 
            // lblTempInput
            // 
            lblTempInput.AutoSize = true;
            lblTempInput.Location = new Point(30, 30);
            lblTempInput.Name = "lblTempInput";
            lblTempInput.Size = new Size(96, 20);
            lblTempInput.TabIndex = 1;
            lblTempInput.Text = "Temperature:";
            // 
            // lblHumidityInput
            // 
            lblHumidityInput.AutoSize = true;
            lblHumidityInput.Location = new Point(30, 75);
            lblHumidityInput.Name = "lblHumidityInput";
            lblHumidityInput.Size = new Size(73, 20);
            lblHumidityInput.TabIndex = 3;
            lblHumidityInput.Text = "Humidity:";
            // 
            // lblPressureInput
            // 
            lblPressureInput.AutoSize = true;
            lblPressureInput.Location = new Point(30, 120);
            lblPressureInput.Name = "lblPressureInput";
            lblPressureInput.Size = new Size(66, 20);
            lblPressureInput.TabIndex = 5;
            lblPressureInput.Text = "Pressure:";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(140, 27);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(125, 27);
            txtTemperature.TabIndex = 2;
            // 
            // txtHumidity
            // 
            txtHumidity.Location = new Point(140, 72);
            txtHumidity.Name = "txtHumidity";
            txtHumidity.Size = new Size(125, 27);
            txtHumidity.TabIndex = 4;
            // 
            // txtPressure
            // 
            txtPressure.Location = new Point(140, 117);
            txtPressure.Name = "txtPressure";
            txtPressure.Size = new Size(125, 27);
            txtPressure.TabIndex = 6;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(140, 165);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(125, 40);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblCurrentDisplay
            // 
            lblCurrentDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentDisplay.Location = new Point(350, 27);
            lblCurrentDisplay.Name = "lblCurrentDisplay";
            lblCurrentDisplay.Size = new Size(400, 60);
            lblCurrentDisplay.TabIndex = 8;
            lblCurrentDisplay.Text = "Current Conditions: --";
            lblCurrentDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatsDisplay
            // 
            lblStatsDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblStatsDisplay.Location = new Point(350, 100);
            lblStatsDisplay.Name = "lblStatsDisplay";
            lblStatsDisplay.Size = new Size(400, 60);
            lblStatsDisplay.TabIndex = 9;
            lblStatsDisplay.Text = "Statistics: --";
            lblStatsDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForecastDisplay
            // 
            lblForecastDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblForecastDisplay.Location = new Point(350, 173);
            lblForecastDisplay.Name = "lblForecastDisplay";
            lblForecastDisplay.Size = new Size(400, 60);
            lblForecastDisplay.TabIndex = 10;
            lblForecastDisplay.Text = "Forecast: --";
            lblForecastDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 300);
            Controls.Add(lblForecastDisplay);
            Controls.Add(lblStatsDisplay);
            Controls.Add(lblCurrentDisplay);
            Controls.Add(btnEnter);
            Controls.Add(txtPressure);
            Controls.Add(lblPressureInput);
            Controls.Add(txtHumidity);
            Controls.Add(lblHumidityInput);
            Controls.Add(txtTemperature);
            Controls.Add(lblTempInput);
            Name = "Form1";
            Text = "Weather Station Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTempInput;
        private Label lblHumidityInput;
        private Label lblPressureInput;
        private TextBox txtTemperature;
        private TextBox txtHumidity;
        private TextBox txtPressure;
        private Button btnEnter;
        private Label lblCurrentDisplay;
        private Label lblStatsDisplay;
        private Label lblForecastDisplay;
    }
}