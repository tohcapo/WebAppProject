using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS3_WebAppProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTechnicianMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustomerIncidents_Click(object sender, EventArgs e)
        {
            FormCustomerIncidents frmCustomerIncidents = new FormCustomerIncidents();
            frmCustomerIncidents.ShowDialog();
        }

        private void buttonProductMaintenance_Click(object sender, EventArgs e)
        {
            FormProductMaintenance frmProductMainenance = new FormProductMaintenance();
            frmProductMainenance.ShowDialog();
        }

        private void buttonAddIncident_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRegistration_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserAccountMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
