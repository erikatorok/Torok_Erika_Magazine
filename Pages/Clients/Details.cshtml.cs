using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Torok_Erika_Magazine.Data;
using Torok_Erika_Magazine.Models;

namespace Torok_Erika_Magazine.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly Torok_Erika_Magazine.Data.Torok_Erika_MagazineContext _context;

        public DetailsModel(Torok_Erika_Magazine.Data.Torok_Erika_MagazineContext context)
        {
            _context = context;
        }

      public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Client == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);
            if (client == null)
            {
                return NotFound();
            }
            else 
            {
                Client = client;
            }
            return Page();
        }
    }
}
