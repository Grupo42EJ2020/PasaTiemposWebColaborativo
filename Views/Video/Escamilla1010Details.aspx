<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalles del Video</title>
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
    <fieldset>
        <legend>Datos</legend>
        
        <div class="display-label">IdVideo</div>
        <div class="display-field"><%: Model.IdVideo %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Url</div>
        <div class="display-field"><%: Model.Url %></div>
        
        <div class="display-label">FechaPublicacion</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaPublicacion) %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Escamilla1010Edit", new {  id=Model.IdVideo  }) %> |
        <%: Html.ActionLink("Regresar a la lista","Escamilla1010") %>
    </p>

</body>
</html>

