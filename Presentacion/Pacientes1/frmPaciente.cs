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
                btBuscar.Text = string.Empty;
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
            limpiar();
        }

        private void tbBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btCargarDatos_Click(object sender, EventArgs e)
        {
            cargarDataDg();
        }
    }
}
