using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaNoticia:IPersistenciaNoticia
    {
          private static PersistenciaNoticia _instancia = null;
          private PersistenciaNoticia() { }
          public static PersistenciaNoticia GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaNoticia();
            return _instancia;
        }

          public void Alta(Noticias N,Administrador adminBD)
          {
              SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminBD.Usuario + "; Password=" + adminBD.Contraseña);
              SqlCommand _comando = new SqlCommand("AltaNoticias", _cnn);
              _comando.CommandType = System.Data.CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@Titulo", N.Titulo);
              _comando.Parameters.AddWithValue("@Resumen", N.Resumen);
              _comando.Parameters.AddWithValue("@CuerpoNoticia", N.CuerpoNoticia);
              _comando.Parameters.AddWithValue("@Relevante", N.Relevante);
              _comando.Parameters.AddWithValue("@Categoria", N.Categoria);
              _comando.Parameters.AddWithValue("@NomPeriodista", N.Periodista.NomPeriodista);
              SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
              _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
              _comando.Parameters.Add(_retorno);

              try
              {
                  _cnn.Open();
                  _comando.ExecuteNonQuery();
                  if ((int)_retorno.Value == -2)
                      throw new Exception("La Noticia ya existe");
                  if ((int)_retorno.Value == -3)
                      throw new Exception("El Periodista no existe");

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
          public void Modificar(Noticias N, Administrador adminBD)
          {
              SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminBD.Usuario + "; Password=" + adminBD.Contraseña);
              SqlCommand _comando = new SqlCommand("ModificarNoticias", _cnn);
              _comando.CommandType = System.Data.CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@id", N.IdNoticia);
              _comando.Parameters.AddWithValue("@Titulo", N.Titulo);
              _comando.Parameters.AddWithValue("@Resumen", N.Resumen);
              _comando.Parameters.AddWithValue("@CuerpoNoticia", N.CuerpoNoticia);
              _comando.Parameters.AddWithValue("@Relevante", N.Relevante);
              _comando.Parameters.AddWithValue("@Categoria", N.Categoria);
              _comando.Parameters.AddWithValue("@NomPeriodista", N.Periodista.NomPeriodista);
              SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
              _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
              _comando.Parameters.Add(_retorno);

              try
              {
                  _cnn.Open();
                  _comando.ExecuteNonQuery();
                  if ((int)_retorno.Value == -1)
                      throw new Exception("La Noticia no existe");
                  if ((int)_retorno.Value == -2)
                      throw new Exception("No existe ese Periodista");
                 
              }

              catch (Exception ex)
              {
                  throw ex;
              }
              finally
              {
                  _cnn.Close();
              }

          }
          public void Baja(Noticias N, Administrador adminBD)
          {
              SqlConnection _cnn = new SqlConnection("Data Source=.; Initial Catalog = Proyecto; User ID=" + adminBD.Usuario + "; Password=" + adminBD.Contraseña);
              SqlCommand _comando = new SqlCommand("BajaNoticias", _cnn);
              _comando.CommandType = System.Data.CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@id", N.IdNoticia);
              SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
              _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
              _comando.Parameters.Add(_retorno);

              try
              {
                  _cnn.Open();
                  _comando.ExecuteNonQuery();
                  if ((int)_retorno.Value == -1)
                      throw new Exception("La Noticia no existe");
                
              }
              catch (Exception ex)
              {
                  throw ex;
              }
              finally
              {
                  _cnn.Close();
              }
          }
          public Noticias Busco(int nid)
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              Noticias unanoticia = null;
              SqlCommand _comando = new SqlCommand("BuscoNoticia", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@id",nid);
              try
              {
                  _cnn.Open();
                  SqlDataReader _lector = _comando.ExecuteReader();
                  if (_lector.HasRows)
                  {
                      _lector.Read();
                      int id = (int)_lector["IdNoticia"];
                      string titulo = (string)_lector["Titulo"];
                      string resumen = (string)_lector["Resumen"];
                      string cuerponoticia = (string)_lector["CuerpoNoticia"];
                      bool relevante = (bool)_lector["Relevante"];
                      string categoria = (string)_lector["Categoria"];
                      string nomperiodista = (string)_lector["NomPeriodista"];
                      DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                      Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                      unanoticia = new Noticias(id, titulo, resumen, cuerponoticia,relevante,fechacreacion,objPeriodista,categoria,ComentariosdeNoticia(id));
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
              return unanoticia;
          }
        
          public List<Noticias> ListarCompleto()
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListoNoticia", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();


                  SqlDataReader _lector = _comando.ExecuteReader();


                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista, categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public List<Noticias> ListarNoticiasRelevantes()
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListarNoticiasRelevantes", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();

             
                  SqlDataReader _lector = _comando.ExecuteReader();
                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {

                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista,categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public List<Noticias> ListarNoticiasEconomica()
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListarNoticiasEconomica", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();


                  SqlDataReader _lector = _comando.ExecuteReader();


                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista, categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public List<Noticias> ListarNoticiasPolicial()
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListarNoticiasPolicial", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();


                  SqlDataReader _lector = _comando.ExecuteReader();


                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista, categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public List<Noticias> ListarNoticiasPolitica()
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListarNoticiasPolitica", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();


                  SqlDataReader _lector = _comando.ExecuteReader();


                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista, categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public List<Noticias> ListarNoticiasInternacional()
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListarNoticiasInternacional", _cnn);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();


                  SqlDataReader _lector = _comando.ExecuteReader();


                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista, categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public List<Noticias> ListadoNoticiasPeriodistaXML(Periodista P)
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              SqlCommand _comando = new SqlCommand("ListadoNoticiasPeriodistaXML", _cnn);
              _comando.Parameters.AddWithValue("@NomPeriodista", P.NomPeriodista);
              _comando.CommandType = CommandType.StoredProcedure;
              List<Noticias> _Lista = new List<Noticias>();
              Noticias noticiass = null;
              try
              {
                  _cnn.Open();


                  SqlDataReader _lector = _comando.ExecuteReader();


                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int id = (int)_lector["IdNoticia"];
                          string titulo = (string)_lector["Titulo"];
                          string resumen = (string)_lector["Resumen"];
                          string cuerponoticia = (string)_lector["CuerpoNoticia"];
                          bool relevante = (bool)_lector["Relevante"];
                          string categoria = (string)_lector["Categoria"];
                          string nomperiodista = (string)_lector["NomPeriodista"];
                          DateTime fechacreacion = (DateTime)_lector["FechaHoraCreacion"];
                          Periodista objPeriodista = PersistenciaPeriodista.GetInstancia().BuscoSBAJA(nomperiodista);
                          noticiass = new Noticias(id, titulo, resumen, cuerponoticia, relevante, fechacreacion, objPeriodista, categoria,ComentariosdeNoticia(id));
                          _Lista.Add(noticiass);
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
          public void ComentarNoticia(Noticias N)
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

              SqlCommand _comando = new SqlCommand("ComentarNoticia", _cnn);
              _comando.CommandType = System.Data.CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@IdNoticia", N.IdNoticia);
              _comando.Parameters.AddWithValue("@Ndoc", N.ListaComentarios.Last().Lector.Ndoc);
              _comando.Parameters.AddWithValue("@Comentario", N.ListaComentarios.Last().Comentario);
              SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
              _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
              _comando.Parameters.Add(_retorno);

              try
              {
                  _cnn.Open();
                  _comando.ExecuteNonQuery();
                  if ((int)_retorno.Value == -1)
                      throw new Exception("La Noticia no existe");
                  if ((int)_retorno.Value == -2)
                      throw new Exception("No existe el Lector");
                  if ((int)_retorno.Value == -3)
                      throw new Exception("Usted ya ingreso ese texto de Comentario en esa Noticia");

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
          internal Queue<Comentarios> ComentariosdeNoticia(int cid)
          {
              SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
              Comentarios objcom = null;
              Queue<Comentarios> _lista = new Queue<Comentarios>();

              SqlCommand _comando = new SqlCommand("ListarComentariosNoticia", _cnn);
              _comando.CommandType = System.Data.CommandType.StoredProcedure;
              _comando.Parameters.AddWithValue("@id", cid);

              try
              {
                  _cnn.Open();
                  SqlDataReader _lector = _comando.ExecuteReader();
                  if (_lector.HasRows)
                  {
                      while (_lector.Read())
                      {
                          int idcom = (int)_lector["IdComentario"];
                          long Ndoc = (long)_lector["Ndoc"];
                          string textocomentario = (string)_lector["Comentario"];
                          Lector L = PersistenciaLector.GetInstancia().Buscar(Ndoc);
                          objcom = new Comentarios(idcom, L, textocomentario);
                          _lista.Enqueue(objcom);
                      }
                  }
                  _lector.Close();
              }
              catch (Exception ex)
              {
                  throw new Exception(ex.Message);
              }
              finally
              {
                  _cnn.Close();
              }
              return _lista;
          }
    }
}
