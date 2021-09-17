using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.inputModel;
using ApiCatalogoJogos.Services;
using ApiCatalogoJogos.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogoJogos.Controllers.V1
{
    //deixar claro a versão do projeto para quem vai consumir a api - V1
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        //interface
        private readonly IJogoService _jogoService;

        //ganhamos uma instancia
        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }


        [HttpGet]
        // task utilizado para garantir uma melhor performance requisições web
        //async ele vai esperar um ActionResult de uma listagem de objetos
        //actionResult é um tipo de retorno, dos status HTTp
        //método
        public async Task<ActionResult<IEnumerable<JogoViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var jogos = await _jogoService.Obter(pagina, quantidade);

            if (jogos.Count() == 0)
                return NoContent();

            return Ok(jogos);
        }

        [HttpGet("{idJogo:guid}")]

        //Contratos injeção de dependencia
        //Tem que depender de contratos, recebo um contrato que é uma interface de um serviço que foi implantado. No caso a classe IJogoService
        public async Task<ActionResult<JogoViewModel>> Obter([FromRoute] Guid idJogo)
        {
            var jogo = await _jogoService.Obter(idJogo);

            if (jogo == null)
                return NoContent();

            return Ok(jogo);
        }

        [HttpPost]
        public async Task<ActionResult<JogoViewModel>> InserirJogo(JogoInputModel jogo)
        {
            return Ok();
        }

        //put eu atualizo o conteudo inteiro
        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult<JogoViewModel>> AtualizarJogo(Guid Idjogo, JogoInputModel jogo)
        {
            return Ok();
        }

        //no patch eu atualizo uma coisa especifica, exemplo: só o preço do jogo
        [HttpPatch("{idJogo:guid/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid Idjogo, double preco)
        {
            return Ok();
        }

        [HttpDelete("{idJogo:guid}")]

        public async Task<ActionResult> ApagarJogo(Guid Idjogo)
        {
            return Ok();
        }
    }
}
