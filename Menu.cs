using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EspanaCultura
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void buttonclasse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classe f1 = new Classe();
            f1.ShowDialog();
            
        }
       

        private void buttonmatiere_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Matiere f3 = new Matiere();
            f3.ShowDialog();
        }

        private void buttonprofesseur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Professeur f4 = new Professeur();
            f4.ShowDialog();
        }

        private void buttonetudiant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Etudiant f5 = new Etudiant();
            f5.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
