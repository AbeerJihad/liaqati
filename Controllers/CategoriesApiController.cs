namespace liaqati_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesApiController : ControllerBase
    {
        private readonly LiaqatiDBContext _context;

        public CategoriesApiController(LiaqatiDBContext context)
        {
            _context = context;
        }


        [HttpGet("AllCategories")]

        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            if (_context.TblCategory == null)
            {
                return NotFound();
            }
            return await _context.TblCategory.ToListAsync();
        }

        [HttpGet("GetCategory/{id}")]
        public async Task<ActionResult<Category>> GetCategory(string id)
        {
            if (_context.TblCategory == null)
            {
                return NotFound();
            }
            var category = await _context.TblCategory.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        [HttpPut("UpdateCategroy/{id}")]
        public async Task<IActionResult> UpdateCategroy(string id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("AddCategory")]
        public async Task<ActionResult<Category>> AddCategory(Category category)
        {
            if (_context.TblCategory == null)
            {
                return Problem("Entity set 'LiaqatiDBContext.TblCategory'  is null.");
            }
            _context.TblCategory.Add(category);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CategoryExists(category.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            if (_context.TblCategory == null)
            {
                return NotFound();
            }
            var category = await _context.TblCategory.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.TblCategory.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(string id)
        {
            return (_context.TblCategory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
