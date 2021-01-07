<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaginaNoticia.aspx.cs" Inherits="PaginaNoticia" %>

<%@ Register src="UserControlPaginaNoticia.ascx" tagname="UserControlPaginaNoticia" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 23px;
            font-size: xx-large;
            width: 418px;
        }
        .style4
        {
            height: 23px;
            font-size: xx-large;
            width: 543px;
        }
        .style5
        {
            width: 543px;
        }
        .style7
        {
            width: 428px;
            height: 76px;
        }
        .style8
        {
            height: 76px;
            }
        .style9
        {
            height: 23px;
            font-size: xx-large;
            width: 69px;
        }
        .style10
        {
            width: 69px;
        }
        .style11
        {
            height: 76px;
            width: 6px;
        }
        .style12
        {
            width: 418px;
        }
        .style13
        {
            height: 76px;
            width: 306px;
        }
        .style14
        {
            width: 428px;
        }
        .style15
        {
            width: 6px;
        }
    </style>
    <link href="Estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style4">
                    PAGINA NOTICIA</td>
                <td class="style1">
                    <asp:Menu ID="Menu1" runat="server">
                        <Items>
                            <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Principal" Value="Principal">
                            </asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    </td>
                <td class="style5">
                    </td>
                <td class="style12">
                    </td>
            </tr>
            </table>
        <table style="width:100%;">
            <tr>
                <td class="style11">
                </td>
                <td class="style7">
                    <uc1:UserControlPaginaNoticia ID="UserControlPaginaNoticia1" runat="server" />
                </td>
                <td class="style13">
                    <asp:TextBox ID="txtcomentario" runat="server" Height="122px" MaxLength="149" 
                        TextMode="MultiLine" Width="322px" CssClass="Estilo"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnComentar" runat="server" Height="36px" 
                        Text="ComentarNoticia" Width="153px" onclick="btnComentar_Click" 
                        CssClass="Estilo" />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblerror" runat="server" CssClass="Estilo"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    <br />
                </td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style12" colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
