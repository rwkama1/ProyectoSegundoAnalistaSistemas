using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaLector:IPersistenciaLector
    {
             private static PersistenciaLector _instancia = null;
             private PersistenciaLector() { }
             public static PersistenciaLector GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaLector();
            return _instancia;
        }
             public Usuarios Logueo(string usuario, string contraseña)
             {
                 SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
                 Usuarios usu = null;

                 SqlCommand _comando = new SqlCommand("LogueoLector", _cnn);
                 _comando.CommandType = System.Data.CommandType.StoredProcedure;
                 _comando.Parameters.AddWithValue("@usuario", usuario);
                 _comando.Parameters.AddWithValue("@contraseña", contraseña);

                 try
                 {
                     _cnn.Open();
                     SqlDataReader _lector = _comando.ExecuteReader();
                     if (_lector.HasRows)
                     {
                         _lector.Read();
                         long pndoc = (long)_lector["Ndoc"];
                         string pnombre = (string)_lector["NomUsuario"];
                         string pusuario = (string)_lector["Usuario"];
                         string pcontraseña = (string)_lector["Constraseña"];
                          string pcorreo = (string)_lector["Correo"];
                         usu = new Lector
                             (pndoc, pnombre, pusuario, pcontraseña,pcorreo);
                     }
                 }
                 catch (Exception ex)
                 {
                     throw new Exception(ex.Message);
                 }
                 finally
                 {
                     _cnn.Close();
                 }
                 return usu;
             }
             public void RegistroLector(Lector A,Administrador adminbd)
             {
                 SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminbd.Usuario + "; Password=" + adminbd.Contraseña);
                 SqlCommand _comando = new SqlCommand("RegistroLector", _cnn);
                 _comando.CommandType = System.Data.CommandType.StoredProcedure;
                 _comando.Parameters.AddWithValue("@Ndoc", A.Ndoc);
                 _comando.Parameters.AddWithValue("@Nom", A.NomUsu);
                 _comando.Parameters.AddWithValue("@Usuario", A.Usuario);
                 _comando.Parameters.AddWithValue("@Constraseña", A.Contraseña);
                 _comando.Parameters.AddWithValue("@Correo", A.Correo);
                 SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
                 _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                 _comando.Parameters.Add(_retorno);

                 try
                 {
                     _cnn.Open();
                     _comando.ExecuteNonQuery();
                     if ((int)_retorno.Value == -1)
                         throw new Exception("El Lector ya existe");
                     if ((int)_retorno.Value == -3)
                         throw new Exception("Usuario ya existente");

                 }
                 catch (Exception ex)
                 {
                     throw new Exception(ex.Message);
                 }
                 finally
                 {
                     _cnn.Close();
                 }

             }
             public void Modificar(Lector A)
             {
                 SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

                 SqlCommand _comando = new SqlCommand("ModificoLector", _cnn);
                 _comando.CommandType = System.Data.CommandType.StoredProcedure;
                 _comando.Parameters.AddWithValue("@Ndoc", A.Ndoc);
                 _comando.Parameters.AddWithValue("@Nom", A.NomUsu);
                 _comando.Parameters.AddWithValue("@Usuario", A.Usuario);
                 _comando.Parameters.AddWithValue("@Constraseña", A.Contraseña);
                 _comando.Parameters.AddWithValue("@Correo", A.Correo);
                 SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
                 _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                 _comando.Parameters.Add(_retorno);

                 try
                 {
                     _cnn.Open();
                     _comando.ExecuteNonQuery();
                     if ((int)_retorno.Value == -1)
                         throw new Exception("El Lector no existe");
                     if ((int)_retorno.Value == -3)
                         throw new Exception("Usuario ya existente");
                 
                 }
                 catch (Exception ex)
                 {
                     throw new Exception(ex.Message);
                 }
                 finally
                 {
                     _cnn.Close();
                 }

             }
             public void Baja(Lector B)
             {
                 SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

                 SqlCommand _comando = new SqlCommand("BajaLector", _cnn);
                 _comando.CommandType = System.Data.CommandType.StoredProcedure;
                 _comando.Parameters.AddWithValue("@Ndoc", B.Ndoc);
                 SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
                 _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
                 _comando.Parameters.Add(_retorno);

                 try
                 {
                     _cnn.Open();
                     _comando.ExecuteNonQuery();
                     if ((int)_retorno.Value == -1)
                         throw new Exception("El Lector no existe");


                 }
                 catch (Exception ex)
                 {
                     throw new Exception(ex.Message);
                 }
                 finally
                 {
                     _cnn.Close();
                 }
             }
             public Lector Buscar(long Ndoc)
             {

                 Lector a = null;
                 SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
                 SqlCommand oComando = new SqlCommand("Exec BuscoLector " + Ndoc, oConexion);

                 SqlDataReader oReader;

                 try
                 {
                     oConexion.Open();
                     oReader = oComando.ExecuteReader();
                     if (oReader.Read())
                     {
                         long ndoc = (long)oReader["Ndoc"];
                         string nombre = (string)oReader["NomUsuario"];
                         string usuario = (string)oReader["Usuario"];
                         string contraseña = (string)oReader["Constraseña"];
                         string correo = (string)oReader["Correo"];

                         a = new Lector(ndoc, nombre, usuario, contraseña,correo);
                     }
                     oReader.Close();
                 }
                 catch (Exception ex)
                 {
                     throw new Exception(ex.Message);
                 }
                 finally
                 {
                     oConexion.Close();
                 }
                 return a;
             }
             public List<Lector> Listar()
             {
                 SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
                 SqlCommand _comando = new SqlCommand("ListarLector", _cnn);
                 _comando.CommandType = CommandType.StoredProcedure;
                 List<Lector> _Lista = new List<Lector>();
                 Lector Lector = null;
                 try
                 {
                     _cnn.Open();


                     SqlDataReader _lector = _comando.ExecuteReader();


                     if (_lector.HasRows)
                     {
                         while (_lector.Read())
                         {
                             long ndoc = (long)_lector["Ndoc"];
                             string nombre = (string)_lector["NomUsuario"];
                             string usuario = (string)_lector["Usuario"];
                             string contraseña = (string)_lector["Constraseña"];
                             string correo = (string)_lector["Correo"];

                             Lector = new Lector(ndoc, nombre, usuario, contraseña, correo);
                             _Lista.Add(Lector);
                         }
                     }

                     _lector.Close();
                 }
                 catch (Exception ex)
                 {
                     throw ex;
                 }
                 finally
                 {
                     _cnn.Close();
                 }


                 return _Lista;
             }

    }
}
