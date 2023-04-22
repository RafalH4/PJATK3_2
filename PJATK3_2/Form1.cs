namespace PJATK3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dzia³a");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = button1.Text + "AA";
        }
    }
}