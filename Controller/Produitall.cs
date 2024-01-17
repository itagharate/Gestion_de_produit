using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gestion_Produit.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class Produitall : ControllerBase
    {
        private readonly BasealpachinoContext _context;
        public Produitall(BasealpachinoContext context)
        {
            _context = context;
        }

        [HttpPost]

        public IActionResult postProduit(Postdto dto)
        {
            var produit = new Produit
            {
                Id = dto.Id,
                Titre = dto.Titre,
                Categorie = dto.Categorie,
                Description = dto.Description,
                Prix = dto.Prix,
                Stock = dto.Stock,
                Image = dto.Image,

            };
            _context.Add(produit);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetProduit()
        {
            var Produits = _context.Produits.ToList();
            return Ok(Produits);

        }
        [HttpPut("{id}")]
        public IActionResult PutProduit(Postdto dto, int id) 
        {
            var produit =  _context.Produits.SingleOrDefault(p => p.Id == id);

            if (postProduit == null)
            {
                return BadRequest("le produit existe pas ");
            }
            produit.Id = dto.Id;
            produit.Titre = dto.Titre;
            produit.Prix = dto.Prix;
            produit.Stock = dto.Stock;
            produit.Image = dto.Image;  
            produit.Categorie = dto.Categorie;
            produit.Description = dto.Description;

            _context.SaveChanges();
            return Ok(produit);    

        }

        [HttpDelete("{id}")]

        public IActionResult DeleteProduit(int id)
        {
            var produit = _context.Produits.SingleOrDefault(p => p.Id == id);
            if (postProduit == null)
            {
                return BadRequest("le produit existe pas ");
            }
            _context.Remove(produit);
            _context.SaveChanges();
            return Ok(produit);


        }

    }
}
