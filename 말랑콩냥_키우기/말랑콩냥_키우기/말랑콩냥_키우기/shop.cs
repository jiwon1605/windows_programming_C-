using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 말랑콩냥_키우기
{
    public partial class shop : Form
    {
        
        Form1 f1;

        public shop(Form1 form)
        {
            InitializeComponent();
            f1 = form;
            amount0.Text = f1.amount[0].ToString(); //실제로 증가한 개수를 유저가 보도록 함
            amount1.Text = f1.amount[1].ToString(); //실제로 증가한 개수를 유저가 보도록 함
            amount2.Text = f1.amount[2].ToString(); //실제로 증가한 개수를 유저가 보도록 함

        }


        private void shop_Load(object sender, EventArgs e) 
        {
            timer1.Interval = 1000;   // 돈이 없다는 라벨을 띄울 시간 1초
            timer2.Interval = 1500;   // 뽑았을 때 나오는 냥이 사진 시간 
        }

        private void timer1_Tick(object sender, EventArgs e) //1초 지나면 Toast_M 보이지 않게 하기 위한 함수
        {
            Toast_M.Visible = false;
            timer1.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e) //1.5초가 지나면 고양이 사라짐(뽑기 하고)
        {
            Show_Cat.Visible = false;
            timer2.Enabled = false;
            Grade.Visible = false;
            Grade.BackColor = Color.White;
        }

        
        private void button1_Click(object sender, EventArgs e) // 일반사료 구매 버튼
        {

            if (f1.money < 1000) //돈이 1000원 미만인 경우 구매 불가하다는 경고 알림
            {
                timer1.Enabled = true;
                Toast_M.Visible = true;
            }

            else if(f1.money>=1000)//돈이 1000원 이상인 경우
            {

                f1.amount[0] += 1;                           //개수 증가
                amount0.Text = f1.amount[0].ToString();      //실제로 증가한 개수를 유저가 보도록 함
                f1.money -= 1000;                            //돈은 1000원을 감소시켜줌
                f1.MyMoney.Text = Convert.ToString(f1.money);//변경된 보유 머니 알려줌
            }
        }

        private void button2_Click(object sender, EventArgs e) //중급사료 구매 버튼
        {
            if (f1.money < 10000)                            //돈이 10000원 미만인 경우 구매 불가하다는 경고 알림
            {
                timer1.Enabled = true;
                Toast_M.Visible = true;

            }

            else if (f1.money >= 10000)                      //돈이 1000원 이상인 경우
            {
                f1.amount[1] += 1;                           //개수 증가
                amount1.Text = f1.amount[1].ToString();      //실제로 증가한 개수를 유저가 보도록 함
                f1.money -= 10000;                           //돈은 10000원을 감소시켜줌
                f1.MyMoney.Text = Convert.ToString(f1.money);//보유 머니 돈 바꿔줌
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f1.money < 100000) //돈이 100000원 미만인 경우 구매 불가하다는 경고 알림
            {
                timer1.Enabled = true;
                Toast_M.Visible = true;

            }

            else if (f1.money >= 100000)//돈이 10000원 이상인 경우
            {
                f1.amount[2] += 1;                      //개수 증가
                amount2.Text = f1.amount[2].ToString(); //실제로 증가한 개수를 유저가 보도록 함
                f1.money -= 100000;                     //돈은 10000원을 감소시켜줌
                f1.MyMoney.Text = Convert.ToString(f1.money);
            }
        }

        //---------------------------------------------뽑기-----------------------------------------------------------------//

        private void button5_Click(object sender, EventArgs e) //일반뽑기 버튼
        {
            if (f1.money < 10000) //돈이 10000원 미만인 경우 구매 불가하다는 경고 알림
            {
                timer1.Enabled = true;
                Toast_M.Visible = true;

            }

            else if (f1.money >= 10000)//돈이 10000원 이상인 경우
            {
                Random rand = new Random();
                int cat = rand.Next(0, 100);
                f1.money -= 10000;
                if (cat < 50)
                {
                    int type = rand.Next(0, 3);
                    f1.A_grade[type]++; //A 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "A 급";
                    Grade.Visible = true;

                    if (f1.A_grade[type] != 1)
                    {
                        f1.reven += 18;
                    }
                    else
                        f1.reven += 90;
                }

                else if (50 <= cat && cat < 85)
                {
                    int type = rand.Next(0, 3);
                    f1.S_grade[type]++; //S 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type+3];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "S 급";
                    Grade.BackColor = Color.LightPink;
                    Grade.Visible = true;

                    if (f1.S_grade[type] != 1)
                    {
                        f1.reven += 45;
                    }
                    else
                        f1.reven += 180;
                }

                else
                {
                    int type = rand.Next(0, 3);
                    f1.SR_grade[type]++; //SR 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type+6];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "!!! SR 급 !!!";
                    Grade.BackColor = Color.Violet;
                    Grade.Visible = true;

                    if (f1.SR_grade[type] != 1)
                    {
                        f1.reven += 150;
                    }
                    else
                        f1.reven += 450;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (f1.money < 100000) //돈이 100000원 미만인 경우 구매 불가하다는 경고 알림
            {
                timer1.Enabled = true;
                Toast_M.Visible = true;

            }

            else if (f1.money >= 100000)//돈이 100000원 이상인 경우
            {
                Random rand = new Random();
                int cat = rand.Next(0, 100);
                f1.money -= 100000;
                if (cat < 30)
                {
                    int type = rand.Next(0, 3);
                    f1.A_grade[type]++; //A 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "A 급";
                    Grade.Visible = true;

                    if (f1.A_grade[type] != 1)
                    {
                        f1.reven += 18;
                    }
                    else
                        f1.reven += 90;
                }

                else if (30 <= cat && cat < 80)
                {
                    int type = rand.Next(0, 3);
                    f1.S_grade[type]++; //S 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type+3];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "S 급";
                    Grade.BackColor = Color.LightPink;
                    Grade.Visible = true;

                    if (f1.S_grade[type] != 1)
                    {
                        f1.reven += 45;
                    }
                    else
                        f1.reven += 180;
                }

                else
                {
                    int type = rand.Next(0, 3);
                    f1.SR_grade[type]++; //SR 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type+6];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "!!! SR 급 !!!";
                    Grade.BackColor = Color.Violet;
                    Grade.Visible = true;

                    if (f1.SR_grade[type] != 1)
                    {
                        f1.reven +=150;
                    }
                    else
                        f1.reven += 450;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f1.money -= 1000000;
            if (f1.money < 1000000) //돈이 1000000원 미만인 경우 구매 불가하다는 경고 알림
            {
                timer1.Enabled = true;
                Toast_M.Visible = true;

            }

            else if (f1.money >= 1000000)//돈이 1000000원 이상인 경우
            {
                Random rand = new Random();
                int cat = rand.Next(0, 100);
                if (cat < 15)
                {
                    int type = rand.Next(0, 3);
                    f1.A_grade[type]++; //A 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "A 급";
                    Grade.Visible = true;

                    if (f1.A_grade[type] != 1)
                    {
                        f1.reven += 18;
                    }
                    else
                        f1.reven += 90;
                }

                else if (15 <= cat && cat < 50)
                {
                    int type = rand.Next(0, 3);
                    f1.S_grade[type]++; //S 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type+3];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "S 급";
                    Grade.BackColor = Color.LightPink;
                    Grade.Visible = true;

                    if (f1.S_grade[type] != 1)
                    {
                        f1.reven += 45;
                    }
                    else
                        f1.reven +=180;
                }

                else
                {
                    int type = rand.Next(0, 3);
                    f1.SR_grade[type]++; //SR 냥이에서 랜덤으로 뽑음
                    Show_Cat.Image = imageList1.Images[type+6];
                    timer2.Enabled = true;
                    Show_Cat.Visible = true;
                    Grade.Text = "!!! SR 급 !!!";
                    Grade.BackColor = Color.Violet;
                    Grade.Visible = true;

                    if (f1.SR_grade[type] != 1)
                    {
                        f1.reven += 150;
                    }
                    else
                        f1.reven += 450;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e) //계속해서 보유 사료 개수 최신화해줌
        {
            amount0.Text = f1.amount[0].ToString();
            amount1.Text = f1.amount[1].ToString();
            amount2.Text = f1.amount[2].ToString();
        }
    }
}
