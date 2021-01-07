<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DatosLector.aspx.cs" Inherits="DatosLector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        font-size: xx-large;
        width: 252px;
    }
    .style7
    {
        width: 143px;
    }
    .style8
    {
        width: 252px;
    }
    .style9
    {
        width: 174px;
    }
    .style10
    {
        font-size: xx-large;
        width: 250px;
    }
    .style11
    {
            width: 250px;
        }
        .style12
        {
            width: 174px;
            height: 23px;
        }
        .style13
        {
            width: 250px;
            height: 23px;
        }
    </style>
<link href="Estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:101%; height: 330px;">
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style10">
            DATOS LECTOR</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style12">
            </td>
        <td class="style13">
            </td>
        <td class="style5">
            </td>
    </tr>
    <tr>
        <td class="style9">
            Numero Documento:</td>
        <td class="style11">
            <asp:TextBox ID="txtndoc" runat="server" Width="130px" CssClass="Estilo"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                ControlToValidate="txtndoc" 
                ErrorMessage="Numero de Documento solo debe contenter numeros" ForeColor="Red" 
                ValidationExpression="^[0-9]{1,20}$"></asp:RegularExpressionValidator>
        </td>
        <td>
            <asp:Button ID="btnbaja" runat="server" Height="27px" Text="Eliminar" 
                Width="83px" onclick="btnbaja_Click" CssClass="Estilo" />
        </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            Nombre Usuario:</td>
        <td class="style11">
            <asp:TextBox ID="txtnom" runat="server" MaxLength="19" CssClass="Estilo"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnmod" runat="server" Height="32px" Text="Modificar" 
                Width="80px" onclick="btnmod_Click" CssClass="Estilo" />
        </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            Usuario:</td>
        <td class="style11">
            <asp:TextBox ID="txtusuario" runat="server" MaxLength="19" CssClass="Estilo"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="Label1" runat="server" CssClass="Estilo"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            Contraseña:</td>
        <td class="style11">
            <asp:TextBox ID="txtcontraseña" runat="server" MaxLength="9" Width="103px" 
                CssClass="Estilo"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txtcontraseña" 
                ErrorMessage="Contraseña debe tener 9 caracteres" ForeColor="Red" 
                ValidationExpression="^[\s\S]{9,9}$"></asp:RegularExpressionValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            Correo:</td>
        <td class="style11">
            <asp:TextBox ID="txtcorreo" runat="server" MaxLength="39" CssClass="Estilo"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                ControlToValidate="txtcorreo" ErrorMessage="Eso no es un Correo" 
                ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            <br />
        </td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

