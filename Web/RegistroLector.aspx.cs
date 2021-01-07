using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;
using System.Configuration;
using System.Messaging;
public partial class RegistroLector : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnenviarsolicitud_Click(object sender, EventArgs e)
    {
        try
        {
            Lector L = new Lector();
            L.Ndoc = Convert.ToInt64(txtndoc.Text.Trim());
            L.NomUsu =txtnomusuario.Text.Trim();
            L.Usuario =txtusu.Text.Trim();
            L.Contraseña = txtpass.Text.Trim();
            L.Correo = txtcorreo.Text.Trim();


            string _NombreCola = ConfigurationManager.AppSettings["ColaMsMq"];
            MessageQueue Clector     = new MessageQueue(_NombreCola);


            Clector.MessageReadPropertyFilter.SetAll();


            ((XmlMessageFormatter)Clector.Formatter).TargetTypes = new Type[] { typeof(Lector) };


            Message _MensajeEnviar = new Message(L);


            MessageQueueTransaction _Transaccion = new MessageQueueTransaction();
            _Transaccion.Begin();
            Clector.Send(_MensajeEnviar, _Transaccion);
            _Transaccion.Commit();


          lblerror.ForeColor = System.Drawing.Color.DarkGreen;
          lblerror.Text = "Se envio la solicitud para que un Admin la acepte";
            this.LimpioControles();

           
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
  
    private void LimpioControles()
    {
        txtndoc.Text = "";
        txtnomusuario.Text = "";
        txtusu.Text = "";
        txtpass.Text = "";
        txtcorreo.Text = "";
      
    }
}