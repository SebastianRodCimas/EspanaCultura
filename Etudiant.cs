using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EspanaCultura
{
    public partial class Etudiant : Form
    {
        string connectionString = @"Server=mysql2.montpellier.epsi.fr;Persistsecurityinfo=true;Database=espanacultura;Uid=rodrigue.cimas;Pwd=915JTK;port=5306;";
        int id;
        public Etudiant()
        {
            InitializeComponent();
        }
        private void Etudiant_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();

        }
        void GridFill()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("EtudiantViewAll", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgEtudiant.DataSource = dataClasse;
                dvgEtudiant.Columns[0].Visible = true;
            }

        }

        void Clear()
        {
            txtId.Text = txtIdClasse.Text =txtName.Text = txtPrenom.Text = txtIdClasseS.Text ="";
            id = 0;
          

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text);
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("EtudiantAdd", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", id);
                mySqlCommand.Parameters.AddWithValue("_id_classe", txtIdClasse.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_prenom", txtPrenom.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_ID_classe_Se_Trouve", txtIdClasseS.Text.Trim());

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
                MySqlCommand mySqlCommand = new MySqlCommand("EtudiantEdit", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", id);
                mySqlCommand.Parameters.AddWithValue("_id_classe", txtIdClasse.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_prenom", txtPrenom.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_ID_classe_Se_Trouve", txtIdClasseS.Text.Trim());

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Modifié avec succès");
                GridFill();


            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("EtudiantDelete", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", txtId.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_id_classe", txtIdClasse.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_prenom", txtPrenom.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_ID_classe_Se_Trouve", txtIdClasseS.Text.Trim());
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Supprimer avec succès");
                Clear();
                GridFill();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("EtudiantSearch", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("_SearchByValue", txtSearch.Text);
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgEtudiant.DataSource = dataClasse;
                dvgEtudiant.Columns[0].Visible = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void dvgEtudiant_DoubleClick(object sender, EventArgs e)
        {
            if (dvgEtudiant.CurrentRow.Index != -1)
            {
                txtId.Text = dvgEtudiant.CurrentRow.Cells[0].Value.ToString();
                txtIdClasse.Text = dvgEtudiant.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dvgEtudiant.CurrentRow.Cells[2].Value.ToString();
                txtPrenom.Text = dvgEtudiant.CurrentRow.Cells[3].Value.ToString();
                txtIdClasseS.Text = dvgEtudiant.CurrentRow.Cells[4].Value.ToString();
               


            }
        }
        private void Etudiant_DoubleClick(object sender, EventArgs e)
        {
            if (dvgEtudiant.CurrentRow.Index != -1)
            {
                txtId.Text = dvgEtudiant.CurrentRow.Cells[0].Value.ToString();
                txtIdClasse.Text = dvgEtudiant.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dvgEtudiant.CurrentRow.Cells[2].Value.ToString();
                txtPrenom.Text = dvgEtudiant.CurrentRow.Cells[3].Value.ToString();
                txtIdClasseS.Text = dvgEtudiant.CurrentRow.Cells[4].Value.ToString();
               


            }
        }
        private void dvgClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
