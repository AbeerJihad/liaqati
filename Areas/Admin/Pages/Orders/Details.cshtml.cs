using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using liaqati_master.Data;
using liaqati_master.Models;

namespace liaqati_master.Areas.Admin.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public DetailsModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.TblOrder
                .Include(o => o.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
