<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo/Site.Master" AutoEventWireup="true"
  CodeBehind="FormPrestarContas.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.FormPrestarContas" %>
<%@ Register src="../Controles/DatePickerControl.ascx" tagname="DatePickerControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>
    Prestar Contas
  </h2>
  <asp:ScriptManager ID="ScriptManager1" runat="server">
  </asp:ScriptManager>
  <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="1">
    <ProgressTemplate>
      <img src="../Images/ajax-loader-1.gif" />
    </ProgressTemplate>
  </asp:UpdateProgress>
  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
      <div>
        <asp:Panel ID="pnlGridPrincipal" runat="server">
        <fieldset>
          <legend>Filtro</legend>
          <asp:Label ID="Label3" runat="server" Text="Funcionário"></asp:Label>
          <asp:DropDownList ID="cbxFunc" runat="server" Height="17px" OnSelectedIndexChanged="cbxFunc_SelectedIndexChanged"
            Width="442px">
          </asp:DropDownList>
          <br />
          <asp:Label ID="Label4" runat="server" Text="Situação:"></asp:Label>
          <asp:DropDownList ID="cbxSituacao" runat="server" OnSelectedIndexChanged="cbxFuncionario_SelectedIndexChanged"
            Width="357px" ViewStateMode="Enabled" OnTextChanged="cbxSituacao_TextChanged">
          </asp:DropDownList>
          <br />
          <asp:Button ID="btnConsultar" runat="server" onclick="btnConsultar_Click" 
            Text="Consultar" />
        </fieldset>
        <p>
          <asp:GridView ID="grdListaAdiantamentos" runat="server" AllowPaging="True" AllowSorting="True"
            AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
            BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="757px" Style="margin-right: 6px"
            EmptyDataText="Teste" SelectedIndex="0" 
            onselectedindexchanged="grdListaAdiantamentos_SelectedIndexChanged" 
            onrowcommand="grdListaAdiantamentos_RowCommand">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
              <asp:BoundField DataField="Codigo_Adiantamento" HeaderText="Cód. Adiant." 
                ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px" >
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="codigo_funcionario" HeaderText="Cód. Func." 
                ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px" >
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="Nome_Funcionario" HeaderText="Nome Func" 
                ItemStyle-Width="200px" >
              <ItemStyle Width="200px" />
              </asp:BoundField>
              <asp:BoundField DataField="data_adiantamento" HeaderText="Data Adiant." 
                ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px" 
                DataFormatString="{0:d}"  >
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="data_prestacao" HeaderText="Data Prestação." 
                ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px" 
                DataFormatString="{0:d}" >
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="valor_adiantamento" HeaderText="Valor Adiant." 
                ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Right" 
                DataFormatString="{0:C}" >
              <ItemStyle HorizontalAlign="Right" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="valor_apresentado" HeaderText="Valor Apresentado" 
                ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Right" 
                DataFormatString="{0:C}" >
              <ItemStyle HorizontalAlign="Right" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="valor_fechamento" HeaderText="Valor Fechamento" 
                ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Right" 
                DataFormatString="{0:C}" >
              <ItemStyle HorizontalAlign="Right" Width="100px" />
              </asp:BoundField>
              <asp:ButtonField ButtonType="Button" CommandName="PRESTARCONTAS" 
                Text="Prestar Contas" />
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
        </p>
        </asp:Panel>
      
        <asp:Panel ID="pnlDespesas" runat="server" Height="263px" Visible="False">
     
          <uc1:DatePickerControl ID="DatePickerControl1" runat="server" />
          <br>
          <br></br>
          <br></br>
          <asp:GridView ID="grdListaDespesas" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" CellPadding="2" ForeColor="#333333" Height="236px" 
            Width="784px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
              <asp:BoundField DataField="DataViagem" DataFormatString="{0:d}" 
                HeaderStyle-Height="20px" HeaderText="Data" ItemStyle-HorizontalAlign="Center" 
                ItemStyle-Width="100px">
              <HeaderStyle Height="20px" />
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="CodigoDespesa" HeaderText="Código" 
                ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:BoundField>
              <asp:BoundField DataField="DescricaoDespesa" HeaderText="Despesa" 
                ItemStyle-Width="300px">
              <ItemStyle Width="300px" />
              </asp:BoundField>
              <asp:BoundField DataField="ValorAdiantado" DataFormatString="{0:C}" 
                FooterText="Total Vlr Adiantado" HeaderText="Valor Adiantado" 
                ItemStyle-HorizontalAlign="Right" ItemStyle-Width="100px">
              <ItemStyle HorizontalAlign="Right" Width="100px" />
              </asp:BoundField>
              <asp:TemplateField HeaderText="Valor Apresentado">
                <ItemTemplate>
                  <asp:TextBox ID="txtvlrApresentado" runat="server" Height="23px" MaxLength="10" 
                    onkeyup="formataValor(this,event);" 
                    ontextchanged="txtvlrApresentado_TextChanged" 
                    Text='<%# DataBinder.Eval (Container.DataItem, "ValorApresentado") %>' 
                    Width="80px"></asp:TextBox>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" 
              Height="20px" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" Height="20px" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
          </asp:GridView>
          <br />
          <br />
          <br />
          <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" />
          <asp:Button ID="btnCancelarDespesas" runat="server" 
            onclick="btnCancelarDespesas_Click" Text="Cancelar" />
          <br></br>
     
          </br>
        </asp:Panel>
        <p>
          &nbsp;</p>
      </div>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
