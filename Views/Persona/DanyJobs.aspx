<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DanyJobs</title>   
    
<link rel="stylesheet" type="text/css" href="../../Content/Hoja.css" />

    <style type="text/css">
        
     html, body {
    width: 100%;
    height: 100%;
    display: block; 
    background: linear-gradient(to right bottom, gold, chocolate);
    font-family: sans-serif;
    
}

:root {
    --x: 5em;
    --y: 1.5em;
}

div ul {
    list-style-type: none;
    padding: 0;
}

div ul li {
    font-size: 40px;
    font-family: sans-serif;
    background-color: white;
    border: 2px solid black;
    letter-spacing: 0.1em;
    width: var(--x);
    height: var(--y);
    line-height: var(--y);
    position: relative;
    overflow: hidden;
    margin: 0.5em;

}

div ul li span {
    color: white;
    mix-blend-mode: difference;
}

div ul li::before {
    content: '';
    position: absolute;
    width: var(--y);
    height: var(--y);
    background-color: black;
    border-radius: 50%;
    top: 0;
    left: calc(-1 * var(--y) / 2);
    transition: 0.5s ease-out;
}

div ul li:hover::before {
    --r: calc(var(--x) * 1.2);
    width: var(--r);
    height: var(--r);
    top: calc(-1 * var(--r) / 2 + var(--y) / 2);
    left: calc(-1 * var(--r) / 2 + var(--x) / 2);
} 
a:link, a:visited, a:active {
    text-decoration:none;
    padding: 25px;
    padding-left: 20px;
    padding-right: 107px;
    font-weight: 300;
    font-size: 25px;
    color:White;
}

 </style>
</head>
<body>
    <form id="form1" runat="server">
    <center>  
    <h1>Dany Jobs</h1>
    <br />
    <h2>Mis Pasatiempos son jugar video juegos, ver series y ver youtube</h2>
    <br /> 
    </center> 
    <div>
            <ul>
                <li><span><a href="/Persona/Index">Regresar</a></span></li>
              <li> <span><a href="/Video/DanyJobs">Lista</a></span> </li>
             
            
            </ul> 
    </div>
 
    </form>
</body>
</html>
