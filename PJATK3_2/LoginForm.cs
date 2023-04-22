using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJATK3_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text == "" || hasloTextBox.Text == "")
            {
                MessageBox.Show("Wprowadź login i hasło");
                return;
            }
            var sql = $"select * from osoba where login ='{loginTextBox.Text}' and haslo = '{hasloTextBox.Text}'";
        }
    }
}
