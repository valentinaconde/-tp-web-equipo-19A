using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace tp_web_equipo_19A
{
    public partial class _Default : Page
    {
        public List<Voucher> ListaVoucher { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVoucherSig_Click(object sender, EventArgs e)
        {
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            ListaVoucher = voucherNegocio.listar();

            bool existeEnBD = false;
            ListaVoucher.ForEach(voucherBD => {
                if (voucherBD.codigoVoucher == voucherText.Text)
                    existeEnBD = true;
            });

            if(!existeEnBD)
            {
                Response.Redirect("ErrorVoucher.aspx", false);
            }
            else Response.Redirect("Premios.aspx?voucher=" + voucherText.Text, false);
        }
    }
}