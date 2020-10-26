using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Chapter06_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string ID_Message = @"아이디를 입력 하시오."; // 아이디 텍스박스에 아무것도 없을 때 들어갈 문자
        private const string PW_Message = @"비밀번호를 입력 하시오."; // 비밀번호 텍스트 박스에 아무것도 없을 때 들어갈 문자

        /// <summary>
        /// 폼이 열렸을때 실행될 이벤트
        /// </summary>
        /// <param name="sender">이 이벤트가 실행된 객체</param>
        /// <param name="e">실행된 이벤트의 상태</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 열릴때 파란색 태두리(포커스)를 버튼1로 주겠다.
            this.ActiveControl = button1;
        }


        /// <summary>
        /// ID 텍스트 박스가 클릭됬을 때 실행될 이벤트
        /// </summary>
        private void textBox1_Click(object sender, EventArgs e)
        {
            // 만약 초기상태(입력하시오 문자가 있을때) 
            if(textBox1.Text.Equals(ID_Message))
            {
                // ID텍스트박스의 내용을 모두 지운다.
                textBox1.Text = string.Empty;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
             // 만약 초기상태(입력하시오 문자가 있을때)
            if(textBox2.Text.Equals(PW_Message))
            {
                // PW텍스트박스의 내용을 모두 지운다.
                textBox2.Text = string.Empty;
                // 비밀번호 문자(숫자 가리고 문자*로 출력)로 출력하게 해준다.
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // ID텍스트박스가 비어있을때
            if(textBox1.Text.Equals(string.Empty))
            {
                // ID텍스트박스에 아이디 입력하라고 적어둠.
                textBox1.Text = ID_Message;    
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text.Equals(string.Empty))
            {
                textBox2.Text = PW_Message;
                // 비밀번호 문자를 없앤다 (default는 '\0'(null)과 같다)
                textBox2.PasswordChar = default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 로그인이 완료됬을 때
            if(textBox1.Text.Equals(@"윈도우프로그래밍실습") && textBox2.Text.Equals(@"1234") )
            {
                // 폼2 객체를 생성한다,
                Form2 form2 = new Form2();
                // 폼2의 부모객체를 자신으로 설정한다.
                form2.Owner = this;
                // 폼2를 보여준다.
                form2.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 링크라벨에 있는 링크를 연다(Process는 System.Diagnostics에 안에 있는 메서드)
            // using System.Diagnostics;를 해줘야 실행이 된다.
            // using 이 귀찮으면 System.Diagnostics.Pocess.Start()를 해줘도 된다.
            Process.Start(linkLabel1.Text);
            //System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
