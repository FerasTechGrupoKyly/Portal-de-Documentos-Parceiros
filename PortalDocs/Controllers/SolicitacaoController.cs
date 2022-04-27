using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PortalDocs.Data;
using PortalDocs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route("solicitacoes/{id}")]
        public async Task<IActionResult> GetByIdAsync(
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

        [HttpPost("solicitacoes")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] Solicitacao model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var solicitacao = new Solicitacao
            {
                ObservacaoSolicitacao = model.ObservacaoSolicitacao,
                Solicitante = model.Solicitante,
                Data = model.Data,
                ParceiroNome = model.ParceiroNome,
                ParceiroCnpj = model.ParceiroCnpj,
                ParceiroEmail = model.ParceiroEmail,
                DocumentoRequerido = model.DocumentoRequerido,
                TipoDocumento = model.TipoDocumento,
               
            };

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
        

        [HttpPut("solicitacoes/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] Solicitacao model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var solicitacao = await context.Solicitacoes.FirstOrDefaultAsync(x => x.Id == id);

            if (solicitacao == null)
                return NotFound();

            try
            {
                solicitacao.ObservacaoSolicitacao = model.ObservacaoSolicitacao;

                context.Solicitacoes.Update(solicitacao);
                await context.SaveChangesAsync();
                return Ok(solicitacao);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

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