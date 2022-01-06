using System.ComponentModel.DataAnnotations;

namespace invoice_backend_net6.domain.entities;

public class City
{
    public int Id { get; set; }
    [Required]
    public string CityName { get; set; }
    
    // FK (nullable)
    public Province? Province { get; set; }
}
