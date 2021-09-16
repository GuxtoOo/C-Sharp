using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MinhaApi.Models;
using MinhaApi.Repository;
using MinhaApi.Domain.Services;

namespace MinhaApi.Controllers
{
    [Route("usuarios")]
    public class UsersController : BaseController
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        /// <summary>
        /// Adicionar novo usuário
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UsuarioDto usuario)
        {
            if (string.IsNullOrEmpty(usuario.Name))
                return BadRequest();

            if (string.IsNullOrEmpty(usuario.Document))
                return BadRequest();

            if (!long.TryParse(usuario.Document, out long _))
                return BadRequest();

            await _usersService.AddAsync(usuario);

            return Ok();
        }

        /// <summary>
        /// Obter todos os usuários
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var query = await _usersService.GetAsync();

            return Ok(query);         
        }

        /// <summary>
        /// Detalhar usuário específico
        /// </summary>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync(long id)
        {
            var query = await _usersService.GetByIdAsync(id);

            return Ok(query);
        }

        /// <summary>
        /// Alterar usuário específico
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> PutAsync(long id, [FromBody] UsuarioDto usuario)
        {
            if (string.IsNullOrEmpty(usuario.Name))
                return BadRequest();

            if (string.IsNullOrEmpty(usuario.Document))
                return BadRequest();

            if (!long.TryParse(usuario.Document, out long _))
                return BadRequest();

            await _usersService.UpdateAsync(id, usuario);

            return Ok();
        }

        /// <summary>
        /// Deletar usuário específico
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            await _usersService.DeleteAsync(id);

            return Ok();
        }
    }
}