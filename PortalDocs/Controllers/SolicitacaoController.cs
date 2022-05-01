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
        

        [HttpPost("parceiro")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] Parceiro model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var parceiro = new Parceiro
            {
                Id = model.Id,
                DocumentosEmpresa = model.DocumentosEmpresa,
                NomeFuncionario = model.NomeFuncionario,
                CpfFuncionario = model.CpfFuncionario,
                RgFuncionario = model.RgFuncionario,
                DocumentosFuncionario = model.DocumentosFuncionario,
            };
            try
            {
                await context.Parceiros.AddAsync(parceiro);
                await context.SaveChangesAsync();
                return Created($"v1/parceiro/{parceiro.Id}", parceiro);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut("parceiro/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] Parceiro model,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var parceiro = await context.Parceiros.FirstOrDefaultAsync(x => x.Id == id);

            if (parceiro == null)
                return NotFound();

            try
            {
                parceiro.DocumentosEmpresa = model.DocumentosEmpresa;
                parceiro.NomeFuncionario = model.NomeFuncionario;
                parceiro.CpfFuncionario = model.CpfFuncionario;
                parceiro.RgFuncionario = model.RgFuncionario;
                parceiro.DocumentosFuncionario = model.DocumentosFuncionario;

                context.Parceiros.Update(parceiro);
                await context.SaveChangesAsync();
                return Ok(parceiro);
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