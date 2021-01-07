using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Persistencia;
namespace Logica
{
    internal class LogicaUsuarios:ILogicaUsuarios
    {
         private static LogicaUsuarios instancia = null;
         private LogicaUsuarios() { }
         public static LogicaUsuarios GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaUsuarios();
            return instancia;
        }

         public void Alta(Usuarios U,Administrador adminBD)
         {
             if (U is Administrador)
             {
                 FabricaPersistencia.getPAdmin().Alta((Administrador)U,adminBD);
             }
             else if (U is Lector)
             {
                 FabricaPersistencia.getPLector().RegistroLector((Lector)U,adminBD);
             }
         }
         public Usuarios Logueo(string usuario, string contraseña)
         {
             Usuarios _unusuario = null;
             _unusuario = FabricaPersistencia.getPAdmin().Logueo(usuario, contraseña);
             if (_unusuario == null)
                 _unusuario = FabricaPersistencia.getPLector().Logueo(usuario, contraseña);
             return _unusuario;

         }
         public void Baja(Usuarios B)
         {
             if (B is Lector)
             {

                 FabricaPersistencia.getPLector().Baja((Lector)B);
             }
             else
             {
                 throw new Exception("No se puede dar de Baja a ese Usuario");
             }
             //hacer un else con un mensaje throw new exception
         }
         public void Modificar(Usuarios A)
         {
             if (A is Lector)
             {
                 FabricaPersistencia.getPLector().Modificar((Lector)A);
             }
             else
             {
                 throw new Exception("No se puede Modificar a ese Usuario");
             }

             //hacer un else con un mensaje throw new exception
         }
         public Usuarios Buscar(long Ndoc)
         {
             Usuarios usu = null;
             usu = FabricaPersistencia.getPAdmin().Buscar(Ndoc);
             if (usu == null)
             {
                 usu = FabricaPersistencia.getPLector().Buscar(Ndoc);
             }
             return usu;
         }
         public List<Lector> Listar()
         {
             return FabricaPersistencia.getPLector().Listar();
         }
    }
}
