using Microsoft.AspNetCore.Mvc;
using morleys_backend.Data;
using morleys_backend.Models.DbModels;
using morleys_backend.Models.Dto;

namespace morleys_backend.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly DatabaseContext _context ;
        
        public ProductController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
       public ActionResult<string> fetchProducts()
        {
            var resp = _context.Products.ToList();
            return Ok(resp);

        }

        [HttpPost]
        public ActionResult<string> postProducts(AddProductDto prodDto)
        {
            Product prod = new Product
            {
                Name = prodDto.Name,
                Description = prodDto.Description,
                Price = prodDto.Price,
                Quantity = prodDto.Quantity,
                AddedAt = DateTime.Now,
                Category = prodDto.Category,
                ImageUrl = prodDto.ImageUrl,
                Discount = prodDto.Discount,

            };
            _context.Products.Add(prod);
            _context.SaveChanges();
            return Ok(prod);
        }
    }
}
