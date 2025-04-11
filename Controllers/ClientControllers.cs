using Microsoft.AspNetCore.Mvc;
using AMLWatch.Models;
using AMLWatch.DTOs;
using AMLWatch.Data;

namespace AMLWatch.Controllers;

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
    public ActionResult<List<ClientDTO>> GetAll()
    {
        List<ClientDTO> clients = [.. _context.Clients.Select(c => new ClientDTO(c.Id, c.Username, c.Email, null))];

        return Ok(clients);
    }

    [HttpPost]
    public ActionResult<ClientDTO> Create([FromBody] LoginDTO dto)
    {
        var client = new Client(dto.Username, dto.FirstName, dto.LastName, dto.Email, dto.PasswordHash);

        _context.Clients.Add(client);
        _context.SaveChanges();

        var result = new ClientDTO(client.Id, client.Username, client.Email, null);
        return CreatedAtAction(nameof(GetAll), new { id = client.Id }, result);
    }
}
