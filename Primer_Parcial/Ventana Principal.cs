using Primer_Parcial.UI.Registros;
using Primer_Parcial.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Primer_Parcial
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            
            InitializeComponent();
        }

       

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();

            reg.Show();
           
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();

            con.Show();
        }
    }
}
