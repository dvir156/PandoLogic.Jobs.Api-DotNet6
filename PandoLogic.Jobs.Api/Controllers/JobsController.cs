using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PandoLogic.Jobs.Api.Data;
using PandoLogic.Jobs.Api.Models;

namespace PandoLogic.Jobs.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly JobContext _context;

        public JobsController(JobContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<JobData>>> Get()
        {
            return Ok(await _context.Jobs.ToListAsync());
        }
    }
}
