using APIsTrainME.Models;
using APIsTrainME.Models.ModelService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIsTrainME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainmeController : ControllerBase
    {

        public static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario
            {
                UserId = 1,
                Name = "Test",
                Email = "tes1@gmail.com",
                Password = "123"
                
                
            }, 
            new Usuario
            {
                UserId = 2,
                Name = "Test 2",
                Email = "tes2@gmail.com",
                Password = "456"
            }
        };

        public static List<Trainer> trainers = new List<Trainer>
        {
            new Trainer
            {
                TrainerId = 1,
                Name = "Trainer1",
                Edad = 35,
                Experiencia = 35,
                Especialidad = "skdhhadhass",
                Descripcion = "123",
                Calificacion = 5


            },
            new Trainer
            {
                TrainerId = 2,
                Name = "Trainer2",
                Edad = 35,
                Experiencia = 10,
                Especialidad = "skdhhadhass",
                Descripcion = "123",
                Calificacion = 5
            }
        };
        public static List<RecervarSesion> agendar = new List<RecervarSesion>
        {

            
        };


        [HttpPost("Agerdar")]

        public async Task<ActionResult<List<RecervarSesion>>> Agendar(Agendar ag)
        {
            var user = usuarios.Find(u => u.UserId == ag.UserId);
            var trainer = trainers.Find(u => u.TrainerId == ag.TrainerId);

            if(user == null & trainer == null)
            {
                return BadRequest("users not faund");
            }


            agendar.Add(new RecervarSesion
            {
                Id = ag.Id,
                Date = ag.Date,
                Location = ag.Location,
                TipoEntrenamiento = ag.TipoEntrenamiento,
                Trainer = trainer,
                User = user



            });




            return Ok(agendar);
        }

        // GET: api/trainme
        [HttpGet("Welcome")]
        public IActionResult Get()
        {
            return Ok("Welcome to TrainMeAPI!");
        }

        // GET: api/getsuario
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetAllUsers()
        {   
            return Ok(usuarios);
        }


        // -------------------------------------method to find a trainer by name--------------------------------------------------- 

        [HttpGet("Buscar")]
        public async Task<ActionResult<List<Trainer>>> Get(string userSh)
        {
            var user = usuarios.Find(h => h.Name == userSh);

            //var trainer = await _context.SuperHeroes.FindAsync(userSh);
            if (user == null)
            {
                return BadRequest($"Usuario no encontrado {userSh}");
            }

            return Ok(user);
        }

        // -----------------------------------------------method to add usuario-----------------------------------------------------------/

        [HttpPost]
        public async Task<ActionResult<List<Usuario>>> AddUser(Usuario hero)
        {
            usuarios.Add(hero);

            return Ok(usuarios);

            ////_context.SuperHeroes.Add(hero);
            ////await _context.SaveChangesAsync();
            ////return Ok(await _context.SuperHeroes.ToArrayAsync());
        }

        // --------------------------------------------Login usuario ---------------------------------------------------------------///
        [HttpPost("Login")]
        public async Task<ActionResult<List<Usuario>>> Login(UserLoginService request)
        {
            //var userpaciente = await _context.Pacientes.FirstOrDefaultAsync(u => u.Email == request.Email);
            var user = usuarios.Find(h => h.Email == request.Email);



            if (user == null)
            {
                return BadRequest($"Usuario no encontrado: {request.Email}");

            }
            else if (user.Password != request.Password)
            {
                return BadRequest("Clave Incorrecta");
            }
            else
            {
                return Ok($"Bienvenido de regreso, {user.Name}! :)");
            }


        }



        // method to update user 

        [HttpPut]
        public async Task<ActionResult<List<Usuario>>> UpdateHero(Usuario request)
        {
            var user = usuarios.Find(h => h.UserId == request.UserId);

            //var hero = await _context.SuperHeroes.FindAsync(request.Id);
            if (user == null)
            {
                return BadRequest("Usuario not find");
            }
            user.Name = request.Name;
            user.Email = request.Email;
            user.Password = request.Password;
           

            //await _context.SaveChangesAsync();


            return Ok(user);

            //return Ok(await _context.SuperHeroes.ToArrayAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Usuario>>> DeleteUsers(int id)
        {
            var hero = usuarios.Find(h => h.UserId == id);

            //var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
            {
                return BadRequest("Hero not find");
            }

            usuarios.Remove(hero);

            return Ok(usuarios);

            //_context.SuperHeroes.Remove(hero);

            //return Ok(await _context.SuperHeroes.ToArrayAsync());
        }
    }
}
