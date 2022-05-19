using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PortalDocs.Data;
using PortalDocs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalDocs.Controllers
{
    /// <summary>
    /// Informações do Cadastro
    /// </summary>
    [ApiController]
    [Route("v1")]
    public class SolicitacaoController : ControllerBase
    {
        /// <summary>
        /// Criar um Cadastro de Solicitante
        /// </summary>
        /// <param name="context"></param>
        /// <param name="id">Solicitação de informação do Cadastro </param>
        /// <returns>Registro da informação do cadastro</returns>
        [HttpGet]
        [Route("solicitacoes/{id}")]
        public async Task<ActionResult<Solicitacao>> GetByIdAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var solicitacoes = await context
                .Solicitacoes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return solicitacoes == null
                ? NotFound()
                : Ok(solicitacoes);
        }


        /// <summary>
        /// Criar uma solicitação de documentos para o Parceiro de Negócio.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="solicitacao">Informações de documentos Solicitados</param>
        /// <returns>Registro das informações solicitadas</returns>
        [HttpPost("solicitacoes")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] Solicitacao solicitacao)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await context.Solicitacoes.AddAsync(solicitacao);
                await context.SaveChangesAsync();
                return Created($"v1/solicitacoes/{solicitacao.Id}", solicitacao);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        

        
        
        /// <summary>
        /// Excluir dados 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("solicitacoes/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var solicitacao = await context.Solicitacoes.FirstOrDefaultAsync(x => x.Id == id);

            try
            {
                context.Solicitacoes.Remove(solicitacao);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}