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
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp;
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

            this.DeeprootButton.Location = new Point(840, 334);
            this.DeeprootButton.Size = new Size(120, 150);
            this.DeeprootButton.ImageSize = new Size(110, 145);
            this.DeeprootButton.HoverState.ImageSize = this.DeeprootButton.ImageSize;
            this.DeeprootButton.CheckedState.ImageSize = this.DeeprootButton.ImageSize;
            this.DeeprootButton.PressedState.ImageSize = this.DeeprootButton.ImageSize;
            this.DeeprootButton.MouseDown += ImageButton_MouseDown;
            this.DeeprootButton.MouseUp += ImageButton_MouseUp;

            this.OverworldButton.Location = new Point(1721, 50);
            this.OverworldButton.Size = new Size(182, 175);
            this.OverworldButton.ImageSize = this.OverworldButton.Size;
            this.OverworldButton.HoverState.ImageSize = this.OverworldButton.ImageSize;
            this.OverworldButton.CheckedState.ImageSize = this.OverworldButton.ImageSize;
            this.OverworldButton.PressedState.ImageSize = this.OverworldButton.ImageSize;
        }

        private void UpperBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = Cursor.Position;
            }
        }
        private void UpperBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = new Point(Cursor.Position.X - lastCursorPosition.X, Cursor.Position.Y - lastCursorPosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
                lastCursorPosition = Cursor.Position;

                if (e.Y > UpperBorderPanel.Height / 2)
                {
                    this.WindowState = FormWindowState.Normal;
                }

                else if (this.Top <= 0 && e.Y < UpperBorderPanel.Height / 2)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void UpperBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
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

        private void OverworldButton_Click(object sender, EventArgs e)
        {
            Program.overworld.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Program.overworld.Close();
            Program.underground.Close();
        }
    }
}
