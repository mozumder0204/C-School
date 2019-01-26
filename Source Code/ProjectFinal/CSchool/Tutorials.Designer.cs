namespace CSchool
{
    partial class Tutorials
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("if Statement");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("if-else Statement");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Decision Control Structure", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("for- Loop");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("while-Loop");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Loop Control Structure", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorials));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.whileLoop1 = new CSchool.WhileLoop();
            this.forLoop1 = new CSchool.ForLoop();
            this.ifElse1 = new CSchool.IfElse();
            this.ifStatement1 = new CSchool.IfStatement();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.treeView1.LineColor = System.Drawing.Color.Violet;
            this.treeView1.Location = new System.Drawing.Point(50, 123);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "if Statement";
            treeNode2.Name = "Node3";
            treeNode2.Text = "if-else Statement";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Decision Control Structure";
            treeNode4.Name = "Node5";
            treeNode4.Text = "for- Loop";
            treeNode5.Name = "Node12";
            treeNode5.Text = "while-Loop";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Loop Control Structure";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.PathSeparator = "/";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(656, 400);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("BankGothic Md BT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(204, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(267, 40);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Tutorials";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(11, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 14;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // whileLoop1
            // 
            this.whileLoop1.AutoScroll = true;
            this.whileLoop1.Location = new System.Drawing.Point(3, 0);
            this.whileLoop1.Name = "whileLoop1";
            this.whileLoop1.Size = new System.Drawing.Size(730, 610);
            this.whileLoop1.TabIndex = 13;
            this.whileLoop1.Visible = false;
            // 
            // forLoop1
            // 
            this.forLoop1.AutoScroll = true;
            this.forLoop1.Location = new System.Drawing.Point(3, 3);
            this.forLoop1.Name = "forLoop1";
            this.forLoop1.Size = new System.Drawing.Size(730, 610);
            this.forLoop1.TabIndex = 12;
            this.forLoop1.Visible = false;
            // 
            // ifElse1
            // 
            this.ifElse1.AutoScroll = true;
            this.ifElse1.Location = new System.Drawing.Point(0, 3);
            this.ifElse1.Name = "ifElse1";
            this.ifElse1.Size = new System.Drawing.Size(730, 610);
            this.ifElse1.TabIndex = 11;
            this.ifElse1.Visible = false;
            // 
            // ifStatement1
            // 
            this.ifStatement1.AutoScroll = true;
            this.ifStatement1.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.ifStatement1.Location = new System.Drawing.Point(0, 3);
            this.ifStatement1.Name = "ifStatement1";
            this.ifStatement1.Size = new System.Drawing.Size(730, 610);
            this.ifStatement1.TabIndex = 10;
            this.ifStatement1.Visible = false;
            // 
            // Tutorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.whileLoop1);
            this.Controls.Add(this.forLoop1);
            this.Controls.Add(this.ifElse1);
            this.Controls.Add(this.ifStatement1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "Tutorials";
            this.Size = new System.Drawing.Size(730, 610);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private IfStatement ifStatement1;
        private IfElse ifElse1;
        private ForLoop forLoop1;
        private WhileLoop whileLoop1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
