<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControlPaginaNoticia.ascx.cs" Inherits="UserControlPaginaNoticia" %>
<link href="Estilo.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .style1
    {
        font-size: large;
    }
</style>
<span class="style1">IDNoticia</span>:&nbsp;&nbsp; <asp:Label ID="lblid" runat="server" Enabled="False"></asp:Label>
<br />
<br />
<asp:Label ID="lblTitulo" runat="server" CssClass="Estilo" Font-Size="X-Large"></asp:Label>
<p>
    &nbsp;<asp:Label ID="lblFechaCreacion" runat="server" 
        CssClass="Estilo" Font-Size="Large"></asp:Label>
</p>
<p>
    <asp:Label ID="lblResumen" runat="server" CssClass="Estilo" Font-Size="Large"></asp:Label>
</p>
<p>
    <asp:Label ID="lblCuerpoNoticia" runat="server" CssClass="Estilo"></asp:Label>
</p>
<p>
    &nbsp; <span class="style1">PERIODISTA</span>:&nbsp; 
    <asp:Label ID="lblPeriodista" runat="server" CssClass="Estilo"></asp:Label>
</p>
<p>
    <asp:Button ID="btnact" runat="server" CssClass="Estilo" Height="31px" 
        onclick="btnact_Click" Text="Actualizar Comentarios" Width="195px" />
</p>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Height="112px" Width="280px" 
    BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
    CellPadding="2" ForeColor="Black" GridLines="None">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <Columns>
                            <asp:BoundField DataField="IdComentario" HeaderText="IdComentario" />
                            <asp:BoundField DataField="NomUsuario" HeaderText="Lector" />
                            <asp:BoundField DataField="Comentario" HeaderText="Comentario" />
                        </Columns>
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                            HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="lblerror" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>

