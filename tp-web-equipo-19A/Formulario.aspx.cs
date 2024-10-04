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
            string dni = TextBoxDni.Text;

            // validacion para revisar que el DNI sea numerico
            if (!EsNumerico(dni))
            {
                labelDni.Text = "El DNI ingresado no es válido. Debe contener solo números.";
                labelDni.Visible = true;
                return;
            }
            else
            {
                labelDni.Visible = false;
            }

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            //excepcion
            try
            {
                Cliente cliente = new Cliente();
                ListaCliente = clienteNegocio.Listar();

                cliente = ListaCliente.Find(Cliente => Cliente.Documento == TextBoxDni.Text);

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
                    TextBoxEmail.Enabled = false;
                    TextBoxDireccion.Enabled = false;
                    TextBoxCiudad.Enabled = false;
                    TextBoxCP.Enabled = false;




                }
                else
                {
                    TextBoxNombre.Text = string.Empty;
                    TextBoxApellido.Text = string.Empty;
                    TextBoxEmail.Text = string.Empty;
                    TextBoxDireccion.Text = string.Empty;
                    TextBoxCiudad.Text = string.Empty;
                    TextBoxCP.Text = string.Empty;

                    TextBoxNombre.Enabled = true;
                    TextBoxApellido.Enabled = true;

                    TextBoxEmail.Enabled = true;
                    TextBoxDireccion.Enabled = true;
                    TextBoxCiudad.Enabled = true;
                    TextBoxCP.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error " + ex;
                lblError.Visible = true;
            }


        }

        private bool EsNumerico(string texto)
        {
            foreach (char c in texto)
            {
                if (char.IsDigit(c) == false)
                {
                    return false;
                }
            }
            return true;
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            if (!CheckBoxTerms.Checked)
            {
                lblParticipar.Text = "Debe aceptar los términos y condiciones.";
                lblParticipar.Visible = true;
                return;
            }

            lblParticipar.Visible = false;

            if (!Page.IsValid)
            {
                lblError.Text = "Por favor, corregí los errores en el formulario.";
                lblError.Visible = true;
                return;
            }

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            ListaCliente = clienteNegocio.Listar();
            Cliente cliente = ListaCliente.Find(c => c.Documento == TextBoxDni.Text);

            // Si el cliente no existe, crear uno nuevo
            if (cliente == null)
            {
                cliente = new Cliente();
               
                    cliente.Documento = TextBoxDni.Text;
                    cliente.Nombre = TextBoxNombre.Text;
                    cliente.Apellido = TextBoxApellido.Text;
                    cliente.Email = TextBoxEmail.Text;
                    cliente.Direccion = TextBoxDireccion.Text;
                    cliente.Ciudad = TextBoxCiudad.Text;
                    cliente.CP = int.Parse(TextBoxCP.Text);
                

                clienteNegocio.agregar(cliente);

                lblParticipar.Text = "¡Cliente registrado exitosamente!";
            }
            else
            {
                lblParticipar.Text = "El cliente ya está registrado.";
            }

            //voucher
            if (Request.QueryString["voucherId"] != null)
            {
                string voucherId = Request.QueryString["voucherId"];
                if (Request.QueryString["Artid"] != null) {
                    int? Artid = int.Parse(Request.QueryString["Artid"]);

                    VoucherNegocio voucherNegocio = new VoucherNegocio();
                    Voucher voucher = new Voucher();
                    DateTime fecha = DateTime.Today;

                    voucher.CodigoVoucher = voucherId;
                    voucher.IdCliente = cliente.Id;
                    voucher.FechaCanje = fecha;
                    voucher.IdArticulo = Artid;

                    voucherNegocio.modificar(voucher.CodigoVoucher, (int)voucher.IdCliente, (DateTime)voucher.FechaCanje, (int)voucher.IdArticulo);

                    //voucherNegocio.modificar(int.Parse(voucher.CodigoVoucher), (int)voucher.IdCliente, (DateTime)voucher.FechaCanje, (int)(int?)voucher.IdArticulo);
                    lblParticipar.Text += " y voucher utilizado!";

                } else 
                { 
                    lblParticipar.Text += " El voucher no es válido.";
                }
            }

            lblParticipar.Visible = true;
            //
            // Reiniciar todos campos del formulario
            TextBoxDni.Text = string.Empty;
            TextBoxNombre.Text = string.Empty;
            TextBoxApellido.Text = string.Empty;
            TextBoxEmail.Text = string.Empty;
            TextBoxDireccion.Text = string.Empty;
            TextBoxCiudad.Text = string.Empty;
            TextBoxCP.Text = string.Empty;
            CheckBoxTerms.Checked = false;

        }
    }
}