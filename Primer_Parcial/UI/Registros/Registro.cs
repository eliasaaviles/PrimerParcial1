using System;
using Primer_Parcial.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Primer_Parcial.BLL;

namespace Primer_Parcial.UI.Registros
{
    public partial class Registro : Form

    {
        public Registro()

        {

            InitializeComponent();

        }
        private GrupoEstudiantes LlenaClase()
        {
            GrupoEstudiantes Estudiante = new GrupoEstudiantes();
            {
                Estudiante.GrupoID = Convert.ToInt32(IdNum.Value);
                Estudiante.Descripcion = DescripcionBox.Text;
                Estudiante.Cantidad = Convert.ToInt32(CantidadBox.Text);
                Estudiante.Grupos = Convert.ToInt32(GrupoBox.Text);
                Estudiante.Fecha = FechaTool.Text;
                IntegranteBox.Text = Convert.ToString(Estudiante.Cantidad / Estudiante.Grupos);
                Estudiante.Integrantes = (Estudiante.Cantidad / Estudiante.Grupos);

                return Estudiante;
            }
        }
        private bool Validar()
        {
            bool confirmar = false;


            if (DescripcionBox.Text == String.Empty)
            {
                errorProvider1.SetError(DescripcionBox, "Por favor, llenar este campo");
                confirmar = true;
            }

            if (CantidadBox.Text == String.Empty)
            {
                errorProvider1.SetError(CantidadBox, "Por favor, llenar este campo");
                confirmar = true;
            }
            if (GrupoBox.Text == String.Empty)
            {
                errorProvider1.SetError(GrupoBox, "Por favor, llenar este campo");
                confirmar = true;
            }

            return confirmar;

        }
        private void Limpiar()
        {
            IdNum.Value = IdNum.Value+1;
            DescripcionBox.Text = " ";
            CantidadBox.Text = " ";
            GrupoBox.Text = " ";
            IntegranteBox.Text = " ";

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscrBoton_Click(object sender, EventArgs e)
        {
            int GrupoID = (int)IdNum.Value;
            GrupoEstudiantes estudiantes = BLL.GrupoEstudiantesBLL.Buscar(GrupoID);

            if (estudiantes != null)
            {
                DescripcionBox.Text = estudiantes.Descripcion;
                IdNum.Value = estudiantes.GrupoID;
                CantidadBox.Text = estudiantes.Cantidad.ToString();
                GrupoBox.Text = estudiantes.Grupos.ToString();
                IntegranteBox.Text = estudiantes.Integrantes.ToString();
                FechaTool.Text = estudiantes.Fecha;

            }
            else
                MessageBox.Show("No se encontro!");
        }
       

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrupoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                GrupoEstudiantes estudiantes = LlenaClase();
                bool guardo = false;

                if (IdNum.Value == 0)
                    guardo = BLL.GrupoEstudiantesBLL.Guardar(estudiantes);
                else
                    guardo = BLL.GrupoEstudiantesBLL.Modificar(LlenaClase());

                if (guardo)
                {
                    MessageBox.Show("Guardado");
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo guardar!");
            }

        }
        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNum.Value);
            if (BLL.GrupoEstudiantesBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado");

            }
            else
            {
                MessageBox.Show("No se pudo Eliminar!!");
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
