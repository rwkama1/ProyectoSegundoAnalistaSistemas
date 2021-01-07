using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Logica
{
   public interface ILogicaUsuarios
    {
       void Alta(Usuarios U,Administrador adminBD);
       Usuarios Logueo(string usuario, string contraseña);
       void Baja(Usuarios B);
       void Modificar(Usuarios A);
       Usuarios Buscar(long Ndoc);
       List<Lector> Listar();

    }
}
