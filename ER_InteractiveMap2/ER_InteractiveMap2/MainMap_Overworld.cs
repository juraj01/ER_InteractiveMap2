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
    public partial class MainMap_Overworld : Form
    {
        private bool isDragging = false;
        private Point lastCursorPosition;
        private bool isButtonPressed = false;

        public MainMap_Overworld()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeEventHandlers()
        {
            //UpperBorderPanel event handlers:
            this.UpperBorderPanel.MouseDown += UpperBorderPanel_MouseDown;
            this.UpperBorderPanel.MouseMove += UpperBorderPanel_MouseMove;
            this.UpperBorderPanel.MouseUp += UpperBorderPanel_MouseUp;

            //this.UndergroundButton.Click += UndergroundButton_Click;

        }

        private void InitializeButtons()
        {
            this.LimgraveButton.Location = new Point(510, 700);    
            this.LimgraveButton.Size = new Size(450, 366);      
            this.LimgraveButton.ImageSize = new Size(450, 333);  
            this.LimgraveButton.HoverState.ImageSize = this.LimgraveButton.ImageSize;
            this.LimgraveButton.CheckedState.ImageSize = this.LimgraveButton.ImageSize;
            this.LimgraveButton.PressedState.ImageSize = this.LimgraveButton.ImageSize;
            this.LimgraveButton.MouseDown += ImageButton_MouseDown;
            this.LimgraveButton.MouseUp += ImageButton_MouseUp;

            this.CaelidButton.Location = new Point(894, 620);     
            this.CaelidButton.Size = new Size(449, 272);         
            this.CaelidButton.ImageSize = new Size(433, 277);       
            this.CaelidButton.HoverState.ImageSize = this.CaelidButton.ImageSize;
            this.CaelidButton.CheckedState.ImageSize = this.CaelidButton.ImageSize;
            this.CaelidButton.PressedState.ImageSize = this.CaelidButton.ImageSize;
            this.CaelidButton.MouseDown += ImageButton_MouseDown;
            this.CaelidButton.MouseUp += ImageButton_MouseUp;

            this.LiurniaButton.Location = new Point(194, 335);        
            this.LiurniaButton.Size = new Size(504, 500);             
            this.LiurniaButton.ImageSize = new Size(493, 435);                             
            this.LiurniaButton.HoverState.ImageSize = this.LiurniaButton.ImageSize;
            this.LiurniaButton.CheckedState.ImageSize = this.LiurniaButton.ImageSize;
            this.LiurniaButton.PressedState.ImageSize = this.LiurniaButton.ImageSize;
            this.LiurniaButton.MouseDown += ImageButton_MouseDown;
            this.LiurniaButton.MouseUp += ImageButton_MouseUp;

            this.VolcanoButton.Location = new Point(341, 268);   
            this.VolcanoButton.Size = new Size(274, 131);        
            this.VolcanoButton.ImageSize = new Size(250, 125);                            
            this.VolcanoButton.HoverState.ImageSize = this.VolcanoButton.ImageSize;
            this.VolcanoButton.CheckedState.ImageSize = this.VolcanoButton.ImageSize;
            this.VolcanoButton.PressedState.ImageSize = this.VolcanoButton.ImageSize;
            this.VolcanoButton.MouseDown += ImageButton_MouseDown;
            this.VolcanoButton.MouseUp += ImageButton_MouseUp;

            this.AltusButton.Location = new Point(513, 265);
            this.AltusButton.Size = new Size(280, 202);
            this.AltusButton.ImageSize = new Size(280, 187);
            this.AltusButton.HoverState.ImageSize = this.AltusButton.ImageSize;
            this.AltusButton.CheckedState.ImageSize = this.AltusButton.ImageSize;
            this.AltusButton.PressedState.ImageSize = this.AltusButton.ImageSize;
            this.AltusButton.MouseDown += ImageButton_MouseDown;
            this.AltusButton.MouseUp += ImageButton_MouseUp;

            this.LeyndellButton.Location = new Point(666, 315);
            this.LeyndellButton.Size = new Size(384, 172);
            this.LeyndellButton.ImageSize = new Size(350, 160);
            this.LeyndellButton.HoverState.ImageSize = this.LeyndellButton.ImageSize;
            this.LeyndellButton.CheckedState.ImageSize = this.LeyndellButton.ImageSize;
            this.LeyndellButton.PressedState.ImageSize = this.LeyndellButton.ImageSize;
            this.LeyndellButton.MouseDown += ImageButton_MouseDown;
            this.LeyndellButton.MouseUp += ImageButton_MouseUp;

            this.MountaintopsButton.Location = new Point(934, 160); 
            this.MountaintopsButton.Size = new Size(520, 312);
            this.MountaintopsButton.ImageSize = new Size(545, 300);                     
            this.MountaintopsButton.HoverState.ImageSize = this.MountaintopsButton.ImageSize;
            this.MountaintopsButton.CheckedState.ImageSize = this.MountaintopsButton.ImageSize;
            this.MountaintopsButton.PressedState.ImageSize = this.MountaintopsButton.ImageSize;
            this.MountaintopsButton.MouseDown += ImageButton_MouseDown;
            this.MountaintopsButton.MouseUp += ImageButton_MouseUp;

            this.MiquellaButton.Location = new Point(1000, 42);
            this.MiquellaButton.Size = new Size(228, 124);
            this.MiquellaButton.ImageSize = new Size(222, 125);                      
            this.MiquellaButton.HoverState.ImageSize = this.MiquellaButton.ImageSize;
            this.MiquellaButton.CheckedState.ImageSize = this.MiquellaButton.ImageSize;
            this.MiquellaButton.PressedState.ImageSize = this.MiquellaButton.ImageSize;
            this.MiquellaButton.MouseDown += ImageButton_MouseDown;
            this.MiquellaButton.MouseUp += ImageButton_MouseUp;

            this.AzulaButton.Location = new Point(1560, 473);
            this.AzulaButton.Size = new Size(235, 110);
            this.AzulaButton.ImageSize = new Size(216, 110);                      
            this.AzulaButton.HoverState.ImageSize = this.AzulaButton.ImageSize;
            this.AzulaButton.CheckedState.ImageSize = this.AzulaButton.ImageSize;
            this.AzulaButton.PressedState.ImageSize = this.AzulaButton.ImageSize;
            this.AzulaButton.MouseDown += ImageButton_MouseDown;
            this.AzulaButton.MouseUp += ImageButton_MouseUp;

            this.UndergroundButton.Location = new Point(1721, 885);
            this.UndergroundButton.Size = new Size(182, 185);
            this.UndergroundButton.ImageSize = this.UndergroundButton.Size;
            this.UndergroundButton.HoverState.ImageSize = this.UndergroundButton.Size;
            this.UndergroundButton.PressedState.ImageSize= this.UndergroundButton.Size;
            this.UndergroundButton.MouseDown += UndergroundButton_MouseDown;
            this.UndergroundButton.MouseUp += UndergroundButton_MouseUp;
            

            /*this.OverworldButton.Location = new Point(1721, 17);
            this.OverworldButton.Size = new Size(182, 175);
            this.OverworldButton.ImageSize = this.OverworldButton.Size;*/
        }

        private void UndergroundButton_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2ImageButton button = sender as Guna2ImageButton;
            if (e.Button == MouseButtons.Left)
            {
                isButtonPressed = true;
                button.ForeColor = Color.FromArgb(150, 0, 0, 0);
                button.BringToFront();
            }
        }

        private void UndergroundButton_MouseUp(object sender, MouseEventArgs e)
        {
            Guna2ImageButton button = sender as Guna2ImageButton;
            if (e.Button == MouseButtons.Left)
            {
                isButtonPressed = false;
                button.ForeColor = Color.Transparent;
            }
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
    }
}
