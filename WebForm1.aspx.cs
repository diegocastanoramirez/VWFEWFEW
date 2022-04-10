using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace puntocinco
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnum1_Click(object sender, EventArgs e)
        {
            double salario, salincremento;
            salario = Convert.ToDouble(txtnum1.Text);
            salincremento = salario * 25 / 100+salario;
            lblresultado.Text = System.Convert.ToString(salincremento);
        }
    }
}