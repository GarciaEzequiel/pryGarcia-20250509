using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarcia_20250509
{
    public partial class frmEleccion : Form
    {
        public frmEleccion()
        {
            InitializeComponent();
        }

        private void cmbHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEleccion_Load(object sender, EventArgs e)
        {
            cmbHeroe.Items.Clear();
            cmbHeroe.Items.Add("Superman");
            cmbHeroe.Items.Add("Batman");
            cmbHeroe.Items.Add("Iron Man");
        }
    }
}
