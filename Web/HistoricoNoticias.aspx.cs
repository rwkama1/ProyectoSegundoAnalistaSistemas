using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;
using System.Xml;
using System.Xml.XPath;
public partial class HistoricoNoticias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USU"] is Lector)
        {
           
            if (!IsPostBack)
                this.PeriodistasEnDropDownList();
          
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void PeriodistasEnDropDownList()
    {
       

        List<Periodista> objp = new Service1Client().ListarPeriodista().ToList();
        if (objp.Count > 0)
        {
         
            CBOPeriodistas.DataSource = objp;
            CBOPeriodistas.DataValueField = "NomPeriodista";
            CBOPeriodistas.DataTextField = "NomPeriodista";
            CBOPeriodistas.DataBind();
        }
        else
        {
            Label1.Text = "Error: no existe ningun Periodista. Debe ingresar uno primero.";
            CBOPeriodistas.Enabled = false;
        }

    }
    protected void CBOPeriodistas_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Label1.Text = "";
            Periodista p = new Service1Client().BuscarPeriodista(CBOPeriodistas.SelectedValue.ToString());
            lblnombre.Text = p.NomPeriodista;
            lblnacionalidad.Text = p.Nacionalidad;
            lblfecha.Text = p.Fechanacimiento.ToString();
            LBpremios.DataSource = p.ListaPremios;
            LBpremios.DataBind();
            XmlDocument _MiDoc = new XmlDocument();
            _MiDoc.LoadXml(new Service1Client().ListadoNoticiasPeriodistaXML(p));
            XmlDocument _documento = new XmlDocument();
            _documento.LoadXml(_MiDoc.OuterXml);
            Xml1.DocumentContent = _documento.OuterXml;
            Session["Documento"] = _documento;
            CBOCategory.Enabled = true;
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    protected void CBOCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
           
            XmlDocument _documento = (XmlDocument)Session["Documento"];


            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;


            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Noticia[Categoria = '" + CBOCategory.Text + "' ]");
            Label1.Text = "";
            if (_Resultado.Count > 0)
            {
                while (_Resultado.MoveNext())
                {

                    XmlNode idxml = _DocumentoFiltrado.CreateElement("IdNoticia");
                    idxml.InnerText = _Resultado.Current.SelectSingleNode("IdNoticia").ToString();

                    XmlNode tituloxml = _DocumentoFiltrado.CreateElement("Titulo");
                    tituloxml.InnerText = _Resultado.Current.SelectSingleNode("Titulo").ToString();

                    XmlNode relevantexml = _DocumentoFiltrado.CreateElement("Relevante");
                    relevantexml.InnerText = _Resultado.Current.SelectSingleNode("Relevante").ToString();

                    XmlNode fechaxml = _DocumentoFiltrado.CreateElement("FechaHoraCreacion");
                    fechaxml.InnerText = _Resultado.Current.SelectSingleNode("FechaHoraCreacion").ToString();

                    XmlNode nomxml = _DocumentoFiltrado.CreateElement("NomPeriodista");
                    nomxml.InnerText = _Resultado.Current.SelectSingleNode("NomPeriodista").ToString();

                    XmlNode catxml = _DocumentoFiltrado.CreateElement("Categoria");
                    catxml.InnerText = _Resultado.Current.SelectSingleNode("Categoria").ToString();
                    XmlNode _Nodo = _DocumentoFiltrado.CreateElement("Noticia");
                    _Nodo.AppendChild(idxml);
                    _Nodo.AppendChild(tituloxml);
                    _Nodo.AppendChild(relevantexml);
                    _Nodo.AppendChild(fechaxml);
                    _Nodo.AppendChild(nomxml);
                    _Nodo.AppendChild(catxml);
                    _raiz.AppendChild(_Nodo);

                }


                Xml1.DocumentContent = _DocumentoFiltrado.OuterXml;


            }
            else
            {

                Label1.Text = "El Periodista no tiene esa Categoria en la Noticia";
            }
        }

        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
}