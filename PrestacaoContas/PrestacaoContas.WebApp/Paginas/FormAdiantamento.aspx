<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true"
  CodeBehind="FormAdiantamento.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormAdiantamento" %>

<%@ Register Src="../Controles/DatePickerControl.ascx" TagName="DatePickerControl"
  TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script src="~/Scripts/js/jquery-1.6.2.min.js" type="text/javascript" ></script> 
<link href="~/Scripts/themes/base/jquery.ui.datepicker.css" rel="stylesheet" type="text/css"></link>
  <script>
    (function () {
      ("#tabs").tabs();
    });
  </script>

  <h2>
    Cadastro de Adiantamenstos de Viagens/Diárias
  </h2>
  <asp:HiddenField ID="txtCodigo" runat="server" 
    onvaluechanged="txtCodigo_ValueChanged" />
  <br />
  <asp:Label ID="Label3" runat="server" Text="Funcionário"></asp:Label>
  <asp:DropDownList ID="cbxFuncionario" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
    Width="357px">
  </asp:DropDownList>
  <br />
  <br />
  <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
  <asp:TextBox ID="txtDescricao" runat="server" Height="24px" Width="359px"></asp:TextBox>
  <br />
  <br />
  <br />
  <br />
  <table>
    <tr>
      <td>
        <uc1:DatePickerControl ID="dpcDataPrestacao" runat="server" />
      </td>
      <td>
        <uc1:DatePickerControl ID="dpcDataAdiantamento" runat="server" />
      </td>
    </tr>
  </table>
  <br />
  <asp:GridView ID="GridViewAdiantamento" runat="server" CellPadding="4" ForeColor="#333333"
    GridLines="None" AutoGenerateSelectButton="True">
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
  <div id="tabs">
    <ul>
      <li><a href="#tabs-1">Nunc tincidunt</a></li>
      <li><a href="#tabs-2">Proin dolor</a></li>
      <li><a href="#tabs-3">Aenean lacinia</a></li>
    </ul>
    <div id="tabs-1">
      <p>
        
    </div>
    <div id="tabs-2">
      <p>
       </p>
    </div>
    <div id="tabs-3">
      <p>
       </p>
      <p>
      </p>
    </div>
  </div>
  <br />
  <br />
  <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click1"
    ValidationGroup="CamposObrigatorios" />
  <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
  <asp:Button ID="btnRemover" runat="server" Text="Remover" ValidationGroup="CamposObrigatorios"
    Enabled="False" />
  <br />
  <br />
  <br />
  <br />
  <br />
  <br />
  <br />
  <br />
  <br />
  <br />
</asp:Content>
