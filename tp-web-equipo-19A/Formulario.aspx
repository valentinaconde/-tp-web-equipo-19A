<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="tp_web_equipo_19A.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <h1 class="text-left">Ingresá tus datos</h1>
            <div class="row">
                <div>
                    <asp:Label ID="labelDni" CssClass="form-label"  runat="server" Text="DNI"></asp:Label>
                    <asp:TextBox ID="TextBoxDni" CssClass="form-control" runat="server" OnTextChanged="TextBoxDni_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fieldDni" runat="server" ControlToValidate="TextBoxDni" ErrorMessage="Requiere DNI" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
             </div>
            <div  class="row my-3">
                 <div class="col-4">
                     <asp:Label ID="labelNombre" CssClass="form-label"  runat="server" Text="Nombre"></asp:Label>
                     <asp:TextBox ID="TextBoxNombre" CssClass="form-control" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="fieldNombre" runat="server" ControlToValidate="TextBoxNombre" ErrorMessage="Requiere Nombre" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                 </div>
                <div class="col-4">
                    <asp:Label ID="labelApellido" CssClass="form-label"  runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="TextBoxApellido" CssClass="form-control" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="fieldApellido" runat="server" ControlToValidate="TextBoxApellido" ErrorMessage="Requiere Apellido" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                  <div class="col-4 ">
                      
                      <asp:Label ID="labelEmail" CssClass="form-label"  runat="server" Text="Email"></asp:Label>
                      <div class="input-group">
                          <span class="input-group-text">@</span>
                          <asp:TextBox ID="TextBoxEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="fieldEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Requiere Email" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                      </div>
                  </div>
     
            </div>
             <div  class="row">
                <div class="col-4 ">
                    <asp:Label ID="labelDireccion" CssClass="form-label "  runat="server" Text="Dirección"></asp:Label>
                    <asp:TextBox ID="TextBoxDireccion" CssClass="form-control w-100" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fieldDireccion" runat="server" ControlToValidate="TextBoxDireccion" ErrorMessage="Requiere Direccion" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4">
                    <asp:Label ID="labelCiudad" CssClass="form-label"  runat="server" Text="Ciudad"></asp:Label>
                    <asp:TextBox ID="TextBoxCiudad" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fieldCiudad" runat="server" ControlToValidate="TextBoxCiudad" ErrorMessage="Requiere Ciudad" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4">
                    <asp:Label ID="labelCP" CssClass="form-label"  runat="server" Text="CP"></asp:Label>
                    <asp:TextBox ID="TextBoxCP" CssClass="form-control" runat="server" placeholder="Código Postal"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fieldCP" runat="server" ControlToValidate="TextBoxCP" ErrorMessage="Requiere Codigo Postal" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
            </div>
             <div class="my-3">
                 <asp:CheckBox ID="CheckBoxTerms" Text="Acepto los términos y condiciones." runat="server" />
            </div>
            <div>
                <asp:Button ID="btnParticipar" runat="server" CssClass="btn btn-primary" Text="Participar!" OnClick="btnParticipar_Click" />
                <asp:Label ID="lblParticipar" CssClass="form-label"  runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblError" CssClass="form-label"  runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
