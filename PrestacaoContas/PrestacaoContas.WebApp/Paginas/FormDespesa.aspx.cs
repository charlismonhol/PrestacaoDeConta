using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrestacaoContas.AppLib.Facade;
using PrestacaoContas.AppLib;

namespace PrestacaoContas.WebApp.Paginas
{
    public partial class FormDespesa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DespesaFacade facade = new DespesaFacade();
           carregarGrid(facade);
        }

        private void carregarGrid(DespesaFacade facade)
        {
            GridViewDespesa.DataSource = facade.Obter();
            GridViewDespesa.DataBind();
        }

        private void limparCampos()
        {
          txtDescricao.Text = "";
          txtDescricao.Focus(); 
        }


        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            DespesaFacade facade = new DespesaFacade();
            if (string.IsNullOrEmpty(txtCodigo.Value))
            {
                facade.DespesaInserir(txtDescricao.Text);
            }
            else
            {
                facade.DespesaAlterar(int.Parse(txtCodigo.Value), txtDescricao.Text);
            }
            carregarGrid(facade);
            limparCampos();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Value))
            {
                DespesaFacade facade = new DespesaFacade();
                facade.DespesaDeletar(int.Parse(txtCodigo.Value));
                carregarGrid(facade);
                limparCampos();
            }
        }

        protected void GridViewMunicipio_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridViewDespesa_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewDespesa.EditIndex = e.NewEditIndex;
        }

        protected void GridViewDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtendo o conteúdo do datasource
            PrestacaoContasDataSet.DespesaDataTable despesaDataTable = (PrestacaoContasDataSet.DespesaDataTable)GridViewDespesa.DataSource;
            PrestacaoContasDataSet.DespesaRow row                    = (PrestacaoContasDataSet.DespesaRow)despesaDataTable.Rows[GridViewDespesa.SelectedIndex];
            txtDescricao.Text = row.Descricao;
            txtCodigo.Value   = row.Codigo.ToString();
            btnRemover.Enabled = true;
        }

        protected void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}