using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Data;
using JuliePro.Models;

namespace JuliePro.Controllers
{
    public class ObjectivesController : Controller
    {
        private readonly JulieProDbContext _baseDonnees;

        public ObjectivesController(JulieProDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        // GET: Objectives
        public async Task<IActionResult> Index()
        {
            return _baseDonnees.Objectives != null ?
                        View(await _baseDonnees.Objectives.ToListAsync()) :
                        Problem("Entity set 'JulieProDbContext.Objectives'  is null.");
        }

    
}
}
