using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MinhaApi.Models;

namespace MinhaApi.Controllers
{
    [Route("usuarios-produtos")]
    public class UsersProductsController : BaseController
    {
        public UsersProductsController() { }

        /// <summary>
        /// Adicionar novo produto associado ao usuário
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Obter todos os produto associado ao usuário
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Alterar produto associado de um usuário específico
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> PutAsync(long id)
        {
            return Ok();
        }

        /// <summary>
        /// Deletar produto associado de a usuário
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok();
        }
    }
}