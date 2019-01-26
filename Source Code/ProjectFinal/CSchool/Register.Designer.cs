namespace CSchool
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Fbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.Ebox = new Bunifu.Framework.UI.BunifuTextbox();
            this.Pbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.CPbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Ubox = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 44);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(330, 20);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(369, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Fbox
            // 
            this.Fbox.BackColor = System.Drawing.SystemColors.Control;
            this.Fbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fbox.BackgroundImage")));
            this.Fbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fbox.ForeColor = System.Drawing.Color.SeaGreen;
            this.Fbox.Icon = ((System.Drawing.Image)(resources.GetObject("Fbox.Icon")));
            this.Fbox.Location = new System.Drawing.Point(25, 121);
            this.Fbox.Name = "Fbox";
            this.Fbox.Size = new System.Drawing.Size(350, 42);
            this.Fbox.TabIndex = 2;
            this.Fbox.text = "Full Name";
            this.Fbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fbox_MouseClick);
            // 
            // Ebox
            // 
            this.Ebox.BackColor = System.Drawing.SystemColors.Control;
            this.Ebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ebox.BackgroundImage")));
            this.Ebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ebox.ForeColor = System.Drawing.Color.SeaGreen;
            this.Ebox.Icon = ((System.Drawing.Image)(resources.GetObject("Ebox.Icon")));
            this.Ebox.Location = new System.Drawing.Point(25, 178);
            this.Ebox.Name = "Ebox";
            this.Ebox.Size = new System.Drawing.Size(350, 42);
            this.Ebox.TabIndex = 3;
            this.Ebox.text = "Email";
            this.Ebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ebox_MouseClick);
            // 
            // Pbox
            // 
            this.Pbox.BackColor = System.Drawing.SystemColors.Control;
            this.Pbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pbox.BackgroundImage")));
            this.Pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbox.ForeColor = System.Drawing.Color.SeaGreen;
            this.Pbox.Icon = ((System.Drawing.Image)(resources.GetObject("Pbox.Icon")));
            this.Pbox.Location = new System.Drawing.Point(24, 235);
            this.Pbox.Name = "Pbox";
            this.Pbox.Size = new System.Drawing.Size(350, 42);
            this.Pbox.TabIndex = 4;
            this.Pbox.text = "Password";
            this.Pbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pbox_MouseClick);
            // 
            // CPbox
            // 
            this.CPbox.BackColor = System.Drawing.SystemColors.Control;
            this.CPbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPbox.BackgroundImage")));
            this.CPbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CPbox.ForeColor = System.Drawing.Color.SeaGreen;
            this.CPbox.Icon = ((System.Drawing.Image)(resources.GetObject("CPbox.Icon")));
            this.CPbox.Location = new System.Drawing.Point(25, 292);
            this.CPbox.Name = "CPbox";
            this.CPbox.Size = new System.Drawing.Size(350, 42);
            this.CPbox.TabIndex = 5;
            this.CPbox.text = "Confirm Password";
            this.CPbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CPbox_MouseClick);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Register";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(193, 354);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Ubox
            // 
            this.Ubox.BackColor = System.Drawing.SystemColors.Control;
            this.Ubox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ubox.BackgroundImage")));
            this.Ubox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ubox.ForeColor = System.Drawing.Color.SeaGreen;
            this.Ubox.Icon = ((System.Drawing.Image)(resources.GetObject("Ubox.Icon")));
            this.Ubox.Location = new System.Drawing.Point(25, 67);
            this.Ubox.Name = "Ubox";
            this.Ubox.Size = new System.Drawing.Size(350, 42);
            this.Ubox.TabIndex = 6;
            this.Ubox.text = "Username";
            this.Ubox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ubox_MouseClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.Ubox);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.CPbox);
            this.Controls.Add(this.Pbox);
            this.Controls.Add(this.Ebox);
            this.Controls.Add(this.Fbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTextbox CPbox;
        private Bunifu.Framework.UI.BunifuTextbox Pbox;
        private Bunifu.Framework.UI.BunifuTextbox Ebox;
        private Bunifu.Framework.UI.BunifuTextbox Fbox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuTextbox Ubox;
    }
}