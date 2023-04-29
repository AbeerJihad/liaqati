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
    public class IndexModel : PageModel
    {
        private readonly liaqati_master.Data.LiaqatiDBContext _context;

        public IndexModel(liaqati_master.Data.LiaqatiDBContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.TblOrder
                .Include(o => o.User).ToListAsync();
        }
    }
}
