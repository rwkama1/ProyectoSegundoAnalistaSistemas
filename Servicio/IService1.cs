using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Logica;
namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //USUARIO
        [OperationContract]
        void AltaUsuario(Usuarios U,Administrador adminBD);
        [OperationContract]
        Usuarios LogueoUsuario(string usuario, string contraseña);
        [OperationContract]
        void BajaUsuario(Usuarios B);
        [OperationContract]
        void ModificarUsuario(Usuarios A);
        [OperationContract]
        Usuarios BuscarUsuario(long Ndoc);
        [OperationContract]
        List<Lector> ListarLector();
        //NOTICIAS------------------------------------------------------------------------
        [OperationContract]
        void AltaNoticias(Noticias N,Administrador adminBD);
        [OperationContract]
        void BajaNoticia(Noticias N,Administrador adminBD);
        [OperationContract]
        void ModificarNoticia(Noticias N,Administrador adminBD);
        [OperationContract]
        Noticias BuscarNoticia(int n);
        [OperationContract]
        List<Noticias> ListarCompletoNoticias();
        [OperationContract]
        List<Noticias> ListoRelevantes();
        [OperationContract]
        List<Noticias> ListoEconomicas();
        [OperationContract]
        List<Noticias> ListoPoliticas();
        [OperationContract]
        List<Noticias> ListoPoliciales();
        [OperationContract]
        List<Noticias> ListoInternacionales();
        [OperationContract]
        string ListadoNoticiasPeriodistaXML(Periodista P);
        [OperationContract]
        void ComentarNoticia(Noticias N);
        //PERIODISTAS-----------------------------------------------------------------------------
        [OperationContract]
        void AltaPeriodista(Periodista L,Administrador adminBD);
        [OperationContract]
        Periodista BuscarPeriodista(string l);
        [OperationContract]
        List<Periodista> ListarPeriodista();
        [OperationContract]
        void BajaPeriodista(Periodista L,Administrador adminBD);
        [OperationContract]
        void ModificarPeriodista(Periodista L,Administrador adminBD);
    }
}
