using DBCreator;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace DBCreator
{
    public partial class Form3 : Form
    {
        bool oneExists = false;
        bool twoExists = false;
        bool threeExists = false;
        bool fourExists = false;
        bool fiveExists = false;
        bool sixExists = false;
        bool sevenExists = false;
        bool eightExists = false;
        bool nineExists = false;
        bool tenExists = false;

        public Form3()
        {
            InitializeComponent();
            FormClosed += Form3_FormClosed;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void peopleDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + label3.Text);
            DialogResult res = MessageBox.Show("The record can be put into a folder. Do you want me to put it into a folder?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\two"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "t");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\three"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "t");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\four"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "f");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\five"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "f");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\six"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "s");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\seven"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "s");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\eight"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "e");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\nine"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "n");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            if (File.Exists(Directory.GetCurrentDirectory() + "\\ten"))
            {
                var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "t");
                newfile.Close();
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3 = textBox3.Text;
                string text4 = textBox4.Text;
                string text5 = textBox5.Text;
                string text6 = textBox6.Text;
                string text7 = textBox7.Text;
                string text8 = textBox8.Text;
                string text9 = textBox9.Text;
                string text10 = textBox10.Text;
                string text11 = textBox11.Text;
                string text12 = textBox12.Text;
                string text13 = textBox13.Text;
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "o", text1 + Environment.NewLine + text2 + Environment.NewLine + text3 + Environment.NewLine + text4 + Environment.NewLine + text5 + Environment.NewLine + text6 + Environment.NewLine + text7 + Environment.NewLine + text8 + Environment.NewLine + text9 + Environment.NewLine + text10 + Environment.NewLine + text11 + Environment.NewLine + text12 + Environment.NewLine + text13);
            }
            else return;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peopleToolStripMenuItem.DropDownItems.Count < 1)
            {
                MessageBox.Show("Please create a person.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void one_Click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\one");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void two_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\two");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button2.Enabled = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void three_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\three");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void four_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\four");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void five_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\five");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void six_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\six");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void seven_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\seven");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void eight_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\eight");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void nine_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\nine");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void ten_click(object sender, EventArgs e)
        {
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\ten");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
            button1.Text = "Create Traffic Record based off '" + ListLines[2] + "' data?";
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (oneExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\one"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\one");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("1. " + ListLines[2]).Click += one_Click;
                oneExists = true;
            }
            if (twoExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\two"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\two");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("2. " + ListLines[2]).Click += two_click;
                twoExists = true;
            }
            if (threeExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\three"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\three");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("3. " + ListLines[2]).Click += three_click;
                threeExists = true;
            }
            if (fourExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\four"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\four");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("4. " + ListLines[2]).Click += four_click;
                fourExists = true;
            }
            if (fiveExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\five"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\five");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("5. " + ListLines[2]).Click += five_click;
                fiveExists = true;
            }
            if (sixExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\six"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\six");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("6. " + ListLines[2]).Click += six_click;
                sixExists = true;
            }
            if (sevenExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\seven"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\seven");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("7. " + ListLines[2]).Click += seven_click;
                sevenExists = true;
            }
            if (eightExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\eight"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\eight");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("8. " + ListLines[2]).Click += eight_click;
                eightExists = true;
            }
            if (nineExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\nine"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\nine");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("9. " + ListLines[2]).Click += nine_click;
                nineExists = true;
            }
            if (tenExists != true && File.Exists(Directory.GetCurrentDirectory() + "\\ten"))
            {
                TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\ten");
                int lines = 9;
                string[] ListLines = new string[lines];
                for (int i = 1; i < lines; i++)
                {
                    ListLines[i] = file.ReadLine();
                }
                peopleToolStripMenuItem.DropDownItems.Add("10. " + ListLines[2]).Click += ten_click;
                tenExists = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Vehicle_registration_plate#:~:text=A%20vehicle%20registration%20plate%2C%20also,trailer%20for%20official%20identification%20purposes.&text=There%20are%20also%20electronic%20license%20plates.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "2";
            textBox3.Text = "3";
            textBox4.Text = "4";
            textBox5.Text = "5";
            textBox6.Text = "6";
            textBox7.Text = "7";
            textBox8.Text = "8";
            textBox9.Text = "9";
            textBox10.Text = "10";
        }

        private void trafficDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Choose an old record.";
            open.InitialDirectory = Directory.GetCurrentDirectory();
            open.ShowDialog();
            TextReader file = new StreamReader(open.FileName);
            int lines = 14;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            textBox1.Text = ListLines[1];
            textBox2.Text = ListLines[2];
            textBox3.Text = ListLines[3];
            textBox4.Text = ListLines[4];
            textBox5.Text = ListLines[5];
            textBox6.Text = ListLines[6];
            textBox7.Text = ListLines[7];
            textBox8.Text = ListLines[8];
            textBox9.Text = ListLines[9];
            textBox10.Text = ListLines[10];
            textBox11.Text = ListLines[11];
            textBox12.Text = ListLines[12];
            textBox13.Text = ListLines[13];
        }

        private void peopleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Choose an old record.";
            open.InitialDirectory = Directory.GetCurrentDirectory();
            open.ShowDialog();
            TextReader file = new StreamReader(open.FileName);
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            label5.Text = ListLines[1];
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label3.Text = ListLines[2];
            label2.Visible = true;
            label6.Visible = true;
            label7.Text = ListLines[3];
            label7.Visible = true;
            label8.Visible = true;
            label9.Text = ListLines[4];
            label9.Visible = true;
            label11.Visible = true;
            label11.Text = ListLines[5];
            label13.Text = ListLines[6];
            label13.Visible = true;
            label12.Visible = true;
            label10.Visible = true;
            label15.Text = ListLines[7];
            label15.Visible = true;
            label14.Visible = true;
            label17.Text = ListLines[8];
            label16.Visible = true;
            label17.Visible = true;
        }

        private void transcriptDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
