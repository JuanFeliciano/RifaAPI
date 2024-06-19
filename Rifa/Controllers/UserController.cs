using Microsoft.AspNetCore.Mvc;
using Users_Domain.Entities;
using User_Infrastructure;

namespace Rifa.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserDbContext _db;

        public UserController(UserDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _db.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            var users = _db.Users.Add(user);
            _db.SaveChanges();

            return Ok(users.Entity);
        }
    }
}
