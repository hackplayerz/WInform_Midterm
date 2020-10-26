using System;
using System.Windows.Forms;

namespace Chapter06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 리스트박스에 데이터가 있을 때
            if (listBox1.SelectedIndex >  -1)
            {
                // 리스트박스(왼쪽)에서 선택된 데이터를 콤보박스(오른쪽)으로 데이터를 복사
                comboBox1.Items.Add(listBox1.SelectedItem);
                // 리스트박스 선택된 데이터를 삭제
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show(@"리스트박스에 선택된 데이터가 없습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                // 콤보박스에 선택된 데이터를 리스트박스(왼쪽)에 복사
                listBox1.Items.Add(comboBox1.SelectedItem);
                // 콤보박스에 선택된 데이터를 삭제
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(@"콤보 박스에 선택된 데이터가 없습니다.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 텍스트박스에 문자열이 있을때
            if (!textBox1.Text.Equals(string.Empty))
            {
                // 리스트박스에 텍스트박스에 입력된 문자를 데이터로서 추가
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 리스트박스에서 선택된 데이터가 있을 때
            if (listBox1.SelectedIndex > -1)
            {
                // 리스트박스에 선택된 데이터를 삭제
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}