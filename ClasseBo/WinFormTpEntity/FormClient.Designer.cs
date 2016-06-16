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
            this.numclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afficher les clients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numclientDataGridViewTextBoxColumn,
            this.nomclientDataGridViewTextBoxColumn,
            this.adresseclientDataGridViewTextBoxColumn,
            this.cpclientDataGridViewTextBoxColumn,
            this.villeclientDataGridViewTextBoxColumn,
            this.telclientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // numclientDataGridViewTextBoxColumn
            // 
            this.numclientDataGridViewTextBoxColumn.DataPropertyName = "num_client";
            this.numclientDataGridViewTextBoxColumn.HeaderText = "num_client";
            this.numclientDataGridViewTextBoxColumn.Name = "numclientDataGridViewTextBoxColumn";
            // 
            // nomclientDataGridViewTextBoxColumn
            // 
            this.nomclientDataGridViewTextBoxColumn.DataPropertyName = "nom_client";
            this.nomclientDataGridViewTextBoxColumn.HeaderText = "nom_client";
            this.nomclientDataGridViewTextBoxColumn.Name = "nomclientDataGridViewTextBoxColumn";
            // 
            // adresseclientDataGridViewTextBoxColumn
            // 
            this.adresseclientDataGridViewTextBoxColumn.DataPropertyName = "adresse_client";
            this.adresseclientDataGridViewTextBoxColumn.HeaderText = "adresse_client";
            this.adresseclientDataGridViewTextBoxColumn.Name = "adresseclientDataGridViewTextBoxColumn";
            // 
            // cpclientDataGridViewTextBoxColumn
            // 
            this.cpclientDataGridViewTextBoxColumn.DataPropertyName = "cp_client";
            this.cpclientDataGridViewTextBoxColumn.HeaderText = "cp_client";
            this.cpclientDataGridViewTextBoxColumn.Name = "cpclientDataGridViewTextBoxColumn";
            // 
            // villeclientDataGridViewTextBoxColumn
            // 
            this.villeclientDataGridViewTextBoxColumn.DataPropertyName = "ville_client";
            this.villeclientDataGridViewTextBoxColumn.HeaderText = "ville_client";
            this.villeclientDataGridViewTextBoxColumn.Name = "villeclientDataGridViewTextBoxColumn";
            // 
            // telclientDataGridViewTextBoxColumn
            // 
            this.telclientDataGridViewTextBoxColumn.DataPropertyName = "tel_client";
            this.telclientDataGridViewTextBoxColumn.HeaderText = "tel_client";
            this.telclientDataGridViewTextBoxColumn.Name = "telclientDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Client);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 13);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(107, 209);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 4;
            // 
            // txtadr
            // 
            this.txtadr.Location = new System.Drawing.Point(107, 236);
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(100, 20);
            this.txtadr.TabIndex = 5;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(107, 263);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(100, 20);
            this.txtcp.TabIndex = 6;
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(107, 290);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(100, 20);
            this.txtville.TabIndex = 7;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(107, 317);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Code Postal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ville :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Téléphone :";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(251, 314);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 438);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.txtadr);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telclientDataGridViewTextBoxColumn;
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
    }
}

