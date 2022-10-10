using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ghani_Projet_ASP.NET_802.Data;
using Ghani_Projet_ASP.NET_802.modeles;

namespace Ghani_Projet_ASP.NET_802.Pages.employes
{
    public class EditModel : PageModel
    {
        private readonly Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context _context;

        public EditModel(Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Employes Employes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employes = await _context.Employes.FirstOrDefaultAsync(m => m.EmployeID == id);

            if (Employes == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployesExists(Employes.EmployeID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployesExists(int id)
        {
            return _context.Employes.Any(e => e.EmployeID == id);
        }
    }
}
