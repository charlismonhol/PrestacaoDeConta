using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrestacaoContas.WebApp.Modelo
{
  public partial class Site:System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender,EventArgs e)
    {

      if (this.Page.Title ==  "Autenticação")
      {
        Session["logado"] = "NAO";
        HeadLoginView.Visible = false;
        NavigationMenu.Visible = false;
      }
      else
      {
        if (Session["logado"] != "SIM")
        {
          Response.Redirect("~/Paginas/Login.aspx");
        }
      }
    }
    protected void NavigationMenu_MenuItemClick(object sender,MenuEventArgs e)
    {
      
    }

  }
}
