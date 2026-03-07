namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnClose.Click += (sender, e) => this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are ypu sure you want to exist  ? ",
                "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DlgOpen.Filter = "Rich Text files|*.rtf|Text Files|*.txt";
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                switch (DlgOpen.FilterIndex)
                {
                    case 1:
                        rftx.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        rftx.LoadFile(DlgOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
            rftx.LoadFile(DlgOpen.FileName);
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            DalgSave.Filter = "Rich Text files|*.rtf|Text Files|*.txt";
            DalgSave.InitialDirectory = "D:\\ITI\\ITI_tasks\\C#\\WinFormsApp1";

            if (DlgOpen.ShowDialog() == DialogResult.OK)
                rftx.SaveFile(DlgOpen.FileName, (RichTextBoxStreamType)(DalgSave.FilterIndex - 1));
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            if (rftx.SelectedText?.Length > 0)
                DalgFont.Font = rftx.SelectionFont;
            if (DalgFont.ShowDialog() == DialogResult.OK)
                rftx.SelectionFont = DalgFont.Font;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (rftx.SelectedText?.Length > 0)
                DlgColor.Color = rftx.SelectionColor;
            if (DlgColor.ShowDialog() == DialogResult.OK)
                rftx.SelectionColor = DlgColor.Color;
        }

        CustomForm cust = new();
        private void BtnCust_Click(object sender, EventArgs e)
        {
            cust.UserTxt = "type here ";
            if (cust.ShowDialog() == DialogResult.OK) 
                this.rftx.AppendText(cust.UserTxt);

        }
    }
}
