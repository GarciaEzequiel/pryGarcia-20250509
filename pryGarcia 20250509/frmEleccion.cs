using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGarcia_20250509.Properties;

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
            string eleccion = cmbHeroe.Text as string;

            switch (eleccion)
            {
                case "Superman":
                    pcbImagen.Image = Resources.Superman;
                break;
                
                case "Batman":
                    pcbImagen.Image = Resources.Batman;
                break;
                
                case "Iron Man":
                    pcbImagen.Image = Resources.Iron_Man;
                break;
            }
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
