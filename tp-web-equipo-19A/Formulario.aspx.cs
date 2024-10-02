using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_19A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Cliente> ListaCliente { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBoxDni_TextChanged(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente cliente = new Cliente();
            ListaCliente = clienteNegocio.Listar();

            cliente = ListaCliente.Find(Cliente => Cliente.Documento == TextBoxDni.Text);

            //TO DO: hacer logica para guardar en FORMULARIO
            if (cliente != null)
            {
                
            }
        

        }
    }
}