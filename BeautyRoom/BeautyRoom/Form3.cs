using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyRoom
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            conteiner(new Masters());

        }
        private void conteiner(object _form) {
            if(gunaPanel3.Controls.Count>0) gunaPanel3.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanel3.Controls.Add(fm);
            gunaPanel3.Tag = fm;
            fm.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            conteiner2(new Service());
        }
        private void conteiner2(object _form)
        {
            if (gunaPanel3.Controls.Count > 0) gunaPanel3.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanel3.Controls.Add(fm);
            gunaPanel3.Tag = fm;
            fm.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            conteiner3(new Date());
        }
        private void conteiner3(object _form)
        {
            if (gunaPanel3.Controls.Count > 0) gunaPanel3.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanel3.Controls.Add(fm);
            gunaPanel3.Tag = fm;
            fm.Show();
        }
    }
}
