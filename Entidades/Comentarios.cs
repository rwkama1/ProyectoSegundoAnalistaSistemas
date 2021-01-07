using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Entidades
{
    [DataContract]
    public class Comentarios
    {
        private int idcomentario;
        private Lector lector = null;
        private string  comentario;
        [DataMember]//---------------------------------------------------------------------------------------------------
        public int IdComentario
        {
            get { return idcomentario; }
            set
            {
                idcomentario = value;   
            }
        }
         [DataMember]
        public Lector Lector
        {
            get { return lector; }
            set
            {
                if (value == null)
                {
                    throw new Exception("No existe el Lector");

                }
                else
                    lector = value;
            }
        }
          [DataMember]
        public string Comentario
        {
            get { return comentario; }
            set
            {
                if (value.Trim().Length < 150)
                    comentario = value;

                else
                    throw new Exception("Muchos Caracteres para el Comentario");
            }
        }
         [DataMember]
          public string NomUsuario
          {
              get { return Lector.NomUsu; }
              set
              {
               
              }
          }
        //---------------------------------------------------------------
         public Comentarios(int pidcom ,Lector plector,string pcomentario)
        {
            IdComentario = pidcom;
            Lector = plector;
            Comentario = pcomentario;
        }
         public Comentarios()
        {

        }
        public override string ToString()
        {
            return ( this.Comentario.ToString()+this.NomUsuario.ToString());
        }
    }
}
