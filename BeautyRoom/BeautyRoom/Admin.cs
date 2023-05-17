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
    public partial class Admin : Form
    {


        public Admin()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int selectedRow;


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow;
            table.Rows.Add(textBoxId.Text, textBoxName.Text, textBoxMaster.Text, textBoxPrise.Text, textBoxDate.Text);
            dataGridView1.DataSource = table;
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Название", typeof(string));
            table.Columns.Add("Имя Мастера", typeof(string));
            table.Columns.Add("Цена", typeof(int));
            table.Columns.Add("Дата ", typeof(string));
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



        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);


        }

        private void dataGridViewSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBoxId.Text = row.Cells[0].Value.ToString();
            textBoxName.Text = row.Cells[1].Value.ToString();
            textBoxMaster.Text = row.Cells[2].Value.ToString();
            textBoxPrise.Text = row.Cells[3].Value.ToString();
            textBoxDate.Text = row.Cells[4].Value.ToString();

        }

        private void UpDateButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = textBoxId.Text;
            newDataRow.Cells[1].Value = textBoxName.Text;
            newDataRow.Cells[2].Value = textBoxMaster.Text;
            newDataRow.Cells[3].Value = textBoxPrise.Text;
            newDataRow.Cells[4].Value = textBoxDate.Text;
        }

        private void gunaButtonSave_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("Masters.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == dataGridView1.Columns.Count - 1)
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    else
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "/");
                }
                writer.WriteLine(" ");
            }
            writer.Close();
            MessageBox.Show("Данные сохранены");
        }


    }
}
