<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Borrar</title>
    <style type="text/css">    
      html, body {
    width: 100%;
    height: 100%;  
    background: linear-gradient(to right bottom, gold, chocolate);
    font-family: sans-serif;
    
}
a:link, a:visited ,.button
{
    text-decoration:none;
  padding: 0 16px;
  border-radius: 2px;
  background-color: #018786;
  box-shadow: 0 3px 1px -2px rgba(0, 0, 0, 0.2),
    0 2px 2px 0 rgba(0, 0, 0, 0.14),
    0 1px 5px 0 rgba(0, 0, 0, 0.12);
  color: #fff;
  transition: background-color 15ms linear,
    box-shadow 280ms cubic-bezier(0.4, 0, 0.2, 1);

  height: 36px;
  line-height: 2.25rem;
  font-family: Roboto, sans-serif;
  font-size: 0.875rem;
  font-weight: 500;
  letter-spacing: 0.06em;
  text-transform: uppercase;
}

a:hover, a:focus , .button:hover, .button:focus{
  box-shadow: 0 2px 4px -1px rgba(0, 0, 0, 0.2),
    0 4px 5px 0 rgba(0, 0, 0, 0.14),
    0 1px 10px 0 rgba(0, 0, 0, 0.12);
  background-color: #159090;
}

a:active,.button:active {
  box-shadow: 0 5px 5px -3px rgba(0, 0, 0, 0.2),
    0 8px 10px 1px rgba(0, 0, 0, 0.14),
    0 3px 14px 2px rgba(0, 0, 0, 0.12);
  background-color: #61b4b3;
}
</style>
</head>
<body>
    <h3>¿Estas seguro de que lo quieres borrar?</h3>
    <fieldset>
        <legend>Información</legend>
        
        <div class="display-label"><b>IdVideo:</b></div>
        <div class="display-field"><%: Model.IdVideo %></div>
        
        <div class="display-label"><b>Nombre:</b></div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label"><b>Url:</b></div>
        <div class="display-field"><%: Model.Url %></div>
        
        <div class="display-label"><b>FechaPublicacion:</b></div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaPublicacion) %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" class="button" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar a la lista", "/DanyJobs") %>
        </p>
    <% } %>

</body>
</html>



