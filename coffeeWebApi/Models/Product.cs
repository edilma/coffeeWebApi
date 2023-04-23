using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
#nullable disable
using System.Text.Json.Serialization;

namespace coffeeWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}
