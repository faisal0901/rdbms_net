namespace Tokonyadia.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Store
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "store_id")]
    public int store_id { get; set; }

    [Column(TypeName = "NVarchar(100)")]
    [Required]
    [Display(Name = "store_name")]
    public string store_name { get; set; } 
    [Display(Name = "phone_number")]
    [Column(TypeName = "NVarchar(14)")]
    public string phone_number { get; set; }    
    [Display(Name = "address")]
    [Column(TypeName = "varchar(250)")]
    public string address { get; set; }   
    
    [Display(Name = "siup_number")]
    [Column(TypeName = "varchar(250)")]
    public string siup_number { get; set; }    
}