using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApEscritorio.ServicioWindows;
namespace ApEscritorio
{
    public partial class FrmListadoLinQ : Form
    {
        private Usuarios usu;
        private List<Noticias> notilinq;
        public FrmListadoLinQ(Usuarios usuario)
        {
          
            InitializeComponent();
            usu = usuario;
        }
        protected void LectorCBO()
        {
       

            List<Lector> objp = new Service1Client().ListarLector().ToList();


            if (objp.Count > 0)
            {
               
                CBOlectores.DataSource = objp;
                CBOlectores.DisplayMember = "NomUsu";
                CBOlectores.ValueMember = "NomUsu";

            }
            else
            {
                lblerror.Text = "Error: no existe ningun Lector. Debe ingresar uno primero.";
                CBOlectores.Enabled = false;
            }

        }
        protected void NoticiaCBO()
        {


            List<Noticias> objp = new Service1Client().ListarCompletoNoticias().ToList();


            if (objp.Count > 0)
            {

                
                CBOnoticia.DataSource = objp;
                CBOnoticia.DisplayMember = "IdNoticia";
                CBOnoticia.ValueMember = "IdNoticia";

            }
            else
            {
                lblerror.Text = "Error: no existe ninguna Noticia. Debe ingresar una primero.";
                CBOnoticia.Enabled = false;
            }

        }
        private void FrmListadoLinQ_Load(object sender, EventArgs e)
        {
            lblerror.ForeColor = System.Drawing.Color.Red;
            try
            {
                DGVComentarios.AutoGenerateColumns = true;
                List<Noticias> ListNotic = new Service1Client().ListarCompletoNoticias().ToList();
             
                var _ResultadoLinQ = from noti in ListNotic
                                     from c in noti.ListaComentarios
                                     select new
                                     {
                                         IdComentario = c.IdComentario,
                                         Lector = c.NomUsuario,
                                         Comentario = c.Comentario
                                     };

                ArrayList _ResultadoFinal = new ArrayList();

                foreach (var unObj in _ResultadoLinQ)
                    _ResultadoFinal.Add(unObj);

                DGVComentarios.DataSource = _ResultadoFinal;
            
                notilinq = ListNotic;
                LectorCBO();
                NoticiaCBO();
              
            }
          
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
         
        }

        private void btnrusuario_Click(object sender, EventArgs e)
        {
    
            var _ResultadoLinQ = from noti in notilinq
                                 from c in noti.ListaComentarios
                                 group c by c.Lector.NomUsu
                                     into Auxiliar
                                     select new
                                     {
                                         Lector = Auxiliar.First().Lector.NomUsu,
                                         CantidadComentarios = Auxiliar.Count()
                                     };

            ArrayList _ResultadoFinal = new ArrayList();

            foreach (var unObj in _ResultadoLinQ)
                _ResultadoFinal.Add(unObj);

           DGVComentarios.DataSource = _ResultadoFinal;
        }

        private void btnusuespecifico_Click(object sender, EventArgs e)
        {
            var _ResultadoLinQ =
                          from noti in notilinq
                          from c in noti.ListaComentarios
                          where c.Lector.NomUsu == CBOlectores.Text
                          select new
                          {
                              Titulo = noti.Titulo.ToString(),
                              Texto = c.Comentario
                          };



            ArrayList _ResultadoFinal = new ArrayList();

            foreach (var unObj in _ResultadoLinQ)
                _ResultadoFinal.Add(unObj);
            DGVComentarios.DataSource = _ResultadoFinal;
          
        }

        private void btncatespecifica_Click(object sender, EventArgs e)
        {
         
            var _ResultadoLinQ =

                            from noti in notilinq
                            where noti.Categoria==CBOCategorias.Text                      
                            select new
                            {
                                Titulo = noti.Titulo,
                                CantidadComentarios = noti.CantComentarios
                            };



            ArrayList _ResultadoFinal = new ArrayList();

            foreach (var unObj in _ResultadoLinQ)
                _ResultadoFinal.Add(unObj);
            DGVComentarios.DataSource = _ResultadoFinal;
           
            
        }

        private void btnnespecifica_Click(object sender, EventArgs e)
        {
            var _ResultadoLinQ =
                            from noti in notilinq
                            from c in noti.ListaComentarios
                            where noti.IdNoticia == Convert.ToInt32(CBOnoticia.Text)
                            select new
                            {
                                Lector = c.Lector.NomUsu.ToString(),
                                Comentario = c.Comentario
                            };
            ArrayList _ResultadoFinal = new ArrayList();
            foreach (var unObj in _ResultadoLinQ)
                _ResultadoFinal.Add(unObj);
            DGVComentarios.DataSource = _ResultadoFinal;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            var _ResultadoLinQ = from noti in notilinq
                                 from c in noti.ListaComentarios
                                 select new
                                 {
                                     IdComentario = c.IdComentario,
                                     Lector = c.NomUsuario,
                                     Comentario = c.Comentario
                                 };

            ArrayList _ResultadoFinal = new ArrayList();

            foreach (var unObj in _ResultadoLinQ)
                _ResultadoFinal.Add(unObj);

            DGVComentarios.DataSource = _ResultadoFinal;
        }

        private void CBOlectores_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void CBOCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBOnoticia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

    }
}
