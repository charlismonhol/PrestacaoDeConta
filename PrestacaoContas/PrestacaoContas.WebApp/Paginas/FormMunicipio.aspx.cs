using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrestacaoContas.AppLib.Facade;
using PrestacaoContas.AppLib;
using System.Data;

namespace PrestacaoContas.WebApp.Paginas
{
    public partial class FormMunicipio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
                MunicipioFacade facade = new MunicipioFacade();
                carregarGrid(facade);
            //}
        }

        private void carregarGrid(MunicipioFacade facade)
        {            
            GridViewMunicipio.DataSource = facade.Obter();
            GridViewMunicipio.DataBind();
        }

        private void limparCampos()
        {
            txtCodigo.Value = "";
            txtMunicipio.Text = "";
            txtUf.Text = "";
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            MunicipioFacade facade = new MunicipioFacade();
            if (string.IsNullOrEmpty(txtCodigo.Value))
            {
                facade.MunicipioInserir(txtMunicipio.Text, txtUf.Text);
            }
            else
            {
                facade.MunicipioAlterar(int.Parse(txtCodigo.Value), txtMunicipio.Text, txtUf.Text);
            }
            carregarGrid(facade);
            limparCampos();
        }

        protected void GridViewMunicipio_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewMunicipio.EditIndex = e.NewEditIndex;
        }

        protected void GridViewMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtendo o conteúdo do datasource
            PrestacaoContasDataSet.MunicipioDataTable municipioDataTable = (PrestacaoContasDataSet.MunicipioDataTable)GridViewMunicipio.DataSource;
            PrestacaoContasDataSet.MunicipioRow row = (PrestacaoContasDataSet.MunicipioRow)municipioDataTable.Rows[GridViewMunicipio.SelectedIndex];
            txtMunicipio.Text = row.municipio;
            txtUf.Text = row.uf;
            txtCodigo.Value = row.codigo.ToString();
            btnRemover.Enabled = true;
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Value))
            {
                MunicipioFacade facade = new MunicipioFacade();
                facade.MunicipioDeletar(int.Parse(txtCodigo.Value));
                carregarGrid(facade);
                limparCampos();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void GridViewMunicipio_PageIndexChanged(object sender,EventArgs e)
        {
         // e.ToString();
        }
    }
}