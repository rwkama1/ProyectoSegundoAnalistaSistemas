using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;
public partial class PaginaNoticia : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnComentar_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USU"] is Lector)
            {

                Noticias n = null;
                int idn = Convert.ToInt32(UserControlPaginaNoticia1.NId);
                string textocomentarioo = txtcomentario.Text;

                n = new Service1Client().BuscarNoticia(idn);

                Usuarios usuario = new Service1Client().BuscarUsuario(((Lector)Session["USU"]).Ndoc);
                Lector objlector = (Lector)Session["USU"];
                objlector = ((Lector)usuario);
                Comentarios com = new Comentarios();
                com.Comentario = textocomentarioo;
                com.Lector = objlector;
                n.ListaComentarios.Enqueue(com);
                n.IdNoticia = idn;
                new Service1Client().ComentarNoticia(n);
                txtcomentario.Text = "";
                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                lblerror.Text = "Comentado";




            }
            else
            {
                lblerror.ForeColor = System.Drawing.Color.Red;
                lblerror.Text = "Para comentar una noticia debe estar Registrado y Logueado al Sitio";
            }
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }

    }


 
}