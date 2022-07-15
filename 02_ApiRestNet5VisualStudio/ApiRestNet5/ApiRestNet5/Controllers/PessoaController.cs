using ApiRestNet5.Model;
using ApiRestNet5.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ApiRestNet5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}/")]
    public class PessoaController : ControllerBase
    {
        private IPessoaNegocio _IpessoaNegocio;
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger, IPessoaNegocio ipersonNegocio)
        {
            _logger = logger;
            _IpessoaNegocio = ipersonNegocio;
        }

        [HttpGet("index/")]
        public IActionResult Index()
        {

            return Ok(_IpessoaNegocio.PesquisarPorId(1));
        }

        [HttpGet("pesquisarporid/{Id}")]
        public IActionResult PesquisarPorId(long Id)
        {

            return Ok(_IpessoaNegocio.PesquisarPorId(Id));
        }
        [HttpGet("pesquisartodos/")]
        public IActionResult PesquisarTodos()
        {

            return Ok(JsonSerializer.Serialize(_IpessoaNegocio.PesquisarTodos()));
        }

        [HttpPost("cadastrar/")]
        public IActionResult Cadastrar([FromBody] PessoaModel pessoa)
        {
            var retorno = _IpessoaNegocio.Cadastrar(pessoa);
            if (retorno == null)
                return BadRequest("Dados invalidos");

            return Ok(retorno);

        }
        [HttpPut("Alterar/")]
        public IActionResult Alterar([FromBody] PessoaModel pessoa)
        {
            var retorno = _IpessoaNegocio.Alterar(pessoa);
            if (retorno == null)
                return BadRequest("Dados invalidos");

            return Ok(retorno);

        }
        [HttpDelete("Deletar/{Id}")]
        public IActionResult Deletar(long Id)
        {
            _IpessoaNegocio.Deletar(Id);


            return Ok("Item deletado com sucesso!");

        }


    }
}
