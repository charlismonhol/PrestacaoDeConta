using System;                 using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Description;
using PrestacaoConta.AppLib.Facade;

namespace PrestacaoContas.WebApp.Paginas
{
  public partial class Login:System.Web.UI.Page
  {
    protected void Page_Load(object sender,EventArgs e)
    {
      
     //string teste =  this.Page.Site.Name.ToString();
    }

    protected void LoginUser_Authenticate(object sender,AuthenticateEventArgs e)
    {
      Session["logado"] = "NAO";
      FuncionarioFacade facade = new FuncionarioFacade();
      e.Authenticated = (facade.ValidaLogin(LoginUser.UserName,LoginUser.Password) != -1);
      if (e.Authenticated)
      {
        Session["logado"] = "SIM";
      }

    }
  }
}
