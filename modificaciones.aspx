<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificaciones.aspx.cs" Inherits="TareaDW.modificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre de usuario:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Apellido:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            CUI:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Familiar a Visitar:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Telefono<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            Direccion:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            Nacimiento:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modificar" />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Regresar</asp:HyperLink>
        </div>
    </form>
</body>
</html>
