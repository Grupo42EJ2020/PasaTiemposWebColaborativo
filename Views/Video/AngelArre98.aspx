﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AngelArre98</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdVideo
            </th>
            <th>
                Nombre
            </th>
            <th>
                Url
            </th>
            <th>
                FechaPublicacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                 <%: Html.ActionLink("Editar", "AngelArre98Edit", new {  id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Detalles", "AngelArre98Details", new { id=item.IdVideo  })%> |
                <%: Html.ActionLink("Borrar", "AngelArre98Delete", new {  id=item.IdVideo  })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Url %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.FechaPublicacion) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Video", "AngelArre98Create")%>
    </p>
    <style>
    a { color: Black; } /* CSS link color */
  </style>
    <center>  <a href="/Persona/AngelArre98">Regresar a mi pagina de pasatiempos</a> </center>
    </style>
</body>
</html>
