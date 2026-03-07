using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }
        public string UserTxt
        {
            get => txtInput.Text;
            set => txtInput.Text = value;
        }
        
    }
}
