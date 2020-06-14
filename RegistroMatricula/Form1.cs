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
            
            if (!(int.TryParse(this.txtEdad.Text, out int Edad)))
            {
                MessageBox.Show("La Edad ingresada no es valida ....");
                this.txtEdad.Focus();
            }
            MatriculasDAO Matriculas = new MatriculasDAO();
            Matriculas.matricula = this.txtMatricula.Text;
            Matriculas.apellidos = this.txtApellido.Text;
            Matriculas.nombres = this.txtNombre.Text;
            Matriculas.edad = Edad;
            Matriculas.sexo = this.cmbSexo.Text;
            //asignar cada asignatura en la lista de asignatura
            lista.Add(Matriculas);

            //Cargar la lista en el Datagridview
            this.gridEstudiantes.DataSource = null;
            this.gridEstudiantes.DataSource = lista;


            //agregar lista 
            ListViewItem listas = new ListViewItem(txtMatricula.Text);
            listas.SubItems.Add(txtApellido.Text);
            listas.SubItems.Add(txtNombre.Text);
            listas.SubItems.Add(txtEdad.Text);
            listas.SubItems.Add(cmbSexo.Text);
            listView1.Items.Add(listas);



            txtMatricula.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            cmbSexo.Text = "";

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //filtrar datos por matriculas
            this.gridEstudiantes.DataSource = null;
            this.gridEstudiantes.DataSource = lista.Where(data => data.matricula.ToString() == this.txtFiltraMatricula.Text).ToList();

            // Calcular la mayor edad y la menor edad
            this.txtEdadMayor.Text = lista.Max(data => data.edad).ToString();
            this.txtEdadMenor.Text = lista.Min(data => data.edad).ToString();

        }
    }
}
