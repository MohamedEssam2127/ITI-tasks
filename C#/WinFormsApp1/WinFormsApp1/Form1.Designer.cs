namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpen = new Button();
            BtnSave = new Button();
            BtnClose = new Button();
            BtnFont = new Button();
            BtnColor = new Button();
            BtnCust = new Button();
            rftx = new RichTextBox();
            DlgOpen = new OpenFileDialog();
            DalgFont = new FontDialog();
            DalgSave = new SaveFileDialog();
            DlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top;
            BtnSave.CausesValidation = false;
            BtnSave.Location = new Point(359, 12);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Location = new Point(694, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 29);
            BtnClose.TabIndex = 6;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnFont
            // 
            BtnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnFont.Location = new Point(12, 409);
            BtnFont.Name = "BtnFont";
            BtnFont.Size = new Size(94, 29);
            BtnFont.TabIndex = 3;
            BtnFont.Text = "Font";
            BtnFont.UseVisualStyleBackColor = true;
            BtnFont.Click += BtnFont_Click;
            // 
            // BtnColor
            // 
            BtnColor.Anchor = AnchorStyles.Bottom;
            BtnColor.Location = new Point(330, 409);
            BtnColor.Name = "BtnColor";
            BtnColor.Size = new Size(94, 29);
            BtnColor.TabIndex = 4;
            BtnColor.Text = "Color";
            BtnColor.UseVisualStyleBackColor = true;
            BtnColor.Click += BtnColor_Click;
            // 
            // BtnCust
            // 
            BtnCust.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCust.Location = new Point(694, 409);
            BtnCust.Name = "BtnCust";
            BtnCust.Size = new Size(94, 29);
            BtnCust.TabIndex = 5;
            BtnCust.Text = "Cust";
            BtnCust.UseVisualStyleBackColor = true;
            BtnCust.Click += BtnCust_Click;
            // 
            // rftx
            // 
            rftx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rftx.Location = new Point(12, 47);
            rftx.Name = "rftx";
            rftx.Size = new Size(776, 356);
            rftx.TabIndex = 1;
            rftx.Text = "";
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            DlgOpen.InitialDirectory = "D:\\\\ITI\\\\ITI_tasks\\\\C#\\\\WinFormsApp1";
            // 
            // DalgSave
            // 
            DalgSave.InitialDirectory = "D:\\\\ITI\\\\ITI_tasks\\\\C#\\\\WinFormsApp1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rftx);
            Controls.Add(BtnCust);
            Controls.Add(BtnColor);
            Controls.Add(BtnFont);
            Controls.Add(BtnClose);
            Controls.Add(BtnSave);
            Controls.Add(btnOpen);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button BtnSave;
        private Button BtnClose;
        private Button BtnFont;
        private Button BtnColor;
        private Button BtnCust;
        private RichTextBox rftx;
        private OpenFileDialog DlgOpen;
        private FontDialog DalgFont;
        private SaveFileDialog DalgSave;
        private ColorDialog DlgColor;
    }
}
