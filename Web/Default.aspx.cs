using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (!IsPostBack)
        {
          
            
            try
            {
                RPRelevantes.DataSource = new Service1Client().ListoRelevantes();
                RPRelevantes.DataBind();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }


    }
    protected void RPRelevantes_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "PaginaNoticia")
        {
            int oid = Convert.ToInt32(((TextBox)(e.Item.Controls[1])).Text);
            Session["DesNoticia"] = oid;
            Response.Redirect("PaginaNoticia.aspx");
        }
    }
}