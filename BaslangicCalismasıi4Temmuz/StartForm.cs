using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaslangicCalismasıi4Temmuz
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                Form1 form1 = new Form1();
                form1.name = textBox1.Text;
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen isminizi giriniz...");
            }
        }
    }
}
