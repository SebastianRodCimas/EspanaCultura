
namespace EspanaCultura
{
    partial class Etudiant
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dvgClasse = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.txtIdClasse = new System.Windows.Forms.TextBox();
            this.txtIdClasseS = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labelIdClasseS = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelIdClasse = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Lato", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Lato", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(185, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Lato", 10.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(348, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dvgClasse
            // 
            this.dvgClasse.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dvgClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClasse.GridColor = System.Drawing.SystemColors.Highlight;
            this.dvgClasse.Location = new System.Drawing.Point(304, 67);
            this.dvgClasse.Name = "dvgClasse";
            this.dvgClasse.Size = new System.Drawing.Size(484, 275);
            this.dvgClasse.TabIndex = 13;
            this.dvgClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClasse_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(348, 22);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 21);
            this.txtSearch.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.Font = new System.Drawing.Font("Lato", 10.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(573, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Rechercher";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.White;
            this.labelId.Font = new System.Drawing.Font("Lato", 14.25F);
            this.labelId.ForeColor = System.Drawing.Color.Orange;
            this.labelId.Location = new System.Drawing.Point(3, 67);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 23);
            this.labelId.TabIndex = 19;
            this.labelId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 67);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 21);
            this.txtId.TabIndex = 20;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.White;
            this.labelNom.Font = new System.Drawing.Font("Lato", 14.25F);
            this.labelNom.ForeColor = System.Drawing.Color.Orange;
            this.labelNom.Location = new System.Drawing.Point(3, 188);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(52, 23);
            this.labelNom.TabIndex = 21;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdClasse
            // 
            this.txtIdClasse.Location = new System.Drawing.Point(109, 140);
            this.txtIdClasse.Multiline = true;
            this.txtIdClasse.Name = "txtIdClasse";
            this.txtIdClasse.Size = new System.Drawing.Size(121, 21);
            this.txtIdClasse.TabIndex = 22;
            // 
            // txtIdClasseS
            // 
            this.txtIdClasseS.Location = new System.Drawing.Point(163, 307);
            this.txtIdClasseS.Multiline = true;
            this.txtIdClasseS.Name = "txtIdClasseS";
            this.txtIdClasseS.Size = new System.Drawing.Size(87, 21);
            this.txtIdClasseS.TabIndex = 23;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(109, 252);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 21);
            this.txtPrenom.TabIndex = 24;
            this.txtPrenom.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(109, 193);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 21);
            this.txtNom.TabIndex = 25;
            // 
            // labelIdClasseS
            // 
            this.labelIdClasseS.AutoSize = true;
            this.labelIdClasseS.BackColor = System.Drawing.Color.White;
            this.labelIdClasseS.Font = new System.Drawing.Font("Lato", 14.25F);
            this.labelIdClasseS.ForeColor = System.Drawing.Color.Orange;
            this.labelIdClasseS.Location = new System.Drawing.Point(3, 305);
            this.labelIdClasseS.Name = "labelIdClasseS";
            this.labelIdClasseS.Size = new System.Drawing.Size(154, 23);
            this.labelIdClasseS.TabIndex = 26;
            this.labelIdClasseS.Text = "IdClasseSeTrouve";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.White;
            this.labelPrenom.Font = new System.Drawing.Font("Lato", 14.25F);
            this.labelPrenom.ForeColor = System.Drawing.Color.Orange;
            this.labelPrenom.Location = new System.Drawing.Point(3, 250);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(76, 23);
            this.labelPrenom.TabIndex = 27;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelIdClasse
            // 
            this.labelIdClasse.AutoSize = true;
            this.labelIdClasse.BackColor = System.Drawing.Color.White;
            this.labelIdClasse.Font = new System.Drawing.Font("Lato", 14.25F);
            this.labelIdClasse.ForeColor = System.Drawing.Color.Orange;
            this.labelIdClasse.Location = new System.Drawing.Point(1, 138);
            this.labelIdClasse.Name = "labelIdClasse";
            this.labelIdClasse.Size = new System.Drawing.Size(78, 23);
            this.labelIdClasse.TabIndex = 28;
            this.labelIdClasse.Text = "IdClasse";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Lato", 11.25F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(26, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 52);
            this.button5.TabIndex = 29;
            this.button5.Text = "Menu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelIdClasse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelIdClasseS);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtIdClasseS);
            this.Controls.Add(this.txtIdClasse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dvgClasse);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Etudiant";
            this.Text = "Etudiant - Espana Cultura";
            ((System.ComponentModel.ISupportInitialize)(this.dvgClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dvgClasse;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox txtIdClasse;
        private System.Windows.Forms.TextBox txtIdClasseS;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labelIdClasseS;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelIdClasse;
        private System.Windows.Forms.Button button5;
    }
}