#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vaccinated_Profile.Data;
using Vaccinated_Profile.Profile;

namespace Vaccinated_Profile.Pages.Profiles
{
    public class DetailsModel : PageModel
    {
        private readonly Vaccinated_Profile.Data.Vaccinated_ProfileContext _context;

        public DetailsModel(Vaccinated_Profile.Data.Vaccinated_ProfileContext context)
        {
            _context = context;
        }

        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
