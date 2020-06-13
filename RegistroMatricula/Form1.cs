using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroMatricula.Clases;

namespace RegistroMatricula
{
    public partial class Form1 : Form
    {
        private List<MatriculasDAO> lista = new List<MatriculasDAO>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validacion si hay datos en las caja de texto
            if (this.txtMatricula.Text.Length == 0)
            {
                MessageBox.Show("Por favor debe de ingresar la Matricula del estudiante .....");
                this.txtMatricula.Focus();
            }
            if (this.txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Por favor debe de ingresar los Apellidos del estudiante .....");
                this.txtApellido.Focus();
            }
            if (this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor debe de ingresar los Nombres del estudiante .....");
                this.txtNombre.Focus();
            }
            if (this.txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Por favor debe de ingresar los Edad del estudiante .....");
                this.txtEdad.Focus();
            }
            if (this.cmbSexo.Text.Length == 0)
            {
                MessageBox.Show("Por favor debe de ingresar los Sexo del estudiante .....");
                this.cmbSexo.Focus();
            }
            //convertir a enteros
            if(!(int.TryParse(this.txtMatricula.Text, out int matricula)))
            {
                MessageBox.Show("La Matricula ingresada no es valida ....");
                this.txtMatricula.Focus();
            }
            if (!(int.TryParse(this.txtEdad.Text, out int Edad)))
            {
                MessageBox.Show("La Edad ingresada no es valida ....");
                this.txtEdad.Focus();
            }
            MatriculasDAO Matriculas = new MatriculasDAO();
            Matriculas.matricula = matricula;
            Matriculas.apellidos = this.txtApellido.Text;
            Matriculas.nombres = this.txtNombre.Text;
            Matriculas.edad = Edad;
            Matriculas.sexo = this.cmbSexo.Text;
            //asignar cada asignatura en la lista de asignatura
            lista.Add(Matriculas);

            //Cargar la lista en el Datagridview
            this.gridEstudiantes.DataSource = null;
            this.gridEstudiantes.DataSource = lista;

            txtMatricula.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            cmbSexo.Text = "";




        }
    }
}
