using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 말랑콩냥_키우기
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 form)
        {
            InitializeComponent();
            f1 = form;            
        }
        //도감 사진 클릭시 메인 고양이의 그림이 바뀜
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(basic_amount.Text) != 0)
            {
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.기본콩냥이_A;
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gray_amount.Text) != 0)
            {
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.회냥이_A;
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tiger_amount.Text) != 0)
            {
                
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.호냥이_A;
                this.Close();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(festival_amount.Text) != 0)
            {
                
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.파티냥이_S;
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(old_amount.Text) != 0)
            {

                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.중절냥이_S;
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(bini_amount.Text) != 0)
            {
                
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.비니냥이_S;
                this.Close();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(queen_amount.Text) != 0)
            {
                
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.귀족냥이_SR;
                this.Close();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(king_amount.Text) != 0)
            {
                
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.왕냥이_SR;
                this.Close();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(hallow_amount.Text) != 0)
            {
                
                f1.MainCat.Image = 말랑콩냥_키우기.Properties.Resources.할리냥이_SR;
                this.Close();
            }
        }
        //계속해서 도감에 보유개수 최신화 해줌.
        private void timer1_Tick(object sender, EventArgs e)
        {
            basic_amount.Text = f1.A_grade[0].ToString();
            gray_amount.Text = f1.A_grade[1].ToString();
            tiger_amount.Text = f1.A_grade[2].ToString();

            festival_amount.Text = f1.S_grade[0].ToString();
            old_amount.Text = f1.S_grade[1].ToString();
            bini_amount.Text = f1.S_grade[2].ToString();

            queen_amount.Text = f1.SR_grade[0].ToString();
            king_amount.Text = f1.SR_grade[1].ToString();
            hallow_amount.Text = f1.SR_grade[2].ToString();
        }
    }
}
