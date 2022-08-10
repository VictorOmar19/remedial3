<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tabla Material<br />
        escribe el tipo de material<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        escribe la marca<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        escribe la presentacion<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
            seleccione&nbsp; el id del tipo de material<br />
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        <asp:Button ID="Button1" runat="server" Text="agregar datos" OnClick="Button1_Click" />
&nbsp;
        &nbsp;
        &nbsp;<asp:Button ID="Button4" runat="server" Text="Mostar Datos" OnClick="Button4_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="actualizar" runat="server" Text="actualizar" />
            <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>


            <br />
            --------------------------------------------------------------------------------------------------------------------------------------------------------<br />
            <br />

             Tabla de Obra<br />
        escribe el Nombre de la obra <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        escribe la direccion<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
            selecciona la fecha de inicio<br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
            seleccione la fecha de fin<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            seleccione el id del dueño<br />
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <br />
            seleccione el id del encargado<br />
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
        <asp:Button ID="Button2" runat="server" Text="agregar datos" OnClick="Button1_Click" />
&nbsp;
        &nbsp;
        &nbsp;<asp:Button ID="Button3" runat="server" Text="Mostar Datos" OnClick="Button4_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="actualizar" />
            <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        </div>
    </form>
</body>
</html>
