using CSharpAPI.Data;
using CSharpAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DestinysController : ControllerBase
  {
    private readonly DataContext _dataContext;

    public DestinysController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    [Route("/GetAllDestinys")]
    public async Task<ActionResult<IEnumerable<Destiny>>> GetAllDestinys()
    {
        return await _dataContext.Destinys.ToListAsync();
    }
  }
}