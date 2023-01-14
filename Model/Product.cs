using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tokonyadia.Model;
[Table(name:"m_product")]
public class Product
{
    [Key,Column(name:"id")]
    public int Id { get; set; }
    [Column(name:"product_name")]
    public string ProductName { get; set; }
    [Column(name:"description")]
    public string Description {get;set;}

    public ICollection<ProductPrice> ProductPrices { get; set; }
}