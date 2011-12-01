using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PrestacaoConta.AppLib;
using PrestacaoConta.AppLib.BO;
using PrestacaoConta.AppLib.Facade;

namespace PrestacaoContas.WebApp.Services
{
  /// <summary>
  /// Summary  description for PrestacaoContasServicos
  /// </summary>
  /// 

 

  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  // [System.Web.Script.Services.ScriptService]
  public class PrestacaoContasServicos:System.Web.Services.WebService
  {
    private  FuncionarioFacade facadeFacade = new FuncionarioFacade();

    [WebMethod]
    public bool autenticarUsuario(string login,string senha)
    {
      int intCodigoFuncionario = facadeFacade.ValidaLogin(login,senha);


      if (intCodigoFuncionario != -1)
      {
        return true;

      }
      return false;
    }


 //   [WebMethod]
 //   public List<TipoUsuario> obterPrestacaodeContasFuncionario(string situacaoPrestacao)
 //   {
 //     return segurancaFacade.obterTiposUsuarios();
 //   }

  }
}
