<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="tp_web_equipo_19A.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <link href="Premios.css" rel="stylesheet" type="text/css" />
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1 class="text-center">Elegí tu premio</h1>
            </div>
            <div class="row">
                <% foreach(Dominio.Articulo art in ListaArticulo) { %>
                <div class="col">
                    <div class="card p-2">
                        <div id="carousel<%: art.Id %>" class="carousel slide" data-bs-ride="carousel">
                            <div class="carousel-inner">
                                <% 
                                    var imagenesFiltradas = ListaImagen.Where(img => img.IdArticulo == art.Id).ToList();
                                    bool isActive = true;
                                    foreach (var img in imagenesFiltradas) { 
                                %>
                                <div class="carousel-item <%: isActive ? "active" : "" %>">
                                    <img src="<%: img.ImagenUrl %>" class="d-block" alt="<%: art.Nombre %>">
                                </div>
                                <% 
                                    isActive = false;
                                    } 
                                %>
                            </div>
                            <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%: art.Id %>" data-bs-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Previous</span>
                            </button>
                            <button class="carousel-control-next" type="button" data-bs-target="#carousel<%: art.Id %>" data-bs-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Next</span>
                            </button>
                        </div>
                        <div class="card-body d-flex flex-column justify-content-between">
                            <div>
                            <h5 class="card-title"><%: art.Nombre %></h5>
                            <p class="card-text"><%: art.Descripcion %></p>
                            </div>
                            <a href="Formulario.aspx?id=<%:art.Id %>" class="btn btn-primary">Elegir</a>
                        </div>
                    </div>
                </div>
                <% } %>
            </div>
        </div>
    </div>
</asp:Content>
