<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tp_web_equipo_19A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="container">
            <p class="fs-4 fw-medium">Ingresá el código de tu voucher!</p>
            <p class="fs-6 fst-italic">El código distingue entre mayúsculas y minúsculas</p>
            <asp:TextBox ID="voucherText" runat="server" CssClass="form-control"></asp:TextBox>
            <div>
                <asp:Button ID="BtnVoucherSig" runat="server" CssClass="btn btn-primary mt-2" Text="Siguiente" OnClick="BtnVoucherSig_Click" />

            </div>
        </div>
   
    </main>

</asp:Content>
