using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_Produit.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Produit : ControllerBase
    {
        private readonly BasealpachinoContext _context;
        public Produit (BasealpachinoContext context)
        {
            _context = context;
        }

        
    }
}
