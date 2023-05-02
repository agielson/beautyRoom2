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

namespace BeautyRoom
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void FormUserEntury_Load(object sender, EventArgs e)
        {
            table.Columns.Add("№", typeof(int));
            table.Columns.Add("Услуга", typeof(string));
            table.Columns.Add("Мастер", typeof(string));
            table.Columns.Add("Цена", typeof(string));
            table.Columns.Add("Дата", typeof(string));

            dataGridView2.DataSource = table;
        }

        private void gunaButtonShowInf_Click(object sender, EventArgs e)
        {
            string pathRecord = @"records.txt";
            string[] lines = File.ReadAllLines(pathRecord);
            string[] data;

            for (int i = 0; i < lines.Length; i++)
            {
                data = lines[i].ToString().Split('/');

                string[] row = new string[data.Length];

                for (int j = 0; j < data.Length; j++)
                {
                    row[j] = data[j].Trim();
                }
                table.Rows.Add(row);
            }
        }

        
    }
}