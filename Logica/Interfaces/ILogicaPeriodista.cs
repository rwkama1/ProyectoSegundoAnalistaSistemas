using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Logica
{
   public interface ILogicaPeriodista
    {
        void Alta(Periodista L,Administrador adminBD);
        Periodista Buscar(string l);
        List<Periodista> Listar();
        void Baja(Periodista L,Administrador adminBD);
        void Modificar(Periodista L,Administrador adminBD);
    }
}
