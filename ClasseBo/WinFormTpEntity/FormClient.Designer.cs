namespace WinFormTpEntity
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centreInformatiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.gbcreer = new System.Windows.Forms.GroupBox();
            this.btnann = new System.Windows.Forms.Button();
            this.btncreer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCent = new System.Windows.Forms.GroupBox();
            this.dgvcent = new System.Windows.Forms.DataGridView();
            this.numclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndgvcent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndgvmodif = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btndgvsupp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numcentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressecentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cplcentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villecentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcentreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbcont = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).BeginInit();
            this.gbcreer.SuspendLayout();
            this.gbCent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afficher les clients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numclientDataGridViewTextBoxColumn,
            this.nomclientDataGridViewTextBoxColumn,
            this.adresseclientDataGridViewTextBoxColumn,
            this.cpclientDataGridViewTextBoxColumn,
            this.villeclientDataGridViewTextBoxColumn,
            this.telclientDataGridViewTextBoxColumn,
            this.btndgvcent,
            this.btndgvmodif,
            this.btndgvsupp});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Client);
            // 
            // centreInformatiqueBindingSource
            // 
            this.centreInformatiqueBindingSource.DataSource = typeof(CentreInformatique);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(107, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 13);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(107, 27);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 4;
            // 
            // txtadr
            // 
            this.txtadr.Location = new System.Drawing.Point(107, 54);
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(100, 20);
            this.txtadr.TabIndex = 5;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(107, 81);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(100, 20);
            this.txtcp.TabIndex = 6;
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(107, 108);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(100, 20);
            this.txtville.TabIndex = 7;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(107, 135);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Code Postal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Téléphone :";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(251, 132);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gbcreer
            // 
            this.gbcreer.Controls.Add(this.btnann);
            this.gbcreer.Controls.Add(this.txttel);
            this.gbcreer.Controls.Add(this.btnadd);
            this.gbcreer.Controls.Add(this.txtnom);
            this.gbcreer.Controls.Add(this.label6);
            this.gbcreer.Controls.Add(this.txtadr);
            this.gbcreer.Controls.Add(this.label5);
            this.gbcreer.Controls.Add(this.txtcp);
            this.gbcreer.Controls.Add(this.label4);
            this.gbcreer.Controls.Add(this.txtville);
            this.gbcreer.Controls.Add(this.label3);
            this.gbcreer.Controls.Add(this.label2);
            this.gbcreer.Location = new System.Drawing.Point(12, 230);
            this.gbcreer.Name = "gbcreer";
            this.gbcreer.Size = new System.Drawing.Size(340, 174);
            this.gbcreer.TabIndex = 15;
            this.gbcreer.TabStop = false;
            this.gbcreer.Visible = false;
            // 
            // btnann
            // 
            this.btnann.Location = new System.Drawing.Point(251, 98);
            this.btnann.Name = "btnann";
            this.btnann.Size = new System.Drawing.Size(75, 23);
            this.btnann.TabIndex = 15;
            this.btnann.Text = "Annuler";
            this.btnann.UseVisualStyleBackColor = true;
            this.btnann.Click += new System.EventHandler(this.btnann_Click);
            // 
            // btncreer
            // 
            this.btncreer.Location = new System.Drawing.Point(12, 203);
            this.btncreer.Name = "btncreer";
            this.btncreer.Size = new System.Drawing.Size(75, 23);
            this.btncreer.TabIndex = 16;
            this.btncreer.Text = "Creer";
            this.btncreer.UseVisualStyleBackColor = true;
            this.btncreer.Click += new System.EventHandler(this.btncreer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(325, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "MaintInfo";
            // 
            // gbCent
            // 
            this.gbCent.Controls.Add(this.dgvcent);
            this.gbCent.Location = new System.Drawing.Point(372, 230);
            this.gbCent.Name = "gbCent";
            this.gbCent.Size = new System.Drawing.Size(541, 173);
            this.gbCent.TabIndex = 18;
            this.gbCent.TabStop = false;
            this.gbCent.Text = "Centres";
            this.gbCent.Visible = false;
            // 
            // dgvcent
            // 
            this.dgvcent.AllowUserToAddRows = false;
            this.dgvcent.AllowUserToDeleteRows = false;
            this.dgvcent.AutoGenerateColumns = false;
            this.dgvcent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numcentreDataGridViewTextBoxColumn,
            this.adressecentreDataGridViewTextBoxColumn,
            this.cplcentreDataGridViewTextBoxColumn,
            this.villecentreDataGridViewTextBoxColumn,
            this.telcentreDataGridViewTextBoxColumn,
            this.cbbcont});
            this.dgvcent.DataSource = this.centreInformatiqueBindingSource;
            this.dgvcent.Location = new System.Drawing.Point(7, 27);
            this.dgvcent.Name = "dgvcent";
            this.dgvcent.ReadOnly = true;
            this.dgvcent.Size = new System.Drawing.Size(528, 139);
            this.dgvcent.TabIndex = 0;
            // 
            // numclientDataGridViewTextBoxColumn
            // 
            this.numclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numclientDataGridViewTextBoxColumn.DataPropertyName = "num_client";
            this.numclientDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numclientDataGridViewTextBoxColumn.Name = "numclientDataGridViewTextBoxColumn";
            this.numclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.numclientDataGridViewTextBoxColumn.Width = 54;
            // 
            // nomclientDataGridViewTextBoxColumn
            // 
            this.nomclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomclientDataGridViewTextBoxColumn.DataPropertyName = "nom_client";
            this.nomclientDataGridViewTextBoxColumn.HeaderText = "Raison Sociale";
            this.nomclientDataGridViewTextBoxColumn.Name = "nomclientDataGridViewTextBoxColumn";
            this.nomclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomclientDataGridViewTextBoxColumn.Width = 95;
            // 
            // adresseclientDataGridViewTextBoxColumn
            // 
            this.adresseclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adresseclientDataGridViewTextBoxColumn.DataPropertyName = "adresse_client";
            this.adresseclientDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseclientDataGridViewTextBoxColumn.Name = "adresseclientDataGridViewTextBoxColumn";
            this.adresseclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseclientDataGridViewTextBoxColumn.Width = 70;
            // 
            // cpclientDataGridViewTextBoxColumn
            // 
            this.cpclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cpclientDataGridViewTextBoxColumn.DataPropertyName = "cp_client";
            this.cpclientDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.cpclientDataGridViewTextBoxColumn.Name = "cpclientDataGridViewTextBoxColumn";
            this.cpclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpclientDataGridViewTextBoxColumn.Width = 81;
            // 
            // villeclientDataGridViewTextBoxColumn
            // 
            this.villeclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.villeclientDataGridViewTextBoxColumn.DataPropertyName = "ville_client";
            this.villeclientDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeclientDataGridViewTextBoxColumn.Name = "villeclientDataGridViewTextBoxColumn";
            this.villeclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeclientDataGridViewTextBoxColumn.Width = 51;
            // 
            // telclientDataGridViewTextBoxColumn
            // 
            this.telclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telclientDataGridViewTextBoxColumn.DataPropertyName = "tel_client";
            this.telclientDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telclientDataGridViewTextBoxColumn.Name = "telclientDataGridViewTextBoxColumn";
            this.telclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.telclientDataGridViewTextBoxColumn.Width = 83;
            // 
            // btndgvcent
            // 
            this.btndgvcent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btndgvcent.HeaderText = "Centres";
            this.btndgvcent.Name = "btndgvcent";
            this.btndgvcent.ReadOnly = true;
            this.btndgvcent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btndgvcent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btndgvcent.Text = "Afficher";
            this.btndgvcent.UseColumnTextForButtonValue = true;
            this.btndgvcent.Width = 68;
            // 
            // btndgvmodif
            // 
            this.btndgvmodif.HeaderText = "";
            this.btndgvmodif.Name = "btndgvmodif";
            this.btndgvmodif.ReadOnly = true;
            this.btndgvmodif.Text = "Modifier";
            this.btndgvmodif.UseColumnTextForButtonValue = true;
            // 
            // btndgvsupp
            // 
            this.btndgvsupp.HeaderText = "";
            this.btndgvsupp.Name = "btndgvsupp";
            this.btndgvsupp.ReadOnly = true;
            this.btndgvsupp.Text = "Supprimer";
            this.btndgvsupp.UseColumnTextForButtonValue = true;
            // 
            // contratBindingSource
            // 
            this.contratBindingSource.DataSource = typeof(Contrat);
            // 
            // numcentreDataGridViewTextBoxColumn
            // 
            this.numcentreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numcentreDataGridViewTextBoxColumn.DataPropertyName = "num_centre";
            this.numcentreDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numcentreDataGridViewTextBoxColumn.Name = "numcentreDataGridViewTextBoxColumn";
            this.numcentreDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcentreDataGridViewTextBoxColumn.Width = 54;
            // 
            // adressecentreDataGridViewTextBoxColumn
            // 
            this.adressecentreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adressecentreDataGridViewTextBoxColumn.DataPropertyName = "adresse_centre";
            this.adressecentreDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adressecentreDataGridViewTextBoxColumn.Name = "adressecentreDataGridViewTextBoxColumn";
            this.adressecentreDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressecentreDataGridViewTextBoxColumn.Width = 70;
            // 
            // cplcentreDataGridViewTextBoxColumn
            // 
            this.cplcentreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cplcentreDataGridViewTextBoxColumn.DataPropertyName = "cpl_centre";
            this.cplcentreDataGridViewTextBoxColumn.HeaderText = "Code Postal";
            this.cplcentreDataGridViewTextBoxColumn.Name = "cplcentreDataGridViewTextBoxColumn";
            this.cplcentreDataGridViewTextBoxColumn.ReadOnly = true;
            this.cplcentreDataGridViewTextBoxColumn.Width = 89;
            // 
            // villecentreDataGridViewTextBoxColumn
            // 
            this.villecentreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.villecentreDataGridViewTextBoxColumn.DataPropertyName = "ville_centre";
            this.villecentreDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villecentreDataGridViewTextBoxColumn.Name = "villecentreDataGridViewTextBoxColumn";
            this.villecentreDataGridViewTextBoxColumn.ReadOnly = true;
            this.villecentreDataGridViewTextBoxColumn.Width = 51;
            // 
            // telcentreDataGridViewTextBoxColumn
            // 
            this.telcentreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telcentreDataGridViewTextBoxColumn.DataPropertyName = "tel_centre";
            this.telcentreDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telcentreDataGridViewTextBoxColumn.Name = "telcentreDataGridViewTextBoxColumn";
            this.telcentreDataGridViewTextBoxColumn.ReadOnly = true;
            this.telcentreDataGridViewTextBoxColumn.Width = 83;
            // 
            // cbbcont
            // 
            this.cbbcont.DataPropertyName = "num_centre";
            this.cbbcont.DataSource = this.contratBindingSource;
            this.cbbcont.DisplayMember = "num_contrat";
            this.cbbcont.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cbbcont.HeaderText = "Contrat";
            this.cbbcont.Name = "cbbcont";
            this.cbbcont.ReadOnly = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 416);
            this.Controls.Add(this.gbCent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncreer);
            this.Controls.Add(this.gbcreer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).EndInit();
            this.gbcreer.ResumeLayout(false);
            this.gbcreer.PerformLayout();
            this.gbCent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtadr;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox gbcreer;
        private System.Windows.Forms.Button btncreer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnann;
        private System.Windows.Forms.BindingSource centreInformatiqueBindingSource;
        private System.Windows.Forms.GroupBox gbCent;
        private System.Windows.Forms.DataGridView dgvcent;
        private System.Windows.Forms.DataGridViewTextBoxColumn numclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btndgvcent;
        private System.Windows.Forms.DataGridViewButtonColumn btndgvmodif;
        private System.Windows.Forms.DataGridViewButtonColumn btndgvsupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressecentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cplcentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villecentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcentreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbcont;
        private System.Windows.Forms.BindingSource contratBindingSource;
    }
}

