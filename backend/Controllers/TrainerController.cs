using APIsTrainME.Models;
using APIsTrainME.Models.ModelService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIsTrainME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {

       public readonly ITrainMeService _trainMeService;

        public TrainerController(ITrainMeService trainMeService)
        {
            _trainMeService = trainMeService;
            
        }


        [HttpPost("AddTrainer")]
        public async Task<ActionResult<List<Trainer>>> AddTrainer(Trainer trainer)
        {
            var result = _trainMeService.AddTrainer(trainer);
            return Ok(result);
        }

        [HttpPut("UpdateTrainer")]
        public async Task<ActionResult<List<Trainer>>> UpdateTrainer(Trainer trainer)
        {
            var user = _trainMeService.UpdateTrainer(trainer);

            if(user is null)
            {
                return NotFound($"Entrenador {trainer.Name} No fue encontrado");
            }

            

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Trainer>>> DeleteTrainer(int trainerId)
        {
            var user = _trainMeService.DeleteTrainer(trainerId);

            if(user is null)
            {
                return NotFound($"Usuario no encontrado");
            }


            return Ok($"Usuario {user} Borrado");
        }

    }
}
