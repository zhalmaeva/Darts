using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string name;

        public static SortedDictionary<int, List<String>> name_players2 = new SortedDictionary<int, List<String>>();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Form4 F4 = new Form4();
        Form3 F3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            // форма заполнения имени
            F4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Открытие формы с таблицей рекордов
            F3.listBox1.Items.Clear();
            foreach (KeyValuePair<int, List<String>> keyValue in name_players2)
            {
                foreach (String name_plr in keyValue.Value)
                {
                    F3.listBox1.Items.Add(name_plr + ":  " + (keyValue.Key * (-1)).ToString());
                }
            }
            F3.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //закрытие игры
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //При загрузке формы происходит загрузка таблицы рекордов из файла "Тор"
            System.IO.StreamReader sr = new
             System.IO.StreamReader("Top.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                if (str != "")
                {
                    int index = str.IndexOf(' ');
                    string name = str.Substring(0, index);
                    int score = Convert.ToInt32(str.Substring(index));
                    if (name_players2.ContainsKey(score * (-1)))
                        name_players2[score * (-1)].Add(name);
                    else name_players2.Add(score * (-1), new List<string> { name });
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //При закрытии формы сохраняем таблицу рекордов в файл "Тор"
            int i = 0;
            string[] tmp = new string[256];
            foreach (KeyValuePair<int, List<string>> keyValue in Form1.name_players2)
            {
                foreach (String name_plr in keyValue.Value)
                {
                    tmp[i] = name_plr + ' ' + (keyValue.Key * (-1)).ToString();
                    i++;
                }
            }
            if (File.Exists("Top.txt"))
                File.Create("Top.txt").Close();
            File.WriteAllLines("Top.txt", tmp);
        }
    }
}
