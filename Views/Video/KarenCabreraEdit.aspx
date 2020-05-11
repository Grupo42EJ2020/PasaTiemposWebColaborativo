<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Actualizar información del Video</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Datos</legend>
            
            
           <br /> <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
           <br /> <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
           <br /> <div class="editor-label">
                <%: Html.LabelFor(model => model.Url) %>
            </div>
           <br /> <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Url) %>
                <%: Html.ValidationMessageFor(model => model.Url) %>
            </div>
            
            <br /> <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaPublicacion) %>
            </div>
            <br /> <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaPublicacion, String.Format("{0:g}", Model.FechaPublicacion)) %>
                <%: Html.ValidationMessageFor(model => model.FechaPublicacion) %>
            </div>
            <br />
            <p>
                <input type="submit" value="GUARDAR CAMBIOS" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la lista de Videos", "KarenCabrera") %>
    </div>

</body>
</html>

