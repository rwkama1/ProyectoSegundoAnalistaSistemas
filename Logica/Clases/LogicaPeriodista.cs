using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Persistencia;
namespace Logica
{
    internal class LogicaPeriodista:ILogicaPeriodista
    {
        private static LogicaPeriodista instancia = null;
        private LogicaPeriodista() { }
        public static LogicaPeriodista GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaPeriodista();
            return instancia;
        }

        public void Alta(Periodista L,Administrador adminBD)
        {
            FabricaPersistencia.getPPeriodista().Alta(L,adminBD);

        }
        public Periodista Buscar(string l)
        {
            return FabricaPersistencia.getPPeriodista().Busco(l);

        }
        public List<Periodista> Listar()
        {

            return FabricaPersistencia.getPPeriodista().Listo();
        }
        public void Modificar(Periodista L,Administrador adminBD)
        {
            FabricaPersistencia.getPPeriodista().Modificar(L, adminBD);

        }
        public void Baja(Periodista L,Administrador adminBD)
        {
            FabricaPersistencia.getPPeriodista().Baja(L,adminBD);

        }
    }

}
