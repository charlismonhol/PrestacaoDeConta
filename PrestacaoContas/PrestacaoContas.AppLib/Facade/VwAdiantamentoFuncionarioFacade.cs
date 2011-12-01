using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.BO;
using PrestacaoContas.AppLib;

namespace PrestacaoContas.AppLib.Facade
{
    /// <summary>
    /// Classe de Fachada de Segurança
    /// </summary>
  public class VwAdiantamentoFuncionarioFacade
    {
        /// <summary>
      /// Atributo (privado) da classe de VwAdiantamentoFuncionarioBO
        /// </summary>
    private VwAdiantamentoFuncionarioBO adiantamentoFuncionarioBO = new VwAdiantamentoFuncionarioBO();

     
        /// <summary>
        /// Método para obter todos os dados da View de VwAdiantamentoFuncionario
        /// </summary>
        /// <returns>Dados da View de Adiantamento</returns>
    public PrestacaoContasDataSet.vw_adiantamento_funcionarioDataTable Obter(int codigoFuncionario)
        {
          return adiantamentoFuncionarioBO.Obter(codigoFuncionario);
        }

        
        /// <summary>
        /// Método para obter a contagem de registro das tabela de adiantamento
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
          return adiantamentoFuncionarioBO.ObterContagem();
        }
    }
}
