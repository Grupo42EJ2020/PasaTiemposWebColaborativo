<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ErickMedellin</title>
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
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "ErickMedellinEdit", new {  id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Ver Detalles", "ErickMedellinDetails", new {  id = item.IdVideo  })%> |
                <%: Html.ActionLink("Borrar", "ErickMedellinDelete", new {  id = item.IdVideo  })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
          </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Video", "ErickMedellinCreate") %>
        <a href ="/Persona/ErickMedellin">Regresar</a>
    </p>

</body>
</html>

