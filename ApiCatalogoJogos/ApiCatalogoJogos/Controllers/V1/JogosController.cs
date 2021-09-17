using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.inputModel;
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

        //Contratos injeção de dependencia
        //Tem que depender de contratos, recebo um contrato que é uma interface de um serviço que foi implantado. No caso a classe IJogoService
        public async Task<ActionResult<JogoViewModel>> Obter(Guid idJogo)
        {
            return Ok();
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
