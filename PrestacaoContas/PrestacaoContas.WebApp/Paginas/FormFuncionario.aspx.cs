using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrestacaoConta.AppLib.Facade;
using PrestacaoContas.AppLib;
using System.Data;

namespace PrestacaoContas.WebApp.Paginas
{
    public partial class FormFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
                FuncionarioFacade facade = new FuncionarioFacade();
                carregarGrid(facade);
            //}
        }

        private void carregarGrid(FuncionarioFacade facade)
        {

          GridViewFuncionario.DataSource = facade.Obter();
          GridViewFuncionario.DataBind();
        }

        private void limparCampos()
        {
            txtCodigo.Value = "";
            txtNomeFuncionario.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text ="";
            
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            FuncionarioFacade facade = new FuncionarioFacade();
            if (string.IsNullOrEmpty(txtCodigo.Value))
            {
                facade.FuncionarioInserir(txtNomeFuncionario.Text, txtLogin.Text ,txtLogin.Text, 0);
            }
            else
            {
              facade.FuncionarioAlterar(int.Parse(txtCodigo.Value),txtNomeFuncionario.Text,txtLogin.Text,txtLogin.Text,0);
            }
            carregarGrid(facade);
            limparCampos();
        }

        protected void GridViewMunicipio_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewFuncionario.EditIndex = e.NewEditIndex;
        }

        protected void GridViewMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtendo o conteúdo do datasource
            PrestacaoContasDataSet.FuncionarioDataTable funcionarioDataTable = (PrestacaoContasDataSet.FuncionarioDataTable)GridViewFuncionario.DataSource;
            PrestacaoContasDataSet.FuncionarioRow row = (PrestacaoContasDataSet.FuncionarioRow)funcionarioDataTable.Rows[GridViewFuncionario.SelectedIndex];
            txtNomeFuncionario.Text = row.Nome;
            txtLogin.Text = row.Login;
            txtSenha.Text = row.Senha;
            txtConfirmaSenha.Text = row.Senha;
            txtTipoFuncionario.SelectedIndex = 1;   
           
          btnRemover.Enabled = true;
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Value))
            {
              FuncionarioFacade facade = new FuncionarioFacade();
                facade.FuncionarioDeletar(int.Parse(txtCodigo.Value));
                carregarGrid(facade);
                limparCampos();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}