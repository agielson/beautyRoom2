﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BeautyRoom
{
    public partial class User : Form

    {
        public User()
        {

            InitializeComponent();
            form4 = new MyRecords();
        }
        MyRecords form4;
        DataTable table = new DataTable();
        int selectedRow;

        public void ShowTable_Load(object sender, EventArgs e)
        {
            table.Columns.Add("№", typeof(int));
            table.Columns.Add("Услуга", typeof(string));
            table.Columns.Add("Мастер", typeof(string));
            table.Columns.Add("Цена", typeof(string));
            table.Columns.Add("Дата", typeof(string));

            dataGridView2.DataSource = table;
        }

        public void ButtonShowInf_Click(object sender, EventArgs e)
        {
            string path = "Masters.txt";

            string[] lines = File.ReadAllLines(path);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }

        public void dataGridViewInTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            IDTextBox.Text = selectedRow.Cells[0].Value.ToString();
            SvTextBox.Text = selectedRow.Cells[1].Value.ToString();
            MrTextBox.Text = selectedRow.Cells[2].Value.ToString();
            PceTextBox.Text = selectedRow.Cells[3].Value.ToString();
            DataTextBox.Text = selectedRow.Cells[4].Value.ToString();
        }


        private void ButtonWriteInUser_Click(object sender, EventArgs e)
        {
            string pathRecord = @"records.txt";
            using (StreamWriter stream = new StreamWriter(pathRecord, true))
            {
                stream.Write(IDTextBox.Text + "/" + "\t");
                stream.Write(SvTextBox.Text + "/" + "\t");
                stream.Write(MrTextBox.Text + "/" + "\t");
                stream.Write(PceTextBox.Text + "/" + "\t");
                stream.Write(DataTextBox.Text + "\n");
            }
        }

        public void ButtonMyEntery_Click(object sender, EventArgs e)
        {

            form4.Show();
        }

        private void CheckBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            string pathRecord = @"Masters.txt";
            using (StreamWriter stream = new StreamWriter(pathRecord, true))
            {
                stream.Write(IDTextBox.Text + "/" + "\t");
                stream.Write(SvTextBox.Text + "/" + "\t");
                stream.Write(MrTextBox.Text + "/" + "\t");
                stream.Write(PceTextBox.Text + "/" + "\t");
                stream.Write(DataTextBox.Text + "\n");

                MessageBox.Show("Данные успешно сохранены! Данные о записи храняться в \" Моих записях\"", "Запись");
                selectedRow = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(selectedRow);
            }

            
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    } 
}