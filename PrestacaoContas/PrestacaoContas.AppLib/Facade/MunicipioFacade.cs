using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleUsuarios.AppLib.BO;
using PrestacaoContas.AppLib;

namespace ControleUsuarios.AppLib.Facade
{
    /// <summary>
    /// Classe de Fachada de Segurança
    /// </summary>
    public class MunicipioFacade
    {
        /// <summary>
        /// Atributo (privado) da classe de MunicipioBO
        /// </summary>
        private MunicipioBO municipioBO = new MunicipioBO();

        /// <summary>
        /// Regra para inserir os dados de perfil
        /// </summary>
        /// <param name="municipio">Descrição do Municipio</param>
        /// <param name="uf">Uf do Municipio</param>
        public void MunicipioInserir(string municipio, string uf)
        {
            municipioBO.Inserir(municipio, uf);
        }

        /// <summary>
        /// Método para deletar o perfil pelo código
        /// </summary>
        /// <param name="codigo">Código do Municipio</param>
        public void MunicipioDeletar(int codigo)
        {
            municipioBO.Deletar(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Municipio
        /// </summary>
        /// <param name="codigo">Código do Municipio</param>
        /// <param name="municipio">Descrição do Municipio</param>
        /// <param name="uf">Uf do Municipio</param>
        public void MunicipioAlterar(int codigo, string municipio, string uf)
        {
            municipioBO.Alterar(codigo, municipio, uf);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Municipio
        /// </summary>
        /// <returns>Dados da Tabela de Municipio</returns>
        public PrestacaoContasDataSet.MunicipioDataTable Obter()
        {
            return municipioBO.Obter();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de municipio de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Municipio</returns>
        public PrestacaoContasDataSet.MunicipioDataTable Obter(string descricao)
        {
            return municipioBO.Obter(descricao);
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de municipio
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            return municipioBO.ObterContagem();
        }
    }
}
