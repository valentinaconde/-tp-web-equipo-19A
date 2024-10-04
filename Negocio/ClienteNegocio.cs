using System.Collections.Generic;
using System;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM CLIENTES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Documento = datos.Lector["Documento"] != DBNull.Value ? datos.Lector["Documento"].ToString() : string.Empty;
                    aux.Nombre = datos.Lector["Nombre"] != DBNull.Value ? datos.Lector["Nombre"].ToString() : string.Empty;
                    aux.Apellido = datos.Lector["Apellido"] != DBNull.Value ? datos.Lector["Apellido"].ToString() : string.Empty;
                    aux.Email = datos.Lector["Email"] != DBNull.Value ? datos.Lector["Email"].ToString() : string.Empty;
                    aux.Direccion = datos.Lector["Direccion"] != DBNull.Value ? datos.Lector["Direccion"].ToString() : string.Empty;
                    aux.Ciudad = datos.Lector["Ciudad"] != DBNull.Value ? datos.Lector["Ciudad"].ToString() : string.Empty;
                    aux.CP = datos.Lector["CP"] != DBNull.Value ? (int)datos.Lector["CP"] : 0;

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Cliente nuevo)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("INSERT INTO CLIENTES (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setearParametro("@Documento", nuevo.Documento);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Direccion", nuevo.Direccion);
                datos.setearParametro("@Ciudad", nuevo.Ciudad);
                datos.setearParametro("@CP", nuevo.CP);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Cliente modificar)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("UPDATE CLIENTES SET Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Direccion = @Direccion, Ciudad = @Ciudad, CP = @CP WHERE Id = @Id");
                datos.setearParametro("@Documento", modificar.Documento);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Apellido", modificar.Apellido);
                datos.setearParametro("@Email", modificar.Email);
                datos.setearParametro("@Direccion", modificar.Direccion);
                datos.setearParametro("@Ciudad", modificar.Ciudad);
                datos.setearParametro("@CP", modificar.CP);
                datos.setearParametro("@Id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM CLIENTES WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Cliente buscarCliente(string DNI)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente cliente = new Cliente();
            try
            {
                datos.setearConsulta("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM CLIENTES WHERE Documento = @DNI");
                datos.setearParametro("@DNI", DNI);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    cliente.Id = (int)datos.Lector["Id"];
                    cliente.Documento = datos.Lector["Documento"] != DBNull.Value ? datos.Lector["Documento"].ToString() : string.Empty;
                    cliente.Nombre = datos.Lector["Nombre"] != DBNull.Value ? datos.Lector["Nombre"].ToString() : string.Empty;
                    cliente.Apellido = datos.Lector["Apellido"] != DBNull.Value ? datos.Lector["Apellido"].ToString() : string.Empty;
                    cliente.Email = datos.Lector["Email"] != DBNull.Value ? datos.Lector["Email"].ToString() : string.Empty;
                    cliente.Direccion = datos.Lector["Direccion"] != DBNull.Value ? datos.Lector["Direccion"].ToString() : string.Empty;
                    cliente.Ciudad = datos.Lector["Ciudad"] != DBNull.Value ? datos.Lector["Ciudad"].ToString() : string.Empty;
                    cliente.CP = datos.Lector["CP"] != DBNull.Value ? (int)datos.Lector["CP"] : 0;
                }

                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
