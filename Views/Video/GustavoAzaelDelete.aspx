<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">

    <title>Borrar Video GustavoAzael</title>
            <style type="text/css">
html, body {
    font-family: sans-serif; 
} 
</style>
</head>
<body style="background-color:#000000 ;">
    <h3 style="color:#E4CF00" >¿Esta seguro de eliminar la siguiente informacion?</h3>
    <fieldset>
        <legend style="color:#E4CF00" >Datos del Video</legend>
        
        <div class="display-label" style="color:#FFFFFF;">IdVideo</div>
        <div class="display-field" style="color:#FFFFFF;"><%: Model.IdVideo %></div>
        
        <div class="display-label" style="color:#FFFFFF;">Nombre</div>
        <div class="display-field"style="color:#FFFFFF;"><%: Model.Nombre %></div>
        
        <div class="display-label" style="color:#FFFFFF;">Url</div>
        <div class="display-field" style="color:#FFFFFF;"><%: Model.Url %></div>
        
        <div class="display-label" style="color:#FFFFFF;">FechaPublicacion</div>
        <div class="display-field" style="color:#FFFFFF;"><%: String.Format("{0:g}", Model.FechaPublicacion) %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Borrar" />  |
		    <%: Html.ActionLink("Regresar a la lista de Videos", "/GustavoAzael") %>
        </p>
    <% } %>

</body>
</html>

