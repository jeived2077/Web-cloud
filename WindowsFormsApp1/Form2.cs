using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yandex_Click(object sender, EventArgs e)
        {
            yandex form1 = new yandex();
            form1.ShowDialog();
            this.Close();
        }

        private void mailru_Click(object sender, EventArgs e)
        {
            dropbox mailform = new dropbox();
            mailform.ShowDialog();
            this.Close();
        }

        private void google_Click(object sender, EventArgs e)
        {
            onedrive google = new onedrive();
            google.ShowDialog();
            this.Close();

        }

        private void cloudmailru_Click(object sender, EventArgs e)
        {
            mailru google = new mailru();
            google.ShowDialog();
            this.Close();
        }
    }
}
