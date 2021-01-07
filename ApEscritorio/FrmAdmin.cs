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
    public partial class FrmAdmin : Form
    {
        private Administrador adminBD;
        private Usuarios usu;
        public FrmAdmin(Usuarios usuario) 
        {
           
            usu = usuario;
            InitializeComponent();
        }
        private void txtndoc_Validating(object sender, CancelEventArgs e)
        {
              try
            {
                Usuarios usu = null;
               
              
                usu = new Service1Client().BuscarUsuario(Convert.ToInt32(mtxtndoc.Text));
              

                if (usu is Administrador)
                {
                  
                    Administrador admini = ((Administrador)usu);
              
                  
                    lblerror.Text = "";

              
                    mtxtndoc.Text = admini.Ndoc.ToString();
                    txtnombre.Text = admini.NomUsu.ToString();
                    txtusu.Text = admini.Usuario.ToString();
                    txtcontraseña.Text = admini.Contraseña.ToString();
                    chcGenera.Checked = admini.GeneraLectores;



                }
                if (usu is Lector)
                {
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "Eso es un lector, aca se busca solo Administradores";
                }

                if (usu == null)
                {
                    btnAlta.Enabled = true;
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    lblerror.Text = "Ese Administrador no existe,Boton ALTA Habilitado";

                }


            }
          
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }

        }
        
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
               
                Administrador adminusu = new Administrador();
                adminusu.Ndoc = Convert.ToInt64(mtxtndoc.Text);
                adminusu.NomUsu = txtnombre.Text;
                adminusu.Usuario = txtusu.Text;
                adminusu.Contraseña = txtcontraseña.Text;
                adminusu.GeneraLectores = chcGenera.Checked;
                new Service1Client().AltaUsuario(adminusu,adminBD=((Administrador)usu));

                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                lblerror.Text = "Alta con Exito";
            }
           
            catch (Exception ex)
            {    
                    lblerror.Text = ex.Message;

            }
        }

       
    }
}
