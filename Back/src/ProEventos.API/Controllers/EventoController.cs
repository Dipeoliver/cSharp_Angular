using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using PROEVENTOS.API.Model;

namespace PROEVENTOS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {       
        
        private readonly ILogger<EventoController> _logger;       

        public DataContext Contex { get; }

        public EventoController(DataContext contex)
        {
            Contex = contex;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Contex.Eventos;                
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return Contex.Eventos.FirstOrDefault(evento => evento.EventoId == id);                
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
