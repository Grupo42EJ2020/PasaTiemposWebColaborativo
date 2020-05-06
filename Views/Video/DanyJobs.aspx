<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">  

    <title>DanyJobs</title>
    <style type="text/css">
 html, body {
    width: 100%;
    height: 100%;
    display: block; 
    background: linear-gradient(to right bottom, gold, chocolate);
    font-family: sans-serif;
}
a:link, a:visited 
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

a:hover, a:focus {
  box-shadow: 0 2px 4px -1px rgba(0, 0, 0, 0.2),
    0 4px 5px 0 rgba(0, 0, 0, 0.14),
    0 1px 10px 0 rgba(0, 0, 0, 0.12);
  background-color: #159090;
}

a:active {
  box-shadow: 0 5px 5px -3px rgba(0, 0, 0, 0.2),
    0 8px 10px 1px rgba(0, 0, 0, 0.14),
    0 3px 14px 2px rgba(0, 0, 0, 0.12);
  background-color: #61b4b3;
}
	

#main-container{
	margin: 150px auto;
	width: 600px;
}

table{
	background-color: white;
	text-align: left;
	border-collapse: collapse;
	width: 100%;
}

th, td{
	padding: 20px;
}

thead{
	background-color: #246355;
	border-bottom: solid 5px #0F362D;
	color: white;
}

tr:nth-child(even){
	background-color: #ddd;
}

tr:hover td{
	background-color: #369681;
	color: white;
}   
    
    </style>
</head>
<body>

    <table>
        <tr>
            <th>  IdVideo</th>
            <th>
               Nombre
            </th>
            <th>
               Url
            </th>
            <th>
                 FechaPublicacion
            </th>
            <th>
               
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
           
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
             <td>
                 <center>              
                   
                <%: Html.ActionLink("Editar", "DanyJobsEdit", new { id = item.IdVideo })%> 
                <%: Html.ActionLink("Detalles", "DanyJobsDetails", new { id = item.IdVideo })%> 
                <%: Html.ActionLink("Eliminar", "DanyJobsDelete", new { id = item.IdVideo })%>
                  </center>
              
            </td>
        </tr>
    
    <% } %>

    </table>
      
    <p>
        <%: Html.ActionLink("Crear Nuevo", "DanyJobsCreate")%>
    </p>  
  <a href="/Persona/DanyJobs">Regresar</a>
</body>
</html>
