﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ControlViaticosApp.LiquidacionesWS.Liquidar>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control de Viáticos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle de Liquidación</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">Co_Liquidacion</div>
        <div class="display-field"><%: Model.Co_Liquidacion %></div>
        
        <div class="display-label">Fe_Liquidacion</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.Fe_Liquidacion) %></div>
        
        <div class="display-label">Ss_TotalAsignado</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Ss_TotalAsignado) %></div>
        
        <div class="display-label">Ss_TotalUtilizado</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Ss_TotalUtilizado) %></div>
        
        <div class="display-label">Ss_OtrosGastos</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Ss_OtrosGastos) %></div>
        
        <div class="display-label">Solicitud</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.solicitud.Co_Solicitud) %></div>
		
    </fieldset>
	
     
    <fieldset>	
		<table>
			<thead>
				<tr>
					<th width="60" align="center">Tipo de Viatico</th>
					<th width="60" align="center">Monto Asignado</th>
					<th width="60" align="center">Monto Utilizado</th>
				</tr>
			</thead>
			<tbody>
				<% foreach (var item in Model.Detalles)  { %>
					<tr>
						<td width="60">
							<%: item.PK.TipoViatico.No_Descripcion %> 
						</td>
			
						<td width="60">
							<%: String.Format("{0:F}", item.Ss_MontoAsignado) %>
						</td>

						<td width="60">
							<%: String.Format("{0:F}", item.Ss_MontoUtilizado) %>
						</td>
					</tr>
				<% }  %>
			</tbody>
		</table>
	</fieldset>	
		<p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.Co_Liquidacion}) %> |
        <%: Html.ActionLink("Regresa a la Lista", "Index") %>
    </p>

</asp:Content>

