using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Persistencia
{
    public interface IPersistenciaPeriodista
    {
        void Alta(Periodista P,Administrador adminBD);
        Periodista Busco(string pnom);
        List<Periodista> Listo();
        void Modificar(Periodista P,Administrador adminBD);
        void Baja(Periodista P,Administrador adminBD);
        
    }
}
