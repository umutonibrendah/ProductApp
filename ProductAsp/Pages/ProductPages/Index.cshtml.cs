using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductAsp.Data;
using ProductAsp.Models;

namespace ProductAsp.Pages_ProductPages
{
    public class IndexModel : PageModel
    {
        private readonly ProductAsp.Data.ProductsContext _context;

        public IndexModel(ProductAsp.Data.ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
