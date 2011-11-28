using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ControleUsuarios.AppLib.BO.Facade;
using ControleUsuarios.AppLib.Model;

namespace ControleUsuarios.WebApp.Services
{
    /// <summary>
    /// Summary description for SegurancaService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SegurancaService : System.Web.Services.WebService
    {

        private SegurancaFacade segurancaFacade = new SegurancaFacade();

        [WebMethod]
        public void salvarUsuario(Usuario usuario)
        {
            segurancaFacade.salvarUsuario(usuario);
        }

        [WebMethod]
        public void salvarTipoUsuario(TipoUsuario tipoUsuario)
        {
            segurancaFacade.salvarTipoUsuario(tipoUsuario);
        }

        [WebMethod]
        public List<Usuario> obterUsuarios()
        {
            return segurancaFacade.obterUsuarios();
        }

        [WebMethod]
        public List<TipoUsuario> obterTiposUsuarios()
        {
            return segurancaFacade.obterTiposUsuarios();
        }

        [WebMethod]
        public bool autenticarUsuario(string login, string senha)
        {
            if (login == senha)
            {
                return true;

            }
            return false;
        }


    }
}
