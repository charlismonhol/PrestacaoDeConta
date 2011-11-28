<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true" CodeBehind="FormDespesa.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormDespesa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <h2>  Cadastro de Despesas  </h2>
    
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="1">
        <ProgressTemplate>
           <img src="../Images/ajax-loader-1.gif" />
        </ProgressTemplate>
        </asp:UpdateProgress>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <asp:ValidationSummary ID="ValidationSummaryMunicipio" runat="server" 
            BackColor="#FFFF99" BorderStyle="Solid" BorderWidth="1px" 
            ValidationGroup="CamposObrigatorios" />
            <asp:HiddenField ID="txtCodigo" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescricao" runat="server" Height="18px" 
            ontextchanged="txtDescricao_TextChanged" Width="349px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDespesa" runat="server" 
            ControlToValidate="txtDescricao" ErrorMessage="Despesa - Campo obrigatório!" 
            ValidationGroup="CamposObrigatorios" Display="None"></asp:RequiredFieldValidator>
        <br />
        <asp:GridView ID="GridViewDespesa" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateSelectButton="True" 
            onrowediting="GridViewDespesa_RowEditing" 
            onselectedindexchanged="GridViewDespesa_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnGravar" runat="server" Text="Gravar" 
            onclick="btnGravar_Click" ValidationGroup="CamposObrigatorios" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
            onclick="btnCancelar_Click" />
        <asp:Button ID="btnRemover" runat="server" Text="Remover" 
            ValidationGroup="CamposObrigatorios" Enabled="False" 
            onclick="btnRemover_Click" />
       </ContentTemplate>
       </asp:UpdatePanel>
  
  
 </asp:Content>
