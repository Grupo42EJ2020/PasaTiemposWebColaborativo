<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>IrvingDeLaGarza</title>
</head>
<body style="background-color:Aqua ;">
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
                 <%: Html.ActionLink("Editar", "IrvingDeLaGarzaEdit", new {  id=item.IdVideo  }) %> |
                <%: Html.ActionLink("Detalles", "IrvingDeLaGarzaDetails", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Eliminar", "IrvingDeLaGarzaDelete", new { id = item.IdVideo })%>
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
        <%: Html.ActionLink("Nuevo Video", "Create")%>
    </p>
    <style>
    a { color: Black; } /* CSS link color */
  </style>
    <center>  <a href="/Persona/IrvingDeLaGarza">Regresar a mi pagina de pasatiempos</a> </center>
    </style>
     <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
     <a href="/Persona/Index">Regresar a la lista de Personas</a> </center>
    </style>
</body>
</html>

