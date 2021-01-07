using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Logica
{
    public interface ILogicaNoticias
    {
       void Alta(Noticias N,Administrador adminBD);
       void Baja(Noticias N,Administrador adminBD);
       void Modificar(Noticias N,Administrador adminBD);
       Noticias Buscar(int n);
       
       List<Noticias> ListarCompleto();  
       List<Noticias> ListoRelevantes();    
       List<Noticias> ListoEconomicas();     
       List<Noticias> ListoPoliticas();
       List<Noticias> ListoPoliciales();
       List<Noticias> ListoInternacionales();
       List<Noticias> ListadoNoticiasPeriodistaXML(Periodista P);
       void ComentarNoticia(Noticias N);
  
        
    }
}
