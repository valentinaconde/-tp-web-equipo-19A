using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace tp_web_equipo_19A
{
    public partial class Premios : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        public List<Imagen> ListaImagen { get; set; }

        public string voucherId;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["voucher"] != null)
                {
                    System.Diagnostics.Debug.WriteLine("ENTRA");
                    voucherId = Request.QueryString["voucher"].ToString();
                }
                else
                {
                    voucherId = string.Empty;
                }

                ArticuloNegocio negocio = new ArticuloNegocio();
                ListaArticulo = negocio.Listar();
                ListaImagen = negocio.ListarImagenes();

            }
        }
    }
}