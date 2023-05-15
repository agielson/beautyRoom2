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
using System.Windows.Markup;
using System.Drawing.Drawing2D;

namespace BeautyRoom
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void gunaButton3_Click(object sender, EventArgs e)
        {


        }
        /* private void conteiner(object _form) {
             if(gunaPanel3.Controls.Count>0) gunaPanel3.Controls.Clear();
             Form fm = _form as Form;
             fm.TopLevel = false;
             fm.FormBorderStyle = FormBorderStyle.None;
             fm.Dock = DockStyle.Fill;
             gunaPanel3.Controls.Add(fm);
             gunaPanel3.Tag = fm;
             fm.Show();
         }*/

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
        /* private void conteiner2(object _form)
         {
             if (gunaPanel3.Controls.Count > 0) gunaPanel3.Controls.Clear();
             Form fm = _form as Form;
             fm.TopLevel = false;
             fm.FormBorderStyle = FormBorderStyle.None;
             fm.Dock = DockStyle.Fill;
             gunaPanel3.Controls.Add(fm);
             gunaPanel3.Tag = fm;
             fm.Show();
         }*/

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Должность", typeof(string));
            dataGridView1.DataSource = table;

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Masters.txt");
            string[] value;
            for (int i = 0; i < lines.Length; i++)
            {
                value = lines[i].ToString().Split('/');
                string[] row = new string[value.Length];
                for (int j = 0; j < value.Length; j++)
                {
                    row[j] = value[j].Trim();
                }
                table.Rows.Add(row);
            }

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

