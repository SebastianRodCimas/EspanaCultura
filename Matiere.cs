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
        private void Matiere_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
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
                dvgMatiere.DataSource = dataClasse;
                dvgMatiere.Columns[0].Visible = true;
            }

        }
       
        void Clear()
        {
            txtId.Text = txtName.Text = "";
            id = 0;
            btnSave.Text = "Sauvegarder";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text);
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("MatiereAddOrEdit", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", id);
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succès");
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
                MySqlCommand mySqlCommand = new MySqlCommand("MatiereDelete", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", txtId.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
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
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("MatiereSearch", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("_SearchByValue", txtSearch.Text);
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgMatiere.DataSource = dataClasse;
                dvgMatiere.Columns[0].Visible = true;
            }
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void dvgMatiere_DoubleClick_1(object sender, EventArgs e)
        {
            if (dvgMatiere.CurrentRow.Index != -1)
            {
                txtId.Text = dvgMatiere.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dvgMatiere.CurrentRow.Cells[1].Value.ToString();
                btnSave.Text = "Modifier";


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
