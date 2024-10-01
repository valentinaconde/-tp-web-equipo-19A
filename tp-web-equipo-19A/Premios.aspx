<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="tp_web_equipo_19A.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1 class="text-center">Elegí tu premio</h1>
            </div>
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-4">
                        <!-- TO DO: traer datos de la base de datos -->
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title
                                    ">Premio 1</h5>
                                <p class="card-text">Descripción del premio 1</p>
                                <asp:Button ID="seleccionarBtn" CssClass="btn btn-primary" runat="server" Text="Elegir premio" />
                              </div>
                          </div>
                     </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
