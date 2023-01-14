using System.Data;

namespace Tokonyadia.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



[Table("customer",Schema = "dbo")]
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "customer id")]
    public int customer_id { get; set; }

    [Column(TypeName = "NVarchar(100)")]
    [Required]
    [Display(Name = "customer_name")]
    public string customer_name { get; set; } 
    [Display(Name = "phone_number")]
    [Column(TypeName = "NVarchar(14)")]
    public string phone_number { get; set; }    
    [Display(Name = "address")]
    [Column(TypeName = "varchar(250)")]
    public string address { get; set; }   
    
    [Display(Name = "email")]
    [Column(TypeName = "varchar(250)")]
    public string email { get; set; }    
}
