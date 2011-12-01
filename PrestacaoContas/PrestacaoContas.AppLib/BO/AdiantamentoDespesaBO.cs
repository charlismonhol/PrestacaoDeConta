using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.PrestacaoContasDataSetTableAdapters;
using PrestacaoContas.AppLib;

namespace PrestacaoContas.AppLib.BO
{
    /// <summary>
    /// Classe de Regras de Negócio de Adiantamento Despesas
    /// </summary>
    public class AdiantamentoDespesaBO
    {
        /// <summary>
        /// Atributo (privado) de Adaptador de Dados da Tabela de Adiantamento_Despesa
        /// </summary>
        private Adiantamento_DespesaTableAdapter tableAdapter = new Adiantamento_DespesaTableAdapter();

        /// <summary>
        /// Regra para inserir os dados do Adiantamento Despesa
        /// </summary>
        /// <param name="codigoAdiantamento">Código do Adiantamento</param>
        /// <param name="codigoDespesa">Código de Despesa</param>
        /// <param name="dataViagem">Data Viagem</param>
        /// <param name="valorAdiantado">Valor Adiantado</param>
        /// <param name="valorApresentado">Valor Apresentado</param>


        public void Inserir(int codigoAdiantamento, int codigoDespesa, DateTime dataViagem, decimal valorAdiantado, decimal valorApresentado)
        {
            tableAdapter.AddNewAdiantamentoDespesa(codigoAdiantamento, codigoDespesa, dataViagem, valorAdiantado, valorApresentado);
        }

        /// <summary>
        /// Método para deletar o Adiantamento Despesa pelo código
        /// </summary>
        /// <param name="codigo">Código do Adiantamento Despesa</param>
        public void Deletar(int codigo)
        {
            tableAdapter.DeleteAdiantamentoDespesa(codigo);
            //charlis monhol jhgjhgjhghgj

        }

        /// <summary>
        /// Método para alterar os dados do Adiantamento Despesa
        /// </summary>
        /// <param name="codigoAdiantamentoDespesa">Código do Adiantamento da Despesa</param>
        /// <param name="codigoAdiantamento">Código do Adiantamento</param>
        /// <param name="codigoDespesa">Código de Despesa</param>
        /// <param name="dataViagem">Data Viagem</param>
        /// <param name="valorAdiantado">Valor Adiantado</param>
        /// <param name="valorApresentado">Valor Apresentado</param>
        public void Alterar(int codigoAdiantamentoDespesa, int codigoAdiantamento, int codigoDespesa, DateTime dataViagem, decimal valorAdiantado, decimal valorApresentado)
        {
            tableAdapter.UpdateAdiantamentoDespesa(codigoAdiantamentoDespesa, codigoAdiantamento, codigoDespesa, dataViagem, valorAdiantado, valorApresentado);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Adiantamento Despesa
        /// </summary>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.Adiantamento_DespesaDataTable Obter()
        {
            return tableAdapter.GetData();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Adiantamento de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.Adiantamento_DespesaDataTable ObterDespesaViagem(int codigoAdiantamento)
        {
            return tableAdapter.GetDataByAdiantamentoDespesaCodigo(codigoAdiantamento);

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
