
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etudiant));
            this.btnSave = new System.Windows.Forms.Button();
            this.btxSupr = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dvgEtudiant = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TitleId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TitleName = new System.Windows.Forms.Label();
            this.txtIdClasse = new System.Windows.Forms.TextBox();
            this.txtIdClasseS = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TitleIdClasseS = new System.Windows.Forms.Label();
            this.TitlePrenom = new System.Windows.Forms.Label();
            this.TitleIdClasse = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(51, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btxSupr
            // 
            this.btxSupr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btxSupr.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btxSupr.ForeColor = System.Drawing.Color.White;
            this.btxSupr.Location = new System.Drawing.Point(640, 370);
            this.btxSupr.Name = "btxSupr";
            this.btxSupr.Size = new System.Drawing.Size(112, 52);
            this.btxSupr.TabIndex = 11;
            this.btxSupr.Text = "Supprimer";
            this.btxSupr.UseVisualStyleBackColor = false;
            this.btxSupr.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(430, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 52);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // dvgEtudiant
            // 
            this.dvgEtudiant.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dvgEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEtudiant.GridColor = System.Drawing.SystemColors.Highlight;
            this.dvgEtudiant.Location = new System.Drawing.Point(304, 67);
            this.dvgEtudiant.Name = "dvgEtudiant";
            this.dvgEtudiant.Size = new System.Drawing.Size(484, 275);
            this.dvgEtudiant.TabIndex = 13;
            this.dvgEtudiant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClasse_CellContentClick);
            this.dvgEtudiant.DoubleClick += new System.EventHandler(this.dvgEtudiant_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(348, 22);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 21);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(573, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 42);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // TitleId
            // 
            this.TitleId.AutoSize = true;
            this.TitleId.BackColor = System.Drawing.Color.White;
            this.TitleId.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleId.ForeColor = System.Drawing.Color.Orange;
            this.TitleId.Location = new System.Drawing.Point(3, 67);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(26, 23);
            this.TitleId.TabIndex = 19;
            this.TitleId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 67);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 21);
            this.txtId.TabIndex = 20;
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.BackColor = System.Drawing.Color.White;
            this.TitleName.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleName.ForeColor = System.Drawing.Color.Orange;
            this.TitleName.Location = new System.Drawing.Point(3, 188);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(52, 23);
            this.TitleName.TabIndex = 21;
            this.TitleName.Text = "Nom";
            this.TitleName.Click += new System.EventHandler(this.label2_Click);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 193);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 25;
            // 
            // TitleIdClasseS
            // 
            this.TitleIdClasseS.AutoSize = true;
            this.TitleIdClasseS.BackColor = System.Drawing.Color.White;
            this.TitleIdClasseS.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleIdClasseS.ForeColor = System.Drawing.Color.Orange;
            this.TitleIdClasseS.Location = new System.Drawing.Point(3, 305);
            this.TitleIdClasseS.Name = "TitleIdClasseS";
            this.TitleIdClasseS.Size = new System.Drawing.Size(154, 23);
            this.TitleIdClasseS.TabIndex = 26;
            this.TitleIdClasseS.Text = "IdClasseSeTrouve";
            // 
            // TitlePrenom
            // 
            this.TitlePrenom.AutoSize = true;
            this.TitlePrenom.BackColor = System.Drawing.Color.White;
            this.TitlePrenom.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitlePrenom.ForeColor = System.Drawing.Color.Orange;
            this.TitlePrenom.Location = new System.Drawing.Point(3, 250);
            this.TitlePrenom.Name = "TitlePrenom";
            this.TitlePrenom.Size = new System.Drawing.Size(76, 23);
            this.TitlePrenom.TabIndex = 27;
            this.TitlePrenom.Text = "Prénom";
            // 
            // TitleIdClasse
            // 
            this.TitleIdClasse.AutoSize = true;
            this.TitleIdClasse.BackColor = System.Drawing.Color.White;
            this.TitleIdClasse.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleIdClasse.ForeColor = System.Drawing.Color.Orange;
            this.TitleIdClasse.Location = new System.Drawing.Point(1, 138);
            this.TitleIdClasse.Name = "TitleIdClasse";
            this.TitleIdClasse.Size = new System.Drawing.Size(78, 23);
            this.TitleIdClasse.TabIndex = 28;
            this.TitleIdClasse.Text = "IdClasse";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(26, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 52);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModif.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(243, 370);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(106, 52);
            this.btnModif.TabIndex = 34;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.TitleIdClasse);
            this.Controls.Add(this.TitlePrenom);
            this.Controls.Add(this.TitleIdClasseS);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtIdClasseS);
            this.Controls.Add(this.txtIdClasse);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.TitleId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dvgEtudiant);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btxSupr);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Etudiant";
            this.Text = "Etudiant - Espana Cultura";
            this.Load += new System.EventHandler(this.Etudiant_Load);
            this.DoubleClick += new System.EventHandler(this.Etudiant_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btxSupr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dvgEtudiant;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label TitleId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.TextBox txtIdClasse;
        private System.Windows.Forms.TextBox txtIdClasseS;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label TitleIdClasseS;
        private System.Windows.Forms.Label TitlePrenom;
        private System.Windows.Forms.Label TitleIdClasse;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnModif;
    }
}