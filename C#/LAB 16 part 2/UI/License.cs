using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class License : Form
    {
        // Dragging variables
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public License()
        {
            InitializeComponent();
            SetupEvents();
            this.ActiveControl = btnBack; // Prevent auto-highlighting text
        }

        private void SetupEvents()
        {
          
            btnClose.Click += (s, e) => this.Close();

            
            btnBack.MouseEnter += (s, e) => btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.MouseLeave += (s, e) => btnBack.BackColor = Color.FromArgb(52, 152, 219);

            
            pnlTopBorder.MouseDown += (s, e) => {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            };
            pnlTopBorder.MouseMove += (s, e) => {
                if (dragging)
                {
                    Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                    this.Location = Point.Add(dragFormPoint, new Size(dif));
                }
            };
            pnlTopBorder.MouseUp += (s, e) => dragging = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}