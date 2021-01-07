<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HistoricoNoticias.aspx.cs" Inherits="HistoricoNoticias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
        width: 349px;
    }
        .style10
        {
            font-size: large;
        }
        .style11
        {
        width: 349px;
        font-size: x-large;
    }
        .style14
        {
            font-size: large;
            width: 83px;
        }
        .style15
        {
            width: 83px;
        }
    .style16
    {
        height: 85px;
    }
    .style18
    {
        height: 18px;
    }
    .style19
    {
        width: 349px;
        height: 85px;
    }
    .style20
    {
        font-size: large;
        width: 197px;
    }
    .style21
    {
        width: 197px;
    }
        .style22
        {
            font-size: large;
            width: 170px;
        }
        .style23
        {
            width: 170px;
        }
    </style>
<link href="Estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 113%; height: 232px;">
        <tr>
            <td class="style11">
                DATOS PERIODISTA</td>
            <td class="style22">
                &nbsp;</td>
            <td class="style20">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td class="style22">
                Seleccionar Periodista:
            </td>
            <td class="style20">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                <span class="style10">Nombre:</span>&nbsp;
                <asp:Label ID="lblnombre" runat="server" CssClass="Estilo" Font-Size="Large"></asp:Label>
            </td>
            <td class="style23">
                <asp:DropDownList ID="CBOPeriodistas" runat="server" Height="29px" 
                    Width="139px" CssClass="Estilo" AutoPostBack="True" 
                    onselectedindexchanged="CBOPeriodistas_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style21">
                <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style23">
                &nbsp;</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                <span class="style10">Nacionalidad:</span>&nbsp;
                <asp:Label ID="lblnacionalidad" runat="server" CssClass="Estilo" 
                    Font-Size="Large"></asp:Label>
            </td>
            <td class="style23">
                &nbsp;</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style23">
                Seleccionar Categoria:</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                <span class="style10">Fecha Nacimiento:</span>
                <asp:Label ID="lblfecha" runat="server" CssClass="Estilo" Font-Size="Large"></asp:Label>
            </td>
            <td class="style23">
                <asp:DropDownList ID="CBOCategory" runat="server" CssClass="Estilo" 
                    AutoPostBack="True" Enabled="False" 
                    onselectedindexchanged="CBOCategory_SelectedIndexChanged">
                    <asp:ListItem>Economica</asp:ListItem>
                    <asp:ListItem>Internacional</asp:ListItem>
                    <asp:ListItem>Politica</asp:ListItem>
                    <asp:ListItem>Policial</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style23">
                &nbsp;</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style19">
                <span class="style10">Premios:</span><br />
                <br />
                <asp:ListBox ID="LBpremios" runat="server" Height="93px" Width="254px" 
                    Enabled="False" CssClass="Estilo">
                </asp:ListBox>
            </td>
            <td class="style16" colspan="4">
                <asp:Xml ID="Xml1" runat="server" TransformSource="~/Noticiaxslt.xslt"></asp:Xml>
            </td>
        </tr>
        <tr>
            <td class="style18" colspan="5">
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style23">
                &nbsp;</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style23">
                &nbsp;</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style23">
                &nbsp;</td>
            <td class="style21">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

