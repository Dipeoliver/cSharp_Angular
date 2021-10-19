using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Model;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {       
        
        private readonly ILogger<EventoController> _logger;

        public IEnumerable<Evento> evento  = new Evento[]{
            new Evento() {
                EventoId = 1,
                Local = "Tremembé",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Tema = "Spring",
                QtdPessoas = 10,
                Lote = "1° lote",
                ImagemURL = ""
                },
            new Evento(){
                EventoId = 2,
                Local = "Tremembé 2",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Tema = "Spring 2",
                QtdPessoas = 10,
                Lote = "2° lote",
                ImagemURL = ""
                },
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return evento;                
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return evento.Where(evento => evento.EventoId == id);                
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id )
        {
            return $"exemplo de put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id )
        {
            return $"exemplo de Delete {id}";
        }
    }
}
