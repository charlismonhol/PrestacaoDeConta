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
    public class DespesaFacade
    {
        /// <summary>
        /// Atributo (privado) da classe de DespesaBO
        /// </summary>
        private DespesaBO despesaBO = new DespesaBO();

        /// <summary>
        /// Regra para inserir os dados de perfil
        /// </summary>
        /// <param name="despesa">Descrição do Despesa</param>
        /// <param name="uf">Uf do Despesa</param>
        public void DespesaInserir(string despesa)
        {
            despesaBO.Inserir(despesa);
        }

        /// <summary>
        /// Método para deletar o perfil pelo código
        /// </summary>
        /// <param name="codigo">Código do Despesa</param>
        public void DespesaDeletar(int codigo)
        {
            despesaBO.Deletar(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Despesa
        /// </summary>
        /// <param name="codigo">Código do Despesa</param>
        /// <param name="despesa">Descrição do Despesa</param>
        /// <param name="uf">Uf do Despesa</param>
        public void DespesaAlterar(int codigo, string despesa)
        {
            despesaBO.Alterar(codigo, despesa);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Despesa
        /// </summary>
        /// <returns>Dados da Tabela de Despesa</returns>
        public PrestacaoContasDataSet.DespesaDataTable Obter()
        {
            return despesaBO.Obter();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de despesa de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Despesa</returns>
        public PrestacaoContasDataSet.DespesaDataTable Obter(string descricao)
        {
            return despesaBO.Obter(descricao);
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de despesa
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            return despesaBO.ObterContagem();
        }
    }
}
