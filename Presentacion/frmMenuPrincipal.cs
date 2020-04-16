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
using Presentacion.Camilla;
using Presentacion.Sala;


namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {

        #region Propiedades

        public string Usuario { get; set; }

        #endregion


        #region Constructor

        public frmMenuPrincipal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #endregion


        #region Metodos publicos

        public void CargarMenu()
        {
            tsslUsuarioConectado.Text = Usuario;
            int op1 = 0;


            int AccesoMenu = LN.VerificarAcceso(new Usuario { nombre = Usuario });

            consultasToolStripMenuItem.Visible = true;
            sistemaToolStripMenuItem.Visible = true;
            switch (AccesoMenu)
            {
                case 1: // Perfil secretaria
                    {
                        sistemaToolStripMenuItem.Visible = true;
                        consultasToolStripMenuItem.Visible = false;
                        

                    }
                    break;
                case 2:// Perfil reportes
                    {
                       
                        sistemaToolStripMenuItem.Visible = true;
                        cerrarElSistemaToolStripMenuItem.Visible = false;
                        perfilToolStripMenuItem.Visible = false;
                        cerrarElSistemaToolStripMenuItem.Visible = true;
                      
                        consultasToolStripMenuItem.Visible = false;
                        procesosToolStripMenuItem.Visible = true;

                    }
                    break;
                case 3://Perfil administrador
                    {
                        sistemaToolStripMenuItem.Visible = true;
                        consultasToolStripMenuItem.Visible = true;
                        procesosToolStripMenuItem.Visible = true;
                    }

                    break;

            }

        }

        #endregion









        private void Principal_Load(object sender, EventArgs e)
        {
			

        }

		private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
		{
           // UsuarioForm frm = new UsuarioForm();
            //frm.MdiParent = this;
           // frm.Show();

            // llama a usuario
        }

		private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		

		

		

        
        
        

       

        

       

        

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarElSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void camillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            camilla cam = new camilla();
            cam.MdiParent = this.MdiParent;
            cam.Show();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sala s = new sala();
            s.MdiParent = this.MdiParent;
            s.Show();

        }
    }
}
