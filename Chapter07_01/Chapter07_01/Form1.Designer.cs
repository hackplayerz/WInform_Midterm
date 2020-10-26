namespace Chapter07_01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_modal = new System.Windows.Forms.Button();
            this.bt_modaless = new System.Windows.Forms.Button();
            this.bt_FileOpen = new System.Windows.Forms.Button();
            this.bt_FileSave = new System.Windows.Forms.Button();
            this.bt_font = new System.Windows.Forms.Button();
            this.bt_color = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 135);
            this.textBox1.TabIndex = 0;
            // 
            // bt_modal
            // 
            this.bt_modal.Location = new System.Drawing.Point(15, 154);
            this.bt_modal.Name = "bt_modal";
            this.bt_modal.Size = new System.Drawing.Size(143, 59);
            this.bt_modal.TabIndex = 1;
            this.bt_modal.Text = "모달(Modal)\r\n대화상자 열기";
            this.bt_modal.UseVisualStyleBackColor = true;
            this.bt_modal.Click += new System.EventHandler(this.bt_modal_Click);
            // 
            // bt_modaless
            // 
            this.bt_modaless.Location = new System.Drawing.Point(182, 154);
            this.bt_modaless.Name = "bt_modaless";
            this.bt_modaless.Size = new System.Drawing.Size(143, 59);
            this.bt_modaless.TabIndex = 2;
            this.bt_modaless.Text = "모달리스(Modaless)\r\n대화상자 열기";
            this.bt_modaless.UseVisualStyleBackColor = true;
            this.bt_modaless.Click += new System.EventHandler(this.bt_modaless_Click);
            // 
            // bt_FileOpen
            // 
            this.bt_FileOpen.Location = new System.Drawing.Point(15, 220);
            this.bt_FileOpen.Name = "bt_FileOpen";
            this.bt_FileOpen.Size = new System.Drawing.Size(310, 42);
            this.bt_FileOpen.TabIndex = 3;
            this.bt_FileOpen.Text = "Txt 파일 열기";
            this.bt_FileOpen.UseVisualStyleBackColor = true;
            this.bt_FileOpen.Click += new System.EventHandler(this.bt_FileOpen_Click);
            // 
            // bt_FileSave
            // 
            this.bt_FileSave.Location = new System.Drawing.Point(15, 268);
            this.bt_FileSave.Name = "bt_FileSave";
            this.bt_FileSave.Size = new System.Drawing.Size(310, 42);
            this.bt_FileSave.TabIndex = 4;
            this.bt_FileSave.Text = "파일 저장하기";
            this.bt_FileSave.UseVisualStyleBackColor = true;
            this.bt_FileSave.Click += new System.EventHandler(this.bt_FileSave_Click);
            // 
            // bt_font
            // 
            this.bt_font.Location = new System.Drawing.Point(12, 316);
            this.bt_font.Name = "bt_font";
            this.bt_font.Size = new System.Drawing.Size(310, 42);
            this.bt_font.TabIndex = 5;
            this.bt_font.Text = "글꼴 변경";
            this.bt_font.UseVisualStyleBackColor = true;
            this.bt_font.Click += new System.EventHandler(this.bt_font_Click);
            // 
            // bt_color
            // 
            this.bt_color.Location = new System.Drawing.Point(15, 364);
            this.bt_color.Name = "bt_color";
            this.bt_color.Size = new System.Drawing.Size(310, 42);
            this.bt_color.TabIndex = 6;
            this.bt_color.Text = "텍스트 박스 색상 변경";
            this.bt_color.UseVisualStyleBackColor = true;
            this.bt_color.Click += new System.EventHandler(this.bt_color_Click);
            // 
            // bt_print
            // 
            this.bt_print.Location = new System.Drawing.Point(12, 412);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(310, 42);
            this.bt_print.TabIndex = 7;
            this.bt_print.Text = "텍스트 박스 내용 출력하기";
            this.bt_print.UseVisualStyleBackColor = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_color);
            this.Controls.Add(this.bt_font);
            this.Controls.Add(this.bt_FileSave);
            this.Controls.Add(this.bt_FileOpen);
            this.Controls.Add(this.bt_modaless);
            this.Controls.Add(this.bt_modal);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_modal;
        private System.Windows.Forms.Button bt_modaless;
        private System.Windows.Forms.Button bt_FileOpen;
        private System.Windows.Forms.Button bt_FileSave;
        private System.Windows.Forms.Button bt_font;
        private System.Windows.Forms.Button bt_color;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

