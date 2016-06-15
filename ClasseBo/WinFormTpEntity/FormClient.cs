﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasseDal.Manager;
using ClasseDal;

namespace WinFormTpEntity
{
    public partial class FormClient : Form
    {
        private IRepository<Client> _clientRepository;
    
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
            this._clientRepository = new Repository<Client>();
        }
        
        public void DisplayAllClients()
        {
            clientBindingSource.DataSource = _clientRepository.GetAll();
        }

    }
}
