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
using ClasseDal.Dao;

namespace WinFormTpEntity
{
    public partial class FormClient : Form
    {
        private clientMngr Mngr;
    
        public FormClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayAllClients();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            this.Mngr = new clientMngr();
        }
        
        public void DisplayAllClients()
        {
            clientBindingSource.DataSource = Mngr.getAllCli();
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
                Mngr.AjoutClient(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur !");
                Application.Exit();
            }
            
        }
    }
}
