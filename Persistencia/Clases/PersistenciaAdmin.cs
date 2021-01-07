using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaAdmin:IPersistenciaAdmin
    {
          private static PersistenciaAdmin _instancia = null;
          private PersistenciaAdmin() { }
          public static PersistenciaAdmin GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaAdmin();
            return _instancia;
        }
          public void Alta(Administrador A,Administrador adminBD)
          {
           
              SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID="+adminBD.Usuario+"; Password="+adminBD.Contraseña);
              SqlCommand _comando = new SqlCommand("AltaAdministrador", _cnn);
              _comando.CommandType = System.Data.CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@Ndoc", A.Ndoc);
              _comando.Parameters.AddWithValue("@NomUsuario", A.NomUsu);
              _comando.Parameters.AddWithValue("@Usuario", A.Usuario);
              _comando.Parameters.AddWithValue("@Constraseña", A.Contraseña);
              _comando.Parameters.AddWithValue("@AprobarLector", A.GeneraLectores);
              SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
              _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
              _comando.Parameters.Add(_retorno);

              try
              {
                  _cnn.Open();
                  _comando.ExecuteNonQuery();
                  if ((int)_retorno.Value == -1)
                      throw new Exception("El Administrador ya existe");
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
          public Usuarios Logueo(string usuario, string contraseña)
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
           
              Usuarios usu = null;

              SqlCommand _comando = new SqlCommand("LogueoAdministrador", _cnn);
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
                      usu = new Administrador
                          (pndoc, pnombre, pusuario, pcontraseña, false);
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
          public Administrador Buscar(long Ndoc)
          {


              Administrador a = null;
              SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("BuscoAdmin", oConexion);
              _comando.CommandType = CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@Ndoc", Ndoc);

              SqlDataReader oReader;

              try
              {
                  oConexion.Open();
                  oReader = _comando.ExecuteReader();
                  if (oReader.Read())
                  {
                      long ndoc = (long)oReader["Ndoc"];
                      string nombre = (string)oReader["NomUsuario"];
                      string usuario = (string)oReader["Usuario"];
                      string contraseña = (string)oReader["Constraseña"];
                      bool generalectores = (bool)oReader["AprobarLectores"];


                      a = new Administrador(ndoc, nombre, usuario, contraseña, generalectores);
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
    }
}
