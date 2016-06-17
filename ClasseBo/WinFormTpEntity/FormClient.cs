using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasseDal;
using ClasseDal.Manager;
using ClasseDal.Exceptions;

namespace WinFormTpEntity
{
    public partial class FormClient : Form
    {
        #region Chargement
        private clientMngr Mngr;

        public FormClient()
        {
            InitializeComponent();
        }
        #endregion

        #region Comportement
        private void FormClient_Load(object sender, EventArgs e)
        {
            this.Mngr = new clientMngr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayAllClients();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.nom_client = txtnom.Text;
            cl.adresse_client = txtadr.Text;
            cl.cp_client = txtcp.Text;
            cl.ville_client = txtville.Text;
            cl.tel_client = txttel.Text;

            try
            {
                if (Mngr.AjoutClient(cl))
                {
                    MessageBox.Show("Ajout ok !", cl.ToString());
                    gbcreer.Visible = false;
                    DisplayAllClients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !");
                Application.Exit();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btndgvsupp"].Index))
            {
                Client cl = new Client();
                cl = (dataGridView1.Rows[e.RowIndex]).DataBoundItem as Client;

                DialogResult dr = MessageBox.Show("Le client va être supprimé", "DEL",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Mngr.SuppClient(cl);
                        DisplayAllClients();
                    }
                    catch (DaoExceptionFinAppli defa)
                    {
                        MessageBox.Show(defa.Message);
                        Application.Exit();
                    }
                }
            }
        }

        private void btncreer_Click(object sender, EventArgs e)
        {
            gbcreer.Visible = true;
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            gbcreer.Visible = false;
        }
        #endregion

        #region Méthodes
        public void DisplayAllClients()
        {
            clientBindingSource.DataSource = Mngr.getAllCli();
        }
        #endregion
    }
}
