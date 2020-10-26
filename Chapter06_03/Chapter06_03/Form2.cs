using System.Windows.Forms;

namespace Chapter06_03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// maskedTextBox에 문자가 입력될때 실행될 메서드
        /// </summary>
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // 전화번호 형식이 제대로 들어왔을 때
            if(maskedTextBox1.MaskCompleted)
            {
                label1.Text = @"휴대전화번호 입력 완료";
            }

            // 형식이 잘못 들어왔을 때
            else
            {
                label1.Text = @"번호 형식이 맞지 않습니다.";
            }
        }
    }
}
