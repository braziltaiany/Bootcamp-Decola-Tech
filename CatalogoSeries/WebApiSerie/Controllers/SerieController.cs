using System.Linq;
using CatalogoSeries.Classes;
using CatalogoSeries.Classes.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSerie.Controllers
{
    [Route("[controller]")]
    public class SerieController : Controller
{
    private readonly IRepositorio<Serie> _repositorioSerie;

    public SerieController(IRepositorio<Serie> repositorioSerie)
    {
        _repositorioSerie = repositorioSerie;
    }

    [HttpGet("")]
    public IActionResult Lista()
    {
        return Ok(_repositorioSerie.Lista().Select(s => new SerieModel(s)));
    }

    [HttpPut("{id}")]
    /* [HttpGet]
         public IActionResult Lista()
         {
             IList<SerieModel> series = new List<SerieModel>();

             series.Add(new SerieModel() { Titulo = "Titulo Série 1" });
             series.Add(new SerieModel() { Titulo = "Titulo Série 2" });
             series.Add(new SerieModel() { Titulo = "Titulo Série 3" });
             series.Add(new SerieModel() { Titulo = "Titulo Série 4" });

             return Ok(series);
         }*/
    public IActionResult Atualiza(int id, [FromBody] SerieModel model)
    {
        _repositorioSerie.Atualiza(id, model.ToSerie()); //AutoMapper
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Exclui(int id)
    {
        _repositorioSerie.Exclui(id);
        return NoContent();
    }

    [HttpPost("")]
    public IActionResult Insere([FromBody] SerieModel model)
    {
        model.Id = _repositorioSerie.ProximoId();

        Serie serie = model.ToSerie();

        _repositorioSerie.Insere(serie);
        return Created("", serie);
    }

    [HttpGet("{id}")]
    public IActionResult Consulta(int id)
    {
        return Ok(new SerieModel(_repositorioSerie.Lista().FirstOrDefault(s => s.Id == id)));
    }
}
}