using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace EspanaCultura
{
    public partial class Professeur : Form
    {
        public Professeur()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
