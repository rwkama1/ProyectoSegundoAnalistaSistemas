using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Entidades
{
    [KnownType(typeof(Administrador))]
    [KnownType(typeof(Lector))]
    [DataContract]
    public abstract class Usuarios
    {
        private long ndoc;
        private string nomUsu;
        private string usuario;
        private string contraseña;
        [DataMember]//------------------------------------------------------------------
        public long Ndoc
        {
            get { return ndoc; }
            set { ndoc = value; }
        }
        [DataMember]
        public string NomUsu
        {
            get { return nomUsu; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de Nombre Usuario");


                else
                    nomUsu = value;
            }
        }
        [DataMember]
        public string Usuario
        {
            get { return usuario; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de Usuario");


                else
                    usuario = value;
            }
        }
        [DataMember]
        public string Contraseña
        {
            get { return contraseña; }
            set
            {
                if (value.Trim().Length > 9 || value.Trim().Length<9)
                    throw new Exception("Contraseña debe tener 9 caracteres");
                   
                else
                    contraseña = value;
               
            }
        }
       
        //------------------------------------------------------------------   //------------------------------------------------------------------
        public Usuarios(long pndoc, string pnomusu, string pusuario, string pcontr)
        {
            
            Ndoc = pndoc;
            NomUsu = pnomusu;
            Usuario = pusuario;
            Contraseña = pcontr;
        }
         public Usuarios()
        {
           
        }
         public override string ToString()
         {
             return (this.Ndoc.ToString() + this.NomUsu + this.Usuario + this.Contraseña);
         }
     
    }
}
