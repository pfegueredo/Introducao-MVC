using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace IntroducaoMVC.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }


        [StringLength(50, MinimumLength =5, ErrorMessage = "Insira uma observação de 5 a 50 caracteres")]
        public string Observacao { get; set; }
        
        
        [Range(18,70, ErrorMessage = "Idade é maior de 18 a 70 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo Login é obrigatório")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras são aceitos")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Login já existe")]
        public string Login { get; set; }
        
        
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Senha { get; set; }
        
        [Required(ErrorMessage = "O campo Confirmar Senha é obrigatório")]
        [Compare("Senha", ErrorMessage ="As senhas não coincidem")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenha { get; set; }
        
        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
                
    }
}
