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
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }
        private void Masters_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void Masters_Load(object sender, EventArgs e)
        {

        }
    }
}
