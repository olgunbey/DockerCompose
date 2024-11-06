using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB.API.Data;

namespace WEB.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public UserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpPost]
        public IActionResult AddUser()
        {
            _appDbContext.Add(new User() { Username = "mehmet" });
            _appDbContext.SaveChanges();
            return Ok();
        }
    }
}
