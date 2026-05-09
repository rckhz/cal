using Microsoft.AspNetCore.Mvc;
using clCalculadora;

namespace calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        // nome da pagina que vai ser chamada
        public IActionResult Index()
        {
            //fala pro asp.net para mostrar a tela html pro usuario
            return View(new CalculadoraModel());
        }


        [HttpPost]
        public IActionResult Calcular(double numero1, double numero2, string operador)
        {
            var model = new CalculadoraModel
            {
                Numero1 = numero1,
                Numero2 = numero2,
                Operador = operador.Trim()  // remove espaços
            };
            model.Calcular();
            return Json(model.Resultado);
        }   

        [HttpPost]
        //recebe os dados que o usuario digito na tela - numero1, numero2 e operador
        public IActionResult Especial(CalculadoraModel model)
        {
            //chama o metodo model que vc escreveu - aqui comeca a conta
            model.CalcularEspecial();
            //devolve pro usuario o resultado daa conta
            return View("Index", model);
        }
    }
}