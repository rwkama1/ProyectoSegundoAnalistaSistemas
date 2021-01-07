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
    public partial class FrmNoticias : Form
    {
        private Administrador adminBD;
        private Usuarios usuario;
        private Noticias N;
        public FrmNoticias(Usuarios usu)
        {
            InitializeComponent();
            usuario = usu;
        }
        protected void PeriodistasEnDropDownList()
        {
      
          
            List<Periodista> objp = new  Service1Client().ListarPeriodista().ToList();


            if (objp.Count > 0)
            {
                CBOperiodistas.DataSource = objp;
                CBOperiodistas.DisplayMember = "NomPeriodista";
                CBOperiodistas.ValueMember = "NomPeriodista";

            }
            else
            {
                lblerror.Text = "Error: no existe ningun Periodista. Debe ingresar una primero.";
                CBOperiodistas.Enabled = false;
            }

        }
        private void LimpioControles()
        {
            mtxtid.Text = "";
            rtxtitulo.Text = "";
            rtxtresumen.Text = "";
            rtxtCuerponoticia.Text = "";
            lblerror.Text = "";
            N = null;
            btnalta.Enabled = false;
            btnmodificar.Enabled = false;
            btnbaja.Enabled = false;
        }
        protected void Grilla()
        {
    
            DGVnoticias.AutoGenerateColumns = false ;
            DGVnoticias.DataSource = new Service1Client().ListarCompletoNoticias();
        }
     

        private void FrmNoticias_Load(object sender, EventArgs e)
        {
            lblerror.ForeColor = System.Drawing.Color.Red;
            Grilla();
           PeriodistasEnDropDownList();
          
            btnalta.Enabled = false;
            btnmodificar.Enabled = false;
            btnbaja.Enabled = false;
        }
        private void txtidnoticia_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                


                int id = Convert.ToInt32(mtxtid.Text);
                Noticias noti = null;
                noti = new Service1Client().BuscarNoticia(id);

                if (noti == null)
                {


                    rtxtCuerponoticia.Text = "";
                    rtxtitulo.Text = "";
                    rtxtresumen.Text = "";
                    CBOCategorias.Text = "";
                    CBRelevante.Text = "";
                    CBOperiodistas.Text = "";
                  
                    btnalta.Enabled = true;
                    lblerror.Text = "Ese Noticia no existe,Boton ALTA Habilitado";

                }
                else
                {
                    LimpioControles();
                    btnalta.Enabled = false;
                    btnmodificar.Enabled = true;
                    btnbaja.Enabled = true;
                    N = noti;
                    mtxtid.Text = noti.IdNoticia.ToString() ;
                    rtxtitulo.Text = noti.Titulo.ToString();
                    rtxtresumen.Text = noti.Resumen.ToString();
                    lblerror.Text = "";
                    rtxtCuerponoticia.Text = noti.CuerpoNoticia.ToString();
                    CBOperiodistas.Text = noti.Periodista.NomPeriodista.ToString();
                    CBOCategorias.Text = noti.Categoria.ToString();
                    CBRelevante.Checked = noti.Relevante;                   

                }
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            try
            {


                Periodista P = new Service1Client().BuscarPeriodista(CBOperiodistas.SelectedValue.ToString());

                Noticias noti = new Noticias();
                noti.IdNoticia = 0;
                noti.Titulo = rtxtitulo.Text;
                noti.Resumen = rtxtresumen.Text;
                noti.CuerpoNoticia = rtxtCuerponoticia.Text;
                
                noti.Categoria = CBOCategorias.Text;
                noti.Periodista = P;
                noti.Relevante = CBRelevante.Checked;
                new Service1Client().AltaNoticias(noti, adminBD = ((Administrador)usuario));
              
                Grilla();
                LimpioControles();
                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                lblerror.Text = "Alta de Noticia Correcta";
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

            
                Noticias noti = N;
                new Service1Client().BajaNoticia(noti, adminBD = ((Administrador)usuario));
                Grilla();
                LimpioControles();
                lblerror.ForeColor = System.Drawing.Color.Red;
                lblerror.Text = "Noticia Eliminada";


            }


            catch (Exception ex)
            {
                lblerror.Text = ex.Message;

            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Periodista P =  new Service1Client().BuscarPeriodista(CBOperiodistas.SelectedValue.ToString());
                Noticias notimod = N;
               
                notimod.Titulo = rtxtitulo.Text;
                notimod.Resumen = rtxtresumen.Text;
                notimod.CuerpoNoticia = rtxtCuerponoticia.Text;
                notimod.Categoria = CBOCategorias.Text;
                notimod.Periodista = P;
                notimod.Relevante = CBRelevante.Checked;
                new Service1Client().ModificarNoticia(notimod, adminBD = ((Administrador)usuario));
              
                Grilla();
                LimpioControles();
                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                lblerror.Text = "Noticia Modificada";


            }
           
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpioControles();
        }
     
    }
}
