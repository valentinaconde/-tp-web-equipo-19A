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
                datos.setearConsulta("select codigoVoucher, idCliente, fechaCanje, idArticulo from VOUCHERS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.codigoVoucher = datos.Lector["codigoVoucher"] as string;
                    aux.idCliente = datos.Lector["idCliente"] != DBNull.Value ? (int?)datos.Lector["idCliente"] : null;
                    aux.fechaCanje = datos.Lector["fechaCanje"] != DBNull.Value ? (DateTime?)datos.Lector["fechaCanje"] : null;
                    aux.idArticulo = datos.Lector["idArticulo"] != DBNull.Value ? (int?)datos.Lector["idArticulo"] : null;

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
                datos.setearConsulta("insert into VOUCHERS (idCliente, fechaCanje, idArticulo) values (@idCliente, @fechaCanje, @idArticulo)");
                datos.setearParametro("@idCliente", idCliente);
                datos.setearParametro("@fechaCanje", fechaCanje);
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(int codigoVoucher, int idCliente, DateTime fechaCanje, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update VOUCHERS set idCliente = @idCliente, fechaCanje = @fechaCanje, idArticulo = @idArticulo where codigoVoucher = @codigoVoucher");
                datos.setearParametro("@idCliente", idCliente);
                datos.setearParametro("@fechaCanje", fechaCanje);
                datos.setearParametro("@idArticulo", idArticulo);
                datos.setearParametro("@codigoVoucher", codigoVoucher);
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
                datos.setearParametro("@codigoVoucher", codigoVoucher);

                datos.setearConsulta("delete from VOUCHERS where codigoVoucher = @codigoVoucher");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
