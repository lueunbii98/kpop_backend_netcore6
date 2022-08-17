using Microsoft.AspNetCore.Mvc;
using KpopProject.Context;

namespace KpopProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : Controller
    {
        private readonly KpopDbContext _context;

        public MemberController(KpopDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_context.Member);
        }
    }
}
