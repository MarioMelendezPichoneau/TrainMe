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
        
        public readonly ITrainMeService _trainMeService;

        public TrainmeController(ITrainMeService trainMeService)
        {
            _trainMeService = trainMeService;
        }


        [HttpPost("Agerdar")]

        public async Task<ActionResult<List<RecervarSesion>>> Agendar(Agendar ag)
        {
            //var user = usuarios.Find(u => u.UserId == ag.UserId);
            //var trainer = trainers.Find(u => u.TrainerId == ag.TrainerId);

            var agendar = await _trainMeService.Agendar(ag);

            if (agendar is null)
            {
                return BadRequest("Agenda no encontrada");
            }

            return Ok(agendar);


            //agendar.Add(new RecervarSesion
            //{
            //    Id = ag.Id,
            //    Date = ag.Date,
            //    Location = ag.Location,
            //    TipoEntrenamiento = ag.TipoEntrenamiento,
            //    Trainer = trainer,
            //    User = user



            //});




            //return Ok(agendar);
        }


        [HttpGet("verAgenda/{id}")]
        public async Task<ActionResult<List<Usuario>>> Getagendar(int id)
        {
            //var agenda = usuarios.Find(h => h.UserId == id);


            //var trainer = await _context.SuperHeroes.FindAsync(userSh);

            var agenda = await _trainMeService.Getagendar(id);
            if (agenda is null)
            {
                return BadRequest($"Usuario no encontrado {id}");
            }

            return Ok(agenda);
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
            var usuarios = await _trainMeService.GetAllUsers();
            return Ok(usuarios);
        }


        // -------------------------------------method to find a trainer by name--------------------------------------------------- 

        [HttpGet("BuscarTrainer")]
        public async Task<ActionResult<List<Trainer>>> Get(string userSh)
        {

            //var user = usuarios.Find(h => h.Name == userSh);

            var user = await _trainMeService.Get(userSh);

            if (user is null)
            {
                return BadRequest($"Usuario no encontrado {userSh}");
            }

            return Ok(user);
        }

        // -----------------------------------------------method to add usuario-----------------------------------------------------------/

        [HttpPost("registarUsuario")]
        public async Task<ActionResult<List<Usuario>>> AddUser(Usuario registarUsuario)
        {
            //usuarios.Add(hero);

            var usuarios = await _trainMeService.AddUser(registarUsuario);
            if (usuarios != null)
                return Ok($"usario {registarUsuario.Name} creado");
            
            
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
            //var user = usuarios.Find(h => h.Email == request.Email);

            var user = await _trainMeService.Login(request);


            if (user is null)
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

        [HttpPut("UpdateUsuario")]
        public async Task<ActionResult<List<Usuario>>> UpdateUauario(Usuario request)
        {
            //var user = usuarios.Find(h => h.UserId == request.UserId);

            var user = await _trainMeService.UpdateUsuario(request);
            if (user is null)
            {
                return BadRequest("Usuario not find");
            }
            
           

            //await _context.SaveChangesAsync();


            return Ok(user);

            //return Ok(await _context.SuperHeroes.ToArrayAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Usuario>>> DeleteUsers(int id)
        {
            //var hero = usuarios.Find(h => h.UserId == id);

            var hero = await _trainMeService.DeleteUsers(id);
            if (hero is null)
            {
                return BadRequest("Usuario no encontrado");
            }

            return Ok(hero);

            //_context.SuperHeroes.Remove(hero);

            //return Ok(await _context.SuperHeroes.ToArrayAsync());
        }
    }
}
