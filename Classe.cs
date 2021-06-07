using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EspanaCultura
{
    public partial class Classe : Form
    {
        string connectionString = @"Server=mysql2.montpellier.epsi.fr;Persistsecurityinfo=true;Database=espanacultura;Uid=rodrigue.cimas;Pwd=915JTK;port=5306;";
        int id;
        public Classe()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }
        void GridFill()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("ClasseViewAll", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgClasse.DataSource = dataClasse;
                dvgClasse.Columns[0].Visible = true;
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
                MySqlCommand mySqlCommand = new MySqlCommand("ClasseAddOrEdit", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", id);
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
               
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succès");
                GridFill();
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }
        private void button6_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("ClasseDelete", mySqlConnection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_id", txtId.Text.Trim());
                mySqlCommand.Parameters.AddWithValue("_nom", txtName.Text.Trim());
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
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("ClasseSearch", mySqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
               
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("_SearchByValue", txtSearch.Text);
                DataTable dataClasse = new DataTable();
                sqlDataAdapter.Fill(dataClasse);
                dvgClasse.DataSource = dataClasse;
                dvgClasse.Columns[0].Visible = true;
                
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


        private void dvgClasse_DoubleClick(object sender, EventArgs e)
        {
            if(dvgClasse.CurrentRow.Index != -1)
            {
                txtId.Text = dvgClasse.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dvgClasse.CurrentRow.Cells[1].Value.ToString();
                btnSave.Text = "Modifier";
               
                    
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dvgClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
       

       
    }
   
}
