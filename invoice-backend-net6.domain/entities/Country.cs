using System.ComponentModel.DataAnnotations;

namespace invoice_backend_net6.domain.entities;

public class Country
{
    public int Id { get; set; }
    [Required]
    public string CountryName { get; set; }
}
