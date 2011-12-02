<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true"
    CodeBehind="FormFuncionario.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormFuncionario" %>

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
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#FFFF99"
        BorderStyle="Solid" BorderWidth="1px" ValidationGroup="CamposObrigatorios" />
    <br />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:HiddenField ID="txtCodigo" runat="server" />
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Height="114px" Width="496px">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="2">
              <h2> Cadastro de Funcionários </h2>
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
                        <asp:Label ID="Label1" runat="server" Text="Nome Funcionário:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNomeFuncionario" runat="server" ValidationGroup="CamposObrigatorios"
                            Width="349px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Label ID="Label2" runat="server" Text="Tipo de Funcionário:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="txtTipoFuncionario" runat="server" Width="349px">
                            <asp:ListItem Value="-1"> Selecione o Tipo do Funcionário.</asp:ListItem>
                            <asp:ListItem Value="0">Administrador</asp:ListItem>
                            <asp:ListItem Value="1">Atendendimento Externo</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Label ID="Labe3" runat="server" Text="Login:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtLogin" runat="server" ValidationGroup="CamposObrigatorios"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Label ID="Label4" runat="server" Text="Senha:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell HorizontalAlign="Right">
                        <asp:Label ID="Label5" runat="server" Text="Confirmação:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtConfirmaSenha" runat="server" TextMode="Password"></asp:TextBox>
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
                        <asp:Button ID="btmCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                        <asp:Button ID="btnRemover" runat="server" Text="Remover" ValidationGroup="CamposObrigatorios"
                            Enabled="False" OnClick="btnRemover_Click" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow>
                    <asp:TableCell ColumnSpan="2">
                        <asp:GridView ID="GridViewFuncionario" runat="server" CellPadding="3" GridLines="Horizontal"
                            AutoGenerateSelectButton="True" OnRowEditing="GridViewMunicipio_RowEditing" OnSelectedIndexChanged="GridViewMunicipio_SelectedIndexChanged"
                            Width="490px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                            AutoGenerateColumns="False">
                            <AlternatingRowStyle BackColor="#F7F7F7" />
                            <Columns>
                                <asp:BoundField DataField="Codigo" HeaderText="Código" />
                                <asp:BoundField DataField="Nome" HeaderText="Funcionário" />
                                <asp:BoundField DataField="Login" HeaderText="Login" />
                                <asp:BoundField DataField="TipoFuncionario" HeaderText="Tipo Funcionário" />
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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNomeFuncionario"
                ErrorMessage="Nome Funcionário - Campo obrigatório!" ValidationGroup="CamposObrigatorios"
                Display="None"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLogin"
                ErrorMessage="Login - Campo Obrigatório !" ValidationGroup="CamposObrigatorios"
                Display="None"></asp:RequiredFieldValidator>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
