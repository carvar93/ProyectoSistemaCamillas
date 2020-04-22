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

namespace Presentacion.Pacientes1
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
            cargarDataDg();
            cargarBoxTrabajador();
        }
        private void cargarDataDg()
        {
            try
            {
                List<Paciente> listaPaciente = new List<Paciente>();

                listaPaciente = LN.consultaPaciente();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Id Trabajador");
                dt.Columns.Add("Nombre Trabajador");
                dt.Columns.Add("Nombre Paciente");
                dt.Columns.Add("Padecimientos");
                dt.Columns.Add("Motivo Emergencia");
                dt.Columns.Add("Estado");
                for (int i = 0; i < listaPaciente.Count; i++)
                {
                    dt.Rows.Add(
                        listaPaciente.ElementAt(i).idPaciente,
                        listaPaciente.ElementAt(i).idTrabajador,
                        nombreTrabajador(listaPaciente.ElementAt(i).idTrabajador),
                        listaPaciente.ElementAt(i).nombre,
                        listaPaciente.ElementAt(i).padecimiente,
                        listaPaciente.ElementAt(i).motivoEmergencia,
                        listaPaciente.ElementAt(i).Estado
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
                List<Paciente> listaPaciente = new List<Paciente>();
                listaPaciente = LN.consultaPaciente();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Id Trabajador");
                dt.Columns.Add("Nombre Trabajador");
                dt.Columns.Add("Nombre Paciente");
                dt.Columns.Add("Padecimientos");
                dt.Columns.Add("Motivo Emergencia");
                dt.Columns.Add("Estado");
                for (int i = 0; i < listaPaciente.Count; i++)
                {
                    if (listaPaciente.ElementAt(i).idPaciente.ToString().Equals(tbBuscar.Text.Trim()))
                    {
                        dt.Rows.Add(
                            listaPaciente.ElementAt(i).idPaciente,
                            listaPaciente.ElementAt(i).idTrabajador,
                            nombreTrabajador(listaPaciente.ElementAt(i).idTrabajador),
                            listaPaciente.ElementAt(i).nombre,
                            listaPaciente.ElementAt(i).padecimiente,
                            listaPaciente.ElementAt(i).motivoEmergencia,
                            listaPaciente.ElementAt(i).Estado
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
        private string nombreTrabajador(int i)
        {
            try
            {
                string nombre = "";
                List<Trabajador> listaTrabadores = new List<Trabajador>();
                listaTrabadores = LN.consultaTrabajador();
                foreach (Trabajador item in listaTrabadores)
                {
                    if (i == item.idTrabajador)
                        nombre = item.nombre;
                }
                return nombre;
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
                tbIdPaciente.Text = string.Empty;
                cbIdTrabajdador.Text = string.Empty;
                tbNombre.Text = string.Empty;
                tbPadecimiento.Text = string.Empty;
                tbMotivo.Text = string.Empty;
                cbEstado.Text = string.Empty;
                tbBuscar.Text = string.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            limpiar();
        }

        private void tbBuscar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            buscar();
        }

        private void btCargarDatos_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            cargarDataDg();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (validarDatos(2))
                {
                Paciente p = new Paciente();
                p.idTrabajador = Convert.ToInt32(cbIdTrabajdador.Text.Trim());
                p.nombre = tbNombre.Text.Trim();
                p.padecimiente = tbPadecimiento.Text.Trim();
                p.motivoEmergencia = tbMotivo.Text.Trim();
                p.Estado = cbEstado.Text;
                LN.agregarPaciente(p);
                cargarDataDg();
                limpiar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (validarDatos(1))
                {
                    Paciente p = new Paciente();
                    p.idPaciente = Convert.ToInt32(tbIdPaciente.Text.Trim());
                    p.idTrabajador = Convert.ToInt32(cbIdTrabajdador.Text.Trim());
                    p.nombre = tbNombre.Text.Trim();
                    p.padecimiente = tbPadecimiento.Text.Trim();
                    p.motivoEmergencia = tbMotivo.Text.Trim();
                    p.Estado = cbEstado.Text;
                    LN.ModificarPaciente(p);
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
            errorProvider1.Clear();
            try
            {
                if (tbIdPaciente.Text.Length <= 0)
                {
                    MessageBox.Show("Id paciente vacia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Paciente p = new Paciente();
                    p.idPaciente = Convert.ToInt32(tbIdPaciente.Text.Trim());
                    LN.eliminarPaciente(p);
                    cargarDataDg();
                    limpiar();
                }
            }
            catch (Exception)
            {
                throw;
            }
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
                    this.tbIdPaciente.Text = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.cbIdTrabajdador.Text = dg.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.tbNombre.Text = dg.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.tbPadecimiento.Text = dg.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.tbMotivo.Text = dg.Rows[e.RowIndex].Cells[5].Value.ToString();
                    this.cbEstado.Text = dg.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cargarBoxTrabajador()
        {
            try
            {
            List<Trabajador> t = new List<Trabajador>();
            t = LN.consultaTrabajador();
                cbIdTrabajdador.DataSource = t;
                cbIdTrabajdador.DisplayMember = "idTrabajador";
                cbIdTrabajdador.ValueMember = "idTrabajador";
                cbIdTrabajdador.Refresh();
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
            if (tbIdPaciente.Text.Length <= 0 && tipo == 1)// si es uno valida Modificar, si es diferente a 1 valida agreagar
            {
                errorProvider1.SetError(tbIdPaciente, "vacio");
                cont++;
            }
            if (cbIdTrabajdador.Text.Length <= 0)
            {
                errorProvider1.SetError(cbIdTrabajdador, "vacio");
                cont++;
            }
            if (tbNombre.Text.Length <= 0)
            {
                errorProvider1.SetError(tbNombre, "vacio");
                cont++;
            }
            if (tbPadecimiento.Text.Length <= 0)
            {
                errorProvider1.SetError(tbPadecimiento, "vacio");
                cont++;
            }
            if (tbMotivo.Text.Length <= 0)
            {
                errorProvider1.SetError(tbMotivo, "vacio");
                cont++;
            }
            if (cbEstado.Text.Length <= 0)
            {
                errorProvider1.SetError(cbEstado, "vacio");
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

