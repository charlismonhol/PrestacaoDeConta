<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true" CodeBehind="FormFuncionario.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <h2>  Cadastro de Funcionários  </h2>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="1">
    <ProgressTemplate>
        <img src="../Images/ajax-loader-1.gif" />
    </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
    <div >
    
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            BackColor="#FFFF99" BorderStyle="Solid" BorderWidth="1px" 
            ValidationGroup="CamposObrigatorios" />
        <br />
        <asp:HiddenField ID="txtCodigo" runat="server" />
        <asp:Label ID="Label3" runat="server" Text="Nome Funcionário:"></asp:Label>
        <asp:TextBox ID="txtNomeFuncionario" runat="server" 
            ValidationGroup="CamposObrigatorios" Width="337px"></asp:TextBox>
        <br />
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtNomeFuncionario" ErrorMessage="Nome Funcionário - Campo obrigatório!" 
            ValidationGroup="CamposObrigatorios" Display="None"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Tipo Funcionário:"></asp:Label>
        <asp:DropDownList ID="txtTipoFuncionario" runat="server" Height="25px" 
          Width="159px">
          <asp:ListItem Value="0">Administrador</asp:ListItem>
          <asp:ListItem Value="1">Atend. Externo</asp:ListItem>
          <asp:ListItem Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Login:"></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server" ValidationGroup="CamposObrigatorios"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Confirmação:"></asp:Label>
        <asp:TextBox ID="txtConfirmaSenha" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ControlToValidate="txtLogin" ErrorMessage="Login - Campo Obrigatório !" 
            ValidationGroup="CamposObrigatorios" Display="None"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnRemover" runat="server" Text="Gravar" 
            onclick="btnGravar_Click" ValidationGroup="CamposObrigatorios" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" 
            onclick="btnCancelar_Click" />
        <asp:Button ID="Button3" runat="server" Text="Remover" 
            ValidationGroup="CamposObrigatorios" Enabled="False" 
            onclick="btnRemover_Click" />
        <br />
        <br />
        <asp:GridView ID="GridViewFuncionario" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AutoGenerateSelectButton="True" 
            onrowediting="GridViewMunicipio_RowEditing" 
            onselectedindexchanged="GridViewMunicipio_SelectedIndexChanged" 
          AllowPaging="True" Width="519px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
              <asp:BoundField DataField="CODIGO" />
            </Columns>
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
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
    
  
 </asp:Content>
