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
    [ApiController]
    [Route("v1")]
    public class ParceiroController : ControllerBase
    {
        [HttpPost("parceiros")]
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
        [HttpPut("parceiros/{id}")]
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
        [HttpGet]
        [Route("parceiros/{id}")]
        public async Task<IActionResult> GetByIdAsync(
           [FromServices] AppDbContext context,
           [FromRoute] int id)
        {
            var parceiros = await context
                .Parceiros
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return parceiros == null
                ? NotFound()
                : Ok(parceiros);
        }
    }
}
