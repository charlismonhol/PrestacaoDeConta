<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true"
    CodeBehind="FormDespesa.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormDespesa" %>

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
            <asp:HiddenField ID="txtCodigo" runat="server" />
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Height="114px" Width="496px">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="2">
            <h2>  Cadastro de Despesas  </h2>
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
                        <asp:Label ID="Label1" runat="server" Text="Descrição:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDescricao" runat="server" OnTextChanged="txtDescricao_TextChanged"
                            Width="349px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
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
                        <asp:GridView ID="GridViewDespesa" runat="server" CellPadding="3" Width="490px" GridLines="Horizontal"
                            AutoGenerateSelectButton="True" OnRowEditing="GridViewDespesa_RowEditing" OnSelectedIndexChanged="GridViewDespesa_SelectedIndexChanged"
                            BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
                            <AlternatingRowStyle BackColor="#F7F7F7" />
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
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorDespesa" runat="server" ControlToValidate="txtDescricao"
                ErrorMessage="Despesa - Campo obrigatório!" ValidationGroup="CamposObrigatorios"
                Display="None"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
