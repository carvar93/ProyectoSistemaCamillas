using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {

        }

        private void cargarDatos()
        {
            try
            {
                List<Especialidad> listaEspecialidad = new List<Especialidad>();
                listaEspecialidad = LN.consultaEspecialidad();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id Especialdiad");
                dt.Columns.Add("Nombre Especialdad");
                foreach (Especialidad item in listaEspecialidad)
                {
                    dt.Rows.Add(
                        item.idEspecialidad,
                        item.nombre
                        );
                }
                this.dgridEspecialidad.DataSource = null;
                this.dgridEspecialidad.Refresh();
                this.dgridEspecialidad.DataSource = dt;
                this.dgridEspecialidad.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad especialidad = new Especialidad();
                especialidad.nombre = tbNombre.Text.Trim();
                LN.agregarEspecialidad(especialidad);
                limpiarDatos();
                cargarDatos();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void limpiarDatos()
        {
            this.tbNombre.Text = string.Empty;
            this.tbIdEspecialidad.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad especialidad = new Especialidad();
                especialidad.idEspecialidad = Convert.ToInt32(tbIdEspecialidad.Text.Trim());
                especialidad.nombre = tbNombre.Text.Trim();
                LN.modificarEspecialidad(especialidad);
                limpiarDatos();
                cargarDatos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad especialidad = new Especialidad();
                especialidad.idEspecialidad = Convert.ToInt32(tbIdEspecialidad.Text.Trim());
                LN.eliminarEspecialidad(especialidad);
                limpiarDatos();
                cargarDatos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buscar()
        {
            try
            {
                List<Especialidad> listaEspecialidad = new List<Especialidad>();
                listaEspecialidad = LN.consultaEspecialidad();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id Especialdiad");
                dt.Columns.Add("Nombre Especialdad");
                foreach (Especialidad item in listaEspecialidad)
                    if (item.nombre.ToUpper().Contains(tbBuscar.Text.ToUpper().Trim()))
                    {
                        dt.Rows.Add(
                       item.idEspecialidad,
                       item.nombre
                       );
                    }
                {

                }
                this.dgridEspecialidad.DataSource = null;
                this.dgridEspecialidad.Refresh();
                this.dgridEspecialidad.DataSource = dt;
                this.dgridEspecialidad.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.Text.Equals(""))
            {
                MessageBox.Show("Campo de busqueda vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                buscar();
            }
        }

        private void dgridEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("Hizo click en una fila no permitida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    this.tbIdEspecialidad.Text = dgridEspecialidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.tbNombre.Text = dgridEspecialidad.Rows[e.RowIndex].Cells[1].Value.ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
