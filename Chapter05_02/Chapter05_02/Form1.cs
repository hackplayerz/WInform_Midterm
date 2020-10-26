using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void OnAlingCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if(radioButton == radioButton4)
            {
                button1.TextAlign = ContentAlignment.MiddleLeft;
            }
            else if(radioButton == radioButton5)
            {
                button1.TextAlign = ContentAlignment.MiddleCenter;
            }
            else if(radioButton == radioButton6)
            {
                button1.TextAlign = ContentAlignment.MiddleRight;
            }

        }

        private void OnColorCheckedChanged(object sender, EventArgs e)
        {
             RadioButton checkedRadioBtn = sender as RadioButton;

            if (checkedRadioBtn == radioButton1)
            {
                button1.BackColor = Color.Red;
            }
            else if (checkedRadioBtn == radioButton2)
            { 
                button1.BackColor = Color.Green;    
            }            
            else if(checkedRadioBtn == radioButton3)
            {
                button1.BackColor = Color.Blue;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = !checkBox2.Checked;
        }
    }
}
