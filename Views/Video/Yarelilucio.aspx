<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Yarelilucio</title>
</head>
<body>
        <center>
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
                <%: Html.ActionLink("Editar", "YarelilucioEdit", new { id=item.IdVideo }) %> |
                <%: Html.ActionLink("Detalles", "YarelilucioDetails", new {  id=item.IdVideo })%> |
                <%: Html.ActionLink("Borrar", "YarelilucioDelete", new { id=item.IdVideo })%>
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
        <%: Html.ActionLink("Nuevo video", "Create") %>
    </p>
    
    <a href="/Persona/Index">Regresar a la lista</a>
    <body style="background-color:#9AB8EA ;">
    </center>
</body>
</html>

