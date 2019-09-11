using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufos.WebApi.Domains;
using Senai.Gufos.WebApi.Interfaces;
using Senai.Gufos.WebApi.Repositories;

namespace Senai.Gufos.WebApi.Controllers {
    [Route ("api/[controller]")]
    [Produces ("application/json")]
    [ApiController]
    public class EventosController : ControllerBase {
        private IEventoRepository EventoRepository { get; set; }

        public EventosController()
        {
            EventoRepository = new EventoRepository();    
        }

        // repositorio
        // endpoints
        [HttpGet]
        public IActionResult Listar () {
            try {
                return Ok (EventoRepository.ListarTodos());
            } catch (Exception ex) {
                return BadRequest (
                    new {
                        mensagem = "Erro: " + ex.Message
                    }
                );
            }
        }

        /// <summary>
        /// Cadastrar um evento
        /// </summary>
        /// <param name="evento">Evento</param>
        /// <returns>Mensagem de sucesso.</returns>
        [HttpPost]
        public IActionResult Cadastrar (Eventos evento) {
            try {
                EventoRepository.Cadastrar (evento);
                return Ok ();
            } catch (Exception ex) {
                return BadRequest (new { mensagem = "Erro ao cadastrar." + ex.Message });
            }
        }
    }
}