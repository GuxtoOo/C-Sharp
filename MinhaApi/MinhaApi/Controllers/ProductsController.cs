using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MinhaApi.Models;

namespace MinhaApi.Controllers
{
    [Route("produtos")]
    public class ProductsController : BaseController
    {
        public ProductsController() { }

        /// <summary>
        /// Adicionar novo produto
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] ProductDto product)
        {
            
            return Ok();
        }

        /// <summary>
        /// Obter todos os produto
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok();
        }

        /// <summary>
        /// Detalhar produto específico
        /// </summary>
        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetAsync(long id)
        {
            return Ok();
        }

        /// <summary>
        /// Alterar produto específico
        /// </summary>
        [HttpPut]
        [Route("{Id}")]
        public async Task<IActionResult> PutAsync(long id)
        {
            return Ok();
        }

        /// <summary>
        /// Deletar produto específico
        /// </summary>
        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok();
        }
    }
}