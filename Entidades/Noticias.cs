using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Entidades
{
    [DataContract]
    public class Noticias
    {
        private int id;
        private string titulo;
        private string resumen;
        private string cuerponoticia;
        private bool relevante;
        private DateTime fechahoracreacion;
        private Periodista periodista = null;
        private string categoria;
        private Queue<Comentarios> listacomentarios = null;

        [DataMember]//------------------------------------------------------------------------------
        public int IdNoticia
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
             [DataMember]
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (value.Trim().Length < 40)
                    titulo = value;

                else
                    throw new Exception("Muchos Caracteres para el Titulo");
            }
        }
             [DataMember]
        public string Resumen
        {
            get { return resumen; }
            set
            {
                if (value.Trim().Length < 150)
                    resumen = value;

                else
                    throw new Exception("Muchos Caracteres para el Resumen");
            }
        }
             [DataMember]
        public string CuerpoNoticia
        {
            get { return cuerponoticia; }
            set
            {
                if (value.Trim().Length < 1500)
                    cuerponoticia = value;

                else
                    throw new Exception("Muchos Caracteres para el Cuerpo de la Noticia");
            }
        }
             [DataMember]
        public bool Relevante
        {
            get { return relevante; }
            set
            {
              relevante = value;
            }
        }
             [DataMember]
        public DateTime FechaHoraCreacion
        {
            get { return fechahoracreacion; }
            set
            {
                fechahoracreacion = value;
            }
        }
             [DataMember]
        public Periodista Periodista
        {
            get { return periodista; }
            set
            {
                if (value == null)
                {
                    throw new Exception("No existe Periodista");

                }
                else
                {
                    periodista = value;
                }
            }
        }
             [DataMember]
        public string Categoria
        {
            get { return categoria; }
            set
            {
                if (value == "Economica" || value == "Internacional" || value == "Politica" || value == "Policial")
                    categoria = value;
                    
                else
                    throw new Exception("EL tipo de Categoria no es correcto");  
            }
        }
             [DataMember]
        public Queue<Comentarios> ListaComentarios
        {
            get { return listacomentarios; }
            set
            {
                listacomentarios = value;
            }
        }
             [DataMember]
        public int CantComentarios
        {
            get
            { 
               return ListaComentarios.Count;
            }
            set { }  
        }
          [DataMember]
        public string NomPeriodista
        {
            get { return Periodista.NomPeriodista; }
            set { }
        }
        
        //-------------------------------------------------------------------------------------------------
          public Noticias(int pIdNoticia,string pTitulo,string presumen,string pcuerponoticia,bool prelevante,DateTime pfechahora,Periodista pperiodista,string pcategoria,Queue<Comentarios> pcomentarios)
        {
            IdNoticia = pIdNoticia;
            Titulo = pTitulo;
            Resumen = presumen;
            CuerpoNoticia = pcuerponoticia;
            Relevante = prelevante;
            FechaHoraCreacion = pfechahora;
            Periodista = pperiodista;
            Categoria = pcategoria;
            ListaComentarios = pcomentarios;
        }
          public Noticias()
          { }
          public override string ToString()
          {
              return (IdNoticia.ToString() + Titulo.ToString() + Resumen.ToString() + CuerpoNoticia.ToString() + Relevante.ToString() + FechaHoraCreacion.ToString() + Periodista.NomPeriodista.ToString()+Categoria.ToString());
          }
        
    }
}
