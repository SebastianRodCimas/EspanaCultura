using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace EspanaCultura
{
    public partial class Professeur : Form
    {
        string connectionString = @"Server=mysql2.montpellier.epsi.fr;Persistsecurityinfo=true;Database=espanacultura;Uid=rodrigue.cimas;Pwd=915JTK;port=5306;";
        int id;
        public Professeur()
        {
            InitializeComponent();
        }
        private void Professeur_Load_1(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void GridFill()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("ProfesseurViewAll", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgProfesseur.DataSource = dataClasse;
                dvgProfesseur.Columns[0].Visible = true;
            }

        }

        void Clear()
        {
            txtId.Text = txtName.Text = txtPrenom.Text = "";
            id = 0;
           
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text);
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("ProfesseurAdd", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", id);
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_prenom", txtPrenom.Text.Trim());

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succès");
                GridFill();


            }
        }
        private void btnModif_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text);
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {

                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("ProfesseurEdit", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", id);
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_prenom", txtPrenom.Text.Trim());

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Modifié avec succès");
                GridFill();


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

       
            private void btxSupr_Click(object sender, EventArgs e)
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("ProfesseurDelete", mySqlConnection);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("_id", txtId.Text.Trim());
                    mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
                    mySqlCommand.Parameters.AddWithValue("_prenom", txtPrenom.Text.Trim());
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Supprimer avec succès");
                    Clear();
                    GridFill();
                }
            }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("ProfesseurSearch", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("_SearchByValue", txtSearch.Text);
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgProfesseur.DataSource = dataClasse;
                dvgProfesseur.Columns[0].Visible = true;
            }
        }

        private void dvgProfesseur_DoubleClick(object sender, EventArgs e)
        {
            if (dvgProfesseur.CurrentRow.Index != -1)
            {
                txtId.Text = dvgProfesseur.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dvgProfesseur.CurrentRow.Cells[1].Value.ToString();
                txtPrenom.Text = dvgProfesseur.CurrentRow.Cells[2].Value.ToString();
              


            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
            private void dvgProfesseur_CellContentClick(object sender, EventArgs e)
        {

        }

      
    }
}
