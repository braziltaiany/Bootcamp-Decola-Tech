using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogoJogos.Controllers.V1
{
    //deixar claro a versão do projeto para quem vai consumir a api - V1
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        [HttpGet]
        // task utilizado para garantir uma melhor performance requisições web
        //async ele vai esperar um ActionResult de uma listagem de objetos
        //actionResult é um tipo de retorno, dos status HTTp
        //método
        public async Task<ActionResult<List<Object>>> Obter()
        {
            return Ok();
        }

        [HttpGet("{idJogo:guid}")]

        public async Task<ActionResult<List<Object>>> Obter(Guid idJogo)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<List<Object>>> InserirJogo(object jogo)
        {
            return Ok();
        }

        //put eu atualizo o conteudo inteiro
        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult<List<Object>>> AtualizarJogo(Guid Idjogo, object jogo)
        {
            return Ok();
        }

        //no patch eu atualizo uma coisa especifica, exemplo: só o preço do jogo
        [HttpPatch("{idJogo:guid/preco/{preco:double}")]
        public async Task<ActionResult<List<Object>>> AtualizarJogo(Guid Idjogo, double preco)
        {
            return Ok();
        }

        [HttpDelete("{idJogo:guid}")]

        public async Task<ActionResult<List<Object>>> ApagarJogo(Guid Idjogo)
        {
            return Ok();
        }
    }
}
