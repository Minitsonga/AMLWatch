using AMLWatch.Core.Models;

namespace AMLWatch.Core.DTOs
{
    public record AdressDTO(
        string Street,
         string City,
          string ZipCode,
           string Country);

}