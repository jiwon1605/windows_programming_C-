namespace 말랑콩냥_키우기
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartScreen = new System.Windows.Forms.Panel();
            this.MainScreen = new System.Windows.Forms.Panel();
            this.reven_amount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Toast_M = new System.Windows.Forms.Label();
            this.MyMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainCat = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.StartScreen.SuspendLayout();
            this.MainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼매직체", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(161, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "말랑콩냥 키우기";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(225, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click Screen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartScreen
            // 
            this.StartScreen.BackColor = System.Drawing.Color.White;
            this.StartScreen.Controls.Add(this.MainScreen);
            this.StartScreen.Controls.Add(this.label2);
            this.StartScreen.Controls.Add(this.pictureBox2);
            this.StartScreen.Controls.Add(this.label1);
            this.StartScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartScreen.Location = new System.Drawing.Point(0, 0);
            this.StartScreen.Name = "StartScreen";
            this.StartScreen.Size = new System.Drawing.Size(774, 829);
            this.StartScreen.TabIndex = 2;
            this.StartScreen.Click += new System.EventHandler(this.StartScreen_Click);
            // 
            // MainScreen
            // 
            this.MainScreen.BackColor = System.Drawing.Color.White;
            this.MainScreen.Controls.Add(this.label4);
            this.MainScreen.Controls.Add(this.reven_amount);
            this.MainScreen.Controls.Add(this.label5);
            this.MainScreen.Controls.Add(this.Toast_M);
            this.MainScreen.Controls.Add(this.MyMoney);
            this.MainScreen.Controls.Add(this.label3);
            this.MainScreen.Controls.Add(this.button4);
            this.MainScreen.Controls.Add(this.button3);
            this.MainScreen.Controls.Add(this.button2);
            this.MainScreen.Controls.Add(this.button1);
            this.MainScreen.Controls.Add(this.MainCat);
            this.MainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScreen.Location = new System.Drawing.Point(0, 0);
            this.MainScreen.Name = "MainScreen";
            this.MainScreen.Size = new System.Drawing.Size(774, 829);
            this.MainScreen.TabIndex = 2;
            this.MainScreen.Visible = false;
            // 
            // reven_amount
            // 
            this.reven_amount.BackColor = System.Drawing.Color.Gainsboro;
            this.reven_amount.Location = new System.Drawing.Point(249, 101);
            this.reven_amount.Name = "reven_amount";
            this.reven_amount.Size = new System.Drawing.Size(495, 23);
            this.reven_amount.TabIndex = 11;
            this.reven_amount.Text = "0";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(111, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(651, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "초당수익 : ";
            // 
            // Toast_M
            // 
            this.Toast_M.BackColor = System.Drawing.Color.Silver;
            this.Toast_M.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Toast_M.Location = new System.Drawing.Point(120, 399);
            this.Toast_M.Name = "Toast_M";
            this.Toast_M.Size = new System.Drawing.Size(522, 42);
            this.Toast_M.TabIndex = 8;
            this.Toast_M.Text = "label4";
            this.Toast_M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Toast_M.Visible = false;
            // 
            // MyMoney
            // 
            this.MyMoney.BackColor = System.Drawing.Color.Gainsboro;
            this.MyMoney.Location = new System.Drawing.Point(249, 34);
            this.MyMoney.Name = "MyMoney";
            this.MyMoney.Size = new System.Drawing.Size(495, 23);
            this.MyMoney.TabIndex = 5;
            this.MyMoney.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(111, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "돈       : ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 731);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "끝내기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 731);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "도감";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 731);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "상점";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "밥주기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainCat
            // 
            this.MainCat.Image = global::말랑콩냥_키우기.Properties.Resources.기본콩냥이_A;
            this.MainCat.Location = new System.Drawing.Point(186, 198);
            this.MainCat.Name = "MainCat";
            this.MainCat.Size = new System.Drawing.Size(385, 420);
            this.MainCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainCat.TabIndex = 9;
            this.MainCat.TabStop = false;
            this.MainCat.Click += new System.EventHandler(this.MainCat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(186, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("한컴 훈민정음 가로쓰기", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(120, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(522, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 829);
            this.Controls.Add(this.StartScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StartScreen.ResumeLayout(false);
            this.StartScreen.PerformLayout();
            this.MainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel StartScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Toast_M;
        public System.Windows.Forms.Panel MainScreen;
        public System.Windows.Forms.PictureBox MainCat;
        private System.Windows.Forms.Label reven_amount;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label MyMoney;
        private System.Windows.Forms.Label label4;
    }
}

