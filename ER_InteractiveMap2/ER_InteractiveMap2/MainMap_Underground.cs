using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ER_InteractiveMap2
{
    public partial class MainMap_Underground : Form
    {
        private bool isDragging = false;
        private Point lastCursorPosition;
        private bool isButtonPressed = false;

        public MainMap_Underground()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            this.SiofraButton.Location = new Point(888, 711);
            this.SiofraButton.Size = new Size(249, 143);
            this.SiofraButton.ImageSize = new Size(200, 143);
            this.SiofraButton.HoverState.ImageSize = this.SiofraButton.ImageSize;
            this.SiofraButton.CheckedState.ImageSize = this.SiofraButton.ImageSize;
            this.SiofraButton.PressedState.ImageSize = this.SiofraButton.ImageSize;
            this.SiofraButton.MouseDown += ImageButton_MouseDown;
            this.SiofraButton.MouseUp += ImageButton_MouseUp;

            this.AinselButton.Location = new Point(543, 430);
            this.AinselButton.Size = new Size(200, 215);
            this.AinselButton.ImageSize = new Size(190, 205);
            this.AinselButton.HoverState.ImageSize = this.AinselButton.ImageSize;
            this.AinselButton.CheckedState.ImageSize = this.AinselButton.ImageSize;
            this.AinselButton.PressedState.ImageSize = this.AinselButton.ImageSize;
            this.AinselButton.MouseDown += ImageButton_MouseDown;
            this.AinselButton.MouseUp += ImageButton_MouseUp;
        }

        private void ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton button = sender as Guna2ImageButton;
            if (e.Button == MouseButtons.Left)
            {
                isButtonPressed = true;
                button.BackColor = Color.FromArgb(50, 0, 0, 0);
                button.BringToFront();
            }
        }

        private void ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            Guna2ImageButton button = sender as Guna2ImageButton;
            if (e.Button == MouseButtons.Left)
            {
                isButtonPressed = false;
                button.BackColor = Color.Transparent;
            }
        }
    }
}
