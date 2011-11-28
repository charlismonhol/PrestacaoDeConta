using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestacaoConta.AppLib.BO;
using PrestacaoContas.AppLib;

namespace PrestacaoConta.AppLib.Facade
{
    /// <summary>
    /// Classe de Fachada de Segurança
    /// </summary>
    public class FuncionarioFacade
    {
        /// <summary>
        /// Atributo (privado) da classe de MunicipioBO
        /// </summary>
      private FuncionarioBO funcionarioBO = new FuncionarioBO();

        /// <summary>
        /// Regra para inserir os dados de perfil
        /// </summary>
        /// <param name="nomeFuncionario">Nome do Funcionário</param>
        /// <param name="login">Login do Funcionário</param>
        /// <param name="senha">Login do Funcionário</param>
        /// <param name="tipoFuncionario">Tipo do Funcionário-1-Administrador ; 2-Funcionário Viagem </param>
      public void FuncionarioInserir(string nomeFuncionario, string login,string senha, short tipoFuncionario )
        {
            funcionarioBO.Inserir(nomeFuncionario,login,senha,tipoFuncionario);
        }

        /// <summary>
        /// Método para deletar o perfil pelo código
        /// </summary>
        /// <param name="codigo">Código do Funcionário</param>
        public void FuncionarioDeletar(int codigo)
        {
            funcionarioBO.Deletar(codigo);
        }

        /// <summary>
        /// Método para alterar os dados do Municipio
        /// </summary>
        /// <param name="codigo">Código do Funcionario</param>
        /// <param name="nomeFuncionario">Nome do Funcionário</param>
        /// <param name="login">Login do Funcionário</param>
        /// <param name="senha">Login do Funcionário</param>
        /// <param name="tipoFuncionario">Tipo do Funcionário-1-Administrador ; 2-Funcionário Viagem </param>
                
        public void FuncionarioAlterar(int codigo,string nomeFuncionario, string login,string senha, short tipoFuncionario )
        {
            funcionarioBO.Alterar(codigo,nomeFuncionario,login,senha,tipoFuncionario);
        }


      
        /// <summary>
        /// Método para obter todos os dados da tabela de Funcionários
        /// </summary>
        /// <returns>Dados da Tabela de Funcionários</returns>
        public PrestacaoContasDataSet.FuncionarioDataTable Obter()
        {
            return funcionarioBO.Obter();
        }

        /// <summary>
        /// Método para obter todos os dados da tabela de Funcionário de acordo com o filtro de "nome do Funcionário"
        /// </summary>
        /// <param name="nomeFuncionario">Nome do Funcionário</param>
        /// <returns>Dados da Tabela de Funcionario</returns>
        public PrestacaoContasDataSet.FuncionarioDataTable Obter(string nomeFuncionario)
        {
          return funcionarioBO.Obter(nomeFuncionario);
        }

        /// <summary>
        /// Método para obter a contagem de registro das tabela de Funcionários
        /// </summary>
        /// <returns>Contagem de Itens na Tabela</returns>
        public int ObterContagem()
        {
            return funcionarioBO.ObterContagem();
        }


          /// <summary>
        /// Método para validar o Login e Senha do Funcionário"
        /// </summary>
        /// <param name="login">Login</param>
        /// <param name="senha">Senha</param>
  
        /// <returns>Retorna Código do funcionário se login e senha estiverem OK </returns>
        public int ValidaLogin(string login,string senha)
        {
          return funcionarioBO.ValidaLogin(login,senha);
        }
    
    }
}
