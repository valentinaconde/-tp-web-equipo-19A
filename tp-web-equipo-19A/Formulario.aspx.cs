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
            //VALIDACION DNI
            if (cliente != null)
            {
                TextBoxNombre.Text = cliente.Nombre;
                TextBoxApellido.Text = cliente.Apellido;
                TextBoxEmail.Text = cliente.Email;
                TextBoxDireccion.Text = cliente.Direccion;
                TextBoxCiudad.Text = cliente.Ciudad;
                TextBoxCP.Text = cliente.CP.ToString();

                TextBoxNombre.Enabled = false; 
                TextBoxApellido.Enabled = false;

              

            } else
            {
                TextBoxNombre.Text = string.Empty;
                TextBoxApellido.Text = string.Empty;
                TextBoxEmail.Text = string.Empty;
                TextBoxDireccion.Text = string.Empty;
                TextBoxCiudad.Text = string.Empty;
                TextBoxCP.Text = string.Empty;

                TextBoxNombre.Enabled = true;
                TextBoxApellido.Enabled = true;
            }
            //to do: agregar excepciones
        

        }
    }
}