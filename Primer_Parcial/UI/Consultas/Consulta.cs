using System;
using Primer_Parcial.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primer_Parcial.UI.Consultas
{
    public partial class Consulta : Form

    {
        public Consulta()

        {

            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)

        {

        }


        private void label2_Click(object sender, EventArgs e)

        {

        }


        private void label5_Click(object sender, EventArgs e)

        {

        }


        private void Consulta_Load(object sender, EventArgs e)

        {

        }


        private void ConsultaBoton_Click(object sender, EventArgs e)

        {
            Expression<Func<GrupoEstudiantes, bool>> filtro = x => true;


            int id;

            switch (FiltroCombo.SelectedIndex)

            {

                case 0:
                    if (CriterioBox.Text == " ")
                    {

                        errorProvider1.SetError(CriterioBox, "Por favor, llenar este campo");
                        break;
                    }
                    else
                    {
                        id = Convert.ToInt32(CriterioBox.Text);

                        filtro = x => x.GrupoID == id;
                        break;
                    }
                    

                case 1:

                    filtro = x => x.Descripcion.Contains(CriterioBox.Text);

                    break;
                case 2:

                    filtro = x => x.Fecha.Contains(DesdeFechaBox.Text);
                    break;
               }


            DataView.DataSource = BLL.GrupoEstudiantesBLL.GetList(filtro);





        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)

        {

        }


        private void primerParcialDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)

        {

        }


        private void ConsultaData_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)

        {

        }


        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

