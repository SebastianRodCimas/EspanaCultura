
namespace EspanaCultura
{
    partial class Professeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professeur));
            this.dvgProfesseur = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btxSupr = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TitleId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TitleName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TitlePrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProfesseur
            // 
            this.dvgProfesseur.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dvgProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProfesseur.GridColor = System.Drawing.SystemColors.Highlight;
            this.dvgProfesseur.Location = new System.Drawing.Point(328, 68);
            this.dvgProfesseur.Name = "dvgProfesseur";
            this.dvgProfesseur.Size = new System.Drawing.Size(458, 275);
            this.dvgProfesseur.TabIndex = 4;
            this.dvgProfesseur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProfesseur_CellContentClick);
            this.dvgProfesseur.DoubleClick += new System.EventHandler(this.dvgProfesseur_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(35, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btxSupr
            // 
            this.btxSupr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btxSupr.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btxSupr.ForeColor = System.Drawing.Color.White;
            this.btxSupr.Location = new System.Drawing.Point(632, 358);
            this.btxSupr.Name = "btxSupr";
            this.btxSupr.Size = new System.Drawing.Size(112, 52);
            this.btxSupr.TabIndex = 12;
            this.btxSupr.Text = "Supprimer";
            this.btxSupr.UseVisualStyleBackColor = false;
            this.btxSupr.Click += new System.EventHandler(this.btxSupr_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(429, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 52);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(360, 32);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 21);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(534, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 42);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TitleId
            // 
            this.TitleId.AutoSize = true;
            this.TitleId.BackColor = System.Drawing.Color.White;
            this.TitleId.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleId.ForeColor = System.Drawing.Color.Orange;
            this.TitleId.Location = new System.Drawing.Point(54, 110);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(26, 23);
            this.TitleId.TabIndex = 18;
            this.TitleId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 110);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 23);
            this.txtId.TabIndex = 19;
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.BackColor = System.Drawing.Color.White;
            this.TitleName.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleName.ForeColor = System.Drawing.Color.Orange;
            this.TitleName.Location = new System.Drawing.Point(54, 167);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(52, 23);
            this.TitleName.TabIndex = 22;
            this.TitleName.Text = "Nom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 167);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 26);
            this.txtName.TabIndex = 23;
            // 
            // TitlePrenom
            // 
            this.TitlePrenom.AutoSize = true;
            this.TitlePrenom.BackColor = System.Drawing.Color.White;
            this.TitlePrenom.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitlePrenom.ForeColor = System.Drawing.Color.Orange;
            this.TitlePrenom.Location = new System.Drawing.Point(54, 215);
            this.TitlePrenom.Name = "TitlePrenom";
            this.TitlePrenom.Size = new System.Drawing.Size(76, 23);
            this.TitlePrenom.TabIndex = 24;
            this.TitlePrenom.Text = "Prénom";
            this.TitlePrenom.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(136, 215);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(133, 26);
            this.txtPrenom.TabIndex = 25;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(35, 20);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 52);
            this.btnMenu.TabIndex = 30;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModif.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(229, 358);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(106, 52);
            this.btnModif.TabIndex = 35;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // Professeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.TitlePrenom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.TitleId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btxSupr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dvgProfesseur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Professeur";
            this.Text = "Professeur - Espana Cultura";
            this.Load += new System.EventHandler(this.Professeur_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProfesseur;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btxSupr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label TitleId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label TitlePrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnModif;
    }
}