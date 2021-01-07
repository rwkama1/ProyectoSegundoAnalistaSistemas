using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Entidades
{
    [DataContract]
    public class Administrador:Usuarios
    {
        private bool generaLectores;

        [DataMember]//----------------------------------------
        public bool GeneraLectores
        {
            get { return generaLectores; }
            set { generaLectores = value; }
        }

        //----------------------------------------

        public Administrador(long pndoc, string pnomusu, string pusuario, string pcontr, bool pgeneravuelo)
            : base(pndoc, pnomusu, pusuario, pcontr)
        {
            GeneraLectores = pgeneravuelo;
        }

        public Administrador()
        {

        }

        public override string ToString()
        {
            return base.ToString() + GeneraLectores;
        }
        
    }
}
