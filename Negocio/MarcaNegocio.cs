using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class MarcaNegocio
    {
        public List<Marca> listar() 
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = datos.Lector["Descripcion"].ToString();

                    lista.Add(aux);
                }

                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion) values (@Descripcion)");
                datos.setearParametro("@Descripcion", descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(int id, string desc)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @Descripcion where Id = @Id");
                datos.setearParametro("@Descripcion", desc);
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@Id", id);

                datos.setearConsulta("UPDATE ARTICULOS SET IdMarca = NULL WHERE IdMarca = @Id");
                datos.ejecutarAccion();

                datos.setearConsulta("delete from MARCAS where Id = @Id");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
