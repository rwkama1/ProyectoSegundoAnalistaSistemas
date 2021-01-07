using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Entidades
{
    [DataContract]
    public class Lector:Usuarios
    {
        private string correo;
        [DataMember]//------------------------------------------------------------------
       public string Correo
       {
           get { return correo; }
           set
           {
               if (value.ToString().Length < 40)
               { correo = value; }
               else
                   throw new Exception("Muchos caracteres para Correo Electronico");
           }
       }
     
        //------------------------------------------------------------------
       public Lector(long pndoc, string pnomusu, string pusuario, string pcontr, string pcorreo)
           : base(pndoc, pnomusu, pusuario, pcontr)
       {
           Correo = pcorreo;
       }
       public Lector()
        {
        }

       public override string ToString()
       {
           return (NomUsu.ToString());
       }
    }
}
