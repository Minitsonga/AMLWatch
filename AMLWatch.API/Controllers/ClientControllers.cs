using Microsoft.AspNetCore.Mvc;
using AMLWatch.Core.Models;
using AMLWatch.Infrastructure;
using AMLWatch.Core.DTOs;

namespace AMLWatch.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly AMLWatchDbContext _context;

    public ClientController(AMLWatchDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ClientDTO>> GetAll()
    {
        var clients = _context.Clients
            .Select(c => new ClientDTO(c.Id, c.Username, c.Email, c.Address))
            .ToList();

        return Ok(clients);
    }

    [HttpPost]
    public IActionResult Create([FromBody] LoginDTO dto)
    {
        var client = new Client(dto.Username, dto.FirstName, dto.LastName, dto.Email, dto.PasswordHash);


        _context.Clients.Add(client);
        _context.SaveChanges();

        var result = new ClientDTO(client.Id, client.Username, client.Email, client.Address);
        return CreatedAtAction(nameof(GetAll), new { id = client.Id }, result);
    }
}
