using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace exemploAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
         public IActionResult ObterDataHora(){
            var obj = new {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
         }

         [HttpGet("ObterNomeCompleto/{nome}/{sobrenome}/{idade}")]

         public IActionResult ObterNomeCompleto(string nome, string sobrenome, int idade){
            var mensagem = $"Olá {nome} {sobrenome}, seja bem vindo!sua idade é {idade} anos";
            return Ok(new {mensagem});
         }
    }
}