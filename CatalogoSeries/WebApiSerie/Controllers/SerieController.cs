using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSerie.Controllers
{
    [Route("[controller]")]
    public class SerieController : Controller
    {
        [HttpGet]
        public IActionResult Lista()
        {
            IList<SerieModel> series = new List<SerieModel>();

            series.Add(new SerieModel() { Titulo = "Titulo Série 1" });
            series.Add(new SerieModel() { Titulo = "Titulo Série 2" });
            series.Add(new SerieModel() { Titulo = "Titulo Série 3" });
            series.Add(new SerieModel() { Titulo = "Titulo Série 4" });

            return Ok(series);
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] SerieModel model)
        {
            return Ok(model);
        }
    }
}
