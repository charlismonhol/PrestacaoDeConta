﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrestacaoConta.AppLib.Facade;
using PrestacaoContas.AppLib.Facade;
using PrestacaoContas.AppLib;


namespace PrestacaoContas.WebApp.Paginas
{
    public partial class FormAdiantamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { 
               FuncionarioFacade funcinarioFacade = new FuncionarioFacade();
               cbxFuncionario.DataSource          = funcinarioFacade.Obter();
               cbxFuncionario.DataTextField       = "nome";
               cbxFuncionario.DataValueField      = "codigo";
               cbxFuncionario.DataBind();
            
                //para buscar o valor do funcionário int.Parse(cbxFuncionario.SelectedItem.Value irá pegar o valor do DataValueField
            }
            AdiantamentoFacade facade = new AdiantamentoFacade();
            carregarGrid(facade);
      
        }

        private void carregarGrid(AdiantamentoFacade facade)
        {
            GridViewAdiantamento.DataSource = facade.Obter();
            GridViewAdiantamento.DataBind();
        }

        private void limparCampos()
        {
            txtCodigo.Value = null;
            txtCodigoAdiantamento.Text = "";
            txtDescricao.Text = "";
            cbxFuncionario.SelectedItem.Value = null;
            //dpcDataAdiantamento.se = null;
            //dpcDataPrestacao.SelectedDate = null;
            cbxFuncionario.Focus();
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click1(object sender, EventArgs e)
        {
            AdiantamentoFacade facade = new AdiantamentoFacade();
            if (string.IsNullOrEmpty(txtCodigo.Value))
            {
                facade.AdiantamentoInserir(int.Parse(cbxFuncionario.SelectedItem.Value), txtDescricao.Text, dpcDataAdiantamento.SelectedDate, dpcDataPrestacao.SelectedDate);
            }
            else
            {
                facade.AdiantamentoAlterar(int.Parse(txtCodigo.Value), int.Parse(cbxFuncionario.SelectedItem.Value), txtDescricao.Text, dpcDataAdiantamento.SelectedDate, dpcDataPrestacao.SelectedDate);
            }
            carregarGrid(facade);
            limparCampos();
        }

        protected void GridViewDespesa_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void txtCodigo_ValueChanged(object sender,EventArgs e)
        {

        }

        protected void GridViewAdiantamento_SelectedIndexChanged(object sender,EventArgs e)
        {
            //Obtendo o conteúdo do datasource
            PrestacaoContasDataSet.AdiantamentoDataTable adiantamentoDataTable = (PrestacaoContasDataSet.AdiantamentoDataTable)GridViewAdiantamento.DataSource;
            PrestacaoContasDataSet.AdiantamentoRow row = (PrestacaoContasDataSet.AdiantamentoRow)adiantamentoDataTable.Rows[GridViewAdiantamento.SelectedIndex];
            txtCodigoAdiantamento.Text = row.codigo_adiantamento.ToString();
            cbxFuncionario.Items.FindByValue(row.codigo_adiantamento.ToString());
            //txtLogin.Text = row.Login;
            //txtSenha.Text = row.Senha;
            //txtConfirmaSenha.Text = row.Senha;
            //txtTipoFuncionario.SelectedIndex = 1;   
           
          btnRemover.Enabled = true;
        }
    }
}