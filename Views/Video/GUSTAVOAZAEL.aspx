<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>GUSTAVOAZAEL</title>
        <style type="text/css">
html, body {
    font-family: sans-serif; 
} 
</style>
</head>
<body style="background-color:#000000 ;">
<br />
<br />
  <h1 align="center" style="color:#E4CF00" >- Lista de Videos -</h1>
<br />
    <table>
        <tr>
            <th></th>
            <th style="color:#E4CF00"> 
                IdVideo
            </th>
            <th style="color:#E4CF00"> 
                Nombre
            </th>
            <th style="color:#E4CF00"> 
                Url
            </th>
            <th style="color:#E4CF00"> 
                FechaPublicacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "GustavoAzaelEdit", new {  id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Detalles", "GustavoAzaelDetails", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Borrar", "GustavoAzaelDelete", new { id = item.IdVideo })%>|
            </td>
            <td style="color:#FFFFFF;">
                <%: item.IdVideo %>
            </td>
            <td style="color:#FFFFFF;">
                <%: item.Nombre %>
            </td>
            <td style="color:#FFFFFF;">
                <%: item.Url %>
            </td>
            <td style="color:#FFFFFF;">
                <%: String.Format("{0:g}", item.FechaPublicacion) %>
            </td>
        </tr>
    
    <% } %>

    </table>
    <hr />
    <p>
        <%: Html.ActionLink("Nuevo Video", "Create") %>     |     <a href="/Persona/Index">Regresar a la lista de personas</a>
    </p>  
    
</body>
</html>

