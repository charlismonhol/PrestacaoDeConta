<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true" CodeBehind="FormMunicipio.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormMunicipio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>  Cadastro de Municípios  </h2>
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="1">
    <ProgressTemplate>
        <img src="../Images/ajax-loader-1.gif" />
    </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <div>
        <asp:ValidationSummary ID="ValidationSummaryMunicipio" runat="server" 
            BackColor="#FFFF99" BorderStyle="Solid" BorderWidth="1px" 
            ValidationGroup="CamposObrigatorios" />
        <br />
        <asp:HiddenField ID="txtCodigo" runat="server" />
        <asp:Label ID="lblMunicipio" runat="server" Text="Município:"></asp:Label>
        <asp:TextBox ID="txtMunicipio" runat="server" 
            ValidationGroup="CamposObrigatorios"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMunicipio" runat="server" 
            ControlToValidate="txtMunicipio" ErrorMessage="Municipio - Campo obrigatório!" 
            ValidationGroup="CamposObrigatorios" Display="None"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblUf" runat="server" Text="Uf:"></asp:Label>
        <asp:TextBox ID="txtUf" runat="server" ValidationGroup="CamposObrigatorios"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMunicipio0" 
            runat="server" ControlToValidate="txtUf" ErrorMessage="Uf - Campo obrigatório!" 
            ValidationGroup="CamposObrigatorios" Display="None"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnGravar" runat="server" Text="Gravar" 
            onclick="btnGravar_Click" ValidationGroup="CamposObrigatorios" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
            onclick="btnCancelar_Click" />
        <asp:Button ID="btnRemover" runat="server" Text="Remover" 
            ValidationGroup="CamposObrigatorios" Enabled="False" 
            onclick="btnRemover_Click" />
        <br />
        <br />
        <asp:GridView ID="GridViewMunicipio" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateSelectButton="True" 
            onrowediting="GridViewMunicipio_RowEditing" 
            onselectedindexchanged="GridViewMunicipio_SelectedIndexChanged" 
          AllowPaging="True" Height="210px" 
          onpageindexchanged="GridViewMunicipio_PageIndexChanged" Width="505px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
              <asp:HyperLinkField />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NumericFirstLast" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
