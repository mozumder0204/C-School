namespace CSchool
{
    partial class LogIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.passHide = new Bunifu.Framework.UI.BunifuImageButton();
            this.passTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.userTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.user1 = new CSchool.User();
            this.admin1 = new CSchool.Admin();
            ((System.ComponentModel.ISupportInitialize)(this.passHide)).BeginInit();
            this.SuspendLayout();
            // 
            // passHide
            // 
            this.passHide.BackColor = System.Drawing.Color.SeaGreen;
            this.passHide.Image = ((System.Drawing.Image)(resources.GetObject("passHide.Image")));
            this.passHide.ImageActive = null;
            this.passHide.Location = new System.Drawing.Point(606, 135);
            this.passHide.Name = "passHide";
            this.passHide.Size = new System.Drawing.Size(18, 18);
            this.passHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passHide.TabIndex = 8;
            this.passHide.TabStop = false;
            this.passHide.Zoom = 10;
            this.passHide.Click += new System.EventHandler(this.passHide_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passTextBox.HintText = "";
            this.passTextBox.isPassword = false;
            this.passTextBox.LineFocusedColor = System.Drawing.Color.SpringGreen;
            this.passTextBox.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.passTextBox.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.passTextBox.LineThickness = 2;
            this.passTextBox.Location = new System.Drawing.Point(295, 135);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(310, 25);
            this.passTextBox.TabIndex = 9;
            this.passTextBox.Text = "Password";
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTextBox.Click += new System.EventHandler(this.passTextBox_Click);
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 1;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "Log In";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleBorderThickness = 1;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.White;
            this.loginButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.Location = new System.Drawing.Point(424, 190);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 41);
            this.loginButton.TabIndex = 11;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTextBox.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.userTextBox.HintText = "";
            this.userTextBox.isPassword = false;
            this.userTextBox.LineFocusedColor = System.Drawing.Color.SpringGreen;
            this.userTextBox.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userTextBox.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.userTextBox.LineThickness = 2;
            this.userTextBox.Location = new System.Drawing.Point(295, 91);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(310, 25);
            this.userTextBox.TabIndex = 13;
            this.userTextBox.Text = "Username";
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userTextBox.Click += new System.EventHandler(this.userTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Don\'t have an account  ?";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Signup";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(525, 246);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(100, 37);
            this.bunifuThinButton21.TabIndex = 17;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // user1
            // 
            this.user1.Location = new System.Drawing.Point(0, 0);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(730, 610);
            this.user1.TabIndex = 18;
            // 
            // admin1
            // 
            this.admin1.AutoScroll = true;
            this.admin1.Location = new System.Drawing.Point(-3, 3);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(730, 610);
            this.admin1.TabIndex = 19;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passHide);
            this.Controls.Add(this.passTextBox);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(730, 610);
            ((System.ComponentModel.ISupportInitialize)(this.passHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton passHide;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private User user1;
        private Admin admin1;
    }
}
