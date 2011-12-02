<%@ Page Title="Autenticação" Language="C#" MasterPageFile="~/Modelo/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="PrestacaoContas.WebApp.Paginas.Login" %>
<%@ Reference VirtualPath="~/Modelo/Site.master"  %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
  <style type="text/css">
  .style1
  {
    width: 254px;
  }
  .style2
  {
    width: 254px;
    height: 29px;
  }
  .style3
  {
    height: 29px;
  }
</style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;<table style="width: 100%;">
          <tr>
            <td class="style1">
              &nbsp;</td>
            <td>
    <asp:Login ID="LoginUser" runat="server" 
  BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" 
  BorderWidth="1px" 
  FailureText="Login ou Senha Inválido. Por favor tente novamente" 
  Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" 
  LoginButtonText="Acessar" onauthenticate="LoginUser_Authenticate" 
  PasswordLabelText="Senha:" 
  PasswordRequiredErrorMessage="Preenchimento do campo senha é obrigatório " 
  TitleText="Autenticação" UserNameLabelText="Usuário:" 
  UserNameRequiredErrorMessage="Preenchimento do campo usuário é obrigatório" 
  Height="165px" Width="395px" CssClass="bold" 
      DestinationPageUrl="~/Paginas/Default.aspx" 
      RememberMeText="Lembrar na Próxima vez." DisplayRememberMe="False">
      <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
      <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
        BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
      <TextBoxStyle Font-Size="0.8em" />
      <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
        ForeColor="White" />
    </asp:Login>
            </td>
            <td>
              &nbsp;</td>
          </tr>
          <tr>
            <td class="style2">
              </td>
            <td class="style3">
              </td>
            <td class="style3">
              </td>
          </tr>
          <tr>
            <td class="style1">
              &nbsp;</td>
            <td>
              &nbsp;</td>
            <td>
              &nbsp;</td>
          </tr>
        </table>
    </h2>
    </asp:Content>
