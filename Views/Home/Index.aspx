<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio</title>
    <style type="text/css">
    html, body
    {
    width: 100%;
    height: 110%; 
    background: #FFFFFF;
    font-family: Helvetica; 
    }
    a:link, a:visited{
    text-decoration: none;
    padding: 20px;
    font-family: Helvetica;
    text-transform: uppercase;
    padding-left: 10px;
    padding-right: 10px;
    font-weight: 200;
    font-size: 25px;
    color: black;
    width:200px;
    height:25px;
    text-align:center;
    display: inline-block;
    margin: 20px 20px 0 20px;
    background-color: #d3dde0;
    }
    a:hover{
    color: #4c5557;
    background-color: #dff2f7;
    text-decoration: none;
    }           
    
    </style>
</head>
<body>
<center>
    <img src="../../Content/images/logo-facpya.png" />
    </center>
    <hr />
    <h1>
        <br />
        <br />
        Bienvenido a la Página de Pasatiempos 
        <br />
        de los miembros de la 
        <br />
        Empresa42EJ2020 &#128207;
    </h1>
    <center>
    <a href="/Persona/Index">Ver lista </a> 
    </center>
</body>
</html>
