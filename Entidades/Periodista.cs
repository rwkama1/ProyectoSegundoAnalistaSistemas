using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace Entidades
{
    [DataContract]
    public class Periodista
    {
        private string nomperiodista;
        private string nacionalidad;
        private DateTime fechanacimiento;
        private List<string> listapremios;
        [DataMember] //-----------------------------------------------------------------------------------------------------
        public string NomPeriodista
        {
            get { return nomperiodista; }
            set
            {
                if (value.Trim().Length < 20)
                    nomperiodista = value;

                else
                    throw new Exception("Muchos Caracteres para el nombre");
            }
        }
             [DataMember]
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set
            {
                if (value.Trim().Length < 20)
                    nacionalidad = value;

                else
                    throw new Exception("Muchos Caracteres para la nacionalidad");
            }
        }
             [DataMember]
        public DateTime Fechanacimiento
        {
            get { return fechanacimiento; }
            set
            {
                fechanacimiento = value;
            }
        }
             [DataMember]
        public List<string> ListaPremios
        {
            get { return listapremios; }
            set { listapremios = value; }
        }
       //---------------------------------------------------------------------------------------------------------------------
        public Periodista(string pnombre, string pnacionalidad, DateTime pfecha, List<string> ppremios)
        {
            NomPeriodista = pnombre;
            Nacionalidad = pnacionalidad;
            Fechanacimiento = pfecha;
            ListaPremios = ppremios;
        }
        public Periodista()
        { }

    }
}
