using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EspanaCultura
{
    public partial class Matiere : Form
    {
        string connectionString = @"Server=mysql2.montpellier.epsi.fr;Persistsecurityinfo=true;Database=espanacultura;Uid=rodrigue.cimas;Pwd=915JTK;port=5306;";
        int id;
        public Matiere()
        {
            InitializeComponent();
        }
        void GridFill()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("MatiereViewAll", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgClasse.DataSource = dataClasse;
                dvgClasse.Columns[0].Visible = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridFill();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
