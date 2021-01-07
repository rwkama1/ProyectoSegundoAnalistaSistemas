using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class FabricaLogica
    {
        public static ILogicaNoticias getLNoticias()
        {
            return (LogicaNoticias.GetInstancia());
        }
        public static ILogicaPeriodista getLPeriodistas()
        {
            return (LogicaPeriodista.GetInstancia());
        }
        public static ILogicaUsuarios getLUsuarios()
        {
            return (LogicaUsuarios.GetInstancia());
        }
    }
}
