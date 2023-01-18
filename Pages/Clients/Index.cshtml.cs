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
    public class IndexModel : PageModel
    {
        private readonly Torok_Erika_Magazine.Data.Torok_Erika_MagazineContext _context;

        public IndexModel(Torok_Erika_Magazine.Data.Torok_Erika_MagazineContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Client != null)
            {
                Client = await _context.Client.ToListAsync();
            }
        }
    }
}
