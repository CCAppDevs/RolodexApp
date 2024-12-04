using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace RolodexApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClaimController : ControllerBase
    {

        public ClaimController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Data test = new Data
            //{
            //    Name = User.ToJson(),
            //}
            return Ok(User.Claims.Select(c => new
            {
                Type = c.Type,
                Value = c.Value
            }));
        }
    }

    public class Data
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
