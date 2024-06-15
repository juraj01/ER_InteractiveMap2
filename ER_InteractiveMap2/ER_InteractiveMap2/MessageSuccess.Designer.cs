namespace EldenRing___Interaktívna_mapa___Guna_UI
{
    partial class MessageSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageSuccess));
            this.UpperBorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MessageSuccessPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.Ok = new Guna.UI2.WinForms.Guna2Button();
            this.MessageSuccessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperBorderPanel
            // 
            this.UpperBorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperBorderPanel.BorderColor = System.Drawing.Color.DimGray;
            this.UpperBorderPanel.BorderThickness = 1;
            this.UpperBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperBorderPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpperBorderPanel.Name = "UpperBorderPanel";
            this.UpperBorderPanel.Size = new System.Drawing.Size(526, 32);
            this.UpperBorderPanel.TabIndex = 0;
            // 
            // MessageSuccessPanel
            // 
            this.MessageSuccessPanel.BackgroundImage = global::ER_InteractiveMap2.Properties.Resources.map_text_background_region;
            this.MessageSuccessPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MessageSuccessPanel.Controls.Add(this.MessageLabel);
            this.MessageSuccessPanel.Location = new System.Drawing.Point(-223, 38);
            this.MessageSuccessPanel.Name = "MessageSuccessPanel";
            this.MessageSuccessPanel.Size = new System.Drawing.Size(926, 167);
            this.MessageSuccessPanel.TabIndex = 2;
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
            this.ExitButton.Location = new System.Drawing.Point(474, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(52, 31);
            this.ExitButton.TabIndex = 1;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Garamond", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MessageLabel.Location = new System.Drawing.Point(410, 76);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(139, 29);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Custom text";
            
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ok.FillColor = System.Drawing.Color.DimGray;
            this.Ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.Location = new System.Drawing.Point(424, 211);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(89, 31);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "OK";
            // 
            // MessageSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 250);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.MessageSuccessPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpperBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageSuccess";
            this.Text = "MessageSuccess";
            this.MessageSuccessPanel.ResumeLayout(false);
            this.MessageSuccessPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UpperBorderPanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2Panel MessageSuccessPanel;
        public System.Windows.Forms.Label MessageLabel;
        private Guna.UI2.WinForms.Guna2Button Ok;
    }
}