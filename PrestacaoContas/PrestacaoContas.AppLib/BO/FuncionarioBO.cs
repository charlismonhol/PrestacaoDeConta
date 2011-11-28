using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoContas.AppLib.PrestacaoContasDataSetTableAdapters;
using PrestacaoContas.AppLib;

namespace PrestacaoConta.AppLib.BO
{
    /// <summary>
    /// Classe de Regras de Negócio de Funcionario
    /// </summary>
    public class FuncionarioBO
    {
        /// <summary>
        /// Atributo (privado) de Adaptador de Dados da Tabela de Funcionario
        /// </summary>
        private FuncionarioTableAdapter tableAdapter = new FuncionarioTableAdapter();

        /// <summary>
        /// Regra para inserir os dados do Funcionario
        /// </summary>
        /// <param name="nomeFuncionario">Nome do Funcionário</param>
        /// <param name="login">Login do Funcionário</param>
        /// <param name="senha">Login do Funcionário</param>
        /// <param name="tipoFuncionario">Tipo do Funcionário-1-Administrador ; 2-Funcionário Viagem </param>
      
        public void Inserir(string nomeFuncionario, string login,string senha, short tipoFuncionario )
        {
          tableAdapter.AddNewFuncionario(nomeFuncionario,login,senha,tipoFuncionario);
        }

        /// <summary>
        /// Método para deletar o Funcionario pelo código
        /// </summary>
        /// <param name="codigo">Código do Funcionario</param>
        public void Deletar(int codigo)
        {
            tableAdapter.DeleteFuncionario(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Funcionario
        /// </summary>
        /// <param name="codigo">Código do Funcionario</param>
        /// <param name="nomeFuncionario">Nome do Funcionário</param>
        /// <param name="login">Login do Funcionário</param>
        /// <param name="senha">Login do Funcionário</param>
        /// <param name="tipoFuncionario">Tipo do Funcionário-1-Administrador ; 2-Funcionário Viagem </param>
        public void Alterar(int codigo,string nomeFuncionario, string login,string senha, short tipoFuncionario )
        {
            tableAdapter.UpdateFuncionario(codigo,nomeFuncionario,login,senha,tipoFuncionario);
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Funcionario
        /// </summary>
        /// <returns>Dados da Tabela de Funcionario</returns>
        public PrestacaoContasDataSet.FuncionarioDataTable Obter()
        {
            return tableAdapter.GetData();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Funcionario de acordo com o filtro de "nome"
        /// </summary>
        /// <param name="descricao">Descrição</param>
        /// <returns>Dados da Tabela de Funcionario</returns>
        public PrestacaoContasDataSet.FuncionarioDataTable Obter(string nomeFuncionario)
        {
          string filtro = String.Format("{0}%",nomeFuncionario);

            //return tableAdapter.GetDataByDescricaoAproximada(filtro);
            return null;
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de Funcionario
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            FuncionarioTableAdapter perfilTableAdapter = new FuncionarioTableAdapter();

            //int? contagem = perfilTableAdapter.GetFuncionarioCount();
            int? contagem = 0;

            if (contagem.HasValue)
            {
                return contagem.Value;
            }

            return 0;
        }

        /// <summary>
        /// Método para validar o Login e Senha do Funcionário"
        /// </summary>
        /// <param name="login">Login</param>
        /// <param name="senha">Senha</param>
  
      /// <returns>Retorna Código do funcionário se login e senha estiverem OK </returns>
        public int ValidaLogin(string login, string senha)
        {
          PrestacaoContasDataSet.FuncionarioDataTable funcionarioLogin = tableAdapter.GetDataByLogin(login);
          // Se retornar nulo Login Inválido
          if (funcionarioLogin != null && funcionarioLogin.Rows.Count > 0)
          {
            if (senha == (string)funcionarioLogin.Rows[0]["senha"])
            {
              return (int)funcionarioLogin.Rows[0]["codigo"];
            } 
          }
          return -1;
        }

    }
}
