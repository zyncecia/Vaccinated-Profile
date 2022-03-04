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
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly Vaccinated_Profile.Data.Vaccinated_ProfileContext _context;

        public IndexModel(Vaccinated_Profile.Data.Vaccinated_ProfileContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
