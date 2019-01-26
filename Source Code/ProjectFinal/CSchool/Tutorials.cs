using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSchool
{
    public partial class Tutorials : UserControl
    {
        public Tutorials()
        {
            InitializeComponent();
        }

        //SELECT TUTORIALS FOR SHOWING
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "if Statement")
            {
                treeView1.Visible = false;
                ifStatement1.Visible = true;    
            }
            else if (treeView1.SelectedNode.Text == "if-else Statement")
            {
                treeView1.Visible = false;
                ifElse1.Visible = true;
           
            }
            else if (treeView1.SelectedNode.Text == "for- Loop")
            {
                treeView1.Visible = false;
                forLoop1.Visible = true;
            
            }
            else if (treeView1.SelectedNode.Text == "while-Loop")
            {
                treeView1.Visible = false;
                whileLoop1.Visible = true;
                
            }
        }

        //BACK BUTTON
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            ifStatement1.Visible = false;
            ifElse1.Visible = false;
            forLoop1.Visible = false;
            whileLoop1.Visible = false;

        }
    }
}
