﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ControlViaticosApp.ViaticoWS.Viatico>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control de Viáticos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Ver Solicitud</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label"><b>Codigo Solicitud</b></div>
        <div class="display-field"><%: Model.CodigoSolicitud %></div>
        
        <div class="display-label"><b>Fecha Solicitud</b></div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaSolicitud) %></div>
        
        <div class="display-label"><b>Origen</b></div>
        <div class="display-field"><%: Model.CodigoUbigeoOrigen %></div>
        
        <div class="display-label"><b>Destino</b></div>
        <div class="display-field"><%: Model.CodigoUbigeoDestino %></div>
        
        <div class="display-label"><b>Fecha Salida</b></div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaSalida) %></div>
        
        <div class="display-label"><b>Fecha Retorno</b></div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaRetorno) %></div>
        
        <div class="display-label"><b>Motivo</b></div>
        <div class="display-field"><%: Model.SustentoViaje %></div>
        
        <div class="display-label"><b>Total Solicitado</b></div>
        <div class="display-field"><%: String.Format("{0:F}", Model.TotalSolicitado) %></div>        
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Modificar", "Edit", new { id = Model.CodigoSolicitud })%> |
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </p>

</asp:Content>

