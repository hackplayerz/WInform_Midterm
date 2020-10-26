using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int _BtnXSize = 75;
        private const int _BtnYSize = 23;

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeBtnLocationAtRandom();

        }

        private void ChangeBtnLocationAtRandom()
        {
            Random rand = new Random();
            Size formSize = this.Size;
            Console.WriteLine("FormX : " + formSize.Width + " Form Y : " + formSize.Height);
            button1.Location = new Point(
                rand.Next(_BtnXSize,formSize.Width - _BtnXSize)
                ,rand.Next(_BtnYSize,formSize.Height - _BtnYSize));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeBtnLocationAtRandom();
            Random rand = new Random();
            button1.BackColor = Color.FromArgb(
                rand.Next(255), rand.Next(255), rand.Next(255)
            );
            

        }
    }
}
