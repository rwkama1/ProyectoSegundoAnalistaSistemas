using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
   public class FabricaPersistencia
    {
       public static IPersistenciaAdmin getPAdmin()
       {
           return (PersistenciaAdmin.GetInstancia());
       }
       public static IPersistenciaLector getPLector()
       {
           return (PersistenciaLector.GetInstancia());
       }
       public static IPersistenciaNoticia getPNoticia()
       {
           return (PersistenciaNoticia.GetInstancia());
       }
       public static IPersistenciaPeriodista getPPeriodista()
       {
           return (PersistenciaPeriodista.GetInstancia());
       }
      
    }
    
}
