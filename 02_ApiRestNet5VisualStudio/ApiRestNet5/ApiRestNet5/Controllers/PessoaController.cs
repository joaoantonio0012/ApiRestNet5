using ApiRestNet5.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ApiRestNet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
         
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("index/")]
        public IActionResult Index( )
        {

            PessoaModel pessoa   = new PessoaModel
            {
                Nome = "João Antonio ",
                SobreNome = "Amaro Pereira",
                Endereco = "Rua Pedro Carlos de souza 278 Jardim Europa Rancharia Sp",
                Genero = "Masculino",
                Id = 1
            };
            var retorno = JsonSerializer.Serialize(pessoa);
            return Ok(retorno);
            
        } 
        
        [HttpPost("cadastrar/")]
        public IActionResult Cadastrar(PessoaModel pessoa )
        {
            return Ok();
            
        } 
        
       
    }
}
