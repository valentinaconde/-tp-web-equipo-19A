using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public string codigoVoucher { get; set; }
        public int idCliente { get; set; }

        public DateTime fechaCanje { get; set; }

        public int idArticulo { get; set; }
    }
}
