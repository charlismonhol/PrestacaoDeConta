using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace PrestacaoContas.WebApp.Controles
{
    public partial class DatePickerControl : System.Web.UI.UserControl
    {
        private DateTime selectedDate;
        private string label;

        [Browsable(true), 
        Description("teste"), 
        Category("Propriedades Especiais")]
        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        [Browsable(true),
        Description("teste"),
        Category("Propriedades Especiais")]
        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                calCalendar.Visible = false;
                lblDate.Text = (this.Label != null && this.Label.Length > 0 ? this.Label : "Informe o Label");
                if (this.SelectedDate != null && this.SelectedDate > DateTime.MinValue)
                {
                    calCalendar.SelectedDate = this.SelectedDate;
                    calCalendar_SelectionChanged(null, null);
                }
            }

        }

        protected void btnCalendario_Click(object sender, EventArgs e)
        {
            calCalendar.Visible = !calCalendar.Visible;
        }

        protected void calCalendar_SelectionChanged(object sender, EventArgs e)
        {
            this.SelectedDate = calCalendar.SelectedDate;
            this.calCalendar.VisibleDate = this.SelectedDate;
            txtDate.Text = this.SelectedDate.ToString("dd/MM/yyyy");
             calCalendar.Visible = false;
        }
    }
}