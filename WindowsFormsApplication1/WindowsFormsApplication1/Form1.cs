using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string others = "";

        private void submitButton_Click(object sender, EventArgs e)
        {
            string place = "";
            
            if (checkBox1.Checked) place += checkBox1.Text + "\n";
            if (checkBox2.Checked) place += checkBox2.Text + "\n";
            if (checkBox3.Checked) place += checkBox3.Text + "\n";
            if (checkBox4.Checked) place += checkBox4.Text + "\n";
            if (othersButton.Checked) place += others + "\n";
          
            MessageBox.Show("You've selected: \n" + place + "\n Thank you" , "Survey" , MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void othersButton_CheckedChanged(object sender, EventArgs e)
        {
            if (othersButton.Checked == true)
            {
                label3.Visible = true;
                otherText.Visible = true;
            }
            else {
                label3.Visible = false;
                otherText.Visible = false;
            }
        }

        private void otherText_TextChanged(object sender, EventArgs e)
        {
            others = otherText.Text;
        }

       

    }
}
