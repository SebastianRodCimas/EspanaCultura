
namespace EspanaCultura
{
    partial class Classe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classe));
            this.TitleId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dvgClasse = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.TitleName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btxSupr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleId
            // 
            this.TitleId.AutoSize = true;
            this.TitleId.BackColor = System.Drawing.Color.White;
            this.TitleId.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleId.ForeColor = System.Drawing.Color.Orange;
            this.TitleId.Location = new System.Drawing.Point(47, 142);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(26, 23);
            this.TitleId.TabIndex = 0;
            this.TitleId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 148);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(51, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 52);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgClasse
            // 
            this.dvgClasse.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dvgClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClasse.GridColor = System.Drawing.SystemColors.Highlight;
            this.dvgClasse.Location = new System.Drawing.Point(304, 95);
            this.dvgClasse.Name = "dvgClasse";
            this.dvgClasse.Size = new System.Drawing.Size(484, 275);
            this.dvgClasse.TabIndex = 3;
            this.dvgClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClasse_CellContentClick);
            this.dvgClasse.DoubleClick += new System.EventHandler(this.dvgClasse_DoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 225);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.BackColor = System.Drawing.Color.White;
            this.TitleName.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleName.ForeColor = System.Drawing.Color.Orange;
            this.TitleName.Location = new System.Drawing.Point(47, 225);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(52, 23);
            this.TitleName.TabIndex = 4;
            this.TitleName.Text = "Nom";
            this.TitleName.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(325, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 52);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(553, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 42);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(384, 57);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 21);
            this.txtSearch.TabIndex = 15;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(30, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 52);
            this.btnMenu.TabIndex = 30;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // btxSupr
            // 
            this.btxSupr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btxSupr.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btxSupr.ForeColor = System.Drawing.Color.White;
            this.btxSupr.Location = new System.Drawing.Point(612, 376);
            this.btxSupr.Name = "btxSupr";
            this.btxSupr.Size = new System.Drawing.Size(109, 52);
            this.btxSupr.TabIndex = 32;
            this.btxSupr.Text = "Supprimer";
            this.btxSupr.UseVisualStyleBackColor = false;
            this.btxSupr.Click += new System.EventHandler(this.button6_Click);
            // 
            // Classe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btxSupr);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.dvgClasse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.TitleId);
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Classe";
            this.Text = "Classe - EspanaCultura ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dvgClasse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btxSupr;
    }
}

