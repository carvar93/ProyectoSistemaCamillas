using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion.Trabajadores
{
    public partial class frmTrabajador : Form
    {
        public frmTrabajador()
        {
            InitializeComponent();
            cargarDataDg();
            datosCombo();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void cargarDataDg()
        {
            try
            {
                String nombre = "";
                List<Trabajador> listaTrabadores = new List<Trabajador>();
                listaTrabadores = LN.consultaTrabajador();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Especialidad");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Puesto");
                dt.Columns.Add("Pacientes");
                dt.Columns.Add("Años Experiencia");
                foreach (Trabajador item in listaTrabadores)
                {
                    nombre = item.idEspecialidad.ToString();
                    nombre = LN.consultaEspecialidad2(nombre);
                    dt.Rows.Add(
                        item.idTrabajador,
                        nombre,
                        item.nombre,
                        item.puesto,
                        item.cantidadPacientes,
                        item.añosExperiencia
                        );
                }
                dg.DataSource = null;
                dg.Refresh();
                dg.DataSource = dt;
                dg.Refresh();
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
                String nombre = "";
                List<Trabajador> listaTrabadores = new List<Trabajador>();
                listaTrabadores = LN.consultaTrabajador();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Especialidad");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Puesto");
                dt.Columns.Add("Pacientes");
                dt.Columns.Add("Años Experiencia");
                foreach (Trabajador item in listaTrabadores)
                {
                    if (item.idTrabajador.ToString().Equals(tbBuscar.Text))
                    {
                        nombre = item.idEspecialidad.ToString();
                        nombre = LN.consultaEspecialidad2(nombre);
                        dt.Rows.Add(
                            item.idTrabajador,
                            nombre,
                            item.nombre,
                            item.puesto,
                            item.cantidadPacientes,
                            item.añosExperiencia
                            );
                    }
                }

                dg.DataSource = null;
                dg.Refresh();
                dg.DataSource = dt;
                dg.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void limpiar()
        {
            try
            {
                tbIdTrabajador.Text = string.Empty;
                cbEspecialidad.Text = string.Empty;
                tbNombre.Text = string.Empty;
                tbPuesto.Text = string.Empty;
                numCantPacientes.Value = 0;
                numAños.Value = 0;
                tbBuscar.Text = string.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void datosCombo()
        {
            try
            {
                List<Especialidad> listaEspecialidad = new List<Especialidad>();
                listaEspecialidad = LN.consultaEspecialidad();
                cbEspecialidad.ValueMember = "idEspecialidad";
                cbEspecialidad.DisplayMember = "nombre";
                cbEspecialidad.DataSource = listaEspecialidad;
                cbEspecialidad.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            limpiar();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (validarDatos(2))
                {
                    Trabajador t = new Trabajador();
                    t.idEspecialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
                    t.nombre = tbNombre.Text;
                    t.puesto = tbPuesto.Text;
                    t.cantidadPacientes = Convert.ToInt32(numCantPacientes.Value);
                    t.añosExperiencia = Convert.ToInt32(numAños.Value);
                    LN.agregarTrabajador(t);
                    cargarDataDg();
                    limpiar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            cargarDataDg();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("Hizo click en una fila no permitida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    this.tbIdTrabajador.Text = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.cbEspecialidad.Text = dg.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.tbNombre.Text = dg.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.tbPuesto.Text = dg.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.numCantPacientes.Text = dg.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.numAños.Text = dg.Rows[e.RowIndex].Cells[5].Value.ToString();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (validarDatos(1))
                {
                    Trabajador t = new Trabajador();
                    t.idTrabajador = Convert.ToInt32(tbIdTrabajador.Text);
                    t.idEspecialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
                    t.nombre = tbNombre.Text;
                    t.puesto = tbPuesto.Text;
                    t.cantidadPacientes = Convert.ToInt32(numCantPacientes.Value);
                    t.añosExperiencia = Convert.ToInt32(numAños.Value);
                    LN.ModificarTrabajador(t);
                    cargarDataDg();
                    limpiar();
                }
                           }
            catch (Exception)
            {
                throw;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (tbIdTrabajador.Text.Length <= 0)
                {
                    MessageBox.Show("Id Trabajdor vacia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Trabajador t = new Trabajador();
                t.idTrabajador = Convert.ToInt32(tbIdTrabajador.Text);
                LN.eliminarTrabajador(t);
                cargarDataDg();
                limpiar();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool validarDatos(int tipo)
        {
            int cont = 0;
            errorProvider1.Clear();
            if (tbIdTrabajador.Text.Length <= 0 && tipo == 1)// si es uno valida Modificar, si es diferente a 1 valida agreagar
            {
                errorProvider1.SetError(tbIdTrabajador, "vacio");
                cont++;
            }
            if (cbEspecialidad.Text.Length <= 0)
            {
                errorProvider1.SetError(cbEspecialidad, "vacio");
                cont++;
            }
            if (tbNombre.Text.Length <= 0)
            {
                errorProvider1.SetError(tbNombre, "vacio");
                cont++;
            }
            if (tbPuesto.Text.Length <= 0)
            {
                errorProvider1.SetError(tbPuesto, "vacio");
                cont++;
            }
            if (cont == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
