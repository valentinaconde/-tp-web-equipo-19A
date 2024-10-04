using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> listar()
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select CodigoVoucher, IdCliente, FechaCanje, IdArticulo from VOUCHERS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.CodigoVoucher = datos.Lector["CodigoVoucher"] as string;
                    aux.IdCliente = datos.Lector["IdCliente"] != DBNull.Value ? (int?)datos.Lector["IdCliente"] : null;
                    aux.FechaCanje = datos.Lector["FechaCanje"] != DBNull.Value ? (DateTime?)datos.Lector["FechaCanje"] : null;
                    aux.IdArticulo = datos.Lector["IdArticulo"] != DBNull.Value ? (int?)datos.Lector["IdArticulo"] : null;

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

        public void agregar(int idCliente, DateTime fechaCanje, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into VOUCHERS (IdCliente, FechaCanje, IdArticulo) values (@IdCliente, @FechaCanje, @IdArticulo)");
                datos.setearParametro("@IdCliente", idCliente);
                datos.setearParametro("@FechaCanje", fechaCanje);
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void modificar(string codigoVoucher, int idCliente, DateTime fechaCanje, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update VOUCHERS set IdCliente = @IdCliente, FechaCanje = @FechaCanje, IdArticulo = @IdArticulo where CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@IdCliente", idCliente);
                datos.setearParametro("@FechaCanje", fechaCanje);
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@CodigoVoucher", codigoVoucher);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int codigoVoucher)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearParametro("@CodigoVoucher", codigoVoucher);

                datos.setearConsulta("delete from VOUCHERS where CodigoVoucher = @CodigoVoucher");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
