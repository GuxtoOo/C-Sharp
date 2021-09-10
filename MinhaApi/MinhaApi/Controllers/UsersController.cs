using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MinhaApi.Models;

namespace MinhaApi.Controllers
{
    [Route("usuarios")]
    public class UsersController : BaseController
    {
        public UsersController() { }

        /// <summary>
        /// Adicionar novo usuário
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UsuarioDto usuario)
        {
            return Ok();
        }

        /// <summary>
        /// Obter todos os usuários
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Detalhar usuário específico
        /// </summary>
        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetAsync(long id)
        {
            return Ok();
        }

        /// <summary>
        /// Alterar usuário específico
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> PutAsync(long id)
        {
            return Ok();
        }

        /// <summary>
        /// Deletar usuário específico
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok();
        }
    }
}