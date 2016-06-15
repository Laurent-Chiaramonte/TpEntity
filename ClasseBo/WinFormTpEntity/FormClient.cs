using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasseDal.Manager;

namespace WinFormTpEntity
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ICollection<Client> listcli = clientMngr.getAllCli();
            //lstcli.DataSource = listcli;
        }
    }
}
