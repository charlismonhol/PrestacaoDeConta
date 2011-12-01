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
    public class AdiantamentoDespesaFacade
    {
        /// <summary>
        /// Atributo (privado) da classe de AdiantamentoBO
        /// </summary>
        private AdiantamentoDespesaBO adiantamentoDespesaBO = new AdiantamentoDespesaBO();

        
        /// <summary>
        /// Regra para inserir os dados do Adiantamento Despesa
        /// </summary>
        /// <param name="codigoAdiantamento">Código do Adiantamento</param>
        /// <param name="codigoDespesa">Código de Despesa</param>
        /// <param name="dataViagem">Data Viagem</param>
        /// <param name="valorAdiantado">Valor Adiantado</param>
        /// <param name="valorApresentado">Valor Apresentado</param>
    
        public void AdiantamentoDespesaInserir(int codigoAdiantamento,int codigoDespesa,DateTime dataViagem,decimal valorAdiantado,decimal valorApresentado)
        {
            adiantamentoDespesaBO.Inserir(codigoAdiantamento,codigoDespesa,dataViagem,valorAdiantado,valorApresentado);
        }

        /// <summary>
        /// Método para deletar o perfil pelo código
        /// </summary>
        /// <param name="codigo">Código do Adiantamento</param>
        public void AdiantamentoDespesaDeletar(int codigo)
        {
            adiantamentoDespesaBO.Deletar(codigo);
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
        public void AdiantamentoDespesaAlterar(int codigoAdiantamentoDespesa,int codigoAdiantamento,int codigoDespesa,DateTime dataViagem,decimal valorAdiantado,decimal valorApresentado)
        {
            adiantamentoDespesaBO.Alterar(codigoAdiantamentoDespesa,codigoAdiantamento,codigoDespesa,dataViagem,valorAdiantado,valorApresentado);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Adiantamento Depesas
        /// </summary>
        /// <returns>Dados da Tabela de Adiantamento</returns>
        public PrestacaoContasDataSet.Adiantamento_DespesaDataTable Obter()
        {
            return adiantamentoDespesaBO.Obter();
        }

        /// <summary>
        /// Método para obter todos as despesas da viagem de acordo com o Código de Adiantamento
        /// </summary>
        /// <param name="codigoAdiantamento">Código Adiantamento</param>
        /// <returns>Dados da Tabela de Adiantamento Despesas filtrado pela Adiantamento/Viagem</returns>
        public PrestacaoContasDataSet.Adiantamento_DespesaDataTable ObterDepesasViagem(int codigoAdiantamento)
        {
            return adiantamentoDespesaBO.ObterDespesaViagem(codigoAdiantamento);
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de adiantamento
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            return adiantamentoDespesaBO.ObterContagem();
        }
    }
}
