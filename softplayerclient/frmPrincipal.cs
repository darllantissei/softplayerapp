using softplayerclient.Services;
using softplayerclient.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softplayerclient
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            lblStatusProcesso.Text = string.Empty;
            pgrStatusProcesso.Visible = false;
        }

        private void txtValorInicial_Leave(object sender, EventArgs e)
        {
            txtValorInicial.Text = Convert.ToDouble(StringsUtil.StringIsNullOrEmptyOrWhiteSpace(txtValorInicial.Text) ? "0" : txtValorInicial.Text).ToString("n2");
        }

        private void txtValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorInicial.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValorInicial_Enter(object sender, EventArgs e)
        {
            string x = string.Empty;
            for (int i = 0; i <= txtValorInicial.Text.Length - 1; i++)
            {
                if ((txtValorInicial.Text[i] >= '0' &&
                    txtValorInicial.Text[i] <= '9') ||
                    txtValorInicial.Text[i] == ',')
                {
                    x += txtValorInicial.Text[i];
                }
            }
            txtValorInicial.Text = x;
            txtValorInicial.SelectAll();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja sair da aplicação?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                e.Cancel = dialogResult == DialogResult.No;
            }
        }

        private void btnSolicitarCalculo_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private async void Consultar()
        {
            // Instanciar
            CalcWebApi calcWebApi = new CalcWebApi();

            // Carregar os eventos sem sobrecarga de evento anterior
            calcWebApi.OnExceptionErro -= CalcWebApi_OnExceptionErro;
            calcWebApi.OnExceptionErro += CalcWebApi_OnExceptionErro;

            decimal.TryParse(txtValorInicial.Text, out decimal valorInical);
            int.TryParse(txtMeses.Text, out int meses);

            StatusProcessoConsulta(mostrar: true, status: "Consultando...");

            // Vamos pedir o cálculo para API
            Returns returns = await Task.Run(() => { return calcWebApi.SolicitarCalculo(valorInical, meses); });

            StatusProcessoConsulta(mostrar: false, status: "Consulta finalizada!");

            if (returns != null)
            {
                // Montar a mensagem para exibir no MessageBox
                // Estou utilizando nameof para utilizar o mesmo nome da propriedade na exibição da descrição
                string ret = string.Concat(nameof(returns.StatusCode), ": ", returns.StatusCode, Environment.NewLine,
                    nameof(returns.Message), ": ", returns.Message, Environment.NewLine,
                    "Valor final: ", string.Format("{0:n2}", returns.Calc?.ValorFinal));

                MessageBox.Show(ret, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        

        private void CalcWebApi_OnExceptionErro(object sender, Task exception)
        {
            //Caso ocorra erro vamos percorrer e mostrar o primeiro e cair fora!
            foreach (var item in exception.Exception.InnerExceptions)
            {
                MessageBox.Show(item?.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void StatusProcessoConsulta(bool mostrar, string status)
        {
            if (lblStatusProcesso.InvokeRequired)
            {
                lblStatusProcesso.Invoke(new Action(() =>
                {
                    lblStatusProcesso.Text = status;
                    lblStatusProcesso.Refresh();
                }));
            }
            else
            {
                lblStatusProcesso.Text = status;
                lblStatusProcesso.Refresh();
            }

            if (pgrStatusProcesso.InvokeRequired)
            {
                pgrStatusProcesso.Invoke(new Action(() =>
                {
                    pgrStatusProcesso.Visible = mostrar;
                    pgrStatusProcesso.Refresh();
                }));
            }
            else
            {
                pgrStatusProcesso.Visible = mostrar;
                pgrStatusProcesso.Refresh();
            }
        }
    }
}
