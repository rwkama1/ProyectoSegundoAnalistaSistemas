using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Persistencia
{
    public interface IPersistenciaLector
    {
        void RegistroLector(Lector A,Administrador adminbd);
        void Baja(Lector B);
        void Modificar(Lector A);
        Usuarios Logueo(string usuario, string contraseña);
        Lector Buscar(long Ndoc);
        List<Lector> Listar();
    }
}
