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
    public partial class FrmPeriodista : Form
    {
        Administrador adminBD;
        private Usuarios usu;
        private Periodista periodista;
        public FrmPeriodista(Usuarios usuario)
        {
            InitializeComponent();
            usu = usuario;
        }
        protected void Limpiar()
        {
            txtnom.Text = "";
          txtnacionalidad.Text = "";
            lblerror.Text = "";
            premiosComposite1.LbPremios.Items.Clear();
            dateTimePicker1.Value = DateTime.Now;
           btnAlta .Enabled = false;
            btnbaja.Enabled = false;
            btnmodificar.Enabled = false;
            premiosComposite1.LblError.Text = "";
        }
        protected void ListoenGrilla()
        {
        

            DGVPeriodistas.DataSource = new Service1Client().ListarPeriodista();

        }

        private void FrmPeriodista_Load(object sender, EventArgs e)
        {
            lblerror.ForeColor = System.Drawing.Color.Red;
            ListoenGrilla();
            btnAlta.Enabled = false;
            btnbaja.Enabled = false;
            btnmodificar.Enabled = false;
           
        }
        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
               
                string nom = txtnom.Text;
                Periodista _unPeriodista = null;
             
                _unPeriodista = new Service1Client().BuscarPeriodista(nom);
                if (string.IsNullOrWhiteSpace(nom))
                {
                    lblerror.Text = "No se escribio nada";
                }
                else if (_unPeriodista == null)
                {

                    btnAlta.Enabled = true;
                    btnbaja.Enabled = false;
                    btnmodificar.Enabled = false;
                    lblerror.Text = "Ese Periodista no existe,Boton ALTA Habilitado";

                }
                else
                {
                    Limpiar();
                    btnAlta.Enabled = false;
                    btnbaja.Enabled = true;
                    btnmodificar.Enabled = true;
                    periodista = _unPeriodista;
                    txtnom.Text = _unPeriodista.NomPeriodista.ToString();
                    txtnacionalidad.Text = _unPeriodista.Nacionalidad.ToString();
                    dateTimePicker1.Value = _unPeriodista.Fechanacimiento.ToUniversalTime();
                   premiosComposite1.ListaPremios= _unPeriodista.ListaPremios.ToList();
                  
                    lblerror.Text = "";

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
                Periodista P = new Periodista();
                P.NomPeriodista = txtnom.Text;
                P.Nacionalidad = txtnacionalidad.Text;
                P.Fechanacimiento = dateTimePicker1.Value;

                P.ListaPremios = premiosComposite1.ListaPremios.ToArray();

                new Service1Client().AltaPeriodista(P,adminBD = ((Administrador)usu));      
                ListoenGrilla();
                Limpiar();
                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                lblerror.Text = "Alta de Periodista + Premios  Correcta";



            }
           
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            try
            {
                
                Periodista P = periodista;
                new Service1Client().BajaPeriodista(P, adminBD =((Administrador)usu));
              
                ListoenGrilla();
                Limpiar();
                lblerror.ForeColor = System.Drawing.Color.Red;
                lblerror.Text = "Periodista Eliminado";
            }
          
            catch (Exception ex)
            {
                btnAlta.Enabled = false;
                btnbaja.Enabled = false;
                btnmodificar.Enabled = false;
                lblerror.Text = ex.Message;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Periodista P =periodista ;
                P.NomPeriodista =txtnom.Text.Trim();
                P.Nacionalidad = txtnacionalidad.Text.Trim();
                P.Fechanacimiento=dateTimePicker1.Value;
                P.ListaPremios = premiosComposite1.ListaPremios.ToArray();
                new Service1Client().ModificarPeriodista(P,adminBD = ((Administrador)usu));
                ListoenGrilla();
                Limpiar();
                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                lblerror.Text = "Linea Modificada";


            }
           
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
         
     
    }
}
