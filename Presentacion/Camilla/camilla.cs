using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
namespace Presentacion.Camilla
{
    public partial class camilla : Form
    {
        public camilla()
        {
            InitializeComponent();
            this.CargarDataGridCamillas();
            this.CargarComboEstadoCamilla();
        }


        public void CargarComboEstadoCamilla() {

            string nom ;
            List<String> lstresultado = new List<String>();
            lstresultado.Add(nom = "----- Seleccione -----");
            lstresultado.Add(nom = "Ocupado");
            lstresultado.Add(nom = "Vacio");
            lstresultado.Add(nom = "Tramite a ocuparse");
            this.camillaEstadocbo.DataSource = lstresultado;
            camillaEstadocbo.DisplayMember = "nom";
            camillaEstadocbo.Refresh();
           
            
        } 

        private void CargarDataGridCamillas()
        {
            try
            {
                //hacer un inner join porque ocupo perfil ya lo hice en data
                List<Entidades.Camilla> lstCamillas = LN.ConsultaCamilla(new Entidades.Camilla { estadoCamilla = string.Empty });
             
                this.CamilladataGridView1.DataSource = null;
                this.CamilladataGridView1.Refresh();
                this.CamilladataGridView1.DataSource = lstCamillas;
                this.CamilladataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarCamillabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Camilla c = new Entidades.Camilla();
                c.estadoCamilla = "Vacio";
                 LN.agregarCamilla(c);
                 MessageBox.Show(" agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.CargarDataGridCamillas();
                      
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CamilladataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numeroCamillatxt.Text = this.CamilladataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.camillaEstadocbo.Text = this.CamilladataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void eliminarCamillabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Camilla c = new Entidades.Camilla();
                c.NumeroCamilla = Int32.Parse(numeroCamillatxt.Text.Trim());
                LN.eliminarCamilla(c);
                MessageBox.Show("Camilla eliminada");
                this.CargarDataGridCamillas();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificarCamillabtn_Click(object sender, EventArgs e)
        {
            try
            {
                    int id = 0;
                    id=Int32.Parse(numeroCamillatxt.Text);
                    string en =  this.camillaEstadocbo.GetItemText(this.camillaEstadocbo.SelectedItem);
                    LN.modificarCamillas(id, en);
                    MessageBox.Show("Camilla modificada");
                    this.CargarDataGridCamillas();
                 
                
            }
            catch (Exception exc)
            {
                throw exc;
            }


        }

        private void CamilladataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
