using clCalculadora;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private CalculadoraModel _model = new CalculadoraModel();
        private bool _digitandoSegundo = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        //btn numeros somente (0 - 9)
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        //btn operadores
        private void btnSoma_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.Operador = "+";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " +";
            txtDisplay.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.Operador = "-";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " -";
            txtDisplay.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.Operador = "*";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " x";
            txtDisplay.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.Operador = "/";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " ÷";
            txtDisplay.Text = "";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            _model.Numero2 = double.Parse(txtDisplay.Text);
            lblHistorico.Text = _model.Numero1 + " " + _model.Operador + " " + _model.Numero2 + " =";
            _model.Calcular();
            txtDisplay.Text = _model.Resultado.ToString();
            _digitandoSegundo = false;
            _model = new CalculadoraModel();
            lblHistorico.Text = "";

        }

        private void btnInversao_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "" && txtDisplay.Text != "0")
            {
                double numero = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (numero * -1).ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            if (lblHistorico.Text.Length > 0)
            {
                lblHistorico.Text = lblHistorico.Text.Substring(0, lblHistorico.Text.Length - 1);
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
                lblHistorico.Text = "";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            _model = new CalculadoraModel();
            _digitandoSegundo = false;
            txtDisplay.Text = "";
            lblHistorico.Text = "";
        }
        //especiais
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.TipoCalculo = "porcentagem";
            _model.CalcularEspecial();
            txtDisplay.Text = _model.Resultado.ToString();
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.TipoCalculo = "inverso";
            _model.CalcularEspecial();
            txtDisplay.Text = _model.Resultado.ToString();
        }
        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.TipoCalculo = "quadrado";
            _model.CalcularEspecial();
            txtDisplay.Text = _model.Resultado.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            _model.Numero1 = double.Parse(txtDisplay.Text);
            _model.TipoCalculo = "raiz";
            _model.CalcularEspecial();
            txtDisplay.Text = _model.Resultado.ToString();
        }

        private void lblHistorico_Click(object sender, EventArgs e)
        {
            _model.Numero2 = double.Parse(txtDisplay.Text);
            lblHistorico.Text = _model.Numero1 + " " + _model.Operador + " " + _model.Numero2 + " =";
            _model.Calcular();
            txtDisplay.Text = _model.Resultado.ToString();
        }
    }
}
