using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _strInfo;

        public string Strinfo
        {
            get { return _strInfo; }
            set { _strInfo = value; }
        }

        private void bt_modal_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // 폼2객체 생성 , 생성자에 Form1을 넣어달라고 헀으니 자신을 넣어준다.
            form2.Owner = this; // 폼2의 부모객체는 자신
            form2.StrText = "모달"; // StrText에 "모달"을 넣어준다 setter에 의해 "모달대화상자"라고 저장됨
            form2.ShowDialog(); // 모달형식으로 Form2를 열어준다.
        }

        private void bt_modaless_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // 폼2객체 생성 , 생성자에 Form1을 넣어달라고 헀으니 자신을 넣어준다.
            form2.Owner = this; // 폼2의 부모객체는 자신
            form2.StrText = "모달리스"; // StrText에 "모달리스"을 넣어준다 setter에 의해 "모달리스대화상자"라고 저장됨
            form2.Show(); // 모달리스형식으로 Form2를 열어준다.
        }

        private void bt_FileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\"; // 파일 열때 파일다이얼로그의 시작 위치는 C드라이브
            openFileDialog1.Filter = @"텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*"; // 이름|형식|이름|형식
            openFileDialog1.FilterIndex = 1; // 필터의 갯수는 2개(모든파일까지 합쳐서)
            openFileDialog1.RestoreDirectory = true; // 이전 디렉토리를 복원해준다, 만약 다시 오픈 파일 다이얼로그를 켰을때
            // 이전에 선택된 디렉토리를 먼저 열어준다

            // 프로그램의 안전성을 위해 예외처리를 해줌
            try
            {
                // openFileDialog를 출력해준다(파일 선택창 열림),후 OK가 선택됫을때(파일이 선택되고 OK버튼 누름)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // File : using System.IO;를 사용
                    // 텍스트박스에 내용은 File에서 읽어온 문자열을 모두 가져온다
                    // 읽어올 내용은 openFileDialog에서 열린 파일 이름(이름은 모든 경로를 가지고있음)
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
            // 만약 파일 불러오기가 실패했을때
            catch (Exception exception)
            {
                // 콘솔창에 현재 오류를 찍어주고 프로그램은 계속 살아있음
                Console.WriteLine(exception);
            }
        }

        private void bt_FileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Filter = @"텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // 파일에 선택된 경로에 text1에 내용을 모두 저장
                    File.WriteAllText(saveFileDialog1.FileName,textBox1.Text);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void bt_font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void bt_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
           PrinterSettings settings = new PrinterSettings(); // 프린터 출력을 위해 대신 일해줄 클래스 객체 생성
           PrintDocument  docs = new PrintDocument(); // 얘도 프린터를 위해 알아서 일해줄꺼임
           printDialog1.PrinterSettings = settings; // 일해줄 애들을 printDialog1에 설정
           printDialog1.Document = docs; // 얘들이 일해주도록 설정

           docs.PrintPage += PrintPageMethod; // 얘가 이제 실행될 delegate. delegate에 콜백함수를 추가해줌
           // 프린트 출력 다이얼로그 출력, 프린터 누르고 OK누르면 실행
           if (printDialog1.ShowDialog() == DialogResult.OK)
           {
               // 설정된 설정대로(아래 PrintPageMethod에서 설정한 값대로 출력해줌
                docs.Print();
           }

        }

        /// <summary>
        /// 파일 출력 프린트를 위해 따로 만든 메서드
        /// 이 함수는 printDialog1에 delegate로 넘겨질 콜백함수
        /// printDialog1은 delegate가 있어서 콜백함수를 넘겨받게 되는데 이 함수가 넘겨지고 delegate가 실행되면
        /// 링크된 모든 콜백함수들은 전부 실행
        /// </summary>
        /// <seealso cref="https://mrw0119.tistory.com/19"/>
        /// <param name="sender">delegate의 형식을 맞춰주기 위해 있는 매개변수</param>
        /// <param name="eventArgs">
        /// delegate의 형식을 맞춰주기 위해 있는 매개변수
        /// PrintPageEventArgs는 프린트에 출력 해주기 위해 있는 객체
        /// </param>
        private void PrintPageMethod(object sender, PrintPageEventArgs eventArgs)
        {
            string text = textBox1.Text;  // textbox1에 텍스트를 미리 저장
            Font font = textBox1.Font; // font도 저장
            // DrawString(출력될 문자, 출력될 문자의 폰트, 출력될 문자의 색상(Brushes라는 클래스에 미리 저장된 검정색 값),
            // 출력될때 시작 X위치는 10, 출력될때 시작 Y위치는 10)
            eventArgs.Graphics.DrawString(text,font,Brushes.Black,10,10);
        }

    }
}
