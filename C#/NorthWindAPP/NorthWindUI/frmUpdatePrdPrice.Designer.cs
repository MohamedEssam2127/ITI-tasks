namespace NorthWindUI
{
    partial class frmUpdatePrdPrice
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
            lstPrds = new ListBox();
            numPrdPrice = new NumericUpDown();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrdPrice).BeginInit();
            SuspendLayout();
            // 
            // lstPrds
            // 
            lstPrds.FormattingEnabled = true;
            lstPrds.Location = new Point(407, 12);
            lstPrds.Name = "lstPrds";
            lstPrds.Size = new Size(187, 384);
            lstPrds.TabIndex = 0;
            lstPrds.SelectedIndexChanged += lstPrds_SelectedIndexChanged;
            // 
            // numPrdPrice
            // 
            numPrdPrice.Location = new Point(28, 45);
            numPrdPrice.Name = "numPrdPrice";
            numPrdPrice.Size = new Size(150, 27);
            numPrdPrice.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(500, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmUpdatePrdPrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(btnUpdate);
            Controls.Add(numPrdPrice);
            Controls.Add(lstPrds);
            Name = "frmUpdatePrdPrice";
            Text = "frmUpdatePrdPrice";
            Load += frmUpdatePrdPrice_Load;
            ((System.ComponentModel.ISupportInitialize)numPrdPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPrds;
        private NumericUpDown numPrdPrice;
        private Button btnUpdate;
    }
}