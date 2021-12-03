using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace WebServiceConsumer
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            int No1 = Convert.ToInt32(txtFirstNumber.Text);
            int No2 = Convert.ToInt32(txtSecondNumber.Text);

            ServiceReference2.CalculatorServiceSoapClient client = new ServiceReference2.CalculatorServiceSoapClient();
            lblTotal.Text = client.Addition(No1, No2).ToString();
        }

        protected void BtnSubtract_Click(object sender, EventArgs e)
        {
            int No1 = Convert.ToInt32(txtFirstNumber.Text);
            int No2 = Convert.ToInt32(txtSecondNumber.Text);

            ServiceReference2.CalculatorServiceSoapClient client = new ServiceReference2.CalculatorServiceSoapClient();
            lblTotal.Text = client.Subtraction(No1, No2).ToString();
        }

        protected void Btnmultiply_Click(object sender, EventArgs e)
        {
            int No1 = Convert.ToInt32(txtFirstNumber.Text);
            int No2 = Convert.ToInt32(txtSecondNumber.Text);

            ServiceReference2.CalculatorServiceSoapClient client = new ServiceReference2.CalculatorServiceSoapClient();
            lblTotal.Text = client.Multiplication(No1, No2).ToString();
        }

        protected void Btndivide_Click(object sender, EventArgs e)
        {
            int No1 = Convert.ToInt32(txtFirstNumber.Text);
            int No2 = Convert.ToInt32(txtSecondNumber.Text);

            ServiceReference2.CalculatorServiceSoapClient client = new ServiceReference2.CalculatorServiceSoapClient();
            lblTotal.Text = client.Division(No1, No2).ToString();
        }
    }
}