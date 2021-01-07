using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Persistencia;
namespace Logica
{
    internal class LogicaNoticias:ILogicaNoticias
    {
         private static LogicaNoticias instancia = null;
         private LogicaNoticias() { }
         public static LogicaNoticias GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaNoticias();
            return instancia;
        }

         public void Alta(Noticias N,Administrador adminBD)
         {
             FabricaPersistencia.getPNoticia().Alta(N,adminBD);

         }
         public void Baja(Noticias N,Administrador adminBD)
         {
             FabricaPersistencia.getPNoticia().Baja(N,adminBD);

         }
         public void Modificar(Noticias N,Administrador adminBD)
         {
             FabricaPersistencia.getPNoticia().Modificar(N, adminBD);

         }
         public Noticias Buscar(int n)
         {
             return FabricaPersistencia.getPNoticia().Busco(n);

         }    
         public List<Noticias> ListarCompleto()
         {
             return FabricaPersistencia.getPNoticia().ListarCompleto();
         }
         public List<Noticias> ListoRelevantes()
         {
             return FabricaPersistencia.getPNoticia().ListarNoticiasRelevantes();
         }
         public List<Noticias> ListoEconomicas()
         {
             return FabricaPersistencia.getPNoticia().ListarNoticiasEconomica();
         }
         public List<Noticias> ListoPoliticas()
         {
             return FabricaPersistencia.getPNoticia().ListarNoticiasPolitica();
         }
         public List<Noticias> ListoPoliciales()
         {
             return FabricaPersistencia.getPNoticia().ListarNoticiasPolicial();
         }
         public List<Noticias> ListoInternacionales()
         {
             return FabricaPersistencia.getPNoticia().ListarNoticiasInternacional();
         }
         public List<Noticias> ListadoNoticiasPeriodistaXML(Periodista P)
         {
             return FabricaPersistencia.getPNoticia().ListadoNoticiasPeriodistaXML(P);
         }
         public void ComentarNoticia(Noticias N)
         {
           FabricaPersistencia.getPNoticia().ComentarNoticia(N);
         }
       

    }
}
