using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaPeriodista:IPersistenciaPeriodista
    {
             private static PersistenciaPeriodista _instancia = null;
             private PersistenciaPeriodista() { }
             public static PersistenciaPeriodista GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaPeriodista();
            return _instancia;
        }
             public void Alta(Periodista P, Administrador adminBD)
             {
                 SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminBD.Usuario + "; Password=" + adminBD.Contraseña);
                 SqlCommand _comando = new SqlCommand("AltaPeriodistas", _cnn);
                 _comando.CommandType = System.Data.CommandType.StoredProcedure;
                 _comando.Parameters.AddWithValue("@NomPeriodista", P.NomPeriodista);
                 _comando.Parameters.AddWithValue("@Nacionalidad", P.Nacionalidad);
                 _comando.Parameters.AddWithValue("@FechaNacimiento", P.Fechanacimiento);
                 SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
                 _ParmRetorno.Direction = ParameterDirection.ReturnValue;
                 _comando.Parameters.Add(_ParmRetorno);

                 SqlTransaction _miTransaccion = null;

                 try
                 {
                     _cnn.Open();
                     _miTransaccion = _cnn.BeginTransaction();
                     _comando.Transaction = _miTransaccion;
                     _comando.ExecuteNonQuery();
                     int afectados = Convert.ToInt32(_ParmRetorno.Value);
                     if (afectados == -1)
                         throw new Exception("Periodista ya existente");
                     else if (afectados == -2)
                         throw new Exception("Error no especificado");
                     foreach (string unpremio in P.ListaPremios)
                     {
                         PersistenciaPremios.Alta(unpremio, P.NomPeriodista, _miTransaccion);
                     }
                     _miTransaccion.Commit();
                 }
                 catch (Exception ex)
                 {
                     _miTransaccion.Rollback();
                     throw new Exception(ex.Message);
                 }
                 finally
                 {
                     _cnn.Close();
                 }
             }
             public void Baja(Periodista P, Administrador adminBD)
       {
           SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminBD.Usuario + "; Password=" + adminBD.Contraseña);
           SqlCommand _comando = new SqlCommand("BajaPeriodistas", _cnn);
           _comando.CommandType = System.Data.CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@NomPeriodista",P.NomPeriodista);
           SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
           _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
           _comando.Parameters.Add(_retorno);

           try
           {
               _cnn.Open();
               _comando.ExecuteNonQuery();
               if ((int)_retorno.Value == -1)
                   throw new Exception("Periodista No existe");

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
             public void Modificar(Periodista P, Administrador adminBD)
       {
           SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminBD.Usuario + "; Password=" + adminBD.Contraseña);
           SqlCommand _comando = new SqlCommand("ModificarPeriodista", _cnn);
           _comando.CommandType = System.Data.CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@Nom", P.NomPeriodista);
           _comando.Parameters.AddWithValue("@Nacionalidad", P.Nacionalidad);
           _comando.Parameters.AddWithValue("@FechaN", P.Fechanacimiento);
           SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
           _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
           _comando.Parameters.Add(_retorno);

           SqlTransaction _miTransaccion = null;

           try
           {
               _cnn.Open();
               _miTransaccion = _cnn.BeginTransaction();

               _comando.Transaction = _miTransaccion;
               _comando.ExecuteNonQuery();
               if ((int)_retorno.Value == -1)
                   throw new Exception("Periodista no existe");
               else if ((int)_retorno.Value == -2)
                   throw new Exception("Error en Modificacion del Periodista");

               PersistenciaPremios.EliminarPremiosPeriodista(P, _miTransaccion);

               foreach (string unPremio in P.ListaPremios)
               {
                   PersistenciaPremios.Alta(unPremio, P.NomPeriodista, _miTransaccion);
               }

               _miTransaccion.Commit();
           }
           catch (Exception ex)
           {
               _miTransaccion.Rollback();
               throw ex;
           }
           finally
           {
               _cnn.Close();
           }
       }
             public Periodista Busco(string pnom)
       {
           SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
           Periodista _unPeriodista = null;
           SqlCommand _comando = new SqlCommand("BuscarPeriodistas", _cnn);
           _comando.CommandType = CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@nom", pnom);
           try
           {    
               _cnn.Open();
               SqlDataReader _lector = _comando.ExecuteReader();
               if (_lector.HasRows)
               {
                   _lector.Read();
                   string nom = (string)_lector["NomPeriodista"];
                   string nacion = (string)_lector["Nacionalidad"];
                   DateTime fecha = (DateTime)_lector["FechaNacimiento"];
                   _unPeriodista =new Periodista(nom, nacion, fecha, PersistenciaPremios.CargoPremiosPeriodista(pnom));
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
           return _unPeriodista;
       }
             internal Periodista BuscoSBAJA(string pnom)
       {
           SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
           Periodista _unPeriodista = null;
           SqlCommand _comando = new SqlCommand("BuscarPeriodistasSBAJA", _cnn);
           _comando.CommandType = CommandType.StoredProcedure;
           _comando.Parameters.AddWithValue("@nom", pnom);
           try
           {
               _cnn.Open();
               SqlDataReader _lector = _comando.ExecuteReader();
               if (_lector.HasRows)
               {
                   _lector.Read();
                   string nom = (string)_lector["NomPeriodista"];
                   string nacion = (string)_lector["Nacionalidad"];
                   DateTime fecha = (DateTime)_lector["FechaNacimiento"];
                   _unPeriodista = new Periodista(nom, nacion, fecha, PersistenciaPremios.CargoPremiosPeriodista(pnom));
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
           return _unPeriodista;
       }
             public List<Periodista> Listo()
       {
           SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

           SqlCommand _comando = new SqlCommand("ListPeriodistas", _cnn);
           _comando.CommandType = CommandType.StoredProcedure;

           List<Periodista> _Lista = new List<Periodista>();
           Periodista P = null;

           try
           {
               _cnn.Open();


               SqlDataReader _lector = _comando.ExecuteReader();


               if (_lector.HasRows)
               {
                   while (_lector.Read())
                   {
                       string nom = (string)_lector["NomPeriodista"];
                   string nacion = (string)_lector["Nacionalidad"];
                   DateTime fecha = (DateTime)_lector["FechaNacimiento"];
                    P = new Periodista(nom,nacion,fecha,PersistenciaPremios.CargoPremiosPeriodista((string)_lector["NomPeriodista"]));
                     _Lista.Add(P);
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
