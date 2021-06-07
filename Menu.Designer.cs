
namespace EspanaCultura
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.titre = new System.Windows.Forms.Label();
            this.buttonclasse = new System.Windows.Forms.Button();
            this.buttonmatiere = new System.Windows.Forms.Button();
            this.buttonprofesseur = new System.Windows.Forms.Button();
            this.buttonetudiant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titre.Font = new System.Drawing.Font("Lato", 14.25F);
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titre.Location = new System.Drawing.Point(575, 61);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(131, 23);
            this.titre.TabIndex = 0;
            this.titre.Text = "EspanaCultura";
            this.titre.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonclasse
            // 
            this.buttonclasse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonclasse.Font = new System.Drawing.Font("Lato", 9.75F);
            this.buttonclasse.Location = new System.Drawing.Point(361, 144);
            this.buttonclasse.Name = "buttonclasse";
            this.buttonclasse.Size = new System.Drawing.Size(138, 54);
            this.buttonclasse.TabIndex = 1;
            this.buttonclasse.Text = "Gestion des classes";
            this.buttonclasse.UseVisualStyleBackColor = false;
            this.buttonclasse.Click += new System.EventHandler(this.buttonclasse_Click);
            // 
            // buttonmatiere
            // 
            this.buttonmatiere.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonmatiere.Font = new System.Drawing.Font("Lato", 9.75F);
            this.buttonmatiere.ForeColor = System.Drawing.Color.Black;
            this.buttonmatiere.Location = new System.Drawing.Point(777, 144);
            this.buttonmatiere.Name = "buttonmatiere";
            this.buttonmatiere.Size = new System.Drawing.Size(138, 54);
            this.buttonmatiere.TabIndex = 2;
            this.buttonmatiere.Text = "Gestion des matières";
            this.buttonmatiere.UseVisualStyleBackColor = false;
            this.buttonmatiere.Click += new System.EventHandler(this.buttonmatiere_Click_1);
            // 
            // buttonprofesseur
            // 
            this.buttonprofesseur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonprofesseur.Font = new System.Drawing.Font("Lato", 9.75F);
            this.buttonprofesseur.Location = new System.Drawing.Point(361, 493);
            this.buttonprofesseur.Name = "buttonprofesseur";
            this.buttonprofesseur.Size = new System.Drawing.Size(138, 54);
            this.buttonprofesseur.TabIndex = 3;
            this.buttonprofesseur.Text = "Gestion des professeurs";
            this.buttonprofesseur.UseVisualStyleBackColor = false;
            this.buttonprofesseur.Click += new System.EventHandler(this.buttonprofesseur_Click);
            // 
            // buttonetudiant
            // 
            this.buttonetudiant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonetudiant.Font = new System.Drawing.Font("Lato", 9.75F);
            this.buttonetudiant.Location = new System.Drawing.Point(777, 493);
            this.buttonetudiant.Name = "buttonetudiant";
            this.buttonetudiant.Size = new System.Drawing.Size(138, 54);
            this.buttonetudiant.TabIndex = 4;
            this.buttonetudiant.Text = "Gestion des étudiants";
            this.buttonetudiant.UseVisualStyleBackColor = false;
            this.buttonetudiant.Click += new System.EventHandler(this.buttonetudiant_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1268, 621);
            this.Controls.Add(this.buttonetudiant);
            this.Controls.Add(this.buttonprofesseur);
            this.Controls.Add(this.buttonmatiere);
            this.Controls.Add(this.buttonclasse);
            this.Controls.Add(this.titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = " Menu - EspanaCultura ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button buttonmatiere;
        private System.Windows.Forms.Button buttonprofesseur;
        private System.Windows.Forms.Button buttonetudiant;
        private System.Windows.Forms.Button buttonclasse;
    }
}