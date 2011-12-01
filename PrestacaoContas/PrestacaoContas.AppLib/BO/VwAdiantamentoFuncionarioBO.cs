using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.PrestacaoContasDataSetTableAdapters;
using PrestacaoContas.AppLib;

namespace PrestacaoContas.AppLib.BO
{
    /// <summary>
    /// Classe de Regras de Negócio de Adiantamento
    /// </summary>
  public class VwAdiantamentoFuncionarioBO
    {
        /// <summary>
        /// Atributo (privado) de Adaptador de Dados da Tabela de Adiantamento
        /// </summary>
    private vw_adiantamento_funcionarioTableAdapter tableAdapter = new vw_adiantamento_funcionarioTableAdapter();

      
        /// <summary>
        /// Método para obter todos de viagens/Adiantamentos do Funcionário
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.vw_adiantamento_funcionarioDataTable Obter(int codigoFuncionario)
        {
            return tableAdapter.GetDataByVwAdiantamentoFuncionarioFunc(codigoFuncionario);
            
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de Adiantamento
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            AdiantamentoTableAdapter perfilTableAdapter = new AdiantamentoTableAdapter();

            //int? contagem = perfilTableAdapter.GetAdiantamentoCount();
            int? contagem = 0;

            if (contagem.HasValue)
            {
                return contagem.Value;
            }

            return 0;
        }

    }
}
