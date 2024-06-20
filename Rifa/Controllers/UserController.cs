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

            try
            {
                return Ok(users);

            }
            catch (Exception e)
            {

                return BadRequest($"Não foi possivel realizar a requisição - {e}");
            }
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(User user)
        {
            try
            {
                var users = _db.Users.Add(user);
                _db.SaveChanges();

                return Ok(users.Entity);
            }
            catch (Exception e)
            {

                return BadRequest($"Não foi possivel realizar a requisição - {e}");
            }
        }

        [HttpPut]
        [Route("updt")]
        public IActionResult Update(int id, User user)
        {
            var item = _db.Users.Find(id);

            if (item is null)
            {
                return NotFound("Usuário não encontrado!");
            }

            try
            {
                item.Nome = user.Nome;
                item.Sobrenome = user.Sobrenome;
                item.Email = user.Email;
                item.CPF = user.CPF;
                _db.SaveChanges();
                return Ok($"Usuário alterado com sucesso!\n {user}");
            }
            catch (Exception e)
            {

                return BadRequest($"Dados estão inválidos - {e}");
            }
        }



        [HttpDelete]
        [Route("del")]
        public IActionResult Delete(int id)
        {
            var item = _db.Users.Find(id);

            try
            {
                _db.Users.Remove(item);
                _db.SaveChanges();

                return Ok($"Usuário deletado com sucesso!\n {item.Id} - {item.Nome} - {item.Email}");
            }
            catch (Exception e)
            {

                return NotFound($"Usuário não encontrado - {e}");
            }
        }
    }
}
