<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true"
    CodeBehind="FormMunicipio.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormMunicipio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="1">
        <ProgressTemplate>
            <img src="../Images/ajax-loader-1.gif" />
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ValidationSummary ID="ValidationSummaryMunicipio" runat="server" BackColor="#FFFF99"
                BorderStyle="Solid" BorderWidth="1px" ValidationGroup="CamposObrigatorios" />
            <br />
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Height="114px" Width="496px">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="2">
            <h2>  Cadastro de Municípios  </h2>
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="2">
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Label ID="lblMunicipio" runat="server" Text="Município:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtMunicipio" runat="server" ValidationGroup="CamposObrigatorios"
                            Width="349px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Label ID="lblUf" runat="server" Text="UF:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtUf" runat="server" ValidationGroup="CamposObrigatorios" Width="349px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Right">
                        <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click"
                            ValidationGroup="CamposObrigatorios" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                        <asp:Button ID="btnRemover" runat="server" Text="Remover" ValidationGroup="CamposObrigatorios"
                            Enabled="False" OnClick="btnRemover_Click" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow>
                    <asp:TableCell ColumnSpan="2">
                        <asp:GridView ID="GridViewMunicipio" runat="server" CellPadding="3" GridLines="Horizontal"
                            AutoGenerateSelectButton="True" OnRowEditing="GridViewMunicipio_RowEditing" OnSelectedIndexChanged="GridViewMunicipio_SelectedIndexChanged"
                            AllowPaging="True" OnPageIndexChanged="GridViewMunicipio_PageIndexChanged" Width="490px"
                            BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                            AutoGenerateColumns="False">
                            <AlternatingRowStyle BackColor="#F7F7F7" />
                            <Columns>
                                <asp:BoundField DataField="codigo" HeaderText="Código" />
                                <asp:BoundField DataField="municipio" HeaderText="Município" />
                                <asp:BoundField DataField="uf" HeaderText="UF" />
                            </Columns>
                            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <SortedAscendingCellStyle BackColor="#F4F4FD" />
                            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                            <SortedDescendingCellStyle BackColor="#D8D8F0" />
                            <SortedDescendingHeaderStyle BackColor="#3E3277" />
                        </asp:GridView>
                    </asp:TableCell>
                </asp:TableFooterRow>
            </asp:Table>
            <asp:HiddenField ID="txtCodigo" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorMunicipio" runat="server" ControlToValidate="txtMunicipio"
                ErrorMessage="Município - Campo obrigatório!" ValidationGroup="CamposObrigatorios"
                Display="None"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorMunicipio0" runat="server"
                ControlToValidate="txtUf" ErrorMessage="UF - Campo obrigatório!" ValidationGroup="CamposObrigatorios"
                Display="None"></asp:RequiredFieldValidator>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
