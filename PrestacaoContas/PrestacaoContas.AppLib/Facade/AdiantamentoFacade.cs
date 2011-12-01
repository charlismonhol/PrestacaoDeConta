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
    public class AdiantamentoFacade
    {
        /// <summary>
        /// Atributo (privado) da classe de AdiantamentoBO
        /// </summary>
        private AdiantamentoBO adiantamentoBO = new AdiantamentoBO();

        /// <summary>
        /// Regra para inserir os dados de perfil
        /// </summary>
        /// <param name="adiantamento">Descrição do Adiantamento</param>
        /// <param name="uf">Uf do Adiantamento</param>
        public void AdiantamentoInserir(int codigo_funcionario, string descricao, DateTime data_adiantamento, DateTime data_prestacao)
        {
            adiantamentoBO.Inserir(codigo_funcionario, descricao, data_adiantamento , data_prestacao);
        }

        /// <summary>
        /// Método para deletar o perfil pelo código
        /// </summary>
        /// <param name="codigo">Código do Adiantamento</param>
        public void AdiantamentoDeletar(int codigo)
        {
            adiantamentoBO.Deletar(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Adiantamento
        /// </summary>
        /// <param name="codigo">Código do Adiantamento</param>
        /// <param name="adiantamento">Descrição do Adiantamento</param>
        /// <param name="uf">Uf do Adiantamento</param>
        public void AdiantamentoAlterar(int codigo, int codigo_funcionario, string descricao, DateTime data_adiantamento, DateTime data_prestacao)
        {
            adiantamentoBO.Alterar(codigo, codigo_funcionario, descricao, data_adiantamento, data_prestacao);            
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Adiantamento
        /// </summary>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.AdiantamentoDataTable Obter()
        {
            return adiantamentoBO.Obter();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de adiantamento de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.AdiantamentoDataTable Obter(string descricao)
        {
            return adiantamentoBO.Obter(descricao);
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de adiantamento
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            return adiantamentoBO.ObterContagem();
        }
    }
}
