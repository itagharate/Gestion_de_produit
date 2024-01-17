using System;
using System.Collections.Generic;

namespace Gestion_Produit.Models;

public partial class Produit
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    public string? Description { get; set; }

    public decimal? Prix { get; set; }

    public string? Categorie { get; set; }

    public int? Stock { get; set; }

    public string? Image { get; set; }
}
