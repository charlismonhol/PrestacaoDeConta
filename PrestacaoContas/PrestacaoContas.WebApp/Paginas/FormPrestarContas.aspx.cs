using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrestacaoConta.AppLib.Facade;
using PrestacaoContas.AppLib.Facade;


namespace PrestacaoContas.WebApp.Paginas
{
  public partial class FormPrestarContas:System.Web.UI.Page
  {
    protected void Page_Load(object sender,EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        FuncionarioFacade funcinarioFacade = new FuncionarioFacade();


        cbxFunc.DataSource          = funcinarioFacade.Obter();
        cbxFunc.DataTextField       = "nome";
        cbxFunc.DataValueField      = "codigo";
        cbxFunc.DataBind();
        ListItem itemTodos = new ListItem();
        itemTodos.Text = "<Todos>";
        itemTodos.Value = "-1";
        cbxFunc.Items.Insert(0,itemTodos);
        ListItem itemAberto = new ListItem();
        itemAberto.Text = "Prestação em Aberto";
        itemAberto.Value = "0";
        ListItem itemFinalizada = new ListItem();
        itemFinalizada.Text = "Prestação Finalizadas";
        itemFinalizada.Value = "1";
        cbxSituacao.Items.Add(itemTodos);
        cbxSituacao.Items.Add(itemAberto);
        cbxSituacao.Items.Add(itemFinalizada);



        //para buscar o valor do funcionário int.Parse(cbxFuncionario.SelectedItem.Value irá pegar o valor do DataValueField
      }
    }

   


    /// <summary>
    /// Método auxiliar para obter os dados do grid
    /// </summary>
    protected void ObterDadosGrid(int codigoFuncionario)
    {
      grdListaAdiantamentos.EditIndex = -1;
      grdListaAdiantamentos.SelectedIndex = -1;

      VwAdiantamentoFuncionarioFacade vwAdiantamentoFuncFacade = new VwAdiantamentoFuncionarioFacade();
      PrestacaoContas.AppLib.PrestacaoContasDataSet.vw_adiantamento_funcionarioDataTable  vwAdiantamentoFuncDataSet =vwAdiantamentoFuncFacade.Obter(codigoFuncionario);

      Session["DadosvwAdiantamentoFuncDataSet"]= vwAdiantamentoFuncDataSet;

      grdListaAdiantamentos.DataSource = Session["DadosvwAdiantamentoFuncDataSet"];
      grdListaAdiantamentos.DataBind();
      pnlGridPrincipal.Visible = true;
      pnlDespesas.Visible = false;
    }

    protected void ObterDadosGridDespesa(int codigoAdiantamento)
    {
      grdListaDespesas.EditIndex = -1;
      grdListaDespesas.SelectedIndex = -1;

      AdiantamentoDespesaFacade adiantamentoDespesaFacade = new AdiantamentoDespesaFacade();
      PrestacaoContas.AppLib.PrestacaoContasDataSet.Adiantamento_DespesaDataTable  adiantamentoDespesaDataSet =adiantamentoDespesaFacade.ObterDepesasViagem(codigoAdiantamento);

      Session["DadosadiantamentoDespesaDataSet"]= adiantamentoDespesaDataSet;

      grdListaDespesas.DataSource = Session["DadosadiantamentoDespesaDataSet"];
      grdListaDespesas.DataBind();
    }



    protected void cbxFuncionario_TextChanged(object sender,EventArgs e)
    {
     // this.ObterDadosGrid(-1);      

    }

    protected void cbxFuncionario_SelectedIndexChanged(object sender,EventArgs e)
    {
    
    }

    protected void cbxFunc_SelectedIndexChanged(object sender,EventArgs e)
    {
    
    }

    protected void cbxSituacao_TextChanged(object sender,EventArgs e)
    {
    
    }

    protected void btnConsultar_Click(object sender,EventArgs e)
    {
      this.ObterDadosGrid(Convert.ToInt32(this.cbxFunc.SelectedItem.Value.ToString()));

    }

    protected void grdListaAdiantamentos_SelectedIndexChanged(object sender,EventArgs e)
    {

    }

    protected void grdListaAdiantamentos_RowCommand(object sender,GridViewCommandEventArgs e)
    {
      if (e.CommandName == "PRESTARCONTAS")
      {
        
        pnlGridPrincipal.Visible = false;
        pnlDespesas.Visible = true;

        int index = int.Parse((string)e.CommandArgument);
        int int_Valor = Convert.ToInt32(grdListaAdiantamentos.Rows[index].Cells[0].Text);


     //   GridViewRow celula_Valor = grdListaAdiantamentos.SelectedRow;
      
       // Int32 int_Valor = Convert.ToInt32(celula_Valor.Cells[0].Text);

       // Int32 int_Valor = Convert.ToInt32(e.CommandArgument.ToString()); 
       // grdListaAdiantamentos.SelectedRow.Cells[2]
        ObterDadosGridDespesa(int_Valor);
        
      }
    }

    protected void btnCancelarDespesas_Click(object sender,EventArgs e)
    {
      pnlGridPrincipal.Visible = true;
      pnlDespesas.Visible = false;
 
    }

    protected void txtvlrApresentado_TextChanged(object sender,EventArgs e)
    {
       
    }

  }
}