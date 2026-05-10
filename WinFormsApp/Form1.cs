using clCalculadora;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private CalculadoraModel _model = new CalculadoraModel();
        private bool _digitandoSegundo = false;
        private bool _acabouDeCalcular = false;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }
        //btn numeros somente (0 - 9)
        private void btn1_Click(object sender, EventArgs e)
        {
            if (_acabouDeCalcular)
            {
                txtDisplay.Text = "";
                _acabouDeCalcular = false;
            }
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

            //verifica se o segundo numero ja foi digitado
            if (_digitandoSegundo && txtDisplay.Text != "")
            {
                //ja calcula o resultado da operacao anterior
                _model.Numero2 = double.Parse(txtDisplay.Text);
                _model.Calcular();
                txtDisplay.Text = _model.Resultado.ToString();
            }

            //caso o display esteja vazio impede o usuario de colocar sinais de operadores
            if (txtDisplay.Text == "")
            {
                return;
            }

            //guarda o primeiro numero e o operador
            _model.Numero1 = double.Parse(txtDisplay.Text);
            //define o operador, limpa o his torico e o display para digitar o proximo numero
            _model.Operador = "+";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " +";
            txtDisplay.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            //verifica se o segundo numero ja foi digitado
            if (_digitandoSegundo && txtDisplay.Text != "")
            {
                //ja calcula o resultado da operacao anterior
                _model.Numero2 = double.Parse(txtDisplay.Text);
                _model.Calcular();
                txtDisplay.Text = _model.Resultado.ToString();
            }

            //caso o display esteja vazio impede o usuario de colocar sinais de operadores
            if (txtDisplay.Text == "")
            {
                return;
            }
            //guarda o primeiro numero e o operador
            _model.Numero1 = double.Parse(txtDisplay.Text);
            //define o operador, limpa o his torico e o display para digitar o proximo numero
            _model.Operador = "-";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " -";
            txtDisplay.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            //verifica se o segundo numero ja foi digitado
            if (_digitandoSegundo && txtDisplay.Text != "")
            {
                //ja calcula o resultado da operacao anterior
                _model.Numero2 = double.Parse(txtDisplay.Text);
                _model.Calcular();
                txtDisplay.Text = _model.Resultado.ToString();
            }

            //caso o display esteja vazio impede o usuario de colocar sinais de operadores
            if (txtDisplay.Text == "")
            {
                return;
            }
            //guarda o primeiro numero e o operador
            _model.Numero1 = double.Parse(txtDisplay.Text);
            //define o operador, limpa o his torico e o display para digitar o proximo numero
            _model.Operador = "*";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " *";
            txtDisplay.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            //verifica se o segundo numero ja foi digitado  
            if (_digitandoSegundo && txtDisplay.Text != "")
            {
                //ja calcula o resultado da operacao anterior
                _model.Numero2 = double.Parse(txtDisplay.Text);
                _model.Calcular();
                txtDisplay.Text = _model.Resultado.ToString();
            }

            //caso o display esteja vazio impede o usuario de colocar sinais de operadores
            if (txtDisplay.Text == "")
            {
                return;
            }
            //guarda o primeiro numero e o operador
            _model.Numero1 = double.Parse(txtDisplay.Text);
            //define o operador, limpa o his torico e o display para digitar o proximo numero
            _model.Operador = "/";
            _digitandoSegundo = true;
            lblHistorico.Text = _model.Numero1 + " /";
            txtDisplay.Text = "";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {

            //pega o segundo numero e guard daa no model
            _model.Numero2 = double.Parse(txtDisplay.Text);

            //exibe o historico da operacao
            lblHistorico.Text = _model.Numero1 + " " + _model.Operador + " " + _model.Numero2 + " =";

            //chama o model para fazer o calculo
            _model.Calcular();

            //mostra o resultado no disply
            txtDisplay.Text = _model.Resultado.ToString();

            //reseta o model ou seja o proximo numero vai ser o numero1 novamente
            _digitandoSegundo = false;

            //cria um model novo para os novos calculos
            _model = new CalculadoraModel();

            //marca que acabou de calcular e limpa o display todo
            _acabouDeCalcular = true;

            //limpa o historico
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 45, 45);

            txtDisplay.BackColor = Color.FromArgb(45, 45, 45);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.Size = new Size(this.ClientSize.Width - 20, 35);
            txtDisplay.Location = new Point(0, 25);

            lblHistorico.BackColor = Color.FromArgb(45, 45, 45);
            lblHistorico.ForeColor = Color.FromArgb(150, 150, 150);
            lblHistorico.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblHistorico.TextAlign = ContentAlignment.MiddleRight;
            lblHistorico.Size = new Size(this.ClientSize.Width - 20, 20);
            lblHistorico.Location = new Point(10, 5);

            Label separador = new Label();
            separador.BackColor = Color.FromArgb(70, 70, 70);
            separador.Size = new Size(this.ClientSize.Width, 1);
            separador.Location = new Point(0, 58);
            this.Controls.Add(separador);

            Color corNumeros = Color.FromArgb(55, 55, 55);
            Color corEspeciais = Color.FromArgb(60, 60, 60);
            Color corOperadores = ColorTranslator.FromHtml("#D07A20");
            Color corIgual = ColorTranslator.FromHtml("#4A90D9");

            btn0.BackColor = btn1.BackColor = btn2.BackColor = btn3.BackColor =
            btn4.BackColor = btn5.BackColor = btn6.BackColor = btn7.BackColor =
            btn8.BackColor = btn9.BackColor = btnPonto.BackColor = btnInversao.BackColor = corNumeros;

            btnPorcentagem.BackColor = btnCE.BackColor = btnC.BackColor =
            btnDelete.BackColor = btnFracao.BackColor = btnQuadrado.BackColor =
            btnRaiz.BackColor = corEspeciais;

            btnSoma.BackColor = btnSubtracao.BackColor =
            btnMultiplicacao.BackColor = btnDivisao.BackColor = corOperadores;

            btnIgual.BackColor = corIgual;

            foreach (Control c in this.Controls)
            {
                if (c is BotaoArredondado b)
                {
                    b.ForeColor = Color.White;
                    b.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                    b.Cursor = Cursors.Hand;
                }
            }
        }
    }
}
