using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Investify.Context;
using Investify.Models;

namespace Investify.Controllers
{
    public class IdeiaModelsController : Controller
    {
        private readonly AppDbContext _context;

        public IdeiaModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: IdeiaModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ideia.ToListAsync());
        }

        // GET: IdeiaModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ideiaModel = await _context.Ideia
                .FirstOrDefaultAsync(m => m.Ide_id == id);
            if (ideiaModel == null)
            {
                return NotFound();
            }

            return View(ideiaModel);
        }

        // GET: IdeiaModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IdeiaModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ide_id,Ide_nome,ide_descricao,Ide_empresario,Ide_nivelRisco,Ide_tipo,Ide_cnpj,Ide_fase,Ide_date,Ide_status,Ide_valorInicial,Ide_valorAtual,Ide_participacaoDisponivel")] IdeiaModel ideiaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ideiaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ideiaModel);
        }

        // GET: IdeiaModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ideiaModel = await _context.Ideia.FindAsync(id);
            if (ideiaModel == null)
            {
                return NotFound();
            }
            return View(ideiaModel);
        }

        // POST: IdeiaModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ide_id,Ide_nome,ide_descricao,Ide_empresario,Ide_nivelRisco,Ide_tipo,Ide_cnpj,Ide_fase,Ide_date,Ide_status,Ide_valorInicial,Ide_valorAtual,Ide_participacaoDisponivel")] IdeiaModel ideiaModel)
        {
            if (id != ideiaModel.Ide_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ideiaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdeiaModelExists(ideiaModel.Ide_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ideiaModel);
        }

        // GET: IdeiaModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ideiaModel = await _context.Ideia
                .FirstOrDefaultAsync(m => m.Ide_id == id);
            if (ideiaModel == null)
            {
                return NotFound();
            }

            return View(ideiaModel);
        }

        // POST: IdeiaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ideiaModel = await _context.Ideia.FindAsync(id);
            if (ideiaModel != null)
            {
                _context.Ideia.Remove(ideiaModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdeiaModelExists(int id)
        {
            return _context.Ideia.Any(e => e.Ide_id == id);
        }
    }
}
