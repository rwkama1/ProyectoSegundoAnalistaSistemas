using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;
public partial class DatosLector : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.ForeColor = System.Drawing.Color.Red;
        if (!IsPostBack)
        {
            if (Session["USU"] is Lector)
            {
         
                btnbaja.Enabled = true;
                btnmod.Enabled = true;
                Usuarios usuario =new Service1Client().BuscarUsuario(((Lector)Session["USU"]).Ndoc);
                Session["USU"] = usuario;
                Lector objlector = (Lector)Session["USU"];
                objlector = ((Lector)usuario);
                txtndoc.Text = objlector.Ndoc.ToString();
                txtnom.Text = objlector.NomUsu.ToString();
                txtusuario.Text = objlector.Usuario.ToString();
                txtcontraseña.Text = objlector.Contraseña.ToString();
                txtcorreo.Text = objlector.Correo.ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
    protected void btnbaja_Click(object sender, EventArgs e)
    {
        try
        {
            Lector L = (Lector)Session["USU"];

            new Service1Client().BajaUsuario(L);
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "Baja con Exito";
            Session["USU"] = null;
            LimpioControles();
            btnbaja.Enabled = false;
            btnmod.Enabled = false;
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }


    }

    protected void btnmod_Click(object sender, EventArgs e)
    {
        try
        {
            Lector L = (Lector)Session["USU"];
            L.Ndoc = Convert.ToInt32(txtndoc.Text);
            L.NomUsu = txtnom.Text;
            L.Usuario = txtusuario.Text;
            L.Contraseña = txtcontraseña.Text;
            L.Correo = txtcorreo.Text;
            new Service1Client().ModificarUsuario(L);
            
            this.LimpioControles();
            Label1.ForeColor = System.Drawing.Color.DarkGreen;
            Label1.Text = "Modificacion con Exito";
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    private void LimpioControles()
    {
        txtndoc.Text = "";
       txtnom.Text = "";
       txtusuario.Text = "";
        txtcontraseña.Text = "";
        txtcorreo.Text = "";
        
    }
}