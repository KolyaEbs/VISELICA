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

namespace VISELICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string text;
        public char[] word;
        public int hp;
        public int hp2;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    StreamReader streamReader = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\1.txt");
                    while (streamReader.EndOfStream)
                    {
                        textBox1.Text = streamReader.ReadLine();
                    }

                    text = streamReader.ReadLine();
                    streamReader.Close();
                    hp = 0;
                    pictureBox1.Image = new Bitmap("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\VISELICA\\VISELICA\\bin\\Debug\\0.png");
                    label1.Text = null;
                    textBox1.Text = null;
                    word = new char[text.Length];
                    pictureBox1.Visible = true;
                    break;

                    case 1:
                    StreamReader streamReader2 = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\2.txt");
                    while (streamReader2.EndOfStream)
                    {
                        textBox1.Text = streamReader2.ReadLine();
                    }

                    text = streamReader2.ReadLine();
                    streamReader2.Close();
                    hp = 0;
                    pictureBox1.Image = new Bitmap("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\VISELICA\\VISELICA\\bin\\Debug\\0.png");
                    label1.Text = null;
                    textBox1.Text = null;
                    word = new char[text.Length];
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    StreamReader streamReader3 = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\3.txt");
                    while (streamReader3.EndOfStream)
                    {
                        textBox1.Text = streamReader3.ReadLine();
                    }

                    text = streamReader3.ReadLine();
                    streamReader3.Close();
                    hp = 0;
                    pictureBox1.Image = new Bitmap("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\VISELICA\\VISELICA\\bin\\Debug\\0.png");
                    label1.Text = null;
                    textBox1.Text = null;
                    word = new char[text.Length];
                    pictureBox1.Visible = true;
                    break;
                case 3:
                    StreamReader streamReader4 = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\4.txt");
                    while (streamReader4.EndOfStream)
                    {
                        textBox1.Text = streamReader4.ReadLine();
                    }

                    text = streamReader4.ReadLine();
                    streamReader4.Close();
                    hp = 0;
                    pictureBox1.Image = new Bitmap("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\VISELICA\\VISELICA\\bin\\Debug\\0.png");
                    label1.Text = null;
                    textBox1.Text = null;
                    word = new char[text.Length];
                    pictureBox1.Visible = true;
                    break;
                case 4:
                    StreamReader streamReader5 = new StreamReader("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\5.txt");
                    while (streamReader5.EndOfStream)
                    {
                        textBox1.Text = streamReader5.ReadLine();
                    }

                    text = streamReader5.ReadLine();
                    streamReader5.Close();
                    hp = 0;
                    pictureBox1.Image = new Bitmap("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\VISELICA\\VISELICA\\bin\\Debug\\0.png");
                    label1.Text = null;
                    textBox1.Text = null;
                    word = new char[text.Length];
                    pictureBox1.Visible = true;
                    break;

            }

            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += '.';
                word[i] = '.';
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                bool words = false;
                int j = 0;
                if (textBox2.Text.Length == 1)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (textBox2.Text[0] == text[i])
                        {
                            words = true;
                            hp2++;
                            word[i] = text[i];
                            label1.Text = null;
                        }
                    }
                    if (words == true)
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            label1.Text += word[i];
                        }
                        if (hp2 == text.Length)
                        {
                            MessageBox.Show("Ты победил!");
                        }
                    }
                    else
                    {
                        hp++;
                        string hpb = hp.ToString() + ".png";
                        pictureBox1.Image = new Bitmap(hpb);
                        if (hp == 5)
                        {
                            MessageBox.Show("Ты проиграл!");
                            label1.Text = null;
                            label1.Text = text;
                        }
                    }

                }
                else if (textBox2.Text.Length > 1) //   ПОМОРАЕВ НИКОЛАЙ И ФЁДОРОВА ДАРЬЯ
                {
                    if (textBox2.Text == text)
                    {
                        label1.Text = null;
                        for (int i = 0; i < text.Length; i++)
                        {
                            label1.Text += text[i];
                        }
                        MessageBox.Show("Ты победил!");
                    }
                    else
                    {
                        hp = 5;
                        string hpb = hp.ToString() + ".png";
                        pictureBox1.Image = new Bitmap(hpb);
                        MessageBox.Show("Ты проиграл!");
                        label1.Text = null;
                        label1.Text = text;
                    }
                }
                textBox2.Text = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    StreamWriter write_text;
                    FileInfo file = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\1.txt");
                    write_text = file.CreateText();
                    write_text.WriteLine(textBox1.Text);
                    write_text.Close();
                    textBox1.Text = null;
                    break;

                case 1:
                    StreamWriter write_text2;
                    FileInfo file2 = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\2.txt");
                    write_text2 = file2.CreateText();
                    write_text2.WriteLine(textBox1.Text);
                    write_text2.Close();
                    textBox1.Text = null;
                    break;
                case 2:
                    StreamWriter write_text3;
                    FileInfo file3 = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\3.txt");
                    write_text3 = file3.CreateText();
                    write_text3.WriteLine(textBox1.Text);
                    write_text3.Close();
                    textBox1.Text = null;
                    break;
                case 3:
                    StreamWriter write_text4;
                    FileInfo file4 = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\4.txt");
                    write_text4 = file4.CreateText();
                    write_text4.WriteLine(textBox1.Text);
                    write_text4.Close();
                    textBox1.Text = null;
                    break;
                case 4:
                    StreamWriter write_text5;
                    FileInfo file5 = new FileInfo("I:\\244-ИСП\\244ИСП\\ОАиП\\Помораев Николай\\ВИСЕЛИЦА\\5.txt");
                    write_text5 = file5.CreateText();
                    write_text5.WriteLine(textBox1.Text);
                    write_text5.Close();
                    textBox1.Text = null;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text = null;
            label1.Text = null;
            pictureBox1.Visible = false;
            

        }
    }
}