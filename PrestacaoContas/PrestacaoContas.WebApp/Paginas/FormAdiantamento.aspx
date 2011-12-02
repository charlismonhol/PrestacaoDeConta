<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true"
    CodeBehind="FormAdiantamento.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormAdiantamento" %>

<%@ Register Src="../Controles/DatePickerControl.ascx" TagName="DatePickerControl"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Height="114px" Width="496px">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell ColumnSpan="2">
              <h2>
    Cadastro de Adiantamento de Viagens/Diárias
  </h2>
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
            <asp:TableCell HorizontalAlign="Right" Width="150px">
                <asp:Label ID="Label4" runat="server" Text="Código:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtCodigoAdiantamento" runat="server" CssClass="textEntry" Enabled="False"
                    ForeColor="#666666" ReadOnly="True" Width="58px"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Label ID="Label3" runat="server" Text="Funcionário"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="cbxFuncionario" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                    Width="357px">
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtDescricao" runat="server" Width="359px"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Label ID="Label5" runat="server" Text="Data do Adiantamento:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <uc1:DatePickerControl ID="dpcDataAdiantamento" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Right">
                <asp:Label ID="Label6" runat="server" Text="Data da Prestação:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <uc1:DatePickerControl ID="dpcDataPrestacao" runat="server" />
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
                <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click1"
                    ValidationGroup="CamposObrigatorios" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                <asp:Button ID="btnRemover" runat="server" Text="Remover" ValidationGroup="CamposObrigatorios"
                    Enabled="False" />
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
                <asp:GridView ID="GridViewAdiantamento" runat="server" CellPadding="3" GridLines="Vertical"
                    AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewAdiantamento_SelectedIndexChanged"
                    Width="490px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px"
                    AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:BoundField DataField="codigo_adiantamento" HeaderText="Código" />
                        <asp:BoundField DataField="codigo_funcionario" HeaderText="Código Funcionário" />
                        <asp:BoundField DataField="data_adiantamento" HeaderText="Data Adiantamento" />
                        <asp:BoundField DataField="data_prestacao" HeaderText="Data Prestação" />
                        <asp:BoundField DataField="descricao_viagem" HeaderText="Descrição" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>
    <asp:HiddenField ID="txtCodigo" runat="server" OnValueChanged="txtCodigo_ValueChanged" />
</asp:Content>
