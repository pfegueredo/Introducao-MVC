using System.ComponentModel.DataAnnotations;

namespace IntroducaoMVC.Models
{
    public class Voluntario
    {
        
        public int voluntario_id { get; set; }
        public string nome_voluntario { get; set; }
        public string sexo { get; set; }

        public string email { get; set; }

    }
}
