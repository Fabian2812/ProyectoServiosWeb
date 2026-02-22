<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoServiosWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEmail" runat="server" Placeholder="Correo" />
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Contraseña" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
