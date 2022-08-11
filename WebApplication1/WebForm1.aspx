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
        <asp:GridView ID="GridView1" runat="server" Width="246px">
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
        <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="agregar" />
            &nbsp; &nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Mostrar Datos" />
&nbsp;
            <br />
        <asp:GridView ID="GridView2" runat="server">

        </asp:GridView>
            <br />
            para eliminar selecciona el id de los datos que quieres eliminar
            <br />
            <br />
            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="true">
            </asp:DropDownList>
&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Eliminar" OnClick="Button5_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
