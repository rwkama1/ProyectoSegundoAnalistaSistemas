using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["USU"] is Lector )
        {
            lblnombrelectorlogueado.Text = "BIENVENIDO:" + ((ServicioWeb.Lector)Session["USU"]).NomUsu;
        }

    }
    protected void Login2_Authenticate(object sender, AuthenticateEventArgs e)
    {

        try
        {

            Session["USU"] = null;
            string usuario = Login2.UserName.Trim();
            string pass = Login2.Password.Trim();
            ServicioWeb.Usuarios usu = new Service1Client().LogueoUsuario(usuario, pass);
            Session["USU"] = usu;
            if (usu is ServicioWeb.Lector)
            {
                Response.Redirect("Default.aspx");

            }
            else
            {
                lblerror.Text = "Usuario y/o Contraseña del Lector incorrectas";
            }

        }

        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }


    }
    protected void btndeslogueo_Click(object sender, EventArgs e)
    {
        Session["USU"] = null;
        Response.Redirect("~/Default.aspx");
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
