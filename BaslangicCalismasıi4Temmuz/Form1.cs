namespace BaslangicCalismasıi4Temmuz
{
    public partial class Form1 : Form
    {
        public string name;
        public Form1()
        {
            InitializeComponent();
            label1.Text += " " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BU BIR TEST PROGRAMIDIR");
            listBox1.Items.Clear();
            listBox1.Items.Add("item 1");
            listBox1.Items.Add("item 2");
            listBox1.Items.Add("item 3");
            listBox1.Items.Add("item 4");
            listBox1.Items.Add("item 5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = name;
        }
    }
}