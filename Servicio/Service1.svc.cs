using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Logica;
using System.Xml;
namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        void IService1.AltaUsuario(Usuarios U,Administrador adminBD)
        {
            FabricaLogica.getLUsuarios().Alta(U,adminBD);
        }

        Usuarios IService1.LogueoUsuario(string usuario, string contraseña)
        {
            Usuarios _unusuario = null;
            _unusuario = FabricaLogica.getLUsuarios().Logueo(usuario, contraseña);
            return _unusuario;
        }
        void IService1.BajaUsuario(Usuarios B)
        {
            FabricaLogica.getLUsuarios().Baja(B);
        }
        void IService1.ModificarUsuario(Usuarios A)
        {
            FabricaLogica.getLUsuarios().Modificar(A);
        }
        Usuarios IService1.BuscarUsuario(long Ndoc)
        {
            return FabricaLogica.getLUsuarios().Buscar(Ndoc);
        }
        List<Lector> IService1.ListarLector()
        {
            return FabricaLogica.getLUsuarios().Listar();
        }
        //NOTICIAS-----------------------

        void IService1.AltaNoticias(Noticias N,Administrador adminBD)
        { FabricaLogica.getLNoticias().Alta(N,adminBD); }
        void IService1.BajaNoticia(Noticias N,Administrador adminBD)
        { FabricaLogica.getLNoticias().Baja(N,adminBD); }
        void IService1.ModificarNoticia(Noticias N,Administrador adminBD)
        { FabricaLogica.getLNoticias().Modificar(N,adminBD); }
        Noticias IService1.BuscarNoticia(int n)
        {
            return FabricaLogica.getLNoticias().Buscar(n);

        }
        List<Noticias> IService1.ListarCompletoNoticias()
        { return FabricaLogica.getLNoticias().ListarCompleto(); }
        List<Noticias> IService1.ListoRelevantes()
        { return FabricaLogica.getLNoticias().ListoRelevantes(); }
        List<Noticias> IService1.ListoEconomicas()
        { return FabricaLogica.getLNoticias().ListoEconomicas(); }
        List<Noticias> IService1.ListoPoliticas()
        { return FabricaLogica.getLNoticias().ListoPoliticas(); }
        List<Noticias> IService1.ListoPoliciales()
        {
            return FabricaLogica.getLNoticias().ListoPoliciales();
        }
        List<Noticias> IService1.ListoInternacionales()
        {
            return FabricaLogica.getLNoticias().ListoInternacionales();
        }
        string IService1.ListadoNoticiasPeriodistaXML(Periodista P)
        {
            List<Noticias> _lista = FabricaLogica.getLNoticias().ListadoNoticiasPeriodistaXML(P);

            XmlDocument _Documento = new XmlDocument();
            _Documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _Documento.DocumentElement;


            foreach (Noticias unaN in _lista)
            {
                XmlNode _Id = _Documento.CreateElement("IdNoticia");
                _Id.InnerText = unaN.IdNoticia.ToString();

                XmlNode _Titulo = _Documento.CreateElement("Titulo");
                _Titulo.InnerText = unaN.Titulo.ToString();

                XmlNode _Relevante = _Documento.CreateElement("Relevante");
                _Relevante.InnerText = unaN.Relevante.ToString();

                XmlNode _Fecha = _Documento.CreateElement("FechaHoraCreacion");
                _Fecha.InnerText = unaN.FechaHoraCreacion.ToString();

                XmlNode _Periodista = _Documento.CreateElement("NomPeriodista");
                _Periodista.InnerText = unaN.Periodista.NomPeriodista.ToString();
                XmlNode _categoria = _Documento.CreateElement("Categoria");
                _categoria.InnerText = unaN.Categoria.ToString();

                XmlNode _Nodo = _Documento.CreateElement("Noticia");
                _Nodo.AppendChild(_Id);
                _Nodo.AppendChild(_Titulo);
                _Nodo.AppendChild(_Relevante);
                _Nodo.AppendChild(_Fecha);
                _Nodo.AppendChild(_Periodista);
                _Nodo.AppendChild(_categoria);


                _raiz.AppendChild(_Nodo);

            }


            return _Documento.OuterXml;
        }
        void IService1.ComentarNoticia(Noticias N)
        {
            FabricaLogica.getLNoticias().ComentarNoticia(N);
        }
        //PERIODISTAS---------------------------------------------------
        void IService1.AltaPeriodista(Periodista L,Administrador adminBD)
        {
            FabricaLogica.getLPeriodistas().Alta(L, adminBD);
        }
        Periodista IService1.BuscarPeriodista(string l)
        {
            return FabricaLogica.getLPeriodistas().Buscar(l);
        }
        List<Periodista> IService1.ListarPeriodista()
        {
            return FabricaLogica.getLPeriodistas().Listar();
        }
        void IService1.BajaPeriodista(Periodista L,Administrador adminBD)
        {
            FabricaLogica.getLPeriodistas().Baja(L,adminBD);
        }
        void IService1.ModificarPeriodista(Periodista L,Administrador adminBD)
        {
            FabricaLogica.getLPeriodistas().Modificar(L,adminBD);
        }
    }
}
