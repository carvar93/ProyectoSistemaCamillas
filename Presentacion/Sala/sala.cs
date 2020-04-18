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

namespace Presentacion.Sala
{
    
   

    public partial class sala : Form
    {
        private int idS =0;
        private int idC = 0;


        public sala()
        {
            InitializeComponent();
            this.cargarDatagrid();
            cargarDatagridCamillas();
        }


        public void cargarDatagrid() {
            List<Entidades.Sala> ls = LN.consultarSala(new Entidades.Sala { nombre = string.Empty });
            this.SaladataGridView.DataSource = null;
            this.SaladataGridView.Refresh();
            this.SaladataGridView.DataSource = ls;
            this.SaladataGridView.Refresh();


        }

        public void cargarDatagridCamillas()
        {

            List<Entidades.Camilla> ls = LN.ConsultaCamillaPorEstado("Vacio");
            this.camillasParaAsigdataGridView.DataSource = null;
            this.camillasParaAsigdataGridView.Refresh();
            this.camillasParaAsigdataGridView.DataSource = ls;
            this.camillasParaAsigdataGridView.Refresh();
            


        }



        private void SaladataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            idS = Int32.Parse(this.SaladataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            nombreSalatxt.Text = this.SaladataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
             }

        private void AgregarSalabtn_Click(object sender, EventArgs e)
        {
            try {
                int a = 0;
                Entidades.Sala s = new Entidades.Sala();
                s.nombre = nombreSalatxt.Text;
                s.cantidadCamillas = a;
                LN.agregarSala(s);
                MessageBox.Show(" agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarDatagrid();

            }
            catch (Exception eee) {
                throw eee;
            }
        }

        private void ModificarSalabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Sala s = new Entidades.Sala();
                s.nombre = nombreSalatxt.Text.Trim();
                s.idSala = this.idS;
                LN.modificarSala(s);
                MessageBox.Show("Sala modificada");
                this.cargarDatagrid();
                this.nombreSalatxt.Text = string.Empty;


            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void eliminarSalabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Sala s = new Entidades.Sala();
                s.nombre= nombreSalatxt.Text.Trim();
                LN.eliminarSala(s);
                MessageBox.Show("Camilla eliminada");
                this.cargarDatagrid();
                nombreSalatxt.Text = string.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sala_Load(object sender, EventArgs e)
        {

        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            try {
                Entidades.Sala s = new Entidades.Sala();
                s.nombre = this.nombreSalatxt.Text.Trim();
                LN.consultarSala(s);
                
                
                this.busquedaSalatextBox.Text = string.Empty;
                this.SaladataGridView.DataSource = null;
                this.SaladataGridView.Refresh();
                this.SaladataGridView.DataSource = LN.consultarSala(s);
                this.SaladataGridView.Refresh();
                nombreSalatxt.Text = string.Empty;
              

            }
            catch (Exception es) {
                throw es;
            }
        }

        private void agregarCamillasbutton_Click(object sender, EventArgs e)
        {
            try {
                LN.agregaCamillaSala(this.idS, this.idC);
                LN.modificarCamillas(idC, "Ocupado");
                MessageBox.Show("Camilla asignada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarDatagridCamillas();
                idS = 0;
                idC = 0;
            }
            catch (Exception ecs) {
                throw ecs;
            }
        }

        private void camillasParaAsigdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idC = Int32.Parse(camillasParaAsigdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
