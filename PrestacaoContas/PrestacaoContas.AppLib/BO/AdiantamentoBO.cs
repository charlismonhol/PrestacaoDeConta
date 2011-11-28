using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.PrestacaoContasDataSetTableAdapters;
using PrestacaoContas.AppLib;

namespace ControleUsuarios.AppLib.BO
{
    /// <summary>
    /// Classe de Regras de Negócio de Adiantamento
    /// </summary>
    public class AdiantamentoBO
    {
        /// <summary>
        /// Atributo (privado) de Adaptador de Dados da Tabela de Adiantamento
        /// </summary>
        private AdiantamentoTableAdapter tableAdapter = new AdiantamentoTableAdapter();

        /// <summary>
        /// Regra para inserir os dados do Adiantamento
        /// </summary>
        /// <param name="Adiantamento">Descrição do Adiantamento</param>
        /// <param name="uf">Uf do Adiantamento</param>
        public void Inserir(int codigo_funcionario, string descricao, DateTime data_adiantamento, DateTime data_prestacao)
        {
            tableAdapter.AddNewAdiantamento(codigo_funcionario, descricao, data_adiantamento , data_prestacao);
        }

        /// <summary>
        /// Método para deletar o Adiantamento pelo código
        /// </summary>
        /// <param name="codigo">Código do Adiantamento</param>
        public void Deletar(int codigo)
        {
            tableAdapter.DeleteAdiantamento(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Adiantamento
        /// </summary>
        /// <param name="codigo">Código do Adiantamento</param>
        /// <param name="Adiantamento">Descrição do Adiantamento</param>
        /// <param name="uf">Uf do Adiantamento</param>
        public void Alterar(int codigo, int codigo_funcionario, string descricao, DateTime data_adiantamento , DateTime data_prestacao)
        {
            tableAdapter.UpdateAdiantamento(codigo, codigo_funcionario, descricao, data_adiantamento, data_prestacao);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Adiantamento
        /// </summary>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.AdiantamentoDataTable Obter()
        {
            return tableAdapter.GetData();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Adiantamento de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.AdiantamentoDataTable Obter(string descricao)
        {
            string filtro = String.Format("{0}%", descricao);

            //return tableAdapter.GetDataByDescricaoAproximada(filtro);
            return null;
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
