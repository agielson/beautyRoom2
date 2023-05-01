using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form3 = new Form3();
        }
        Form2 form2;
        Form3 form3;

        string path = @"User.txt";
        string admin = @"Admin.txt";

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            string name = NameTextBox.Text;
            string number = NumberTextBox.Text;
            string password = PasswordTextBox.Text;
            bool correctName = false;
            bool correctNumber = false;
            bool correctPassword = false;
            bool adminCorrectName = false;
            bool adminCorrectNumber = false;
            bool adminCorrectPassword = false;

            string[] line = File.ReadAllLines(path);
            for (int i = 0; i < line.Length; i++)
            {
                if (name == line[i])
                {
                    correctName = true;
                }
                if (number == line[i])
                {
                    correctNumber = true;
                }
                if (password == line[i])
                {
                    correctPassword = true;
                }

            }

            string[] lines = File.ReadAllLines(admin);
            for (int i = 0; i < lines.Length; i++)
            {
                if (name == lines[i])
                {
                    adminCorrectName = true;
                }
                if (number == lines[i])
                {
                    adminCorrectNumber = true;
                }
                if (password == lines[i])
                {
                    adminCorrectPassword = true;
                }
            }
            if (adminCorrectName == true && adminCorrectNumber == true && adminCorrectPassword == true)
            {
                form3.Show();
            }

            if (correctName == true && correctNumber == true && correctPassword == true)
            {
                form2.Show(); ;
            }

            else if (correctName == false && correctNumber == false && correctPassword == false)
            {
                MessageBox.Show("Ошибка! Проверьте введные данные!", "Ошибка авторизации");
            }

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine(NameTextBox.Text);
                stream.WriteLine(NumberTextBox.Text);
                stream.WriteLine(PasswordTextBox.Text);
                MessageBox.Show("Данные успешно сохранены!", "Регистрация");
            }
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}