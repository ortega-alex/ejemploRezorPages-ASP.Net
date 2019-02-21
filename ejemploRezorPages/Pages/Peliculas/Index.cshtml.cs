using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ejemploRezorPages.Models;

namespace ejemploRezorPages.Pages.Peliculas
{
    public class IndexModel : PageModel
    {
        private readonly ejemploRezorPages.Models.ApplicationDbContext _context;

        public IndexModel(ejemploRezorPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; }

        public async Task OnGetAsync()
        {
            Pelicula = await _context.Peliculas.ToListAsync();
        }
    }
}
