using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace TP2DOTNET.Pages
{
    public class IndexModel : PageModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public void OnGet()
        {
            // Inicializar a lista de pessoas com dados fictícios
            Pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 25, CPF = "123.456.789-00" },
                new Pessoa { Nome = "Maria", Idade = 30, CPF = "987.654.321-00" },
                // Adicione mais pessoas conforme necessário
            };
        }
    }
}
