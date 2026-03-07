namespace WinFormsApp1
{
    partial class CustomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnOk = new Button();
            BtnCancel = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnOk.DialogResult = DialogResult.OK;
            BtnOk.Location = new Point(12, 109);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 29);
            BtnOk.TabIndex = 1;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.Location = new Point(527, 109);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(12, 42);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(609, 27);
            txtInput.TabIndex = 0;
            // 
            // CustomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 150);
            ControlBox = false;
            Controls.Add(txtInput);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CustomForm";
            ShowInTaskbar = false;
            Text = "CustomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOk;
        private Button BtnCancel;
        private TextBox txtInput;
    }
}