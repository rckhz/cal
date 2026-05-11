using clCalculadora;

namespace mobCalc
{
    public partial class MainPage : ContentPage
    {
        private CalculadoraModel _model = new CalculadoraModel();
        private bool _digitandoSegundo = false;
        private bool _acabouDeCalcular = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string texto = btn.Text;

            // NÚMEROS
            if ("0123456789".Contains(texto))
            {
                // lógica dos números
            }
            // OPERADORES
            else if (texto == "+" || texto == "−" || texto == "×" || texto == "÷")
            {
                // lógica dos operadores
            }
            // IGUAL
            else if (texto == "=")
            {
                // lógica do igual
            }
            // LIMPAR
            else if (texto == "C")
            {
                // lógica do C
            }
            else if (texto == "CE")
            {
                // lógica do CE
            }
            // BACKSPACE
            else if (texto == "⌫")
            {
                // lógica do backspace
            }
            // PONTO
            else if (texto == ".")
            {
                // lógica do ponto
            }
            // ESPECIAIS
            else if (texto == "%" || texto == "x²" || texto == "²√x" || texto == "¹/x" || texto == "+/-")
            {
                // lógica dos especiais
            }
        }
    }
}