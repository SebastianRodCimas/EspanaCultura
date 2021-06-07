
namespace EspanaCultura
{
    partial class Matiere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matiere));
            this.dvgMatiere = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btxSupr = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.TitleId = new System.Windows.Forms.Label();
            this.TitleName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgMatiere
            // 
            this.dvgMatiere.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dvgMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatiere.GridColor = System.Drawing.SystemColors.Highlight;
            this.dvgMatiere.Location = new System.Drawing.Point(294, 64);
            this.dvgMatiere.Name = "dvgMatiere";
            this.dvgMatiere.Size = new System.Drawing.Size(484, 275);
            this.dvgMatiere.TabIndex = 4;
            this.dvgMatiere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClasse_CellContentClick);
            this.dvgMatiere.DoubleClick += new System.EventHandler(this.dvgMatiere_DoubleClick_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(56, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btxSupr
            // 
            this.btxSupr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btxSupr.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btxSupr.ForeColor = System.Drawing.Color.White;
            this.btxSupr.Location = new System.Drawing.Point(640, 362);
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
            this.btnCancel.Location = new System.Drawing.Point(351, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 52);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.Font = new System.Drawing.Font("Lato", 10.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(578, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 42);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(403, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 21);
            this.txtSearch.TabIndex = 16;
            // 
            // TitleId
            // 
            this.TitleId.AutoSize = true;
            this.TitleId.BackColor = System.Drawing.Color.White;
            this.TitleId.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleId.ForeColor = System.Drawing.Color.Orange;
            this.TitleId.Location = new System.Drawing.Point(52, 121);
            this.TitleId.Name = "TitleId";
            this.TitleId.Size = new System.Drawing.Size(26, 23);
            this.TitleId.TabIndex = 19;
            this.TitleId.Text = "Id";
            this.TitleId.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.BackColor = System.Drawing.Color.White;
            this.TitleName.Font = new System.Drawing.Font("Lato", 14.25F);
            this.TitleName.ForeColor = System.Drawing.Color.Orange;
            this.TitleName.Location = new System.Drawing.Point(52, 191);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(52, 23);
            this.TitleName.TabIndex = 23;
            this.TitleName.Text = "Nom";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(127, 126);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 23);
            this.txtId.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 191);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 26);
            this.txtName.TabIndex = 25;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Font = new System.Drawing.Font("Lato", 11.25F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(22, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 52);
            this.btnMenu.TabIndex = 30;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // Matiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.TitleName);
            this.Controls.Add(this.TitleId);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btxSupr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dvgMatiere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matiere";
            this.Text = "Matiere - Espana Cultura ";
            this.Load += new System.EventHandler(this.Matiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgMatiere;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btxSupr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label TitleId;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnMenu;
    }
}