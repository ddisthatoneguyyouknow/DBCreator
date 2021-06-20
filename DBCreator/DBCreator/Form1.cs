using DBCreator;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace DBCreator
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void peopleDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + label3.Text);
            DialogResult res = MessageBox.Show("The record can be put into a folder. Do you want me to put it into a folder?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\one"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\one");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "one");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "one", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\two"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\two");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "two");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "two", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\three"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\three");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "three");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "three", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\four"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\four");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "four");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "four", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\five"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\five");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "five");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "five", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\six"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\six");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "six");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "six", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\seven"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\seven");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "seven");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "seven", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\eight"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\eight");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "eight");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "eight", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\nine"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\nine");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "nine");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "nine", text);
                }
                if (File.Exists(Directory.GetCurrentDirectory() + "\\ten"))
                {
                    var text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\ten");
                    var newfile = File.Create(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "ten");
                    newfile.Close();
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "ten", text);
                }
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
            button2.Enabled = true;
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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
            button1.Text = "Create a '" + label3.Text + "' folder.";
            button2.Text = "Save to '" + label3.Text + "' folder.";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Picture of POI (Person Of Interest)";
            openFileDialog.ShowDialog();
            pictureBox1.Image = new Bitmap(openFileDialog.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\" + label3.Text))
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + pictureBox1.ImageLocation) != true)
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    bitmap.Save(Directory.GetCurrentDirectory() + "\\" + label3.Text + "\\" + "POI.png", ImageFormat.Png);
                }
            }
            else
            {
                MessageBox.Show("Please create a person and add that person to a directory first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label3.Text != string.Empty)
            {
                button2.Enabled = true;
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
