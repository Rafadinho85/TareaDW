<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="TareaDW.Alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido:<asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        CUI:<asp:TextBox ID="TextBoxCUI" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="FAMILIAR A VISITAR:"></asp:Label>
        <asp:TextBox ID="TextBoxFAM_VISITAR" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="NO. TELEFONO:"></asp:Label>
        <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="DIRECCION DE LA CASA A VISITAR"></asp:Label>
        <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="FECHA DE NACIMIENTO"></asp:Label>
        <asp:TextBox ID="TextBoxFechaNac" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GUARDAR Visita" />
        <asp:Label ID="LabelExito" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Regresar</asp:HyperLink>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
