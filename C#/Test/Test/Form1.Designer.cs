namespace Test
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
            BynNext = new Button();
            Name = new Label();
            BtnPrev = new Button();
            SuspendLayout();
            // 
            // BynNext
            // 
            BynNext.Location = new Point(27, 375);
            BynNext.Name = "BynNext";
            BynNext.Size = new Size(94, 29);
            BynNext.TabIndex = 0;
            BynNext.Text = "next";
            BynNext.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(283, 216);
            Name.Name = "Name";
            Name.Size = new Size(50, 20);
            Name.TabIndex = 3;
            Name.Text = "label2";
            // 
            // BtnPrev
            // 
            BtnPrev.Location = new Point(514, 392);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(94, 29);
            BtnPrev.TabIndex = 5;
            BtnPrev.Text = "prev";
            BtnPrev.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(BtnPrev);
            Controls.Add(Name);
            Controls.Add(BynNext);
           
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BynNext;
        private Label Name;
        private Button BtnPrev;
    }
}
