using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;

public partial class UserControlPaginaNoticia : System.Web.UI.UserControl
{
    Noticias n;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int oid = (int)Session["DesNoticia"];
           
           n= new Service1Client().BuscarNoticia(oid);
         
            if (!IsPostBack)
            {

                NId = n.IdNoticia.ToString();
                lblTitulo.Text = n.Titulo.ToString();
                lblFechaCreacion.Text = n.FechaHoraCreacion.ToString();
                lblResumen.Text = n.Resumen.ToString();
                lblPeriodista.Text = n.Periodista.NomPeriodista.ToString();
                lblCuerpoNoticia.Text = n.CuerpoNoticia.ToString();
                GridView1.DataSource = n.ListaComentarios;
                GridView1.DataBind();
            }
           

        }

        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    public string NId
    {
        get { return lblid.Text; }
        set { lblid.Text = value; }
    }

    protected void btnact_Click(object sender, EventArgs e)
    {

        GridView1.DataSource = n.ListaComentarios;
        GridView1.DataBind();
              
    }
}