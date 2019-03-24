using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        public double _score = 0;
        public double gen_score = 0;
        public double modifier = 1;
        public bool flag = false;
        public Form1()
        {
            InitializeComponent();
            button2.Text = "Купить x"+ modifier;
            
           //TODO:  textBox3.Text = "" + tick(); сделать секундомер
        }
        public void score_Check()
        {
//            if global.money < 1000
//{
//                draw_text(x, y, string('Money: $') + string(global.money))
//}
//            if global.money >= 1000
//            {
//                draw_text(x, y, string('Money: $') + string(round(global.money / 1000)) + string('K'))
//            }

            if(gen_score < 1000)
            {
                textBox1.Text = "" + Math.Round(_score, 1);
            }
            if(gen_score >= 1000)
            {
                textBox1.Text = "" + Math.Round((_score/1000),1)+ "K";
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            _score *= modifier;
            _score += 1;
            textBox1.Text = "" + Math.Round(_score,1);
            textBox2.Text = "Модификатор: " + modifier;
            gen_score = double.Parse(textBox1.Text);
            Score_check();
            score_Check();
        }

        public void Score_check()
        {
            if((gen_score >= 60)&&(gen_score <= 100))
            {
                MessageBox.Show("Now you can X your score");
                button2.Show();
            }
            if ((gen_score >= 200)&& (gen_score < 400))
            {
                MessageBox.Show("Now you can X your score");
                button2.Show();
            }
            if ((gen_score >= 1000)&& (gen_score < 1100))
            {
                MessageBox.Show("Now you can X your score");
                button2.Show();
            }
            if (gen_score >= 5000)
            {
                MessageBox.Show("Now you can X your score");
                button2.Show();
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            modifier += 0.1 ; //x0,1 к клику
            button2.Text = "Купить x" + modifier;
            button2.Hide();
        }

        public Timer tick()
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Start();
            return tmr;
        }
    }
}
