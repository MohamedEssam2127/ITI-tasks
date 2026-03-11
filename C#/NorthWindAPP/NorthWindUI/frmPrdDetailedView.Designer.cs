namespace NorthWindUI
{
    partial class frmPrdDetailedView
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
            components = new System.ComponentModel.Container();
            lblProductID = new Label();
            txtProductName = new TextBox();
            numUnitPrice = new NumericUpDown();
            prdBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prdBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(41, 47);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(50, 20);
            lblProductID.TabIndex = 0;
            lblProductID.Text = "label1";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(41, 88);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 1;
            // 
            // numUnitPrice
            // 
            numUnitPrice.Location = new Point(41, 140);
            numUnitPrice.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new Size(150, 27);
            numUnitPrice.TabIndex = 2;
            // 
            // frmPrdDetailedView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductID);
            Name = "frmPrdDetailedView";
            Text = "frmPrdDetailedView";
            Load += frmPrdDetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)prdBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductID;
        private TextBox txtProductName;
        private NumericUpDown numUnitPrice;
        private BindingSource prdBindingSource;
    }
}