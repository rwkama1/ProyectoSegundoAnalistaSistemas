using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Persistencia
{
    internal class PersistenciaPremios
    {
        internal static void Alta(string unpremio, string nombre, SqlTransaction _transaccion)
        {

            SqlCommand _comando = new SqlCommand("AltaPremio", _transaccion.Connection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Periodista", nombre);
            _comando.Parameters.AddWithValue("@Premio",unpremio);
            SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParmRetorno.Direction = ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_ParmRetorno);
            try
            {


                _comando.Transaction = _transaccion;
                _comando.ExecuteNonQuery();

                int retorno = Convert.ToInt32(_ParmRetorno.Value);
                if (retorno == -1)
                    throw new Exception("No existe ese Periodista");
                else if (retorno == -2)
                    throw new Exception("Premio ya existente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal static List<string> CargoPremiosPeriodista(string nombreP)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            SqlCommand _comando = new SqlCommand("ListarPremio", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@nomP", nombreP);
            List<string> _ListaPremios = new List<string>();
            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();

                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _ListaPremios.Add((string)_lector["Premio"]);
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

            return _ListaPremios;
        }
        internal static void EliminarPremiosPeriodista(Periodista unPeriodista, SqlTransaction _pTransaccion)
        {
            SqlCommand _comando = new SqlCommand("BajaPremios", _pTransaccion.Connection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@nom", unPeriodista.NomPeriodista);
            SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParmRetorno.Direction = ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_ParmRetorno);


            try
            {
               
                _comando.Transaction = _pTransaccion;
                _comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
