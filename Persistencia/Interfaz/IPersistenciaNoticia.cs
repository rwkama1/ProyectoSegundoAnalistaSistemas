using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Persistencia
{
    public interface IPersistenciaNoticia
    {
        void Alta(Noticias N,Administrador adminBD);
        void Modificar(Noticias N,Administrador adminBD);
        void Baja(Noticias N,Administrador adminBD);
        Noticias Busco(int nid);
    
        List<Noticias> ListarCompleto();
        List<Noticias> ListarNoticiasRelevantes();
        List<Noticias> ListarNoticiasEconomica();
        List<Noticias> ListarNoticiasPolicial();
        List<Noticias> ListarNoticiasPolitica();
        List<Noticias> ListarNoticiasInternacional();
        List<Noticias> ListadoNoticiasPeriodistaXML(Periodista P);
        void ComentarNoticia(Noticias N);
 


     
    }
}
