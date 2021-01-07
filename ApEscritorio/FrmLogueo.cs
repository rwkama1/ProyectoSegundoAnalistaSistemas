using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ApEscritorio.ServicioWindows;
namespace ApEscritorio
{
    public partial class FrmLogueo : Form
    {
        
        public FrmLogueo()
        {
            InitializeComponent();
        }

        private void btnlogueo_Click(object sender, EventArgs e)
        {
            lblerror.ForeColor = System.Drawing.Color.Red;
            
            try
            {
                Service1Client v = new Service1Client();
            
                Usuarios usuario = v.LogueoUsuario(txtusuario.Text, txtcontraseña.Text);
                if (usuario is Administrador)
                {
                    this.Hide();
                    Form _unForm = new FrmPrincipal(usuario);
                    _unForm.ShowDialog();
                    this.Close();

                }

                else
                {
                    lblerror.Text = "Usuario y/o contraseña incorrectas";
                }


            }

            catch (Exception ex)
            {
                
                lblerror.Text = ex.Message;
            }
        }

       
    }
}
