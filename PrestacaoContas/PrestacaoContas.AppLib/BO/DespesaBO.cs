using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.PrestacaoContasDataSetTableAdapters;
using PrestacaoContas.AppLib;

namespace ControleUsuarios.AppLib.BO
{
    /// <summary>
    /// Classe de Regras de Negócio de Despesa
    /// </summary>
    public class DespesaBO
    {
        /// <summary>
        /// Atributo (privado) de Adaptador de Dados da Tabela de Despesa
        /// </summary>
        private DespesaTableAdapter tableAdapter = new DespesaTableAdapter();

        /// <summary>
        /// Regra para inserir os dados do despesa
        /// </summary>
        /// <param name="despesa">Descrição do Despesa</param>
        /// <param name="uf">Uf do Despesa</param>
        public void Inserir(string despesa)
        {
            tableAdapter.AddNewDespesa(despesa);
        }

        /// <summary>
        /// Método para deletar o despesa pelo código
        /// </summary>
        /// <param name="codigo">Código do Despesa</param>
        public void Deletar(int codigo)
        {
            tableAdapter.DeleteDespesa(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Despesa
        /// </summary>
        /// <param name="codigo">Código do Despesa</param>
        /// <param name="despesa">Descrição do Despesa</param>
        /// <param name="uf">Uf do Despesa</param>
        public void Alterar(int codigo, string despesa)
        {
            tableAdapter.UpdateDespesa(codigo, despesa);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Despesa
        /// </summary>
        /// <returns>Dados da Tabela de Despesa</returns>
        public PrestacaoContasDataSet.DespesaDataTable Obter()
        {
            return tableAdapter.GetData();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de despesa de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Despesa</returns>
        public PrestacaoContasDataSet.DespesaDataTable Obter(string descricao)
        {
            string filtro = String.Format("{0}%", descricao);

            //return tableAdapter.GetDataByDescricaoAproximada(filtro);
            return null;
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de despesa
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            DespesaTableAdapter perfilTableAdapter = new DespesaTableAdapter();

            //int? contagem = perfilTableAdapter.GetDespesaCount();
            int? contagem = 0;

            if (contagem.HasValue)
            {
                return contagem.Value;
            }

            return 0;
        }

    }
}
