<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 365px;
        }
        .style9
        {
            height: 47px;
            width: 101px;
        }
        .style10
        {
            width: 365px;
            height: 47px;
        }
        .style12
        {
            width: 365px;
            height: 46px;
        }
        .style13
        {
            height: 46px;
        }
        .style14
        {
            height: 47px;
            font-size: xx-large;
        }
        .style15
        {
            height: 46px;
            width: 101px;
        }
        .style16
        {
            width: 101px;
        }
    </style>
<link href="Estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 151%; height: 341px;">
        <tr>
            <td class="style9">
            </td>
            <td class="style14">
                NOTICIAS RELEVANTES</td>
            <td class="style10">
            </td>
        </tr>
        <tr>
            <td class="style15">
            </td>
            <td class="style13">
                <asp:Repeater ID="RPRelevantes" runat="server" 
                    onitemcommand="RPRelevantes_ItemCommand">
                     <ItemTemplate>
                    <table>
                         <tr bgcolor="#CCFF99">

                                 <td>
                                    IdNoticia: <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("IdNoticia") %>' ReadOnly="True" TextMode="SingleLine"></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Titulo: <asp:TextBox ID="TxtTitulo" runat="server" Text='<%# Bind("Titulo") %>' ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Resumen: <asp:TextBox ID="TxtResumen" runat="server" Text='<%# Bind("Resumen") %>' ReadOnly="True" AutoCompleteType="None" TextMode="MultiLine"></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    FechaHoraCreacion: <asp:TextBox ID="TxtFechaHoraCreacion" runat="server" Text='<%# Bind("FechaHoraCreacion") %>' TextMode="SingleLine" ReadOnly="True"></asp:TextBox>
                                    <br />
                                </td>  
                                  <td>                            
                                     <asp:Button id="Button2" runat="server" CommandName="PaginaNoticia" style="text-align:center" text="PaginaNoticia"/>
                                </td>
                            </tr>
                    </table>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                         <table>
                        <tr bgcolor="#CCFFCC">
                            <td>
                                    IdNoticia: <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("IdNoticia") %>' ReadOnly="True" TextMode="SingleLine"></asp:TextBox>
                                    <br />
                                </td>
                               <td>
                                    Titulo: <asp:TextBox ID="TxtTitulo" runat="server" Text='<%# Bind("Titulo") %>' ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Resumen: <asp:TextBox ID="TxtResumen" runat="server" Text='<%# Bind("Resumen") %>' ReadOnly="True" AutoCompleteType="None" TextMode="MultiLine"></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    FechaHoraCreacion: <asp:TextBox ID="TxtFechaHoraCreacion" runat="server" Text='<%# Bind("FechaHoraCreacion") %>' ReadOnly="True"></asp:TextBox>
                                    <br />
                                </td>
                                <td>                              
                                    <asp:Button id="Button2" runat="server" CommandName="PaginaNoticia" style="text-align:center" text="PaginaNoticia"/>
                                </td>
                        </tr>
                    </table>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </td>
            <td class="style12">
            </td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblerror" runat="server" CssClass="dynamic"></asp:Label>
            </td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

