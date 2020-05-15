<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Escamilla1010</title>
    <style type="text/css">
    html, body 
    {
    width: 100%;
    height: 110%; 
    background: #FFAA00;
    font-family: sans-serif; 
    }    
  a:hover
  {
    color: #FF4800;
    background-color: #FF9100;
    text-decoration: none;
  }
    </style>
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
                <%: Html.ActionLink("Editar", "Escamilla1010Edit", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Detalles", "Escamilla1010Details", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Eliminar", "Escamilla1010Delete", new { id = item.IdVideo })%>
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
        <%: Html.ActionLink("Crear Nuevo", "Escamilla1010Create")%>
        <br />
        <a href="/Persona/Escamilla1010">Regresar al apartado Escamilla1010</a>

    </p>

</body>
</html>

