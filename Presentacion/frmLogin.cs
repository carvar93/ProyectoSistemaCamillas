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
    public partial class frmLogin : Form
    {
        int Intento = 0;
     
        public frmLogin()
        {

            InitializeComponent();
            LN.RestIntentoAll();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Iniciar();
            }
        }

        private void Iniciar()
        {

            Usuario usuario = new Usuario();
            usuario.nombre = txtUsuario.Text.Trim();
            usuario.clave = txtContrasena.Text.Trim();
            if (LN.ConsultarAutenticacion(usuario))
            {


                frmMenuPrincipal frm = new frmMenuPrincipal();

                frm.Usuario = txtUsuario.Text.Trim();
                frm.CargarMenu();

                frm.Show();

                this.Hide();
            }

            else
            {
                if (LN.VerificarIntento(usuario) == 2)
                {
                    frmLogin frm = new frmLogin();
                    LN.RestIntento(usuario); //reseta el intento a  0
                    MessageBox.Show("Se exedio el limite de intento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Application.Exit();

                }
                else
                {
                        Intento += 1;
                    LN.ActulizarUsuario(usuario);
                    if (Intento == 3)
                    {
                        MessageBox.Show("Se exedio el limite de intento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("usuarios y/o contraseña erroneos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
