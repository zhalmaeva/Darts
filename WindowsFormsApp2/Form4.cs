using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // слхраняем имя игрока, передаем его в следующую форму
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите имя игрока");
            }
            else
            {
                Form1.name = textBox1.Text;
                Form2 F2 = new Form2();
                this.Hide();
                F2.ShowDialog();
                textBox1.Text = "";
            }
        }
    }
}
