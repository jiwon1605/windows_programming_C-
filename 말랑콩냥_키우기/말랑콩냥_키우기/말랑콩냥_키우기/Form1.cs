using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 말랑콩냥_키우기
{

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void StartScreen_Click(object sender, EventArgs e) //시작화면 누를시
        {
            MainScreen.Visible = true;                             //메인화면 보이게 바꿈
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainScreen.Visible = true; //시작화면에서 메인화면으로 넘어감
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainScreen.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MainScreen.Visible = true;
        }


        public double money = 50000;           // 현재 가지고 있는 돈
        public double reven = 90;              // 초당 수익
        public int[] A_grade = { 1, 0, 0 };    // A 등급 보유 개수
        public int[] S_grade = { 0, 0, 0 };    //S 등급 보유 개수 
        public int[] SR_grade = { 0, 0, 0 };   //SR 등급 보유 개수
        int i = 5;                             // 사료 지속시간 
        double temp;
        public int[] amount = { 0, 0, 0 };     //사료 개수 기본 / 고급 / 최고급 / 
        private void timer1_Tick(object sender, EventArgs e) // (1/10)초마다 타이머 계산
        {
            money += Math.Round(reven/10);               //돈에 반올림해서 더해줌
            MyMoney.Text = Convert.ToString(money);      //현재 가지고 있는 돈 표시
            reven_amount.Text = reven.ToString();        //현재 초당 수익 표시
        } 
        
        
        private void button1_Click(object sender, EventArgs e) //밥주기 버튼 이벤트처리
        {
            if (timer2.Enabled == false)   //만약 이미 사료를 먹인 상태가 아니라면,
            {
                temp = 0;                  //temp 를 0으로 초기화
                if (amount[2] != 0)        // 고급사료가 있다면 고급사료 부터 사용
                {
                      
                    amount[2]--;           //개수 하나 빼줌
                  
                    
                    timer2.Enabled = true; //먹이 주는 타이머 시작
                    label4.Text = "고급사료가 " + amount[2].ToString() + "개 남았습니다. "; //몇개 남았는지 보여줌
                    label4.Visible = true;  //몇개 남았는지 보여주는 라벨 보여줌 
                    temp = Math.Round(reven * 2); //현재 초당 수익의 2배를 temp에 저장.
                    
                }
                else if (amount[1] != 0)
                {
                    
                    amount[1]--;
                    
                    timer2.Enabled = true;
                    label4.Text = "중급사료가 " + amount[1].ToString() + "개 남았습니다. ";
                    label4.Visible = true;
                    temp = Math.Round(reven * 0.75);

                    
                }
                else if (amount[0] != 0)
                {
                    
                    amount[0]--;
                    
                    timer2.Enabled = true;
                    label4.Text = "일반 사료가 " + amount[0].ToString() + "개 남았습니다. ";
                    label4.Visible = true;
                    temp = Math.Round(reven * 0.35);
                    
                }
                else       //사료가 없을시
                {
                    i = 2; //2초간 메세지보여줌
                    timer2.Enabled = true; //타이머 사용 
                    Toast_M.Text = "사료가 없습니다."; //사료가 없다는 메세지 보여줌
                    Toast_M.Visible = true;
                }
                reven += temp; //초당수익에 temp 더해줌
            }
            
        }
        private void timer2_Tick(object sender, EventArgs e) //밥주기 버튼 담당할 타이머
        {
            i--;        //1초당 i를 하나 씩 빼줌
            if (i == 0) //지정된 시간이 다 지나면
            {
                label4.Visible = false;  //사료 몇개 남았는지 보여주는 라벨 안보이게 함
                Toast_M.Visible = false; //토스트 메세지 안보이게 함
                timer2.Enabled=false;    //타이머 정지시킴
                i = 5;                   //i를 다시 5로 초기화
                reven = reven - temp;    //초당 수익을 다시 원래대로 돌려둠
            }
        }

        

        private void button3_Click(object sender, EventArgs e) //도감버튼
        {
            Form2 form2 = new Form2(this);                     //도감 폼 보여줌
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e) //끝내기 버튼
        {
            Application.Exit();                                //프로그램 끝냄
        }

        private void button2_Click(object sender, EventArgs e) //상점 버튼
        {
            shop newshop = new shop(this);                     //상점폼 열어줌
            
            newshop.Show();
        }

        private void MainCat_Click(object sender, EventArgs e)  //가운데 고양이 누를시
        { 
            money += Math.Round(reven/2);                       //초당 수익의 반씩 돈이 들어옴
        }
    }
}
