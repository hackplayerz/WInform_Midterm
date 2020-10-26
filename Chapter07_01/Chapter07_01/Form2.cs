using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07_01
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// 새로만든 생성자
        /// Form2를 만들때 new Form2()메서드가 생성자를 호출하는것. 객체를 생성할 때 무조건 1번 실행되는 메서드.
        /// 기존에 있던 생성자 public Form2()는 사라져서 이 생성자만 사용해야됨
        /// 그래서 Form2 form2 = new Form2(Form1) 로 만들어야 실행 가능.
        /// </summary>
        /// <param name="form1">Form1의 클래스 포인터를 가져와야됨(포인터라고 주소가 아닌 Form1에서 this를 쳐주면됨)</param>
        public Form2(Form1 form1)
        {
            _form1 = form1; // 생성자로부터 받아온 form1의 객체를 미리 설정해둔 데이터에 저장
            InitializeComponent();
        }

        private Form1 _form1; // 생성자에서 받아온 Form1를 저장해둘 데이터.
        private string _strText; // 내부에서만 사용될(private)문자열

        // private로 설정된 데이터를 외부에서도 사용할 수 있도록 설정한 getter ,setter
        public string StrText
        {
            // StrText를 가져올 때 _strText의 값이 나옴
            get { return _strText; }
            // StrText에 저장할 때 _strText 에 "대화상자"까지 합쳐져서 저장
            set { _strText = value + "대화상자"; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // 미리 저장된 _form1에서 Strinfo라는 변수를 _strText로 저장
            _form1.Strinfo = _strText;
            // 자신(Form2)를 끈다.
            Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 폼2의 타이틀(폼이 열리면 왼쪽 위에 문자)를 _strText로 변경.
            this.Text = _strText;
        }
    }
}
