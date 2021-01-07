using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Persistencia
{
    public interface IPersistenciaAdmin
    {
        void Alta(Administrador A, Administrador adminBD);
        Usuarios Logueo(string usuario, string contraseña);
        Administrador Buscar(long Ndoc);
    }
}
