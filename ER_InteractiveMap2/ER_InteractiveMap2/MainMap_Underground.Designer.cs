namespace ER_InteractiveMap2
{
    partial class MainMap_Underground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMap_Underground));
            this.UpperBorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SiofraButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AinselButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // UpperBorderPanel
            // 
            this.UpperBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperBorderPanel.Name = "UpperBorderPanel";
            this.UpperBorderPanel.Size = new System.Drawing.Size(1920, 30);
            this.UpperBorderPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::ER_InteractiveMap2.Properties.Resources.Exit___final_;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.BorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.IconColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(1878, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 29);
            this.ExitButton.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = global::ER_InteractiveMap2.Properties.Resources.Minimalize___final;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.IconColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Location = new System.Drawing.Point(1836, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimizeButton.TabIndex = 2;
            // 
            // SiofraButton
            // 
            this.SiofraButton.BackColor = System.Drawing.Color.Transparent;
            this.SiofraButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SiofraButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.SiofraButton.Image = global::ER_InteractiveMap2.Properties.Resources.Siafra_River_Main;
            this.SiofraButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.SiofraButton.ImageRotate = 0F;
            this.SiofraButton.ImageSize = new System.Drawing.Size(200, 143);
            this.SiofraButton.Location = new System.Drawing.Point(888, 711);
            this.SiofraButton.Name = "SiofraButton";
            this.SiofraButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SiofraButton.Size = new System.Drawing.Size(249, 143);
            this.SiofraButton.TabIndex = 3;
            // 
            // AinselButton
            // 
            this.AinselButton.BackColor = System.Drawing.Color.Transparent;
            this.AinselButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AinselButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.AinselButton.Image = global::ER_InteractiveMap2.Properties.Resources.Ainsel_River_Main;
            this.AinselButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.AinselButton.ImageRotate = 0F;
            this.AinselButton.ImageSize = new System.Drawing.Size(190, 205);
            this.AinselButton.Location = new System.Drawing.Point(543, 430);
            this.AinselButton.Name = "AinselButton";
            this.AinselButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AinselButton.Size = new System.Drawing.Size(200, 215);
            this.AinselButton.TabIndex = 4;
            // 
            // MainMap_Underground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ER_InteractiveMap2.Properties.Resources.Underground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.AinselButton);
            this.Controls.Add(this.SiofraButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpperBorderPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMap_Underground";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UpperBorderPanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2ImageButton SiofraButton;
        private Guna.UI2.WinForms.Guna2ImageButton AinselButton;
    }
}