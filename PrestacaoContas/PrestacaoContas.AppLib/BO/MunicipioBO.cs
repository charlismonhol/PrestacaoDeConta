using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.PrestacaoContasDataSetTableAdapters;
using PrestacaoContas.AppLib;

namespace PrestacaoContas.AppLib.BO
{
    /// <summary>
    /// Classe de Regras de Negócio de Municipio
    /// </summary>
    public class MunicipioBO
    {
        /// <summary>
        /// Atributo (privado) de Adaptador de Dados da Tabela de Municipio
        /// </summary>
        private MunicipioTableAdapter tableAdapter = new MunicipioTableAdapter();

        /// <summary>
        /// Regra para inserir os dados do municipio
        /// </summary>
        /// <param name="municipio">Descrição do Municipio</param>
        /// <param name="uf">Uf do Municipio</param>
        public void Inserir(string municipio, string uf)
        {
            tableAdapter.AddNewMunicipio(municipio, uf);
        }

        /// <summary>
        /// Método para deletar o municipio pelo código
        /// </summary>
        /// <param name="codigo">Código do Municipio</param>
        public void Deletar(int codigo)
        {
            tableAdapter.DeleteMunicipio(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Municipio
        /// </summary>
        /// <param name="codigo">Código do Municipio</param>
        /// <param name="municipio">Descrição do Municipio</param>
        /// <param name="uf">Uf do Municipio</param>
        public void Alterar(int codigo, string municipio, string uf)
        {
            tableAdapter.UpdateMunicipio(codigo, municipio, uf);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Municipio
        /// </summary>
        /// <returns>Dados da Tabela de Municipio</returns>
        public PrestacaoContasDataSet.MunicipioDataTable Obter()
        {
            return tableAdapter.GetData();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de municipio de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Municipio</returns>
        public PrestacaoContasDataSet.MunicipioDataTable Obter(string descricao)
        {
            string filtro = String.Format("{0}%", descricao);

            //return tableAdapter.GetDataByDescricaoAproximada(filtro);
            return null;
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de municipio
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            MunicipioTableAdapter perfilTableAdapter = new MunicipioTableAdapter();

            //int? contagem = perfilTableAdapter.GetMunicipioCount();
            int? contagem = 0;

            if (contagem.HasValue)
            {
                return contagem.Value;
            }

            return 0;
        }

    }
}
