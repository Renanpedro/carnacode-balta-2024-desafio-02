using System.ComponentModel.DataAnnotations;

namespace IMC.Models
{
    public class CalculoImc
    {
        [Required(ErrorMessage = "Informe a Altura")]
        public double? Altura { get; set; }

        [Required(ErrorMessage = "Informe o Peso")]
        [Range(1, 500, ErrorMessage = "O Peso informado deve estar entre 1 e 500 Kg")]
        public double? Peso { get; set; }

        [Required(ErrorMessage = "Informe o Sexo")]
        public string Sexo { get; set; } = string.Empty;

        public double? ResultadoIMC { get; set; }

        public List<double> ResultadosHistorico { get; set; } = new List<double>();
    }
}
