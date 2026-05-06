namespace calculadora.Models
{
    public class CalculadoraModel
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public string Operador { get; set; }
        public double Resultado { get; set; }

        public void Calcular()
        {
            Resultado = Operador switch
            {
                "+" => Numero1 + Numero2,
                "-" => Numero1 - Numero2,
                "*" => Numero1 * Numero2,
                "/" => Numero2 != 0 ? Numero1 / Numero2 : 0,
                _ => 0
            };
        }
    }
}