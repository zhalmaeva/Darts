using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using WMPLib;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool stopX = false;
        int stepMain = 5;
        int x = -5;
        int y = -5;
        int double_x;
        int double_y;
        public int score = 0;
        string name;
        int i = 0;
        int bomb_x = 200;
        int bomb_y = 200;
        Random rand = new Random();

        private void Form2_Load(object sender, EventArgs e)
        {
            //загрузка формы
            name = Form1.name;
            label1.Text = name + ", удачи!";
            label4.Text = "Кликните по мишени.";
            double_x = rand.Next(30, 350);
            double_y = rand.Next(30, 350);
            bomb_x = rand.Next(30, 350);
            bomb_y = rand.Next(30, 350);
        }
        Image image_double = Image.FromFile("double3.png");
        Image image_bomb = Image.FromFile("bomb.png");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // запуск потоков для бегунков (5 раз)

            if (i < 5)
            {
                if (!backgroundWorker1.IsBusy && !stopX)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                    stopX = true;
                }

                if (!backgroundWorker2.IsBusy && stopX)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
                else
                if (backgroundWorker2.IsBusy && stopX)
                {
                    backgroundWorker2.CancelAsync();
                    i++;
                    stopX = false;
                }
            }
            else MessageBox.Show("Ваш результат: " + score.ToString()+ ". Ура!");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // первый поток для горизонтального бегунка
            int value = 135;
            int step = stepMain;
            while (true)
            {
                value += step;
                Task.Delay(1).GetAwaiter().GetResult();
                if (value + step >= 540)
                    step *= -1;
                if (value + step <= 135)
                    step *= -1;
                backgroundWorker1.ReportProgress(value);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // получаем из потока значения для измения положения горизонтального бегунка 
            pictureBox2.Left = e.ProgressPercentage;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //второй поток для вертикально бегунка
            int value = 435;
            int step = stepMain;
            while (true)
            {
                value += step;
                Task.Delay(1).GetAwaiter().GetResult();
                if (value + step >= 435)
                    step *= -1;
                if (value + step <= 40)
                    step *= -1;
                backgroundWorker2.ReportProgress(value);
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // меняем положение вертикального бегунка
            pictureBox3.Top= e.ProgressPercentage; 
        }
        int chek_Count(int x, int y)
        {
            // проверяем, в какой сектор попали
            double count = (x - 200) * (x - 200) + (y - 200) * (y - 200);
            if (count >= 40000) return 0;
            if (count >= 25600) return 5;
            if (count >= 14000) return 6;
            if (count >= 6400) return 7;
            if (count >= 1600) return 8;
            if (count >= 260) return 9;
            return 20;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // рисуем попадание
            e.Graphics.DrawImage(image_double, new Point(double_x, double_y));
            e.Graphics.DrawImage(image_bomb, new Point(bomb_x, bomb_y));
            e.Graphics.FillEllipse(Brushes.Black, x - 5, y - 5, 10, 10);          
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //по окончании работы потока проверяем попадание в х2 или бомбу
            x = pictureBox2.Left-133;
            y = pictureBox3.Top - 37;
            if ((x - double_x - 25) * (x - double_x - 25) + (y - double_y - 25) * (y - double_y - 25) <= 625)
            {
                score *= 2;
                double_x = 600;
                double_y = 600;

            }
            else if ((x - bomb_x - 25) * (x - bomb_x - 25) + (y - bomb_y - 30) * (y - bomb_y - 30) <= 625)
            {
                score = 0;
                bomb_x= 600;
                bomb_y = 600;
            }
            else
                score += chek_Count(x, y);
            label3.Text = "Счет: " + score.ToString();
            if (darts2.Visible==false)  
                darts1.Visible = false;
            if (darts3.Visible == false)
                darts2.Visible = false;
            if (darts4.Visible == false)
                darts3.Visible = false;
            if (darts5.Visible == false)
                darts4.Visible = false;
            if (darts5.Visible == true)
                darts5.Visible = false;
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //кнопка выхода в меню
            saveResult();
            this.Hide();
        }

        void saveResult()
        {
            //функция сохранения результата
            if (score != 0)
            {
                if (Form1.name_players2.ContainsKey(score * (-1)))
                    Form1.name_players2[-score].Add(name);
                else Form1.name_players2.Add(score * (-1), new List<string> { name });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка перезапуска игры
            saveResult();
            Form F2 = new Form2();
            this.Close();
            F2.Show();
        }
    }
}
