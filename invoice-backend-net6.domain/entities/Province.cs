using System.ComponentModel.DataAnnotations;

namespace invoice_backend_net6.domain.entities;

public class Province
{
    public int Id { get; set; }
    [Required]
    public string ProvinceName { get; set; }
    
    // FK (nullable)
    public int? CountryId { get; set; }
    public Country? Country { get; set; }
}
