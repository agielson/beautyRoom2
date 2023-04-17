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
using System.IO;

namespace BeautyRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            mainWindow = new MainWindow();
        }
        MainWindow mainWindow;

        string path = @"D:\Дз_Программы\BeautyRoom\User.txt";
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string number = NumberTextBox.Text;
            string password = PasswordTextBox.Text;
=======
            form2 = new Form3(); 
        }
        Form3 form2;
       

        string path = @"User.txt";
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string name = gunaTextBox1.Text;
            string number = gunaTextBox3.Text;
            string password = gunaTextBox2.Text;
>>>>>>> Привязка к окнам пользователя и админа
            bool correctName = false;
            bool correctNumber = false;
            bool correctPassword = false;

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
            if (correctName == true && correctNumber == true && correctPassword == true)
            {
<<<<<<< HEAD
                mainWindow.Show(); ;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте введные данные!","Ошибка авторизации");
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
=======
                form2.Show(); ;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте введные данные!", "Ошибка авторизации");
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
>>>>>>> Привязка к окнам пользователя и админа
        {

        }

<<<<<<< HEAD
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine(NameTextBox.Text);
                stream.WriteLine(NumberTextBox.Text);
                stream.WriteLine(PasswordTextBox.Text);
=======
      

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine(gunaTextBox1.Text);
                stream.WriteLine(gunaTextBox3.Text);
                stream.WriteLine(gunaTextBox2.Text);
                MessageBox.Show("Пользователь успешно зарегестрирован");
>>>>>>> Привязка к окнам пользователя и админа
            }
        }
    }
}
