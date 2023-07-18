using APIsTrainME.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIsTrainME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {

        public static List<Trainer> trainers = new List<Trainer>
        {
            new Trainer
            {
                TrainerId = 1,
                Name = "Luca",
                Edad = 35,
                Experiencia = 10,
                Especialidad = "skdhhadhass",
                Descripcion = "123",
                Calificacion = 5


            },
            new Trainer
            {
                TrainerId = 2,
                Name = "Trainer1",
                Edad = 35,
                Experiencia = 10,
                Especialidad = "skdhhadhass",
                Descripcion = "123",
                Calificacion = 5
            }
        };


        [HttpPost("AddTrainer")]
        public async Task<ActionResult<List<Trainer>>> AddTrainer(Trainer trainer)
        {
            trainers.Add(trainer);
            return Ok(trainers);
        }

        [HttpPut("UpdateTrainer")]
        public async Task<ActionResult<List<Trainer>>> UpdateTrainer(Trainer trainer)
        {
            var user = trainers.Find(t=>t.TrainerId ==trainer.TrainerId);

            if(user != null)
            {
                return BadRequest($"Entrenador {trainer.Name} No fue encontrado");
            }

            user.Name = trainer.Name;
            user.Edad = trainer.Edad;
            user.Experiencia = trainer.Experiencia;
            user.Especialidad = trainer.Especialidad;
            user.Descripcion = trainer.Descripcion;
            user.Calificacion = trainer.Calificacion;

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Trainer>>> DeleteTrainer(int trainerId)
        {
            var user = trainers.Find(t => t.TrainerId == trainerId);

            if(user != null)
            {
                return BadRequest($"Usuario no encontrado");
            }

            trainers.Remove(user);

            return Ok($"Usuario {user} Borrado");
        }

    }
}
