namespace CSchool
{
    partial class Credit
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
            this.label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(248, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Supervised By  :  Victor Stany Rozario Sir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(729, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Developed By :  Md. Billal Hossain Mozumder(16-1)\r\n                      " +
    "               Esrat Jahan Tonni (16-1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 88);
            this.label4.TabIndex = 3;
            this.label4.Text = "\"C School\" is our C# course project in \r\n7th semester(Spring 2017-18)  and \r\nthis" +
    " project is dedicated to all AIUBians.\r\n#HappyCoding :)";
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Credit";
            this.Size = new System.Drawing.Size(730, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel label1;
        private Bunifu.Framework.UI.BunifuCustomLabel label2;
        private Bunifu.Framework.UI.BunifuCustomLabel label3;
        private Bunifu.Framework.UI.BunifuCustomLabel label4;
    }
}
