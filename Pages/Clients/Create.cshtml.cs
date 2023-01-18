﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Torok_Erika_Magazine.Data;
using Torok_Erika_Magazine.Models;

namespace Torok_Erika_Magazine.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly Torok_Erika_Magazine.Data.Torok_Erika_MagazineContext _context;

        public CreateModel(Torok_Erika_Magazine.Data.Torok_Erika_MagazineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}